Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Public Class Editor_Vinos_Insertar
    Private Sub b_SaveItem_Click(sender As Object, e As EventArgs) Handles b_SaveItem.Click

        Dim byte_operation As Byte

        If Insert_ID.Text <> "" And
           Insert_Marca.Text <> "" And
           Insert_Maduracion.Text <> "" And
           Insert_Year.Text <> "" And
           Insert_Tipo.Text <> "" And
           Insert_Comentario.Text <> "" And
           Insert_DO.Text <> "" Then

            byte_operation = MsgBox("Esta seguro que quiere insertar un nuevo Vino en la base de datos", vbYesNo, "Confirmar")

            If byte_operation = vbYes Then
                'llamar a la funcion para insertar nuevo vino
                insertar_registro_vino()
            Else
                MsgBox("Cancelada la operacion para insertar el nuevo vino", vbInformation, "Cancelacion")
            End If
            Me.Dispose()

        Else

            MsgBox("Es necesario completar todos los campos antes de poder insertar el nuevo vino", vbInformation, "Requerimiento para realizar la operacion")

        End If

    End Sub

    Private Sub Editor_Vinos_Insertar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_Bodega_V1DataSet.Denominaciones_Origen' Puede moverla o quitarla según sea necesario.
        Me.Denominaciones_OrigenTableAdapter.Fill(Me.BD_Bodega_V1DataSet.Denominaciones_Origen)

        'ocultar algunos elementos 
        Insert_Maduracion.Visible = False
        Insert_DO.Visible = False
        Insert_Tipo.Visible = False
        Insert_Photo_Name.Visible = False

        'no aparezca seleccionado ninguno
        ComboBox_DO.Text = ""
        ComboBox_Tipos.Text = ""
        ComboBox_Maduracion.Text = ""

        'los avisos sobre la necesidad de introducir los campos
        info_rellenar_campo_1.Visible = True
        info_rellenar_campo_2.Visible = True
        info_rellenar_campo_3.Visible = True
        info_rellenar_campo_4.Visible = True
        info_rellenar_campo_5.Visible = True
        info_rellenar_campo_6.Visible = True
        info_rellenar_campo_7.Visible = True
        info_rellenar_campo_8.Visible = True

    End Sub

    Private Sub b_SearchPhoto_Click(sender As Object, e As EventArgs) Handles b_SearchPhoto.Click

        Dim directory As String
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Maduracion.Validated

        Insert_Maduracion.Text = ComboBox_Maduracion.Text

        'animacion por si se requiere introducir al menos un valor
        If Insert_Maduracion.Text <> "" Then
            info_rellenar_campo_3.Visible = False
        End If

        If Insert_Maduracion.Text = "" Then
            info_rellenar_campo_3.Visible = True
        End If

    End Sub


    Private Sub ComboBox_Tipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Tipos.Validated
        Insert_Tipo.Text = ComboBox_Tipos.Text

        'animacion por si se requiere introducir al menos un valor
        If Insert_Tipo.Text <> "" Then
            info_rellenar_campo_5.Visible = False
        End If

        If Insert_Tipo.Text = "" Then
            info_rellenar_campo_5.Visible = True
        End If

    End Sub

    Private Sub ComboBox_DO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_DO.Validated

        Insert_DO.Text = ComboBox_DO.Text

        'animacion por si se requiere introducir al menos un valor
        If Insert_DO.Text <> "" Then
            info_rellenar_campo_7.Visible = False
        End If

        If Insert_DO.Text = "" Then
            info_rellenar_campo_7.Visible = True
        End If

    End Sub

    Private Sub insertar_registro_vino()

        'abrir conexion con la base de datos
        enlace_BD()

        'declaracion de los parametros para la consulta de insercion
        Dim parametro_1 As String
        Dim parametro_2 As String
        Dim parametro_3 As String
        Dim parametro_4 As Integer
        Dim parametro_5 As String
        Dim parametro_6 As String
        Dim parametro_7 As String
        Dim parametro_8 As String

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
            consulta = "Select *From Vinos where Id_Vino ='" & Insert_ID.Text & "'"
            oda = New OleDbDataAdapter(consulta, Conection)
            ods = New DataSet
            oda.Fill(ods, "Vinos")
            registro = ods.Tables("Vinos").Rows.Count
            If registro <> 0 Then
                MsgBox("Se ha introducido un número de ID ya existente", vbExclamation, "Aviso")
                desconectar_BD()
                Exit Sub
            End If
        End If

            'asignacion del valor de los parametros según los textbox
            parametro_2 = Insert_Marca.Text
        'aviso sobre la necesidad de introducir valores en los parametros
        If parametro_2 = "" Then
            MsgBox("Es necesario introducir una marca del vino antes de introducir registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        'asignacion del valor de los parametros según los textbox
        parametro_3 = Insert_Maduracion.Text
        'aviso sobre la necesidad de introducir valores en los parametros
        If parametro_3 = "" Then
            MsgBox("Es necesario introducir la maduracion del vino antes de introducir registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        'asignacion del valor de los parametros según los textbox
        'comprobar que se pasa al menos un valor de año
        If Insert_Year.Text <> "" Then
            parametro_4 = Insert_Year.Text
        Else
            parametro_4 = 0
            MsgBox("No se ha puesto valor al año, se ha prefijado un valor a 0, modificar posteriormente si es necesario", vbCritical, "Aviso")
        End If

        'asignacion del valor de los parametros según los textbox
        parametro_5 = Insert_Tipo.Text
        'aviso sobre la necesidad de introducir valores en los parametros
        If parametro_5 = "" Then
            MsgBox("Es necesario introducir un tipo de vino antes de añadir registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        'fijar al menos un comentario para que no de fallo
        If Insert_Comentario.Text <> "" Then
            parametro_6 = Insert_Comentario.Text
        Else
            parametro_6 = "sin comentario"
        End If

        'asignacion del valor de los parametros según los textbox
        parametro_7 = Insert_DO.Text
        'aviso sobre la necesidad de introducir valores en los parametros
        If parametro_7 = "" Then
            MsgBox("Es necesario introducir una DO antes de introducir registro", vbCritical, "Aviso")
            desconectar_BD()
            Exit Sub
        End If

        'comprobar que se pasa al menos una foto
        If Insert_Photo_Name.Text <> "" Then
            parametro_8 = Insert_Photo_Name.Text
        Else
            parametro_8 = "GENERICO.jpg"
            MsgBox("No se ha asignado foto al vino, modificar posteriormente si es necesario", vbCritical, "Aviso")
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

        Dim strInsertar_vino As String

        'cadena para la consultar de inserccion
        strInsertar_vino = "INSERT INTO Vinos(Id_Vino,Marca,Maduracion,Año,Tipo,Comentario,Denominacion_Origen,Foto_Etiqueta)" & "VALUES('" & parametro_1 & "'" & ",'" & parametro_2 & "'" & ",'" & parametro_3 & "'" & ",'" & parametro_4 & "'" & ",'" & parametro_5 & "'" & ",'" & parametro_6 & "'" & ",'" & parametro_7 & "'" & ",'" & parametro_8 & "'" & ")"

        'comando para pasar los parametros a la tabla
        Cmd_BD = New OleDbCommand(strInsertar_vino, Conection)
        Cmd_BD.Parameters.AddWithValue("@Id_Vino", parametro_1)
        Cmd_BD.Parameters.AddWithValue("@Marca", parametro_2)
        Cmd_BD.Parameters.AddWithValue("@Maduracion", parametro_3)
        Cmd_BD.Parameters.AddWithValue("@Año", parametro_4)
        Cmd_BD.Parameters.AddWithValue("@Tipo", parametro_5)
        Cmd_BD.Parameters.AddWithValue("@Comentario", parametro_6)
        Cmd_BD.Parameters.AddWithValue("@Denominacion_Origen", parametro_7)
        Cmd_BD.Parameters.AddWithValue("@Foto_Etiqueta", parametro_8)

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

    Private Sub Insert_ID_TextChanged(sender As Object, e As EventArgs) Handles Insert_ID.TextChanged

        If Insert_ID.Text <> "" Then
            info_rellenar_campo_1.Visible = False
        End If

        If Insert_ID.Text = "" Then
            info_rellenar_campo_1.Visible = True
        End If

    End Sub

    Private Sub Insert_Marca_TextChanged(sender As Object, e As EventArgs) Handles Insert_Marca.TextChanged

        If Insert_Marca.Text <> "" Then
            info_rellenar_campo_2.Visible = False
        End If

        If Insert_Marca.Text = "" Then
            info_rellenar_campo_2.Visible = True
        End If

    End Sub

    Private Sub Insert_Year_TextChanged(sender As Object, e As EventArgs) Handles Insert_Year.TextChanged

        If Insert_Year.Text <> "" Then
            info_rellenar_campo_4.Visible = False
        End If

        If Insert_Year.Text = "" Then
            info_rellenar_campo_4.Visible = True
        End If

    End Sub

    Private Sub Insert_Comentario_TextChanged(sender As Object, e As EventArgs) Handles Insert_Comentario.TextChanged

        If Insert_Comentario.Text <> "" Then
            info_rellenar_campo_6.Visible = False
        End If

        If Insert_Comentario.Text = "" Then
            info_rellenar_campo_6.Visible = True
        End If

    End Sub

    Private Sub Insert_Photo_Name_TextChanged(sender As Object, e As EventArgs) Handles Insert_Photo_Name.TextChanged

        If Insert_Photo_Name.Text <> "" Then
            info_rellenar_campo_8.Visible = False
        End If

        If Insert_Photo_Name.Text = "" Then
            info_rellenar_campo_8.Visible = True
        End If

    End Sub

    Private Sub Insert_DO_TextChanged(sender As Object, e As EventArgs) Handles Insert_DO.TextChanged
        If Insert_DO.Text <> "" Then
            info_rellenar_campo_7.Visible = False
        End If

        If Insert_DO.Text = "" Then
            info_rellenar_campo_7.Visible = True
        End If
    End Sub
End Class