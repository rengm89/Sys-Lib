Imports System.IO
Public Class frm003Libros
    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        Adaptador = New OleDb.OleDbDataAdapter(Comando)
        DS = New DataSet
        Adaptador.Fill(DS)

        dgvDatos.DataSource = DS.Tables(0)

        Conexion.Close()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim objArchivo As New StreamWriter("DatosExportados3.csv", False, System.Text.Encoding.UTF8)
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        DR = Comando.ExecuteReader


        If DR.HasRows Then
            Do While DR.Read
                objArchivo.Write(DR("Titulo"))
                objArchivo.Write(DR("Año"))
                objArchivo.Write(DR("Cantidad"))
                objArchivo.WriteLine(DR("Precio"))
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
        Dim titulo As String = "Libros"



        e.Graphics.DrawString(titulo, LetraTitulo, Brushes.Blue, 80, 40)
        e.Graphics.DrawString("Titulo del Libro", LetraTituloColumna, Brushes.Black, 80, 80)
        e.Graphics.DrawString("Año", LetraTituloColumna, Brushes.Black, 350, 80)
        e.Graphics.DrawString("Cantidad", LetraTituloColumna, Brushes.Black, 580, 80)
        e.Graphics.DrawString("Precio", LetraTituloColumna, Brushes.Black, 680, 80)


        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        DR = Comando.ExecuteReader


        If DR.HasRows Then
            Do While DR.Read



                e.Graphics.DrawString(DR("Titulo"), TipoLetra, Brushes.Black, 80, fila)
                e.Graphics.DrawString(DR("Año"), TipoLetra, Brushes.Black, 350, fila)
                e.Graphics.DrawString(DR("Cantidad"), TipoLetra, Brushes.Black, 580, fila)
                e.Graphics.DrawString(DR("Precio"), TipoLetra, Brushes.Black, 680, fila)

                fila = fila + 15



            Loop


        End If


        Conexion.Close()
    End Sub
End Class