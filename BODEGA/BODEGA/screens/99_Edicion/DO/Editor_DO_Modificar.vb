Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_DO_Modificar
    Private Sub Editor_DO_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)

        'no aparezca seleccionado ninguno
        ComboBox1.Text = index_do_modificar
        Panel1.Visible = False
        Panel_Lista.Visible = False
        Show_ID.Visible = False
        b_Search.Visible = False

        'llamar funcion para mostrar info
        show_do_info()
    End Sub

    Private Sub b_Search_Click(sender As Object, e As EventArgs) Handles b_Search.Click
        'llamada funcion de busqueda informacion de la DO
        show_do_info()
    End Sub

    Private Sub b_SearchPhoto_DO_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto_DO.Click

        Dim directory_logo As String
        directory_logo = Ruta_Logos_DO
        'MsgBox(directory_logo)

        Try
            Dim openFileDialog2 As New OpenFileDialog()
            openFileDialog2.InitialDirectory = directory_logo
            openFileDialog2.FilterIndex = 4
            openFileDialog2.RestoreDirectory = True

            If openFileDialog2.ShowDialog() = DialogResult.OK Then
                Dim dir As String = openFileDialog2.FileName
                Dim str_name_file As String
                str_name_file = Path.GetFileName(dir)

                'nombre del archivo a pasar a la cadena
                Insert_Logo_Name.Text = str_name_file

                'para visualizar el vino tras cargar la foto
                ShowPhotoDO.Load(dir)
                ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
                ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage

            Else
                If String.IsNullOrEmpty(openFileDialog2.FileName) Then
                    MessageBox.Show("No ha Seleccionado ningun archivo")
                    Return
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click

        'llamada funcion de consulta
        guardar_DO()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Show_ID.Text = ComboBox1.Text

        Panel_Lista.Visible = True

        info_rellenar_campo_1.Visible = False

        show_do_info()
    End Sub

    Private Sub b_SearchPhoto_Map_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto_Map.Click
        Dim directory As String
        directory = Ruta_DO
        'MsgBox(directory)

        Try
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = directory
            openFileDialog1.FilterIndex = 4
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dir As String = openFileDialog1.FileName
                Dim str_name_file As String
                str_name_file = Path.GetFileName(dir)

                'nombre del archivo a pasar a la cadena
                Insert_Map_Name.Text = str_name_file

                'para visualizar el vino tras cargar la foto
                ShowMapDO.Load(dir)
                ShowMapDO.SizeMode = PictureBoxSizeMode.CenterImage
                ShowMapDO.SizeMode = PictureBoxSizeMode.StretchImage

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

    Private Sub show_do_info()
        'activar enlace con la base de datos
        enlace_BD()

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If Show_ID.Text <> " " Then

            consulta = "Select *From Denominaciones_Origen where ID_Denominacion ='" & Show_ID.Text & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Denominaciones_Origen")

            registro = ods.Tables("Denominaciones_Origen").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar la denominacion de Origen en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then
            DataGridView1.DataSource = ods
            DataGridView1.DataMember = "Denominaciones_Origen"

            Show_ID.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("ID_Denominacion")
            Insert_Informacion.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Informacion")
            Insert_Logo_Name.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Logo_denominacion")
            Insert_Map_Name.Text = ods.Tables("Denominaciones_Origen").Rows(0).Item("Mapa_ubicacion")

            'para visualizar la foto
            Dim cadena_logo_do As String
            Dim foto_logo As String

            Dim cadena_map_do As String
            Dim foto_map As String

            'Logo denominacion
            foto_logo = Insert_Logo_Name.Text
            cadena_logo_do = Ruta_Logos_DO & foto_logo

            'Mapa ubicacion
            foto_map = Insert_Map_Name.Text
            cadena_map_do = Ruta_DO & foto_map

            ''Configuracion de la imagen del vino
            ShowPhotoDO.Load(cadena_logo_do)
            ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
            ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage


            ''Configuracion de la imagen del vino
            ShowMapDO.Load(cadena_map_do)
            ShowMapDO.SizeMode = PictureBoxSizeMode.CenterImage
            ShowMapDO.SizeMode = PictureBoxSizeMode.StretchImage

            'visualizar todo los elementos
            Panel1.Visible = True

        Else
            'MsgBox("No existe el codigo", vbCritical, "Aviso")
            'ocultar todos los elementos
            Panel1.Visible = False
        End If
        desconectar_BD()


        info_rellenar_campo_2.Visible = False
        info_rellenar_campo_3.Visible = False
        info_rellenar_campo_4.Visible = False


        contabilizar_numero_botellas()

    End Sub

    Private Sub b_DeleteItem_Click(sender As Object, e As EventArgs) Handles b_DeleteItem.Click
        borrar_DO()
    End Sub


    Private Sub borrar_DO()
        'activar enlace con la base de datos
        enlace_BD()

        Dim borrar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea eliminar la Denominacion de Origen", vbYesNo, "Confirmar")

        If registro = vbYes Then

            borrar = "Delete *From Denominaciones_Origen where ID_Denominacion ='" & Show_ID.Text & "'"

            Cmd_BD = New OleDbCommand(borrar, Conection)
            Cmd_BD.ExecuteNonQuery()
            MsgBox("Registro borrado", vbInformation, "Aviso")

            desconectar_BD()
            Me.Dispose()
            Me.Close()

        Else
            MsgBox("Cancelada la operacion de borrado", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If


    End Sub


    Private Sub guardar_DO()

        Dim actualizar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea modificar los datos de la Denonimacion de Origen", vbYesNo, "Confirmar")

        If registro = vbYes Then

            Try
                enlace_BD()
                actualizar = "UPDATE Denominaciones_Origen SET Informacion= '" & Insert_Informacion.Text &
                         "',Logo_denominacion ='" & Insert_Logo_Name.Text &
                         "',Mapa_ubicacion ='" & Insert_Map_Name.Text &
                         "' WHERE ID_Denominacion ='" & Show_ID.Text & "'"

                'MsgBox(actualizar)

                Cmd_BD = New OleDbCommand(actualizar, Conection)
                Cmd_BD.ExecuteNonQuery()

                MsgBox("Denominacion de Origen actualizadada", vbInformation, "Aviso")
                desconectar_BD()

            Catch ex As Exception
                DisplayOleDbErrorCollection(ex)
                MsgBox("No se puedo actualizar los datos de la denominacion", vbCritical, "Aviso")
                desconectar_BD()
            End Try

            Me.Dispose()
            Me.Close()

        Else
            MsgBox("Modificacion de datos del vino cancelada", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
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
        consulta = New OleDb.OleDbDataAdapter("SELECT * FROM Vinos WHERE Denominacion_Origen ='" & busqueda & "'", Conection)
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

    Private Sub Insert_Informacion_TextChanged(sender As Object, e As EventArgs) Handles Insert_Informacion.TextChanged

        If Insert_Informacion.Text <> "" Then
            info_rellenar_campo_4.Visible = False
        End If

        If Insert_Informacion.Text = "" Then
            info_rellenar_campo_4.Visible = True
        End If
    End Sub
End Class