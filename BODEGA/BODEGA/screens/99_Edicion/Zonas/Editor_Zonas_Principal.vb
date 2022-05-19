Public Class Editor_Zonas_Principal
    Private Sub Zonas_almacenamientoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Editor_Zonas_Modificar.Show()

    End Sub

    Private Sub Editor_Zonas_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Zonas_almacenamiento' Puede moverla o quitarla según sea necesario.
        Me.Zonas_almacenamientoTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Zonas_almacenamiento)

        'para visualizar el numero de elementos que disponemos registrados
        ' BindingNavigatorCountItem.Text = tabla_zona.Rows.Count.ToString

        Panel1.Visible = False

    End Sub

    Private Sub b_Insertar_Click(sender As Object, e As EventArgs) Handles b_Insertar.Click
        Editor_Zonas_Insertar.Show()
    End Sub

    Private Sub b_Refrescar_Click(sender As Object, e As EventArgs) Handles b_Refrescar.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Zonas_almacenamiento' Puede moverla o quitarla según sea necesario.
        Me.Zonas_almacenamientoTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Zonas_almacenamiento)

        'para visualizar el numero de elementos que disponemos registrados
        ' BindingNavigatorCountItem.Text = tabla_zona.Rows.Count.ToString

        Panel1.Visible = False
    End Sub

    Private Sub b_Modificar_Click(sender As Object, e As EventArgs) Handles b_Modificar.Click
        Editor_Zonas_Modificar.Show()
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
        show_info_zona()
    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click
        show_info_zona()
    End Sub

    Private Sub BindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMovePreviousItem.Click
        show_info_zona()
    End Sub

    Private Sub BindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveFirstItem.Click
        show_info_zona()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        Editor_Zonas_Insertar.Show()
    End Sub

    Private Sub Zonas_almacenamientoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Zonas_almacenamientoDataGridView.CellContentClick
        show_info_zona()
    End Sub

    Private Sub show_info_zona()

        Show_ID.Text = Zonas_almacenamientoDataGridView.CurrentRow.Cells(0).Value.ToString
        index_zona_modificar = Show_ID.Text

        'habilitar vista del panel de detalle
        Panel1.Visible = True

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If index_zona_modificar <> " " Then

            consulta = "Select *From Zonas_almacenamiento where ID_Zona ='" & index_zona_modificar & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Zonas_almacenamiento")

            registro = ods.Tables("Zonas_almacenamiento").Rows.Count

        Else
            MsgBox("No se ha introducido un ID de una zona para visualizar", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then

            Show_ID.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("ID_Zona")
            show_zona.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("Zona")
            Show_Photo_name.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("Foto_zona")

            'para visualizar la foto

            Dim cadena_foto_zona As String
            Dim foto_zona As String

            foto_zona = Show_Photo_name.Text
            cadena_foto_zona = Ruta_zonas & foto_zona

            ''Configuracion de la imagen del vino
            Show_Zona_Photo.Load(cadena_foto_zona)
            Show_Zona_Photo.SizeMode = PictureBoxSizeMode.CenterImage
            Show_Zona_Photo.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        desconectar_BD()

    End Sub

    Private Sub Zonas_BindingNavigatorRefreshItem_Click(sender As Object, e As EventArgs) Handles Zonas_BindingNavigatorRefreshItem.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Zonas_almacenamiento' Puede moverla o quitarla según sea necesario.
        Me.Zonas_almacenamientoTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Zonas_almacenamiento)

        'para visualizar el numero de elementos que disponemos registrados
        ' BindingNavigatorCountItem.Text = tabla_zona.Rows.Count.ToString

        Panel1.Visible = False
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Help.ShowHelp(Me, URL_help_document)
    End Sub
End Class