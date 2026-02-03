Imports System
Imports System.Windows.Forms

Namespace ServiEmpaqSystem
    Friend Class Program
        <STAThread>
        Shared Sub Main()
            Try
                Application.SetHighDpiMode(HighDpiMode.SystemAware)
                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)
                Application.Run(New FormMenu())
            Catch ex As Exception
                System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "startup_error.txt"), ex.ToString())
                MessageBox.Show("Error al iniciar: " & ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
    End Class
End Namespace
