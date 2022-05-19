<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Huecos_Modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HuecoscompletosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.b_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Insert_uso = New System.Windows.Forms.TextBox()
        Me.Insert_Zona = New System.Windows.Forms.TextBox()
        Me.Insert_Comentario_hueco = New System.Windows.Forms.TextBox()
        Me.Insert_Columna = New System.Windows.Forms.TextBox()
        Me.Insert_Fila = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ConsumoRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBox_Zona = New System.Windows.Forms.ComboBox()
        Me.ZonasalmacenamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColeccionRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox_ID_Vino = New System.Windows.Forms.ComboBox()
        Me.VinosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Insert_ID_Vino = New System.Windows.Forms.TextBox()
        Me.PanelVino = New System.Windows.Forms.Panel()
        Me.Show_photo_name = New System.Windows.Forms.TextBox()
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.show_Year = New System.Windows.Forms.TextBox()
        Me.show_DO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show_Tipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.show_Maduracion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.show_Comentario_vino = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.show_Marca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VinosTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter()
        Me.Zonas_almacenamientoTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter()
        Me.Huecos_completosTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Huecos_completosTableAdapter()
        CType(Me.HuecoscompletosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ZonasalmacenamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVino.SuspendLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.HuecoscompletosBindingSource
        Me.ComboBox1.DisplayMember = "Id_Hueco"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 435
        '
        'HuecoscompletosBindingSource
        '
        Me.HuecoscompletosBindingSource.DataMember = "Huecos_completos"
        Me.HuecoscompletosBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'b_Search
        '
        Me.b_Search.Location = New System.Drawing.Point(12, 67)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(100, 39)
        Me.b_Search.TabIndex = 434
        Me.b_Search.Text = "BUSCAR"
        Me.b_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 433
        Me.Label1.Text = "ID HUECOS"
        '
        'Insert_uso
        '
        Me.Insert_uso.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_uso.Enabled = False
        Me.Insert_uso.Location = New System.Drawing.Point(256, 286)
        Me.Insert_uso.Name = "Insert_uso"
        Me.Insert_uso.Size = New System.Drawing.Size(75, 20)
        Me.Insert_uso.TabIndex = 488
        Me.ToolTip1.SetToolTip(Me.Insert_uso, "Codigo ID del Vino")
        Me.Insert_uso.Visible = False
        '
        'Insert_Zona
        '
        Me.Insert_Zona.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Zona.Enabled = False
        Me.Insert_Zona.Location = New System.Drawing.Point(350, 223)
        Me.Insert_Zona.Name = "Insert_Zona"
        Me.Insert_Zona.Size = New System.Drawing.Size(105, 20)
        Me.Insert_Zona.TabIndex = 486
        Me.ToolTip1.SetToolTip(Me.Insert_Zona, "Codigo ID del Vino")
        Me.Insert_Zona.Visible = False
        '
        'Insert_Comentario_hueco
        '
        Me.Insert_Comentario_hueco.BackColor = System.Drawing.SystemColors.Window
        Me.Insert_Comentario_hueco.Location = New System.Drawing.Point(136, 187)
        Me.Insert_Comentario_hueco.Name = "Insert_Comentario_hueco"
        Me.Insert_Comentario_hueco.Size = New System.Drawing.Size(208, 20)
        Me.Insert_Comentario_hueco.TabIndex = 484
        Me.ToolTip1.SetToolTip(Me.Insert_Comentario_hueco, "Codigo ID del Vino")
        '
        'Insert_Columna
        '
        Me.Insert_Columna.BackColor = System.Drawing.SystemColors.Window
        Me.Insert_Columna.Location = New System.Drawing.Point(136, 124)
        Me.Insert_Columna.Name = "Insert_Columna"
        Me.Insert_Columna.Size = New System.Drawing.Size(208, 20)
        Me.Insert_Columna.TabIndex = 492
        Me.ToolTip1.SetToolTip(Me.Insert_Columna, "Codigo ID del Vino")
        '
        'Insert_Fila
        '
        Me.Insert_Fila.BackColor = System.Drawing.SystemColors.Window
        Me.Insert_Fila.Location = New System.Drawing.Point(136, 76)
        Me.Insert_Fila.Name = "Insert_Fila"
        Me.Insert_Fila.Size = New System.Drawing.Size(208, 20)
        Me.Insert_Fila.TabIndex = 494
        Me.ToolTip1.SetToolTip(Me.Insert_Fila, "Codigo ID del Vino")
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(155, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(770, 93)
        Me.DataGridView1.TabIndex = 436
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Location = New System.Drawing.Point(29, 112)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(57, 20)
        Me.Show_ID.TabIndex = 437
        Me.Show_ID.Visible = False
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(16, 330)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(294, 59)
        Me.b_SaveItem.TabIndex = 409
        Me.b_SaveItem.Text = "ACTUALIZAR HUECO"
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ConsumoRadioButton)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Insert_Fila)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Insert_Columna)
        Me.Panel1.Controls.Add(Me.ComboBox_Zona)
        Me.Panel1.Controls.Add(Me.ColeccionRadioButton)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Insert_uso)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Insert_Zona)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Insert_Comentario_hueco)
        Me.Panel1.Controls.Add(Me.ComboBox_ID_Vino)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Insert_ID_Vino)
        Me.Panel1.Controls.Add(Me.PanelVino)
        Me.Panel1.Controls.Add(Me.b_SaveItem)
        Me.Panel1.Location = New System.Drawing.Point(29, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(899, 394)
        Me.Panel1.TabIndex = 438
        '
        'ConsumoRadioButton
        '
        Me.ConsumoRadioButton.AutoSize = True
        Me.ConsumoRadioButton.Location = New System.Drawing.Point(169, 307)
        Me.ConsumoRadioButton.Name = "ConsumoRadioButton"
        Me.ConsumoRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.ConsumoRadioButton.TabIndex = 495
        Me.ConsumoRadioButton.Text = "Consumo"
        Me.ConsumoRadioButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 493
        Me.Label13.Text = "Fila"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 13)
        Me.Label12.TabIndex = 491
        Me.Label12.Text = "Columna"
        '
        'ComboBox_Zona
        '
        Me.ComboBox_Zona.DataSource = Me.ZonasalmacenamientoBindingSource
        Me.ComboBox_Zona.DisplayMember = "ID_Zona"
        Me.ComboBox_Zona.FormattingEnabled = True
        Me.ComboBox_Zona.Location = New System.Drawing.Point(136, 222)
        Me.ComboBox_Zona.Name = "ComboBox_Zona"
        Me.ComboBox_Zona.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox_Zona.TabIndex = 490
        '
        'ZonasalmacenamientoBindingSource
        '
        Me.ZonasalmacenamientoBindingSource.DataMember = "Zonas_almacenamiento"
        Me.ZonasalmacenamientoBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'ColeccionRadioButton
        '
        Me.ColeccionRadioButton.AutoSize = True
        Me.ColeccionRadioButton.Location = New System.Drawing.Point(169, 271)
        Me.ColeccionRadioButton.Name = "ColeccionRadioButton"
        Me.ColeccionRadioButton.Size = New System.Drawing.Size(72, 17)
        Me.ColeccionRadioButton.TabIndex = 489
        Me.ColeccionRadioButton.Text = "Colección"
        Me.ColeccionRadioButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 487
        Me.Label11.Text = "Uso del hueco"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 225)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 485
        Me.Label10.Text = "Zona"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(41, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 483
        Me.Label9.Text = "Comentario"
        '
        'ComboBox_ID_Vino
        '
        Me.ComboBox_ID_Vino.DataSource = Me.VinosBindingSource
        Me.ComboBox_ID_Vino.DisplayMember = "Id_Vino"
        Me.ComboBox_ID_Vino.FormattingEnabled = True
        Me.ComboBox_ID_Vino.Location = New System.Drawing.Point(665, 79)
        Me.ComboBox_ID_Vino.Name = "ComboBox_ID_Vino"
        Me.ComboBox_ID_Vino.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox_ID_Vino.TabIndex = 482
        '
        'VinosBindingSource
        '
        Me.VinosBindingSource.DataMember = "Vinos"
        Me.VinosBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(537, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 480
        Me.Label7.Text = "Codigo Vino"
        '
        'Insert_ID_Vino
        '
        Me.Insert_ID_Vino.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_ID_Vino.Enabled = False
        Me.Insert_ID_Vino.Location = New System.Drawing.Point(665, 53)
        Me.Insert_ID_Vino.Name = "Insert_ID_Vino"
        Me.Insert_ID_Vino.Size = New System.Drawing.Size(208, 20)
        Me.Insert_ID_Vino.TabIndex = 481
        Me.Insert_ID_Vino.Visible = False
        '
        'PanelVino
        '
        Me.PanelVino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVino.Controls.Add(Me.Show_photo_name)
        Me.PanelVino.Controls.Add(Me.ShowPhotoVino)
        Me.PanelVino.Controls.Add(Me.show_Year)
        Me.PanelVino.Controls.Add(Me.show_DO)
        Me.PanelVino.Controls.Add(Me.Label8)
        Me.PanelVino.Controls.Add(Me.Label2)
        Me.PanelVino.Controls.Add(Me.show_Tipo)
        Me.PanelVino.Controls.Add(Me.Label3)
        Me.PanelVino.Controls.Add(Me.show_Maduracion)
        Me.PanelVino.Controls.Add(Me.Label4)
        Me.PanelVino.Controls.Add(Me.show_Comentario_vino)
        Me.PanelVino.Controls.Add(Me.Label5)
        Me.PanelVino.Controls.Add(Me.show_Marca)
        Me.PanelVino.Controls.Add(Me.Label6)
        Me.PanelVino.Location = New System.Drawing.Point(474, 102)
        Me.PanelVino.Name = "PanelVino"
        Me.PanelVino.Size = New System.Drawing.Size(407, 287)
        Me.PanelVino.TabIndex = 448
        '
        'Show_photo_name
        '
        Me.Show_photo_name.BackColor = System.Drawing.SystemColors.Info
        Me.Show_photo_name.Enabled = False
        Me.Show_photo_name.Location = New System.Drawing.Point(6, 260)
        Me.Show_photo_name.Name = "Show_photo_name"
        Me.Show_photo_name.Size = New System.Drawing.Size(100, 20)
        Me.Show_photo_name.TabIndex = 478
        Me.Show_photo_name.Visible = False
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(6, 79)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(143, 175)
        Me.ShowPhotoVino.TabIndex = 475
        Me.ShowPhotoVino.TabStop = False
        '
        'show_Year
        '
        Me.show_Year.BackColor = System.Drawing.SystemColors.Info
        Me.show_Year.Enabled = False
        Me.show_Year.Location = New System.Drawing.Point(299, 112)
        Me.show_Year.Name = "show_Year"
        Me.show_Year.Size = New System.Drawing.Size(100, 20)
        Me.show_Year.TabIndex = 473
        '
        'show_DO
        '
        Me.show_DO.BackColor = System.Drawing.SystemColors.Info
        Me.show_DO.Enabled = False
        Me.show_DO.Location = New System.Drawing.Point(299, 160)
        Me.show_DO.Name = "show_DO"
        Me.show_DO.Size = New System.Drawing.Size(100, 20)
        Me.show_DO.TabIndex = 474
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(169, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 472
        Me.Label8.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 463
        Me.Label2.Text = "Marca"
        '
        'show_Tipo
        '
        Me.show_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.show_Tipo.Enabled = False
        Me.show_Tipo.Location = New System.Drawing.Point(299, 88)
        Me.show_Tipo.Name = "show_Tipo"
        Me.show_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.show_Tipo.TabIndex = 471
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "Maduracion "
        '
        'show_Maduracion
        '
        Me.show_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.show_Maduracion.Enabled = False
        Me.show_Maduracion.Location = New System.Drawing.Point(299, 136)
        Me.show_Maduracion.Name = "show_Maduracion"
        Me.show_Maduracion.Size = New System.Drawing.Size(100, 20)
        Me.show_Maduracion.TabIndex = 470
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 465
        Me.Label4.Text = "Tipo"
        '
        'show_Comentario_vino
        '
        Me.show_Comentario_vino.BackColor = System.Drawing.SystemColors.Info
        Me.show_Comentario_vino.Enabled = False
        Me.show_Comentario_vino.Location = New System.Drawing.Point(191, 55)
        Me.show_Comentario_vino.Name = "show_Comentario_vino"
        Me.show_Comentario_vino.Size = New System.Drawing.Size(208, 20)
        Me.show_Comentario_vino.TabIndex = 469
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 466
        Me.Label5.Text = "Comentario"
        '
        'show_Marca
        '
        Me.show_Marca.BackColor = System.Drawing.SystemColors.Info
        Me.show_Marca.Enabled = False
        Me.show_Marca.Location = New System.Drawing.Point(191, 29)
        Me.show_Marca.Name = "show_Marca"
        Me.show_Marca.Size = New System.Drawing.Size(208, 20)
        Me.show_Marca.TabIndex = 468
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(169, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 467
        Me.Label6.Text = "Denominacion de Origen"
        '
        'VinosTableAdapter
        '
        Me.VinosTableAdapter.ClearBeforeFill = True
        '
        'Zonas_almacenamientoTableAdapter
        '
        Me.Zonas_almacenamientoTableAdapter.ClearBeforeFill = True
        '
        'Huecos_completosTableAdapter
        '
        Me.Huecos_completosTableAdapter.ClearBeforeFill = True
        '
        'Editor_Huecos_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 544)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Show_ID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.b_Search)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Editor_Huecos_Modificar"
        Me.Text = "Editor_Huecos_Modificar"
        CType(Me.HuecoscompletosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ZonasalmacenamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVino.ResumeLayout(False)
        Me.PanelVino.PerformLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents b_Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents b_SaveItem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelVino As Panel
    Friend WithEvents Show_photo_name As TextBox
    Friend WithEvents ShowPhotoVino As PictureBox
    Friend WithEvents show_Year As TextBox
    Friend WithEvents show_DO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents show_Tipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents show_Maduracion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents show_Comentario_vino As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents show_Marca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Insert_ID_Vino As TextBox
    Friend WithEvents ComboBox_ID_Vino As ComboBox
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents VinosBindingSource As BindingSource
    Friend WithEvents VinosTableAdapter As BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter
    Friend WithEvents ComboBox_Zona As ComboBox
    Friend WithEvents ColeccionRadioButton As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Insert_uso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Insert_Zona As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Insert_Comentario_hueco As TextBox
    Friend WithEvents ZonasalmacenamientoBindingSource As BindingSource
    Friend WithEvents Zonas_almacenamientoTableAdapter As BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents Insert_Fila As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Insert_Columna As TextBox
    Friend WithEvents HuecoscompletosBindingSource As BindingSource
    Friend WithEvents Huecos_completosTableAdapter As BD_Bodega_V1DataSetTableAdapters.Huecos_completosTableAdapter
    Friend WithEvents ConsumoRadioButton As RadioButton
End Class
