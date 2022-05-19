Public Class Info_Detalle


    Private Sub Info_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' MsgBox("Cargar valores del hueco nº" + " - " + Detalle_ID_Hueco)

        Dim cadena_foto_vino As String
        base_Url_Vinos = Ruta_Vinos
        cadena_foto_vino = base_Url_Vinos & Detalle_Photo_Vino_url

        Dim cadena_foto_DO As String
        base_Url_DO = Ruta_Logos_DO
        cadena_foto_DO = base_Url_DO & Detalle_Photo_DO_url

        ''Transpaso de variables globales a variables locales para su visualización
        If Detalle_ID_Hueco <> "" Then
            Show_ID_Hueco.Text = Detalle_ID_Hueco.ToString
        Else
            Show_ID_Hueco.Text = "ID_Hueco"
        End If

        'tenemos vino en el hueco
        If Detalle_Marca <> "MARCA" Then
            Show_Marca.Text = Detalle_Marca.ToString
            Show_Coleccion.Visible = True
            Show_Tipo.Visible = True
            Show_year.Visible = True
            Show_Maduracion.Visible = True
            Show_Denominacion.Visible = False
            Label4.Visible = True
            Label5.Visible = True
            Label6.Visible = True
            Label7.Visible = True
            Panel_Photo.Visible = True
            Panel_Detalle.Visible = True
            Panel_DO.Visible = True
        Else
            Show_Marca.Text = "HUECO VACIO"
            Show_Coleccion.Visible = False
            Show_Tipo.Visible = False
            Show_year.Visible = False
            Show_Maduracion.Visible = False
            Show_Denominacion.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Panel_Detalle.Visible = False
            Panel_Photo.Visible = False
            Panel_DO.Visible = False
        End If

        Show_Maduracion.Text = Detalle_Maduracion
        Show_Denominacion.Text = Detalle_Denominacion
        Show_Tipo.Text = Detalle_Tipo.ToString
        Show_year.Text = Detalle_Year.ToString

        'ocultar el boton para acceder a la información de la denominacion si no tiene 
        If Detalle_Denominacion = "Sin DO" Then
            Panel_DO.Visible = False
        Else
            Panel_DO.Visible = True
        End If

        If Detalle_Coleccion = True Then
            Show_Coleccion.Text = "COLECCION"
            Show_Coleccion.BackColor = System.Drawing.Color.DeepSkyBlue
        Else
            Show_Coleccion.Text = "CONSUMO"
            Show_Coleccion.BackColor = System.Drawing.Color.White
        End If

        'Show_Coleccion.Text = Detalle_Coleccion

        ''Configuracion de la imagen del vino
        ShowPhotoVino.Load(cadena_foto_vino)
        ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage

        ''Configuracion de la imagen del logo de la deonimacion
        ShowPhotoDO.Load(cadena_foto_DO)
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage

        'PARTE ALMACENADA POR SI SE CONSULTA LA DENOMINACION DE ORIGEN

        Dim cadena_foto_DO_map As String
        base_Url_DO = Ruta_DO
        cadena_foto_DO_map = base_Url_DO & Detalle_Photo_DO_Map_url

        'Temporizador para comprobar si es necesario para cargar los datos
        System.Threading.Thread.Sleep(100)

    End Sub


    Private Sub Show_Tipo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Show_ID_Hueco_TextChanged(sender As Object, e As EventArgs) Handles Show_ID_Hueco.TextChanged

    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'Reset de los valores guardados
        Show_ID_Hueco.Text = "ID_Hueco"
        Show_Marca.Text = "MARCA"
        Show_Maduracion.Text = "MADURACIÓN"
        Show_Denominacion.Text = "DO"
        Show_Tipo.Text = "Tipo"
        Show_Coleccion.Text = "Coleccion"
        Show_year.Text = "Año"

        'Reset de la foto cargada
        ShowPhotoVino.Image = Nothing
        ShowPhotoDO.Image = Nothing

        System.Threading.Thread.Sleep(100)
        Close()
    End Sub



    Private Sub ShowPhotoDO_Click(sender As Object, e As EventArgs) Handles ShowPhotoDO.Click
        'Cerrar por si hay otro abierto
        Info_Detalle_DO.Close()

        'Abrir ventana detalle 
        Info_Detalle_DO.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel_General.Paint

    End Sub
End Class