Module Module_Bodega

    'Variable con las rutas de instalacion
    Public ruta_usuario_instalacion As String

    'Variable unidad disco localización archivos
    Public unidad_disco As String

    'Variable con las rutas de instalacion
    Public Ruta_BD As String
    Public Ruta_Vinos As String
    Public Ruta_DO As String
    Public Ruta_Logos_DO As String
    Public Ruta_zonas As String

    Public Ruta_audios As String

    'URL of Help archive
    Public URL_help_document As String
    Public URL_aux_help_document As String


    'Variable para bucles/ indice del hueco
    Public ID_NUMERO As String

    'Variable con la ruta base para acceder carpeta de vinos
    Public base_Url_Vinos As String

    'Variable con la ruta base para acceder carpeta de logos de la denominacion de origen
    Public base_Url_DO As String

    'Variable para la ventana en detalle al pulsar el boton del hueco
    Public Detalle_ID_Hueco As String
    Public Detalle_ID_Vino As String
    Public Detalle_Year As String
    Public Detalle_Marca As String
    Public Detalle_Denominacion As String
    Public Detalle_Maduracion As String
    Public Detalle_Coleccion As String
    Public Detalle_Tipo As String
    Public Detalle_Photo_Vino_url As String
    Public Detalle_Photo_DO_url As String
    Public Detalle_Photo_DO_Map_url As String
    Public Detalle_URL_DO As String

    ' Variables para guardar los valores corresponientes a cada hueco
    Public N_ID_Hueco(502) As String
    Public N_ID_Vino(502) As String
    Public N_Year(502) As String
    Public N_Marca(502) As String
    Public N_Denominacion(502) As String
    Public N_Maduracion(502) As String
    Public N_Coleccion(502) As String
    Public N_Tipo(502) As String
    Public N_Photo_Vino(502) As String
    Public N_Photo_DO(502) As String
    Public N_Photo_DO_Map(502) As String
    Public N_URL_DO(502) As String

    ' Variable auxiliar para mostrar solo las 2 ultimas cifras del año
    Public N_Year_short(502) As String

    'Tablas con los datos
    Public tabla_huecos As New DataTable
    Public tabla_vinos As New DataTable
    Public tabla_DO As New DataTable
    Public tabla_contabilizacion_vinos As New DataTable

    'Variables para totalizadores

    Public Total_huecos As Integer
    Public Total_tintos As Integer
    Public Total_blancos As Integer
    Public Total_rosados As Integer
    Public Total_cavas As Integer
    Public Total_otros As Integer

    Public Total_cosecha As Integer
    Public Total_reserva As Integer
    Public Total_Gran_reserva As Integer
    Public Total_crianza As Integer

    Public Total_rioja As Integer
    Public Total_ribera As Integer
    Public Total_valdepenas As Integer


    'Variable para iniciar el modo arranque pruebas o normal
    Public modo_pruebas As Boolean
    Public sin_permisos As Boolean

    'Para mostrar un valor al iniciar la pantalla de modificar en el modo edicion
    Public index_hueco_modificar As Integer
    Public index_vino_modificar As String
    Public index_do_modificar As String
    Public index_zona_modificar As String

    'Para el folleto de vinos
    Public index_vino As Integer
    Public num_vinos_registrados As Integer
    Public tabla_vinos_ordenado As New DataTable

    'Para el folleto de vinos
    Public N_Folleto_ID_Hueco(999) As String
    Public N_Folleto_ID_Vino(999) As String
    Public N_Folleto_Year(999) As String
    Public N_Folleto_Marca(999) As String
    Public N_Folleto_Denominacion(999) As String
    Public N_Folleto_Maduracion(999) As String
    Public N_Folleto_Coleccion(999) As String
    Public N_Folleto_Comentario(999) As String
    Public N_Folleto_Tipo(999) As String
    Public N_Folleto_Photo_Vino(999) As String
    Public N_Folleto_Photo_DO(999) As String


    Public Sub Generacion_Datos()

        Dim url_documents As String

        'conocer unidad de disco 
        url_documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        unidad_disco = url_documents.Substring(0, 3)

        'folder personal documents
        ruta_usuario_instalacion = url_documents

        'llamada a la rutina para generar enlace con base de datos
        enlace_BD()

        'Memorizacion de la ruta donde se encuentran los archivos
        If modo_pruebas Then
            'Para pruebas
            Ruta_BD = Application.StartupPath
            URL_help_document = "file://" & Ruta_BD & "\Resources\Ayuda_vinoteca.chm"

        Else
            'for instalation version
            Ruta_BD = "" & ruta_usuario_instalacion & "\Luis Software\Vinoteca"
            URL_help_document = "file://" & Ruta_BD & "\help\Ayuda_vinoteca.chm"

        End If

        'creacion del resto de rutas utilizadas para acceder a los datos
        Ruta_Vinos = Ruta_BD & "\imagenes\vinos\"
        Ruta_zonas = Ruta_BD & "\imagenes\zonas\"
        Ruta_DO = Ruta_BD & "\imagenes\denominacion_origen\"
        Ruta_Logos_DO = Ruta_DO & "logos\"

        'comprobar si hemos realizado bien la conexion
        If StatusConex Is "Comunicacion OK" Then

            ' ******** CREACIÓN DE LA CONSULTA PARA GUARDAR LOS VALORES DE LOS 338 HUECOS CON SU RESPECTIVA INFORMACIÓN ********

            Dim adaptador As OleDb.OleDbDataAdapter

            ' Creacion tabla Grid catalogo de Vinos
            adaptador = New OleDb.OleDbDataAdapter("SELECT * FROM Vinos", Conection)
            tabla_vinos = New DataTable
            adaptador.Fill(tabla_vinos)

            ' Creacion tabla Denominaciones de origen
            adaptador = New OleDb.OleDbDataAdapter("SELECT * FROM Denominaciones_Origen", Conection)
            tabla_DO = New DataTable
            adaptador.Fill(tabla_DO)

            ' Creacion tabla Huecos
            adaptador = New OleDb.OleDbDataAdapter("SELECT * FROM Huecos_completos", Conection)
            tabla_huecos = New DataTable
            adaptador.Fill(tabla_huecos)

            ' Guardado de la informacion tabla huecos en vectores
            For i As Integer = 0 To 501
                N_ID_Hueco(i) = CType(tabla_huecos.Rows(i)("Id_Hueco"), String)
            Next

            For i As Integer = 0 To 501
                N_Coleccion(i) = CType(tabla_huecos.Rows(i)("Coleccion"), String)
            Next

            For i As Integer = 0 To 501
                N_ID_Vino(i) = CType(tabla_huecos.Rows(i)("Vino"), String)
            Next

            ' **** RELACIONAR VALOR DEL INDICE DEL VINO CON VALOR DE POSICION EN LA TABLA
            ' Se va proceder a buscar informacion sobre el vino con el indice guardado en la tabla huecos_completos

            ' Creacion tabla Grid catalogo de Vinos
            adaptador = New OleDb.OleDbDataAdapter("SELECT * From Vinos Order By Marca", Conection)
            tabla_vinos_ordenado = New DataTable
            adaptador.Fill(tabla_vinos_ordenado)

            'conocer el número de vinos registrados
            num_vinos_registrados = tabla_vinos_ordenado.Rows.Count - 1

            'rellenar tabla con la información de todos los vinos registrados
            For i As Integer = 0 To num_vinos_registrados
                N_Folleto_ID_Vino(i) = CType(tabla_vinos_ordenado.Rows(i)("Id_Vino"), String)
                N_Folleto_Marca(i) = CType(tabla_vinos_ordenado.Rows(i)("Marca"), String)
                N_Folleto_Maduracion(i) = CType(tabla_vinos_ordenado.Rows(i)("Maduracion"), String)
                N_Folleto_Year(i) = CType(tabla_vinos_ordenado.Rows(i)("Año"), String)
                N_Folleto_Tipo(i) = CType(tabla_vinos_ordenado.Rows(i)("Tipo"), String)
                N_Folleto_Denominacion(i) = CType(tabla_vinos_ordenado.Rows(i)("Denominacion_Origen"), String)
                N_Folleto_Photo_Vino(i) = CType(tabla_vinos_ordenado.Rows(i)("Foto_Etiqueta"), String)

                'Busqueda de informacion de la denominacion de origen según el tipo de vino
                Dim v_Folleto_nombre_DO As String = N_Folleto_Denominacion(i)
                Dim busca_Folleto_DO() As DataRow

                busca_Folleto_DO = tabla_DO.Select("Id_Denominacion='" & v_Folleto_nombre_DO & "'")

                If busca_Folleto_DO.Length > 0 Then
                    'Guardado del nombre de la foto con el indice de la denominacion
                    N_Folleto_Photo_DO(i) = busca_Folleto_DO(0).Item(2).ToString
                Else
                    ' Mensaje de fallo en la busqueda del id del vino
                    MessageBox.Show("ERROR en generación de la tabla DO de vinos")
                End If

                '*****CONTABILIZAR CUANTAS BOTELLAS TENEMOS DEL VINO

                ' consultor.Dispose()

            Next

            '*************************************************************
            For i As Integer = 0 To 501

                'Busqueda de informacion según el tipo de vino
                Dim v_nombre_vino As String = N_ID_Vino(i)
                Dim busca_vino() As DataRow

                busca_vino = tabla_vinos.Select("Id_Vino='" & v_nombre_vino & "'")

                If busca_vino.Length > 0 Then

                    'Guardado del nombre de la foto con el indice del vino buscado
                    N_Photo_Vino(i) = busca_vino(0).Item(7).ToString

                    'Carga de la marca
                    N_Marca(i) = busca_vino(0).Item(1).ToString

                    'Carga de la maduracion
                    N_Maduracion(i) = busca_vino(0).Item(2).ToString

                    'año de la cosecha
                    N_Year(i) = busca_vino(0).Item(3).ToString

                    'Carga del tipo 
                    N_Tipo(i) = busca_vino(0).Item(4).ToString

                    'Memorizacion de denominacion de origen
                    N_Denominacion(i) = busca_vino(0).Item(6).ToString

                Else
                    ' Mensaje de fallo en la busqueda del id del vino
                    MessageBox.Show("ERROR en generación de la tabla tipo de vinos")
                End If

                'Busqueda de informacion de la denominacion de origen según el tipo de vino
                Dim v_nombre_DO As String = N_Denominacion(i)
                Dim busca_DO() As DataRow

                busca_DO = tabla_DO.Select("Id_Denominacion='" & v_nombre_DO & "'")

                If busca_DO.Length > 0 Then
                    'Guardado del nombre de la foto con el indice de la denominacion
                    N_Photo_DO(i) = busca_DO(0).Item(2).ToString

                    'Guardado del nombre de la foto con el mapa
                    N_Photo_DO_Map(i) = busca_DO(0).Item(3).ToString

                Else
                    ' Mensaje de fallo en la busqueda del id del vino
                    MessageBox.Show("ERROR en generación de la tabla DO de vinos")
                End If
            Next

            'Acortar string del año para su visualización
            For index As Integer = 0 To 501
                If N_Year(index) <> "0" Then
                    N_Year_short(index) = N_Year(index).Remove(0, 2)
                End If
            Next

        Else
            'Para la ejecución - no funciona bien la aplicación
            MsgBox("Fallo crítica en la busqueda de conexion con la BD", MsgBoxStyle.Critical, "Error generacion conexion de datos")
            End
        End If

    End Sub


    'Funcion para audio del sonido boton inicio
    Public Sub Tocar_audio_notificacion()

        ''Memorizacion de la ruta donde se encuentran los archivos
        'If modo_pruebas Then
        '    'Para pruebas
        '    Ruta_BD = Application.StartupPath
        'Else
        '    Ruta_BD = "C:\Users\" & ruta_usuario_instalacion & "\Documents\Luis Software\Vinoteca"
        'End If

        ''creacion ruta de sonidos
        'Ruta_audios = Ruta_BD & "\audios\"
        ''MsgBox(Ruta_audios)

        'Dim url_audio_notificacion As String

        'url_audio_notificacion = Ruta_audios & "ASOT.mp3"
        ''MsgBox(url_audio_notificacion)

        'Dim song_1 As System.Media.SoundPlayer
        'song_1 = New System.Media.SoundPlayer(url_audio_notificacion)
        'song_1.Play()
        ''Temporizador para comprobar si es necesario para cargar los datos
        ''System.Threading.Thread.Sleep(500)
        ''song_1.Stop()

    End Sub

    Public Sub audio_prueba()

        ''Memorizacion de la ruta donde se encuentran los archivos
        'If modo_pruebas Then
        '    'Para pruebas
        '    Ruta_BD = Application.StartupPath
        'Else
        '    Ruta_BD = "C:\Users\" & ruta_usuario_instalacion & "\Documents\Luis Software\Vinoteca"
        'End If

        ''creacion ruta de sonidos
        'Ruta_audios = Ruta_BD & "\audios\"
        ''MsgBox(Ruta_audios)

        'Dim url_audio_notificacion As String

        'url_audio_notificacion = Ruta_audios & "close.wav"

    End Sub

End Module
