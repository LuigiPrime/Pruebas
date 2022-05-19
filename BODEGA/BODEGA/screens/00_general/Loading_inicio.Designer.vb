<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loading_inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading_inicio))
        Me.Porcentaje = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.boton_Inicio = New System.Windows.Forms.Button()
        Me.boton_modo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.b_Admin = New System.Windows.Forms.Button()
        Me.b_Visualizacion = New System.Windows.Forms.Button()
        Me.b_end = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Porcentaje
        '
        resources.ApplyResources(Me.Porcentaje, "Porcentaje")
        Me.Porcentaje.BackColor = System.Drawing.Color.Transparent
        Me.Porcentaje.Name = "Porcentaje"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'Timer1
        '
        '
        'boton_Inicio
        '
        Me.boton_Inicio.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.boton_Inicio, "boton_Inicio")
        Me.boton_Inicio.Name = "boton_Inicio"
        Me.ToolTip1.SetToolTip(Me.boton_Inicio, resources.GetString("boton_Inicio.ToolTip"))
        Me.boton_Inicio.UseVisualStyleBackColor = True
        '
        'boton_modo
        '
        Me.boton_modo.Cursor = System.Windows.Forms.Cursors.Hand
        resources.ApplyResources(Me.boton_modo, "boton_modo")
        Me.boton_modo.Name = "boton_modo"
        Me.ToolTip1.SetToolTip(Me.boton_modo, resources.GetString("boton_modo.ToolTip"))
        Me.boton_modo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.BODEGA.My.Resources.Resources.pruebas
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Name = "Button1"
        Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = False
        '
        'b_Admin
        '
        Me.b_Admin.BackColor = System.Drawing.Color.Transparent
        Me.b_Admin.BackgroundImage = Global.BODEGA.My.Resources.Resources.administrador
        resources.ApplyResources(Me.b_Admin, "b_Admin")
        Me.b_Admin.FlatAppearance.BorderSize = 0
        Me.b_Admin.Name = "b_Admin"
        Me.ToolTip1.SetToolTip(Me.b_Admin, resources.GetString("b_Admin.ToolTip"))
        Me.b_Admin.UseVisualStyleBackColor = False
        '
        'b_Visualizacion
        '
        Me.b_Visualizacion.BackColor = System.Drawing.Color.Transparent
        Me.b_Visualizacion.BackgroundImage = Global.BODEGA.My.Resources.Resources.visualizacion_de_datos
        resources.ApplyResources(Me.b_Visualizacion, "b_Visualizacion")
        Me.b_Visualizacion.FlatAppearance.BorderSize = 0
        Me.b_Visualizacion.Name = "b_Visualizacion"
        Me.ToolTip1.SetToolTip(Me.b_Visualizacion, resources.GetString("b_Visualizacion.ToolTip"))
        Me.b_Visualizacion.UseVisualStyleBackColor = False
        '
        'b_end
        '
        Me.b_end.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.b_end.BackgroundImage = Global.BODEGA.My.Resources.Resources.poder
        resources.ApplyResources(Me.b_end, "b_end")
        Me.b_end.Name = "b_end"
        Me.b_end.UseVisualStyleBackColor = False
        '
        'Loading_inicio
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.b_Visualizacion)
        Me.Controls.Add(Me.b_Admin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.b_end)
        Me.Controls.Add(Me.boton_modo)
        Me.Controls.Add(Me.boton_Inicio)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Porcentaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading_inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Porcentaje As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents boton_Inicio As Button
    Friend WithEvents boton_modo As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents b_end As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents b_Admin As Button
    Friend WithEvents b_Visualizacion As Button
End Class
