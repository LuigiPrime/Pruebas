Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_Huecos_Principal

    'variable para saber que id de DO queremos visualizar 
    Dim str_show_hueco As String
    Dim int_show_hueco As Integer
    Private Sub Huecos_completosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Editor_Huecos_Modificar.Show()

    End Sub

    Private Sub Editor_Huecos_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Huecos_completos' Puede moverla o quitarla según sea necesario.
        Me.Huecos_completosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Huecos_completos)

        'para visualizar el numero de elementos que disponemos registrados
        BindingNavigatorCountItem.Text = tabla_huecos.Rows.Count.ToString

        'ocultar visualizacion de detalle
        PanelHueco.Visible = False

        'ocultar visualizacion de detalle
        PanelVino.Visible = False

    End Sub

    Private Sub b_Modificar_Click(sender As Object, e As EventArgs) Handles b_Modificar.Click
        Editor_Huecos_Modificar.Show()
    End Sub

    Private Sub b_Refrescar_Click(sender As Object, e As EventArgs) Handles b_Refrescar.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Huecos_completos' Puede moverla o quitarla según sea necesario.
        Me.Huecos_completosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Huecos_completos)

        actualizar_show()
    End Sub


    Private Sub show_register()


        'Me.Size = New Size(884, 583)
        int_show_hueco = Huecos_completosDataGridView.CurrentRow.Cells(0).Value

        Show_ID.Text = Huecos_completosDataGridView.CurrentRow.Cells(0).Value.ToString
        str_show_hueco = Show_ID.Text

        PanelHueco.Visible = True
        PanelVino.Visible = True

        index_hueco_modificar = int_show_hueco


        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If str_show_hueco <> " " Then

            consulta = "Select *From Huecos_completos where Id_Hueco =" & int_show_hueco & ""

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Huecos_completos")

            registro = ods.Tables("Huecos_completos").Rows.Count

        Else
            MsgBox("No se ha introducido un ID de hueco existente", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then

            Show_ID.Text = ods.Tables("Huecos_completos").Rows(0).Item("ID_Hueco")
            show_Comentario_hueco.Text = ods.Tables("Huecos_completos").Rows(0).Item("Comentario")
            show_Zona.Text = ods.Tables("Huecos_completos").Rows(0).Item("Zona")
            Show_uso.Text = ods.Tables("Huecos_completos").Rows(0).Item("Coleccion")

            'animacion para visualizar el uso
            If Show_uso.Text = "True" Then
                UsoRadioButton.Checked = True
            Else
                UsoRadioButton.Checked = False
            End If

            Show_ID_Vino.Text = ods.Tables("Huecos_completos").Rows(0).Item("Vino")

            If Show_ID_Vino.Text <> "VACIO" Then
                'llamada consulta informacion del vino
                show_vino()
            Else
                PanelVino.Visible = False
                show_Marca.Text = ""
                show_Maduracion.Text = ""
                show_Year.Text = ""
                show_Tipo.Text = ""
                show_Comentario_vino.Text = ""
                show_DO.Text = ""
                Show_photo_name.Text = ""
            End If

        End If
        desconectar_BD()

    End Sub


    Private Sub show_vino()
        'activar enlace con la base de datos
        enlace_BD()

        Dim consulta_vino As String
        Dim oda_vino As New OleDbDataAdapter
        Dim ods_vino As DataSet
        Dim registro_vino As Byte

        If Show_ID_Vino.Text <> " " Then

            consulta_vino = "Select *From Vinos where Id_Vino ='" & Show_ID_Vino.Text & "'"

            oda_vino = New OleDbDataAdapter(consulta_vino, Conection)
            ods_vino = New DataSet
            oda_vino.Fill(ods_vino, "Vinos")

            registro_vino = ods_vino.Tables("Vinos").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar el vino en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro_vino <> 0 Then

            Show_ID_Vino.Text = ods_vino.Tables("Vinos").Rows(0).Item("Id_Vino")
            show_Marca.Text = ods_vino.Tables("Vinos").Rows(0).Item("Marca")
            show_Maduracion.Text = ods_vino.Tables("Vinos").Rows(0).Item("Maduracion")
            show_Year.Text = ods_vino.Tables("Vinos").Rows(0).Item("Año")
            show_Tipo.Text = ods_vino.Tables("Vinos").Rows(0).Item("Tipo")
            show_Comentario_vino.Text = ods_vino.Tables("Vinos").Rows(0).Item("Comentario")
            show_DO.Text = ods_vino.Tables("Vinos").Rows(0).Item("Denominacion_Origen")
            Show_photo_name.Text = ods_vino.Tables("Vinos").Rows(0).Item("Foto_Etiqueta")

            'para visualizar la foto

            Dim cadena_foto_vino As String
            Dim foto_vino As String
            base_Url_Vinos = Ruta_Vinos

            foto_vino = Show_photo_name.Text
            cadena_foto_vino = base_Url_Vinos & foto_vino

            ''Configuracion de la imagen del vino
            ShowPhotoVino.Load(cadena_foto_vino)
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage

            'visualizar todo los elementos
            PanelVino.Visible = True

        Else
            MsgBox("No existe el codigo", vbCritical, "Aviso")
            'ocultar todos los elementos
            PanelVino.Visible = False
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

    Private Sub Huecos_completosDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Huecos_completosDataGridView.CellClick
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Huecos_completos' Puede moverla o quitarla según sea necesario.
        Me.Huecos_completosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Huecos_completos)

        actualizar_show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Help.ShowHelp(Me, URL_help_document)
    End Sub


End Class