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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMBformaPago = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTcarnet = New System.Windows.Forms.TextBox()
        Me.TXTnombre = New System.Windows.Forms.TextBox()
        Me.CMBcarreras = New System.Windows.Forms.ComboBox()
        Me.RDbasico = New System.Windows.Forms.RadioButton()
        Me.RDdiversificado = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTtinscritos = New System.Windows.Forms.TextBox()
        Me.TXTtformaPago = New System.Windows.Forms.TextBox()
        Me.TXTnivelBueno = New System.Windows.Forms.TextBox()
        Me.TXTtgeneral = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTtnivel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNaceptar = New System.Windows.Forms.Button()
        Me.BTNtotales = New System.Windows.Forms.Button()
        Me.BTNsalir = New System.Windows.Forms.Button()
        Me.BTNltotales = New System.Windows.Forms.Button()
        Me.BTNlentradas = New System.Windows.Forms.Button()
        Me.BTNlmatriz = New System.Windows.Forms.Button()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MediumOrchid
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(34, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(918, 271)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Generales:"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MediumOrchid
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(906, 219)
        Me.DataGridView1.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nivel de Estudio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cuota de Inscripción"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "1era Cuota Mensual"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Forma de Pago"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.GroupBox1.Controls.Add(Me.CMBformaPago)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTcarnet)
        Me.GroupBox1.Controls.Add(Me.TXTnombre)
        Me.GroupBox1.Controls.Add(Me.CMBcarreras)
        Me.GroupBox1.Controls.Add(Me.RDbasico)
        Me.GroupBox1.Controls.Add(Me.RDdiversificado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 177)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos"
        '
        'CMBformaPago
        '
        Me.CMBformaPago.FormattingEnabled = True
        Me.CMBformaPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta de credito", "Trasferencia por ACH", "Deposito bancario"})
        Me.CMBformaPago.Location = New System.Drawing.Point(646, 138)
        Me.CMBformaPago.Name = "CMBformaPago"
        Me.CMBformaPago.Size = New System.Drawing.Size(206, 27)
        Me.CMBformaPago.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(510, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Forma de pago:"
        '
        'TXTcarnet
        '
        Me.TXTcarnet.Location = New System.Drawing.Point(646, 34)
        Me.TXTcarnet.Name = "TXTcarnet"
        Me.TXTcarnet.Size = New System.Drawing.Size(207, 26)
        Me.TXTcarnet.TabIndex = 8
        '
        'TXTnombre
        '
        Me.TXTnombre.Location = New System.Drawing.Point(128, 34)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.Size = New System.Drawing.Size(437, 26)
        Me.TXTnombre.TabIndex = 7
        '
        'CMBcarreras
        '
        Me.CMBcarreras.FormattingEnabled = True
        Me.CMBcarreras.Items.AddRange(New Object() {"Perito Contador", "Bachillerato", "Electronico", "Diseno Grafico"})
        Me.CMBcarreras.Location = New System.Drawing.Point(646, 103)
        Me.CMBcarreras.Name = "CMBcarreras"
        Me.CMBcarreras.Size = New System.Drawing.Size(207, 27)
        Me.CMBcarreras.TabIndex = 6
        '
        'RDbasico
        '
        Me.RDbasico.AutoSize = True
        Me.RDbasico.Location = New System.Drawing.Point(173, 136)
        Me.RDbasico.Name = "RDbasico"
        Me.RDbasico.Size = New System.Drawing.Size(74, 23)
        Me.RDbasico.TabIndex = 5
        Me.RDbasico.Text = "Basico"
        Me.RDbasico.UseVisualStyleBackColor = True
        '
        'RDdiversificado
        '
        Me.RDdiversificado.AutoSize = True
        Me.RDdiversificado.Checked = True
        Me.RDdiversificado.Location = New System.Drawing.Point(173, 107)
        Me.RDdiversificado.Name = "RDdiversificado"
        Me.RDdiversificado.Size = New System.Drawing.Size(120, 23)
        Me.RDdiversificado.TabIndex = 4
        Me.RDdiversificado.TabStop = True
        Me.RDdiversificado.Text = "Diversificado"
        Me.RDdiversificado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(448, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Carreras de diversificado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nivel de Estudio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Carnet:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LimeGreen
        Me.GroupBox3.Controls.Add(Me.TXTtinscritos)
        Me.GroupBox3.Controls.Add(Me.TXTtformaPago)
        Me.GroupBox3.Controls.Add(Me.TXTnivelBueno)
        Me.GroupBox3.Controls.Add(Me.TXTtgeneral)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TXTtnivel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(34, 516)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(918, 170)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales:"
        '
        'TXTtinscritos
        '
        Me.TXTtinscritos.Location = New System.Drawing.Point(646, 39)
        Me.TXTtinscritos.Name = "TXTtinscritos"
        Me.TXTtinscritos.Size = New System.Drawing.Size(221, 26)
        Me.TXTtinscritos.TabIndex = 7
        '
        'TXTtformaPago
        '
        Me.TXTtformaPago.Location = New System.Drawing.Point(257, 102)
        Me.TXTtformaPago.Name = "TXTtformaPago"
        Me.TXTtformaPago.Size = New System.Drawing.Size(221, 26)
        Me.TXTtformaPago.TabIndex = 6
        '
        'TXTnivelBueno
        '
        Me.TXTnivelBueno.Location = New System.Drawing.Point(646, 102)
        Me.TXTnivelBueno.Name = "TXTnivelBueno"
        Me.TXTnivelBueno.Size = New System.Drawing.Size(221, 26)
        Me.TXTnivelBueno.TabIndex = 5
        '
        'TXTtgeneral
        '
        Me.TXTtgeneral.Location = New System.Drawing.Point(173, 42)
        Me.TXTtgeneral.Name = "TXTtgeneral"
        Me.TXTtgeneral.Size = New System.Drawing.Size(221, 26)
        Me.TXTtgeneral.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(423, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 19)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Total inscritos por carrera:"
        '
        'TXTtnivel
        '
        Me.TXTtnivel.AutoSize = True
        Me.TXTtnivel.Location = New System.Drawing.Point(508, 108)
        Me.TXTtnivel.Name = "TXTtnivel"
        Me.TXTtnivel.Size = New System.Drawing.Size(116, 19)
        Me.TXTtnivel.TabIndex = 2
        Me.TXTtnivel.Text = "Total por nivel:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total por forma de pago:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Total general:"
        '
        'BTNaceptar
        '
        Me.BTNaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNaceptar.Location = New System.Drawing.Point(991, 27)
        Me.BTNaceptar.Name = "BTNaceptar"
        Me.BTNaceptar.Size = New System.Drawing.Size(160, 68)
        Me.BTNaceptar.TabIndex = 27
        Me.BTNaceptar.Text = "Aceptar"
        Me.BTNaceptar.UseVisualStyleBackColor = False
        '
        'BTNtotales
        '
        Me.BTNtotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BTNtotales.Location = New System.Drawing.Point(991, 354)
        Me.BTNtotales.Name = "BTNtotales"
        Me.BTNtotales.Size = New System.Drawing.Size(160, 68)
        Me.BTNtotales.TabIndex = 26
        Me.BTNtotales.Text = "Totales"
        Me.BTNtotales.UseVisualStyleBackColor = False
        '
        'BTNsalir
        '
        Me.BTNsalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNsalir.Location = New System.Drawing.Point(991, 439)
        Me.BTNsalir.Name = "BTNsalir"
        Me.BTNsalir.Size = New System.Drawing.Size(160, 68)
        Me.BTNsalir.TabIndex = 24
        Me.BTNsalir.Text = "Salir"
        Me.BTNsalir.UseVisualStyleBackColor = False
        '
        'BTNltotales
        '
        Me.BTNltotales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNltotales.Location = New System.Drawing.Point(991, 268)
        Me.BTNltotales.Name = "BTNltotales"
        Me.BTNltotales.Size = New System.Drawing.Size(160, 68)
        Me.BTNltotales.TabIndex = 23
        Me.BTNltotales.Text = "Limpiar Totales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNltotales.UseVisualStyleBackColor = False
        '
        'BTNlentradas
        '
        Me.BTNlentradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNlentradas.Location = New System.Drawing.Point(991, 185)
        Me.BTNlentradas.Name = "BTNlentradas"
        Me.BTNlentradas.Size = New System.Drawing.Size(160, 68)
        Me.BTNlentradas.TabIndex = 22
        Me.BTNlentradas.Text = "Limpiar Entradas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNlentradas.UseVisualStyleBackColor = False
        '
        'BTNlmatriz
        '
        Me.BTNlmatriz.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNlmatriz.Location = New System.Drawing.Point(991, 106)
        Me.BTNlmatriz.Name = "BTNlmatriz"
        Me.BTNlmatriz.Size = New System.Drawing.Size(160, 68)
        Me.BTNlmatriz.TabIndex = 21
        Me.BTNlmatriz.Text = "Limpiar Matriz"
        Me.BTNlmatriz.UseVisualStyleBackColor = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago Inicial"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.HeaderText = "Carrera"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1202, 711)
        Me.Controls.Add(Me.BTNaceptar)
        Me.Controls.Add(Me.BTNtotales)
        Me.Controls.Add(Me.BTNsalir)
        Me.Controls.Add(Me.BTNltotales)
        Me.Controls.Add(Me.BTNlentradas)
        Me.Controls.Add(Me.BTNlmatriz)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBformaPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTcarnet As TextBox
    Friend WithEvents TXTnombre As TextBox
    Friend WithEvents CMBcarreras As ComboBox
    Friend WithEvents RDbasico As RadioButton
    Friend WithEvents RDdiversificado As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTtinscritos As TextBox
    Friend WithEvents TXTtformaPago As TextBox
    Friend WithEvents TXTnivelBueno As TextBox
    Friend WithEvents TXTtgeneral As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTtnivel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNaceptar As Button
    Friend WithEvents BTNtotales As Button
    Friend WithEvents BTNsalir As Button
    Friend WithEvents BTNltotales As Button
    Friend WithEvents BTNlentradas As Button
    Friend WithEvents BTNlmatriz As Button
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
