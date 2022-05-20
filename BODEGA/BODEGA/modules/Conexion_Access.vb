':::Importamos la libreria necesaria para nuestra conexión

Imports System.Data
Imports System.Data.OleDb

Module Conexion_Access

    Public Cmd_BD As New OleDbCommand 'comando para realizar consultas con las bases de datos
    Public StatusConex As String

    Public url_connection_string As String '

    'conexion con la base de datos nueva (rectificada) 
    Public Conection As New OleDbConnection


    Public Sub enlace_BD()

        'Create url to search personal folder documents (destination of instalation files)
        Dim aux_url_connnection_string As String
        aux_url_connnection_string = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        url_connection_string = aux_url_connnection_string & "\Luis Software\Vinoteca\BD_Bodega_V1.accdb"


        On Error GoTo fallo

        'If modo_pruebas Then
        'Para pruebas
        'Conection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BD_Bodega_V1.accdb; Persist Security Info=False"
        'Else
        'Para la version instalador
        ' Conection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & url_connection_string & "; Persist Security Info=False"
        'Conection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BD_Bodega_V1.accdb; Persist Security Info=False"
        'End If

        Conection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BD_Bodega_V1.accdb; Persist Security Info=False"

        'activar la conexion
        Conection.Open()

        'generar aviso sobre la correcta activación de la conexión con la BD
        StatusConex = "Comunicacion OK"
        Exit Sub

fallo:
        MsgBox("Fallo Comunicacion - necesario reiniciar aplicacion", MsgBoxStyle.Critical, "ERROR CONEXION BASE DATOS")
        StatusConex = "Fallo Comunicacion - necesario reiniciar aplicacion"
    End Sub

    Public Sub desconectar_BD()
        Conection.Close()
    End Sub

    Public Sub DisplayOleDbErrorCollection(exception As OleDbException)
        'con este metodo se puede visualizar el codigo de fallo en los comandos de OleDb
        Dim i As Integer

        For i = 0 To exception.Errors.Count - 1
            MessageBox.Show("Index #" + i.ToString() + ControlChars.Cr _
           + "Message: " + exception.Errors(i).Message + ControlChars.Cr _
           + "Native: " + exception.Errors(i).NativeError.ToString() + ControlChars.Cr _
           + "Source: " + exception.Errors(i).Source + ControlChars.Cr _
           + "SQL: " + exception.Errors(i).SQLState + ControlChars.Cr)
        Next i
    End Sub


    Public Sub Backup_BD()

        'this method copy de actual BD to Backup Folder with the date

        Dim actualdate As String = DateTime.Now.ToString("dd-MM-yyyy H-mm-ss")
        Dim filename As String

        filename = "BD_Bodega_V1 " & actualdate & ".accdb"

        'folder of destiny store BD
        Dim backup_directory As String
        backup_directory = Ruta_BD & "\backup\"

        'folder of origin to bakcup BD
        Dim backup_directory_origin As String
        backup_directory_origin = Application.StartupPath

        'URL where the BD is located to Copy
        Dim url_bd_origin As String
        url_bd_origin = backup_directory_origin & "\BD_Bodega_V1.accdb"

        'create folder backup at Personal folder
        My.Computer.FileSystem.CreateDirectory("" & backup_directory_origin & "\backup")

        'copy file BD and name it temp_backup
        My.Computer.FileSystem.CopyFile("" & url_bd_origin & "",
                                            "" & backup_directory & "\temp_backup",
                                            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        ' rename file 
        My.Computer.FileSystem.RenameFile("" & backup_directory & "\temp_backup", "" & filename & "")

        MsgBox("Copia seguridad creada en " & backup_directory, vbInformation, "OPERACION DE BACKUP COMPLETADA")

        'old version
        'If modo_pruebas Then
        '    'create folder al dowloads only for tests
        '    My.Computer.FileSystem.CreateDirectory("C:\Users\Luis\Downloads\Creador")

        '    My.Computer.FileSystem.CopyFile("C:\Users\Luis\Downloads\presentacion.png",
        '                                    "C:\Users\Luis\Downloads\Creador\presentacion2.png",
        '                                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        '                                    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        '    MsgBox("Copia seguridad creada")

        '    My.Computer.FileSystem.RenameFile("C:\Users\Luis\Downloads\Creador\presentacion2.png", "" & actualdate & "")

        'Else

        '    'create folder backup at Personal folder
        '    My.Computer.FileSystem.CreateDirectory("" & Ruta_BD & "\backup")

        '    My.Computer.FileSystem.CopyFile("" & url_connection_string & "",
        '                                    "" & backup_directory & "\temp_backup",
        '                                    Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        '                                    Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)

        '    ' 
        '    My.Computer.FileSystem.RenameFile("" & backup_directory & "\temp_backup", "" & filename & "")

        '    MsgBox("Copia seguridad creada en " & backup_directory)

        'End If

    End Sub


    Public Sub Clear_Backup_BD()

        Dim backup_directory As String
        backup_directory = Ruta_BD & "\backup\"

        If My.Computer.FileSystem.DirectoryExists(backup_directory) Then
            'delete folder backup at Personal folder
            My.Computer.FileSystem.DeleteDirectory(backup_directory, FileIO.UIOption.AllDialogs,
                                                       FileIO.RecycleOption.SendToRecycleBin,
                                                       FileIO.UICancelOption.ThrowException)
        Else
            MsgBox("Directorio de backup no existe", vbCritical, "OPERACION CANCELADA")
            Exit Sub
        End If

        'OLD VERSION
        'If modo_pruebas Then
        '    'delete folder al dowloads only for tests
        '    If My.Computer.FileSystem.DirectoryExists("C:\Users\Luis\Downloads\Creador") Then

        '        'only if the directory its created
        '        My.Computer.FileSystem.DeleteDirectory("C:\Users\Luis\Downloads\Creador",
        '                               FileIO.UIOption.AllDialogs,
        '                               FileIO.RecycleOption.SendToRecycleBin,
        '                               FileIO.UICancelOption.ThrowException)
        '    Else
        '        MsgBox("Directorio de backup no existe")
        '        Exit Sub
        '    End If
        'Else
        '    'delete folder al dowloads only for tests
        '    If My.Computer.FileSystem.DirectoryExists(backup_directory) Then
        '        'delete folder backup at Personal folder
        '        My.Computer.FileSystem.DeleteDirectory(backup_directory, FileIO.UIOption.AllDialogs,
        '                                               FileIO.RecycleOption.SendToRecycleBin,
        '                                               FileIO.UICancelOption.ThrowException)

        '    Else
        '        MsgBox("Directorio de backup no existe")
        '        Exit Sub
        '    End If
        'End If
    End Sub

End Module
