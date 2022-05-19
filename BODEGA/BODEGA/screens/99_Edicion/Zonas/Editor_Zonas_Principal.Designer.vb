<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Zonas_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Editor_Zonas_Principal))
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.Zonas_almacenamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zonas_almacenamientoTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter()
        Me.TableAdapterManager = New BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager()
        Me.Zonas_almacenamientoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Zonas_almacenamientoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_Refrescar = New System.Windows.Forms.Button()
        Me.b_Modificar = New System.Windows.Forms.Button()
        Me.b_Insertar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Show_Zona_Photo = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Show_Photo_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.show_zona = New System.Windows.Forms.TextBox()
        Me.Zonas_BindingNavigatorRefreshItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zonas_almacenamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Zonas_almacenamientoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Zonas_almacenamientoBindingNavigator.SuspendLayout()
        CType(Me.Zonas_almacenamientoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Show_Zona_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Zonas_almacenamientoBindingSource
        '
        Me.Zonas_almacenamientoBindingSource.DataMember = "Zonas_almacenamiento"
        Me.Zonas_almacenamientoBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Zonas_almacenamientoTableAdapter
        '
        Me.Zonas_almacenamientoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Denominaciones_OrigenTableAdapter = Nothing
        Me.TableAdapterManager.Huecos_completosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = BODEGA.BD_Bodega_V1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VinosTableAdapter = Nothing
        Me.TableAdapterManager.Zonas_almacenamientoTableAdapter = Me.Zonas_almacenamientoTableAdapter
        '
        'Zonas_almacenamientoBindingNavigator
        '
        Me.Zonas_almacenamientoBindingNavigator.AddNewItem = Nothing
        Me.Zonas_almacenamientoBindingNavigator.BindingSource = Me.Zonas_almacenamientoBindingSource
        Me.Zonas_almacenamientoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Zonas_almacenamientoBindingNavigator.DeleteItem = Nothing
        Me.Zonas_almacenamientoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Zonas_BindingNavigatorRefreshItem, Me.ToolStripButton2})
        Me.Zonas_almacenamientoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Zonas_almacenamientoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Zonas_almacenamientoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Zonas_almacenamientoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Zonas_almacenamientoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Zonas_almacenamientoBindingNavigator.Name = "Zonas_almacenamientoBindingNavigator"
        Me.Zonas_almacenamientoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Zonas_almacenamientoBindingNavigator.Size = New System.Drawing.Size(960, 25)
        Me.Zonas_almacenamientoBindingNavigator.TabIndex = 0
        Me.Zonas_almacenamientoBindingNavigator.Text = "BindingNavigator1"
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
        'Zonas_almacenamientoDataGridView
        '
        Me.Zonas_almacenamientoDataGridView.AutoGenerateColumns = False
        Me.Zonas_almacenamientoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.Zonas_almacenamientoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Zonas_almacenamientoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Zonas_almacenamientoDataGridView.DataSource = Me.Zonas_almacenamientoBindingSource
        Me.Zonas_almacenamientoDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.Zonas_almacenamientoDataGridView.Name = "Zonas_almacenamientoDataGridView"
        Me.Zonas_almacenamientoDataGridView.Size = New System.Drawing.Size(787, 179)
        Me.Zonas_almacenamientoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_Zona"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_Zona"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Zona"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Zona"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 57
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Foto_zona"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Foto_zona"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 82
        '
        'b_Refrescar
        '
        Me.b_Refrescar.Location = New System.Drawing.Point(628, 239)
        Me.b_Refrescar.Name = "b_Refrescar"
        Me.b_Refrescar.Size = New System.Drawing.Size(171, 23)
        Me.b_Refrescar.TabIndex = 10
        Me.b_Refrescar.Text = "ACTUALIZAR TABLA"
        Me.b_Refrescar.UseVisualStyleBackColor = True
        '
        'b_Modificar
        '
        Me.b_Modificar.Location = New System.Drawing.Point(295, 239)
        Me.b_Modificar.Name = "b_Modificar"
        Me.b_Modificar.Size = New System.Drawing.Size(153, 23)
        Me.b_Modificar.TabIndex = 9
        Me.b_Modificar.Text = "MODIFICAR ZONA"
        Me.b_Modificar.UseVisualStyleBackColor = True
        '
        'b_Insertar
        '
        Me.b_Insertar.Location = New System.Drawing.Point(12, 239)
        Me.b_Insertar.Name = "b_Insertar"
        Me.b_Insertar.Size = New System.Drawing.Size(191, 23)
        Me.b_Insertar.TabIndex = 8
        Me.b_Insertar.Text = "INSERTAR NUEVA ZONA"
        Me.b_Insertar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Show_Zona_Photo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Show_Photo_name)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Show_ID)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.show_zona)
        Me.Panel1.Location = New System.Drawing.Point(12, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(856, 286)
        Me.Panel1.TabIndex = 447
        '
        'Show_Zona_Photo
        '
        Me.Show_Zona_Photo.BackColor = System.Drawing.Color.Transparent
        Me.Show_Zona_Photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Show_Zona_Photo.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Show_Zona_Photo.Location = New System.Drawing.Point(453, 13)
        Me.Show_Zona_Photo.Name = "Show_Zona_Photo"
        Me.Show_Zona_Photo.Size = New System.Drawing.Size(387, 251)
        Me.Show_Zona_Photo.TabIndex = 465
        Me.Show_Zona_Photo.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 463
        Me.Label4.Text = "Nombre foto Mapa"
        Me.Label4.Visible = False
        '
        'Show_Photo_name
        '
        Me.Show_Photo_name.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Photo_name.Enabled = False
        Me.Show_Photo_name.Location = New System.Drawing.Point(147, 244)
        Me.Show_Photo_name.Name = "Show_Photo_name"
        Me.Show_Photo_name.Size = New System.Drawing.Size(300, 20)
        Me.Show_Photo_name.TabIndex = 464
        Me.Show_Photo_name.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 446
        Me.Label1.Text = "Codigo único identificacion"
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Enabled = False
        Me.Show_ID.Location = New System.Drawing.Point(147, 16)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(300, 20)
        Me.Show_ID.TabIndex = 447
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 448
        Me.Label2.Text = "Informacion"
        '
        'show_zona
        '
        Me.show_zona.BackColor = System.Drawing.SystemColors.Info
        Me.show_zona.Enabled = False
        Me.show_zona.Location = New System.Drawing.Point(147, 60)
        Me.show_zona.Name = "show_zona"
        Me.show_zona.Size = New System.Drawing.Size(300, 20)
        Me.show_zona.TabIndex = 453
        '
        'Zonas_BindingNavigatorRefreshItem
        '
        Me.Zonas_BindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Zonas_BindingNavigatorRefreshItem.Image = Global.BODEGA.My.Resources.Resources.refresh
        Me.Zonas_BindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Zonas_BindingNavigatorRefreshItem.Name = "Zonas_BindingNavigatorRefreshItem"
        Me.Zonas_BindingNavigatorRefreshItem.Size = New System.Drawing.Size(23, 22)
        Me.Zonas_BindingNavigatorRefreshItem.Text = "ToolStripButton1"
        Me.Zonas_BindingNavigatorRefreshItem.ToolTipText = "Actualizar tabla"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.BODEGA.My.Resources.Resources.info
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Ayuda"
        '
        'Editor_Zonas_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 630)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_Refrescar)
        Me.Controls.Add(Me.b_Modificar)
        Me.Controls.Add(Me.b_Insertar)
        Me.Controls.Add(Me.Zonas_almacenamientoDataGridView)
        Me.Controls.Add(Me.Zonas_almacenamientoBindingNavigator)
        Me.Name = "Editor_Zonas_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editor_Zonas_Principal"
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zonas_almacenamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Zonas_almacenamientoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Zonas_almacenamientoBindingNavigator.ResumeLayout(False)
        Me.Zonas_almacenamientoBindingNavigator.PerformLayout()
        CType(Me.Zonas_almacenamientoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Show_Zona_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents Zonas_almacenamientoBindingSource As BindingSource
    Friend WithEvents Zonas_almacenamientoTableAdapter As BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter
    Friend WithEvents TableAdapterManager As BD_Bodega_V1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Zonas_almacenamientoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Zonas_almacenamientoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents b_Refrescar As Button
    Friend WithEvents b_Modificar As Button
    Friend WithEvents b_Insertar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Show_Zona_Photo As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Show_Photo_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents show_zona As TextBox
    Friend WithEvents Zonas_BindingNavigatorRefreshItem As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
End Class
