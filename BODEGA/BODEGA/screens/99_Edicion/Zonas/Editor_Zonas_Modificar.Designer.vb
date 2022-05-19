<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_Zonas_Modificar
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
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.b_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_DeleteItem = New System.Windows.Forms.Button()
        Me.Insert_Photo_Name = New System.Windows.Forms.TextBox()
        Me.Insert_Informacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Show_Photo = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_SearchPhoto = New System.Windows.Forms.Button()
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.ZonasalmacenamientoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Zonas_almacenamientoTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Show_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZonasalmacenamientoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Location = New System.Drawing.Point(9, 9)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(100, 20)
        Me.Show_ID.TabIndex = 453
        '
        'b_Search
        '
        Me.b_Search.Location = New System.Drawing.Point(9, 86)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(100, 39)
        Me.b_Search.TabIndex = 452
        Me.b_Search.Text = "BUSCAR"
        Me.b_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 451
        Me.Label1.Text = "ID Zona"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ZonasalmacenamientoBindingSource
        Me.ComboBox1.DisplayMember = "ID_Zona"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 50)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 450
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(150, 32)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(725, 93)
        Me.DataGridView1.TabIndex = 449
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.b_DeleteItem)
        Me.Panel1.Controls.Add(Me.Insert_Photo_Name)
        Me.Panel1.Controls.Add(Me.Insert_Informacion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Show_Photo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.b_SearchPhoto)
        Me.Panel1.Controls.Add(Me.b_SaveItem)
        Me.Panel1.Location = New System.Drawing.Point(12, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 391)
        Me.Panel1.TabIndex = 454
        '
        'b_DeleteItem
        '
        Me.b_DeleteItem.Location = New System.Drawing.Point(191, 343)
        Me.b_DeleteItem.Name = "b_DeleteItem"
        Me.b_DeleteItem.Size = New System.Drawing.Size(180, 36)
        Me.b_DeleteItem.TabIndex = 449
        Me.b_DeleteItem.Text = "BORRAR DO"
        Me.b_DeleteItem.UseVisualStyleBackColor = True
        '
        'Insert_Photo_Name
        '
        Me.Insert_Photo_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Photo_Name.Location = New System.Drawing.Point(513, 0)
        Me.Insert_Photo_Name.Name = "Insert_Photo_Name"
        Me.Insert_Photo_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Photo_Name.TabIndex = 446
        Me.Insert_Photo_Name.Visible = False
        '
        'Insert_Informacion
        '
        Me.Insert_Informacion.Location = New System.Drawing.Point(45, 28)
        Me.Insert_Informacion.Multiline = True
        Me.Insert_Informacion.Name = "Insert_Informacion"
        Me.Insert_Informacion.Size = New System.Drawing.Size(376, 76)
        Me.Insert_Informacion.TabIndex = 444
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 443
        Me.Label5.Text = "Zona"
        '
        'Show_Photo
        '
        Me.Show_Photo.BackColor = System.Drawing.Color.Transparent
        Me.Show_Photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Show_Photo.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Show_Photo.Location = New System.Drawing.Point(427, 28)
        Me.Show_Photo.Name = "Show_Photo"
        Me.Show_Photo.Size = New System.Drawing.Size(417, 281)
        Me.Show_Photo.TabIndex = 442
        Me.Show_Photo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 441
        Me.Label2.Text = "Foto ubicacion"
        '
        'b_SearchPhoto
        '
        Me.b_SearchPhoto.Location = New System.Drawing.Point(551, 329)
        Me.b_SearchPhoto.Name = "b_SearchPhoto"
        Me.b_SearchPhoto.Size = New System.Drawing.Size(191, 25)
        Me.b_SearchPhoto.TabIndex = 438
        Me.b_SearchPhoto.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto.UseVisualStyleBackColor = True
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(30, 343)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(155, 36)
        Me.b_SaveItem.TabIndex = 436
        Me.b_SaveItem.Text = "ACTUALIZAR INFO DO"
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ZonasalmacenamientoBindingSource
        '
        Me.ZonasalmacenamientoBindingSource.DataMember = "Zonas_almacenamiento"
        Me.ZonasalmacenamientoBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'Zonas_almacenamientoTableAdapter
        '
        Me.Zonas_almacenamientoTableAdapter.ClearBeforeFill = True
        '
        'Editor_Zonas_Modificar
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(893, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Show_ID)
        Me.Controls.Add(Me.b_Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Editor_Zonas_Modificar"
        Me.Text = "Editor_Zonas_Modificar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Show_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZonasalmacenamientoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Show_ID As TextBox
    Friend WithEvents b_Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_DeleteItem As Button
    Friend WithEvents Insert_Photo_Name As TextBox
    Friend WithEvents Insert_Informacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Show_Photo As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents b_SearchPhoto As Button
    Friend WithEvents b_SaveItem As Button
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents ZonasalmacenamientoBindingSource As BindingSource
    Friend WithEvents Zonas_almacenamientoTableAdapter As BD_Bodega_V1DataSetTableAdapters.Zonas_almacenamientoTableAdapter
End Class
