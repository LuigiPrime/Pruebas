Module Leyenda

    'variables para fijar las coordenadas de los label de la leyenda
    Public L1_x As Integer
    Public L2_x As Integer
    Public L3_x As Integer
    Public L4_x As Integer
    Public L5_x As Integer
    Public L6_x As Integer
    Public L7_x As Integer
    Public L8_x As Integer

    Public L1_y As Integer
    Public L2_y As Integer
    Public L3_y As Integer
    Public L4_y As Integer
    Public L5_y As Integer
    Public L6_y As Integer
    Public L7_y As Integer
    Public L8_y As Integer

    Public Leyenda_offset_X As Integer
    Public Leyenda_offset_Y As Integer

    'variables para fijar las coordenadas de los iconos de la leyenda
    Public IL1_x As Integer
    Public IL2_x As Integer
    Public IL3_x As Integer
    Public IL4_x As Integer
    Public IL5_x As Integer
    Public IL6_x As Integer
    Public IL7_x As Integer
    Public IL8_x As Integer

    Public IL1_y As Integer
    Public IL2_y As Integer
    Public IL3_y As Integer
    Public IL4_y As Integer
    Public IL5_y As Integer
    Public IL6_y As Integer
    Public IL7_y As Integer
    Public IL8_y As Integer

    Public ILeyenda_offset_X As Integer
    Public ILeyenda_offset_Y As Integer


    'variables para fijar tamaño y posicion del label filtros
    Public LF_pos_x As Integer
    Public LF_pos_y As Integer
    Public LF_long_x As Integer
    Public LF_long_y As Integer

    'variables para fijar tamaño y posicion del label leyenda
    Public LL_pos_x As Integer
    Public LL_pos_y As Integer
    Public LL_long_x As Integer
    Public LL_long_y As Integer

    'forma tipo de texto para leyenda
    Public Fuente_tipo_1 As FontFamily
    Public Font_Leyenda As New Font("Tahoma", 10, FontStyle.Bold)


    'variables para fijar tamaño y posicion del label filtros


    Public Sub colocar_leyenda_tipo_principal()

        '*************************
        '*****COLOCACION DE LOS TEXTOS TIPO LABEL 
        '*************************

        'fijar separacion entre cada elemento
        Leyenda_offset_X = 168
        Leyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        L1_x = 72
        L2_x = L1_x + Leyenda_offset_X
        L3_x = L2_x + Leyenda_offset_X
        L4_x = L3_x + Leyenda_offset_X
        L5_x = L4_x + Leyenda_offset_X
        L6_x = L5_x + Leyenda_offset_X
        L7_x = L6_x + Leyenda_offset_X
        L8_x = L7_x + Leyenda_offset_X

        'calculo de los valores de posicion coordenada y
        L1_y = 660
        L2_y = L1_y + Leyenda_offset_Y
        L3_y = L2_y + Leyenda_offset_Y
        L4_y = L3_y + Leyenda_offset_Y
        L5_y = L4_y + Leyenda_offset_Y
        L6_y = L5_y + Leyenda_offset_Y
        L7_y = L6_y + Leyenda_offset_Y
        L8_y = L7_y + Leyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS ICONOS + CONTADORES 
        '*************************

        'fijar separacion entre cada elemento
        ILeyenda_offset_X = 168
        ILeyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        IL1_x = 16
        IL2_x = IL1_x + ILeyenda_offset_X
        IL3_x = IL2_x + ILeyenda_offset_X
        IL4_x = IL3_x + ILeyenda_offset_X
        IL5_x = IL4_x + ILeyenda_offset_X
        IL6_x = IL5_x + ILeyenda_offset_X
        IL7_x = IL6_x + ILeyenda_offset_X
        IL8_x = IL7_x + ILeyenda_offset_X

        'calculo de los valores de posicion coordenada y
        IL1_y = 647
        IL2_y = IL1_y + ILeyenda_offset_Y
        IL3_y = IL2_y + ILeyenda_offset_Y
        IL4_y = IL3_y + ILeyenda_offset_Y
        IL5_y = IL4_y + ILeyenda_offset_Y
        IL6_y = IL5_y + ILeyenda_offset_Y
        IL7_y = IL6_y + ILeyenda_offset_Y
        IL8_y = IL7_y + ILeyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS LABEL FILTROS
        '*************************
        LF_pos_x = 0
        LF_pos_y = 490
        LF_long_x = 1365
        LF_long_y = 25

        '*************************
        '*****COLOCACION DE LOS LABEL LEYENDA
        '*************************
        LL_pos_x = LF_pos_x
        LL_pos_y = 600
        LL_long_x = LF_long_x
        LL_long_y = 25

    End Sub


    Public Sub colocar_leyenda_tipo_lenera()

        '*************************
        '*****COLOCACION DE LOS TEXTOS TIPO LABEL 
        '*************************

        'fijar separacion entre cada elemento
        Leyenda_offset_X = 168
        Leyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        L1_x = 72
        L2_x = L1_x + Leyenda_offset_X
        L3_x = L2_x + Leyenda_offset_X
        L4_x = L3_x + Leyenda_offset_X
        L5_x = L4_x + Leyenda_offset_X
        L6_x = L5_x + Leyenda_offset_X
        L7_x = L6_x + Leyenda_offset_X
        L8_x = L7_x + Leyenda_offset_X

        'calculo de los valores de posicion coordenada y
        L1_y = 660
        L2_y = L1_y + Leyenda_offset_Y
        L3_y = L2_y + Leyenda_offset_Y
        L4_y = L3_y + Leyenda_offset_Y
        L5_y = L4_y + Leyenda_offset_Y
        L6_y = L5_y + Leyenda_offset_Y
        L7_y = L6_y + Leyenda_offset_Y
        L8_y = L7_y + Leyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS ICONOS + CONTADORES 
        '*************************

        'fijar separacion entre cada elemento
        ILeyenda_offset_X = 168
        ILeyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        IL1_x = 16
        IL2_x = IL1_x + ILeyenda_offset_X
        IL3_x = IL2_x + ILeyenda_offset_X
        IL4_x = IL3_x + ILeyenda_offset_X
        IL5_x = IL4_x + ILeyenda_offset_X
        IL6_x = IL5_x + ILeyenda_offset_X
        IL7_x = IL6_x + ILeyenda_offset_X
        IL8_x = IL7_x + ILeyenda_offset_X

        'calculo de los valores de posicion coordenada y
        IL1_y = 647
        IL2_y = IL1_y + ILeyenda_offset_Y
        IL3_y = IL2_y + ILeyenda_offset_Y
        IL4_y = IL3_y + ILeyenda_offset_Y
        IL5_y = IL4_y + ILeyenda_offset_Y
        IL6_y = IL5_y + ILeyenda_offset_Y
        IL7_y = IL6_y + ILeyenda_offset_Y
        IL8_y = IL7_y + ILeyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS LABEL FILTROS
        '*************************
        LF_pos_x = 0
        LF_pos_y = 490
        LF_long_x = 1345
        LF_long_y = 25

        '*************************
        '*****COLOCACION DE LOS LABEL LEYENDA
        '*************************
        LL_pos_x = LF_pos_x
        LL_pos_y = 600
        LL_long_x = LF_long_x
        LL_long_y = 25

    End Sub


    Public Sub colocar_leyenda_tipo_despensa()

        '*************************
        '*****COLOCACION DE LOS LABEL FILTROS
        '*************************
        LF_pos_x = 8
        LF_pos_y = 490
        LF_long_x = 1350
        LF_long_y = 25

        '*************************
        '*****COLOCACION DE LOS LABEL LEYENDA
        '*************************
        LL_pos_x = LF_pos_x
        LL_pos_y = 600
        LL_long_x = LF_long_x
        LL_long_y = 25

        'fijar separacion entre cada elemento
        Leyenda_offset_X = 168
        Leyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        L1_x = 72
        L2_x = L1_x + Leyenda_offset_X
        L3_x = L2_x + Leyenda_offset_X
        L4_x = L3_x + Leyenda_offset_X
        L5_x = L4_x + Leyenda_offset_X
        L6_x = L5_x + Leyenda_offset_X
        L7_x = L6_x + Leyenda_offset_X
        L8_x = L7_x + Leyenda_offset_X

        'calculo de los valores de posicion coordenada y
        L1_y = LL_pos_y + LL_long_y + 20
        L2_y = L1_y + Leyenda_offset_Y
        L3_y = L2_y + Leyenda_offset_Y
        L4_y = L3_y + Leyenda_offset_Y
        L5_y = L4_y + Leyenda_offset_Y
        L6_y = L5_y + Leyenda_offset_Y
        L7_y = L6_y + Leyenda_offset_Y
        L8_y = L7_y + Leyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS ICONOS + CONTADORES 
        '*************************

        'fijar separacion entre cada elemento
        ILeyenda_offset_X = 168
        ILeyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        IL1_x = 16
        IL2_x = IL1_x + ILeyenda_offset_X
        IL3_x = IL2_x + ILeyenda_offset_X
        IL4_x = IL3_x + ILeyenda_offset_X
        IL5_x = IL4_x + ILeyenda_offset_X
        IL6_x = IL5_x + ILeyenda_offset_X
        IL7_x = IL6_x + ILeyenda_offset_X
        IL8_x = IL7_x + ILeyenda_offset_X

        'calculo de los valores de posicion coordenada y
        IL1_y = LL_pos_y + LL_long_y + 20
        IL2_y = IL1_y + ILeyenda_offset_Y
        IL3_y = IL2_y + ILeyenda_offset_Y
        IL4_y = IL3_y + ILeyenda_offset_Y
        IL5_y = IL4_y + ILeyenda_offset_Y
        IL6_y = IL5_y + ILeyenda_offset_Y
        IL7_y = IL6_y + ILeyenda_offset_Y
        IL8_y = IL7_y + ILeyenda_offset_Y



    End Sub


    Public Sub colocar_leyenda_tipo_auxiliar()

        '*************************
        '*****COLOCACION DE LOS TEXTOS TIPO LABEL 
        '*************************

        '*************************
        '*****COLOCACION DE LOS LABEL FILTROS
        '*************************
        LF_pos_x = 0
        LF_pos_y = 320
        LF_long_x = 1365
        LF_long_y = 25

        '*************************
        '*****COLOCACION DE LOS LABEL LEYENDA
        '*************************
        LL_pos_x = LF_pos_x
        LL_pos_y = 450
        LL_long_x = LF_long_x
        LL_long_y = 25


        'fijar separacion entre cada elemento
        Leyenda_offset_X = 168
        Leyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        L1_x = 72
        L2_x = L1_x + Leyenda_offset_X
        L3_x = L2_x + Leyenda_offset_X
        L4_x = L3_x + Leyenda_offset_X
        L5_x = L4_x + Leyenda_offset_X
        L6_x = L5_x + Leyenda_offset_X
        L7_x = L6_x + Leyenda_offset_X
        L8_x = L7_x + Leyenda_offset_X

        'calculo de los valores de posicion coordenada y
        L1_y = LL_pos_y + LL_long_y + 20
        L2_y = L1_y + Leyenda_offset_Y
        L3_y = L2_y + Leyenda_offset_Y
        L4_y = L3_y + Leyenda_offset_Y
        L5_y = L4_y + Leyenda_offset_Y
        L6_y = L5_y + Leyenda_offset_Y
        L7_y = L6_y + Leyenda_offset_Y
        L8_y = L7_y + Leyenda_offset_Y

        '*************************
        '*****COLOCACION DE LOS ICONOS + CONTADORES 
        '*************************


        'fijar separacion entre cada elemento
        ILeyenda_offset_X = 168
        ILeyenda_offset_Y = 0

        'calculo de los valores de posicion coordenada X
        IL1_x = 16
        IL2_x = IL1_x + ILeyenda_offset_X
        IL3_x = IL2_x + ILeyenda_offset_X
        IL4_x = IL3_x + ILeyenda_offset_X
        IL5_x = IL4_x + ILeyenda_offset_X
        IL6_x = IL5_x + ILeyenda_offset_X
        IL7_x = IL6_x + ILeyenda_offset_X
        IL8_x = IL7_x + ILeyenda_offset_X

        'calculo de los valores de posicion coordenada y
        IL1_y = LL_pos_y + LL_long_y + 20
        IL2_y = IL1_y + ILeyenda_offset_Y
        IL3_y = IL2_y + ILeyenda_offset_Y
        IL4_y = IL3_y + ILeyenda_offset_Y
        IL5_y = IL4_y + ILeyenda_offset_Y
        IL6_y = IL5_y + ILeyenda_offset_Y
        IL7_y = IL6_y + ILeyenda_offset_Y
        IL8_y = IL7_y + ILeyenda_offset_Y

    End Sub

End Module
