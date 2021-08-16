<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salirform
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
        Me.BTNsi = New System.Windows.Forms.Button()
        Me.BTNno = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.BTNno)
        Me.GroupBox1.Controls.Add(Me.BTNsi)
        Me.GroupBox1.Location = New System.Drawing.Point(84, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(353, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "¿Desea salir?"
        '
        'BTNsi
        '
        Me.BTNsi.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNsi.Location = New System.Drawing.Point(49, 86)
        Me.BTNsi.Name = "BTNsi"
        Me.BTNsi.Size = New System.Drawing.Size(75, 23)
        Me.BTNsi.TabIndex = 0
        Me.BTNsi.Text = "Si"
        Me.BTNsi.UseVisualStyleBackColor = False
        '
        'BTNno
        '
        Me.BTNno.BackColor = System.Drawing.Color.Red
        Me.BTNno.Location = New System.Drawing.Point(213, 86)
        Me.BTNno.Name = "BTNno"
        Me.BTNno.Size = New System.Drawing.Size(75, 23)
        Me.BTNno.TabIndex = 1
        Me.BTNno.Text = "No"
        Me.BTNno.UseVisualStyleBackColor = False
        '
        'Salirform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(521, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Salirform"
        Me.Text = "Salirform"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTNsi As Button
    Friend WithEvents BTNno As Button
End Class
