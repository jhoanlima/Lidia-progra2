<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class presor
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
        Me.DATAprestor = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNprestar = New System.Windows.Forms.Button()
        Me.BTNbuscar = New System.Windows.Forms.Button()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.TXTbuscar = New System.Windows.Forms.TextBox()
        Me.CMBbuscar = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DATAprestor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Location = New System.Drawing.Point(100, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elige un libro de su interés"
        '
        'DATAprestor
        '
        Me.DATAprestor.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.DATAprestor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAprestor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DATAprestor.Location = New System.Drawing.Point(104, 171)
        Me.DATAprestor.Name = "DATAprestor"
        Me.DATAprestor.RowHeadersWidth = 51
        Me.DATAprestor.RowTemplate.Height = 24
        Me.DATAprestor.Size = New System.Drawing.Size(1015, 275)
        Me.DATAprestor.TabIndex = 1
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
        'Column5
        '
        Me.Column5.HeaderText = "Disponibles"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(100, 476)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*Para prestar lbro, haga click sobre el titulo de este"
        '
        'BTNprestar
        '
        Me.BTNprestar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNprestar.Location = New System.Drawing.Point(480, 539)
        Me.BTNprestar.Name = "BTNprestar"
        Me.BTNprestar.Size = New System.Drawing.Size(211, 59)
        Me.BTNprestar.TabIndex = 3
        Me.BTNprestar.Text = "Prestar"
        Me.BTNprestar.UseVisualStyleBackColor = False
        '
        'BTNbuscar
        '
        Me.BTNbuscar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTNbuscar.Location = New System.Drawing.Point(394, 23)
        Me.BTNbuscar.Name = "BTNbuscar"
        Me.BTNbuscar.Size = New System.Drawing.Size(125, 37)
        Me.BTNbuscar.TabIndex = 4
        Me.BTNbuscar.Text = "Buscar"
        Me.BTNbuscar.UseVisualStyleBackColor = False
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BTNregresar.Location = New System.Drawing.Point(920, 536)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 16
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        Me.BTNregresar.UseWaitCursor = True
        '
        'TXTbuscar
        '
        Me.TXTbuscar.Location = New System.Drawing.Point(16, 27)
        Me.TXTbuscar.Name = "TXTbuscar"
        Me.TXTbuscar.Size = New System.Drawing.Size(210, 29)
        Me.TXTbuscar.TabIndex = 17
        '
        'CMBbuscar
        '
        Me.CMBbuscar.FormattingEnabled = True
        Me.CMBbuscar.Items.AddRange(New Object() {"Título", "Catégoria"})
        Me.CMBbuscar.Location = New System.Drawing.Point(247, 27)
        Me.CMBbuscar.Name = "CMBbuscar"
        Me.CMBbuscar.Size = New System.Drawing.Size(128, 31)
        Me.CMBbuscar.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.CMBbuscar)
        Me.GroupBox1.Controls.Add(Me.TXTbuscar)
        Me.GroupBox1.Controls.Add(Me.BTNbuscar)
        Me.GroupBox1.Location = New System.Drawing.Point(600, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(532, 88)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'presor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.reportes
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1207, 647)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.BTNprestar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DATAprestor)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "presor"
        Me.Text = "presor"
        CType(Me.DATAprestor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DATAprestor As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNprestar As Button
    Friend WithEvents BTNbuscar As Button
    Friend WithEvents BTNregresar As Button
    Friend WithEvents TXTbuscar As TextBox
    Friend WithEvents CMBbuscar As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
