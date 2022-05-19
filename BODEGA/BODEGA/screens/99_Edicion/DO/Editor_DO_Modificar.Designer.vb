<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_DO_Modificar
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
        Me.DenominacionesOrigenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.b_Search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Insert_Map_Name = New System.Windows.Forms.TextBox()
        Me.Insert_Logo_Name = New System.Windows.Forms.TextBox()
        Me.Insert_Informacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowMapDO = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.b_SearchPhoto_Map = New System.Windows.Forms.Button()
        Me.b_SearchPhoto_DO = New System.Windows.Forms.Button()
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_DeleteItem = New System.Windows.Forms.Button()
        Me.Denominaciones_OrigenTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter()
        Me.Show_ID = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.info_rellenar_campo_4 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_3 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_2 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_1 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Show_NumBotellas = New System.Windows.Forms.TextBox()
        Me.Panel_Lista = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowMapDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_Lista.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DenominacionesOrigenBindingSource
        Me.ComboBox1.DisplayMember = "ID_Denominacion"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(9, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(250, 21)
        Me.ComboBox1.TabIndex = 433
        '
        'DenominacionesOrigenBindingSource
        '
        Me.DenominacionesOrigenBindingSource.DataMember = "Denominaciones_Origen"
        Me.DenominacionesOrigenBindingSource.DataSource = Me.BD_Bodega_V1DataSet
        '
        'BD_Bodega_V1DataSet
        '
        Me.BD_Bodega_V1DataSet.DataSetName = "BD_Bodega_V1DataSet"
        Me.BD_Bodega_V1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'b_Search
        '
        Me.b_Search.Location = New System.Drawing.Point(9, 74)
        Me.b_Search.Name = "b_Search"
        Me.b_Search.Size = New System.Drawing.Size(100, 39)
        Me.b_Search.TabIndex = 435
        Me.b_Search.Text = "BUSCAR"
        Me.b_Search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 434
        Me.Label1.Text = "Listado de Denominaciones de Origen"
        '
        'Insert_Map_Name
        '
        Me.Insert_Map_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Map_Name.Location = New System.Drawing.Point(498, 3)
        Me.Insert_Map_Name.Name = "Insert_Map_Name"
        Me.Insert_Map_Name.Size = New System.Drawing.Size(331, 20)
        Me.Insert_Map_Name.TabIndex = 446
        Me.Insert_Map_Name.Visible = False
        '
        'Insert_Logo_Name
        '
        Me.Insert_Logo_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Logo_Name.Location = New System.Drawing.Point(37, 3)
        Me.Insert_Logo_Name.Name = "Insert_Logo_Name"
        Me.Insert_Logo_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Logo_Name.TabIndex = 445
        Me.Insert_Logo_Name.Visible = False
        '
        'Insert_Informacion
        '
        Me.Insert_Informacion.Location = New System.Drawing.Point(3, 233)
        Me.Insert_Informacion.Multiline = True
        Me.Insert_Informacion.Name = "Insert_Informacion"
        Me.Insert_Informacion.Size = New System.Drawing.Size(376, 76)
        Me.Insert_Informacion.TabIndex = 444
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 443
        Me.Label5.Text = "Informacion"
        '
        'ShowMapDO
        '
        Me.ShowMapDO.BackColor = System.Drawing.Color.DarkGray
        Me.ShowMapDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowMapDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowMapDO.Location = New System.Drawing.Point(412, 28)
        Me.ShowMapDO.Name = "ShowMapDO"
        Me.ShowMapDO.Size = New System.Drawing.Size(432, 309)
        Me.ShowMapDO.TabIndex = 442
        Me.ShowMapDO.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(409, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 441
        Me.Label2.Text = "Mapa ubicacion"
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BackColor = System.Drawing.Color.DarkGray
        Me.ShowPhotoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoDO.Location = New System.Drawing.Point(3, 28)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(134, 129)
        Me.ShowPhotoDO.TabIndex = 440
        Me.ShowPhotoDO.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 439
        Me.Label7.Text = "Logo"
        '
        'b_SearchPhoto_Map
        '
        Me.b_SearchPhoto_Map.Location = New System.Drawing.Point(546, 343)
        Me.b_SearchPhoto_Map.Name = "b_SearchPhoto_Map"
        Me.b_SearchPhoto_Map.Size = New System.Drawing.Size(191, 25)
        Me.b_SearchPhoto_Map.TabIndex = 438
        Me.b_SearchPhoto_Map.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto_Map.UseVisualStyleBackColor = True
        '
        'b_SearchPhoto_DO
        '
        Me.b_SearchPhoto_DO.Location = New System.Drawing.Point(3, 163)
        Me.b_SearchPhoto_DO.Name = "b_SearchPhoto_DO"
        Me.b_SearchPhoto_DO.Size = New System.Drawing.Size(134, 25)
        Me.b_SearchPhoto_DO.TabIndex = 437
        Me.b_SearchPhoto_DO.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto_DO.UseVisualStyleBackColor = True
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(3, 343)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(155, 36)
        Me.b_SaveItem.TabIndex = 436
        Me.b_SaveItem.Text = "ACTUALIZAR INFO DO"
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Show_NumBotellas)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_2)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_4)
        Me.Panel1.Controls.Add(Me.b_DeleteItem)
        Me.Panel1.Controls.Add(Me.info_rellenar_campo_3)
        Me.Panel1.Controls.Add(Me.Insert_Map_Name)
        Me.Panel1.Controls.Add(Me.Insert_Logo_Name)
        Me.Panel1.Controls.Add(Me.Insert_Informacion)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ShowMapDO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ShowPhotoDO)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.b_SearchPhoto_Map)
        Me.Panel1.Controls.Add(Me.b_SearchPhoto_DO)
        Me.Panel1.Controls.Add(Me.b_SaveItem)
        Me.Panel1.Location = New System.Drawing.Point(9, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 391)
        Me.Panel1.TabIndex = 447
        '
        'b_DeleteItem
        '
        Me.b_DeleteItem.Location = New System.Drawing.Point(169, 343)
        Me.b_DeleteItem.Name = "b_DeleteItem"
        Me.b_DeleteItem.Size = New System.Drawing.Size(180, 36)
        Me.b_DeleteItem.TabIndex = 449
        Me.b_DeleteItem.Text = "BORRAR DO"
        Me.b_DeleteItem.UseVisualStyleBackColor = True
        '
        'Denominaciones_OrigenTableAdapter
        '
        Me.Denominaciones_OrigenTableAdapter.ClearBeforeFill = True
        '
        'Show_ID
        '
        Me.Show_ID.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID.Location = New System.Drawing.Point(9, 6)
        Me.Show_ID.Name = "Show_ID"
        Me.Show_ID.Size = New System.Drawing.Size(100, 20)
        Me.Show_ID.TabIndex = 448
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'info_rellenar_campo_4
        '
        Me.info_rellenar_campo_4.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_4.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_4.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_4.Location = New System.Drawing.Point(67, 209)
        Me.info_rellenar_campo_4.Name = "info_rellenar_campo_4"
        Me.info_rellenar_campo_4.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_4.TabIndex = 452
        Me.info_rellenar_campo_4.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_3
        '
        Me.info_rellenar_campo_3.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_3.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_3.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_3.Location = New System.Drawing.Point(743, 343)
        Me.info_rellenar_campo_3.Name = "info_rellenar_campo_3"
        Me.info_rellenar_campo_3.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_3.TabIndex = 451
        Me.info_rellenar_campo_3.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_2
        '
        Me.info_rellenar_campo_2.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_2.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_2.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_2.Location = New System.Drawing.Point(143, 163)
        Me.info_rellenar_campo_2.Name = "info_rellenar_campo_2"
        Me.info_rellenar_campo_2.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_2.TabIndex = 450
        Me.info_rellenar_campo_2.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_1
        '
        Me.info_rellenar_campo_1.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_1.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_1.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_1.Location = New System.Drawing.Point(259, 46)
        Me.info_rellenar_campo_1.Name = "info_rellenar_campo_1"
        Me.info_rellenar_campo_1.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_1.TabIndex = 449
        Me.info_rellenar_campo_1.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(166, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 13)
        Me.Label11.TabIndex = 454
        Me.Label11.Text = "Nº Vinos registrados"
        '
        'Show_NumBotellas
        '
        Me.Show_NumBotellas.BackColor = System.Drawing.SystemColors.Info
        Me.Show_NumBotellas.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_NumBotellas.Enabled = False
        Me.Show_NumBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_NumBotellas.Location = New System.Drawing.Point(169, 28)
        Me.Show_NumBotellas.Name = "Show_NumBotellas"
        Me.Show_NumBotellas.Size = New System.Drawing.Size(98, 23)
        Me.Show_NumBotellas.TabIndex = 453
        Me.ToolTip1.SetToolTip(Me.Show_NumBotellas, "Número de botellas totales")
        '
        'Panel_Lista
        '
        Me.Panel_Lista.Controls.Add(Me.DataGridView1)
        Me.Panel_Lista.Location = New System.Drawing.Point(298, 12)
        Me.Panel_Lista.Name = "Panel_Lista"
        Me.Panel_Lista.Size = New System.Drawing.Size(574, 110)
        Me.Panel_Lista.TabIndex = 450
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 8)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 93)
        Me.DataGridView1.TabIndex = 1
        '
        'Editor_DO_Modificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(881, 534)
        Me.Controls.Add(Me.Panel_Lista)
        Me.Controls.Add(Me.info_rellenar_campo_1)
        Me.Controls.Add(Me.Show_ID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Editor_DO_Modificar"
        Me.Text = "Editor_DO_Modificar"
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowMapDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Lista.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents b_Search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Insert_Map_Name As TextBox
    Friend WithEvents Insert_Logo_Name As TextBox
    Friend WithEvents Insert_Informacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ShowMapDO As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents b_SearchPhoto_Map As Button
    Friend WithEvents b_SearchPhoto_DO As Button
    Friend WithEvents b_SaveItem As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents DenominacionesOrigenBindingSource As BindingSource
    Friend WithEvents Denominaciones_OrigenTableAdapter As BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter
    Friend WithEvents Show_ID As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents b_DeleteItem As Button
    Friend WithEvents info_rellenar_campo_2 As Button
    Friend WithEvents info_rellenar_campo_4 As Button
    Friend WithEvents info_rellenar_campo_3 As Button
    Friend WithEvents info_rellenar_campo_1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Show_NumBotellas As TextBox
    Friend WithEvents Panel_Lista As Panel
    Friend WithEvents DataGridView1 As DataGridView
End Class
