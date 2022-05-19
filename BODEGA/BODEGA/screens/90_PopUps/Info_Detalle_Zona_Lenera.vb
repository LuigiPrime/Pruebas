Public Class Info_Detalle_Zona_Lenera
    Private Sub Info_Detalle_Zona_Lenera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cadena_foto As String

        cadena_foto = Ruta_zonas & "zona_lenera.jpg"

        ''Configuracion de la imagen del logo de la denonimacion

        PictureBox_Zone.Load(cadena_foto)
        PictureBox_Zone.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox_Zone.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub
End Class