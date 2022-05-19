Public Class Info_Detalle_DO

    Private Sub Info_Detalle_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cadena_foto_DO As String
        base_Url_DO = Ruta_Logos_DO
        cadena_foto_DO = base_Url_DO & Detalle_Photo_DO_url

        ''Configuracion de la imagen del logo de la denonimacion

        ShowPhotoDO.Load(cadena_foto_DO)
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage


        Show_Denominacion.Text = Detalle_Denominacion


        Dim cadena_foto_DO_map As String
        base_Url_DO = Ruta_DO
        cadena_foto_DO_map = base_Url_DO & Detalle_Photo_DO_Map_url


        ''Configuracion de la imagen del logo de la denonimacion

        ShowPhoto_map.Load(cadena_foto_DO_map)
        ShowPhoto_map.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhoto_map.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Reset de los valores guardados
        '  Show_ID_Hueco.Text = "ID_Hueco"
        '  Show_Marca.Text = "MARCA"
        '  Show_Maduracion.Text = "MADURACIÓN"
        '  Show_Denominacion.Text = "DO"
        '  Show_Tipo.Text = "Tipo"
        '  Show_Coleccion.Text = "Coleccion"
        '  Show_year.Text = "Año"

        'Reset de la foto cargada
        ShowPhoto_map.Image = Nothing
        ShowPhotoDO.Image = Nothing

        System.Threading.Thread.Sleep(100)
        Close()
    End Sub


End Class

