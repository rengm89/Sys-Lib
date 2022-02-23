Imports System.IO
Public Class frm006Paises
    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Pais"

        Adaptador = New OleDb.OleDbDataAdapter(Comando)
        DS = New DataSet
        Adaptador.Fill(DS)

        dgvDatos.DataSource = DS.Tables(0)

        Conexion.Close()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim objArchivo As New StreamWriter("DatosExportados6.csv", False, System.Text.Encoding.UTF8)
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Pais"

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
        Dim titulo As String = "Países"



        e.Graphics.DrawString(titulo, LetraTitulo, Brushes.Blue, 80, 40)
        e.Graphics.DrawString("IDPaís", LetraTituloColumna, Brushes.Black, 80, 80)
        e.Graphics.DrawString("País", LetraTituloColumna, Brushes.Black, 380, 80)



        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Pais"

        DR = Comando.ExecuteReader


        If DR.HasRows Then
            Do While DR.Read



                e.Graphics.DrawString(DR("IdPais"), TipoLetra, Brushes.Black, 80, fila)
                e.Graphics.DrawString(DR("Nombre"), TipoLetra, Brushes.Black, 380, fila)


                fila = fila + 15



            Loop


        End If
    End Sub
End Class