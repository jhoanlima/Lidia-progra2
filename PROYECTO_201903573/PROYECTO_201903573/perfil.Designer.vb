<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class perfil
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.TXTapellido = New System.Windows.Forms.TextBox()
        Me.TXTusuario = New System.Windows.Forms.TextBox()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.BTNactualizar)
        Me.GroupBox1.Controls.Add(Me.TXTusuario)
        Me.GroupBox1.Controls.Add(Me.TXTapellido)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(376, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 430)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(81, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(81, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nacimiento:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(196, 271)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(258, 29)
        Me.DateTimePicker1.TabIndex = 4
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(196, 71)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(258, 29)
        Me.TXTnombre.TabIndex = 5
        '
        'TXTapellido
        '
        Me.TXTapellido.Location = New System.Drawing.Point(196, 135)
        Me.TXTapellido.Name = "TXTapellido"
        Me.TXTapellido.Size = New System.Drawing.Size(258, 29)
        Me.TXTapellido.TabIndex = 6
        '
        'TXTusuario
        '
        Me.TXTusuario.Location = New System.Drawing.Point(196, 198)
        Me.TXTusuario.Name = "TXTusuario"
        Me.TXTusuario.Size = New System.Drawing.Size(258, 29)
        Me.TXTusuario.TabIndex = 7
        '
        'BTNactualizar
        '
        Me.BTNactualizar.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BTNactualizar.Location = New System.Drawing.Point(196, 330)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(176, 68)
        Me.BTNactualizar.TabIndex = 8
        Me.BTNactualizar.Text = "Actualizar Datos"
        Me.BTNactualizar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(64, 627)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 68)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Eliminar Cuenta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.Location = New System.Drawing.Point(1054, 635)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 14
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        Me.BTNregresar.UseWaitCursor = True
        '
        'perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.perfil
        Me.ClientSize = New System.Drawing.Size(1336, 747)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "perfil"
        Me.Text = "perfil"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BTNactualizar As Button
    Friend WithEvents TXTusuario As TextBox
    Friend WithEvents TXTapellido As TextBox
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTNregresar As Button
End Class
