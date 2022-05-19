Public Class Bodega_Huecos_Principal

    Private Sub Bodega_Huecos_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Borrar todos los controles creados
        Me.Controls.Clear()
        'llamada a la funcion
        Principal_Creador_Filtro_Huecos()
    End Sub

    Private Sub b_Photo_Click(ByVal sender As Object, ByVal e As EventArgs)
        'mostrar la foto de la zona
        Info_Detalle_Zona_Principal.Show()
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Select Case CType(sender, System.Windows.Forms.Button).Name
            Case "Hueco1"
                ID_NUMERO = 0
            Case "Hueco2"
                ID_NUMERO = 1
            Case "Hueco3"
                ID_NUMERO = 2
            Case "Hueco4"
                ID_NUMERO = 3
            Case "Hueco5"
                ID_NUMERO = 4
            Case "Hueco6"
                ID_NUMERO = 5
            Case "Hueco7"
                ID_NUMERO = 6
            Case "Hueco8"
                ID_NUMERO = 7
            Case "Hueco9"
                ID_NUMERO = 8
            Case "Hueco10"
                ID_NUMERO = 9
            Case "Hueco11"
                ID_NUMERO = 10
            Case "Hueco12"
                ID_NUMERO = 11
            Case "Hueco13"
                ID_NUMERO = 12
            Case "Hueco14"
                ID_NUMERO = 13
            Case "Hueco15"
                ID_NUMERO = 14
            Case "Hueco16"
                ID_NUMERO = 15
            Case "Hueco17"
                ID_NUMERO = 16
            Case "Hueco18"
                ID_NUMERO = 17
            Case "Hueco19"
                ID_NUMERO = 18
            Case "Hueco20"
                ID_NUMERO = 19
            Case "Hueco21"
                ID_NUMERO = 20
            Case "Hueco22"
                ID_NUMERO = 21
            Case "Hueco23"
                ID_NUMERO = 22
            Case "Hueco24"
                ID_NUMERO = 23
            Case "Hueco25"
                ID_NUMERO = 24
            Case "Hueco26"
                ID_NUMERO = 25
            Case "Hueco27"
                ID_NUMERO = 26
            Case "Hueco28"
                ID_NUMERO = 27
            Case "Hueco29"
                ID_NUMERO = 28
            Case "Hueco30"
                ID_NUMERO = 29
            Case "Hueco31"
                ID_NUMERO = 30
            Case "Hueco32"
                ID_NUMERO = 31
            Case "Hueco33"
                ID_NUMERO = 32
            Case "Hueco34"
                ID_NUMERO = 33
            Case "Hueco35"
                ID_NUMERO = 34
            Case "Hueco36"
                ID_NUMERO = 35
            Case "Hueco37"
                ID_NUMERO = 36
            Case "Hueco38"
                ID_NUMERO = 37
            Case "Hueco39"
                ID_NUMERO = 38
            Case "Hueco40"
                ID_NUMERO = 39
            Case "Hueco41"
                ID_NUMERO = 40
            Case "Hueco42"
                ID_NUMERO = 41
            Case "Hueco43"
                ID_NUMERO = 42
            Case "Hueco44"
                ID_NUMERO = 43
            Case "Hueco45"
                ID_NUMERO = 44
            Case "Hueco46"
                ID_NUMERO = 45
            Case "Hueco47"
                ID_NUMERO = 46
            Case "Hueco48"
                ID_NUMERO = 47
            Case "Hueco49"
                ID_NUMERO = 48
            Case "Hueco50"
                ID_NUMERO = 49
            Case "Hueco51"
                ID_NUMERO = 50
            Case "Hueco52"
                ID_NUMERO = 51
            Case "Hueco53"
                ID_NUMERO = 52
            Case "Hueco54"
                ID_NUMERO = 53
            Case "Hueco55"
                ID_NUMERO = 54
            Case "Hueco56"
                ID_NUMERO = 55
            Case "Hueco57"
                ID_NUMERO = 56
            Case "Hueco58"
                ID_NUMERO = 57
            Case "Hueco59"
                ID_NUMERO = 58
            Case "Hueco60"
                ID_NUMERO = 59
            Case "Hueco61"
                ID_NUMERO = 60
            Case "Hueco62"
                ID_NUMERO = 61
            Case "Hueco63"
                ID_NUMERO = 62
            Case "Hueco64"
                ID_NUMERO = 63
            Case "Hueco65"
                ID_NUMERO = 64
            Case "Hueco66"
                ID_NUMERO = 65
            Case "Hueco67"
                ID_NUMERO = 66
            Case "Hueco68"
                ID_NUMERO = 67
            Case "Hueco69"
                ID_NUMERO = 68
            Case "Hueco70"
                ID_NUMERO = 69
            Case "Hueco71"
                ID_NUMERO = 70
            Case "Hueco72"
                ID_NUMERO = 71
            Case "Hueco73"
                ID_NUMERO = 72
            Case "Hueco74"
                ID_NUMERO = 73
            Case "Hueco75"
                ID_NUMERO = 74
            Case "Hueco76"
                ID_NUMERO = 75
            Case "Hueco77"
                ID_NUMERO = 76
            Case "Hueco78"
                ID_NUMERO = 77
            Case "Hueco79"
                ID_NUMERO = 78
            Case "Hueco80"
                ID_NUMERO = 79
            Case "Hueco81"
                ID_NUMERO = 80
            Case "Hueco82"
                ID_NUMERO = 81
            Case "Hueco83"
                ID_NUMERO = 82
            Case "Hueco84"
                ID_NUMERO = 83
            Case "Hueco85"
                ID_NUMERO = 84
            Case "Hueco86"
                ID_NUMERO = 85
            Case "Hueco87"
                ID_NUMERO = 86
            Case "Hueco88"
                ID_NUMERO = 87
            Case "Hueco89"
                ID_NUMERO = 88
            Case "Hueco90"
                ID_NUMERO = 89
            Case "Hueco91"
                ID_NUMERO = 90
            Case "Hueco92"
                ID_NUMERO = 91
            Case "Hueco93"
                ID_NUMERO = 92
            Case "Hueco94"
                ID_NUMERO = 93
            Case "Hueco95"
                ID_NUMERO = 94
            Case "Hueco96"
                ID_NUMERO = 95
            Case "Hueco97"
                ID_NUMERO = 96
            Case "Hueco98"
                ID_NUMERO = 97
            Case "Hueco99"
                ID_NUMERO = 98
            Case "Hueco100"
                ID_NUMERO = 99
            Case "Hueco101"
                ID_NUMERO = 100
            Case "Hueco102"
                ID_NUMERO = 101
            Case "Hueco103"
                ID_NUMERO = 102
            Case "Hueco104"
                ID_NUMERO = 103
            Case "Hueco105"
                ID_NUMERO = 104
            Case "Hueco106"
                ID_NUMERO = 105
            Case "Hueco107"
                ID_NUMERO = 106
            Case "Hueco108"
                ID_NUMERO = 107
            Case "Hueco109"
                ID_NUMERO = 108
            Case "Hueco110"
                ID_NUMERO = 109
            Case "Hueco111"
                ID_NUMERO = 110
            Case "Hueco112"
                ID_NUMERO = 111
            Case "Hueco113"
                ID_NUMERO = 112
            Case "Hueco114"
                ID_NUMERO = 113
            Case "Hueco115"
                ID_NUMERO = 114
            Case "Hueco116"
                ID_NUMERO = 115
            Case "Hueco117"
                ID_NUMERO = 116
            Case "Hueco118"
                ID_NUMERO = 117
            Case "Hueco119"
                ID_NUMERO = 118
            Case "Hueco120"
                ID_NUMERO = 119
            Case "Hueco121"
                ID_NUMERO = 120
            Case "Hueco122"
                ID_NUMERO = 121
            Case "Hueco123"
                ID_NUMERO = 122
            Case "Hueco124"
                ID_NUMERO = 123
            Case "Hueco125"
                ID_NUMERO = 124
            Case "Hueco126"
                ID_NUMERO = 125
            Case "Hueco127"
                ID_NUMERO = 126
            Case "Hueco128"
                ID_NUMERO = 127
            Case "Hueco129"
                ID_NUMERO = 128
            Case "Hueco130"
                ID_NUMERO = 129
            Case "Hueco131"
                ID_NUMERO = 130
            Case "Hueco132"
                ID_NUMERO = 131
            Case "Hueco133"
                ID_NUMERO = 132
            Case "Hueco134"
                ID_NUMERO = 133
            Case "Hueco135"
                ID_NUMERO = 134
            Case "Hueco136"
                ID_NUMERO = 135
            Case "Hueco137"
                ID_NUMERO = 136
            Case "Hueco138"
                ID_NUMERO = 137
            Case "Hueco139"
                ID_NUMERO = 138
            Case "Hueco140"
                ID_NUMERO = 139
            Case "Hueco141"
                ID_NUMERO = 140
            Case "Hueco142"
                ID_NUMERO = 141
            Case "Hueco143"
                ID_NUMERO = 142
            Case "Hueco144"
                ID_NUMERO = 143
            Case "Hueco145"
                ID_NUMERO = 144
            Case "Hueco146"
                ID_NUMERO = 145
            Case "Hueco147"
                ID_NUMERO = 146
            Case "Hueco148"
                ID_NUMERO = 147
            Case "Hueco149"
                ID_NUMERO = 148
            Case "Hueco150"
                ID_NUMERO = 149
            Case "Hueco151"
                ID_NUMERO = 150
            Case "Hueco152"
                ID_NUMERO = 151
            Case "Hueco153"
                ID_NUMERO = 152
            Case "Hueco154"
                ID_NUMERO = 153
            Case "Hueco155"
                ID_NUMERO = 154
            Case "Hueco156"
                ID_NUMERO = 155
            Case "Hueco157"
                ID_NUMERO = 156
            Case "Hueco158"
                ID_NUMERO = 157
            Case "Hueco159"
                ID_NUMERO = 158
            Case "Hueco160"
                ID_NUMERO = 159
            Case "Hueco161"
                ID_NUMERO = 160
            Case "Hueco162"
                ID_NUMERO = 161
            Case "Hueco163"
                ID_NUMERO = 162
            Case "Hueco164"
                ID_NUMERO = 163
            Case "Hueco165"
                ID_NUMERO = 164
            Case "Hueco166"
                ID_NUMERO = 165
            Case "Hueco167"
                ID_NUMERO = 166
            Case "Hueco168"
                ID_NUMERO = 167
            Case "Hueco169"
                ID_NUMERO = 168
            Case "Hueco170"
                ID_NUMERO = 169
            Case "Hueco171"
                ID_NUMERO = 170
            Case "Hueco172"
                ID_NUMERO = 171
            Case "Hueco173"
                ID_NUMERO = 172
            Case "Hueco174"
                ID_NUMERO = 173
            Case "Hueco175"
                ID_NUMERO = 174
            Case "Hueco176"
                ID_NUMERO = 175
            Case "Hueco177"
                ID_NUMERO = 176
            Case "Hueco178"
                ID_NUMERO = 177
            Case "Hueco179"
                ID_NUMERO = 178
            Case "Hueco180"
                ID_NUMERO = 179
            Case "Hueco181"
                ID_NUMERO = 180
            Case "Hueco182"
                ID_NUMERO = 181
            Case "Hueco183"
                ID_NUMERO = 182
            Case "Hueco184"
                ID_NUMERO = 183
            Case "Hueco185"
                ID_NUMERO = 184
            Case "Hueco186"
                ID_NUMERO = 185
            Case "Hueco187"
                ID_NUMERO = 186
            Case "Hueco188"
                ID_NUMERO = 187
            Case "Hueco189"
                ID_NUMERO = 188
            Case "Hueco190"
                ID_NUMERO = 189
            Case "Hueco191"
                ID_NUMERO = 190
            Case "Hueco192"
                ID_NUMERO = 191
            Case "Hueco193"
                ID_NUMERO = 192
            Case "Hueco194"
                ID_NUMERO = 193
            Case "Hueco195"
                ID_NUMERO = 194
            Case "Hueco196"
                ID_NUMERO = 195
            Case "Hueco197"
                ID_NUMERO = 196
            Case "Hueco198"
                ID_NUMERO = 197
            Case "Hueco199"
                ID_NUMERO = 198
            Case "Hueco200"
                ID_NUMERO = 199
            Case "Hueco201"
                ID_NUMERO = 200
            Case "Hueco202"
                ID_NUMERO = 201
            Case "Hueco203"
                ID_NUMERO = 202
            Case "Hueco204"
                ID_NUMERO = 203
            Case "Hueco205"
                ID_NUMERO = 204
            Case "Hueco206"
                ID_NUMERO = 205
            Case "Hueco207"
                ID_NUMERO = 206
            Case "Hueco208"
                ID_NUMERO = 207
            Case "Hueco209"
                ID_NUMERO = 208
            Case "Hueco210"
                ID_NUMERO = 209
            Case "Hueco211"
                ID_NUMERO = 210
            Case "Hueco212"
                ID_NUMERO = 211
            Case "Hueco213"
                ID_NUMERO = 212
            Case "Hueco214"
                ID_NUMERO = 213
            Case "Hueco215"
                ID_NUMERO = 214
            Case "Hueco216"
                ID_NUMERO = 215
            Case "Hueco217"
                ID_NUMERO = 216
            Case "Hueco218"
                ID_NUMERO = 217
            Case "Hueco219"
                ID_NUMERO = 218
            Case "Hueco220"
                ID_NUMERO = 219
            Case "Hueco221"
                ID_NUMERO = 220
            Case "Hueco222"
                ID_NUMERO = 221
            Case "Hueco223"
                ID_NUMERO = 222
            Case "Hueco224"
                ID_NUMERO = 223
            Case "Hueco225"
                ID_NUMERO = 224
            Case "Hueco226"
                ID_NUMERO = 225
            Case "Hueco227"
                ID_NUMERO = 226
            Case "Hueco228"
                ID_NUMERO = 227
            Case "Hueco229"
                ID_NUMERO = 228
            Case "Hueco230"
                ID_NUMERO = 229
            Case "Hueco231"
                ID_NUMERO = 230
            Case "Hueco232"
                ID_NUMERO = 231
            Case "Hueco233"
                ID_NUMERO = 232
            Case "Hueco234"
                ID_NUMERO = 233
            Case "Hueco235"
                ID_NUMERO = 234
            Case "Hueco236"
                ID_NUMERO = 235
            Case "Hueco237"
                ID_NUMERO = 236
            Case "Hueco238"
                ID_NUMERO = 237
            Case "Hueco239"
                ID_NUMERO = 238
            Case "Hueco240"
                ID_NUMERO = 239
            Case "Hueco241"
                ID_NUMERO = 240
            Case "Hueco242"
                ID_NUMERO = 241
            Case "Hueco243"
                ID_NUMERO = 242
            Case "Hueco244"
                ID_NUMERO = 243
            Case "Hueco245"
                ID_NUMERO = 244
            Case "Hueco246"
                ID_NUMERO = 245
            Case "Hueco247"
                ID_NUMERO = 246
            Case "Hueco248"
                ID_NUMERO = 247
            Case "Hueco249"
                ID_NUMERO = 248
            Case "Hueco250"
                ID_NUMERO = 249
            Case "Hueco251"
                ID_NUMERO = 250
            Case "Hueco252"
                ID_NUMERO = 251
            Case "Hueco253"
                ID_NUMERO = 252
            Case "Hueco254"
                ID_NUMERO = 253
            Case "Hueco255"
                ID_NUMERO = 254
            Case "Hueco256"
                ID_NUMERO = 255
            Case "Hueco257"
                ID_NUMERO = 256
            Case "Hueco258"
                ID_NUMERO = 257
            Case "Hueco259"
                ID_NUMERO = 258
            Case "Hueco260"
                ID_NUMERO = 259
            Case "Hueco261"
                ID_NUMERO = 260
            Case "Hueco262"
                ID_NUMERO = 261
            Case "Hueco263"
                ID_NUMERO = 262
            Case "Hueco264"
                ID_NUMERO = 263
            Case "Hueco265"
                ID_NUMERO = 264
            Case "Hueco266"
                ID_NUMERO = 265
            Case "Hueco267"
                ID_NUMERO = 266
            Case "Hueco268"
                ID_NUMERO = 267
            Case "Hueco269"
                ID_NUMERO = 268
            Case "Hueco270"
                ID_NUMERO = 269
            Case "Hueco271"
                ID_NUMERO = 270
            Case "Hueco272"
                ID_NUMERO = 271
            Case "Hueco273"
                ID_NUMERO = 272
            Case "Hueco274"
                ID_NUMERO = 273
            Case "Hueco275"
                ID_NUMERO = 274
            Case "Hueco276"
                ID_NUMERO = 275
            Case "Hueco277"
                ID_NUMERO = 276
            Case "Hueco278"
                ID_NUMERO = 277
            Case "Hueco279"
                ID_NUMERO = 278
            Case "Hueco280"
                ID_NUMERO = 279
            Case "Hueco281"
                ID_NUMERO = 280
            Case "Hueco282"
                ID_NUMERO = 281
            Case "Hueco283"
                ID_NUMERO = 282
            Case "Hueco284"
                ID_NUMERO = 283
            Case "Hueco285"
                ID_NUMERO = 284
            Case "Hueco286"
                ID_NUMERO = 285
            Case "Hueco287"
                ID_NUMERO = 286
            Case "Hueco288"
                ID_NUMERO = 287
            Case "Hueco289"
                ID_NUMERO = 288
            Case "Hueco290"
                ID_NUMERO = 289
            Case "Hueco291"
                ID_NUMERO = 290
            Case "Hueco292"
                ID_NUMERO = 291
            Case "Hueco293"
                ID_NUMERO = 292
            Case "Hueco294"
                ID_NUMERO = 293
            Case "Hueco295"
                ID_NUMERO = 294
            Case "Hueco296"
                ID_NUMERO = 295
            Case "Hueco297"
                ID_NUMERO = 296
            Case "Hueco298"
                ID_NUMERO = 297
            Case "Hueco299"
                ID_NUMERO = 298
            Case "Hueco300"
                ID_NUMERO = 299
            Case "Hueco301"
                ID_NUMERO = 300
            Case "Hueco302"
                ID_NUMERO = 301
            Case "Hueco303"
                ID_NUMERO = 302
            Case "Hueco304"
                ID_NUMERO = 303
            Case "Hueco305"
                ID_NUMERO = 304
            Case "Hueco306"
                ID_NUMERO = 305
            Case "Hueco307"
                ID_NUMERO = 306
            Case "Hueco308"
                ID_NUMERO = 307
            Case "Hueco309"
                ID_NUMERO = 308
            Case "Hueco310"
                ID_NUMERO = 309
            Case "Hueco311"
                ID_NUMERO = 310
            Case "Hueco312"
                ID_NUMERO = 311
            Case "Hueco313"
                ID_NUMERO = 312
            Case "Hueco314"
                ID_NUMERO = 313
            Case "Hueco315"
                ID_NUMERO = 314
            Case "Hueco316"
                ID_NUMERO = 315
            Case "Hueco317"
                ID_NUMERO = 316
            Case "Hueco318"
                ID_NUMERO = 317
            Case "Hueco319"
                ID_NUMERO = 318
            Case "Hueco320"
                ID_NUMERO = 319
            Case "Hueco321"
                ID_NUMERO = 320
            Case "Hueco322"
                ID_NUMERO = 321
            Case "Hueco323"
                ID_NUMERO = 322
            Case "Hueco324"
                ID_NUMERO = 323
            Case "Hueco325"
                ID_NUMERO = 324
            Case "Hueco326"
                ID_NUMERO = 325
            Case "Hueco327"
                ID_NUMERO = 326
            Case "Hueco328"
                ID_NUMERO = 327
            Case "Hueco329"
                ID_NUMERO = 328
            Case "Hueco330"
                ID_NUMERO = 329
            Case "Hueco331"
                ID_NUMERO = 330
            Case "Hueco332"
                ID_NUMERO = 331
            Case "Hueco333"
                ID_NUMERO = 332
            Case "Hueco334"
                ID_NUMERO = 333
            Case "Hueco335"
                ID_NUMERO = 334
            Case "Hueco336"
                ID_NUMERO = 335
            Case "Hueco337"
                ID_NUMERO = 336
            Case "Hueco338"
                ID_NUMERO = 337
            Case "Hueco333"
                ID_NUMERO = 332
            Case "Hueco334"
                ID_NUMERO = 333
            Case "Hueco335"
                ID_NUMERO = 334
            Case "Hueco336"
                ID_NUMERO = 335
            Case "Hueco337"
                ID_NUMERO = 336
            Case "Hueco338"
                ID_NUMERO = 337
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
        Principal_Creador_Filtro_Huecos()
    End Sub
    Public Sub b_Filtro_Coleccion_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON FILTRO - COLECCION

        'borrar todos los controles
        Controls.Clear()
        'llamada al creador de todos los elementos
        Principal_Creador_Filtro_Coleccion()

    End Sub
    Private Sub b_Filtro_Year_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON FILTRO - AÑOS
        'borrar todos los controles
        Controls.Clear()
        'llamada al creador de todos los elementos
        Principal_Creador_Filtro_Years()
    End Sub
    Private Sub b_Filtro_DO_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON FILTRO - DO
        'borrar todos los controles
        Controls.Clear()
        'llamada al creador de todos los elementos
        Principal_Creador_Filtro_DO()
    End Sub
    Private Sub b_Filtro_Tipo_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON FILTRO - TIPO
        'borrar todos los controles
        Controls.Clear()
        'llamada al creador de todos los elementos
        Principal_Creador_Filtro_Tipo()
    End Sub
    Private Sub b_Filtro_Maduracion_Click(ByVal sender As Object, ByVal e As EventArgs)
        'ACCCION DEL BOTON FILTRO - MADURACION
        'borrar todos los controles
        Controls.Clear()
        'llamada al creador de todos los elementos
        Principal_Creador_Filtro_Maduracion()
    End Sub
    Private Sub Principal_Creador_Filtro_Huecos()

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
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0

        Dim index As String

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8


        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
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
        colocar_leyenda_tipo_principal()

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
    End Sub
    Private Sub Principal_Creador_Filtro_Coleccion()

        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR TIPO USO HUECO
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
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer
        Dim contador_libre As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0
        contador_libre = 0

        Dim index As String

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8


        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If



                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 7, FontStyle.Bold)
                    .FlatAppearance.BorderSize = 0

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
        '*****CREACION DE LEYENDA
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
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
            .TextImageRelation = TextImageRelation.TextAboveImage
            .BackColor = System.Drawing.Color.Transparent
            .UseVisualStyleBackColor = False
            .CausesValidation = False
            .BackgroundImageLayout = ImageLayout.Stretch
            .FlatStyle = FlatStyle.Flat
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

        'Incorporar panel y label para cabecera botones filtros

        colocar_leyenda_tipo_principal()

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


    End Sub
    Private Sub Principal_Creador_Filtro_DO()
        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR DENOMINACION DE ORIGEN
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
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

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

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8


        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
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

        '******************************************************************
        '*****CREACION DE LEYENDA
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
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
            .Enabled = False
        End With
        Me.Controls.Add(Icono_Leyenda_8)

        'Incorporar panel y label para cabecera botones filtros

        colocar_leyenda_tipo_principal()

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
    End Sub
    Private Sub Principal_Creador_Filtro_Maduracion()
        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR MADURACION
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
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

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

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8


        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
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
        '*****CREACION DE LEYENDA
        '*************************

        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
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

        'pasar valores a las posiciones
        colocar_leyenda_tipo_principal()

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



    End Sub
    Private Sub Principal_Creador_Filtro_Tipo()
        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR TIPO DE VINO
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
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

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

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8

        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto
                    .Text = index     ' Asignas el texto del objeto
                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
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
        '*****CREACION DE LEYENDA
        '*************************
        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
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

        'valores para fijar posiciones
        colocar_leyenda_tipo_principal()

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
    End Sub
    Private Sub Principal_Creador_Filtro_Years()
        '**********CREACION DE ELEMENTOS PARA VISUALIZAR FILTRO POR AÑO DE LA COSECHA
        'creacion del control Tooltip
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1.ToolTipTitle = "Informacion"
        Me.ToolTip1.ToolTipIcon = ToolTipIcon.Info

        'ZONA CREACION DE BOTONES DE MENUS Y CABECERA
        '***************************************************
        'Boton de CERRAR
        Dim boton_1 As New Button()
        With boton_1
            .Name = "b_Cerrar"  ' Asignas el nombre del objeto
            '.Text = "VOLVER" ' Asignas el texto del objeto
            .Size = New System.Drawing.Size(75, 50) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(10, 530)
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
            .Location = New System.Drawing.Point(175, 530)
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
            .Location = New System.Drawing.Point(271, 530)
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
            .Location = New System.Drawing.Point(367, 530)
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
            .Location = New System.Drawing.Point(463, 530)
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
            .Location = New System.Drawing.Point(559, 530)
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
            .Location = New System.Drawing.Point(655, 530)
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
            .Location = New System.Drawing.Point(105, 530)
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
            .Size = New System.Drawing.Size(1364, 490) ' Asignas el tamaño del objeto
            .Location = New System.Drawing.Point(0, 0)
            .BackgroundImage = My.Resources.Principal_huecos
            .BackgroundImageLayout = ImageLayout.Stretch
            .AutoScroll = True
        End With
        Me.Controls.Add(panel_fondo)

        'contadores 
        Dim Contador_Condicion_1 As Integer
        Dim Contador_Condicion_2 As Integer

        'inicializacion 
        Contador_Condicion_1 = 0
        Contador_Condicion_2 = 0

        Dim index As String

        Dim SIZE_x As Integer
        Dim SIZE_y As Integer

        Dim Ini_X As Integer
        Dim Ini_Y As Integer

        Dim Desfase_X As Integer

        Dim acum_x As Integer
        Dim acum_y As Integer
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer

        Dim x_numero As Integer

        'Variables auxiliares para compensar los errores en las disancias

        Dim offset_x As Integer
        Dim offset_y As Integer
        Dim offset_x_2 As Integer
        Dim offset_y_2 As Integer
        Dim offset_x_3 As Integer
        Dim offset_y_3 As Integer
        Dim offset_x_4 As Integer
        Dim offset_y_4 As Integer
        Dim offset_x_5 As Integer
        Dim offset_y_5 As Integer
        Dim offset_x_6 As Integer
        Dim offset_y_6 As Integer
        Dim offset_x_7 As Integer
        Dim offset_y_7 As Integer
        Dim offset_x_8 As Integer
        Dim offset_x_9 As Integer
        Dim offset_x_10 As Integer

        'Medidas del boton
        SIZE_x = 35
        SIZE_y = 35

        'Desfase entre las columnas por cambiar de fila
        Desfase_X = 23

        'Coordenadas iniciales 
        Ini_X = 8
        Ini_Y = 8


        'HABRA QUE REALIZAR CALCULOS SEGÚN EL NUMERO DEL INDICE PARA CARGAR UNA SERIE DE VALORES
        offset_x = 46
        offset_y = 36

        'Fila 3ª
        offset_y_2 = 81

        'Fila 5ª
        offset_y_3 = 153

        'Fila 7ª
        offset_y_4 = 227

        'Fila 9ª
        offset_y_5 = 301

        'Fila 11ª
        offset_y_6 = 373

        'Fila 13ª
        offset_y_7 = 447

        'Valores iniciales
        acum_x = 8
        acum_y = 8

        n = 0

        For y = 1 To 13

            'Formacion de las columnas
            If y = 1 Then
                x_numero = 20
            End If

            If y > 1 And y <= 6 Then
                x_numero = 23
            End If

            If y > 6 Then
                x_numero = 29
            End If

            'CORRECCIONES EN LOS DESFASES DE LAS FILAS

            If y > 1 And y < 3 Then
                acum_y = acum_y + offset_y ' desfase acumulado en y
            End If

            If y = 3 Then
                acum_y = offset_y_2
            End If

            If y > 3 And y < 5 Then
                acum_y = acum_y + offset_y
            End If

            If y = 5 Then
                acum_y = offset_y_3
            End If

            If y > 5 And y < 7 Then
                acum_y = acum_y + offset_y
            End If

            If y = 7 Then
                acum_y = offset_y_4
            End If

            If y > 7 And y < 9 Then
                acum_y = acum_y + offset_y
            End If

            If y = 9 Then
                acum_y = offset_y_5
            End If

            If y > 9 And y < 11 Then
                acum_y = acum_y + offset_y
            End If

            If y = 11 Then
                acum_y = offset_y_6
            End If

            If y > 11 And y < 13 Then
                acum_y = acum_y + offset_y
            End If

            If y = 13 Then
                acum_y = offset_y_7
            End If

            'BUCLE FORMADOR DE COLUMNAS
            For x = 1 To x_numero

                'Columnas PARA LA PRIMERA FILA

                If y = 1 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 145
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_3
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 6 Then
                        acum_x = offset_x_4
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 9 Then
                        acum_x = offset_x_5
                    End If

                    If x = 10 Then
                        acum_x = offset_x_7 + offset_x
                    End If

                    If x > 10 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 12 Then
                        acum_x = offset_x_8
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_9
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_10
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If
                End If

                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 3 Or y = 5 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    'SALTO DE LA VENTANA
                    If y > 1 And y <= 6 Then

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    'Columnas completas
                    If y > 6 Then

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If

                End If


                'Columnas PARA EL RESTO DE FILAS IMPARES

                If y = 7 Or y = 9 Or y = 11 Or y = 13 Then

                    'Columna 3ª
                    offset_x_2 = 99
                    'Columna 6ª
                    offset_x_3 = 238
                    'Columna 9ª
                    offset_x_4 = 376
                    'Columna 12ª
                    offset_x_5 = 515
                    'Columna 15ª
                    offset_x_6 = 653
                    'Columna 18ª
                    offset_x_7 = 792
                    'Columna 21ª
                    offset_x_8 = 930
                    'Columna 24ª
                    offset_x_9 = 1069
                    'Columna 27ª
                    offset_x_10 = 1208

                    If x = 1 Then
                        acum_x = 7
                    End If

                    If x > 1 And x < 3 Then
                        acum_x = acum_x + offset_x
                    End If

                    If x = 3 Then
                        acum_x = offset_x_2
                    End If

                    If x > 3 And x < 6 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 6 Then
                        acum_x = offset_x_3
                    End If

                    If x > 6 And x < 9 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 9 Then
                        acum_x = offset_x_4
                    End If

                    If x > 9 And x < 12 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                    If x = 12 Then
                        acum_x = offset_x_5
                    End If

                    If x > 12 And x < 15 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 15 Then
                        acum_x = offset_x_6
                    End If

                    If x > 15 And x < 18 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 18 Then
                        acum_x = offset_x_7
                    End If

                    If x > 18 And x < 21 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 21 Then
                        acum_x = offset_x_8
                    End If

                    If x > 21 And x < 24 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 24 Then
                        acum_x = offset_x_9
                    End If

                    If x > 24 And x < 27 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If

                    If x = 27 Then
                        acum_x = offset_x_10
                    End If

                    If x > 27 And x < 30 Then
                        acum_x = acum_x + offset_x ' desfase acumulado en X
                    End If


                End If

                'Columnas con FILAS PARES
                If y = 2 Or y = 4 Or y = 6 Or y = 8 Or y = 10 Or y = 12 Then
                    'Columna 3ª
                    offset_x_2 = 123
                    'Columna 6ª
                    offset_x_3 = 260
                    'Columna 9ª
                    offset_x_4 = 399
                    'Columna 12ª
                    offset_x_5 = 539
                    'Columna 15ª
                    offset_x_6 = 677
                    'Columna 18ª
                    offset_x_7 = 815
                    'Columna 21ª
                    offset_x_8 = 954
                    'Columna 24ª
                    offset_x_9 = 1092
                    'Columna 27ª
                    offset_x_10 = 1231

                    If y <= 6 Then

                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x = 13 Then
                            acum_x = offset_x_7 + offset_x
                        End If

                        If x > 13 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_8
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_9
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_10
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                    End If

                    If y > 6 Then
                        If x = 1 Then
                            acum_x = 7 + Desfase_X
                        End If

                        If x > 1 And x < 3 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 3 Then
                            acum_x = offset_x_2
                        End If

                        If x > 3 And x < 6 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 6 Then
                            acum_x = offset_x_3
                        End If

                        If x > 6 And x < 9 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 9 Then
                            acum_x = offset_x_4
                        End If

                        If x > 9 And x < 12 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 12 Then
                            acum_x = offset_x_5
                        End If

                        If x > 12 And x < 15 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 15 Then
                            acum_x = offset_x_6
                        End If

                        If x > 15 And x < 18 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 18 Then
                            acum_x = offset_x_7
                        End If

                        If x > 18 And x < 21 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 21 Then
                            acum_x = offset_x_8
                        End If

                        If x > 21 And x < 24 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 24 Then
                            acum_x = offset_x_9
                        End If

                        If x > 24 And x < 27 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If

                        If x = 27 Then
                            acum_x = offset_x_10
                        End If

                        If x > 27 And x < 30 Then
                            acum_x = acum_x + offset_x ' desfase acumulado en X
                        End If
                    End If
                End If

                'fase creacion de boton
                Dim hueco As New Button()
                index = n + 1

                With hueco

                    .Name = "Hueco" & index  ' Asignas el nombre del objeto

                    .Size = New System.Drawing.Size(35, 35) ' Asignas el tamaño del objeto
                    .Location = New System.Drawing.Point(acum_x, acum_y)
                    .FlatStyle = FlatStyle.Popup
                    .BackColor = Color.Transparent
                    .Font = New Font("Tahoma", 8, FontStyle.Bold)

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
        '*****CREACION DE LEYENDA
        '*************************

        'crear las cabeceras 
        Dim Panel_filtros As New Panel()
        With Panel_filtros
            .Name = "Panel_filtros"  ' Asignar el nombre del objeto
            '.Size = New System.Drawing.Size(1359, 59) ' Asignar el tamaño del objeto
            .BackColor = System.Drawing.Color.SkyBlue
            .BackgroundImageLayout = ImageLayout.Stretch
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

        Icono_Leyenda_1.FlatStyle = FlatStyle.Flat

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

        'pasar valores para colocaciones
        colocar_leyenda_tipo_principal()

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


    End Sub

End Class

