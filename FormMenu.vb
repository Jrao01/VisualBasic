Imports System.Windows.Forms
Imports System.Drawing

Public Class FormMenu
    Inherits Form

    Private UserRole As String

    Public Sub New()
        InitializeComponent()
        Init()
    End Sub

    Public Sub New(role As String)
        InitializeComponent()
        UserRole = role
        Init()
    End Sub

    Private Sub Init()
        ' Initialize database
        DatabaseHelper.InitializeDatabase()

        ' Load logo
        Try
            If System.IO.File.Exists("logo.jpeg") Then
                picLogoMain.Image = Image.FromFile("logo.jpeg")
            End If
        Catch ex As Exception
            ' Ignore if image not found
        End Try

        ' Center Logo
        CenterLogo()
        AddHandler Me.Resize, AddressOf FormMenu_Resize
        
        ' Apply Role Restrictions if any (Example: Salesperson cannot manage products)
        If UserRole = "Vendedor" Then
             ' Example: Maybe hide Product management or restrict it. 
             ' User didn't specify restrictions, just identification.
             ' I'll just show the role in title
             Me.Text = "ServiEmpaq - Vendedor"
        ElseIf UserRole = "Gerente" Then
             Me.Text = "ServiEmpaq - Gerente"
        End If
    End Sub

    Private Sub CenterLogo()
        If pnlMain IsNot Nothing AndAlso picLogoMain IsNot Nothing Then
            picLogoMain.Left = (pnlMain.Width - picLogoMain.Width) \ 2
            ' picLogoMain.Top = 20 ' Keep top position or center vertically too? User said "centered", usually means horizontally in this context or dead center.
            ' I'll center horizontally as per standard UI for logos in headers/main panels.
        End If
    End Sub

    Private Sub FormMenu_Resize(sender As Object, e As EventArgs)
        CenterLogo()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim f As New FormClientes()
        f.ShowDialog()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim f As New FormProductos()
        f.ShowDialog()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim f As New FormVentas()
        f.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub
End Class
