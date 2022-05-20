Public Class Editor_DO_Principal

    'variable para saber que id de DO queremos visualizar 
    Dim str_show_DO As String
    Private Sub Editor_DO_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)

        'para visualizar el numero de elementos que disponemos registrados
        BindingNavigatorCountItem.Text = tabla_DO.Rows.Count.ToString

        'ocultar visualizacion de detalle
        Panel1.Visible = False

    End Sub

    Private Sub b_Insertar_Click(sender As Object, e As EventArgs) Handles b_Insertar.Click
        Editor_DO_Insertar.Show()
    End Sub

    Private Sub b_Modificar_Click(sender As Object, e As EventArgs) Handles b_Modificar.Click
        Editor_DO_Modificar.Show()
    End Sub

    Private Sub show_register()

        'Me.Size = New Size(884, 583)

        TextBox1.Text = Denominaciones_OrigenDataGridView.CurrentRow.Cells(0).Value.ToString
        str_show_DO = TextBox1.Text
        index_do_modificar = str_show_DO

        Panel1.Visible = True


        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If str_show_DO <> " " Then

            consulta = "Select *From Denominaciones_Origen where ID_Denominacion ='" & str_show_DO & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Denominaciones_Origen")

            registro = ods.Tables("Denominaciones_Origen").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar la Denominacion en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then

            Show_ID.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("ID_Denominacion")
            show_Informacion.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Informacion")
            Show_DO_Photo_name.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Logo_denominacion")
            Show_MAP_name.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Mapa_ubicacion")

            'para visualizar la foto

            Dim cadena_foto_do As String
            Dim cadena_foto_map As String

            Dim foto_do As String
            Dim foto_map As String

            foto_do = Show_DO_Photo_name.Text
            foto_map = Show_MAP_name.Text

            cadena_foto_do = Ruta_Logos_DO & foto_do
            cadena_foto_map = Ruta_DO & foto_map

            'Configuracion de la imagen del logo de la denominacion de origen
            ShowPhotoDO.Load(cadena_foto_do)
            ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage

            'Configuracion de la imagen con el mapa
            ShowPhotoMAP.Load(cadena_foto_map)
            ShowPhotoMAP.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoMAP.SizeMode = PictureBoxSizeMode.StretchImage

        End If

        desconectar_BD()

        contabilizar_numero_botellas()

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

    Private Sub Denominaciones_OrigenDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Denominaciones_OrigenDataGridView.CellClick
        actualizar_show()
    End Sub

    Private Sub b_Refrescar_Click(sender As Object, e As EventArgs) Handles b_Refrescar.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)

    End Sub


    Private Sub Denominaciones_OrigenBindingNavigatorRefreshItem_Click(sender As Object, e As EventArgs) Handles Denominaciones_OrigenBindingNavigatorRefreshItem.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)
    End Sub

    Private Sub Denominaciones_OrigenBindingNavigatorHelpItem_Click(sender As Object, e As EventArgs) Handles Denominaciones_OrigenBindingNavigatorHelpItem.Click
        Help.ShowHelp(Me, URL_help_document)
    End Sub

    Public Sub contabilizar_numero_botellas()

        'generacion de la consulta numero botellas
        Dim consulta As OleDb.OleDbDataAdapter

        Dim busqueda As String
        busqueda = Show_ID.Text
        'MsgBox(busqueda)

        'activar enlace
        enlace_BD()

        ' Creacion tabla Grid catalogo de Vinos
        consulta = New OleDb.OleDbDataAdapter("SELECT * FROM Vinos WHERE Denominacion_Origen ='" & str_show_DO & "'", Conection)
        tabla_contabilizacion_vinos = New DataTable
        consulta.Fill(tabla_contabilizacion_vinos)

        'desactivar lectura con base de datos
        desconectar_BD()

        'mostrar resultado final
        Show_NumBotellas.Text = tabla_contabilizacion_vinos.Rows.Count

    End Sub
End Class