<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edtorial
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTeditDireccion = New System.Windows.Forms.TextBox()
        Me.TXTeditNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNagregar = New System.Windows.Forms.Button()
        Me.BTNmodificar = New System.Windows.Forms.Button()
        Me.BTNeliminar = New System.Windows.Forms.Button()
        Me.DATAeditorial = New System.Windows.Forms.DataGridView()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.BTNlimpiar = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTtelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DATAeditorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.GroupBox1.Controls.Add(Me.TXTtelefono)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTeditDireccion)
        Me.GroupBox1.Controls.Add(Me.TXTeditNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(367, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 225)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TXTeditDireccion
        '
        Me.TXTeditDireccion.Location = New System.Drawing.Point(159, 104)
        Me.TXTeditDireccion.Name = "TXTeditDireccion"
        Me.TXTeditDireccion.Size = New System.Drawing.Size(292, 27)
        Me.TXTeditDireccion.TabIndex = 4
        '
        'TXTeditNombre
        '
        Me.TXTeditNombre.Location = New System.Drawing.Point(159, 26)
        Me.TXTeditNombre.Name = "TXTeditNombre"
        Me.TXTeditNombre.Size = New System.Drawing.Size(292, 27)
        Me.TXTeditNombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'BTNagregar
        '
        Me.BTNagregar.BackColor = System.Drawing.Color.PaleGreen
        Me.BTNagregar.Location = New System.Drawing.Point(994, 94)
        Me.BTNagregar.Name = "BTNagregar"
        Me.BTNagregar.Size = New System.Drawing.Size(203, 55)
        Me.BTNagregar.TabIndex = 2
        Me.BTNagregar.Text = "Agregar"
        Me.BTNagregar.UseVisualStyleBackColor = False
        '
        'BTNmodificar
        '
        Me.BTNmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNmodificar.Location = New System.Drawing.Point(994, 183)
        Me.BTNmodificar.Name = "BTNmodificar"
        Me.BTNmodificar.Size = New System.Drawing.Size(203, 57)
        Me.BTNmodificar.TabIndex = 3
        Me.BTNmodificar.Text = "Modificar"
        Me.BTNmodificar.UseVisualStyleBackColor = False
        '
        'BTNeliminar
        '
        Me.BTNeliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNeliminar.Location = New System.Drawing.Point(994, 263)
        Me.BTNeliminar.Name = "BTNeliminar"
        Me.BTNeliminar.Size = New System.Drawing.Size(203, 56)
        Me.BTNeliminar.TabIndex = 4
        Me.BTNeliminar.Text = "Eliminar"
        Me.BTNeliminar.UseVisualStyleBackColor = False
        '
        'DATAeditorial
        '
        Me.DATAeditorial.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DATAeditorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAeditorial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Column1, Me.Column2})
        Me.DATAeditorial.Location = New System.Drawing.Point(65, 351)
        Me.DATAeditorial.Name = "DATAeditorial"
        Me.DATAeditorial.RowHeadersWidth = 51
        Me.DATAeditorial.RowTemplate.Height = 24
        Me.DATAeditorial.Size = New System.Drawing.Size(1132, 257)
        Me.DATAeditorial.TabIndex = 5
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.Location = New System.Drawing.Point(994, 630)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 13
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        '
        'BTNlimpiar
        '
        Me.BTNlimpiar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTNlimpiar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNlimpiar.Location = New System.Drawing.Point(526, 633)
        Me.BTNlimpiar.Name = "BTNlimpiar"
        Me.BTNlimpiar.Size = New System.Drawing.Size(203, 57)
        Me.BTNlimpiar.TabIndex = 14
        Me.BTNlimpiar.Text = "Limpiar Entradas"
        Me.BTNlimpiar.UseVisualStyleBackColor = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Dirrección"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Telefono"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Telefono:"
        '
        'TXTtelefono
        '
        Me.TXTtelefono.Location = New System.Drawing.Point(159, 163)
        Me.TXTtelefono.Name = "TXTtelefono"
        Me.TXTtelefono.Size = New System.Drawing.Size(292, 27)
        Me.TXTtelefono.TabIndex = 6
        '
        'edtorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.editorial
        Me.ClientSize = New System.Drawing.Size(1259, 702)
        Me.Controls.Add(Me.BTNlimpiar)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.DATAeditorial)
        Me.Controls.Add(Me.BTNeliminar)
        Me.Controls.Add(Me.BTNmodificar)
        Me.Controls.Add(Me.BTNagregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "edtorial"
        Me.Text = "edtorial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DATAeditorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTeditDireccion As TextBox
    Friend WithEvents TXTeditNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BTNagregar As Button
    Friend WithEvents BTNmodificar As Button
    Friend WithEvents BTNeliminar As Button
    Friend WithEvents DATAeditorial As DataGridView
    Friend WithEvents BTNregresar As Button
    Friend WithEvents BTNlimpiar As Button
    Friend WithEvents TXTtelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
