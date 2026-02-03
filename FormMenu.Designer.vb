<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblEmpresa = New System.Windows.Forms.Label()
        Me.lblRIF = New System.Windows.Forms.Label()
        Me.picLogoMain = New System.Windows.Forms.PictureBox()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.picLogoMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogoMain
        '
        Me.picLogoMain.Location = New System.Drawing.Point(190, 20)
        Me.picLogoMain.Name = "picLogoMain"
        Me.picLogoMain.Size = New System.Drawing.Size(200, 120)
        Me.picLogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogoMain.TabIndex = 2
        Me.picLogoMain.TabStop = False
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.pnlSidebar.Controls.Add(Me.btnSalir)
        Me.pnlSidebar.Controls.Add(Me.btnVentas)
        Me.pnlSidebar.Controls.Add(Me.btnProductos)
        Me.pnlSidebar.Controls.Add(Me.btnClientes)
        Me.pnlSidebar.Controls.Add(Me.lblLogo)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 500)
        Me.pnlSidebar.TabIndex = 0
        '
        'lblLogo
        '
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblLogo.ForeColor = System.Drawing.Color.White
        Me.lblLogo.Location = New System.Drawing.Point(12, 20)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(196, 80)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "SERVI EMPAQ"
        Me.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(10, 130)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(200, 45)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Gestionar Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        AddHandler Me.btnClientes.Click, AddressOf Me.BtnClientes_Click
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Location = New System.Drawing.Point(10, 190)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(200, 45)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "Gestionar Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        AddHandler Me.btnProductos.Click, AddressOf Me.BtnProductos_Click
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnVentas.ForeColor = System.Drawing.Color.White
        Me.btnVentas.Location = New System.Drawing.Point(10, 250)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(200, 45)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Generar Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        AddHandler Me.btnVentas.Click, AddressOf Me.BtnVentas_Click
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(0, 455)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(220, 45)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        AddHandler Me.btnSalir.Click, AddressOf Me.BtnSalir_Click
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(233, 237, 236)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(220, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(580, 60)
        Me.pnlHeader.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(27, 67, 50)
        Me.lblTitle.Location = New System.Drawing.Point(20, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(320, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Sistema de Gestión de Empaques C.A."
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Controls.Add(Me.picLogoMain)
        Me.pnlMain.Controls.Add(Me.lblRIF)
        Me.pnlMain.Controls.Add(Me.lblEmpresa)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(220, 60)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(580, 440)
        Me.pnlMain.TabIndex = 2
        '
        'lblEmpresa
        '
        Me.lblEmpresa.AutoSize = True
        Me.lblEmpresa.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(45, 106, 79)
        Me.lblEmpresa.Location = New System.Drawing.Point(44, 153)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(491, 45)
        Me.lblEmpresa.TabIndex = 0
        Me.lblEmpresa.Text = "INVERSIONES SERVI EMPAQ C.A."
        '
        'lblRIF
        '
        Me.lblRIF.AutoSize = True
        Me.lblRIF.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblRIF.ForeColor = System.Drawing.Color.Gray
        Me.lblRIF.Location = New System.Drawing.Point(215, 205)
        Me.lblRIF.Name = "lblRIF"
        Me.lblRIF.Size = New System.Drawing.Size(149, 25)
        Me.lblRIF.TabIndex = 1
        Me.lblRIF.Text = "J - 412814680"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servi Empaq - Menú Principal"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.picLogoMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents lblLogo As System.Windows.Forms.Label
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnProductos As System.Windows.Forms.Button
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblEmpresa As System.Windows.Forms.Label
    Friend WithEvents lblRIF As System.Windows.Forms.Label
    Friend WithEvents picLogoMain As System.Windows.Forms.PictureBox
End Class
