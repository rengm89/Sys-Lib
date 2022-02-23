Imports System.Data.OleDb
Public Class frm017ModificarLibro
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombre As String = BuscarLibro(txtCodigo.Text)
            If nombre <> "" Then
                btnGuardar.Enabled = True
                txtNombre.Enabled = True
                txtCodigo.Enabled = False
                txtNombre.Text = nombre
            Else
                btnGuardar.Enabled = False
                txtNombre.Enabled = False
                txtCodigo.Enabled = True
                MessageBox.Show("El código no existe")
            End If
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ModificarLibro()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try

    End Sub
    Public Function BuscarLibro(Cod As Integer) As String
        Dim Resultado As String = ""

        Dim ConexionLibro As New OleDb.OleDbConnection
        Dim ComandoLibro As New OleDb.OleDbCommand
        Dim DRLibro As OleDbDataReader

        ConexionLibro.ConnectionString = CadenaDeConexion
        ConexionLibro.Open()

        ComandoLibro.Connection = ConexionLibro
        ComandoLibro.CommandType = CommandType.TableDirect
        ComandoLibro.CommandText = "Libro"
        DRLibro = ComandoLibro.ExecuteReader
        If DRLibro.HasRows Then
            Do While DRLibro.Read
                If DRLibro("IdLibro") = Cod Then
                    Resultado = DRLibro("Titulo")
                End If
            Loop


        End If
        ConexionLibro.Close()
        Return Resultado
    End Function

    Private Sub ModificarLibro()
        Dim SQL As String = ""
        SQL = "update libro set Titulo= '" & txtNombre.Text & "' where IdLibro = " & txtCodigo.Text
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = SQL
        Comando.ExecuteReader()
        Conexion.Close()
        MessageBox.Show("Dato Modificado")
    End Sub
End Class