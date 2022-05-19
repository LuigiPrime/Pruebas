Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_Zonas_Modificar
    Private Sub Editor_Zonas_Modificar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Zonas_almacenamiento' Puede moverla o quitarla según sea necesario.
        Me.Zonas_almacenamientoTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Zonas_almacenamiento)

        'no aparezca seleccionado ninguno
        ComboBox1.Text = index_zona_modificar
        Panel1.Visible = False

        show_zona_info()

    End Sub

    Private Sub b_Search_Click(sender As Object, e As EventArgs) Handles b_Search.Click
        show_zona_info()
    End Sub

    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click
        guardar_Zona()
    End Sub

    Private Sub b_DeleteItem_Click(sender As Object, e As EventArgs) Handles b_DeleteItem.Click
        borrar_zona()
    End Sub

    Private Sub b_SearchPhoto_Map_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto.Click

        Dim directory_foto As String
        directory_foto = Ruta_zonas
        MsgBox(directory_foto)

        Try
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.InitialDirectory = directory_foto
            openFileDialog1.FilterIndex = 4
            openFileDialog1.RestoreDirectory = True

            If openFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim dir As String = openFileDialog1.FileName
                Dim str_name_file As String
                str_name_file = Path.GetFileName(dir)

                'nombre del archivo a pasar a la cadena
                Insert_Photo_Name.Text = str_name_file

                'para visualizar el vino tras cargar la foto
                Show_Photo.Load(dir)
                Show_Photo.SizeMode = PictureBoxSizeMode.CenterImage
                Show_Photo.SizeMode = PictureBoxSizeMode.StretchImage

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

    Private Sub guardar_Zona()

        Dim actualizar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea modificar los datos de la zona", vbYesNo, "Confirmar")

        If registro = vbYes Then

            Try
                enlace_BD()
                actualizar = "UPDATE Zonas_almacenamiento SET Zona= '" & Insert_Informacion.Text &
                         "',Foto_zona ='" & Insert_Photo_Name.Text &
                         "' WHERE ID_Zona ='" & Show_ID.Text & "'"

                'MsgBox(actualizar)

                Cmd_BD = New OleDbCommand(actualizar, Conection)
                Cmd_BD.ExecuteNonQuery()

                MsgBox("Zona de almacenamiento actualizadada", vbInformation, "Aviso")
                desconectar_BD()

            Catch ex As Exception
                DisplayOleDbErrorCollection(ex)
                MsgBox("No se puedo actualizar los datos de la Zona de almacenamiento", vbCritical, "Aviso")
                desconectar_BD()
            End Try

            Me.Dispose()
            Me.Close()

        Else
            MsgBox("modificacion de datos Zona de almacenamiento cancelada", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

    End Sub

    Private Sub borrar_zona()
        'activar enlace con la base de datos
        enlace_BD()

        Dim borrar As String
        Dim registro As Byte

        registro = MsgBox("Esta seguro que desea eliminar el registro", vbYesNo, "Confirmar")

        If registro = vbYes Then

            borrar = "Delete *From Zonas_almacenamiento where ID_Zona ='" & Show_ID.Text & "'"

            Cmd_BD = New OleDbCommand(borrar, Conection)
            Cmd_BD.ExecuteNonQuery()
            MsgBox("Registro borrado", vbInformation, "Aviso")

            desconectar_BD()
            Me.Dispose()
            Me.Close()

        Else
            MsgBox("no se pudo borrar el registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If
    End Sub

    Private Sub show_zona_info()
        'activar enlace con la base de datos
        enlace_BD()

        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If Show_ID.Text <> " " Then

            consulta = "Select *From Zonas_almacenamiento where ID_Zona ='" & Show_ID.Text & "'"

            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Zonas_almacenamiento")

            registro = ods.Tables("Zonas_almacenamiento").Rows.Count

        Else
            MsgBox("No se ha introducido un numero de ID para buscar la Zonas almacenamiento en la base de datos", vbInformation, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        If registro <> 0 Then
            DataGridView1.DataSource = ods
            DataGridView1.DataMember = "Zonas_almacenamiento"

            Show_ID.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("ID_Zona")
            Insert_Informacion.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("Zona")
            Insert_Photo_Name.Text = ods.Tables("Zonas_almacenamiento").Rows(0).Item("Foto_zona")

            'para visualizar la foto
            Dim cadena_foto As String
            Dim foto_zona As String

            'Logo denominacion
            foto_zona = Insert_Photo_Name.Text
            cadena_foto = Ruta_zonas & foto_zona

            'Configuracion de la imagen 
            Show_Photo.Load(cadena_foto)
            Show_Photo.SizeMode = PictureBoxSizeMode.CenterImage
            Show_Photo.SizeMode = PictureBoxSizeMode.StretchImage

            'visualizar todo los elementos
            Panel1.Visible = True

        Else
            'MsgBox("No existe el codigo", vbCritical, "Aviso")
            'ocultar todos los elementos
            Panel1.Visible = False
        End If
        desconectar_BD()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Show_ID.Text = ComboBox1.Text
        show_zona_info()
    End Sub
End Class