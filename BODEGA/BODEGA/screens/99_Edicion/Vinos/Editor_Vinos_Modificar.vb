Imports System.IO
Imports System.Data
Imports System.Data.OleDb


Public Class Editor_Vinos_Modificar
    Private Sub b_Search_Click(sender As Object, e As EventArgs) Handles b_Search.Click

        'llamada a la funcion para ejecutar la consulta de busqueda info del vino
        'show_info_vino()
        If Panel_Lista.Visible = True Then
            Panel_Lista.Visible = False
        End If
        If Panel_Lista.Visible = False Then
            Panel_Lista.Visible = True
        End If

    End Sub

    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click

        'llamada a la funcion para ejecutar la consulta
        guardar_vino()

    End Sub

    Private Sub Editor_Vinos_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Vinos' Puede moverla o quitarla según sea necesario.
        Me.VinosTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Vinos)

        'ocultar algunos elementos 
        Insert_Maduracion.Visible = False
        Insert_DO.Visible = False
        Insert_Tipo.Visible = False
        Insert_Photo_Name.Visible = False
        Show_ID.Visible = False

        'ocultar todo los elementos
        Panel1.Visible = False
        Panel_Lista.Visible = False
        b_Search.Visible = False
        b_DeleteItem.Visible = False

        'no aparezca seleccionado ninguno
        ComboBox1.Text = index_vino_modificar

        info_rellenar_campo_1.Visible = True

        show_info_vino()

    End Sub

    Private Sub ComboBox_Maduracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Maduracion.SelectedIndexChanged
        Insert_Maduracion.Text = ComboBox_Maduracion.Text
    End Sub

    Private Sub ComboBox_Tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Tipos.SelectedIndexChanged
        Insert_Tipo.Text = ComboBox_Tipos.Text
    End Sub

    Private Sub ComboBox_DO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DO.SelectedIndexChanged
        Insert_DO.Text = ComboBox_DO.Text
    End Sub

    Private Sub b_SearchPhoto_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto.Click

        Dim directory As String
        'MsgBox("El archivo debe estar en la siguiente ruta" & " " & Ruta_Vinos, vbInformation, "Aviso")
        ' directory = "C:\" & Ruta_Vinos
        directory = Ruta_Vinos
        'MsgBox(directory)

        Try
            Dim openFileDialog1 As New OpenFileDialog()
            ' openFileDialog1.InitialDirectory = "C:\"
            openFileDialog1.InitialDirectory = directory
            openFileDialog1.FilterIndex = 4
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dir As String = openFileDialog1.FileName
                Dim str_name_file As String
                str_name_file = Path.GetFileName(dir)

                'nombre del archivo a pasar a la cadena
                Insert_Photo_Name.Text = str_name_file

                'para visualizar el vino tras cargar la foto
                ShowPhotoVino.Load(dir)
                ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
                ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage

            Else
                If String.IsNullOrEmpty(openFileDialog1.FileName) Then
                    MessageBox.Show("No ha Seleccionado ningun archivo")
                    Return
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Show_ID.Text = ComboBox1.Text
        show_info_vino()

        If Show_ID.Text <> "" Then
            info_rellenar_campo_1.Visible = False
        End If

        If Show_ID.Text = "" Then
            info_rellenar_campo_1.Visible = True
        End If

    End Sub

    Private Sub show_info_vino()

        'activar enlace con la base de datos
        enlace_BD()

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If Show_ID.Text <> " " Then

            consulta = "Select *From Vinos where Id_Vino ='" & Show_ID.Text & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Vinos")

            registro = ods.Tables("Vinos").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar el vino en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Panel_Lista.Visible = False
            info_rellenar_campo_1.Visible = True
            Exit Sub
        End If

        If registro <> 0 Then
            DataGridView1.DataSource = ods
            DataGridView1.DataMember = "Vinos"

            Show_ID.Text = ods.Tables("Vinos").Rows(0).Item("Id_Vino")
            Insert_Marca.Text = ods.Tables("Vinos").Rows(0).Item("Marca")
            Insert_Maduracion.Text = ods.Tables("Vinos").Rows(0).Item("Maduracion")
            Insert_Year.Text = ods.Tables("Vinos").Rows(0).Item("Año")
            Insert_Tipo.Text = ods.Tables("Vinos").Rows(0).Item("Tipo")
            Insert_Comentario.Text = ods.Tables("Vinos").Rows(0).Item("Comentario")
            Insert_DO.Text = ods.Tables("Vinos").Rows(0).Item("Denominacion_Origen")
            Insert_Photo_Name.Text = ods.Tables("Vinos").Rows(0).Item("Foto_Etiqueta")

            'Adaptar para visualizar en los combo box
            ComboBox_Maduracion.Text = Insert_Maduracion.Text
            ComboBox_Tipos.Text = Insert_Tipo.Text
            ComboBox_DO.Text = Insert_DO.Text

            'para visualizar la foto

            Dim cadena_foto_vino As String
            Dim foto_vino As String
            base_Url_Vinos = Ruta_Vinos

            foto_vino = Insert_Photo_Name.Text
            cadena_foto_vino = base_Url_Vinos & foto_vino

            ''Configuracion de la imagen del vino
            ShowPhotoVino.Load(cadena_foto_vino)
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage

            'visualizar todo los elementos
            Panel1.Visible = True
            Panel_Lista.Visible = True
            info_rellenar_campo_1.Visible = False

        Else
            ' MsgBox("No existe el codigo", vbCritical, "Aviso")
            'ocultar todos los elementos
            Panel1.Visible = False
        End If
        desconectar_BD()

        info_rellenar_campo_2.Visible = False
        info_rellenar_campo_3.Visible = False
        info_rellenar_campo_4.Visible = False
        info_rellenar_campo_5.Visible = False
        info_rellenar_campo_6.Visible = False
        info_rellenar_campo_7.Visible = False

        'contabilizar el numero de botellas
        contabilizar_numero_botellas()

    End Sub

    Private Sub b_DeleteItem_Click(sender As Object, e As EventArgs) Handles b_DeleteItem.Click

        'llamada a la funcion para ejecutar la consulta
        borrar_vino()

    End Sub

    Private Sub borrar_vino()
        'activar enlace con la base de datos
        enlace_BD()

        Dim borrar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea eliminar el registro", vbYesNo, "Confirmar")

        If registro = vbYes Then

            borrar = "Delete *From Vinos where Id_Vino ='" & Show_ID.Text & "'"

            Cmd_BD = New OleDbCommand(borrar, Conection)
            Cmd_BD.ExecuteNonQuery()
            MsgBox("Registro borrado", vbInformation, "Aviso")

            desconectar_BD()
            Me.Dispose()
            Me.Close()

        Else
            MsgBox("Cancelada operación", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

    End Sub

    Private Sub guardar_vino()

        Dim actualizar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea modificar los datos del Vino", vbYesNo, "Confirmar")

        If registro = vbYes Then

            Try
                enlace_BD()
                actualizar = "UPDATE Vinos SET Marca= '" & Insert_Marca.Text &
                             "',Maduracion ='" & Insert_Maduracion.Text &
                             "',Año ='" & Insert_Year.Text &
                             "',Tipo ='" & Insert_Tipo.Text &
                             "',Comentario ='" & Insert_Comentario.Text &
                             "',Denominacion_Origen ='" & Insert_DO.Text &
                             "',Foto_Etiqueta ='" & Insert_Photo_Name.Text &
                             "' WHERE Id_Vino ='" & Show_ID.Text & "'"


                Cmd_BD = New OleDbCommand(actualizar, Conection)
                Cmd_BD.ExecuteNonQuery()

                MsgBox("Vino actualizado", vbInformation, "Aviso")
                desconectar_BD()

            Catch ex As Exception
                DisplayOleDbErrorCollection(ex)
                MsgBox("No se puedo actualizar los datos del vino", vbCritical, "Aviso")
                desconectar_BD()
            End Try

            Me.Dispose()
            Me.Close()

        Else
            MsgBox("modificacion de datos del vino cancelada", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

    End Sub

    Private Sub Show_ID_TextChanged(sender As Object, e As EventArgs) Handles Show_ID.TextChanged

    End Sub

    Private Sub Insert_Marca_TextChanged(sender As Object, e As EventArgs) Handles Insert_Marca.TextChanged

        If Insert_Marca.Text = "" Then
            info_rellenar_campo_2.Visible = True
        End If

        If Insert_Marca.Text <> "" Then
            info_rellenar_campo_2.Visible = False
        End If

    End Sub

    Private Sub Insert_Year_TextChanged(sender As Object, e As EventArgs) Handles Insert_Year.TextChanged

        If Insert_Year.Text = "" Then
            info_rellenar_campo_4.Visible = True
        End If

        If Insert_Year.Text <> "" Then
                info_rellenar_campo_4.Visible = False
            End If

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
        consulta = New OleDb.OleDbDataAdapter("SELECT * FROM Huecos_completos WHERE Vino ='" & busqueda & "'", Conection)
        tabla_contabilizacion_vinos = New DataTable
        consulta.Fill(tabla_contabilizacion_vinos)

        'desactivar lectura con base de datos
        desconectar_BD()

        'mostrar resultado final
        Show_NumBotellas.Text = tabla_contabilizacion_vinos.Rows.Count

        'mostar el boton de borrar solo cuando se pueda borrar (es decir no tengamos ningun registro
        If Show_NumBotellas.Text = "0" Then
            b_DeleteItem.Visible = True
        Else
            b_DeleteItem.Visible = False
        End If

    End Sub

End Class