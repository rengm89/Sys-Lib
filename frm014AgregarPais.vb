﻿Imports System.Data.OleDb
Public Class frm014AgregarPais
    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Pais"

            Adaptador = New OleDb.OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim Tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = Tabla.NewRow()
            Fila("Nombre") = txtNombre.Text
            Tabla.Rows.Add(Fila)

            Dim ComandoParaGrabar As New OleDbCommandBuilder(Adaptador)
            Adaptador.Update(DS)

            Conexion.Close()
            MessageBox.Show("Datos Grabados")
        Catch ex As Exception
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub frm014AgregarPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class