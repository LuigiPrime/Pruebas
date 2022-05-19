<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Detalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_Detalle))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Show_ID_Hueco = New System.Windows.Forms.TextBox()
        Me.Panel_General = New System.Windows.Forms.Panel()
        Me.Panel_Photo = New System.Windows.Forms.Panel()
        Me.Panel_Detalle = New System.Windows.Forms.Panel()
        Me.Show_Coleccion = New System.Windows.Forms.TextBox()
        Me.Show_Tipo = New System.Windows.Forms.TextBox()
        Me.Show_year = New System.Windows.Forms.TextBox()
        Me.Show_Maduracion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel_Marca = New System.Windows.Forms.Panel()
        Me.Show_Marca = New System.Windows.Forms.TextBox()
        Me.Show_Denominacion = New System.Windows.Forms.TextBox()
        Me.Panel_DO = New System.Windows.Forms.Panel()
        Me.Panel_Hueco = New System.Windows.Forms.Panel()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_General.SuspendLayout()
        Me.Panel_Photo.SuspendLayout()
        Me.Panel_Detalle.SuspendLayout()
        Me.Panel_Marca.SuspendLayout()
        Me.Panel_DO.SuspendLayout()
        Me.Panel_Hueco.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 22)
        Me.Label1.TabIndex = 399
        Me.Label1.Text = "HUECO NÚMERO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(92, 62)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(162, 300)
        Me.ShowPhotoVino.TabIndex = 407
        Me.ShowPhotoVino.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ShowPhotoVino, "Foto del vino")
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(9, 492)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 51)
        Me.Button1.TabIndex = 424
        Me.ToolTip1.SetToolTip(Me.Button1, "Cerrar ventana")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Help
        Me.ShowPhotoDO.Location = New System.Drawing.Point(38, 35)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(65, 52)
        Me.ShowPhotoDO.TabIndex = 0
        Me.ShowPhotoDO.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ShowPhotoDO, "Pulsar para acceder al detalle de la DO")
        '
        'Show_ID_Hueco
        '
        Me.Show_ID_Hueco.BackColor = System.Drawing.Color.OldLace
        Me.Show_ID_Hueco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Show_ID_Hueco.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_ID_Hueco.Enabled = False
        Me.Show_ID_Hueco.Font = New System.Drawing.Font("Dutch801 XBd BT", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_ID_Hueco.Location = New System.Drawing.Point(46, 50)
        Me.Show_ID_Hueco.Name = "Show_ID_Hueco"
        Me.Show_ID_Hueco.Size = New System.Drawing.Size(75, 45)
        Me.Show_ID_Hueco.TabIndex = 415
        Me.Show_ID_Hueco.Text = "000"
        Me.Show_ID_Hueco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Show_ID_Hueco, "Nº identificación del hueco")
        '
        'Panel_General
        '
        Me.Panel_General.BackColor = System.Drawing.Color.LightGray
        Me.Panel_General.BackgroundImage = Global.BODEGA.My.Resources.Resources.pngwing_fondo_uvas_com
        Me.Panel_General.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_General.Controls.Add(Me.Panel_Photo)
        Me.Panel_General.Controls.Add(Me.Panel_Detalle)
        Me.Panel_General.Controls.Add(Me.Panel_Marca)
        Me.Panel_General.Controls.Add(Me.Button1)
        Me.Panel_General.Controls.Add(Me.Show_Denominacion)
        Me.Panel_General.Controls.Add(Me.Panel_DO)
        Me.Panel_General.Controls.Add(Me.Panel_Hueco)
        Me.Panel_General.Location = New System.Drawing.Point(7, 12)
        Me.Panel_General.Name = "Panel_General"
        Me.Panel_General.Size = New System.Drawing.Size(615, 546)
        Me.Panel_General.TabIndex = 419
        '
        'Panel_Photo
        '
        Me.Panel_Photo.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Photo.BackgroundImage = Global.BODEGA.My.Resources.Resources.kisspng_iphone_samsung_galaxy_computer_icons_smartphone_te_cellphone_5ac2abe3e1dbc1_3790372015227074279251__1_
        Me.Panel_Photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_Photo.Controls.Add(Me.ShowPhotoVino)
        Me.Panel_Photo.Location = New System.Drawing.Point(264, 124)
        Me.Panel_Photo.Name = "Panel_Photo"
        Me.Panel_Photo.Size = New System.Drawing.Size(348, 419)
        Me.Panel_Photo.TabIndex = 427
        '
        'Panel_Detalle
        '
        Me.Panel_Detalle.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Detalle.BackgroundImage = Global.BODEGA.My.Resources.Resources.desfile_de_papel
        Me.Panel_Detalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Detalle.Controls.Add(Me.Show_Coleccion)
        Me.Panel_Detalle.Controls.Add(Me.Show_Tipo)
        Me.Panel_Detalle.Controls.Add(Me.Show_year)
        Me.Panel_Detalle.Controls.Add(Me.Show_Maduracion)
        Me.Panel_Detalle.Controls.Add(Me.Label7)
        Me.Panel_Detalle.Controls.Add(Me.Label6)
        Me.Panel_Detalle.Controls.Add(Me.Label5)
        Me.Panel_Detalle.Controls.Add(Me.Label4)
        Me.Panel_Detalle.Location = New System.Drawing.Point(6, 155)
        Me.Panel_Detalle.Name = "Panel_Detalle"
        Me.Panel_Detalle.Size = New System.Drawing.Size(274, 175)
        Me.Panel_Detalle.TabIndex = 426
        '
        'Show_Coleccion
        '
        Me.Show_Coleccion.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Coleccion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Coleccion.Enabled = False
        Me.Show_Coleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Coleccion.Location = New System.Drawing.Point(115, 91)
        Me.Show_Coleccion.Name = "Show_Coleccion"
        Me.Show_Coleccion.Size = New System.Drawing.Size(118, 20)
        Me.Show_Coleccion.TabIndex = 422
        '
        'Show_Tipo
        '
        Me.Show_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Tipo.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Tipo.Enabled = False
        Me.Show_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Tipo.Location = New System.Drawing.Point(115, 61)
        Me.Show_Tipo.Name = "Show_Tipo"
        Me.Show_Tipo.Size = New System.Drawing.Size(118, 23)
        Me.Show_Tipo.TabIndex = 421
        '
        'Show_year
        '
        Me.Show_year.BackColor = System.Drawing.SystemColors.Info
        Me.Show_year.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_year.Enabled = False
        Me.Show_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_year.Location = New System.Drawing.Point(115, 118)
        Me.Show_year.Name = "Show_year"
        Me.Show_year.Size = New System.Drawing.Size(39, 23)
        Me.Show_year.TabIndex = 420
        Me.Show_year.Text = "0000"
        Me.Show_year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Show_Maduracion
        '
        Me.Show_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Maduracion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Maduracion.Enabled = False
        Me.Show_Maduracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Maduracion.Location = New System.Drawing.Point(115, 31)
        Me.Show_Maduracion.Name = "Show_Maduracion"
        Me.Show_Maduracion.Size = New System.Drawing.Size(118, 23)
        Me.Show_Maduracion.TabIndex = 419
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 418
        Me.Label7.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Año"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Uso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 415
        Me.Label4.Text = "Maduracion"
        '
        'Panel_Marca
        '
        Me.Panel_Marca.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Marca.BackgroundImage = Global.BODEGA.My.Resources.Resources.Daco_986294
        Me.Panel_Marca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Marca.Controls.Add(Me.Show_Marca)
        Me.Panel_Marca.Location = New System.Drawing.Point(195, 10)
        Me.Panel_Marca.Name = "Panel_Marca"
        Me.Panel_Marca.Size = New System.Drawing.Size(410, 115)
        Me.Panel_Marca.TabIndex = 425
        '
        'Show_Marca
        '
        Me.Show_Marca.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Show_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Show_Marca.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Marca.Location = New System.Drawing.Point(44, 50)
        Me.Show_Marca.Name = "Show_Marca"
        Me.Show_Marca.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Show_Marca.Size = New System.Drawing.Size(319, 25)
        Me.Show_Marca.TabIndex = 410
        Me.Show_Marca.Text = "AAAAAAAAAAAAAAAAAAAA"
        Me.Show_Marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Show_Denominacion
        '
        Me.Show_Denominacion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Denominacion.Enabled = False
        Me.Show_Denominacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Denominacion.Location = New System.Drawing.Point(16, 132)
        Me.Show_Denominacion.Name = "Show_Denominacion"
        Me.Show_Denominacion.Size = New System.Drawing.Size(135, 20)
        Me.Show_Denominacion.TabIndex = 422
        '
        'Panel_DO
        '
        Me.Panel_DO.BackColor = System.Drawing.Color.Transparent
        Me.Panel_DO.BackgroundImage = Global.BODEGA.My.Resources.Resources.barril_de_vino
        Me.Panel_DO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_DO.Controls.Add(Me.ShowPhotoDO)
        Me.Panel_DO.Location = New System.Drawing.Point(10, 10)
        Me.Panel_DO.Name = "Panel_DO"
        Me.Panel_DO.Size = New System.Drawing.Size(149, 122)
        Me.Panel_DO.TabIndex = 420
        '
        'Panel_Hueco
        '
        Me.Panel_Hueco.BackColor = System.Drawing.Color.Transparent
        Me.Panel_Hueco.BackgroundImage = Global.BODEGA.My.Resources.Resources.pngwing_cartes_com
        Me.Panel_Hueco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel_Hueco.Controls.Add(Me.Show_ID_Hueco)
        Me.Panel_Hueco.Location = New System.Drawing.Point(10, 336)
        Me.Panel_Hueco.Name = "Panel_Hueco"
        Me.Panel_Hueco.Size = New System.Drawing.Size(170, 150)
        Me.Panel_Hueco.TabIndex = 419
        '
        'Info_Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Wheat
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 567)
        Me.Controls.Add(Me.Panel_General)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(250, 250)
        Me.MaximizeBox = False
        Me.Name = "Info_Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFORMACION SOBRE HUECO SELECCIONADO"
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_General.ResumeLayout(False)
        Me.Panel_General.PerformLayout()
        Me.Panel_Photo.ResumeLayout(False)
        Me.Panel_Detalle.ResumeLayout(False)
        Me.Panel_Detalle.PerformLayout()
        Me.Panel_Marca.ResumeLayout(False)
        Me.Panel_Marca.PerformLayout()
        Me.Panel_DO.ResumeLayout(False)
        Me.Panel_Hueco.ResumeLayout(False)
        Me.Panel_Hueco.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ShowPhotoVino As PictureBox
    Public WithEvents Show_ID_Hueco As TextBox
    Friend WithEvents Show_Marca As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel_General As Panel
    Friend WithEvents Panel_Hueco As Panel
    Friend WithEvents Panel_DO As Panel
    Friend WithEvents Show_Denominacion As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel_Marca As Panel
    Friend WithEvents Panel_Detalle As Panel
    Friend WithEvents Show_Coleccion As TextBox
    Friend WithEvents Show_Tipo As TextBox
    Friend WithEvents Show_year As TextBox
    Friend WithEvents Show_Maduracion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel_Photo As Panel
End Class
