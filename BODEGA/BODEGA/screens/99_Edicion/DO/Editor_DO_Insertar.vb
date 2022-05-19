Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_DO_Insertar
    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click

        Dim byte_operation As Byte

        byte_operation = MsgBox("Esta seguro que quiere insertar una nueva Denominacion de Origen", vbYesNo, "Confirmar")

        If byte_operation = vbYes Then
            'llamar a la funcion para insertar nueva Denominacion Origen
            insertar_registro_DO()
        Else
            MsgBox("Cancelada la creación de la nueva Denominación de Origen", vbInformation, "Aviso")
        End If
        Me.Dispose()
    End Sub


    Private Sub insertar_registro_DO()

        'abrir conexion con la base de datos
        enlace_BD()

        'declaracion de los parametros para la consulta de insercion
        Dim parametro_1 As String
        Dim parametro_2 As String
        Dim parametro_3 As String
        Dim parametro_4 As String
        'Dim parametro_5 As String
        'Dim parametro_6 As String
        'Dim parametro_7 As String
        'Dim parametro_8 As String

        'asignacion del valor de los parametros según los textbox
        parametro_1 = Insert_ID.Text

        'aviso sobre la necesidad de introducir valores en los parametros
        If parametro_1 = "" Then
            MsgBox("Es necesario introducir un numero de ID antes de introducir registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        'comprobar que el numero de ID no existe
        Dim consulta As String
        Dim oda As New OleDbDataAdapter
        Dim ods As DataSet
        Dim registro As Byte

        If Insert_ID.Text <> " " Then
            consulta = "Select *From Denominaciones_Origen where ID_Denominacion ='" & Insert_ID.Text & "'"
            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Denominaciones_Origen")
            registro = ods.Tables("Denominaciones_Origen").Rows.Count
            If registro <> 0 Then
                MsgBox("Se ha introducido un número de ID ya existente", vbExclamation, "Aviso")
                desconectar_BD()
                Exit Sub
            End If
        End If

        'asignacion del valor de los parametros según los textbox
        If Insert_Informacion.Text <> "" Then
            parametro_2 = Insert_Informacion.Text
        Else
            parametro_2 = "informacion extra sobre la DO"
        End If

        'comprobar que se pasa al menos una foto
        If Insert_Logo_Name.Text <> "" Then
            parametro_3 = Insert_Logo_Name.Text
        Else
            parametro_3 = "NO_LOGO.jpg"
            MsgBox("No se ha asignado logo a la denominacion, modificar posteriormente si es necesario", vbInformation, "Aviso")
        End If

        'comprobar que se pasa al menos una foto
        If Insert_Map_Name.Text <> "" Then
            parametro_4 = Insert_Map_Name.Text
        Else
            parametro_4 = "NO_LOGO.jpg"
        End If

        '******SOLO PRUEBAS *******
        'mostrar el valor de cada parametro
        'MsgBox(parametro_1)
        'MsgBox(parametro_2)
        'MsgBox(parametro_3)
        'MsgBox(parametro_4)
        'MsgBox(parametro_5)
        'MsgBox(parametro_6)
        'MsgBox(parametro_7)
        'MsgBox(parametro_8)

        Dim strInsertar_DO As String

        'cadena para la consultar de inserccion
        strInsertar_DO = "INSERT INTO Denominaciones_Origen(ID_Denominacion,Informacion,Logo_denominacion,Mapa_ubicacion)" & "VALUES('" & parametro_1 & "'" & ",'" & parametro_2 & "'" & ",'" & parametro_3 & "'" & ",'" & parametro_4 & "'" & ")"

        'comando para pasar los parametros a la tabla
        Cmd_BD = New OleDbCommand(strInsertar_DO, Conection)
        Cmd_BD.Parameters.AddWithValue("@ID_Denominacion", parametro_1)
        Cmd_BD.Parameters.AddWithValue("@Informacion", parametro_2)
        Cmd_BD.Parameters.AddWithValue("@Logo_denominacion", parametro_3)
        Cmd_BD.Parameters.AddWithValue("@Mapa_ubicacion", parametro_4)
        'Cmd_BD.Parameters.AddWithValue("@Tipo", parametro_5)
        'Cmd_BD.Parameters.AddWithValue("@Comentario", parametro_6)
        'Cmd_BD.Parameters.AddWithValue("@Denominacion_Origen", parametro_7)
        'Cmd_BD.Parameters.AddWithValue("@Foto_Etiqueta", parametro_8)

        'ventana informativa sobre operacion correcta
        MsgBox("Datos guardados OK", vbInformation, "aviso")

        Try
            Cmd_BD.ExecuteNonQuery()
            Cmd_BD.Dispose()
            desconectar_BD()
        Catch ex As Exception
            DisplayOleDbErrorCollection(ex)
            MsgBox("Registro no se guardo", vbCritical, "Aviso")
            desconectar_BD()
        End Try

        Me.Dispose()
        Me.Close()

    End Sub

    Private Sub b_SearchPhoto_Map_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto_Map.Click

        Dim directory As String
        directory = Ruta_DO
        ' MsgBox(directory)

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

    Private Sub b_SearchPhoto_DO_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto_DO.Click

        Dim directory_logo As String
        directory_logo = Ruta_Logos_DO
        'MsgBox(directory_logo)

        Try
            Dim openFileDialog2 As New OpenFileDialog()
            openFileDialog2.InitialDirectory = directory_logo
            openFileDialog2.FilterIndex = 4
            openFileDialog2.RestoreDirectory = True

            If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
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
    Private Sub Editor_DO_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'mostrar los simbolos para introducir valores
        info_rellenar_campo_1.Visible = True
        info_rellenar_campo_2.Visible = True
        info_rellenar_campo_3.Visible = True
        info_rellenar_campo_4.Visible = True

        'ocultar algunos elementos 
        'Insert_Maduracion.Visible = False
        'Insert_DO.Visible = False
        'Insert_Tipo.Visible = False
        'Insert_Photo_Name.Visible = False
    End Sub
    Private Sub Insert_ID_TextChanged(sender As Object, e As EventArgs) Handles Insert_ID.TextChanged

        If Insert_ID.Text <> "" Then
            info_rellenar_campo_1.Visible = False
        Else
            info_rellenar_campo_1.Visible = True
        End If

    End Sub
    Private Sub Insert_Logo_Name_TextChanged(sender As Object, e As EventArgs) Handles Insert_Logo_Name.TextChanged
        info_rellenar_campo_2.Visible = False
    End Sub

    Private Sub Insert_Map_Name_TextChanged(sender As Object, e As EventArgs) Handles Insert_Map_Name.TextChanged
        info_rellenar_campo_3.Visible = False
    End Sub
    Private Sub Insert_Informacion_TextChanged(sender As Object, e As EventArgs) Handles Insert_Informacion.TextChanged

        If Insert_Informacion.Text <> "" Then
            info_rellenar_campo_4.Visible = False
        Else
            info_rellenar_campo_4.Visible = True
        End If

    End Sub
End Class