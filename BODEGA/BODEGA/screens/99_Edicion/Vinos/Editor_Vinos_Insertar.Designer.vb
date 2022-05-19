<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Editor_Vinos_Insertar
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
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Insert_ID = New System.Windows.Forms.TextBox()
        Me.Insert_Marca = New System.Windows.Forms.TextBox()
        Me.Insert_Comentario = New System.Windows.Forms.TextBox()
        Me.ComboBox_Maduracion = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Tipos = New System.Windows.Forms.ComboBox()
        Me.ComboBox_DO = New System.Windows.Forms.ComboBox()
        Me.DenominacionesOrigenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BD_Bodega_V1DataSet = New BODEGA.BD_Bodega_V1DataSet()
        Me.Denominaciones_OrigenTableAdapter = New BODEGA.BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.b_SearchPhoto = New System.Windows.Forms.Button()
        Me.Insert_Maduracion = New System.Windows.Forms.TextBox()
        Me.Insert_Tipo = New System.Windows.Forms.TextBox()
        Me.Insert_Photo_Name = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Insert_Year = New System.Windows.Forms.TextBox()
        Me.Insert_DO = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.info_rellenar_campo_1 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_2 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_3 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_4 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_5 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_6 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_7 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_8 = New System.Windows.Forms.Button()
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(37, 403)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(155, 36)
        Me.b_SaveItem.TabIndex = 0
        Me.b_SaveItem.Text = "GUARDAR NUEVO VINO"
        Me.ToolTip1.SetToolTip(Me.b_SaveItem, "Pulsar para guardar el nuevo tipo de vino")
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo único identificacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Marca"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Maduracion "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Comentario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Denominacion de Origen"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(508, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Foto "
        '
        'Insert_ID
        '
        Me.Insert_ID.Location = New System.Drawing.Point(205, 38)
        Me.Insert_ID.Name = "Insert_ID"
        Me.Insert_ID.Size = New System.Drawing.Size(118, 20)
        Me.Insert_ID.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.Insert_ID, "Introducir codigo de ID del vino. NO PUEDE SER IGUAL a uno ya existente")
        '
        'Insert_Marca
        '
        Me.Insert_Marca.Location = New System.Drawing.Point(205, 77)
        Me.Insert_Marca.Name = "Insert_Marca"
        Me.Insert_Marca.Size = New System.Drawing.Size(273, 20)
        Me.Insert_Marca.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Insert_Marca, "Pulsar para introducir el nombre del vino")
        '
        'Insert_Comentario
        '
        Me.Insert_Comentario.Location = New System.Drawing.Point(205, 235)
        Me.Insert_Comentario.Name = "Insert_Comentario"
        Me.Insert_Comentario.Size = New System.Drawing.Size(276, 20)
        Me.Insert_Comentario.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Insert_Comentario, "Introducir un comentario")
        '
        'ComboBox_Maduracion
        '
        Me.ComboBox_Maduracion.FormattingEnabled = True
        Me.ComboBox_Maduracion.Items.AddRange(New Object() {"Cosecha", "Crianza", "Reserva", "Gran Reserva", "Otro"})
        Me.ComboBox_Maduracion.Location = New System.Drawing.Point(205, 116)
        Me.ComboBox_Maduracion.Name = "ComboBox_Maduracion"
        Me.ComboBox_Maduracion.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Maduracion.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.ComboBox_Maduracion, "Pulsar para acceder al listado de tipo de maduración del vino")
        '
        'ComboBox_Tipos
        '
        Me.ComboBox_Tipos.FormattingEnabled = True
        Me.ComboBox_Tipos.Items.AddRange(New Object() {"Tinto", "Rosado", "Blanco", "Cava", "Otro"})
        Me.ComboBox_Tipos.Location = New System.Drawing.Point(205, 195)
        Me.ComboBox_Tipos.Name = "ComboBox_Tipos"
        Me.ComboBox_Tipos.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Tipos.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.ComboBox_Tipos, "Pulsar para desplegar el tipo de Vino")
        '
        'ComboBox_DO
        '
        Me.ComboBox_DO.DataSource = Me.DenominacionesOrigenBindingSource
        Me.ComboBox_DO.DisplayMember = "ID_Denominacion"
        Me.ComboBox_DO.FormattingEnabled = True
        Me.ComboBox_DO.Location = New System.Drawing.Point(205, 274)
        Me.ComboBox_DO.Name = "ComboBox_DO"
        Me.ComboBox_DO.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_DO.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.ComboBox_DO, "Pulsar para abrir el listado de DO existentes")
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
        'Denominaciones_OrigenTableAdapter
        '
        Me.Denominaciones_OrigenTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'b_SearchPhoto
        '
        Me.b_SearchPhoto.Location = New System.Drawing.Point(545, 409)
        Me.b_SearchPhoto.Name = "b_SearchPhoto"
        Me.b_SearchPhoto.Size = New System.Drawing.Size(191, 25)
        Me.b_SearchPhoto.TabIndex = 14
        Me.b_SearchPhoto.Text = "SELECCIONAR FOTO"
        Me.ToolTip1.SetToolTip(Me.b_SearchPhoto, "Pulsar para acceder a la ruta especifica donde se deben guardar las fotos de los " &
        "nuevos vinos")
        Me.b_SearchPhoto.UseVisualStyleBackColor = True
        '
        'Insert_Maduracion
        '
        Me.Insert_Maduracion.Location = New System.Drawing.Point(378, 124)
        Me.Insert_Maduracion.Name = "Insert_Maduracion"
        Me.Insert_Maduracion.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Maduracion.TabIndex = 16
        '
        'Insert_Tipo
        '
        Me.Insert_Tipo.Location = New System.Drawing.Point(378, 195)
        Me.Insert_Tipo.Name = "Insert_Tipo"
        Me.Insert_Tipo.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Tipo.TabIndex = 17
        '
        'Insert_Photo_Name
        '
        Me.Insert_Photo_Name.Location = New System.Drawing.Point(378, 370)
        Me.Insert_Photo_Name.Name = "Insert_Photo_Name"
        Me.Insert_Photo_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Photo_Name.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Año"
        '
        'Insert_Year
        '
        Me.Insert_Year.Location = New System.Drawing.Point(205, 156)
        Me.Insert_Year.Name = "Insert_Year"
        Me.Insert_Year.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Year.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.Insert_Year, "Pulsar para introducir el año de la cosecha")
        '
        'Insert_DO
        '
        Me.Insert_DO.Location = New System.Drawing.Point(378, 279)
        Me.Insert_DO.Name = "Insert_DO"
        Me.Insert_DO.Size = New System.Drawing.Size(100, 20)
        Me.Insert_DO.TabIndex = 21
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.DimGray
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(545, 38)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(326, 365)
        Me.ShowPhotoVino.TabIndex = 408
        Me.ShowPhotoVino.TabStop = False
        '
        'info_rellenar_campo_1
        '
        Me.info_rellenar_campo_1.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_1.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_1.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_1.Location = New System.Drawing.Point(329, 37)
        Me.info_rellenar_campo_1.Name = "info_rellenar_campo_1"
        Me.info_rellenar_campo_1.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_1.TabIndex = 438
        Me.info_rellenar_campo_1.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_2
        '
        Me.info_rellenar_campo_2.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_2.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_2.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_2.Location = New System.Drawing.Point(475, 73)
        Me.info_rellenar_campo_2.Name = "info_rellenar_campo_2"
        Me.info_rellenar_campo_2.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_2.TabIndex = 439
        Me.info_rellenar_campo_2.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_3
        '
        Me.info_rellenar_campo_3.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_3.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_3.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_3.Location = New System.Drawing.Point(329, 116)
        Me.info_rellenar_campo_3.Name = "info_rellenar_campo_3"
        Me.info_rellenar_campo_3.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_3.TabIndex = 440
        Me.info_rellenar_campo_3.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_4
        '
        Me.info_rellenar_campo_4.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_4.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_4.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_4.Location = New System.Drawing.Point(311, 155)
        Me.info_rellenar_campo_4.Name = "info_rellenar_campo_4"
        Me.info_rellenar_campo_4.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_4.TabIndex = 441
        Me.info_rellenar_campo_4.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_5
        '
        Me.info_rellenar_campo_5.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_5.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_5.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_5.Location = New System.Drawing.Point(329, 194)
        Me.info_rellenar_campo_5.Name = "info_rellenar_campo_5"
        Me.info_rellenar_campo_5.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_5.TabIndex = 442
        Me.info_rellenar_campo_5.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_6
        '
        Me.info_rellenar_campo_6.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_6.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_6.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_6.Location = New System.Drawing.Point(484, 235)
        Me.info_rellenar_campo_6.Name = "info_rellenar_campo_6"
        Me.info_rellenar_campo_6.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_6.TabIndex = 443
        Me.info_rellenar_campo_6.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_7
        '
        Me.info_rellenar_campo_7.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_7.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_7.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_7.Location = New System.Drawing.Point(332, 278)
        Me.info_rellenar_campo_7.Name = "info_rellenar_campo_7"
        Me.info_rellenar_campo_7.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_7.TabIndex = 444
        Me.info_rellenar_campo_7.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_8
        '
        Me.info_rellenar_campo_8.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_8.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_8.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_8.Location = New System.Drawing.Point(742, 411)
        Me.info_rellenar_campo_8.Name = "info_rellenar_campo_8"
        Me.info_rellenar_campo_8.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_8.TabIndex = 445
        Me.info_rellenar_campo_8.UseVisualStyleBackColor = False
        '
        'Editor_Vinos_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 478)
        Me.Controls.Add(Me.info_rellenar_campo_8)
        Me.Controls.Add(Me.info_rellenar_campo_7)
        Me.Controls.Add(Me.info_rellenar_campo_6)
        Me.Controls.Add(Me.info_rellenar_campo_5)
        Me.Controls.Add(Me.info_rellenar_campo_4)
        Me.Controls.Add(Me.info_rellenar_campo_3)
        Me.Controls.Add(Me.info_rellenar_campo_2)
        Me.Controls.Add(Me.info_rellenar_campo_1)
        Me.Controls.Add(Me.ShowPhotoVino)
        Me.Controls.Add(Me.Insert_DO)
        Me.Controls.Add(Me.Insert_Year)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Insert_Photo_Name)
        Me.Controls.Add(Me.Insert_Tipo)
        Me.Controls.Add(Me.Insert_Maduracion)
        Me.Controls.Add(Me.b_SearchPhoto)
        Me.Controls.Add(Me.ComboBox_DO)
        Me.Controls.Add(Me.ComboBox_Tipos)
        Me.Controls.Add(Me.ComboBox_Maduracion)
        Me.Controls.Add(Me.Insert_Comentario)
        Me.Controls.Add(Me.Insert_Marca)
        Me.Controls.Add(Me.Insert_ID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.b_SaveItem)
        Me.Name = "Editor_Vinos_Insertar"
        Me.Text = "INSERTAR NUEVO VINO"
        CType(Me.DenominacionesOrigenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BD_Bodega_V1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_SaveItem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Insert_ID As TextBox
    Friend WithEvents Insert_Marca As TextBox
    Friend WithEvents Insert_Comentario As TextBox
    Friend WithEvents ComboBox_Maduracion As ComboBox
    Friend WithEvents ComboBox_Tipos As ComboBox
    Friend WithEvents ComboBox_DO As ComboBox
    Friend WithEvents BD_Bodega_V1DataSet As BD_Bodega_V1DataSet
    Friend WithEvents DenominacionesOrigenBindingSource As BindingSource
    Friend WithEvents Denominaciones_OrigenTableAdapter As BD_Bodega_V1DataSetTableAdapters.Denominaciones_OrigenTableAdapter
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents b_SearchPhoto As Button
    Friend WithEvents Insert_Maduracion As TextBox
    Friend WithEvents Insert_Tipo As TextBox
    Friend WithEvents Insert_Photo_Name As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Insert_Year As TextBox
    Friend WithEvents Insert_DO As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ShowPhotoVino As PictureBox
    Friend WithEvents info_rellenar_campo_1 As Button
    Friend WithEvents info_rellenar_campo_2 As Button
    Friend WithEvents info_rellenar_campo_3 As Button
    Friend WithEvents info_rellenar_campo_4 As Button
    Friend WithEvents info_rellenar_campo_5 As Button
    Friend WithEvents info_rellenar_campo_6 As Button
    Friend WithEvents info_rellenar_campo_7 As Button
    Friend WithEvents info_rellenar_campo_8 As Button
End Class
