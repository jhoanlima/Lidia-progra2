<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cliente
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
        Me.BTNprestados = New System.Windows.Forms.Button()
        Me.BTNprestar = New System.Windows.Forms.Button()
        Me.BTNeditarPerfil = New System.Windows.Forms.Button()
        Me.BTNcerrar = New System.Windows.Forms.Button()
        Me.BTNregresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNprestados
        '
        Me.BTNprestados.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTNprestados.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNprestados.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNprestados.Location = New System.Drawing.Point(388, 127)
        Me.BTNprestados.Name = "BTNprestados"
        Me.BTNprestados.Size = New System.Drawing.Size(414, 128)
        Me.BTNprestados.TabIndex = 0
        Me.BTNprestados.Text = "Libros Prestados"
        Me.BTNprestados.UseVisualStyleBackColor = False
        '
        'BTNprestar
        '
        Me.BTNprestar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTNprestar.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNprestar.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNprestar.Location = New System.Drawing.Point(388, 305)
        Me.BTNprestar.Name = "BTNprestar"
        Me.BTNprestar.Size = New System.Drawing.Size(414, 128)
        Me.BTNprestar.TabIndex = 1
        Me.BTNprestar.Text = "Prestar Libros"
        Me.BTNprestar.UseVisualStyleBackColor = False
        '
        'BTNeditarPerfil
        '
        Me.BTNeditarPerfil.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BTNeditarPerfil.Font = New System.Drawing.Font("Berlin Sans FB", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNeditarPerfil.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.BTNeditarPerfil.Location = New System.Drawing.Point(388, 494)
        Me.BTNeditarPerfil.Name = "BTNeditarPerfil"
        Me.BTNeditarPerfil.Size = New System.Drawing.Size(414, 128)
        Me.BTNeditarPerfil.TabIndex = 2
        Me.BTNeditarPerfil.Text = "Editar Perfil"
        Me.BTNeditarPerfil.UseVisualStyleBackColor = False
        '
        'BTNcerrar
        '
        Me.BTNcerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BTNcerrar.ForeColor = System.Drawing.Color.Red
        Me.BTNcerrar.Location = New System.Drawing.Point(894, 638)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(203, 67)
        Me.BTNcerrar.TabIndex = 6
        Me.BTNcerrar.Text = "Cerrar Sesión"
        Me.BTNcerrar.UseVisualStyleBackColor = False
        '
        'BTNregresar
        '
        Me.BTNregresar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTNregresar.Font = New System.Drawing.Font("Berlin Sans FB", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNregresar.Location = New System.Drawing.Point(894, 562)
        Me.BTNregresar.Name = "BTNregresar"
        Me.BTNregresar.Size = New System.Drawing.Size(199, 60)
        Me.BTNregresar.TabIndex = 15
        Me.BTNregresar.Text = "REGRESAR"
        Me.BTNregresar.UseVisualStyleBackColor = False
        Me.BTNregresar.UseWaitCursor = True
        '
        'cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PROYECTO_201903573.My.Resources.Resources.cliente
        Me.ClientSize = New System.Drawing.Size(1200, 731)
        Me.Controls.Add(Me.BTNregresar)
        Me.Controls.Add(Me.BTNcerrar)
        Me.Controls.Add(Me.BTNeditarPerfil)
        Me.Controls.Add(Me.BTNprestar)
        Me.Controls.Add(Me.BTNprestados)
        Me.Font = New System.Drawing.Font("Berlin Sans FB", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "cliente"
        Me.Text = "cliente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNprestados As Button
    Friend WithEvents BTNprestar As Button
    Friend WithEvents BTNeditarPerfil As Button
    Friend WithEvents BTNcerrar As Button
    Friend WithEvents BTNregresar As Button
End Class
