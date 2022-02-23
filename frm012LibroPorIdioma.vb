﻿Imports System.IO
Public Class frm012LibroPorIdioma
    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "Select top 8 * from TitulosPorIdioma order by CantidadLibro desc"

            DR = Comando.ExecuteReader


            If DR.HasRows Then
                Do While DR.Read
                    dgvDatos.Rows.Add(DR("Nombre"), DR("CantidadLibro"))
                Loop
            End If

            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnGrafico_Click(sender As Object, e As EventArgs) Handles btnGrafico.Click
        Try
            Conexion.ConnectionString = CadenaDeConexion
            Conexion.Open()

            Comando.Connection = Conexion
            Comando.CommandType = CommandType.Text
            Comando.CommandText = "Select top 8 * from TitulosPorIdioma order by CantidadLibro desc"

            DR = Comando.ExecuteReader


            If DR.HasRows Then
                Do While DR.Read
                    Chart1.Series("TitulosPorIdioma").Points.AddXY(DR("Nombre"), DR("CantidadLibro"))
                Loop
            End If

            Conexion.Close()
        Catch ex As Exception
            Conexion.Close()
            MessageBox.Show(ErrorToString)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim objArchivo As New StreamWriter("DatosExportados13.csv", False, System.Text.Encoding.UTF8)
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Select top 8 * from TitulosPorIdioma order by CantidadLibro desc"

        DR = Comando.ExecuteReader


        If DR.HasRows Then
            Do While DR.Read
                objArchivo.Write(DR("Titulo"))

                objArchivo.WriteLine(DR("Cantidad"))
            Loop

        End If
        objArchivo.Close()
        Conexion.Close()
        MessageBox.Show("Datos Exportados")
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        DialogoImpresora.ShowDialog()
        DocumentoImprimir.PrinterSettings = DialogoImpresora.PrinterSettings
        DocumentoImprimir.Print()
    End Sub

    Private Sub DocumentoImprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocumentoImprimir.PrintPage
        Dim LetraTitulo As New Font("Arial", 14)
        Dim LetraTituloColumna As New Font("Arial", 12)
        Dim TipoLetra As New Font("Arial", 10)
        Dim fila As Integer = 100
        Dim titulo As String = "Estadísticas por Idioma"



        e.Graphics.DrawString(titulo, LetraTitulo, Brushes.Blue, 80, 40)
        e.Graphics.DrawString("Idioma", LetraTituloColumna, Brushes.Black, 80, 80)
        e.Graphics.DrawString("Cantidad", LetraTituloColumna, Brushes.Black, 380, 80)

        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "Select top 8 * from TitulosPorIdioma order by CantidadLibro desc"

        DR = Comando.ExecuteReader


        If DR.HasRows Then
            Do While DR.Read
                e.Graphics.DrawString(DR("Nombre"), TipoLetra, Brushes.Black, 80, fila)
                e.Graphics.DrawString(DR("CantidadLibro"), TipoLetra, Brushes.Black, 380, fila)

                fila = fila + 15
            Loop
            Chart1.Printing.PrintPaint(e.Graphics, New Rectangle(480, fila, Chart1.Width, Chart1.Height))
        End If

        Conexion.Close()
    End Sub
End Class