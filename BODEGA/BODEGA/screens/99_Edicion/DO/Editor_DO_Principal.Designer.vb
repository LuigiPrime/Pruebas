<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_DO_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_DO_Principal))
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.Denominaciones_OrigenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Denominaciones_OrigenTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter()
        Me.TableAdapterManager = New BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager()
        Me.Denominaciones_OrigenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem = New System.Windows.Forms.ToolStripButton()
        Me.Denominaciones_OrigenBindingNavigatorHelpItem = New System.Windows.Forms.ToolStripButton()
        Me.Denominaciones_OrigenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_Refrescar = New System.Windows.Forms.Button()
        Me.b_Modificar = New System.Windows.Forms.Button()
        Me.b_Insertar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShowPhotoMAP = New System.Windows.Forms.PictureBox()
        Me.Show_NumBotellas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Show_MAP_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Show_DO_Photo_name = New System.Windows.Forms.TextBox()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show_Informacion = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Denominaciones_OrigenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Denominaciones_OrigenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Denominaciones_OrigenBindingNavigator.SuspendLayout()
        CType(Me.Denominaciones_OrigenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ShowPhotoMAP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Denominaciones_OrigenBindingSource
        '
        Me.Denominaciones_OrigenBindingSource.DataMember = "Denominaciones_Origen"
        Me.Denominaciones_OrigenBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Denominaciones_OrigenTableAdapter
        '
        Me.Denominaciones_OrigenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Denominaciones_OrigenTableAdapter = Me.Denominaciones_OrigenTableAdapter
        Me.TableAdapterManager.Huecos_completosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VinosTableAdapter = Nothing
        Me.TableAdapterManager.Zonas_almacenamientoTableAdapter = Nothing
        '
        'Denominaciones_OrigenBindingNavigator
        '
        Me.Denominaciones_OrigenBindingNavigator.AddNewItem = Nothing
        Me.Denominaciones_OrigenBindingNavigator.BindingSource = Me.Denominaciones_OrigenBindingSource
        Me.Denominaciones_OrigenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Denominaciones_OrigenBindingNavigator.DeleteItem = Nothing
        Me.Denominaciones_OrigenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Denominaciones_OrigenBindingNavigatorRefreshItem, Me.Denominaciones_OrigenBindingNavigatorHelpItem})
        Me.Denominaciones_OrigenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Denominaciones_OrigenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Denominaciones_OrigenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Denominaciones_OrigenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Denominaciones_OrigenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Denominaciones_OrigenBindingNavigator.Name = "Denominaciones_OrigenBindingNavigator"
        Me.Denominaciones_OrigenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Denominaciones_OrigenBindingNavigator.Size = New System.Drawing.Size(975, 25)
        Me.Denominaciones_OrigenBindingNavigator.TabIndex = 0
        Me.Denominaciones_OrigenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'Denominaciones_OrigenBindingNavigatorRefreshItem
        '
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.Image = Global.BODEGA.My.Resources.Resources.refresh
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.Name = "Denominaciones_OrigenBindingNavigatorRefreshItem"
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.Size = New System.Drawing.Size(23, 22)
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.Text = "ToolStripButton1"
        Me.Denominaciones_OrigenBindingNavigatorRefreshItem.ToolTipText = "Actualizar tabla"
        '
        'Denominaciones_OrigenBindingNavigatorHelpItem
        '
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.Image = Global.BODEGA.My.Resources.Resources.info
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.Name = "Denominaciones_OrigenBindingNavigatorHelpItem"
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.Size = New System.Drawing.Size(23, 22)
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.Text = "ToolStripButton1"
        Me.Denominaciones_OrigenBindingNavigatorHelpItem.ToolTipText = "Ayuda"
        '
        'Denominaciones_OrigenDataGridView
        '
        Me.Denominaciones_OrigenDataGridView.AllowUserToAddRows = False
        Me.Denominaciones_OrigenDataGridView.AllowUserToDeleteRows = False
        Me.Denominaciones_OrigenDataGridView.AutoGenerateColumns = False
        Me.Denominaciones_OrigenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Denominaciones_OrigenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Denominaciones_OrigenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Denominaciones_OrigenDataGridView.DataSource = Me.Denominaciones_OrigenBindingSource
        Me.Denominaciones_OrigenDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.Denominaciones_OrigenDataGridView.Name = "Denominaciones_OrigenDataGridView"
        Me.Denominaciones_OrigenDataGridView.Size = New System.Drawing.Size(937, 146)
        Me.Denominaciones_OrigenDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Denominacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Denominacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 117
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Informacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Informacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 87
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Logo_denominacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Logo_denominacion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 128
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Mapa_ubicacion"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mapa_ubicacion"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 111
        '
        'b_Refrescar
        '
        Me.b_Refrescar.Location = New System.Drawing.Point(778, 191)
        Me.b_Refrescar.Name = "b_Refrescar"
        Me.b_Refrescar.Size = New System.Drawing.Size(171, 23)
        Me.b_Refrescar.TabIndex = 7
        Me.b_Refrescar.Text = "ACTUALIZAR TABLA"
        Me.b_Refrescar.UseVisualStyleBackColor = True
        '
        'b_Modificar
        '
        Me.b_Modificar.Location = New System.Drawing.Point(414, 191)
        Me.b_Modificar.Name = "b_Modificar"
        Me.b_Modificar.Size = New System.Drawing.Size(153, 23)
        Me.b_Modificar.TabIndex = 6
        Me.b_Modificar.Text = "MODIFICAR DO EXISTENTE"
        Me.b_Modificar.UseVisualStyleBackColor = True
        '
        'b_Insertar
        '
        Me.b_Insertar.Location = New System.Drawing.Point(12, 191)
        Me.b_Insertar.Name = "b_Insertar"
        Me.b_Insertar.Size = New System.Drawing.Size(191, 23)
        Me.b_Insertar.TabIndex = 5
        Me.b_Insertar.Text = "INSERTAR NUEVA DO"
        Me.b_Insertar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ShowPhotoMAP)
        Me.Panel1.Controls.Add(Me.Show_NumBotellas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Show_MAP_name)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Show_DO_Photo_name)
        Me.Panel1.Controls.Add(Me.ShowPhotoDO)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Show_ID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.show_Informacion)
        Me.Panel1.Location = New System.Drawing.Point(178, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 283)
        Me.Panel1.TabIndex = 446
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 456
        Me.Label11.Text = "Nº Vinos registrados"
        '
        'ShowPhotoMAP
        '
        Me.ShowPhotoMAP.BackColor = System.Drawing.Color.Silver
        Me.ShowPhotoMAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoMAP.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoMAP.Location = New System.Drawing.Point(337, 13)
        Me.ShowPhotoMAP.Name = "ShowPhotoMAP"
        Me.ShowPhotoMAP.Size = New System.Drawing.Size(330, 261)
        Me.ShowPhotoMAP.TabIndex = 465
        Me.ShowPhotoMAP.TabStop = False
        '
        'Show_NumBotellas
        '
        Me.Show_NumBotellas.BackColor = System.Drawing.SystemColors.Info
        Me.Show_NumBotellas.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_NumBotellas.Enabled = False
        Me.Show_NumBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_NumBotellas.Location = New System.Drawing.Point(20, 250)
        Me.Show_NumBotellas.Name = "Show_NumBotellas"
        Me.Show_NumBotellas.Size = New System.Drawing.Size(98, 23)
        Me.Show_NumBotellas.TabIndex = 455
        Me.ToolTip1.SetToolTip(Me.Show_NumBotellas, "Número de botellas totales")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 463
        Me.Label4.Text = "Nombre foto Mapa"
        Me.Label4.Visible = False
        '
        'Show_MAP_name
        '
        Me.Show_MAP_name.BackColor = System.Drawing.SystemColors.Info
        Me.Show_MAP_name.Enabled = False
        Me.Show_MAP_name.Location = New System.Drawing.Point(157, 125)
        Me.Show_MAP_name.Name = "Show_MAP_name"
        Me.Show_MAP_name.Size = New System.Drawing.Size(163, 20)
        Me.Show_MAP_name.TabIndex = 464
        Me.Show_MAP_name.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(154, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 461
        Me.Label3.Text = "Nombre Foto DO"
        Me.Label3.Visible = False
        '
        'Show_DO_Photo_name
        '
        Me.Show_DO_Photo_name.BackColor = System.Drawing.SystemColors.Info
        Me.Show_DO_Photo_name.Enabled = False
        Me.Show_DO_Photo_name.Location = New System.Drawing.Point(157, 86)
        Me.Show_DO_Photo_name.Name = "Show_DO_Photo_name"
        Me.Show_DO_Photo_name.Size = New System.Drawing.Size(163, 20)
        Me.Show_DO_Photo_name.TabIndex = 462
        Me.Show_DO_Photo_name.Visible = False
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BackColor = System.Drawing.Color.DarkGray
        Me.ShowPhotoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoDO.Location = New System.Drawing.Point(20, 46)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(131, 129)
        Me.ShowPhotoDO.TabIndex = 460
        Me.ShowPhotoDO.TabStop = False
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
        Me.Show_ID.Location = New System.Drawing.Point(157, 13)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(163, 20)
        Me.Show_ID.TabIndex = 447
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "Informacion"
        '
        'show_Informacion
        '
        Me.show_Informacion.BackColor = System.Drawing.SystemColors.Info
        Me.show_Informacion.Enabled = False
        Me.show_Informacion.Location = New System.Drawing.Point(20, 194)
        Me.show_Informacion.Name = "show_Informacion"
        Me.show_Informacion.Size = New System.Drawing.Size(300, 20)
        Me.show_Informacion.TabIndex = 453
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(616, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(63, 20)
        Me.TextBox1.TabIndex = 447
        Me.TextBox1.Visible = False
        '
        'Editor_DO_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 520)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_Refrescar)
        Me.Controls.Add(Me.b_Modificar)
        Me.Controls.Add(Me.b_Insertar)
        Me.Controls.Add(Me.Denominaciones_OrigenDataGridView)
        Me.Controls.Add(Me.Denominaciones_OrigenBindingNavigator)
        Me.Name = "Editor_DO_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor_DO_Principal"
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Denominaciones_OrigenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Denominaciones_OrigenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Denominaciones_OrigenBindingNavigator.ResumeLayout(False)
        Me.Denominaciones_OrigenBindingNavigator.PerformLayout()
        CType(Me.Denominaciones_OrigenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ShowPhotoMAP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents Denominaciones_OrigenBindingSource As BindingSource
    Friend WithEvents Denominaciones_OrigenTableAdapter As BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter
    Friend WithEvents TableAdapterManager As BD_Bodega_V1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Denominaciones_OrigenBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Denominaciones_OrigenDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents b_Refrescar As Button
    Friend WithEvents b_Modificar As Button
    Friend WithEvents b_Insertar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents show_Informacion As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Show_MAP_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Show_DO_Photo_name As TextBox
    Friend WithEvents ShowPhotoMAP As PictureBox
    Friend WithEvents Denominaciones_OrigenBindingNavigatorRefreshItem As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Denominaciones_OrigenBindingNavigatorHelpItem As ToolStripButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Show_NumBotellas As TextBox
End Class
