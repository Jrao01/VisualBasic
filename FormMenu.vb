Imports System.Windows.Forms
Imports System.Drawing

Public Class FormMenu
    Inherits Form

    Public Sub New()
        InitializeComponent()
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
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs)
        Dim f As New FormClientes()
        f.ShowDialog()
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs)
        Dim f As New FormProductos()
        f.ShowDialog()
    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs)
        Dim f As New FormVentas()
        f.ShowDialog()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class
