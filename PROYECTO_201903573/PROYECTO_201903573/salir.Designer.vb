<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salir
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNno = New System.Windows.Forms.Button()
        Me.BTNsi = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.BTNsi)
        Me.GroupBox1.Controls.Add(Me.BTNno)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¿Desea Salir?"
        '
        'BTNno
        '
        Me.BTNno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNno.ForeColor = System.Drawing.Color.Maroon
        Me.BTNno.Location = New System.Drawing.Point(172, 124)
        Me.BTNno.Name = "BTNno"
        Me.BTNno.Size = New System.Drawing.Size(117, 49)
        Me.BTNno.TabIndex = 1
        Me.BTNno.Text = "No"
        Me.BTNno.UseVisualStyleBackColor = False
        '
        'BTNsi
        '
        Me.BTNsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNsi.ForeColor = System.Drawing.Color.Green
        Me.BTNsi.Location = New System.Drawing.Point(33, 124)
        Me.BTNsi.Name = "BTNsi"
        Me.BTNsi.Size = New System.Drawing.Size(117, 49)
        Me.BTNsi.TabIndex = 2
        Me.BTNsi.Text = "SI"
        Me.BTNsi.UseVisualStyleBackColor = False
        '
        'salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.cliente
        Me.ClientSize = New System.Drawing.Size(458, 270)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "salir"
        Me.Text = "salir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNsi As Button
    Friend WithEvents BTNno As Button
    Friend WithEvents Label1 As Label
End Class
