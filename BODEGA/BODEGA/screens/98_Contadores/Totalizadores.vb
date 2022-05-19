Public Class Totalizadores

    Private Sub Totalizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(23, 550)
            '.BackColor = System.Drawing.Color.Silver
            .BackgroundImage = My.Resources.regreso
            .BackgroundImageLayout = ImageLayout.Stretch
        End With
        AddHandler boton_1.Click, AddressOf b_Cerrar_Click   ' Asocias el evento al método Button_Click
        Me.Controls.Add(boton_1)

        Dim n As Integer

        'Reset de variables totalizadores

        Total_huecos = 0
        Total_tintos = 0
        Total_blancos = 0
        Total_rosados = 0
        Total_cavas = 0
        Total_otros = 0

        Total_rioja = 0
        Total_valdepenas = 0
        Total_ribera = 0

        Total_cosecha = 0
        Total_reserva = 0
        Total_Gran_reserva = 0
        Total_crianza = 0

        For n = 0 To 501

            'contar numero de botellas/ huecos ocupados
            If N_Marca(n) <> "MARCA" Then
                Total_huecos = Total_huecos + 1
            End If

            'contar numero de tintos
            If N_Tipo(n) = "Tinto" Then
                Total_tintos = Total_tintos + 1
            End If

            'contar numero de blancos
            If N_Tipo(n) = "Blanco" Then
                Total_blancos = Total_blancos + 1
            End If

            'contar numero de rosados
            If N_Tipo(n) = "Rosado" Then
                Total_rosados = Total_rosados + 1
            End If

            'contar numero de cavas/ champan
            If N_Tipo(n) = "Cava/Champan" Then
                Total_cavas = Total_cavas + 1
            End If

            'contar numero de licores o huecos utilizados para otras cosas
            If N_Tipo(n) = "Otro" Then
                Total_otros = Total_otros + 1
            End If

            'contar numero de vinos de cosecha
            If N_Maduracion(n) = "Cosecha" Then
                Total_cosecha = Total_cosecha + 1
            End If

            'contar numero de vinos de reserva
            If N_Maduracion(n) = "Reserva" Then
                Total_reserva = Total_reserva + 1
            End If

            'contar numero de vinos de gran reserva
            If N_Maduracion(n) = "Gran Reserva" Then
                Total_Gran_reserva = Total_Gran_reserva + 1
            End If

            'contar numero de vinos de crianza
            If N_Maduracion(n) = "Crianza" Then
                Total_crianza = Total_crianza + 1
            End If

            'contar numero de riojas
            If N_Denominacion(n) = "Rioja" Then
                Total_rioja = Total_rioja + 1
            End If

            'contar numero de riberas del duero
            If N_Denominacion(n) = "Ribera del Duero" Then
                Total_ribera = Total_ribera + 1
            End If

            'contar numero de vadelpéñas
            If N_Denominacion(n) = "Valdepeñas" Then
                Total_valdepenas = Total_valdepenas + 1
            End If
        Next

        'Visualizar numeros
        Numero_vinos.Text = Total_huecos.ToString

        'Según tipo de vino
        Numero_tintos.Text = Total_tintos.ToString
        Numero_blancos.Text = Total_blancos.ToString
        Numero_rosados.Text = Total_rosados.ToString
        Numero_cavas.Text = Total_cavas.ToString

        'Según maduracion
        Numero_cosecha.Text = Total_cosecha.ToString
        Numero_reserva.Text = Total_reserva.ToString
        Numero_gran_reserva.Text = Total_Gran_reserva.ToString
        Numero_crianza.Text = Total_crianza.ToString

        'Según Denominacion de Origen
        Numero_riojas.Text = Total_rioja.ToString
        Numero_riberas.Text = Total_ribera.ToString
        Numero_valdepenas.Text = Total_valdepenas.ToString

    End Sub


    Private Sub b_Cerrar_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON CERRAR
        Dispose()
        Close()
    End Sub

    Private Sub b_showCatalog_Click(sender As Object, e As EventArgs) Handles b_showCatalog.Click
        Folleto_Vinos.Show()
    End Sub


End Class