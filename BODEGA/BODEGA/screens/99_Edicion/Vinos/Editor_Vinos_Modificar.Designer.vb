<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor_Vinos_Modificar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Vinos_Modificar))
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.Insert_DO = New System.Windows.Forms.TextBox()
        Me.Insert_Year = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Insert_Photo_Name = New System.Windows.Forms.TextBox()
        Me.Insert_Tipo = New System.Windows.Forms.TextBox()
        Me.Insert_Maduracion = New System.Windows.Forms.TextBox()
        Me.b_SearchPhoto = New System.Windows.Forms.Button()
        Me.ComboBox_Tipos = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Maduracion = New System.Windows.Forms.ComboBox()
        Me.Insert_Comentario = New System.Windows.Forms.TextBox()
        Me.Insert_Marca = New System.Windows.Forms.TextBox()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.b_Search = New System.Windows.Forms.Button()
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.VinosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VinosTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter()
        Me.ComboBox_DO = New System.Windows.Forms.ComboBox()
        Me.DenominacionesOrigenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Denominaciones_OrigenTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.info_rellenar_campo_7 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_6 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_5 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_4 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_3 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_2 = New System.Windows.Forms.Button()
        Me.b_DeleteItem = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel_Lista = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.info_rellenar_campo_1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Show_NumBotellas = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_Lista.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.DarkGray
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(570, 9)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(261, 269)
        Me.ShowPhotoVino.TabIndex = 431
        Me.ShowPhotoVino.TabStop = False
        '
        'Insert_DO
        '
        Me.Insert_DO.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_DO.Location = New System.Drawing.Point(379, 233)
        Me.Insert_DO.Name = "Insert_DO"
        Me.Insert_DO.Size = New System.Drawing.Size(100, 20)
        Me.Insert_DO.TabIndex = 430
        '
        'Insert_Year
        '
        Me.Insert_Year.Location = New System.Drawing.Point(187, 111)
        Me.Insert_Year.Name = "Insert_Year"
        Me.Insert_Year.Size = New System.Drawing.Size(121, 20)
        Me.Insert_Year.TabIndex = 429
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 428
        Me.Label8.Text = "Año"
        '
        'Insert_Photo_Name
        '
        Me.Insert_Photo_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Photo_Name.Location = New System.Drawing.Point(379, 308)
        Me.Insert_Photo_Name.Name = "Insert_Photo_Name"
        Me.Insert_Photo_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Photo_Name.TabIndex = 427
        '
        'Insert_Tipo
        '
        Me.Insert_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Tipo.Location = New System.Drawing.Point(379, 157)
        Me.Insert_Tipo.Name = "Insert_Tipo"
        Me.Insert_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Tipo.TabIndex = 426
        '
        'Insert_Maduracion
        '
        Me.Insert_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Maduracion.Location = New System.Drawing.Point(379, 70)
        Me.Insert_Maduracion.Name = "Insert_Maduracion"
        Me.Insert_Maduracion.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Maduracion.TabIndex = 425
        '
        'b_SearchPhoto
        '
        Me.b_SearchPhoto.Location = New System.Drawing.Point(570, 284)
        Me.b_SearchPhoto.Name = "b_SearchPhoto"
        Me.b_SearchPhoto.Size = New System.Drawing.Size(261, 44)
        Me.b_SearchPhoto.TabIndex = 423
        Me.b_SearchPhoto.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto.UseVisualStyleBackColor = True
        '
        'ComboBox_Tipos
        '
        Me.ComboBox_Tipos.FormattingEnabled = True
        Me.ComboBox_Tipos.Items.AddRange(New Object() {"Tinto", "Rosado", "Blanco", "Cava", "Otro"})
        Me.ComboBox_Tipos.Location = New System.Drawing.Point(187, 151)
        Me.ComboBox_Tipos.Name = "ComboBox_Tipos"
        Me.ComboBox_Tipos.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Tipos.TabIndex = 421
        '
        'ComboBox_Maduracion
        '
        Me.ComboBox_Maduracion.FormattingEnabled = True
        Me.ComboBox_Maduracion.Items.AddRange(New Object() {"Cosecha", "Crianza", "Reserva", "Gran Reserva", "Otro"})
        Me.ComboBox_Maduracion.Location = New System.Drawing.Point(187, 72)
        Me.ComboBox_Maduracion.Name = "ComboBox_Maduracion"
        Me.ComboBox_Maduracion.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Maduracion.TabIndex = 420
        '
        'Insert_Comentario
        '
        Me.Insert_Comentario.Location = New System.Drawing.Point(187, 191)
        Me.Insert_Comentario.Name = "Insert_Comentario"
        Me.Insert_Comentario.Size = New System.Drawing.Size(292, 20)
        Me.Insert_Comentario.TabIndex = 419
        '
        'Insert_Marca
        '
        Me.Insert_Marca.Location = New System.Drawing.Point(187, 33)
        Me.Insert_Marca.Name = "Insert_Marca"
        Me.Insert_Marca.Size = New System.Drawing.Size(292, 20)
        Me.Insert_Marca.TabIndex = 418
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Location = New System.Drawing.Point(300, 9)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(57, 20)
        Me.Show_ID.TabIndex = 417
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(522, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 416
        Me.Label7.Text = "Foto "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 415
        Me.Label6.Text = "Denominacion de Origen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 414
        Me.Label5.Text = "Comentario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 413
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 412
        Me.Label3.Text = "Maduracion "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 411
        Me.Label2.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 410
        Me.Label1.Text = "ID VINO"
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(14, 270)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(165, 59)
        Me.b_SaveItem.TabIndex = 409
        Me.b_SaveItem.Text = "ACTUALIZAR VINO"
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'b_Search
        '
        Me.b_Search.Location = New System.Drawing.Point(362, 39)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(100, 39)
        Me.b_Search.TabIndex = 432
        Me.b_Search.Text = "BUSCAR"
        Me.b_Search.UseVisualStyleBackColor = True
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VinosBindingSource
        '
        Me.VinosBindingSource.DataMember = "Vinos"
        Me.VinosBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'VinosTableAdapter
        '
        Me.VinosTableAdapter.ClearBeforeFill = True
        '
        'ComboBox_DO
        '
        Me.ComboBox_DO.DataSource = Me.DenominacionesOrigenBindingSource
        Me.ComboBox_DO.DisplayMember = "ID_Denominacion"
        Me.ComboBox_DO.FormattingEnabled = True
        Me.ComboBox_DO.Location = New System.Drawing.Point(187, 230)
        Me.ComboBox_DO.Name = "ComboBox_DO"
        Me.ComboBox_DO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DO.TabIndex = 422
        '
        'DenominacionesOrigenBindingSource
        '
        Me.DenominacionesOrigenBindingSource.DataMember = "Denominaciones_Origen"
        Me.DenominacionesOrigenBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Denominaciones_OrigenTableAdapter
        '
        Me.Denominaciones_OrigenTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_7)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_6)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_5)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_4)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_3)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_2)
        Me.Panel1.Controls.Add(Me.b_DeleteItem)
        Me.Panel1.Controls.Add(Me.ShowPhotoVino)
        Me.Panel1.Controls.Add(Me.Insert_DO)
        Me.Panel1.Controls.Add(Me.Insert_Year)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Insert_Photo_Name)
        Me.Panel1.Controls.Add(Me.Insert_Tipo)
        Me.Panel1.Controls.Add(Me.Insert_Maduracion)
        Me.Panel1.Controls.Add(Me.b_SearchPhoto)
        Me.Panel1.Controls.Add(Me.ComboBox_DO)
        Me.Panel1.Controls.Add(Me.ComboBox_Tipos)
        Me.Panel1.Controls.Add(Me.ComboBox_Maduracion)
        Me.Panel1.Controls.Add(Me.Insert_Comentario)
        Me.Panel1.Controls.Add(Me.Insert_Marca)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.b_SaveItem)
        Me.Panel1.Location = New System.Drawing.Point(70, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(836, 336)
        Me.Panel1.TabIndex = 434
        '
        'info_rellenar_campo_7
        '
        Me.info_rellenar_campo_7.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_7.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_7.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_7.Location = New System.Drawing.Point(320, 230)
        Me.info_rellenar_campo_7.Name = "info_rellenar_campo_7"
        Me.info_rellenar_campo_7.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_7.TabIndex = 450
        Me.info_rellenar_campo_7.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_6
        '
        Me.info_rellenar_campo_6.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_6.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_6.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_6.Location = New System.Drawing.Point(485, 190)
        Me.info_rellenar_campo_6.Name = "info_rellenar_campo_6"
        Me.info_rellenar_campo_6.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_6.TabIndex = 449
        Me.info_rellenar_campo_6.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_5
        '
        Me.info_rellenar_campo_5.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_5.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_5.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_5.Location = New System.Drawing.Point(320, 149)
        Me.info_rellenar_campo_5.Name = "info_rellenar_campo_5"
        Me.info_rellenar_campo_5.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_5.TabIndex = 448
        Me.info_rellenar_campo_5.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_4
        '
        Me.info_rellenar_campo_4.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_4.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_4.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_4.Location = New System.Drawing.Point(320, 111)
        Me.info_rellenar_campo_4.Name = "info_rellenar_campo_4"
        Me.info_rellenar_campo_4.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_4.TabIndex = 447
        Me.info_rellenar_campo_4.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_3
        '
        Me.info_rellenar_campo_3.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_3.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_3.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_3.Location = New System.Drawing.Point(320, 73)
        Me.info_rellenar_campo_3.Name = "info_rellenar_campo_3"
        Me.info_rellenar_campo_3.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_3.TabIndex = 446
        Me.info_rellenar_campo_3.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_2
        '
        Me.info_rellenar_campo_2.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_2.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_2.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_2.Location = New System.Drawing.Point(485, 32)
        Me.info_rellenar_campo_2.Name = "info_rellenar_campo_2"
        Me.info_rellenar_campo_2.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_2.TabIndex = 445
        Me.info_rellenar_campo_2.UseVisualStyleBackColor = False
        '
        'b_DeleteItem
        '
        Me.b_DeleteItem.Location = New System.Drawing.Point(193, 270)
        Me.b_DeleteItem.Name = "b_DeleteItem"
        Me.b_DeleteItem.Size = New System.Drawing.Size(180, 59)
        Me.b_DeleteItem.TabIndex = 432
        Me.b_DeleteItem.Text = "BORRAR VINO"
        Me.b_DeleteItem.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.VinosBindingSource
        Me.ComboBox1.DisplayMember = "Id_Vino"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(130, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 432
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 13)
        Me.Label9.TabIndex = 435
        Me.Label9.Text = "Pulsar en la lista el Vino a modificar o borrar"
        '
        'Panel_Lista
        '
        Me.Panel_Lista.Controls.Add(Me.Label10)
        Me.Panel_Lista.Controls.Add(Me.DataGridView1)
        Me.Panel_Lista.Location = New System.Drawing.Point(70, 84)
        Me.Panel_Lista.Name = "Panel_Lista"
        Me.Panel_Lista.Size = New System.Drawing.Size(836, 92)
        Me.Panel_Lista.TabIndex = 436
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(229, 13)
        Me.Label10.TabIndex = 439
        Me.Label10.Text = "Detalles de los datos del vino en vista de tabla:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(830, 69)
        Me.DataGridView1.TabIndex = 434
        '
        'info_rellenar_campo_1
        '
        Me.info_rellenar_campo_1.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_1.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_1.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_1.Location = New System.Drawing.Point(314, 50)
        Me.info_rellenar_campo_1.Name = "info_rellenar_campo_1"
        Me.info_rellenar_campo_1.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_1.TabIndex = 437
        Me.info_rellenar_campo_1.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Show_NumBotellas
        '
        Me.Show_NumBotellas.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_NumBotellas.Enabled = False
        Me.Show_NumBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_NumBotellas.Location = New System.Drawing.Point(808, 53)
        Me.Show_NumBotellas.Name = "Show_NumBotellas"
        Me.Show_NumBotellas.Size = New System.Drawing.Size(98, 23)
        Me.Show_NumBotellas.TabIndex = 443
        Me.ToolTip1.SetToolTip(Me.Show_NumBotellas, "numero de botellas contabilizadas")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(652, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 444
        Me.Label11.Text = "Nº Botellas contabilizadas"
        '
        'Editor_Vinos_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 530)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Show_NumBotellas)
        Me.Controls.Add(Me.info_rellenar_campo_1)
        Me.Controls.Add(Me.Panel_Lista)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_Search)
        Me.Controls.Add(Me.Show_ID)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Editor_Vinos_Modificar"
        Me.Text = "Editor_Vinos_Modificar"
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Lista.ResumeLayout(False)
        Me.Panel_Lista.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowPhotoVino As PictureBox
    Friend WithEvents Insert_DO As TextBox
    Friend WithEvents Insert_Year As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Insert_Photo_Name As TextBox
    Friend WithEvents Insert_Tipo As TextBox
    Friend WithEvents Insert_Maduracion As TextBox
    Friend WithEvents b_SearchPhoto As Button
    Friend WithEvents ComboBox_Tipos As ComboBox
    Friend WithEvents ComboBox_Maduracion As ComboBox
    Friend WithEvents Insert_Comentario As TextBox
    Friend WithEvents Insert_Marca As TextBox
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents b_SaveItem As Button
    Friend WithEvents b_Search As Button
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents VinosBindingSource As BindingSource
    Friend WithEvents VinosTableAdapter As BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter
    Friend WithEvents ComboBox_DO As ComboBox
    Friend WithEvents DenominacionesOrigenBindingSource As BindingSource
    Friend WithEvents Denominaciones_OrigenTableAdapter As BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents b_DeleteItem As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel_Lista As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents info_rellenar_campo_1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents info_rellenar_campo_7 As Button
    Friend WithEvents info_rellenar_campo_6 As Button
    Friend WithEvents info_rellenar_campo_5 As Button
    Friend WithEvents info_rellenar_campo_4 As Button
    Friend WithEvents info_rellenar_campo_3 As Button
    Friend WithEvents info_rellenar_campo_2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label11 As Label
    Friend WithEvents Show_NumBotellas As TextBox
End Class
