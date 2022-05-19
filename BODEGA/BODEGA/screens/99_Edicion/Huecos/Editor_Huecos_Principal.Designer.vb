<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Huecos_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Huecos_Principal))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.show_Comentario_hueco = New System.Windows.Forms.TextBox()
        Me.show_Zona = New System.Windows.Forms.TextBox()
        Me.Show_uso = New System.Windows.Forms.TextBox()
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.Huecos_completosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Huecos_completosTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Huecos_completosTableAdapter()
        Me.TableAdapterManager = New BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager()
        Me.Huecos_completosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.b_Refrescar = New System.Windows.Forms.Button()
        Me.b_Modificar = New System.Windows.Forms.Button()
        Me.PanelHueco = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Show_ID_Vino = New System.Windows.Forms.TextBox()
        Me.UsoRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Huecos_completosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Huecos_completosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Huecos_completosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHueco.SuspendLayout()
        Me.PanelVino.SuspendLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Huecos_completosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Huecos_completosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Enabled = False
        Me.Show_ID.Location = New System.Drawing.Point(239, 13)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(141, 20)
        Me.Show_ID.TabIndex = 447
        Me.ToolTip1.SetToolTip(Me.Show_ID, "Codigo ID del Vino")
        '
        'show_Comentario_hueco
        '
        Me.show_Comentario_hueco.BackColor = System.Drawing.SystemColors.Info
        Me.show_Comentario_hueco.Enabled = False
        Me.show_Comentario_hueco.Location = New System.Drawing.Point(239, 43)
        Me.show_Comentario_hueco.Name = "show_Comentario_hueco"
        Me.show_Comentario_hueco.Size = New System.Drawing.Size(141, 20)
        Me.show_Comentario_hueco.TabIndex = 449
        Me.ToolTip1.SetToolTip(Me.show_Comentario_hueco, "Codigo ID del Vino")
        '
        'show_Zona
        '
        Me.show_Zona.BackColor = System.Drawing.SystemColors.Info
        Me.show_Zona.Enabled = False
        Me.show_Zona.Location = New System.Drawing.Point(239, 73)
        Me.show_Zona.Name = "show_Zona"
        Me.show_Zona.Size = New System.Drawing.Size(141, 20)
        Me.show_Zona.TabIndex = 451
        Me.ToolTip1.SetToolTip(Me.show_Zona, "Codigo ID del Vino")
        '
        'Show_uso
        '
        Me.Show_uso.BackColor = System.Drawing.SystemColors.Info
        Me.Show_uso.Enabled = False
        Me.Show_uso.Location = New System.Drawing.Point(102, 136)
        Me.Show_uso.Name = "Show_uso"
        Me.Show_uso.Size = New System.Drawing.Size(75, 20)
        Me.Show_uso.TabIndex = 453
        Me.ToolTip1.SetToolTip(Me.Show_uso, "Codigo ID del Vino")
        Me.Show_uso.Visible = False
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Huecos_completosBindingSource
        '
        Me.Huecos_completosBindingSource.DataMember = "Huecos_completos"
        Me.Huecos_completosBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Huecos_completosTableAdapter
        '
        Me.Huecos_completosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Denominaciones_OrigenTableAdapter = Nothing
        Me.TableAdapterManager.Huecos_completosTableAdapter = Me.Huecos_completosTableAdapter
        Me.TableAdapterManager.UpdateOrder = BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VinosTableAdapter = Nothing
        Me.TableAdapterManager.Zonas_almacenamientoTableAdapter = Nothing
        '
        'Huecos_completosDataGridView
        '
        Me.Huecos_completosDataGridView.AutoGenerateColumns = False
        Me.Huecos_completosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Huecos_completosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Huecos_completosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.Huecos_completosDataGridView.DataSource = Me.Huecos_completosBindingSource
        Me.Huecos_completosDataGridView.Location = New System.Drawing.Point(12, 55)
        Me.Huecos_completosDataGridView.Name = "Huecos_completosDataGridView"
        Me.Huecos_completosDataGridView.Size = New System.Drawing.Size(581, 408)
        Me.Huecos_completosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Hueco"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Hueco"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 79
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fila"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fila"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 48
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Columna"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Columna"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 73
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Comentario"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 85
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Zona"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 57
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Vino"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Vino"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 53
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Coleccion"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Coleccion"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 60
        '
        'b_Refrescar
        '
        Me.b_Refrescar.Location = New System.Drawing.Point(796, 55)
        Me.b_Refrescar.Name = "b_Refrescar"
        Me.b_Refrescar.Size = New System.Drawing.Size(171, 23)
        Me.b_Refrescar.TabIndex = 9
        Me.b_Refrescar.Text = "ACTUALIZAR TABLA"
        Me.b_Refrescar.UseVisualStyleBackColor = True
        '
        'b_Modificar
        '
        Me.b_Modificar.Location = New System.Drawing.Point(629, 55)
        Me.b_Modificar.Name = "b_Modificar"
        Me.b_Modificar.Size = New System.Drawing.Size(153, 23)
        Me.b_Modificar.TabIndex = 8
        Me.b_Modificar.Text = "MODIFICAR HUECO"
        Me.b_Modificar.UseVisualStyleBackColor = True
        '
        'PanelHueco
        '
        Me.PanelHueco.Controls.Add(Me.Label7)
        Me.PanelHueco.Controls.Add(Me.Show_ID_Vino)
        Me.PanelHueco.Controls.Add(Me.UsoRadioButton)
        Me.PanelHueco.Controls.Add(Me.Label11)
        Me.PanelHueco.Controls.Add(Me.Show_uso)
        Me.PanelHueco.Controls.Add(Me.Label10)
        Me.PanelHueco.Controls.Add(Me.show_Zona)
        Me.PanelHueco.Controls.Add(Me.Label9)
        Me.PanelHueco.Controls.Add(Me.show_Comentario_hueco)
        Me.PanelHueco.Controls.Add(Me.Label1)
        Me.PanelHueco.Controls.Add(Me.Show_ID)
        Me.PanelHueco.Location = New System.Drawing.Point(599, 84)
        Me.PanelHueco.Name = "PanelHueco"
        Me.PanelHueco.Size = New System.Drawing.Size(394, 162)
        Me.PanelHueco.TabIndex = 446
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 478
        Me.Label7.Text = "Codigo Vino"
        '
        'Show_ID_Vino
        '
        Me.Show_ID_Vino.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID_Vino.Enabled = False
        Me.Show_ID_Vino.Location = New System.Drawing.Point(239, 103)
        Me.Show_ID_Vino.Name = "Show_ID_Vino"
        Me.Show_ID_Vino.Size = New System.Drawing.Size(141, 20)
        Me.Show_ID_Vino.TabIndex = 479
        '
        'UsoRadioButton
        '
        Me.UsoRadioButton.AutoSize = True
        Me.UsoRadioButton.Enabled = False
        Me.UsoRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsoRadioButton.Location = New System.Drawing.Point(239, 133)
        Me.UsoRadioButton.Name = "UsoRadioButton"
        Me.UsoRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.UsoRadioButton.TabIndex = 454
        Me.UsoRadioButton.Text = "Colección"
        Me.UsoRadioButton.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 452
        Me.Label11.Text = "Uso del hueco"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 450
        Me.Label10.Text = "Zona"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 448
        Me.Label9.Text = "Comentario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 446
        Me.Label1.Text = "Codigo único identificacion"
        '
        'PanelVino
        '
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
        Me.PanelVino.Location = New System.Drawing.Point(599, 252)
        Me.PanelVino.Name = "PanelVino"
        Me.PanelVino.Size = New System.Drawing.Size(394, 211)
        Me.PanelVino.TabIndex = 447
        '
        'Show_photo_name
        '
        Me.Show_photo_name.BackColor = System.Drawing.SystemColors.Info
        Me.Show_photo_name.Enabled = False
        Me.Show_photo_name.Location = New System.Drawing.Point(153, 186)
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
        Me.ShowPhotoVino.Location = New System.Drawing.Point(17, 59)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(127, 147)
        Me.ShowPhotoVino.TabIndex = 475
        Me.ShowPhotoVino.TabStop = False
        '
        'show_Year
        '
        Me.show_Year.BackColor = System.Drawing.SystemColors.Info
        Me.show_Year.Enabled = False
        Me.show_Year.Location = New System.Drawing.Point(280, 122)
        Me.show_Year.Name = "show_Year"
        Me.show_Year.Size = New System.Drawing.Size(100, 20)
        Me.show_Year.TabIndex = 473
        '
        'show_DO
        '
        Me.show_DO.BackColor = System.Drawing.SystemColors.Info
        Me.show_DO.Enabled = False
        Me.show_DO.Location = New System.Drawing.Point(280, 170)
        Me.show_DO.Name = "show_DO"
        Me.show_DO.Size = New System.Drawing.Size(100, 20)
        Me.show_DO.TabIndex = 474
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 472
        Me.Label8.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 463
        Me.Label2.Text = "Marca"
        '
        'show_Tipo
        '
        Me.show_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.show_Tipo.Enabled = False
        Me.show_Tipo.Location = New System.Drawing.Point(280, 98)
        Me.show_Tipo.Name = "show_Tipo"
        Me.show_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.show_Tipo.TabIndex = 471
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 464
        Me.Label3.Text = "Maduracion "
        '
        'show_Maduracion
        '
        Me.show_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.show_Maduracion.Enabled = False
        Me.show_Maduracion.Location = New System.Drawing.Point(197, 98)
        Me.show_Maduracion.Name = "show_Maduracion"
        Me.show_Maduracion.Size = New System.Drawing.Size(100, 20)
        Me.show_Maduracion.TabIndex = 470
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 465
        Me.Label4.Text = "Tipo"
        '
        'show_Comentario_vino
        '
        Me.show_Comentario_vino.BackColor = System.Drawing.SystemColors.Info
        Me.show_Comentario_vino.Enabled = False
        Me.show_Comentario_vino.Location = New System.Drawing.Point(172, 35)
        Me.show_Comentario_vino.Name = "show_Comentario_vino"
        Me.show_Comentario_vino.Size = New System.Drawing.Size(208, 20)
        Me.show_Comentario_vino.TabIndex = 469
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 466
        Me.Label5.Text = "Comentario"
        '
        'show_Marca
        '
        Me.show_Marca.BackColor = System.Drawing.SystemColors.Info
        Me.show_Marca.Enabled = False
        Me.show_Marca.Location = New System.Drawing.Point(172, 9)
        Me.show_Marca.Name = "show_Marca"
        Me.show_Marca.Size = New System.Drawing.Size(208, 20)
        Me.show_Marca.TabIndex = 468
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 467
        Me.Label6.Text = "Denominacion de Origen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.BODEGA.My.Resources.Resources.refresh
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Actualizar tabla"
        '
        'Huecos_completosBindingNavigator
        '
        Me.Huecos_completosBindingNavigator.AddNewItem = Nothing
        Me.Huecos_completosBindingNavigator.BindingSource = Me.Huecos_completosBindingSource
        Me.Huecos_completosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Huecos_completosBindingNavigator.DeleteItem = Nothing
        Me.Huecos_completosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.Huecos_completosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Huecos_completosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Huecos_completosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Huecos_completosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Huecos_completosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Huecos_completosBindingNavigator.Name = "Huecos_completosBindingNavigator"
        Me.Huecos_completosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Huecos_completosBindingNavigator.Size = New System.Drawing.Size(998, 25)
        Me.Huecos_completosBindingNavigator.TabIndex = 0
        Me.Huecos_completosBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.BODEGA.My.Resources.Resources.info
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        '
        'Editor_Huecos_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 475)
        Me.Controls.Add(Me.PanelVino)
        Me.Controls.Add(Me.PanelHueco)
        Me.Controls.Add(Me.b_Refrescar)
        Me.Controls.Add(Me.b_Modificar)
        Me.Controls.Add(Me.Huecos_completosDataGridView)
        Me.Controls.Add(Me.Huecos_completosBindingNavigator)
        Me.Name = "Editor_Huecos_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor_Huecos_Principal"
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Huecos_completosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Huecos_completosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHueco.ResumeLayout(False)
        Me.PanelHueco.PerformLayout()
        Me.PanelVino.ResumeLayout(False)
        Me.PanelVino.PerformLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Huecos_completosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Huecos_completosBindingNavigator.ResumeLayout(False)
        Me.Huecos_completosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents Huecos_completosBindingSource As BindingSource
    Friend WithEvents Huecos_completosTableAdapter As BD_Bodega_V1DataSetTableAdapters.Huecos_completosTableAdapter
    Friend WithEvents TableAdapterManager As BD_Bodega_V1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Huecos_completosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents b_Refrescar As Button
    Friend WithEvents b_Modificar As Button
    Friend WithEvents PanelHueco As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents PanelVino As Panel
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
    Friend WithEvents UsoRadioButton As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Show_uso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents show_Zona As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents show_Comentario_hueco As TextBox
    Friend WithEvents Show_photo_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Show_ID_Vino As TextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Huecos_completosBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
