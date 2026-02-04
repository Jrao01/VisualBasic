<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlInputs = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDim = New System.Windows.Forms.Label()
        Me.txtDimensiones = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(12, 210)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(760, 240)
        Me.dgvProductos.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(12, 460)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 35)
        Me.btnVolver.TabIndex = 2
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'pnlInputs
        '
        Me.pnlInputs.BackColor = System.Drawing.Color.FromArgb(233, 237, 236)
        Me.pnlInputs.Controls.Add(Me.btnGuardar)
        Me.pnlInputs.Controls.Add(Me.txtStock)
        Me.pnlInputs.Controls.Add(Me.lblStock)
        Me.pnlInputs.Controls.Add(Me.txtPrecio)
        Me.pnlInputs.Controls.Add(Me.lblPrecio)
        Me.pnlInputs.Controls.Add(Me.txtDimensiones)
        Me.pnlInputs.Controls.Add(Me.lblDim)
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
        'lblDim
        '
        Me.lblDim.AutoSize = True
        Me.lblDim.Location = New System.Drawing.Point(230, 15)
        Me.lblDim.Name = "lblDim"
        Me.lblDim.Size = New System.Drawing.Size(78, 15)
        Me.lblDim.TabIndex = 2
        Me.lblDim.Text = "Dimensiones:"
        '
        'txtDimensiones
        '
        Me.txtDimensiones.Location = New System.Drawing.Point(230, 35)
        Me.txtDimensiones.Name = "txtDimensiones"
        Me.txtDimensiones.Size = New System.Drawing.Size(150, 23)
        Me.txtDimensiones.TabIndex = 3
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(15, 75)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(43, 15)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "Precio:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(15, 95)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 23)
        Me.txtPrecio.TabIndex = 5
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Location = New System.Drawing.Point(130, 75)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(39, 15)
        Me.lblStock.TabIndex = 6
        Me.lblStock.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(130, 95)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(85, 23)
        Me.txtStock.TabIndex = 7
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
        Me.btnGuardar.Text = "Guardar Producto"
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
        Me.lblHeader.Size = New System.Drawing.Size(201, 25)
        Me.lblHeader.TabIndex = 2
        Me.lblHeader.Text = "Gestión de Productos"
        '
        'FormProductos
        '
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pnlInputs)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.btnVolver)
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servi Empaq - Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInputs.ResumeLayout(False)
        Me.pnlInputs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents pnlInputs As System.Windows.Forms.Panel
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblDim As System.Windows.Forms.Label
    Friend WithEvents txtDimensiones As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
