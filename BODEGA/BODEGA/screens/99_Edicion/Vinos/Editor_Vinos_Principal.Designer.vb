<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Vinos_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Vinos_Principal))
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.VinosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VinosTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter()
        Me.TableAdapterManager = New BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager()
        Me.VinosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.b_Actualizar = New System.Windows.Forms.ToolStripButton()
        Me.AyudaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.VinosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_Insertar = New System.Windows.Forms.Button()
        Me.b_Modificar = New System.Windows.Forms.Button()
        Me.b_Refrescar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.show_Year = New System.Windows.Forms.TextBox()
        Me.show_DO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show_Tipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.show_Maduracion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.show_Comentario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.show_Marca = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VinosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VinosBindingNavigator.SuspendLayout()
        CType(Me.VinosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Denominaciones_OrigenTableAdapter = Nothing
        Me.TableAdapterManager.Huecos_completosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VinosTableAdapter = Me.VinosTableAdapter
        Me.TableAdapterManager.Zonas_almacenamientoTableAdapter = Nothing
        '
        'VinosBindingNavigator
        '
        Me.VinosBindingNavigator.AddNewItem = Nothing
        Me.VinosBindingNavigator.BindingSource = Me.VinosBindingSource
        Me.VinosBindingNavigator.CountItem = Nothing
        Me.VinosBindingNavigator.DeleteItem = Nothing
        Me.VinosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.toolStripSeparator1, Me.b_Actualizar, Me.AyudaToolStripButton})
        Me.VinosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VinosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VinosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VinosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VinosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VinosBindingNavigator.Name = "VinosBindingNavigator"
        Me.VinosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HelpProvider1.SetShowHelp(Me.VinosBindingNavigator, True)
        Me.VinosBindingNavigator.Size = New System.Drawing.Size(868, 25)
        Me.VinosBindingNavigator.TabIndex = 0
        Me.VinosBindingNavigator.Text = "BindingNavigator1"
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
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'b_Actualizar
        '
        Me.b_Actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.b_Actualizar.Image = Global.BODEGA.My.Resources.Resources.refresh
        Me.b_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.b_Actualizar.Name = "b_Actualizar"
        Me.b_Actualizar.Size = New System.Drawing.Size(23, 22)
        Me.b_Actualizar.Text = "Actualizar Tabla"
        '
        'AyudaToolStripButton
        '
        Me.AyudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AyudaToolStripButton.Image = CType(resources.GetObject("AyudaToolStripButton.Image"), System.Drawing.Image)
        Me.AyudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AyudaToolStripButton.Name = "AyudaToolStripButton"
        Me.AyudaToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AyudaToolStripButton.Text = "Ay&uda"
        '
        'VinosDataGridView
        '
        Me.VinosDataGridView.AutoGenerateColumns = False
        Me.VinosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.VinosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VinosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.VinosDataGridView.DataSource = Me.VinosBindingSource
        Me.VinosDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.VinosDataGridView.Name = "VinosDataGridView"
        Me.VinosDataGridView.Size = New System.Drawing.Size(845, 220)
        Me.VinosDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id_Vino"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Vino"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 68
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 62
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Maduracion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Maduracion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 88
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Año"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Año"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 51
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 53
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Comentario"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Comentario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 85
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Denominacion_Origen"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Denominacion_Origen"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 137
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Foto_Etiqueta"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Foto_Etiqueta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 98
        '
        'b_Insertar
        '
        Me.b_Insertar.Location = New System.Drawing.Point(12, 280)
        Me.b_Insertar.Name = "b_Insertar"
        Me.b_Insertar.Size = New System.Drawing.Size(191, 44)
        Me.b_Insertar.TabIndex = 2
        Me.b_Insertar.Text = "INSERTAR NUEVO VINO"
        Me.ToolTip1.SetToolTip(Me.b_Insertar, "Pulsar para abrir la ventana de insercion nuevo Vino")
        Me.b_Insertar.UseVisualStyleBackColor = True
        '
        'b_Modificar
        '
        Me.b_Modificar.Location = New System.Drawing.Point(339, 280)
        Me.b_Modificar.Name = "b_Modificar"
        Me.b_Modificar.Size = New System.Drawing.Size(191, 44)
        Me.b_Modificar.TabIndex = 3
        Me.b_Modificar.Text = "MODIFICAR VINO EXISTENTE"
        Me.ToolTip1.SetToolTip(Me.b_Modificar, "Pulsar para ir a la pantalla de modificacion de Vinos")
        Me.b_Modificar.UseVisualStyleBackColor = True
        '
        'b_Refrescar
        '
        Me.b_Refrescar.Location = New System.Drawing.Point(666, 280)
        Me.b_Refrescar.Name = "b_Refrescar"
        Me.b_Refrescar.Size = New System.Drawing.Size(191, 44)
        Me.b_Refrescar.TabIndex = 4
        Me.b_Refrescar.Text = "ACTUALIZAR TABLA"
        Me.ToolTip1.SetToolTip(Me.b_Refrescar, "Pulsar para actualizar la informacion a visualizar")
        Me.b_Refrescar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 254)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(845, 20)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ShowPhotoVino)
        Me.Panel1.Controls.Add(Me.show_Year)
        Me.Panel1.Controls.Add(Me.show_DO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Show_ID)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.show_Tipo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.show_Maduracion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.show_Comentario)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.show_Marca)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(12, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(845, 203)
        Me.Panel1.TabIndex = 445
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(638, 3)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(204, 197)
        Me.ShowPhotoVino.TabIndex = 460
        Me.ShowPhotoVino.TabStop = False
        '
        'show_Year
        '
        Me.show_Year.BackColor = System.Drawing.SystemColors.Info
        Me.show_Year.Enabled = False
        Me.show_Year.Location = New System.Drawing.Point(147, 97)
        Me.show_Year.Name = "show_Year"
        Me.show_Year.Size = New System.Drawing.Size(100, 20)
        Me.show_Year.TabIndex = 458
        '
        'show_DO
        '
        Me.show_DO.BackColor = System.Drawing.SystemColors.Info
        Me.show_DO.Enabled = False
        Me.show_DO.Location = New System.Drawing.Point(147, 145)
        Me.show_DO.Name = "show_DO"
        Me.show_DO.Size = New System.Drawing.Size(100, 20)
        Me.show_DO.TabIndex = 459
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
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Enabled = False
        Me.Show_ID.Location = New System.Drawing.Point(226, 13)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(75, 20)
        Me.Show_ID.TabIndex = 447
        Me.ToolTip1.SetToolTip(Me.Show_ID, "Codigo ID del Vino")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 457
        Me.Label8.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "Marca"
        '
        'show_Tipo
        '
        Me.show_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.show_Tipo.Enabled = False
        Me.show_Tipo.Location = New System.Drawing.Point(147, 73)
        Me.show_Tipo.Name = "show_Tipo"
        Me.show_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.show_Tipo.TabIndex = 456
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 449
        Me.Label3.Text = "Maduracion "
        '
        'show_Maduracion
        '
        Me.show_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.show_Maduracion.Enabled = False
        Me.show_Maduracion.Location = New System.Drawing.Point(147, 121)
        Me.show_Maduracion.Name = "show_Maduracion"
        Me.show_Maduracion.Size = New System.Drawing.Size(100, 20)
        Me.show_Maduracion.TabIndex = 455
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 450
        Me.Label4.Text = "Tipo"
        '
        'show_Comentario
        '
        Me.show_Comentario.BackColor = System.Drawing.SystemColors.Info
        Me.show_Comentario.Enabled = False
        Me.show_Comentario.Location = New System.Drawing.Point(147, 169)
        Me.show_Comentario.Name = "show_Comentario"
        Me.show_Comentario.Size = New System.Drawing.Size(300, 20)
        Me.show_Comentario.TabIndex = 454
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 451
        Me.Label5.Text = "Comentario"
        '
        'show_Marca
        '
        Me.show_Marca.BackColor = System.Drawing.SystemColors.Info
        Me.show_Marca.Enabled = False
        Me.show_Marca.Location = New System.Drawing.Point(147, 49)
        Me.show_Marca.Name = "show_Marca"
        Me.show_Marca.Size = New System.Drawing.Size(300, 20)
        Me.show_Marca.TabIndex = 453
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 452
        Me.Label6.Text = "Denominacion de Origen"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\Luis\Documents\BODEGA\Vinoteca_V10\BODEGA\BODEGA\Resources\Ayuda_vinotec" &
    "a.chm"
        '
        'Editor_Vinos_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 548)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.b_Refrescar)
        Me.Controls.Add(Me.b_Modificar)
        Me.Controls.Add(Me.b_Insertar)
        Me.Controls.Add(Me.VinosDataGridView)
        Me.Controls.Add(Me.VinosBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.HelpButton = True
        Me.Name = "Editor_Vinos_Principal"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor_Vinos_Principal"
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VinosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VinosBindingNavigator.ResumeLayout(False)
        Me.VinosBindingNavigator.PerformLayout()
        CType(Me.VinosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents VinosBindingSource As BindingSource
    Friend WithEvents VinosTableAdapter As BD_Bodega_V1DataSetTableAdapters.VinosTableAdapter
    Friend WithEvents TableAdapterManager As BD_Bodega_V1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VinosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VinosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents b_Insertar As Button
    Friend WithEvents b_Modificar As Button
    Friend WithEvents b_Refrescar As Button
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AyudaToolStripButton As ToolStripButton
    Friend WithEvents b_Actualizar As ToolStripButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShowPhotoVino As PictureBox
    Friend WithEvents show_Year As TextBox
    Friend WithEvents show_DO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents show_Tipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents show_Maduracion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents show_Comentario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents show_Marca As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
