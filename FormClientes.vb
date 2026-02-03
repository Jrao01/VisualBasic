Imports System.Windows.Forms
Imports System.Data.SQLite
Imports System.Data

Public Class FormClientes
    Inherits Form

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    Private Sub CargarClientes()
        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Clientes", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvClientes.DataSource = dt
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        If txtNombre.Text = "" Or txtRIF.Text = "" Then
            MessageBox.Show("Por favor complete los campos obligatorios")
            Return
        End If

        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO Clientes (Nombre, RIF, Direccion, Telefono) VALUES (@Nom, @RIF, @Dir, @Tel)"
            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Nom", txtNombre.Text)
            cmd.Parameters.AddWithValue("@RIF", txtRIF.Text)
            cmd.Parameters.AddWithValue("@Dir", txtDireccion.Text)
            cmd.Parameters.AddWithValue("@Tel", txtTelefono.Text)
            cmd.ExecuteNonQuery()
        End Using

        CargarClientes()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear()
        txtRIF.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
    End Sub
End Class
