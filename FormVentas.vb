Imports System.Windows.Forms
Imports System.Data.SQLite
Imports System.Data

Public Class FormVentas
    Inherits Form

    Private dtCarrito As New DataTable()

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ConfigurarCarrito()
    End Sub

    Private Sub CargarCombos()
        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            ' Clientes
            Dim daC As New SQLiteDataAdapter("SELECT Id, Nombre FROM Clientes", conn)
            Dim dtC As New DataTable()
            daC.Fill(dtC)
            cmbClientes.DataSource = dtC
            cmbClientes.DisplayMember = "Nombre"
            cmbClientes.ValueMember = "Id"

            ' Productos
            Dim daP As New SQLiteDataAdapter("SELECT Id, Nombre, Precio FROM Productos", conn)
            Dim dtP As New DataTable()
            daP.Fill(dtP)
            cmbProductos.DataSource = dtP
            cmbProductos.DisplayMember = "Nombre"
            cmbProductos.ValueMember = "Id"
        End Using
    End Sub

    Private Sub ConfigurarCarrito()
        dtCarrito.Columns.Add("Id")
        dtCarrito.Columns.Add("Producto")
        dtCarrito.Columns.Add("Precio", GetType(Decimal))
        dtCarrito.Columns.Add("Cantidad", GetType(Integer))
        dtCarrito.Columns.Add("Subtotal", GetType(Decimal))
        dgvCarrito.DataSource = dtCarrito
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        Dim rowProd As DataRowView = cmbProductos.SelectedItem
        dgvCarrito.DataSource = Nothing ' Detach for update
        
        Dim id As Integer = rowProd("Id")
        Dim nombre As String = rowProd("Nombre")
        Dim precio As Decimal = rowProd("Precio")
        Dim cant As Integer = Convert.ToInt32(nudCantidad.Value)
        Dim subtotal As Decimal = precio * cant

        dtCarrito.Rows.Add(id, nombre, precio, cant, subtotal)
        dgvCarrito.DataSource = dtCarrito
        CalcularTotal()
    End Sub

    Private Sub CalcularTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In dtCarrito.Rows
            total += row("Subtotal")
        Next
        lblTotal.Text = "TOTAL: $" & total.ToString("N2")
    End Sub

    Private Sub BtnFinalizar_Click(sender As Object, e As EventArgs)
        If dtCarrito.Rows.Count = 0 Then Return

        Using conn = DatabaseHelper.GetConnection()
            conn.Open()
            Dim trans = conn.BeginTransaction()
            Try
                ' Create Sale
                Dim sqlVenta = "INSERT INTO Ventas (ClienteId, Total) VALUES (@Cli, @Tot); SELECT last_insert_rowid();"
                Dim cmdV = New SQLiteCommand(sqlVenta, conn)
                cmdV.Parameters.AddWithValue("@Cli", cmbClientes.SelectedValue)
                cmdV.Parameters.AddWithValue("@Tot", 0) ' Will update later or set now
                
                Dim total As Decimal = 0
                For Each row As DataRow In dtCarrito.Rows
                    total += row("Subtotal")
                Next
                cmdV.Parameters("@Tot").Value = total
                
                Dim ventaId = cmdV.ExecuteScalar()

                ' Create Details
                For Each row As DataRow In dtCarrito.Rows
                    Dim sqlDet = "INSERT INTO DetalleVentas (VentaId, ProductoId, Cantidad, PrecioUnitario) VALUES (@Vid, @Pid, @Cant, @Pre)"
                    Dim cmdD = New SQLiteCommand(sqlDet, conn)
                    cmdD.Parameters.AddWithValue("@Vid", ventaId)
                    cmdD.Parameters.AddWithValue("@Pid", row("Id"))
                    cmdD.Parameters.AddWithValue("@Cant", row("Cantidad"))
                    cmdD.Parameters.AddWithValue("@Pre", row("Precio"))
                    cmdD.ExecuteNonQuery()
                Next

                trans.Commit()
                MessageBox.Show("Venta Generada Exitosamente. Factura #" & ventaId)
                dtCarrito.Clear()
                lblTotal.Text = "TOTAL: $0.00"
            Catch ex As Exception
                trans.Rollback()
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
