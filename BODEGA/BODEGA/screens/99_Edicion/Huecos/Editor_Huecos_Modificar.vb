Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_Huecos_Modificar

    'variable para saber que id de DO queremos visualizar 
    Dim str_show_hueco As String
    Dim int_show_hueco As Integer
    Private Sub b_Search_Click(sender As Object, e As EventArgs) Handles b_Search.Click

        'llamada a la funcion para mostrar información del hueco
        show_info_hueco()

    End Sub

    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click

        Dim actualizar As String

        'para el tratamiento del valor número de la columna
        Dim int_columna As Integer
        int_columna = Val(Insert_Columna.Text)

        'conversion del tipo de datos para el uso al ser un booleano
        Dim bool_uso As Boolean
        If Insert_uso.Text = "True" Then
            bool_uso = True
        Else
            bool_uso = False
        End If

        Try
            enlace_BD()
            'actualizar = "UPDATE Huecos_completos SET Fila= '" & Insert_Fila.Text &
            '             "',Columna ='" & Insert_Columna.Text &
            '             "',Comentario ='" & Insert_Comentario_hueco.Text &
            '             "',Zona ='" & Insert_Zona.Text &
            '             "',Vino ='" & Insert_ID_Vino.Text &
            '             "',Coleccion ='" & Insert_uso.Text &
            '               "' WHERE Id_Hueco ='" & Show_ID.Text & "'"

            actualizar = "UPDATE Huecos_completos SET Fila= '" & Insert_Fila.Text &
                         "',Columna =" & int_columna &
                         ",Comentario ='" & Insert_Comentario_hueco.Text &
                         "',Zona ='" & Insert_Zona.Text &
                         "',Vino ='" & Insert_ID_Vino.Text &
                         "',Coleccion =" & bool_uso &
                         " WHERE Id_Hueco =" & int_show_hueco & ""
            'para depuración
            'MsgBox(actualizar)

            Cmd_BD = New OleDbCommand(actualizar, Conection)
            Cmd_BD.ExecuteNonQuery()

            MsgBox("Registro actualizado", vbInformation, "Aviso")
            desconectar_BD()

        Catch ex As Exception
            DisplayOleDbErrorCollection(ex)
            MsgBox("No se puedo actualizar el registro", vbCritical, "Aviso")
            desconectar_BD()
        End Try
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub Editor_Huecos_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Huecos_completos' Puede moverla o quitarla según sea necesario.
        Me.Huecos_completosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Huecos_completos)
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Zonas_almacenamiento' Puede moverla o quitarla según sea necesario.
        Me.Zonas_almacenamientoTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Zonas_almacenamiento)
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Vinos)

        'ocultar todo los elementos
        Panel1.Visible = False
        b_Search.Visible = False

        'no aparezca seleccionado ninguno
        ComboBox1.Text = index_hueco_modificar
        show_info_hueco()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Show_ID.Text = ComboBox1.Text
        show_info_hueco()
    End Sub

    Private Sub ComboBox_ID_Vino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ID_Vino.SelectedIndexChanged

        Insert_ID_Vino.Text = ComboBox_ID_Vino.Text
        show_info_vino()
    End Sub

    Private Sub show_info_hueco()
        'activar enlace con la base de datos
        enlace_BD()

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        'int_show_hueco = Show_ID.Text 'variable tipo integer
        str_show_hueco = Show_ID.Text
        int_show_hueco = Val(str_show_hueco)

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

            DataGridView1.DataSource = ods
            DataGridView1.DataMember = "Huecos_completos"

            Show_ID.Text = ods.Tables("Huecos_completos").Rows(0).Item("ID_Hueco")
            Insert_Fila.Text = ods.Tables("Huecos_completos").Rows(0).Item("Fila")
            Insert_Columna.Text = ods.Tables("Huecos_completos").Rows(0).Item("Columna")
            Insert_Comentario_hueco.Text = ods.Tables("Huecos_completos").Rows(0).Item("Comentario")
            Insert_Zona.Text = ods.Tables("Huecos_completos").Rows(0).Item("Zona")
            Insert_uso.Text = ods.Tables("Huecos_completos").Rows(0).Item("Coleccion")

            'habilitar vista de todo el panel
            Panel1.Visible = True

            'animacion para visualizar el uso
            If Insert_uso.Text = "True" Then
                ColeccionRadioButton.Checked = True
                ConsumoRadioButton.Checked = False
            Else
                ColeccionRadioButton.Checked = False
                ConsumoRadioButton.Checked = True
            End If

            Insert_ID_Vino.Text = ods.Tables("Huecos_completos").Rows(0).Item("Vino")

            If Insert_ID_Vino.Text <> "VACIO" Then
                'llamada consulta informacion del vino
                show_info_vino()
            Else
                PanelVino.Visible = False
                show_Marca.Text = ""
                show_Maduracion.Text = ""
                show_Year.Text = ""
                show_Tipo.Text = ""
                show_Comentario_vino.Text = ""
                show_DO.Text = ""
                Show_photo_name.Text = ""
                ComboBox_ID_Vino.Text = "VACIO"
            End If

        End If
        desconectar_BD()
    End Sub

    Private Sub show_info_vino()
        'activar enlace con la base de datos
        desconectar_BD()
        enlace_BD()

        Dim consulta_vino As String
        Dim oda_vino As New OleDbDataAdapter
        Dim ods_vino As DataSet
        Dim registro_vino As Byte

        If Insert_ID_Vino.Text <> " " Then

            consulta_vino = "Select *From Vinos where Id_Vino ='" & Insert_ID_Vino.Text & "'"

            oda_vino = New OleDbDataAdapter(consulta_vino, Conection)
            ods_vino = New DataSet
            oda_vino.Fill(ods_vino, "Vinos")

            registro_vino = ods_vino.Tables("Vinos").Rows.Count

        Else
            MsgBox("El hueco no tiene informacion de vino correcta", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro_vino <> 0 Then

            Insert_ID_Vino.Text = ods_vino.Tables("Vinos").Rows(0).Item("Id_Vino")
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
            ' MsgBox("No existe el codigo", vbCritical, "Aviso")
            'ocultar todos los elementos
            PanelVino.Visible = False
        End If
        desconectar_BD()

        'mostrar info
        ComboBox_ID_Vino.Text = Insert_ID_Vino.Text

    End Sub

    Private Sub ColeccionRadioButton_Click(sender As Object, e As EventArgs) Handles ColeccionRadioButton.Click

        ConsumoRadioButton.Checked = False
        Insert_uso.Text = "True"
    End Sub

    Private Sub ConsumoRadioButton_Click(sender As Object, e As EventArgs) Handles ConsumoRadioButton.Click

        ColeccionRadioButton.Checked = False
        Insert_uso.Text = "False"
    End Sub
End Class