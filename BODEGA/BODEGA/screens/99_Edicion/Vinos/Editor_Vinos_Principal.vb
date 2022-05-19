Public Class Editor_Vinos_Principal
    Dim str_show_vino As String

    Private Sub VinosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Editor_Vinos_Modificar.Show()
    End Sub

    Private Sub Editor_Vinos_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Vinos)

        'para visualizar el numero de elementos que disponemos registrados
        BindingNavigatorCountItem.Text = tabla_vinos.Rows.Count.ToString

        'ocultar visualizacion de detalle
        Panel1.Visible = False

    End Sub

    Private Sub b_Insertar_Click(sender As Object, e As EventArgs) Handles b_Insertar.Click
        Editor_Vinos_Insertar.Show()
    End Sub

    Private Sub b_Modificar_Click(sender As Object, e As EventArgs) Handles b_Modificar.Click
        Editor_Vinos_Modificar.Show()
    End Sub

    Private Sub b_Refrescar_Click(sender As Object, e As EventArgs) Handles b_Refrescar.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Vinos)
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) 
        Editor_Vinos_Insertar.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles b_Actualizar.Click
        Me.VinosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Vinos)
    End Sub

    Private Sub VinosDataGridView_Cellclick(sender As Object, e As DataGridViewCellEventArgs) Handles VinosDataGridView.CellClick

        show_register()
    End Sub

    Private Sub show_register()

        TextBox1.Text = VinosDataGridView.CurrentRow.Cells(0).Value.ToString
        str_show_vino = TextBox1.Text

        index_vino_modificar = str_show_vino

        Panel1.Visible = True

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If str_show_vino <> " " Then

            consulta = "Select *From Vinos where Id_Vino ='" & str_show_vino & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Vinos")

            registro = ods.Tables("Vinos").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar el vino en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then

            Show_ID.Text = ods.Tables("Vinos").Rows(0).Item("Id_Vino")
            show_Marca.Text = ods.Tables("Vinos").Rows(0).Item("Marca")
            show_Maduracion.Text = ods.Tables("Vinos").Rows(0).Item("Maduracion")
            show_Year.Text = ods.Tables("Vinos").Rows(0).Item("Año")
            show_Tipo.Text = ods.Tables("Vinos").Rows(0).Item("Tipo")
            show_Comentario.Text = ods.Tables("Vinos").Rows(0).Item("Comentario")
            show_DO.Text = ods.Tables("Vinos").Rows(0).Item("Denominacion_Origen")
            ShowPhotoVino.Text = ods.Tables("Vinos").Rows(0).Item("Foto_Etiqueta")

            'para visualizar la foto

            Dim cadena_foto_vino As String
            Dim foto_vino As String
            base_Url_Vinos = Ruta_Vinos

            foto_vino = ShowPhotoVino.Text
            cadena_foto_vino = base_Url_Vinos & foto_vino

            ''Configuracion de la imagen del vino
            ShowPhotoVino.Load(cadena_foto_vino)
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        desconectar_BD()

    End Sub

    Private Sub actualizar_show()
        show_register()
    End Sub
    Private Sub BindingNavigatorMoveNextItem_MouseUp(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.MouseUp
        actualizar_show()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_MouseUp(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.MouseUp
        actualizar_show()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_MouseUp(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.MouseUp
        actualizar_show()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_MouseUp(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.MouseUp
        actualizar_show()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_MouseUp(sender As Object, e As MouseEventArgs) Handles BindingNavigatorMoveFirstItem.MouseUp

    End Sub

    Private Sub BindingNavigatorMovePreviousItem_MouseUp(sender As Object, e As MouseEventArgs) Handles BindingNavigatorMovePreviousItem.MouseUp

    End Sub

    Private Sub BindingNavigatorMoveNextItem_MouseUp(sender As Object, e As MouseEventArgs) Handles BindingNavigatorMoveNextItem.MouseUp

    End Sub

    Private Sub BindingNavigatorMoveLastItem_MouseUp(sender As Object, e As MouseEventArgs) Handles BindingNavigatorMoveLastItem.MouseUp

    End Sub

    Private Sub AyudaToolStripButton_Click(sender As Object, e As EventArgs) Handles AyudaToolStripButton.Click

        Help.ShowHelp(Me, URL_help_document)
    End Sub
End Class