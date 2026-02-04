<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVentas
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.nudCantidad = New System.Windows.Forms.NumericUpDown()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.dgvCarrito = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.lblCli = New System.Windows.Forms.Label()
        Me.lblProd = New System.Windows.Forms.Label()
        Me.lblCant = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(12, 70)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(250, 23)
        Me.cmbClientes.TabIndex = 0
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(12, 120)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(200, 23)
        Me.cmbProductos.TabIndex = 1
        '
        'nudCantidad
        '
        Me.nudCantidad.Location = New System.Drawing.Point(220, 121)
        Me.nudCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCantidad.Name = "nudCantidad"
        Me.nudCantidad.Size = New System.Drawing.Size(60, 23)
        Me.nudCantidad.TabIndex = 2
        Me.nudCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(290, 118)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        AddHandler Me.btnAgregar.Click, AddressOf Me.BtnAgregar_Click
        '
        'dgvCarrito
        '
        Me.dgvCarrito.AllowUserToAddRows = False
        Me.dgvCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCarrito.BackgroundColor = System.Drawing.Color.White
        Me.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarrito.Location = New System.Drawing.Point(12, 160)
        Me.dgvCarrito.Name = "dgvCarrito"
        Me.dgvCarrito.Size = New System.Drawing.Size(760, 240)
        Me.dgvCarrito.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.lblTotal.Location = New System.Drawing.Point(522, 415)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(250, 30)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "TOTAL: Bs0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnVolver
        '
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnVolver.BackColor = System.Drawing.Color.Gray
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnVolver.ForeColor = System.Drawing.Color.White
        Me.btnVolver.Location = New System.Drawing.Point(12, 415)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(100, 35)
        Me.btnVolver.TabIndex = 10
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(12, 410)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(200, 40)
        Me.btnFinalizar.TabIndex = 6
        Me.btnFinalizar.Text = "Finalizar Venta (Facturar)"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        AddHandler Me.btnFinalizar.Click, AddressOf Me.BtnFinalizar_Click
        '
        'lblCli
        '
        Me.lblCli.AutoSize = True
        Me.lblCli.Location = New System.Drawing.Point(12, 50)
        Me.lblCli.Name = "lblCli"
        Me.lblCli.Size = New System.Drawing.Size(107, 15)
        Me.lblCli.TabIndex = 7
        Me.lblCli.Text = "Seleccionar Cliente:"
        '
        'lblProd
        '
        Me.lblProd.AutoSize = True
        Me.lblProd.Location = New System.Drawing.Point(12, 100)
        Me.lblProd.Name = "lblProd"
        Me.lblProd.Size = New System.Drawing.Size(59, 15)
        Me.lblProd.TabIndex = 8
        Me.lblProd.Text = "Producto:"
        '
        'lblCant
        '
        Me.lblCant.AutoSize = True
        Me.lblCant.Location = New System.Drawing.Point(220, 100)
        Me.lblCant.Name = "lblCant"
        Me.lblCant.Size = New System.Drawing.Size(35, 15)
        Me.lblCant.TabIndex = 9
        Me.lblCant.Text = "Cant:"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.lblHeader.Location = New System.Drawing.Point(12, 10)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(217, 25)
        Me.lblHeader.TabIndex = 10
        Me.lblHeader.Text = "Generar Nueva Factura"
        '
        'FormVentas
        '
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblCant)
        Me.Controls.Add(Me.lblProd)
        Me.Controls.Add(Me.lblCli)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvCarrito)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.nudCantidad)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.cmbClientes)
        Me.Name = "FormVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servi Empaq - Ventas"
        CType(Me.nudCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
    Friend WithEvents nudCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dgvCarrito As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblCli As System.Windows.Forms.Label
    Friend WithEvents lblProd As System.Windows.Forms.Label
    Friend WithEvents lblCant As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.Label
End Class
