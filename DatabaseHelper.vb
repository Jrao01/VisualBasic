Imports System.Data.SQLite
Imports System.IO

Public Class DatabaseHelper
    Private Shared connectionString As String = "Data Source=ServiEmpaq.db;Version=3;"

    Public Shared Sub InitializeDatabase()
        If Not File.Exists("ServiEmpaq.db") Then
            SQLiteConnection.CreateFile("ServiEmpaq.db")
        End If

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim sql As String = "
                CREATE TABLE IF NOT EXISTS Clientes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    RIF TEXT NOT NULL UNIQUE,
                    Direccion TEXT,
                    Telefono TEXT
                );
                CREATE TABLE IF NOT EXISTS Productos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Dimensiones TEXT,
                    Precio REAL NOT NULL,
                    Stock INTEGER DEFAULT 0
                );
                CREATE TABLE IF NOT EXISTS Ventas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClienteId INTEGER,
                    Fecha TEXT DEFAULT CURRENT_TIMESTAMP,
                    Total REAL,
                    FOREIGN KEY(ClienteId) REFERENCES Clientes(Id)
                );
                CREATE TABLE IF NOT EXISTS DetalleVentas (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    VentaId INTEGER,
                    ProductoId INTEGER,
                    Cantidad INTEGER,
                    PrecioUnitario REAL,
                    FOREIGN KEY(VentaId) REFERENCES Ventas(Id),
                    FOREIGN KEY(ProductoId) REFERENCES Productos(Id)
                );"
            Dim cmd As New SQLiteCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Function GetConnection() As SQLiteConnection
        Return New SQLiteConnection(connectionString)
    End Function
End Class
