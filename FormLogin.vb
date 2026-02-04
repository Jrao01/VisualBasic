Imports System.Windows.Forms
Imports System.Data.SQLite

Public Class FormLogin
    Inherits Form

    Public Sub New()
        InitializeComponent()
        DatabaseHelper.InitializeDatabase()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUser.Text.Trim()
        Dim pass As String = txtPass.Text.Trim()

        If String.IsNullOrEmpty(user) OrElse String.IsNullOrEmpty(pass) Then
            MessageBox.Show("Por favor ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT Role FROM Usuarios WHERE Username = @User AND Password = @Pass", conn)
            cmd.Parameters.AddWithValue("@User", user)
            cmd.Parameters.AddWithValue("@Pass", pass)

            Dim role As Object = cmd.ExecuteScalar()

            If role IsNot Nothing Then
                Dim userRole As String = role.ToString()
                Me.Hide()
                Dim menu As New FormMenu(userRole)
                menu.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
    End Sub
End Class
