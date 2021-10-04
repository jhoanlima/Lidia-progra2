<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestados
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DATAprestados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNdevolver = New System.Windows.Forms.Button()
        Me.BTNregresar = New System.Windows.Forms.Button()
        CType(Me.DATAprestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(172, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuentas con estos libros en tu haber."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(172, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "*Para devolver lbro, haga click sobre el título de este"
        '
        'DATAprestados
        '
        Me.DATAprestados.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DATAprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAprestados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DATAprestados.Location = New System.Drawing.Point(176, 136)
        Me.DATAprestados.Name = "DATAprestados"
        Me.DATAprestados.RowHeadersWidth = 51
        Me.DATAprestados.RowTemplate.Height = 24
        Me.DATAprestados.Size = New System.Drawing.Size(990, 307)
        Me.DATAprestados.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Título"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Autor"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Género"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Editorial"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'BTNdevolver
        '
        Me.BTNdevolver.BackColor = System.Drawing.Color.PaleGreen
        Me.BTNdevolver.Location = New System.Drawing.Point(538, 511)
        Me.BTNdevolver.Name = "BTNdevolver"
        Me.BTNdevolver.Size = New System.Drawing.Size(283, 61)
        Me.BTNdevolver.TabIndex = 3
        Me.BTNdevolver.Text = "Devolver"
        Me.BTNdevolver.UseVisualStyleBackColor = False
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNregresar.Location = New System.Drawing.Point(967, 511)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 15
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        Me.BTNregresar.UseWaitCursor = True
        '
        'Prestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.cliente
        Me.ClientSize = New System.Drawing.Size(1331, 613)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.BTNdevolver)
        Me.Controls.Add(Me.DATAprestados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Green
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Prestados"
        Me.Text = "Prestados"
        CType(Me.DATAprestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DATAprestados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BTNdevolver As Button
    Friend WithEvents BTNregresar As Button
End Class
