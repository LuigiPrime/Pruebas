<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Folleto_Vinos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Folleto_Vinos))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_abrirListado = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.b_Up_Folleto = New System.Windows.Forms.Button()
        Me.Show_NumBotellas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.b_Down_Folleto = New System.Windows.Forms.Button()
        Me.busqueda_id_vino = New System.Windows.Forms.TextBox()
        Me.Panel_Listado = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.busqueda_marca = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_Catalogo = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Show_ID_Vino = New System.Windows.Forms.TextBox()
        Me.Show_Maduracion = New System.Windows.Forms.TextBox()
        Me.Show_Denominacion = New System.Windows.Forms.TextBox()
        Me.Show_Tipo = New System.Windows.Forms.TextBox()
        Me.Show_year = New System.Windows.Forms.TextBox()
        Me.Show_Marca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShowPhotoVino = New System.Windows.Forms.PictureBox()
        Me.b_CerrarListado = New System.Windows.Forms.Button()
        Me.Panel_Listado.SuspendLayout()
        Me.Panel_Catalogo.SuspendLayout()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'b_abrirListado
        '
        Me.b_abrirListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_abrirListado.Location = New System.Drawing.Point(783, 513)
        Me.b_abrirListado.Name = "b_abrirListado"
        Me.b_abrirListado.Size = New System.Drawing.Size(112, 40)
        Me.b_abrirListado.TabIndex = 437
        Me.b_abrirListado.Text = "ABRIR LISTADO"
        Me.ToolTip1.SetToolTip(Me.b_abrirListado, "Activar lista desplegable")
        Me.b_abrirListado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.BODEGA.My.Resources.Resources.info
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Help
        Me.Button2.Location = New System.Drawing.Point(137, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 24)
        Me.Button2.TabIndex = 443
        Me.ToolTip1.SetToolTip(Me.Button2, "informacion sobre listado IDs por vino")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'b_Up_Folleto
        '
        Me.b_Up_Folleto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Up_Folleto.Location = New System.Drawing.Point(716, 222)
        Me.b_Up_Folleto.Name = "b_Up_Folleto"
        Me.b_Up_Folleto.Size = New System.Drawing.Size(36, 50)
        Me.b_Up_Folleto.TabIndex = 443
        Me.b_Up_Folleto.Text = ">"
        Me.ToolTip1.SetToolTip(Me.b_Up_Folleto, "Avanzar siguiente vino")
        Me.b_Up_Folleto.UseVisualStyleBackColor = True
        '
        'Show_NumBotellas
        '
        Me.Show_NumBotellas.BackColor = System.Drawing.SystemColors.Info
        Me.Show_NumBotellas.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_NumBotellas.Enabled = False
        Me.Show_NumBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_NumBotellas.Location = New System.Drawing.Point(182, 425)
        Me.Show_NumBotellas.Name = "Show_NumBotellas"
        Me.Show_NumBotellas.Size = New System.Drawing.Size(128, 23)
        Me.Show_NumBotellas.TabIndex = 441
        Me.ToolTip1.SetToolTip(Me.Show_NumBotellas, "numero de botellas contabilizadas")
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.BODEGA.My.Resources.Resources.marcador_de_posicion
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(316, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 39)
        Me.Button1.TabIndex = 440
        Me.ToolTip1.SetToolTip(Me.Button1, "Visualizar detalle de localizacion")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'b_Down_Folleto
        '
        Me.b_Down_Folleto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_Down_Folleto.Location = New System.Drawing.Point(3, 222)
        Me.b_Down_Folleto.Name = "b_Down_Folleto"
        Me.b_Down_Folleto.Size = New System.Drawing.Size(36, 50)
        Me.b_Down_Folleto.TabIndex = 1
        Me.b_Down_Folleto.Text = "<"
        Me.ToolTip1.SetToolTip(Me.b_Down_Folleto, "Retroceder vino")
        Me.b_Down_Folleto.UseVisualStyleBackColor = True
        '
        'busqueda_id_vino
        '
        Me.busqueda_id_vino.AcceptsReturn = True
        Me.busqueda_id_vino.AcceptsTab = True
        Me.busqueda_id_vino.Cursor = System.Windows.Forms.Cursors.Help
        Me.busqueda_id_vino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.busqueda_id_vino.Location = New System.Drawing.Point(35, 81)
        Me.busqueda_id_vino.Name = "busqueda_id_vino"
        Me.busqueda_id_vino.Size = New System.Drawing.Size(153, 23)
        Me.busqueda_id_vino.TabIndex = 432
        '
        'Panel_Listado
        '
        Me.Panel_Listado.BackColor = System.Drawing.Color.DarkRed
        Me.Panel_Listado.BackgroundImage = Global.BODEGA.My.Resources.Resources.desfile_de_papel
        Me.Panel_Listado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Listado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Listado.Controls.Add(Me.Button2)
        Me.Panel_Listado.Controls.Add(Me.ListBox1)
        Me.Panel_Listado.Controls.Add(Me.busqueda_marca)
        Me.Panel_Listado.Controls.Add(Me.Label9)
        Me.Panel_Listado.Controls.Add(Me.Label4)
        Me.Panel_Listado.Controls.Add(Me.Label3)
        Me.Panel_Listado.Controls.Add(Me.busqueda_id_vino)
        Me.Panel_Listado.Location = New System.Drawing.Point(783, 6)
        Me.Panel_Listado.Name = "Panel_Listado"
        Me.Panel_Listado.Size = New System.Drawing.Size(238, 501)
        Me.Panel_Listado.TabIndex = 436
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Info
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Help
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(35, 156)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(153, 286)
        Me.ListBox1.TabIndex = 442
        '
        'busqueda_marca
        '
        Me.busqueda_marca.Location = New System.Drawing.Point(35, 130)
        Me.busqueda_marca.Name = "busqueda_marca"
        Me.busqueda_marca.Size = New System.Drawing.Size(153, 20)
        Me.busqueda_marca.TabIndex = 441
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(32, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 440
        Me.Label9.Text = "Por Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(36, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 439
        Me.Label4.Text = "Por número ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 438
        Me.Label3.Text = "FILTROS BUSQUEDA"
        '
        'Panel_Catalogo
        '
        Me.Panel_Catalogo.BackColor = System.Drawing.Color.Maroon
        Me.Panel_Catalogo.BackgroundImage = Global.BODEGA.My.Resources.Resources.pngwing_pergamino_com
        Me.Panel_Catalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Catalogo.Controls.Add(Me.Label8)
        Me.Panel_Catalogo.Controls.Add(Me.Label6)
        Me.Panel_Catalogo.Controls.Add(Me.b_Up_Folleto)
        Me.Panel_Catalogo.Controls.Add(Me.Label5)
        Me.Panel_Catalogo.Controls.Add(Me.Show_NumBotellas)
        Me.Panel_Catalogo.Controls.Add(Me.Button1)
        Me.Panel_Catalogo.Controls.Add(Me.ShowPhotoDO)
        Me.Panel_Catalogo.Controls.Add(Me.Show_ID_Vino)
        Me.Panel_Catalogo.Controls.Add(Me.Show_Maduracion)
        Me.Panel_Catalogo.Controls.Add(Me.Show_Denominacion)
        Me.Panel_Catalogo.Controls.Add(Me.Show_Tipo)
        Me.Panel_Catalogo.Controls.Add(Me.Show_year)
        Me.Panel_Catalogo.Controls.Add(Me.Show_Marca)
        Me.Panel_Catalogo.Controls.Add(Me.Label7)
        Me.Panel_Catalogo.Controls.Add(Me.Label2)
        Me.Panel_Catalogo.Controls.Add(Me.Label1)
        Me.Panel_Catalogo.Controls.Add(Me.ShowPhotoVino)
        Me.Panel_Catalogo.Controls.Add(Me.b_Down_Folleto)
        Me.Panel_Catalogo.Location = New System.Drawing.Point(12, 6)
        Me.Panel_Catalogo.Name = "Panel_Catalogo"
        Me.Panel_Catalogo.Size = New System.Drawing.Size(765, 553)
        Me.Panel_Catalogo.TabIndex = 443
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 445
        Me.Label8.Text = "Codigo de ID Vino"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(67, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 26)
        Me.Label6.TabIndex = 444
        Me.Label6.Text = "Denominacion " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Origen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(67, 430)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 442
        Me.Label5.Text = "Nº Botellas "
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoDO.Location = New System.Drawing.Point(185, 267)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(123, 130)
        Me.ShowPhotoDO.TabIndex = 438
        Me.ShowPhotoDO.TabStop = False
        '
        'Show_ID_Vino
        '
        Me.Show_ID_Vino.BackColor = System.Drawing.SystemColors.Info
        Me.Show_ID_Vino.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_ID_Vino.Enabled = False
        Me.Show_ID_Vino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_ID_Vino.Location = New System.Drawing.Point(182, 110)
        Me.Show_ID_Vino.Name = "Show_ID_Vino"
        Me.Show_ID_Vino.Size = New System.Drawing.Size(128, 23)
        Me.Show_ID_Vino.TabIndex = 430
        Me.Show_ID_Vino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Show_Maduracion
        '
        Me.Show_Maduracion.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Maduracion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Maduracion.Enabled = False
        Me.Show_Maduracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Maduracion.Location = New System.Drawing.Point(182, 148)
        Me.Show_Maduracion.Name = "Show_Maduracion"
        Me.Show_Maduracion.Size = New System.Drawing.Size(128, 23)
        Me.Show_Maduracion.TabIndex = 429
        '
        'Show_Denominacion
        '
        Me.Show_Denominacion.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Denominacion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Denominacion.Enabled = False
        Me.Show_Denominacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Denominacion.Location = New System.Drawing.Point(182, 238)
        Me.Show_Denominacion.Name = "Show_Denominacion"
        Me.Show_Denominacion.Size = New System.Drawing.Size(128, 23)
        Me.Show_Denominacion.TabIndex = 428
        Me.Show_Denominacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Show_Tipo
        '
        Me.Show_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Tipo.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Tipo.Enabled = False
        Me.Show_Tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Tipo.Location = New System.Drawing.Point(182, 206)
        Me.Show_Tipo.Name = "Show_Tipo"
        Me.Show_Tipo.Size = New System.Drawing.Size(128, 23)
        Me.Show_Tipo.TabIndex = 426
        '
        'Show_year
        '
        Me.Show_year.BackColor = System.Drawing.SystemColors.Info
        Me.Show_year.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_year.Enabled = False
        Me.Show_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_year.Location = New System.Drawing.Point(182, 177)
        Me.Show_year.Name = "Show_year"
        Me.Show_year.Size = New System.Drawing.Size(128, 23)
        Me.Show_year.TabIndex = 425
        '
        'Show_Marca
        '
        Me.Show_Marca.BackColor = System.Drawing.SystemColors.Info
        Me.Show_Marca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Show_Marca.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Marca.Enabled = False
        Me.Show_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Marca.Location = New System.Drawing.Point(56, 66)
        Me.Show_Marca.Name = "Show_Marca"
        Me.Show_Marca.Size = New System.Drawing.Size(652, 28)
        Me.Show_Marca.TabIndex = 424
        Me.Show_Marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 421
        Me.Label7.Text = "Tipo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 420
        Me.Label2.Text = "Año"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "Maduracion"
        '
        'ShowPhotoVino
        '
        Me.ShowPhotoVino.BackColor = System.Drawing.Color.Transparent
        Me.ShowPhotoVino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoVino.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoVino.Location = New System.Drawing.Point(395, 147)
        Me.ShowPhotoVino.Name = "ShowPhotoVino"
        Me.ShowPhotoVino.Size = New System.Drawing.Size(304, 296)
        Me.ShowPhotoVino.TabIndex = 423
        Me.ShowPhotoVino.TabStop = False
        '
        'b_CerrarListado
        '
        Me.b_CerrarListado.Location = New System.Drawing.Point(909, 513)
        Me.b_CerrarListado.Name = "b_CerrarListado"
        Me.b_CerrarListado.Size = New System.Drawing.Size(112, 40)
        Me.b_CerrarListado.TabIndex = 444
        Me.b_CerrarListado.Text = "CERRAR LISTADO"
        Me.b_CerrarListado.UseVisualStyleBackColor = True
        '
        'Folleto_Vinos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1027, 571)
        Me.Controls.Add(Me.b_CerrarListado)
        Me.Controls.Add(Me.b_abrirListado)
        Me.Controls.Add(Me.Panel_Listado)
        Me.Controls.Add(Me.Panel_Catalogo)
        Me.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Folleto_Vinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO VINOS REGISTRADOS"
        Me.Panel_Listado.ResumeLayout(False)
        Me.Panel_Listado.PerformLayout()
        Me.Panel_Catalogo.ResumeLayout(False)
        Me.Panel_Catalogo.PerformLayout()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoVino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents busqueda_id_vino As TextBox
    Friend WithEvents Panel_Listado As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents busqueda_marca As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents b_abrirListado As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents b_Down_Folleto As Button
    Friend WithEvents ShowPhotoVino As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Show_Marca As TextBox
    Friend WithEvents Show_year As TextBox
    Friend WithEvents Show_Tipo As TextBox
    Friend WithEvents Show_Denominacion As TextBox
    Friend WithEvents Show_Maduracion As TextBox
    Friend WithEvents Show_ID_Vino As TextBox
    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Show_NumBotellas As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_Catalogo As Panel
    Friend WithEvents b_Up_Folleto As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents b_CerrarListado As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
