Public Class Loading_inicio

    Private Sub Loading_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'reinicio de todas las variables
        modo_pruebas = False
        sin_permisos = False
        Porcentaje.Text = "0 %"
        Porcentaje.Visible = False
        ProgressBar1.Visible = False
        boton_modo.BackColor = SystemColors.MenuText
        Button1.Visible = False

        'carga de valores iniciales 
        Dim idx As Integer
        idx = 0
        For idx = 0 To 999
            N_Folleto_Marca(idx) = "Vino " & idx
            idx = idx + 1
        Next

        'Obtener informacion del usuario que ha iniciado la aplicación para saber donde buscar los datos
        leer_usuario()

        Comprobar_administrador()

    End Sub
    Private Sub Inicio_Click(sender As Object, e As EventArgs) Handles boton_Inicio.Click

        'deshabilitar el volver a pulsar el boton
        boton_Inicio.Enabled = False
        boton_Inicio.Text = "CARGANDO"

        'activar la visualización de la barra de progreso
        Porcentaje.Visible = True
        ProgressBar1.Visible = True

        'animación para generar la barra falsa de progreso
        Timer1.Start()

        'llamada a la rutina para generar audio
        'Tocar_audio_notificacion()
        ' audio_prueba()

        'comprobar permisos del usuario cuando es en modo APP
        If Not modo_pruebas Then
            Comprobar_administrador()
        Else
            'forzar tener permisos para visualizar el modo editor
            sin_permisos = False
        End If

        'llamada a la rutina obtener datos
        Generacion_Datos()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        Porcentaje.Text = "Cargando datos " & ProgressBar1.Value & "%"
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Menu_Principal.Show()
            Timer1.Enabled = False
            Timer1.Stop()
            ProgressBar1.Value = 0

            Porcentaje.Text = "0 %"
            Porcentaje.Visible = False
            ProgressBar1.Visible = False
            boton_Inicio.Enabled = True
            boton_Inicio.Text = "PULSAR PARA INICIAR"

        End If
    End Sub



    Private Sub boton_Inicio_MouseHover(sender As Object, e As EventArgs) Handles boton_Inicio.MouseHover
        'boton_Inicio.Size = New Size(163, 27)
        'boton_Inicio.Location = New Point(186, 12)

    End Sub

    Private Sub boton_Inicio_MouseLeave(sender As Object, e As EventArgs) Handles boton_Inicio.MouseLeave
        'boton_Inicio.Size = New Size(133, 27)
        'boton_Inicio.Location = New Point(209, 12)
    End Sub

    Private Sub boton_modo_Click(sender As Object, e As EventArgs) Handles boton_modo.Click

        'My.Computer.Audio.Play(My.Resources.Close, AudioPlayMode.WaitToComplete)

        'activar el modo pruebas
        If Not modo_pruebas Then
            MsgBox("Modo de prueba activado")
            modo_pruebas = True
            'activar animación en el boton 
            boton_modo.BackColor = Color.Green
        End If
        Button1.Visible = True
    End Sub

    Private Sub b_end_Click(sender As Object, e As EventArgs) Handles b_end.Click

        Dim registro As Byte

        registro = MsgBox("¿Desea apagar la aplicación?", vbYesNo, "Confirmar")
        If registro = vbYes Then
            desconectar_BD()
            Dispose()
            End
        Else
            Return
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'desactivar el modo pruebas
        If modo_pruebas Then
            'MsgBox("Modo de prueba desactivado")
            modo_pruebas = False
            sin_permisos = False
            'activar animación en el boton 
            boton_modo.BackColor = Color.Silver
        End If
        Button1.Visible = False
    End Sub

    Private Sub leer_usuario()
        'ruta de ubicacion de los archivos
        Dim user As Microsoft.VisualBasic.ApplicationServices.User
        user = New Microsoft.VisualBasic.ApplicationServices.User
        Dim usuario() As String = Split(user.Name, "\")

        ruta_usuario_instalacion = usuario(1)

        'RUTA A UTILIZAR EN LA CONEXION CON LOS DATOS
        url_connection_string = "C:\Users\" & usuario(1) & "\Documents\Luis Software\Vinoteca\BD_Bodega_V1.accdb"
    End Sub


    Private Sub Comprobar_administrador()
        'obtener los permisos de usuario que ha iniciado sesion en la aplicación
        Dim win_user = System.Security.Principal.WindowsIdentity.GetCurrent()
        Dim grupo_win_user = New System.Security.Principal.WindowsPrincipal(win_user)

        If (grupo_win_user.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator)) Then
            sin_permisos = False
            b_Visualizacion.Visible = False
            b_Admin.Visible = True
        Else
            sin_permisos = True
            b_Visualizacion.Visible = True
            b_Admin.Visible = False
        End If
    End Sub

End Class