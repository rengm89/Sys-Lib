Imports System.Data.OleDb
Public Class frm020ModificarIdioma
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim nombre As String = BuscarIdioma(txtCodigo.Text)
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
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            ModificarIdioma()
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub
    Private Sub ModificarIdioma()
        Dim SQL As String = ""
        SQL = "update idioma set Nombre= '" & txtNombre.Text & "' where IdIdioma = " & txtCodigo.Text
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = SQL
        Comando.ExecuteReader()
        Conexion.Close()
        MessageBox.Show("Dato Modificado")
    End Sub


    Public Function BuscarIdioma(Cod As Integer) As String
        Dim Resultado As String = ""

        Dim ConexionIdioma As New OleDb.OleDbConnection
        Dim ComandoIdioma As New OleDb.OleDbCommand
        Dim DRIdioma As OleDbDataReader

        ConexionIdioma.ConnectionString = CadenaDeConexion
        ConexionIdioma.Open()

        ComandoIdioma.Connection = ConexionIdioma
        ComandoIdioma.CommandType = CommandType.TableDirect
        ComandoIdioma.CommandText = "Idioma"
        DRIdioma = ComandoIdioma.ExecuteReader
        If DRIdioma.HasRows Then
            Do While DRIdioma.Read
                If DRIdioma("IdIdioma") = Cod Then
                    Resultado = DRIdioma("Nombre")
                End If
            Loop


        End If
        ConexionIdioma.Close()
        Return Resultado
    End Function

    Private Sub frm020ModificarIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class