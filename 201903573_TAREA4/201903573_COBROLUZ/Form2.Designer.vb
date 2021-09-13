<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BTNno = New System.Windows.Forms.Button()
        Me.BTNsi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNno
        '
        Me.BTNno.Location = New System.Drawing.Point(241, 157)
        Me.BTNno.Name = "BTNno"
        Me.BTNno.Size = New System.Drawing.Size(75, 23)
        Me.BTNno.TabIndex = 0
        Me.BTNno.Text = "No"
        Me.BTNno.UseVisualStyleBackColor = True
        '
        'BTNsi
        '
        Me.BTNsi.Location = New System.Drawing.Point(89, 157)
        Me.BTNsi.Name = "BTNsi"
        Me.BTNsi.Size = New System.Drawing.Size(75, 23)
        Me.BTNsi.TabIndex = 1
        Me.BTNsi.Text = "Si"
        Me.BTNsi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(163, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desea Salir?"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(421, 259)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNsi)
        Me.Controls.Add(Me.BTNno)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNno As Button
    Friend WithEvents BTNsi As Button
    Friend WithEvents Label1 As Label
End Class
