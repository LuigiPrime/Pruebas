Public Class Folleto_Vinos
    Private Sub Folleto_Vinos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        b_CerrarListado.Visible = False

        '***************************************************
        'Configuracion de la ventana
        '***************************************************

        'ocultar la zona del buscador
        Panel_Listado.Visible = False

        'iniciar la visualización
        visualizar_vino()

        '***************************************************
        'Configuracion de la lista de vinos
        '***************************************************

        ' Set the ListBox to display items in multiple columns.
        ListBox1.MultiColumn = False
        ' Set the selection mode to multiple and extended.
        ListBox1.SelectionMode = SelectionMode.One

        ' Shutdown the painting of the ListBox as items are added.
        ListBox1.BeginUpdate()
        ' Loop through and add X items to the ListBox.
        Dim x As Integer
        For x = 0 To num_vinos_registrados
            'ListBox1.Items.Add("Item " & x.ToString())
            ListBox1.Items.Add(N_Folleto_Marca(x))
        Next x
        ' Allow the ListBox to repaint and display the new items.
        ListBox1.EndUpdate()

        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS 
        '***************************************************

        'Creacion de Boton CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(20, 450)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")

    End Sub
    Private Sub b_Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON CERRAR
        Dispose()
        Close()
    End Sub

    Private Sub b_Down_Folleto_Click(sender As Object, e As EventArgs) Handles b_Down_Folleto.Click

        If index_vino >= 1 Then
            index_vino = index_vino - 1
        Else
            index_vino = 0
        End If

        'rutina para actualizar los campos para visualizar
        visualizar_vino()

        'visualizar que indice de vino estabamos visualizando
        ListBox1.SetSelected(index_vino, True)

        If index_vino = 0 Then
            b_Down_Folleto.Visible = False
        End If

    End Sub


    Public Sub visualizar_vino()

        'llamada a la rutina para contabilizar cuantas botellas tenemos de ese tipo
        contabilizar_numero_botellas()

        'variables auxiliares locales
        Dim cadena_foto_vino As String
        Dim cadena_foto_DO As String

        'carga de los valores
        Show_ID_Vino.Text = N_Folleto_ID_Vino(index_vino)
        Show_year.Text = N_Folleto_Year(index_vino)
        'Show_Coleccion.Text = N_Folleto_Coleccion(index_vino)
        Show_Maduracion.Text = N_Folleto_Maduracion(index_vino)
        Show_Marca.Text = N_Folleto_Marca(index_vino)
        Show_Tipo.Text = N_Folleto_Tipo(index_vino)
        Show_Denominacion.Text = N_Folleto_Denominacion(index_vino)

        'ruta de busqueda archivos de fotos
        base_Url_Vinos = Ruta_Vinos
        base_Url_DO = Ruta_Logos_DO

        'carga de las fotos según el vino
        Detalle_Photo_Vino_url = N_Folleto_Photo_Vino(index_vino)
        Detalle_Photo_DO_url = N_Folleto_Photo_DO(index_vino)

        'generacion de la ruta completa
        cadena_foto_vino = base_Url_Vinos & Detalle_Photo_Vino_url
        cadena_foto_DO = base_Url_DO & Detalle_Photo_DO_url

        'Configuracion de la imagen del vino
        ShowPhotoVino.Load(cadena_foto_vino)
        ShowPhotoVino.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhotoVino.SizeMode = PictureBoxSizeMode.StretchImage

        'Configuracion de la imagen de la denominacion de origen
        ShowPhotoDO.Load(cadena_foto_DO)
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.CenterImage
        ShowPhotoDO.SizeMode = PictureBoxSizeMode.StretchImage

        busqueda_id_vino.Text = index_vino

    End Sub

    Public Sub contabilizar_numero_botellas()

        'generacion de la consulta numero botellas
        Dim consulta As OleDb.OleDbDataAdapter

        Dim busqueda As String
        busqueda = N_Folleto_ID_Vino(index_vino)
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
    End Sub

    Public Sub obtener_idx_vino()

        ' mediante este procedimiento buscamos al primer que coincida con el nombre de la marca 

        'rellenar tabla con la información de todos los vinos registrados
        For i As Integer = 0 To num_vinos_registrados

            If busqueda_marca.Text = N_Folleto_Marca(i) Then
                index_vino = i
            Else

            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles busqueda_id_vino.TextChanged

        'comprobar que tenemos valores correctos
        If busqueda_id_vino.Text > 502 Or busqueda_id_vino.Text < 0 Then
            MsgBox("Valor introducido no es correcto debe ser entre 0 y 502")
        Else
            index_vino = busqueda_id_vino.Text
        End If
        'ejecutar actualización de los valores a visualizar
        visualizar_vino()

    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles busqueda_marca.TextChanged
        'ejecutar actualización de los valores a visualizar
        obtener_idx_vino()
        visualizar_vino()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b_abrirListado.Click
        Panel_Listado.Visible = True
        b_CerrarListado.Visible = True
    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        index_vino = ListBox1.SelectedIndex
        'ejecutar actualización de los valores a visualizar
        visualizar_vino()

        'actualizar 
        busqueda_marca.Text = Show_Marca.Text
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Localizacion_vino.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Info_Listado_Vinos.Show()
    End Sub

    Private Sub b_Up_Folleto_Click_1(sender As Object, e As EventArgs) Handles b_Up_Folleto.Click
        If index_vino >= 502 Then
            index_vino = 502
        Else
            index_vino = index_vino + 1
        End If

        'rutina para actualizar los campos para visualizar
        visualizar_vino()

        'visualizar que indice de vino estabamos visualizando
        ListBox1.SetSelected(index_vino, True)

        If index_vino > 0 Then
            b_Down_Folleto.Visible = True
        End If
    End Sub

    Private Sub b_CerrarListado_Click(sender As Object, e As EventArgs) Handles b_CerrarListado.Click
        Panel_Listado.Visible = False
        b_CerrarListado.Visible = False
    End Sub
End Class