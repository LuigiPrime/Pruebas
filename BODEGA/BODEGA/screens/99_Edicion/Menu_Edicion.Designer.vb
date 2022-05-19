<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Edicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Edicion))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.b_Ayuda = New System.Windows.Forms.Button()
        Me.b_EditorVinos = New System.Windows.Forms.Button()
        Me.b_EditorDO = New System.Windows.Forms.Button()
        Me.b_EditorZonas = New System.Windows.Forms.Button()
        Me.b_EditorHuecos = New System.Windows.Forms.Button()
        Me.b_Reinicio = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.b_Ayuda)
        Me.Panel1.Controls.Add(Me.b_EditorVinos)
        Me.Panel1.Controls.Add(Me.b_EditorDO)
        Me.Panel1.Controls.Add(Me.b_EditorZonas)
        Me.Panel1.Controls.Add(Me.b_EditorHuecos)
        Me.Panel1.Controls.Add(Me.b_Reinicio)
        Me.Panel1.Location = New System.Drawing.Point(8, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 215)
        Me.Panel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "VINOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "HUECOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(278, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ZONAS"
        '
        'b_Ayuda
        '
        Me.b_Ayuda.BackgroundImage = Global.BODEGA.My.Resources.Resources.info
        Me.b_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Ayuda.Location = New System.Drawing.Point(16, 173)
        Me.b_Ayuda.Name = "b_Ayuda"
        Me.b_Ayuda.Size = New System.Drawing.Size(34, 34)
        Me.b_Ayuda.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.b_Ayuda, "Pulsar para actualizar datos")
        Me.b_Ayuda.UseVisualStyleBackColor = True
        '
        'b_EditorVinos
        '
        Me.b_EditorVinos.BackColor = System.Drawing.Color.Transparent
        Me.b_EditorVinos.BackgroundImage = Global.BODEGA.My.Resources.Resources.Icono_vinos_1
        Me.b_EditorVinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_EditorVinos.Location = New System.Drawing.Point(16, 33)
        Me.b_EditorVinos.Name = "b_EditorVinos"
        Me.b_EditorVinos.Size = New System.Drawing.Size(76, 78)
        Me.b_EditorVinos.TabIndex = 7
        Me.b_EditorVinos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.b_EditorVinos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ToolTip1.SetToolTip(Me.b_EditorVinos, "Pulsar para entrar al editor de Vinos")
        Me.b_EditorVinos.UseVisualStyleBackColor = False
        '
        'b_EditorDO
        '
        Me.b_EditorDO.BackgroundImage = Global.BODEGA.My.Resources.Resources.Logo_pdo_es
        Me.b_EditorDO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_EditorDO.Location = New System.Drawing.Point(252, 33)
        Me.b_EditorDO.Name = "b_EditorDO"
        Me.b_EditorDO.Size = New System.Drawing.Size(76, 78)
        Me.b_EditorDO.TabIndex = 6
        Me.b_EditorDO.UseVisualStyleBackColor = True
        '
        'b_EditorZonas
        '
        Me.b_EditorZonas.BackgroundImage = Global.BODEGA.My.Resources.Resources.zonas_almacenamiento
        Me.b_EditorZonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_EditorZonas.Location = New System.Drawing.Point(370, 33)
        Me.b_EditorZonas.Name = "b_EditorZonas"
        Me.b_EditorZonas.Size = New System.Drawing.Size(76, 78)
        Me.b_EditorZonas.TabIndex = 5
        Me.b_EditorZonas.UseVisualStyleBackColor = True
        '
        'b_EditorHuecos
        '
        Me.b_EditorHuecos.BackgroundImage = Global.BODEGA.My.Resources.Resources.bodega_huecos
        Me.b_EditorHuecos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_EditorHuecos.Location = New System.Drawing.Point(134, 33)
        Me.b_EditorHuecos.Name = "b_EditorHuecos"
        Me.b_EditorHuecos.Size = New System.Drawing.Size(76, 78)
        Me.b_EditorHuecos.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.b_EditorHuecos, "Pulsar para entrar a la asignacion de vinos a los huecos")
        Me.b_EditorHuecos.UseVisualStyleBackColor = True
        '
        'b_Reinicio
        '
        Me.b_Reinicio.BackgroundImage = Global.BODEGA.My.Resources.Resources.reinicio
        Me.b_Reinicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Reinicio.Location = New System.Drawing.Point(394, 152)
        Me.b_Reinicio.Name = "b_Reinicio"
        Me.b_Reinicio.Size = New System.Drawing.Size(52, 55)
        Me.b_Reinicio.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.b_Reinicio, "Pulsar para actualizar datos")
        Me.b_Reinicio.UseVisualStyleBackColor = True
        '
        'Menu_Edicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(486, 233)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu_Edicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU EDICIÓN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents b_EditorHuecos As Button
    Friend WithEvents b_EditorZonas As Button
    Friend WithEvents b_EditorDO As Button
    Friend WithEvents b_EditorVinos As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents b_Ayuda As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_Reinicio As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
