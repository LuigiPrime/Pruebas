Public Class Debug_Aplicacion
    Private Sub Debug_Aplicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New System.Drawing.Size(360, 330) ' size of screen

        Panel_bd.Visible = False
        Panel_RUTAS.Visible = False

        l_unidad_disco.Text = unidad_disco
        l_date.Visible = False

        'Informacion sobre la lectura de los datos desde la base de datos
        If StatusConex Is "Comunicacion OK" Then
            Info_carga.Text = "Lectura de datos correcta"
            Info_carga.BackColor = System.Drawing.Color.LimeGreen
        Else
            Info_carga.Text = "Fallo en la carga datos"
            Info_carga.BackColor = System.Drawing.Color.OrangeRed
        End If

        Label1.Text = "Version V10 - 2022/05/16"
        Label2.Text = url_connection_string
        Label3.Text = Ruta_BD
        Label5.Text = ruta_usuario_instalacion
        Label6.Text = Ruta_DO
        Label7.Text = Ruta_Logos_DO
        Label15.Text = URL_help_document

        If modo_pruebas Then
            l_pruebas.Visible = True
        Else
            l_pruebas.Visible = False
        End If

    End Sub

    Private Sub b_ON_Click(sender As Object, e As EventArgs)

        Info_carga.Text = "Restableciendo conexion"

        enlace_BD()

        'Informacion sobre la lectura de los datos desde la base de datos
        If StatusConex Is "Comunicacion OK" Then
            Info_carga.Text = "Carga de datos correcta"
            Info_carga.BackColor = System.Drawing.Color.LimeGreen
        Else
            Info_carga.Text = "Fallo en la carga datos"
            Info_carga.BackColor = System.Drawing.Color.OrangeRed
        End If

    End Sub

    Private Sub b_OFF_Click(sender As Object, e As EventArgs)

        Info_carga.Text = "Apagando conexion"

        desconectar_BD()
        'Informacion sobre la lectura de los datos desde la base de datos
        If StatusConex Is "Comunicacion OK" Then
            Info_carga.Text = "Carga de datos correcta"
            Info_carga.BackColor = System.Drawing.Color.LimeGreen
        Else
            Info_carga.Text = "Fallo en la carga datos"
            Info_carga.BackColor = System.Drawing.Color.OrangeRed
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b_BackUp.Click

        Dim byte_operation As Byte

        byte_operation = MsgBox("Esta seguro que quiere crear una copia de seguridad de la base de datos", vbYesNo, "Confirmar")

        If byte_operation = vbYes Then
            'llamar a la funcion para crear una copia de seguridad
            desconectar_BD()
            Backup_BD()
            l_date.Text = "copia seguridad realizada"
            l_date.Visible = True
        Else
            MsgBox("Cancelada la operacion creacion copia de seguridad", vbInformation, "Cancelacion")
            l_date.Text = "copia seguridad NO realizada"
            l_date.Visible = True
        End If

        'Me.Dispose()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim byte_operation As Byte

        byte_operation = MsgBox("Esta seguro que quiere borrar el directorio de copias de seguridad", vbYesNo, "Confirmar")

        If byte_operation = vbYes Then
            'llamar a la funcion para crear una copia de seguridad
            desconectar_BD()
            Clear_Backup_BD()
            l_date.Text = "limpieza directorio backup realizada"
            l_date.Visible = True
        Else
            MsgBox("Cancelada la operacion limpieza directorio copia de seguridad", vbInformation, "Cancelacion")
            l_date.Text = "limpieza directorio backup cancelada"
            l_date.Visible = True
        End If

        'Me.Dispose()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_bd.Visible = True
        Panel_RUTAS.Visible = True


        Me.Size = New System.Drawing.Size(1120, 492) ' size of screen

    End Sub
End Class