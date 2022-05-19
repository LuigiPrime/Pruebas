<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Detalle_DO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_Detalle_DO))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShowPhoto_map = New System.Windows.Forms.PictureBox()
        Me.ShowPhotoDO = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel_mapa = New System.Windows.Forms.Panel()
        Me.Panel_logo = New System.Windows.Forms.Panel()
        Me.Show_Denominacion = New System.Windows.Forms.TextBox()
        CType(Me.ShowPhoto_map, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel_mapa.SuspendLayout()
        Me.Panel_logo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShowPhoto_map
        '
        Me.ShowPhoto_map.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ShowPhoto_map.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhoto_map.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhoto_map.Location = New System.Drawing.Point(9, 9)
        Me.ShowPhoto_map.Name = "ShowPhoto_map"
        Me.ShowPhoto_map.Size = New System.Drawing.Size(449, 335)
        Me.ShowPhoto_map.TabIndex = 420
        Me.ShowPhoto_map.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ShowPhoto_map, "Foto de la ubicación de la DO")
        '
        'ShowPhotoDO
        '
        Me.ShowPhotoDO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPhotoDO.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ShowPhotoDO.Location = New System.Drawing.Point(31, 26)
        Me.ShowPhotoDO.Name = "ShowPhotoDO"
        Me.ShowPhotoDO.Size = New System.Drawing.Size(158, 151)
        Me.ShowPhotoDO.TabIndex = 417
        Me.ShowPhotoDO.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ShowPhotoDO, "Logo de la Denominación")
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.BODEGA.My.Resources.Resources.regreso
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(12, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 60)
        Me.Button1.TabIndex = 425
        Me.ToolTip1.SetToolTip(Me.Button1, "Cerrar ventana")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.BackgroundImage = Global.BODEGA.My.Resources.Resources.pngwing_villa
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.Panel_mapa)
        Me.Panel1.Controls.Add(Me.Panel_logo)
        Me.Panel1.Controls.Add(Me.Show_Denominacion)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(735, 489)
        Me.Panel1.TabIndex = 429
        '
        'Panel_mapa
        '
        Me.Panel_mapa.BackColor = System.Drawing.Color.Transparent
        Me.Panel_mapa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel_mapa.Controls.Add(Me.ShowPhoto_map)
        Me.Panel_mapa.Location = New System.Drawing.Point(240, 64)
        Me.Panel_mapa.Name = "Panel_mapa"
        Me.Panel_mapa.Size = New System.Drawing.Size(473, 360)
        Me.Panel_mapa.TabIndex = 430
        '
        'Panel_logo
        '
        Me.Panel_logo.BackColor = System.Drawing.Color.Transparent
        Me.Panel_logo.BackgroundImage = Global.BODEGA.My.Resources.Resources.desfile_de_papel
        Me.Panel_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_logo.Controls.Add(Me.ShowPhotoDO)
        Me.Panel_logo.Location = New System.Drawing.Point(12, 64)
        Me.Panel_logo.Name = "Panel_logo"
        Me.Panel_logo.Size = New System.Drawing.Size(222, 208)
        Me.Panel_logo.TabIndex = 429
        '
        'Show_Denominacion
        '
        Me.Show_Denominacion.Cursor = System.Windows.Forms.Cursors.Help
        Me.Show_Denominacion.Enabled = False
        Me.Show_Denominacion.Font = New System.Drawing.Font("Algerian", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Show_Denominacion.Location = New System.Drawing.Point(12, 15)
        Me.Show_Denominacion.Name = "Show_Denominacion"
        Me.Show_Denominacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Show_Denominacion.Size = New System.Drawing.Size(701, 43)
        Me.Show_Denominacion.TabIndex = 428
        Me.Show_Denominacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Info_Detalle_DO
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(757, 510)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Info_Detalle_DO"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de la denominacion de origen"
        CType(Me.ShowPhoto_map, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShowPhotoDO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_mapa.ResumeLayout(False)
        Me.Panel_logo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShowPhoto_map As PictureBox
    Friend WithEvents ShowPhotoDO As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Show_Denominacion As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel_logo As Panel
    Friend WithEvents Panel_mapa As Panel
End Class
