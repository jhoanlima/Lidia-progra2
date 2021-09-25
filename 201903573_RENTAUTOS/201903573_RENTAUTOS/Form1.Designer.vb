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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTporcentajeEfectivo = New System.Windows.Forms.TextBox()
        Me.TXTporcentajeTarjeta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBtarjeta = New System.Windows.Forms.CheckBox()
        Me.CBefectivo = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTdías = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBmarca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTplaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTnit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTNcalcular = New System.Windows.Forms.Button()
        Me.MenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ProcesosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarEntradasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXTporcentajeEfectivo)
        Me.GroupBox1.Controls.Add(Me.TXTporcentajeTarjeta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBtarjeta)
        Me.GroupBox1.Controls.Add(Me.CBefectivo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXTdías)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CMBmarca)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTplaca)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTnit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Salmon
        Me.GroupBox1.Location = New System.Drawing.Point(3, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(986, 306)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar Datos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(611, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(22, 19)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(611, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "%"
        '
        'TXTporcentajeEfectivo
        '
        Me.TXTporcentajeEfectivo.Enabled = False
        Me.TXTporcentajeEfectivo.Location = New System.Drawing.Point(505, 212)
        Me.TXTporcentajeEfectivo.Name = "TXTporcentajeEfectivo"
        Me.TXTporcentajeEfectivo.Size = New System.Drawing.Size(100, 26)
        Me.TXTporcentajeEfectivo.TabIndex = 13
        '
        'TXTporcentajeTarjeta
        '
        Me.TXTporcentajeTarjeta.Enabled = False
        Me.TXTporcentajeTarjeta.Location = New System.Drawing.Point(505, 254)
        Me.TXTporcentajeTarjeta.Name = "TXTporcentajeTarjeta"
        Me.TXTporcentajeTarjeta.Size = New System.Drawing.Size(100, 26)
        Me.TXTporcentajeTarjeta.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 19)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ingresar el porcentaje de cada forma de pago"
        '
        'CBtarjeta
        '
        Me.CBtarjeta.AutoSize = True
        Me.CBtarjeta.BackColor = System.Drawing.Color.Salmon
        Me.CBtarjeta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CBtarjeta.Location = New System.Drawing.Point(127, 256)
        Me.CBtarjeta.Name = "CBtarjeta"
        Me.CBtarjeta.Size = New System.Drawing.Size(82, 23)
        Me.CBtarjeta.TabIndex = 10
        Me.CBtarjeta.Text = "Tarjeta"
        Me.CBtarjeta.UseVisualStyleBackColor = False
        '
        'CBefectivo
        '
        Me.CBefectivo.AutoSize = True
        Me.CBefectivo.BackColor = System.Drawing.Color.Salmon
        Me.CBefectivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CBefectivo.Location = New System.Drawing.Point(127, 212)
        Me.CBefectivo.Name = "CBefectivo"
        Me.CBefectivo.Size = New System.Drawing.Size(87, 23)
        Me.CBefectivo.TabIndex = 9
        Me.CBefectivo.Text = "Efectivo"
        Me.CBefectivo.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(127, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Forma de Pago:"
        '
        'TXTdías
        '
        Me.TXTdías.Location = New System.Drawing.Point(263, 109)
        Me.TXTdías.Name = "TXTdías"
        Me.TXTdías.Size = New System.Drawing.Size(100, 26)
        Me.TXTdías.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad de días:"
        '
        'CMBmarca
        '
        Me.CMBmarca.FormattingEnabled = True
        Me.CMBmarca.Items.AddRange(New Object() {"Honda", "Mercedes Benz", "Toyota", "Mazda"})
        Me.CMBmarca.Location = New System.Drawing.Point(684, 113)
        Me.CMBmarca.Name = "CMBmarca"
        Me.CMBmarca.Size = New System.Drawing.Size(147, 27)
        Me.CMBmarca.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(501, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccione la marca:"
        '
        'TXTplaca
        '
        Me.TXTplaca.Location = New System.Drawing.Point(685, 42)
        Me.TXTplaca.Name = "TXTplaca"
        Me.TXTplaca.Size = New System.Drawing.Size(146, 26)
        Me.TXTplaca.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Placa del Auto:"
        '
        'TXTnit
        '
        Me.TXTnit.Location = New System.Drawing.Point(194, 44)
        Me.TXTnit.Name = "TXTnit"
        Me.TXTnit.Size = New System.Drawing.Size(169, 26)
        Me.TXTnit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(123, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nit:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSalmon
        Me.GroupBox2.Location = New System.Drawing.Point(3, 348)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(986, 248)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista Datos"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 373)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(973, 217)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Placa"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Marca"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Dias de alquiler"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Pago Parcial"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'BTNcalcular
        '
        Me.BTNcalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BTNcalcular.Location = New System.Drawing.Point(1089, 217)
        Me.BTNcalcular.Name = "BTNcalcular"
        Me.BTNcalcular.Size = New System.Drawing.Size(106, 106)
        Me.BTNcalcular.TabIndex = 2
        Me.BTNcalcular.Text = "Calcular"
        Me.BTNcalcular.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.MenuPrincipal.BackColor = System.Drawing.Color.Bisque
        Me.MenuPrincipal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.MenuPrincipal.Name = "MenuPrincipal"
        Me.MenuPrincipal.Size = New System.Drawing.Size(1402, 28)
        Me.MenuPrincipal.TabIndex = 5
        Me.MenuPrincipal.Text = "MenuStrip1"
        '
        'ProcesosToolStripMenuItem
        '
        Me.ProcesosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarEntradasToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem})
        Me.ProcesosToolStripMenuItem.Name = "ProcesosToolStripMenuItem"
        Me.ProcesosToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ProcesosToolStripMenuItem.Text = "Procesos"
        '
        'LimpiarEntradasToolStripMenuItem
        '
        Me.LimpiarEntradasToolStripMenuItem.Name = "LimpiarEntradasToolStripMenuItem"
        Me.LimpiarEntradasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LimpiarEntradasToolStripMenuItem.Text = "Limpiar Entradas"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Descuento"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Recargo"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago Final"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201903573_RENTAUTOS.My.Resources.Resources.rentcar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1402, 994)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTNcalcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuPrincipal)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Salmon
        Me.MainMenuStrip = Me.MenuPrincipal
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPrincipal.ResumeLayout(False)
        Me.MenuPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTporcentajeEfectivo As TextBox
    Friend WithEvents TXTporcentajeTarjeta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CBtarjeta As CheckBox
    Friend WithEvents CBefectivo As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTdías As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTplaca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTnit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents BTNcalcular As Button
    Friend WithEvents CMBmarca As ComboBox
    Friend WithEvents MenuPrincipal As MenuStrip
    Friend WithEvents ProcesosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarEntradasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
