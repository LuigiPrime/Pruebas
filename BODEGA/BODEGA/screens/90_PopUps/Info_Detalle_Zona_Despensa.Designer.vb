<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Detalle_Zona_Despensa
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
        Me.Panel_photo = New System.Windows.Forms.Panel()
        Me.PictureBox_Zone_2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_Zone = New System.Windows.Forms.PictureBox()
        Me.Panel_photo.SuspendLayout()
        CType(Me.PictureBox_Zone_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_Zone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_photo
        '
        Me.Panel_photo.BackColor = System.Drawing.Color.Black
        Me.Panel_photo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_photo.Controls.Add(Me.PictureBox_Zone_2)
        Me.Panel_photo.Controls.Add(Me.PictureBox_Zone)
        Me.Panel_photo.Location = New System.Drawing.Point(12, 12)
        Me.Panel_photo.Name = "Panel_photo"
        Me.Panel_photo.Size = New System.Drawing.Size(847, 396)
        Me.Panel_photo.TabIndex = 2
        '
        'PictureBox_Zone_2
        '
        Me.PictureBox_Zone_2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox_Zone_2.Location = New System.Drawing.Point(427, 13)
        Me.PictureBox_Zone_2.Name = "PictureBox_Zone_2"
        Me.PictureBox_Zone_2.Size = New System.Drawing.Size(409, 363)
        Me.PictureBox_Zone_2.TabIndex = 1
        Me.PictureBox_Zone_2.TabStop = False
        '
        'PictureBox_Zone
        '
        Me.PictureBox_Zone.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox_Zone.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox_Zone.Name = "PictureBox_Zone"
        Me.PictureBox_Zone.Size = New System.Drawing.Size(409, 363)
        Me.PictureBox_Zone.TabIndex = 0
        Me.PictureBox_Zone.TabStop = False
        '
        'Info_Detalle_Zona_Despensa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 419)
        Me.Controls.Add(Me.Panel_photo)
        Me.Name = "Info_Detalle_Zona_Despensa"
        Me.Text = "Info_Detalle_Zona_Despensa"
        Me.Panel_photo.ResumeLayout(False)
        CType(Me.PictureBox_Zone_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_Zone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_photo As Panel
    Friend WithEvents PictureBox_Zone_2 As PictureBox
    Friend WithEvents PictureBox_Zone As PictureBox
End Class
