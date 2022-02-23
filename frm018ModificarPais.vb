Imports System.Data.OleDb
Public Class frm018ModificarPais
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            Dim nombre As String = BuscarPais(txtCodigo.Text)
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
            ModificarPais()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Public Function BuscarPais(Cod As Integer) As String
        Dim Resultado As String = ""

        Dim ConexionPais As New OleDb.OleDbConnection
        Dim ComandoPais As New OleDb.OleDbCommand
        Dim DRPais As OleDbDataReader

        ConexionPais.ConnectionString = CadenaDeConexion
        ConexionPais.Open()

        ComandoPais.Connection = ConexionPais
        ComandoPais.CommandType = CommandType.TableDirect
        ComandoPais.CommandText = "Pais"
        DRPais = ComandoPais.ExecuteReader
        If DRPais.HasRows Then
            Do While DRPais.Read
                If DRPais("IdPais") = Cod Then
                    Resultado = DRPais("Nombre")
                End If
            Loop


        End If
        ConexionPais.Close()
        Return Resultado
    End Function

    Private Sub ModificarPais()
        Dim SQL As String = ""
        SQL = "update pais set Nombre= '" & txtNombre.Text & "' where IdPais = " & txtCodigo.Text
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = SQL
        Comando.ExecuteReader()
        Conexion.Close()
        MessageBox.Show("Dato Modificado")
    End Sub
End Class