Imports System.Windows.Forms
Imports System.Data.SQLite
Imports System.Data

Public Class FormProductos
    Inherits Form

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim adapter As New SQLiteDataAdapter("SELECT * FROM Productos", conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            dgvProductos.DataSource = dt
        End Using
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        If txtNombre.Text = "" Or txtPrecio.Text = "" Then
            MessageBox.Show("Por favor complete los campos obligatorios")
            Return
        End If

        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim sql As String = "INSERT INTO Productos (Nombre, Dimensiones, Precio, Stock) VALUES (@Nom, @Dim, @Pre, @Sto)"
            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.Parameters.AddWithValue("@Nom", txtNombre.Text)
            cmd.Parameters.AddWithValue("@Dim", txtDimensiones.Text)
            cmd.Parameters.AddWithValue("@Pre", Convert.ToDecimal(txtPrecio.Text))
            cmd.Parameters.AddWithValue("@Sto", Convert.ToInt32(txtStock.Text))
            cmd.ExecuteNonQuery()
        End Using

        CargarProductos()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        txtNombre.Clear()
        txtDimensiones.Clear()
        txtPrecio.Clear()
        txtStock.Clear()
    End Sub
End Class
