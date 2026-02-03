<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblRIF = New System.Windows.Forms.Label()
        Me.txtRIF = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AllowUserToAddRows = False
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(12, 210)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(760, 240)
        Me.dgvClientes.TabIndex = 0
        '
        'pnlInputs
        '
        Me.pnlInputs.BackColor = System.Drawing.Color.FromArgb(233, 237, 236)
        Me.pnlInputs.Controls.Add(Me.btnGuardar)
        Me.pnlInputs.Controls.Add(Me.txtTelefono)
        Me.pnlInputs.Controls.Add(Me.lblTelefono)
        Me.pnlInputs.Controls.Add(Me.txtDireccion)
        Me.pnlInputs.Controls.Add(Me.lblDireccion)
        Me.pnlInputs.Controls.Add(Me.txtRIF)
        Me.pnlInputs.Controls.Add(Me.lblRIF)
        Me.pnlInputs.Controls.Add(Me.txtNombre)
        Me.pnlInputs.Controls.Add(Me.lblNombre)
        Me.pnlInputs.Location = New System.Drawing.Point(12, 50)
        Me.pnlInputs.Name = "pnlInputs"
        Me.pnlInputs.Size = New System.Drawing.Size(760, 140)
        Me.pnlInputs.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(15, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 35)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 23)
        Me.txtNombre.TabIndex = 1
        '
        'lblRIF
        '
        Me.lblRIF.AutoSize = True
        Me.lblRIF.Location = New System.Drawing.Point(230, 15)
        Me.lblRIF.Name = "lblRIF"
        Me.lblRIF.Size = New System.Drawing.Size(26, 15)
        Me.lblRIF.TabIndex = 2
        Me.lblRIF.Text = "RIF:"
        '
        'txtRIF
        '
        Me.txtRIF.Location = New System.Drawing.Point(230, 35)
        Me.txtRIF.Name = "txtRIF"
        Me.txtRIF.Size = New System.Drawing.Size(150, 23)
        Me.txtRIF.TabIndex = 3
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(15, 75)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 15)
        Me.lblDireccion.TabIndex = 4
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(15, 95)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(365, 23)
        Me.txtDireccion.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(400, 15)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(55, 15)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(400, 35)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(150, 23)
        Me.txtTelefono.TabIndex = 7
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(580, 85)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 40)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar Cliente"
        Me.btnGuardar.UseVisualStyleBackColor = False
        AddHandler Me.btnGuardar.Click, AddressOf Me.BtnGuardar_Click
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.lblHeader.Location = New System.Drawing.Point(12, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(184, 25)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Gestión de Clientes"
        '
        'FormClientes
        '
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pnlInputs)
        Me.Controls.Add(Me.dgvClientes)
        Me.Name = "FormClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servi Empaq - Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInputs.ResumeLayout(False)
        Me.pnlInputs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As System.Windows.Forms.DataGridView
    Friend WithEvents pnlInputs As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblRIF As System.Windows.Forms.Label
    Friend WithEvents txtRIF As System.Windows.Forms.TextBox
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
End Class
