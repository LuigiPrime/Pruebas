Public Class Info_Detalle_Zona_Auxiliar
    Private Sub Info_Detalle_Zona_Auxiliar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cadena_foto_1 As String
        cadena_foto_1 = Ruta_zonas & "zona_aux_1.jpg"

        'Carga datos de la foto
        PictureBox_Zone.Load(cadena_foto_1)
        PictureBox_Zone.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox_Zone.SizeMode = PictureBoxSizeMode.StretchImage


        Dim cadena_foto_2 As String
        cadena_foto_2 = Ruta_zonas & "zona_aux_2.jpg"

        'Carga datos de la foto
        PictureBox_Zone_2.Load(cadena_foto_2)
        PictureBox_Zone_2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox_Zone_2.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
End Class