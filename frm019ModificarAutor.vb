Imports System.Data.OleDb
Public Class frm019ModificarAutor
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombre As String = BuscarAutor(txtCodigo.Text)
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
            ModificarAutor()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Public Function BuscarAutor(Cod As Integer) As String
        Dim Resultado As String = ""

        Dim ConexionAutor As New OleDb.OleDbConnection
        Dim ComandoAutor As New OleDb.OleDbCommand
        Dim DRAutor As OleDbDataReader

        ConexionAutor.ConnectionString = CadenaDeConexion
        ConexionAutor.Open()

        ComandoAutor.Connection = ConexionAutor
        ComandoAutor.CommandType = CommandType.TableDirect
        ComandoAutor.CommandText = "Autor"
        DRAutor = ComandoAutor.ExecuteReader
        If DRAutor.HasRows Then
            Do While DRAutor.Read
                If DRAutor("IdAutor") = Cod Then
                    Resultado = DRAutor("Nombre")
                End If
            Loop


        End If
        ConexionAutor.Close()
        Return Resultado
    End Function

    Private Sub ModificarAutor()
        Dim SQL As String = ""
        SQL = "update autor set Nombre= '" & txtNombre.Text & "' where IdAutor = " & txtCodigo.Text
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = SQL
        Comando.ExecuteReader()
        Conexion.Close()
        MessageBox.Show("Dato Modificado")
    End Sub
End Class