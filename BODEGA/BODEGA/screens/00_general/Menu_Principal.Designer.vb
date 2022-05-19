<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Principal))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.b_ShowAuxiliar = New System.Windows.Forms.Button()
        Me.b_ShowDespensa = New System.Windows.Forms.Button()
        Me.b_ShowLenera = New System.Windows.Forms.Button()
        Me.b_Ayuda = New System.Windows.Forms.Button()
        Me.b_editor = New System.Windows.Forms.Button()
        Me.b_showTotal = New System.Windows.Forms.Button()
        Me.b_showCatalog = New System.Windows.Forms.Button()
        Me.b_ShowFrontal = New System.Windows.Forms.Button()
        Me.Cerrar_Aplicacion = New System.Windows.Forms.Button()
        Me.p_ShowLenera = New System.Windows.Forms.PictureBox()
        Me.p_ShowDespensa = New System.Windows.Forms.PictureBox()
        Me.p_ShowAuxiliar = New System.Windows.Forms.PictureBox()
        Me.p_ShowFrontal = New System.Windows.Forms.PictureBox()
        Me.b_Debug = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.l_cabecera = New System.Windows.Forms.Label()
        CType(Me.p_ShowLenera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_ShowDespensa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_ShowAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p_ShowFrontal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_ShowAuxiliar
        '
        Me.b_ShowAuxiliar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ShowAuxiliar.Location = New System.Drawing.Point(136, 32)
        Me.b_ShowAuxiliar.Name = "b_ShowAuxiliar"
        Me.b_ShowAuxiliar.Size = New System.Drawing.Size(90, 65)
        Me.b_ShowAuxiliar.TabIndex = 22
        Me.b_ShowAuxiliar.Text = "AUXILIAR"
        Me.b_ShowAuxiliar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_ShowAuxiliar, "Pulsar para activar pantalla auxiliar principal")
        Me.b_ShowAuxiliar.UseVisualStyleBackColor = True
        '
        'b_ShowDespensa
        '
        Me.b_ShowDespensa.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ShowDespensa.Location = New System.Drawing.Point(244, 32)
        Me.b_ShowDespensa.Name = "b_ShowDespensa"
        Me.b_ShowDespensa.Size = New System.Drawing.Size(90, 65)
        Me.b_ShowDespensa.TabIndex = 23
        Me.b_ShowDespensa.Text = "DESPENSA"
        Me.b_ShowDespensa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_ShowDespensa, "Pulsar para activar pantalla Despensa")
        Me.b_ShowDespensa.UseVisualStyleBackColor = True
        '
        'b_ShowLenera
        '
        Me.b_ShowLenera.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ShowLenera.Location = New System.Drawing.Point(352, 32)
        Me.b_ShowLenera.Name = "b_ShowLenera"
        Me.b_ShowLenera.Size = New System.Drawing.Size(90, 65)
        Me.b_ShowLenera.TabIndex = 24
        Me.b_ShowLenera.Text = "LEÑERA"
        Me.b_ShowLenera.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_ShowLenera, "Pulsar para activar pantalla Leñera")
        Me.b_ShowLenera.UseVisualStyleBackColor = True
        '
        'b_Ayuda
        '
        Me.b_Ayuda.BackgroundImage = Global.BODEGA.My.Resources.Resources.info
        Me.b_Ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Ayuda.Location = New System.Drawing.Point(438, 243)
        Me.b_Ayuda.Name = "b_Ayuda"
        Me.b_Ayuda.Size = New System.Drawing.Size(40, 41)
        Me.b_Ayuda.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.b_Ayuda, "Pulsar para abrir archivo de ayuda")
        Me.b_Ayuda.UseVisualStyleBackColor = True
        '
        'b_editor
        '
        Me.b_editor.BackgroundImage = Global.BODEGA.My.Resources.Resources.engranaje
        Me.b_editor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_editor.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold)
        Me.b_editor.Location = New System.Drawing.Point(321, 3)
        Me.b_editor.Name = "b_editor"
        Me.b_editor.Size = New System.Drawing.Size(68, 65)
        Me.b_editor.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.b_editor, "Ir a modo edicion de datos")
        Me.b_editor.UseVisualStyleBackColor = True
        Me.b_editor.Visible = False
        '
        'b_showTotal
        '
        Me.b_showTotal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.b_showTotal.BackgroundImage = Global.BODEGA.My.Resources.Resources.kisspng_calculator_numeric_keypad_vector_calculator_5a6d44a8b13912_8514482915171104407259
        Me.b_showTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_showTotal.Location = New System.Drawing.Point(83, 3)
        Me.b_showTotal.Name = "b_showTotal"
        Me.b_showTotal.Size = New System.Drawing.Size(68, 65)
        Me.b_showTotal.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.b_showTotal, "Pulsar para entrar en pantalla de contabilizaciones")
        Me.b_showTotal.UseVisualStyleBackColor = False
        '
        'b_showCatalog
        '
        Me.b_showCatalog.BackgroundImage = Global.BODEGA.My.Resources.Resources.catalogo_vino
        Me.b_showCatalog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_showCatalog.Location = New System.Drawing.Point(202, 3)
        Me.b_showCatalog.Name = "b_showCatalog"
        Me.b_showCatalog.Size = New System.Drawing.Size(68, 65)
        Me.b_showCatalog.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.b_showCatalog, "Pulsar para entrar en pantalla de visualizacion catalogo de vinos")
        Me.b_showCatalog.UseVisualStyleBackColor = True
        '
        'b_ShowFrontal
        '
        Me.b_ShowFrontal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_ShowFrontal.Location = New System.Drawing.Point(28, 32)
        Me.b_ShowFrontal.Name = "b_ShowFrontal"
        Me.b_ShowFrontal.Size = New System.Drawing.Size(90, 65)
        Me.b_ShowFrontal.TabIndex = 21
        Me.b_ShowFrontal.Text = "FRONTAL"
        Me.b_ShowFrontal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_ShowFrontal, "Pulsar para activar pantalla frontal principal")
        Me.b_ShowFrontal.UseVisualStyleBackColor = True
        '
        'Cerrar_Aplicacion
        '
        Me.Cerrar_Aplicacion.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar_Aplicacion.BackgroundImage = CType(resources.GetObject("Cerrar_Aplicacion.BackgroundImage"), System.Drawing.Image)
        Me.Cerrar_Aplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar_Aplicacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cerrar_Aplicacion.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.Cerrar_Aplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Cerrar_Aplicacion.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.Cerrar_Aplicacion, "Para cerrar la aplicación")
        Me.Cerrar_Aplicacion.Location = New System.Drawing.Point(225, 243)
        Me.Cerrar_Aplicacion.Margin = New System.Windows.Forms.Padding(5)
        Me.Cerrar_Aplicacion.Name = "Cerrar_Aplicacion"
        Me.HelpProvider1.SetShowHelp(Me.Cerrar_Aplicacion, True)
        Me.Cerrar_Aplicacion.Size = New System.Drawing.Size(40, 41)
        Me.Cerrar_Aplicacion.TabIndex = 6
        Me.Cerrar_Aplicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Cerrar_Aplicacion, "Pulsar para cerrar")
        Me.Cerrar_Aplicacion.UseVisualStyleBackColor = False
        '
        'p_ShowLenera
        '
        Me.p_ShowLenera.BackgroundImage = Global.BODEGA.My.Resources.Resources.bodega_huecos
        Me.p_ShowLenera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_ShowLenera.Location = New System.Drawing.Point(377, 41)
        Me.p_ShowLenera.Name = "p_ShowLenera"
        Me.p_ShowLenera.Size = New System.Drawing.Size(40, 35)
        Me.p_ShowLenera.TabIndex = 26
        Me.p_ShowLenera.TabStop = False
        Me.ToolTip1.SetToolTip(Me.p_ShowLenera, "Pulsar para activar pantalla Leñera")
        '
        'p_ShowDespensa
        '
        Me.p_ShowDespensa.BackgroundImage = Global.BODEGA.My.Resources.Resources.bodega_huecos
        Me.p_ShowDespensa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_ShowDespensa.Location = New System.Drawing.Point(269, 41)
        Me.p_ShowDespensa.Name = "p_ShowDespensa"
        Me.p_ShowDespensa.Size = New System.Drawing.Size(40, 35)
        Me.p_ShowDespensa.TabIndex = 27
        Me.p_ShowDespensa.TabStop = False
        Me.ToolTip1.SetToolTip(Me.p_ShowDespensa, "Pulsar para activar pantalla Despensa")
        '
        'p_ShowAuxiliar
        '
        Me.p_ShowAuxiliar.BackgroundImage = Global.BODEGA.My.Resources.Resources.bodega_huecos
        Me.p_ShowAuxiliar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_ShowAuxiliar.Location = New System.Drawing.Point(161, 41)
        Me.p_ShowAuxiliar.Name = "p_ShowAuxiliar"
        Me.p_ShowAuxiliar.Size = New System.Drawing.Size(40, 35)
        Me.p_ShowAuxiliar.TabIndex = 28
        Me.p_ShowAuxiliar.TabStop = False
        Me.ToolTip1.SetToolTip(Me.p_ShowAuxiliar, "Pulsar para activar pantalla auxiliar principal")
        '
        'p_ShowFrontal
        '
        Me.p_ShowFrontal.BackgroundImage = Global.BODEGA.My.Resources.Resources.bodega_huecos
        Me.p_ShowFrontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.p_ShowFrontal.Location = New System.Drawing.Point(53, 41)
        Me.p_ShowFrontal.Name = "p_ShowFrontal"
        Me.p_ShowFrontal.Size = New System.Drawing.Size(40, 35)
        Me.p_ShowFrontal.TabIndex = 29
        Me.p_ShowFrontal.TabStop = False
        Me.ToolTip1.SetToolTip(Me.p_ShowFrontal, "Pulsar para activar pantalla frontal principal")
        '
        'b_Debug
        '
        Me.b_Debug.BackgroundImage = Global.BODEGA.My.Resources.Resources.base_de_datos
        Me.b_Debug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_Debug.Cursor = System.Windows.Forms.Cursors.Help
        Me.b_Debug.Location = New System.Drawing.Point(12, 243)
        Me.b_Debug.Name = "b_Debug"
        Me.b_Debug.Size = New System.Drawing.Size(40, 41)
        Me.b_Debug.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.b_Debug, "Para abrir informacion de enrutamiento")
        Me.b_Debug.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Panel1.Controls.Add(Me.p_ShowFrontal)
        Me.Panel1.Controls.Add(Me.p_ShowAuxiliar)
        Me.Panel1.Controls.Add(Me.p_ShowDespensa)
        Me.Panel1.Controls.Add(Me.p_ShowLenera)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.b_ShowLenera)
        Me.Panel1.Controls.Add(Me.b_ShowDespensa)
        Me.Panel1.Controls.Add(Me.b_ShowAuxiliar)
        Me.Panel1.Controls.Add(Me.b_ShowFrontal)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 106)
        Me.Panel1.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "CERCEDA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.b_editor)
        Me.Panel2.Controls.Add(Me.b_showTotal)
        Me.Panel2.Controls.Add(Me.b_showCatalog)
        Me.Panel2.Location = New System.Drawing.Point(12, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(466, 70)
        Me.Panel2.TabIndex = 29
        '
        'l_cabecera
        '
        Me.l_cabecera.AutoSize = True
        Me.l_cabecera.Location = New System.Drawing.Point(171, 9)
        Me.l_cabecera.Name = "l_cabecera"
        Me.l_cabecera.Size = New System.Drawing.Size(95, 13)
        Me.l_cabecera.TabIndex = 31
        Me.l_cabecera.Text = "ABCDEFGHIJKLM"
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(498, 288)
        Me.Controls.Add(Me.b_Ayuda)
        Me.Controls.Add(Me.l_cabecera)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.b_Debug)
        Me.Controls.Add(Me.Cerrar_Aplicacion)
        Me.DoubleBuffered = True
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL"
        CType(Me.p_ShowLenera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_ShowDespensa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_ShowAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p_ShowFrontal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cerrar_Aplicacion As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents b_Debug As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents l_cabecera As Label
    Friend WithEvents b_Ayuda As Button
    Friend WithEvents b_showCatalog As Button
    Friend WithEvents b_showTotal As Button
    Friend WithEvents b_ShowLenera As Button
    Friend WithEvents b_ShowDespensa As Button
    Friend WithEvents b_ShowAuxiliar As Button
    Friend WithEvents b_ShowFrontal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents b_editor As Button
    Friend WithEvents p_ShowLenera As PictureBox
    Friend WithEvents p_ShowFrontal As PictureBox
    Friend WithEvents p_ShowAuxiliar As PictureBox
    Friend WithEvents p_ShowDespensa As PictureBox
End Class
