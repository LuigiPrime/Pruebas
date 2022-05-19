Public Class Bodega_Huecos_Principal_Aux
    Private Sub Bodega_Huecos_Principal_Aux_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Huecos()

    End Sub

    Private Sub b_Photo_Click(ByVal sender As Object, ByVal e As EventArgs)
        'mostrar la foto de la zona
        Info_Detalle_Zona_Auxiliar.Show()
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, System.Windows.Forms.Button).Name
            Case "Hueco339"
                ID_NUMERO = 338
            Case "Hueco340"
                ID_NUMERO = 339
            Case "Hueco341"
                ID_NUMERO = 340
            Case "Hueco342"
                ID_NUMERO = 341
            Case "Hueco343"
                ID_NUMERO = 342
            Case "Hueco344"
                ID_NUMERO = 343
            Case "Hueco345"
                ID_NUMERO = 344
            Case "Hueco346"
                ID_NUMERO = 345
            Case "Hueco347"
                ID_NUMERO = 346
            Case "Hueco348"
                ID_NUMERO = 347
            Case "Hueco349"
                ID_NUMERO = 348
            Case "Hueco350"
                ID_NUMERO = 349
            Case "Hueco351"
                ID_NUMERO = 350
            Case "Hueco352"
                ID_NUMERO = 351
            Case "Hueco353"
                ID_NUMERO = 352
            Case "Hueco354"
                ID_NUMERO = 353
            Case "Hueco355"
                ID_NUMERO = 354
            Case "Hueco356"
                ID_NUMERO = 355
            Case "Hueco357"
                ID_NUMERO = 356
            Case "Hueco358"
                ID_NUMERO = 357
            Case "Hueco359"
                ID_NUMERO = 358
            Case "Hueco360"
                ID_NUMERO = 359
            Case "Hueco361"
                ID_NUMERO = 360
            Case "Hueco362"
                ID_NUMERO = 361
            Case "Hueco363"
                ID_NUMERO = 362
            Case "Hueco364"
                ID_NUMERO = 363
            Case "Hueco365"
                ID_NUMERO = 364
            Case "Hueco366"
                ID_NUMERO = 365
            Case "Hueco367"
                ID_NUMERO = 366
            Case "Hueco368"
                ID_NUMERO = 367
            Case "Hueco369"
                ID_NUMERO = 368
            Case "Hueco370"
                ID_NUMERO = 369
            Case "Hueco371"
                ID_NUMERO = 370
            Case "Hueco372"
                ID_NUMERO = 371
            Case "Hueco373"
                ID_NUMERO = 372
            Case "Hueco374"
                ID_NUMERO = 373
            Case "Hueco375"
                ID_NUMERO = 374
            Case "Hueco376"
                ID_NUMERO = 375
            Case Else
                ' Accion genérica
                MsgBox("boton sin accion")
        End Select

        'Cerrar por si hay otro abierto
        Info_Detalle.Close()

        'Traspaso de la informacion a las variables "especificas para visualizar

        Detalle_ID_Hueco = N_ID_Hueco(ID_NUMERO)
        Detalle_ID_Vino = N_ID_Hueco(ID_NUMERO)
        Detalle_Maduracion = N_Maduracion(ID_NUMERO)
        Detalle_Marca = N_Marca(ID_NUMERO)
        Detalle_Tipo = N_Tipo(ID_NUMERO)
        Detalle_Year = N_Year(ID_NUMERO)
        Detalle_Denominacion = N_Denominacion(ID_NUMERO)
        Detalle_Coleccion = N_Coleccion(ID_NUMERO)

        'Carga de la cadena con el nombre de las fotos cargar - la ruta completa se carga en info_detalle

        Detalle_Photo_Vino_url = N_Photo_Vino(ID_NUMERO)
        Detalle_Photo_DO_url = N_Photo_DO(ID_NUMERO)
        Detalle_Photo_DO_Map_url = N_Photo_DO_Map(ID_NUMERO)


        'Abrir ventana detalle 
        Info_Detalle.Show()


    End Sub

    Private Sub b_Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON CERRAR
        Dispose()
        Close()
    End Sub
    Private Sub b_Filtro_Huecos_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Huecos()
    End Sub
    Private Sub b_Filtro_Coleccion_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Coleccion()
    End Sub
    Private Sub b_Filtro_Year_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Years()
    End Sub

    Private Sub b_Filtro_DO_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_DO()
    End Sub
    Private Sub b_Filtro_Tipo_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Tipo()
    End Sub
    Private Sub b_Filtro_Maduracion_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion generador de todos los elementos
        Auxiliar_Creador_Filtro_Maduracion()
    End Sub

    Private Sub Auxiliar_Creador_Filtro_Huecos()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "mostrar foto de la zona")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Condicion_1 = Contador_Condicion_1 + 1
                    Else
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLightLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Condicion_1 = Contador_Condicion_1 + 1

                    Else
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLightLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1

                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Condicion_1 = Contador_Condicion_1 + 1

                    Else
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLightLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "OCUPADO"
        Leyenda_2.Text = "LIBRE"
        Leyenda_3.Text = "LEYENDA 3"
        Leyenda_4.Text = "LEYENDA 4"
        Leyenda_5.Text = "LEYENDA 5"
        Leyenda_6.Text = "LEYENDA 6"
        Leyenda_7.Text = "LEYENDA 7"
        Leyenda_8.Text = "LEYENDA 8"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = False
        Leyenda_4.Visible = False
        Leyenda_5.Visible = False
        Leyenda_6.Visible = False
        Leyenda_7.Visible = False
        Leyenda_8.Visible = False

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = False
        Icono_Leyenda_4.Visible = False
        Icono_Leyenda_5.Visible = False
        Icono_Leyenda_6.Visible = False
        Icono_Leyenda_7.Visible = False
        Icono_Leyenda_8.Visible = False

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Condicion_2.ToString
        Icono_Leyenda_2.Text = Contador_Condicion_1.ToString
        'Icono_Leyenda_3.Text = Contador_Rueda.ToString
        'Icono_Leyenda_4.Text = Contador_Mancha.ToString
        'Icono_Leyenda_5.Text = Contador_Navarra.ToString
        'Icono_Leyenda_6.Text = Contador_Valdepena.ToString
        'Icono_Leyenda_7.Text = Contador_Otra.ToString
        'Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_marron
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_negro
        'Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_azul
        'Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_verde
        'Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_amarillo
        'Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_marron
        'Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        'Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_blanco

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de huecos " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de huecos " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_2.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_3.ForeColor = Color.Black
        Icono_Leyenda_4.ForeColor = Color.Black
        Icono_Leyenda_5.ForeColor = Color.Black
        Icono_Leyenda_6.ForeColor = Color.Black
        Icono_Leyenda_7.ForeColor = Color.Black
        Icono_Leyenda_8.ForeColor = Color.Black

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub

    Private Sub Auxiliar_Creador_Filtro_Coleccion()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "mostrar foto de la zona")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer
        Dim contador_libre As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0
        contador_libre = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Coleccion(n) = True Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_1 = Contador_Condicion_1 + 1
                    End If

                    If N_Coleccion(n) = False And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        contador_libre = contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)
                    If N_Coleccion(n) = True Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_1 = Contador_Condicion_1 + 1
                    End If

                    If N_Coleccion(n) = False And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        contador_libre = contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Coleccion(n) = True Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_1 = Contador_Condicion_1 + 1
                    End If

                    If N_Coleccion(n) = False And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        contador_libre = contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "COLECCIÓN"
        Leyenda_2.Text = "CONSUMO"
        Leyenda_3.Text = "LIBRE"
        Leyenda_4.Text = "LEYENDA 4"
        Leyenda_5.Text = "LEYENDA 5"
        Leyenda_6.Text = "LEYENDA 6"
        Leyenda_7.Text = "LEYENDA 7"
        Leyenda_8.Text = "LEYENDA 8"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = True
        Leyenda_4.Visible = False
        Leyenda_5.Visible = False
        Leyenda_6.Visible = False
        Leyenda_7.Visible = False
        Leyenda_8.Visible = False

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = True
        Icono_Leyenda_4.Visible = False
        Icono_Leyenda_5.Visible = False
        Icono_Leyenda_6.Visible = False
        Icono_Leyenda_7.Visible = False
        Icono_Leyenda_8.Visible = False

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Condicion_1.ToString
        Icono_Leyenda_2.Text = Contador_Condicion_2.ToString
        Icono_Leyenda_3.Text = contador_libre.ToString
        'Icono_Leyenda_4.Text = Contador_Mancha.ToString
        'Icono_Leyenda_5.Text = Contador_Navarra.ToString
        'Icono_Leyenda_6.Text = Contador_Valdepena.ToString
        'Icono_Leyenda_7.Text = Contador_Otra.ToString
        'Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_azul
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_verde
        Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_negro
        'Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_verde
        'Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_amarillo
        'Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_marron
        'Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        'Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_blanco

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de huecos " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de huecos " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_2.ForeColor = Color.Black
        Icono_Leyenda_3.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_4.ForeColor = Color.Black
        Icono_Leyenda_5.ForeColor = Color.Black
        Icono_Leyenda_6.ForeColor = Color.Black
        Icono_Leyenda_7.ForeColor = Color.Black
        Icono_Leyenda_8.ForeColor = Color.Black

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub

    Private Sub Auxiliar_Creador_Filtro_DO()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "mostrar foto de la zona")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Riojas As Integer
        Dim Contador_Riberas As Integer
        Dim Contador_Rueda As Integer
        Dim Contador_Mancha As Integer
        Dim Contador_Navarra As Integer
        Dim Contador_Valdepena As Integer
        Dim Contador_Otra As Integer
        Dim Contador_Libre As Integer


        'inicializacion 
        Contador_Riojas = 0
        Contador_Riberas = 0
        Contador_Rueda = 0
        Contador_Mancha = 0
        Contador_Navarra = 0
        Contador_Valdepena = 0
        Contador_Otra = 0
        Contador_Libre = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Denominacion(n) = "Rioja" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riojas = Contador_Riojas + 1
                    End If


                    If N_Denominacion(n) = "Ribera del Duero" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riberas = Contador_Riberas + 1
                    End If

                    If N_Denominacion(n) = "Rueda" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rueda = Contador_Rueda + 1
                    End If

                    If N_Denominacion(n) = "Mancha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Mancha = Contador_Mancha + 1
                    End If

                    If N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Navarra = Contador_Navarra + 1
                    End If

                    If N_Denominacion(n) = "Valdepeñas" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Valdepena = Contador_Valdepena + 1
                    End If

                    If Not N_Marca(n) = "MARCA" And Not N_Denominacion(n) = "Valdepeñas" And Not N_Denominacion(n) = "Rioja" And Not N_Denominacion(n) = "Ribera del Duero" And Not N_Denominacion(n) = "Rueda" And Not N_Denominacion(n) = "Mancha" And Not N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_gris
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otra = Contador_Otra + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Denominacion(n) = "Rioja" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riojas = Contador_Riojas + 1
                    End If


                    If N_Denominacion(n) = "Ribera del Duero" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riberas = Contador_Riberas + 1
                    End If

                    If N_Denominacion(n) = "Rueda" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rueda = Contador_Rueda + 1
                    End If

                    If N_Denominacion(n) = "Mancha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Mancha = Contador_Mancha + 1
                    End If

                    If N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Navarra = Contador_Navarra + 1
                    End If

                    If N_Denominacion(n) = "Valdepeñas" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Valdepena = Contador_Valdepena + 1
                    End If

                    If Not N_Marca(n) = "MARCA" And Not N_Denominacion(n) = "Valdepeñas" And Not N_Denominacion(n) = "Rioja" And Not N_Denominacion(n) = "Ribera del Duero" And Not N_Denominacion(n) = "Rueda" And Not N_Denominacion(n) = "Mancha" And Not N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_gris
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otra = Contador_Otra + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Denominacion(n) = "Rioja" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riojas = Contador_Riojas + 1
                    End If


                    If N_Denominacion(n) = "Ribera del Duero" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Riberas = Contador_Riberas + 1
                    End If

                    If N_Denominacion(n) = "Rueda" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rueda = Contador_Rueda + 1
                    End If

                    If N_Denominacion(n) = "Mancha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Mancha = Contador_Mancha + 1
                    End If

                    If N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Navarra = Contador_Navarra + 1
                    End If

                    If N_Denominacion(n) = "Valdepeñas" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Valdepena = Contador_Valdepena + 1
                    End If

                    If Not N_Marca(n) = "MARCA" And Not N_Denominacion(n) = "Valdepeñas" And Not N_Denominacion(n) = "Rioja" And Not N_Denominacion(n) = "Ribera del Duero" And Not N_Denominacion(n) = "Rueda" And Not N_Denominacion(n) = "Mancha" And Not N_Denominacion(n) = "Navarra" Then
                        .BackgroundImage = My.Resources.circulo_gris
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otra = Contador_Otra + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_7
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "RIOJA"
        Leyenda_2.Text = "RIBERA DUERO"
        Leyenda_3.Text = "RUEDA"
        Leyenda_4.Text = "LA MANCHA"
        Leyenda_5.Text = "NAVARRA"
        Leyenda_6.Text = "VALDEPEÑAS"
        Leyenda_7.Text = "OTRA DO"
        Leyenda_8.Text = "LIBRE"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = True
        Leyenda_4.Visible = True
        Leyenda_5.Visible = True
        Leyenda_6.Visible = True
        Leyenda_7.Visible = True
        Leyenda_8.Visible = True

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = True
        Icono_Leyenda_4.Visible = True
        Icono_Leyenda_5.Visible = True
        Icono_Leyenda_6.Visible = True
        Icono_Leyenda_7.Visible = True
        Icono_Leyenda_8.Visible = True

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Riojas.ToString
        Icono_Leyenda_2.Text = Contador_Riberas.ToString
        Icono_Leyenda_3.Text = Contador_Rueda.ToString
        Icono_Leyenda_4.Text = Contador_Mancha.ToString
        Icono_Leyenda_5.Text = Contador_Navarra.ToString
        Icono_Leyenda_6.Text = Contador_Valdepena.ToString
        Icono_Leyenda_7.Text = Contador_Otra.ToString
        Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_violeta
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_rojo
        Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_azul
        Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_verde
        Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_amarillo
        Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_marron
        Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_negro

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de botellas " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de botellas " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_2.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_3.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_4.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_5.ForeColor = Color.Black
        Icono_Leyenda_6.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_7.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_8.ForeColor = SystemColors.ControlLight

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub

    Private Sub Auxiliar_Creador_Filtro_Maduracion()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "visualizar pantalla maduracion")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Crianza As Integer
        Dim Contador_Cosecha As Integer
        Dim Contador_Reserva As Integer
        Dim Contador_Gran_Reserva As Integer
        Dim Contador_Otro As Integer
        Dim Contador_libre As Integer

        'inicializacion 
        Contador_Crianza = 0
        Contador_Cosecha = 0
        Contador_Reserva = 0
        Contador_Gran_Reserva = 0
        Contador_Otro = 0
        Contador_libre = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Maduracion(n) = "Cosecha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Cosecha = Contador_Cosecha + 1
                    End If

                    If N_Maduracion(n) = "Crianza" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Crianza = Contador_Crianza + 1
                    End If

                    If N_Maduracion(n) = "Reserva" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Reserva = Contador_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Gran Reserva" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Gran_Reserva = Contador_Gran_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_libre = Contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Maduracion(n) = "Cosecha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Cosecha = Contador_Cosecha + 1
                    End If

                    If N_Maduracion(n) = "Crianza" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Crianza = Contador_Crianza + 1
                    End If

                    If N_Maduracion(n) = "Reserva" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Reserva = Contador_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Gran Reserva" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Gran_Reserva = Contador_Gran_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_libre = Contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Maduracion(n) = "Cosecha" Then
                        .BackgroundImage = My.Resources.circulo_verde
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Cosecha = Contador_Cosecha + 1
                    End If

                    If N_Maduracion(n) = "Crianza" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Crianza = Contador_Crianza + 1
                    End If

                    If N_Maduracion(n) = "Reserva" Then
                        .BackgroundImage = My.Resources.circulo_marron
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Reserva = Contador_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Gran Reserva" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Gran_Reserva = Contador_Gran_Reserva + 1
                    End If

                    If N_Maduracion(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_libre = Contador_libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_7
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "COSECHA"
        Leyenda_2.Text = "CRIANZA"
        Leyenda_3.Text = "RESERVA"
        Leyenda_4.Text = "G RESERVA"
        Leyenda_5.Text = "OTRO"
        Leyenda_6.Text = "LIBRE"
        Leyenda_7.Text = "LEYENDA 7"
        Leyenda_8.Text = "LEYENDA 8"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = True
        Leyenda_4.Visible = True
        Leyenda_5.Visible = True
        Leyenda_6.Visible = True
        Leyenda_7.Visible = False
        Leyenda_8.Visible = False

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = True
        Icono_Leyenda_4.Visible = True
        Icono_Leyenda_5.Visible = True
        Icono_Leyenda_6.Visible = True
        Icono_Leyenda_7.Visible = False
        Icono_Leyenda_8.Visible = False

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Cosecha.ToString
        Icono_Leyenda_2.Text = Contador_Crianza.ToString
        Icono_Leyenda_3.Text = Contador_Reserva.ToString
        Icono_Leyenda_4.Text = Contador_Gran_Reserva.ToString
        Icono_Leyenda_5.Text = Contador_Otro.ToString
        Icono_Leyenda_6.Text = Contador_libre.ToString
        'Icono_Leyenda_7.Text = Contador_Otra.ToString
        'Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_verde
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_rojo
        Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_marron
        Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_violeta
        Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_azul
        Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_negro
        'Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        'Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_blanco

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de botellas " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de botellas " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_2.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_3.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_4.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_5.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_6.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_7.ForeColor = Color.Black
        Icono_Leyenda_8.ForeColor = Color.Black

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub

    Private Sub Auxiliar_Creador_Filtro_Tipo()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "mostrar foto de la zona")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Blanco As Integer
        Dim Contador_Tinto As Integer
        Dim Contador_Rosado As Integer
        Dim Contador_Cava As Integer
        Dim Contador_Otro As Integer
        Dim Contador_Libre As Integer

        'inicializacion 
        Contador_Blanco = 0
        Contador_Tinto = 0
        Contador_Rosado = 0
        Contador_Cava = 0
        Contador_Otro = 0
        Contador_Libre = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)


                    ' Tenemos vino en el hueco

                    If N_Tipo(n) = "Blanco" Then
                        .BackgroundImage = My.Resources.circulo_blanco
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.Black
                        Contador_Blanco = Contador_Blanco + 1
                    End If

                    If N_Tipo(n) = "Tinto" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Tinto = Contador_Tinto + 1
                    End If

                    If N_Tipo(n) = "Rosado" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rosado = Contador_Rosado + 1
                    End If

                    If N_Tipo(n) = "Cava/Champan" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Cava = Contador_Cava + 1
                    End If

                    If N_Tipo(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .ForeColor = SystemColors.ControlLight
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)


                    ' Tenemos vino en el hueco

                    If N_Tipo(n) = "Blanco" Then
                        .BackgroundImage = My.Resources.circulo_blanco
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.Black
                        Contador_Blanco = Contador_Blanco + 1
                    End If

                    If N_Tipo(n) = "Tinto" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Tinto = Contador_Tinto + 1
                    End If

                    If N_Tipo(n) = "Rosado" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rosado = Contador_Rosado + 1
                    End If

                    If N_Tipo(n) = "Cava/Champan" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Cava = Contador_Cava + 1
                    End If

                    If N_Tipo(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .ForeColor = SystemColors.ControlLight
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    ' Tenemos vino en el hueco

                    If N_Tipo(n) = "Blanco" Then
                        .BackgroundImage = My.Resources.circulo_blanco
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.Black
                        Contador_Blanco = Contador_Blanco + 1
                    End If

                    If N_Tipo(n) = "Tinto" Then
                        .BackgroundImage = My.Resources.circulo_violeta
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Tinto = Contador_Tinto + 1
                    End If

                    If N_Tipo(n) = "Rosado" Then
                        .BackgroundImage = My.Resources.circulo_rojo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        Contador_Rosado = Contador_Rosado + 1
                    End If

                    If N_Tipo(n) = "Cava/Champan" Then
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Cava = Contador_Cava + 1
                    End If

                    If N_Tipo(n) = "Otro" And Not N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_azul
                        .ForeColor = SystemColors.ControlLight
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Otro = Contador_Otro + 1
                    End If

                    ' No tenemos vino en el hueco
                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        Contador_Libre = Contador_Libre + 1
                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_7
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "BLANCO"
        Leyenda_2.Text = "TINTO"
        Leyenda_3.Text = "CAVA"
        Leyenda_4.Text = "ROSADO"
        Leyenda_5.Text = "OTRO"
        Leyenda_6.Text = "LIBRE"
        Leyenda_7.Text = "LEYENDA 7"
        Leyenda_8.Text = "LEYENDA 8"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = True
        Leyenda_4.Visible = True
        Leyenda_5.Visible = True
        Leyenda_6.Visible = True
        Leyenda_7.Visible = False
        Leyenda_8.Visible = False

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = True
        Icono_Leyenda_4.Visible = True
        Icono_Leyenda_5.Visible = True
        Icono_Leyenda_6.Visible = True
        Icono_Leyenda_7.Visible = False
        Icono_Leyenda_8.Visible = False

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Blanco.ToString
        Icono_Leyenda_2.Text = Contador_Tinto.ToString
        Icono_Leyenda_3.Text = Contador_Cava.ToString
        Icono_Leyenda_4.Text = Contador_Rosado.ToString
        Icono_Leyenda_5.Text = Contador_Otro.ToString
        Icono_Leyenda_6.Text = Contador_Libre.ToString
        'Icono_Leyenda_7.Text = Contador_Otra.ToString
        'Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_blanco
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_violeta
        Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_amarillo
        Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_rojo
        Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_azul
        Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_negro
        'Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        'Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_blanco

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de botellas " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de botellas " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = Color.Black
        Icono_Leyenda_2.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_3.ForeColor = Color.Black
        Icono_Leyenda_4.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_5.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_6.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_7.ForeColor = Color.Black
        Icono_Leyenda_8.ForeColor = Color.Black

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub

    Private Sub Auxiliar_Creador_Filtro_Years()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR OCUPACION
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info
        '***************************************************
        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 370)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        'Boton de FILTRO OCUPACION
        Dim boton_2 As New Button()
        With boton_2
            .Name = "b_Filtro_Huecos"  ' Asignas el nombre del objeto
            .Text = "OCUPACIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(175, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_2.Click, AddressOf b_Filtro_Huecos_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_2)

        'Boton de FILTRO COLECCION
        Dim boton_3 As New Button()
        With boton_3
            .Name = "b_Filtro_coleccion"  ' Asignas el nombre del objeto
            .Text = "COLECCIÓN" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(271, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_3.Click, AddressOf b_Filtro_Coleccion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_3)

        'Boton de MOSTRAR AÑOS
        Dim boton_4 As New Button()
        With boton_4
            .Name = "b_Filtro_Year"  ' Asignas el nombre del objeto
            .Text = "AÑO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(367, 370)
            .BackColor = System.Drawing.Color.Green
            .Enabled = False
        End With
        AddHandler boton_4.Click, AddressOf b_Filtro_Year_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_4)

        'Boton de COLOREAR POR DO
        Dim boton_5 As New Button()
        With boton_5
            .Name = "b_Filtro_DO"  ' Asignas el nombre del objeto
            .Text = "DO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(463, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_5.Click, AddressOf b_Filtro_DO_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_5)

        'Boton de COLOREAR POR TIPO VINO
        Dim boton_6 As New Button()
        With boton_6
            .Name = "b_Filtro_Tipo"  ' Asignas el nombre del objeto
            .Text = "TIPO" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(559, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_6.Click, AddressOf b_Filtro_Tipo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_6)

        'Boton de COLOREAR POR MADURACION
        Dim boton_7 As New Button()
        With boton_7
            .Name = "b_Filtro_Maduracion"  ' Asignas el nombre del objeto
            .Text = "MADURACION" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(90, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(655, 370)
            .BackColor = System.Drawing.Color.Gray
            .Enabled = True
        End With
        AddHandler boton_7.Click, AddressOf b_Filtro_Maduracion_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_7)

        'Boton de MOSTRAR FOTO
        Dim boton_photo As New Button()
        With boton_photo
            .Name = "b_show_photo"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(50, 50) ' Asignas el tamaño del objeto
            .BackgroundImageLayout = ImageLayout.Stretch
            .Location = New System.Drawing.Point(105, 370)
            .BackgroundImage = My.Resources.zonas_almacenamiento
            .Enabled = True
        End With
        AddHandler boton_photo.Click, AddressOf b_Photo_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_photo)

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(boton_1, "A menu principal")
        Me.ToolTip1.SetToolTip(boton_2, "Pantalla ocupacion general")
        Me.ToolTip1.SetToolTip(boton_3, "visualizar pantalla coleccion/consumo")
        Me.ToolTip1.SetToolTip(boton_4, "visualizar pantalla años de la cosecha")
        Me.ToolTip1.SetToolTip(boton_5, "visualizar pantalla por denominacion de origen")
        Me.ToolTip1.SetToolTip(boton_6, "visualizar pantalla por tipo de vino")
        Me.ToolTip1.SetToolTip(boton_7, "visualizar pantalla maduracion")
        Me.ToolTip1.SetToolTip(boton_photo, "mostrar foto de la zona")

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'Incorporar el panel de fondo para evitar deformaciones
        Dim panel_fondo As New Panel()
        With panel_fondo
            .Name = "p_frontal"  ' Asignas el nombre del objeto
            .Size = New System.Drawing.Size(850, 300) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(15, 15)
            .BackgroundImage = My.Resources.Fondo_Auxiliar
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        '***************************************************
        'ZONA CREACION DE BOTONES DE PARA ACCEDER INFORMACION DE CADA HUECO
        '***************************************************
        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0

        Dim index As String

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer

        '************************************************************
        'Creacion del primer mueble de 5 filas x 2 columnas

        '************************************************************

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 45

        'Inicialización del indice 
        n = 338

        For y = 1 To 5

            If y = 1 Then
                acum_y = 40
            End If

            If y > 1 Then
                'Formacion de las columnas
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 4

                If x = 1 Then
                    acum_x = 48
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = Color.DimGray
                        .Text = ""  'Asignar el texto del objeto
                        Contador_Condicion_1 = Contador_Condicion_1 + 1

                    Else
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                        .Text = N_Year_short(n) 'Asignar el texto del objeto

                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 2º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 358

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 502
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        .Text = ""  'Asignar el texto del objeto
                        Contador_Condicion_1 = Contador_Condicion_1 + 1

                    Else
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                        .Text = N_Year_short(n) 'Asignar el texto del objeto

                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '************************************************************
        'Creacion del 3º mueble de 3 filas x 3 columnas

        '************************************************************

        'Inicialización del indice 
        n = 367

        For y = 1 To 3
            'Formacion de las filas
            If y = 1 Then
                acum_y = 132
            End If

            If y > 1 Then
                acum_y = acum_y + offset_y
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To 3

                If x = 1 Then
                    acum_x = 697
                End If

                If x > 1 Then
                    acum_x = acum_x + offset_x
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(36, 36) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)

                    If N_Marca(n) = "MARCA" Then
                        .BackgroundImage = My.Resources.circulo_negro
                        .BackgroundImageLayout = ImageLayout.Stretch
                        .ForeColor = SystemColors.ControlLight
                        .Text = ""  'Asignar el texto del objeto
                        Contador_Condicion_1 = Contador_Condicion_1 + 1

                    Else
                        .BackgroundImage = My.Resources.circulo_amarillo
                        .BackgroundImageLayout = ImageLayout.Stretch
                        Contador_Condicion_2 = Contador_Condicion_2 + 1
                        .Text = N_Year_short(n) 'Asignar el texto del objeto

                    End If

                End With
                AddHandler hueco.Click, AddressOf Button_Click   ' Asocias el evento al método Button_Click
                panel_fondo.Controls.Add(hueco)
                'generador de mensaje de ayuda
                Me.ToolTip1.SetToolTip(hueco, "Hueco " & index)
                n = n + 1 'incremento del indice
            Next
        Next

        '*************************
        '*****CREACION DE LEYENDA y CABECERAS
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True

        End With
        Me.Controls.Add(Panel_filtros)

        Dim Label_Filtros As New Label()
        With Label_Filtros
            .Name = "Label_filtros"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "CAMBIO FILTROS PARA VISUALIZACIÓN" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)

        End With
        Panel_filtros.Controls.Add(Label_Filtros)
        Panel_filtros.SendToBack()

        Dim Panel_Leyenda As New Panel()
        With Panel_Leyenda
            .Name = "Panel_Leyenda"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
            .Visible = False
            '.AutoScroll = True
        End With
        Me.Controls.Add(Panel_Leyenda)

        Dim Label_Leyenda As New Label()
        With Label_Leyenda
            .Name = "Label_Leyenda"  ' Asignas el nombre del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Text = "LEYENDA Y CONTADORES" ' Asignas el texto del objeto
            .Font = New Font("Tahoma", 12, FontStyle.Bold)
        End With
        Panel_Leyenda.Controls.Add(Label_Leyenda)
        Panel_Leyenda.SendToBack()

        'textos de la leyenda
        Dim Leyenda_1 As New Label()
        With Leyenda_1
            .Name = "Leyenda_1"  ' Asignas el nombre del objeto
            .Text = "Leyenda_1" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            '.Font = New Font("Tahoma", 12, FontStyle.Bold)
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_1)

        Dim Leyenda_2 As New Label()
        With Leyenda_2
            .Name = "Leyenda_2"  ' Asignas el nombre del objeto
            .Text = "Leyenda_2" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_2)

        Dim Leyenda_3 As New Label()
        With Leyenda_3
            .Name = "Leyenda_3"  ' Asignas el nombre del objeto
            .Text = "Leyenda_3" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_3)

        Dim Leyenda_4 As New Label()
        With Leyenda_4
            .Name = "Leyenda_4"  ' Asignas el nombre del objeto
            .Text = "Leyenda_4" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_4)

        Dim Leyenda_5 As New Label()
        With Leyenda_5
            .Name = "Leyenda_5"  ' Asignas el nombre del objeto
            .Text = "Leyenda_5" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_5)

        Dim Leyenda_6 As New Label()
        With Leyenda_6
            .Name = "Leyenda_6"  ' Asignas el nombre del objeto
            .Text = "Leyenda_6" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_6)

        Dim Leyenda_7 As New Label()
        With Leyenda_7
            .Name = "Leyenda_7"  ' Asignas el nombre del objeto
            .Text = "Leyenda_7" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_7)

        Dim Leyenda_8 As New Label()
        With Leyenda_8
            .Name = "Leyenda_8"  ' Asignas el nombre del objeto
            .Text = "Leyenda_8" ' Asignas el texto del objeto
            .AutoSize = True
            .BackColor = System.Drawing.Color.Transparent
            .Font = Font_Leyenda
        End With
        Me.Controls.Add(Leyenda_8)

        '*****ICONOS de la leyenda
        Dim Icono_Leyenda_1 As New Button()
        With Icono_Leyenda_1
            .Name = "Icono_Leyenda_1"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_1)

        Dim Icono_Leyenda_2 As New Button()
        With Icono_Leyenda_2
            .Name = "Icono_Leyenda_2"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_2)

        Dim Icono_Leyenda_3 As New Button()
        With Icono_Leyenda_3
            .Name = "Icono_Leyenda_3"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_3)

        Dim Icono_Leyenda_4 As New Button()
        With Icono_Leyenda_4
            .Name = "Icono_Leyenda_4"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_4)

        Dim Icono_Leyenda_5 As New Button()
        With Icono_Leyenda_5
            .Name = "Icono_Leyenda_5"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_5)

        Dim Icono_Leyenda_6 As New Button()
        With Icono_Leyenda_6
            .Name = "Icono_Leyenda_6"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_6)

        Dim Icono_Leyenda_7 As New Button()
        With Icono_Leyenda_7
            .Name = "Icono_Leyenda_7"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_7)

        Dim Icono_Leyenda_8 As New Button()
        With Icono_Leyenda_8
            .Name = "Icono_Leyenda_8"
            .Text = "000"
            .Size = New System.Drawing.Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .BackgroundImage = My.Resources.borrar
            .FlatAppearance.BorderSize = 0
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'calculo de las posiciones 
        colocar_leyenda_tipo_auxiliar()

        'Colocar todos los elementos de la pantalla
        Panel_filtros.Location = New System.Drawing.Point(LF_pos_x, LF_pos_y)
        Panel_filtros.Size = New System.Drawing.Size(LF_long_x, LF_long_y)

        Panel_Leyenda.Location = New System.Drawing.Point(LL_pos_x, LL_pos_y)
        Panel_Leyenda.Size = New System.Drawing.Size(LL_long_x, LL_long_y)

        Leyenda_1.Location = New System.Drawing.Point(L1_x, L1_y)
        Leyenda_2.Location = New System.Drawing.Point(L2_x, L2_y)
        Leyenda_3.Location = New System.Drawing.Point(L3_x, L3_y)
        Leyenda_4.Location = New System.Drawing.Point(L4_x, L4_y)
        Leyenda_5.Location = New System.Drawing.Point(L5_x, L5_y)
        Leyenda_6.Location = New System.Drawing.Point(L6_x, L6_y)
        Leyenda_7.Location = New System.Drawing.Point(L7_x, L7_y)
        Leyenda_8.Location = New System.Drawing.Point(L8_x, L8_y)

        Icono_Leyenda_1.Location = New System.Drawing.Point(IL1_x, IL1_y)
        Icono_Leyenda_2.Location = New System.Drawing.Point(IL2_x, IL2_y)
        Icono_Leyenda_3.Location = New System.Drawing.Point(IL3_x, IL3_y)
        Icono_Leyenda_4.Location = New System.Drawing.Point(IL4_x, IL4_y)
        Icono_Leyenda_5.Location = New System.Drawing.Point(IL5_x, IL5_y)
        Icono_Leyenda_6.Location = New System.Drawing.Point(IL6_x, IL6_y)
        Icono_Leyenda_7.Location = New System.Drawing.Point(IL7_x, IL7_y)
        Icono_Leyenda_8.Location = New System.Drawing.Point(IL8_x, IL8_y)

        'Texto leyenda
        Leyenda_1.Text = "OCUPADO"
        Leyenda_2.Text = "LIBRE"
        Leyenda_3.Text = "LEYENDA 3"
        Leyenda_4.Text = "LEYENDA 4"
        Leyenda_5.Text = "LEYENDA 5"
        Leyenda_6.Text = "LEYENDA 6"
        Leyenda_7.Text = "LEYENDA 7"
        Leyenda_8.Text = "LEYENDA 8"

        'activar visualización texto leyenda
        Leyenda_1.Visible = True
        Leyenda_2.Visible = True
        Leyenda_3.Visible = False
        Leyenda_4.Visible = False
        Leyenda_5.Visible = False
        Leyenda_6.Visible = False
        Leyenda_7.Visible = False
        Leyenda_8.Visible = False

        'activar visualización texto leyenda
        Icono_Leyenda_1.Visible = True
        Icono_Leyenda_2.Visible = True
        Icono_Leyenda_3.Visible = False
        Icono_Leyenda_4.Visible = False
        Icono_Leyenda_5.Visible = False
        Icono_Leyenda_6.Visible = False
        Icono_Leyenda_7.Visible = False
        Icono_Leyenda_8.Visible = False

        'Dato de contador a mostrar
        Icono_Leyenda_1.Text = Contador_Condicion_2.ToString
        Icono_Leyenda_2.Text = Contador_Condicion_1.ToString
        'Icono_Leyenda_3.Text = Contador_Cava.ToString
        'Icono_Leyenda_4.Text = Contador_Rosado.ToString
        'Icono_Leyenda_5.Text = Contador_Otro.ToString
        'Icono_Leyenda_6.Text = Contador_Libre.ToString
        'Icono_Leyenda_7.Text = Contador_Otra.ToString
        'Icono_Leyenda_8.Text = Contador_Libre.ToString

        'imagen para el icono de leyenda
        Icono_Leyenda_1.BackgroundImage = My.Resources.circulo_amarillo
        Icono_Leyenda_2.BackgroundImage = My.Resources.circulo_negro
        'Icono_Leyenda_3.BackgroundImage = My.Resources.circulo_amarillo
        'Icono_Leyenda_4.BackgroundImage = My.Resources.circulo_rojo
        'Icono_Leyenda_5.BackgroundImage = My.Resources.circulo_azul
        'Icono_Leyenda_6.BackgroundImage = My.Resources.circulo_blanco
        'Icono_Leyenda_7.BackgroundImage = My.Resources.circulo_gris
        'Icono_Leyenda_8.BackgroundImage = My.Resources.circulo_blanco

        'activar mensajes informativos al pasar por el boton
        Me.ToolTip1.SetToolTip(Icono_Leyenda_1, "Nº de botellas " & Leyenda_1.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_2, "Nº de botellas " & Leyenda_2.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_3, "Nº de botellas " & Leyenda_3.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_4, "Nº de botellas " & Leyenda_4.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_5, "Nº de botellas " & Leyenda_5.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_6, "Nº de botellas " & Leyenda_6.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_7, "Nº de botellas " & Leyenda_7.Text)
        Me.ToolTip1.SetToolTip(Icono_Leyenda_8, "Nº de botellas " & Leyenda_8.Text)

        'Colores de los botones
        Icono_Leyenda_1.ForeColor = Color.Black
        Icono_Leyenda_2.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_3.ForeColor = Color.Black
        Icono_Leyenda_4.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_5.ForeColor = SystemColors.ControlLight
        Icono_Leyenda_6.ForeColor = Color.Black
        Icono_Leyenda_7.ForeColor = Color.Black
        Icono_Leyenda_8.ForeColor = Color.Black

        'quitar el fondo blanco al pasar el raton
        Icono_Leyenda_1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_2.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_3.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_4.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_5.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_6.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_7.FlatAppearance.MouseOverBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseDownBackColor = Color.Transparent
        Icono_Leyenda_8.FlatAppearance.MouseOverBackColor = Color.Transparent

        'Tamaño de los textos
        Icono_Leyenda_1.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_2.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_3.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_4.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_5.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_6.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_7.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Icono_Leyenda_8.Font = New Font("Tahoma", 12, FontStyle.Bold)

        'para conseguir que los botones no se queden por debajo del panel del fondo
        panel_fondo.SendToBack()

        Panel_filtros.SendToBack()
        Panel_Leyenda.SendToBack()

        Panel_filtros.Visible = True
        Panel_Leyenda.Visible = True

    End Sub


End Class