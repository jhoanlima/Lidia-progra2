<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTNregistrarse = New System.Windows.Forms.Button()
        Me.BTNlogin = New System.Windows.Forms.Button()
        Me.TXTcontraseña = New System.Windows.Forms.TextBox()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNverificar = New System.Windows.Forms.Button()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Controls.Add(Me.BTNregistrarse)
        Me.GroupBox1.Controls.Add(Me.BTNlogin)
        Me.GroupBox1.Controls.Add(Me.TXTcontraseña)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(255, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(354, 374)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login"
        '
        'BTNregistrarse
        '
        Me.BTNregistrarse.BackColor = System.Drawing.Color.AliceBlue
        Me.BTNregistrarse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNregistrarse.Location = New System.Drawing.Point(143, 291)
        Me.BTNregistrarse.Name = "BTNregistrarse"
        Me.BTNregistrarse.Size = New System.Drawing.Size(185, 38)
        Me.BTNregistrarse.TabIndex = 5
        Me.BTNregistrarse.Text = "REGISTRARSE"
        Me.BTNregistrarse.UseVisualStyleBackColor = False
        '
        'BTNlogin
        '
        Me.BTNlogin.BackColor = System.Drawing.Color.Navy
        Me.BTNlogin.ForeColor = System.Drawing.Color.White
        Me.BTNlogin.Location = New System.Drawing.Point(33, 291)
        Me.BTNlogin.Name = "BTNlogin"
        Me.BTNlogin.Size = New System.Drawing.Size(87, 38)
        Me.BTNlogin.TabIndex = 4
        Me.BTNlogin.Text = "LOGIN"
        Me.BTNlogin.UseVisualStyleBackColor = False
        '
        'TXTcontraseña
        '
        Me.TXTcontraseña.Location = New System.Drawing.Point(126, 181)
        Me.TXTcontraseña.Name = "TXTcontraseña"
        Me.TXTcontraseña.Size = New System.Drawing.Size(193, 29)
        Me.TXTcontraseña.TabIndex = 3
        Me.TXTcontraseña.UseSystemPasswordChar = True
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(126, 79)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(193, 29)
        Me.TXTnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario"
        '
        'BTNverificar
        '
        Me.BTNverificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNverificar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNverificar.ForeColor = System.Drawing.Color.Black
        Me.BTNverificar.Location = New System.Drawing.Point(757, 408)
        Me.BTNverificar.Name = "BTNverificar"
        Me.BTNverificar.Size = New System.Drawing.Size(152, 82)
        Me.BTNverificar.TabIndex = 6
        Me.BTNverificar.Text = "Verificar Conexion"
        Me.BTNverificar.UseVisualStyleBackColor = False
        '
        'BTNsalir
        '
        Me.BTNsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNsalir.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsalir.ForeColor = System.Drawing.Color.Black
        Me.BTNsalir.Location = New System.Drawing.Point(30, 417)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(152, 82)
        Me.BTNsalir.TabIndex = 7
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.Login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(951, 571)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.BTNverificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNregistrarse As Button
    Friend WithEvents BTNlogin As Button
    Friend WithEvents TXTcontraseña As TextBox
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents BTNverificar As Button
    Friend WithEvents BTNsalir As Button
End Class
