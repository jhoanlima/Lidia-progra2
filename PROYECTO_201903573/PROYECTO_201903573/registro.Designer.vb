<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BTNregistro2 = New System.Windows.Forms.Button()
        Me.TXTcontraseña = New System.Windows.Forms.TextBox()
        Me.TXTusuario = New System.Windows.Forms.TextBox()
        Me.TXTapellido = New System.Windows.Forms.TextBox()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CMBtusuario = New System.Windows.Forms.ComboBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.CMBtusuario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.BTNregistro2)
        Me.GroupBox1.Controls.Add(Me.TXTcontraseña)
        Me.GroupBox1.Controls.Add(Me.TXTusuario)
        Me.GroupBox1.Controls.Add(Me.TXTapellido)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(490, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 517)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Berlin Sans FB", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(161, 301)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(217, 29)
        Me.DateTimePicker1.TabIndex = 12
        '
        'BTNregistro2
        '
        Me.BTNregistro2.BackColor = System.Drawing.Color.Azure
        Me.BTNregistro2.Location = New System.Drawing.Point(110, 428)
        Me.BTNregistro2.Name = "BTNregistro2"
        Me.BTNregistro2.Size = New System.Drawing.Size(199, 60)
        Me.BTNregistro2.TabIndex = 11
        Me.BTNregistro2.Text = "REGISTRARSE"
        Me.BTNregistro2.UseVisualStyleBackColor = False
        '
        'TXTcontraseña
        '
        Me.TXTcontraseña.Location = New System.Drawing.Point(161, 363)
        Me.TXTcontraseña.Name = "TXTcontraseña"
        Me.TXTcontraseña.Size = New System.Drawing.Size(217, 29)
        Me.TXTcontraseña.TabIndex = 10
        '
        'TXTusuario
        '
        Me.TXTusuario.Location = New System.Drawing.Point(161, 175)
        Me.TXTusuario.Name = "TXTusuario"
        Me.TXTusuario.Size = New System.Drawing.Size(217, 29)
        Me.TXTusuario.TabIndex = 8
        '
        'TXTapellido
        '
        Me.TXTapellido.Location = New System.Drawing.Point(161, 116)
        Me.TXTapellido.Name = "TXTapellido"
        Me.TXTapellido.Size = New System.Drawing.Size(217, 29)
        Me.TXTapellido.TabIndex = 7
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(161, 45)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(217, 29)
        Me.TXTnombre.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 23)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.Location = New System.Drawing.Point(712, 647)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 12
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipo de Usuario"
        '
        'CMBtusuario
        '
        Me.CMBtusuario.FormattingEnabled = True
        Me.CMBtusuario.Items.AddRange(New Object() {"Administrador", "Cliente"})
        Me.CMBtusuario.Location = New System.Drawing.Point(161, 240)
        Me.CMBtusuario.Name = "CMBtusuario"
        Me.CMBtusuario.Size = New System.Drawing.Size(217, 31)
        Me.CMBtusuario.TabIndex = 13
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.registro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(957, 719)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "registro"
        Me.Text = "registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTcontraseña As TextBox
    Friend WithEvents TXTusuario As TextBox
    Friend WithEvents TXTapellido As TextBox
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents BTNregistro2 As Button
    Friend WithEvents BTNregresar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CMBtusuario As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
