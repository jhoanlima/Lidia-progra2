<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class libros
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMBeditorial = New System.Windows.Forms.ComboBox()
        Me.TXTgenero = New System.Windows.Forms.TextBox()
        Me.TXTautor = New System.Windows.Forms.TextBox()
        Me.TXTtitulo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNeliminar = New System.Windows.Forms.Button()
        Me.BTNmodificar = New System.Windows.Forms.Button()
        Me.BTNagregar = New System.Windows.Forms.Button()
        Me.DATAlibros = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.BTNlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DATAlibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Título:"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Autor:"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Género:"
        Me.Label3.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.CMBeditorial)
        Me.GroupBox1.Controls.Add(Me.TXTgenero)
        Me.GroupBox1.Controls.Add(Me.TXTautor)
        Me.GroupBox1.Controls.Add(Me.TXTtitulo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 271)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.UseWaitCursor = True
        '
        'CMBeditorial
        '
        Me.CMBeditorial.FormattingEnabled = True
        Me.CMBeditorial.Items.AddRange(New Object() {"Ediciones Susaeta Guat", "Editoriales Sur S.A."})
        Me.CMBeditorial.Location = New System.Drawing.Point(179, 201)
        Me.CMBeditorial.Name = "CMBeditorial"
        Me.CMBeditorial.Size = New System.Drawing.Size(245, 28)
        Me.CMBeditorial.TabIndex = 7
        Me.CMBeditorial.UseWaitCursor = True
        '
        'TXTgenero
        '
        Me.TXTgenero.Location = New System.Drawing.Point(179, 151)
        Me.TXTgenero.Name = "TXTgenero"
        Me.TXTgenero.Size = New System.Drawing.Size(245, 27)
        Me.TXTgenero.TabIndex = 6
        Me.TXTgenero.UseWaitCursor = True
        '
        'TXTautor
        '
        Me.TXTautor.Location = New System.Drawing.Point(179, 99)
        Me.TXTautor.Name = "TXTautor"
        Me.TXTautor.Size = New System.Drawing.Size(245, 27)
        Me.TXTautor.TabIndex = 5
        Me.TXTautor.UseWaitCursor = True
        '
        'TXTtitulo
        '
        Me.TXTtitulo.Location = New System.Drawing.Point(179, 45)
        Me.TXTtitulo.Name = "TXTtitulo"
        Me.TXTtitulo.Size = New System.Drawing.Size(245, 27)
        Me.TXTtitulo.TabIndex = 4
        Me.TXTtitulo.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Editorial:"
        Me.Label4.UseWaitCursor = True
        '
        'BTNeliminar
        '
        Me.BTNeliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNeliminar.Location = New System.Drawing.Point(785, 278)
        Me.BTNeliminar.Name = "BTNeliminar"
        Me.BTNeliminar.Size = New System.Drawing.Size(203, 56)
        Me.BTNeliminar.TabIndex = 7
        Me.BTNeliminar.Text = "Eliminar"
        Me.BTNeliminar.UseVisualStyleBackColor = False
        Me.BTNeliminar.UseWaitCursor = True
        '
        'BTNmodificar
        '
        Me.BTNmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNmodificar.Location = New System.Drawing.Point(785, 198)
        Me.BTNmodificar.Name = "BTNmodificar"
        Me.BTNmodificar.Size = New System.Drawing.Size(203, 57)
        Me.BTNmodificar.TabIndex = 6
        Me.BTNmodificar.Text = "Modificar"
        Me.BTNmodificar.UseVisualStyleBackColor = False
        Me.BTNmodificar.UseWaitCursor = True
        '
        'BTNagregar
        '
        Me.BTNagregar.BackColor = System.Drawing.Color.PaleGreen
        Me.BTNagregar.Location = New System.Drawing.Point(785, 109)
        Me.BTNagregar.Name = "BTNagregar"
        Me.BTNagregar.Size = New System.Drawing.Size(203, 55)
        Me.BTNagregar.TabIndex = 5
        Me.BTNagregar.Text = "Agregar"
        Me.BTNagregar.UseVisualStyleBackColor = False
        Me.BTNagregar.UseWaitCursor = True
        '
        'DATAlibros
        '
        Me.DATAlibros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DATAlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAlibros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DATAlibros.Location = New System.Drawing.Point(111, 397)
        Me.DATAlibros.Name = "DATAlibros"
        Me.DATAlibros.RowHeadersWidth = 51
        Me.DATAlibros.RowTemplate.Height = 24
        Me.DATAlibros.Size = New System.Drawing.Size(877, 276)
        Me.DATAlibros.TabIndex = 8
        Me.DATAlibros.UseWaitCursor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Títulos"
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
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.Location = New System.Drawing.Point(789, 679)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 13
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        Me.BTNregresar.UseWaitCursor = True
        '
        'BTNlimpiar
        '
        Me.BTNlimpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTNlimpiar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNlimpiar.Location = New System.Drawing.Point(412, 685)
        Me.BTNlimpiar.Name = "BTNlimpiar"
        Me.BTNlimpiar.Size = New System.Drawing.Size(203, 57)
        Me.BTNlimpiar.TabIndex = 15
        Me.BTNlimpiar.Text = "Limpiar Entradas"
        Me.BTNlimpiar.UseVisualStyleBackColor = False
        '
        'libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.libros
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1086, 738)
        Me.Controls.Add(Me.BTNlimpiar)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.DATAlibros)
        Me.Controls.Add(Me.BTNeliminar)
        Me.Controls.Add(Me.BTNmodificar)
        Me.Controls.Add(Me.BTNagregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "libros"
        Me.Text = "libros"
        Me.UseWaitCursor = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DATAlibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBeditorial As ComboBox
    Friend WithEvents TXTgenero As TextBox
    Friend WithEvents TXTautor As TextBox
    Friend WithEvents TXTtitulo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNeliminar As Button
    Friend WithEvents BTNmodificar As Button
    Friend WithEvents BTNagregar As Button
    Friend WithEvents DATAlibros As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BTNregresar As Button
    Friend WithEvents BTNlimpiar As Button
End Class
