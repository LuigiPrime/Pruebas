<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Debug_Aplicacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Debug_Aplicacion))
        Me.l_pruebas = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.b_ON = New System.Windows.Forms.Button()
        Me.b_OFF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Info_carga = New System.Windows.Forms.Label()
        Me.Panel_RUTAS = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.l_unidad_disco = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.l_date = New System.Windows.Forms.Label()
        Me.b_BackUp = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel_bd = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel_RUTAS.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel_bd.SuspendLayout()
        Me.SuspendLayout()
        '
        'l_pruebas
        '
        Me.l_pruebas.AutoSize = True
        Me.l_pruebas.Location = New System.Drawing.Point(5, 7)
        Me.l_pruebas.Name = "l_pruebas"
        Me.l_pruebas.Size = New System.Drawing.Size(136, 13)
        Me.l_pruebas.TabIndex = 33
        Me.l_pruebas.Text = "MODO PRUEBAS ACTIVO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(3, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Datos de la version "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(3, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "URL conexion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(3, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Ruta BD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(3, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Ruta Instalacion Usuario"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(3, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Ruta Denominacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Silver
        Me.Label13.Location = New System.Drawing.Point(3, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Ruta Logos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.Location = New System.Drawing.Point(3, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Ruta ayuda"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.b_ON)
        Me.Panel1.Controls.Add(Me.b_OFF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Info_carga)
        Me.Panel1.Location = New System.Drawing.Point(8, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(301, 99)
        Me.Panel1.TabIndex = 43
        '
        'b_ON
        '
        Me.b_ON.BackColor = System.Drawing.Color.Transparent
        Me.b_ON.BackgroundImage = Global.BODEGA.My.Resources.Resources.encender
        Me.b_ON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_ON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_ON.FlatAppearance.BorderSize = 0
        Me.b_ON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_ON.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_ON.Location = New System.Drawing.Point(48, 24)
        Me.b_ON.Name = "b_ON"
        Me.b_ON.Size = New System.Drawing.Size(45, 45)
        Me.b_ON.TabIndex = 46
        Me.b_ON.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_ON, "Pulsar para activar enlace con BD")
        Me.b_ON.UseVisualStyleBackColor = False
        '
        'b_OFF
        '
        Me.b_OFF.BackColor = System.Drawing.Color.Transparent
        Me.b_OFF.BackgroundImage = Global.BODEGA.My.Resources.Resources.apagar
        Me.b_OFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_OFF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.b_OFF.FlatAppearance.BorderSize = 0
        Me.b_OFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b_OFF.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b_OFF.Location = New System.Drawing.Point(224, 24)
        Me.b_OFF.Name = "b_OFF"
        Me.b_OFF.Size = New System.Drawing.Size(45, 45)
        Me.b_OFF.TabIndex = 45
        Me.b_OFF.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.b_OFF, "Pulsar para desactivar enlace con BD")
        Me.b_OFF.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(301, 21)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "CONEXIÓN A BASE DE DATOS"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Info_carga
        '
        Me.Info_carga.BackColor = System.Drawing.SystemColors.Info
        Me.Info_carga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Info_carga.Cursor = System.Windows.Forms.Cursors.Help
        Me.Info_carga.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Info_carga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Info_carga.Location = New System.Drawing.Point(3, 68)
        Me.Info_carga.Name = "Info_carga"
        Me.Info_carga.Size = New System.Drawing.Size(296, 24)
        Me.Info_carga.TabIndex = 43
        Me.Info_carga.Text = "Label2"
        Me.Info_carga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_RUTAS
        '
        Me.Panel_RUTAS.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel_RUTAS.Controls.Add(Me.Label22)
        Me.Panel_RUTAS.Controls.Add(Me.Label20)
        Me.Panel_RUTAS.Controls.Add(Me.Label19)
        Me.Panel_RUTAS.Controls.Add(Me.Label18)
        Me.Panel_RUTAS.Controls.Add(Me.Label17)
        Me.Panel_RUTAS.Controls.Add(Me.Label16)
        Me.Panel_RUTAS.Controls.Add(Me.l_unidad_disco)
        Me.Panel_RUTAS.Controls.Add(Me.Label15)
        Me.Panel_RUTAS.Controls.Add(Me.Label7)
        Me.Panel_RUTAS.Controls.Add(Me.Label6)
        Me.Panel_RUTAS.Controls.Add(Me.Label5)
        Me.Panel_RUTAS.Controls.Add(Me.Label3)
        Me.Panel_RUTAS.Controls.Add(Me.Label2)
        Me.Panel_RUTAS.Controls.Add(Me.Label1)
        Me.Panel_RUTAS.Controls.Add(Me.Label8)
        Me.Panel_RUTAS.Controls.Add(Me.Label9)
        Me.Panel_RUTAS.Controls.Add(Me.Label14)
        Me.Panel_RUTAS.Controls.Add(Me.Label10)
        Me.Panel_RUTAS.Controls.Add(Me.Label13)
        Me.Panel_RUTAS.Controls.Add(Me.Label11)
        Me.Panel_RUTAS.Controls.Add(Me.Label12)
        Me.Panel_RUTAS.Location = New System.Drawing.Point(349, 20)
        Me.Panel_RUTAS.Name = "Panel_RUTAS"
        Me.Panel_RUTAS.Size = New System.Drawing.Size(785, 422)
        Me.Panel_RUTAS.TabIndex = 44
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 231)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 13)
        Me.Label22.TabIndex = 58
        Me.Label22.Text = "data source"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 209)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 13)
        Me.Label20.TabIndex = 57
        Me.Label20.Text = "unidad disco"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(84, 297)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Label16"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(84, 275)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(84, 253)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 54
        Me.Label17.Text = "Label16"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(84, 231)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Label16"
        '
        'l_unidad_disco
        '
        Me.l_unidad_disco.AutoSize = True
        Me.l_unidad_disco.Location = New System.Drawing.Point(84, 209)
        Me.l_unidad_disco.Name = "l_unidad_disco"
        Me.l_unidad_disco.Size = New System.Drawing.Size(45, 13)
        Me.l_unidad_disco.TabIndex = 52
        Me.l_unidad_disco.Text = "Label16"
        Me.ToolTip1.SetToolTip(Me.l_unidad_disco, "Informacion sobre la unidad de disco utilizada")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Info
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(160, 170)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 17)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "Label15"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Info
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(162, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 17)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Label7"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(162, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Label5"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 17)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Label1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.l_date)
        Me.Panel3.Controls.Add(Me.b_BackUp)
        Me.Panel3.Location = New System.Drawing.Point(12, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(311, 156)
        Me.Panel3.TabIndex = 50
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(11, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(202, 13)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "COPIAS SEGURIDAD BASE DE DATOS"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.BODEGA.My.Resources.Resources.basura
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(14, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 52)
        Me.Button1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button1, "Pulsar para borrar directorio de copias de seguridad")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'l_date
        '
        Me.l_date.AutoSize = True
        Me.l_date.BackColor = System.Drawing.SystemColors.Info
        Me.l_date.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.l_date.Location = New System.Drawing.Point(85, 75)
        Me.l_date.Name = "l_date"
        Me.l_date.Size = New System.Drawing.Size(47, 15)
        Me.l_date.TabIndex = 1
        Me.l_date.Text = "Label20"
        '
        'b_BackUp
        '
        Me.b_BackUp.BackgroundImage = Global.BODEGA.My.Resources.Resources.backup
        Me.b_BackUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.b_BackUp.Location = New System.Drawing.Point(14, 27)
        Me.b_BackUp.Name = "b_BackUp"
        Me.b_BackUp.Size = New System.Drawing.Size(55, 52)
        Me.b_BackUp.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.b_BackUp, "Pulsar para crear una copia de seguridad de la BD")
        Me.b_BackUp.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.BODEGA.My.Resources.Resources.pruebas
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(140, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 51)
        Me.Button2.TabIndex = 53
        Me.ToolTip1.SetToolTip(Me.Button2, "Pulsar para mostrar informacion para depuracion")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel_bd
        '
        Me.Panel_bd.Controls.Add(Me.Panel1)
        Me.Panel_bd.Controls.Add(Me.l_pruebas)
        Me.Panel_bd.Location = New System.Drawing.Point(22, 297)
        Me.Panel_bd.Name = "Panel_bd"
        Me.Panel_bd.Size = New System.Drawing.Size(321, 145)
        Me.Panel_bd.TabIndex = 52
        '
        'Debug_Aplicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1165, 525)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel_bd)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_RUTAS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Debug_Aplicacion"
        Me.Text = "HERRAMIENTAS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel_RUTAS.ResumeLayout(False)
        Me.Panel_RUTAS.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel_bd.ResumeLayout(False)
        Me.Panel_bd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents l_pruebas As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents b_ON As Button
    Friend WithEvents b_OFF As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Info_carga As Label
    Friend WithEvents Panel_RUTAS As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents b_BackUp As Button
    Friend WithEvents l_date As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents l_unidad_disco As Label
    Friend WithEvents Panel_bd As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label22 As Label
End Class
