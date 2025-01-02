<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnIrAPrimero = New System.Windows.Forms.Button()
        Me.btnIrAAnterior = New System.Windows.Forms.Button()
        Me.btnIrASiguiente = New System.Windows.Forms.Button()
        Me.btnIrAUltimo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevoRegistro = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.grpNuevoRegistro = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumIdNuevo = New System.Windows.Forms.TextBox()
        Me.txtNombreNuevoContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdClienteNuevo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefonoNuevo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpNuevoRegistro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "IdCliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "NumId"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(66, 30)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(270, 20)
        Me.txtNombres.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(66, 66)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(270, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(66, 100)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtIdCliente.TabIndex = 6
        '
        'txtNumId
        '
        Me.txtNumId.Location = New System.Drawing.Point(66, 137)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(100, 20)
        Me.txtNumId.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumId)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 195)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Cliente"
        '
        'btnIrAPrimero
        '
        Me.btnIrAPrimero.Location = New System.Drawing.Point(12, 213)
        Me.btnIrAPrimero.Name = "btnIrAPrimero"
        Me.btnIrAPrimero.Size = New System.Drawing.Size(32, 23)
        Me.btnIrAPrimero.TabIndex = 9
        Me.btnIrAPrimero.Text = "<<"
        Me.btnIrAPrimero.UseVisualStyleBackColor = True
        '
        'btnIrAAnterior
        '
        Me.btnIrAAnterior.Location = New System.Drawing.Point(50, 213)
        Me.btnIrAAnterior.Name = "btnIrAAnterior"
        Me.btnIrAAnterior.Size = New System.Drawing.Size(32, 23)
        Me.btnIrAAnterior.TabIndex = 10
        Me.btnIrAAnterior.Text = "<"
        Me.btnIrAAnterior.UseVisualStyleBackColor = True
        '
        'btnIrASiguiente
        '
        Me.btnIrASiguiente.Location = New System.Drawing.Point(88, 213)
        Me.btnIrASiguiente.Name = "btnIrASiguiente"
        Me.btnIrASiguiente.Size = New System.Drawing.Size(32, 23)
        Me.btnIrASiguiente.TabIndex = 11
        Me.btnIrASiguiente.Text = ">"
        Me.btnIrASiguiente.UseVisualStyleBackColor = True
        '
        'btnIrAUltimo
        '
        Me.btnIrAUltimo.Location = New System.Drawing.Point(126, 213)
        Me.btnIrAUltimo.Name = "btnIrAUltimo"
        Me.btnIrAUltimo.Size = New System.Drawing.Size(32, 23)
        Me.btnIrAUltimo.TabIndex = 12
        Me.btnIrAUltimo.Text = ">>"
        Me.btnIrAUltimo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(164, 213)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(54, 23)
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnNuevoRegistro
        '
        Me.btnNuevoRegistro.Location = New System.Drawing.Point(295, 166)
        Me.btnNuevoRegistro.Name = "btnNuevoRegistro"
        Me.btnNuevoRegistro.Size = New System.Drawing.Size(55, 23)
        Me.btnNuevoRegistro.TabIndex = 14
        Me.btnNuevoRegistro.Text = "&Nuevo"
        Me.btnNuevoRegistro.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(224, 213)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(43, 23)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "&Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'grpNuevoRegistro
        '
        Me.grpNuevoRegistro.Controls.Add(Me.btnLimpiar)
        Me.grpNuevoRegistro.Controls.Add(Me.Label5)
        Me.grpNuevoRegistro.Controls.Add(Me.txtNumIdNuevo)
        Me.grpNuevoRegistro.Controls.Add(Me.btnNuevoRegistro)
        Me.grpNuevoRegistro.Controls.Add(Me.txtNombreNuevoContacto)
        Me.grpNuevoRegistro.Controls.Add(Me.Label6)
        Me.grpNuevoRegistro.Controls.Add(Me.txtIdClienteNuevo)
        Me.grpNuevoRegistro.Controls.Add(Me.Label7)
        Me.grpNuevoRegistro.Controls.Add(Me.txtTelefonoNuevo)
        Me.grpNuevoRegistro.Controls.Add(Me.Label8)
        Me.grpNuevoRegistro.Location = New System.Drawing.Point(400, 12)
        Me.grpNuevoRegistro.Name = "grpNuevoRegistro"
        Me.grpNuevoRegistro.Size = New System.Drawing.Size(356, 195)
        Me.grpNuevoRegistro.TabIndex = 16
        Me.grpNuevoRegistro.TabStop = False
        Me.grpNuevoRegistro.Text = "Nuevo Registro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombres"
        '
        'txtNumIdNuevo
        '
        Me.txtNumIdNuevo.Location = New System.Drawing.Point(66, 137)
        Me.txtNumIdNuevo.Name = "txtNumIdNuevo"
        Me.txtNumIdNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtNumIdNuevo.TabIndex = 7
        '
        'txtNombreNuevoContacto
        '
        Me.txtNombreNuevoContacto.Location = New System.Drawing.Point(66, 30)
        Me.txtNombreNuevoContacto.Name = "txtNombreNuevoContacto"
        Me.txtNombreNuevoContacto.Size = New System.Drawing.Size(270, 20)
        Me.txtNombreNuevoContacto.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "NumId"
        '
        'txtIdClienteNuevo
        '
        Me.txtIdClienteNuevo.Location = New System.Drawing.Point(66, 100)
        Me.txtIdClienteNuevo.Name = "txtIdClienteNuevo"
        Me.txtIdClienteNuevo.Size = New System.Drawing.Size(100, 20)
        Me.txtIdClienteNuevo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Telefono"
        '
        'txtTelefonoNuevo
        '
        Me.txtTelefonoNuevo.Location = New System.Drawing.Point(66, 66)
        Me.txtTelefonoNuevo.Name = "txtTelefonoNuevo"
        Me.txtTelefonoNuevo.Size = New System.Drawing.Size(270, 20)
        Me.txtTelefonoNuevo.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "IdCliente"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 166)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(49, 23)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "&Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 450)
        Me.Controls.Add(Me.grpNuevoRegistro)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnIrAUltimo)
        Me.Controls.Add(Me.btnIrASiguiente)
        Me.Controls.Add(Me.btnIrAAnterior)
        Me.Controls.Add(Me.btnIrAPrimero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormPrincipal"
        Me.Text = "EJEMPLO DE BASES DE DATOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpNuevoRegistro.ResumeLayout(False)
        Me.grpNuevoRegistro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIrAPrimero As Button
    Friend WithEvents btnIrAAnterior As Button
    Friend WithEvents btnIrASiguiente As Button
    Friend WithEvents btnIrAUltimo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnNuevoRegistro As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents grpNuevoRegistro As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNumIdNuevo As TextBox
    Friend WithEvents txtNombreNuevoContacto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdClienteNuevo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTelefonoNuevo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLimpiar As Button
End Class
