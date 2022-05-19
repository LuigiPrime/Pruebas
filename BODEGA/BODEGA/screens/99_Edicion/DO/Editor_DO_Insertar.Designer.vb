<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor_DO_Insertar
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
        Me.b_SaveItem = New System.Windows.Forms.Button()
        Me.b_SearchPhoto_DO = New System.Windows.Forms.Button()
        Me.b_SearchPhoto_Map = New System.Windows.Forms.Button()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowMapDO = New System.Windows.Forms.PictureBox()
        Me.Insert_ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Insert_Informacion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Insert_Logo_Name = New System.Windows.Forms.TextBox()
        Me.Insert_Map_Name = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.info_rellenar_campo_4 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_3 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_2 = New System.Windows.Forms.Button()
        Me.info_rellenar_campo_1 = New System.Windows.Forms.Button()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowMapDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_SaveItem
        '
        Me.b_SaveItem.Location = New System.Drawing.Point(36, 390)
        Me.b_SaveItem.Name = "b_SaveItem"
        Me.b_SaveItem.Size = New System.Drawing.Size(155, 36)
        Me.b_SaveItem.TabIndex = 1
        Me.b_SaveItem.Text = "GUARDAR NUEVA DO"
        Me.b_SaveItem.UseVisualStyleBackColor = True
        '
        'b_SearchPhoto_DO
        '
        Me.b_SearchPhoto_DO.Location = New System.Drawing.Point(36, 249)
        Me.b_SearchPhoto_DO.Name = "b_SearchPhoto_DO"
        Me.b_SearchPhoto_DO.Size = New System.Drawing.Size(134, 25)
        Me.b_SearchPhoto_DO.TabIndex = 15
        Me.b_SearchPhoto_DO.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto_DO.UseVisualStyleBackColor = True
        '
        'b_SearchPhoto_Map
        '
        Me.b_SearchPhoto_Map.Location = New System.Drawing.Point(518, 401)
        Me.b_SearchPhoto_Map.Name = "b_SearchPhoto_Map"
        Me.b_SearchPhoto_Map.Size = New System.Drawing.Size(191, 25)
        Me.b_SearchPhoto_Map.TabIndex = 16
        Me.b_SearchPhoto_Map.Text = "SELECCIONAR FOTO"
        Me.b_SearchPhoto_Map.UseVisualStyleBackColor = True
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BackColor = System.Drawing.Color.DarkGray
        Me.ShowPhotoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoDO.Location = New System.Drawing.Point(33, 114)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(134, 129)
        Me.ShowPhotoDO.TabIndex = 410
        Me.ShowPhotoDO.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 409
        Me.Label7.Text = "Logo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 411
        Me.Label1.Text = "Mapa ubicacion"
        '
        'ShowMapDO
        '
        Me.ShowMapDO.BackColor = System.Drawing.Color.Silver
        Me.ShowMapDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowMapDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowMapDO.Location = New System.Drawing.Point(400, 114)
        Me.ShowMapDO.Name = "ShowMapDO"
        Me.ShowMapDO.Size = New System.Drawing.Size(417, 281)
        Me.ShowMapDO.TabIndex = 412
        Me.ShowMapDO.TabStop = False
        '
        'Insert_ID
        '
        Me.Insert_ID.Location = New System.Drawing.Point(36, 53)
        Me.Insert_ID.Name = "Insert_ID"
        Me.Insert_ID.Size = New System.Drawing.Size(319, 20)
        Me.Insert_ID.TabIndex = 414
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 413
        Me.Label2.Text = "Codigo único identificacion"
        '
        'Insert_Informacion
        '
        Me.Insert_Informacion.Location = New System.Drawing.Point(101, 307)
        Me.Insert_Informacion.Name = "Insert_Informacion"
        Me.Insert_Informacion.Size = New System.Drawing.Size(254, 20)
        Me.Insert_Informacion.TabIndex = 416
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 415
        Me.Label5.Text = "Informacion"
        '
        'Insert_Logo_Name
        '
        Me.Insert_Logo_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Logo_Name.Location = New System.Drawing.Point(667, 24)
        Me.Insert_Logo_Name.Name = "Insert_Logo_Name"
        Me.Insert_Logo_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Logo_Name.TabIndex = 417
        Me.Insert_Logo_Name.Visible = False
        '
        'Insert_Map_Name
        '
        Me.Insert_Map_Name.BackColor = System.Drawing.SystemColors.Info
        Me.Insert_Map_Name.Location = New System.Drawing.Point(667, 50)
        Me.Insert_Map_Name.Name = "Insert_Map_Name"
        Me.Insert_Map_Name.Size = New System.Drawing.Size(100, 20)
        Me.Insert_Map_Name.TabIndex = 418
        Me.Insert_Map_Name.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.InitialDirectory = "Ruta_DO"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        Me.OpenFileDialog2.InitialDirectory = "Ruta_Logos_DO"
        '
        'info_rellenar_campo_4
        '
        Me.info_rellenar_campo_4.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_4.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_4.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_4.Location = New System.Drawing.Point(361, 306)
        Me.info_rellenar_campo_4.Name = "info_rellenar_campo_4"
        Me.info_rellenar_campo_4.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_4.TabIndex = 448
        Me.info_rellenar_campo_4.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_3
        '
        Me.info_rellenar_campo_3.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_3.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_3.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_3.Location = New System.Drawing.Point(715, 405)
        Me.info_rellenar_campo_3.Name = "info_rellenar_campo_3"
        Me.info_rellenar_campo_3.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_3.TabIndex = 447
        Me.info_rellenar_campo_3.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_2
        '
        Me.info_rellenar_campo_2.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_2.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_2.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_2.Location = New System.Drawing.Point(176, 251)
        Me.info_rellenar_campo_2.Name = "info_rellenar_campo_2"
        Me.info_rellenar_campo_2.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_2.TabIndex = 446
        Me.info_rellenar_campo_2.UseVisualStyleBackColor = False
        '
        'info_rellenar_campo_1
        '
        Me.info_rellenar_campo_1.BackColor = System.Drawing.Color.Transparent
        Me.info_rellenar_campo_1.BackgroundImage = Global.BODEGA.My.Resources.Resources.alerta
        Me.info_rellenar_campo_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.info_rellenar_campo_1.FlatAppearance.BorderSize = 0
        Me.info_rellenar_campo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.info_rellenar_campo_1.Location = New System.Drawing.Point(361, 53)
        Me.info_rellenar_campo_1.Name = "info_rellenar_campo_1"
        Me.info_rellenar_campo_1.Size = New System.Drawing.Size(33, 21)
        Me.info_rellenar_campo_1.TabIndex = 445
        Me.info_rellenar_campo_1.UseVisualStyleBackColor = False
        '
        'Editor_DO_Insertar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 441)
        Me.Controls.Add(Me.info_rellenar_campo_4)
        Me.Controls.Add(Me.info_rellenar_campo_3)
        Me.Controls.Add(Me.info_rellenar_campo_2)
        Me.Controls.Add(Me.info_rellenar_campo_1)
        Me.Controls.Add(Me.Insert_Map_Name)
        Me.Controls.Add(Me.Insert_Logo_Name)
        Me.Controls.Add(Me.Insert_Informacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Insert_ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShowMapDO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShowPhotoDO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.b_SearchPhoto_Map)
        Me.Controls.Add(Me.b_SearchPhoto_DO)
        Me.Controls.Add(Me.b_SaveItem)
        Me.Name = "Editor_DO_Insertar"
        Me.Text = "Editor_DO_Insertar"
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowMapDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_SaveItem As Button
    Friend WithEvents b_SearchPhoto_DO As Button
    Friend WithEvents b_SearchPhoto_Map As Button
    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowMapDO As PictureBox
    Friend WithEvents Insert_ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Insert_Informacion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Insert_Logo_Name As TextBox
    Friend WithEvents Insert_Map_Name As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents info_rellenar_campo_4 As Button
    Friend WithEvents info_rellenar_campo_3 As Button
    Friend WithEvents info_rellenar_campo_2 As Button
    Friend WithEvents info_rellenar_campo_1 As Button
End Class
