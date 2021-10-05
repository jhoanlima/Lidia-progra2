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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNsi = New System.Windows.Forms.Button()
        Me.BTNno = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desea salir?"
        '
        'BTNsi
        '
        Me.BTNsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNsi.ForeColor = System.Drawing.Color.Green
        Me.BTNsi.Location = New System.Drawing.Point(53, 112)
        Me.BTNsi.Name = "BTNsi"
        Me.BTNsi.Size = New System.Drawing.Size(128, 53)
        Me.BTNsi.TabIndex = 1
        Me.BTNsi.Text = "Si"
        Me.BTNsi.UseVisualStyleBackColor = False
        '
        'BTNno
        '
        Me.BTNno.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNno.ForeColor = System.Drawing.Color.Maroon
        Me.BTNno.Location = New System.Drawing.Point(233, 112)
        Me.BTNno.Name = "BTNno"
        Me.BTNno.Size = New System.Drawing.Size(128, 53)
        Me.BTNno.TabIndex = 2
        Me.BTNno.Text = "No"
        Me.BTNno.UseVisualStyleBackColor = False
        '
        'salir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 223)
        Me.Controls.Add(Me.BTNno)
        Me.Controls.Add(Me.BTNsi)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "salir"
        Me.Text = "salir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNsi As Button
    Friend WithEvents BTNno As Button
End Class
