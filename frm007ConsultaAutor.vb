Imports System.IO
Public Class frm007ConsultaAutor
    Private Sub frm007ConsultaAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Autor"


        Adaptador = New OleDb.OleDbDataAdapter(Comando)
        DS = New DataSet
        Adaptador.Fill(DS)

        cmbAutor.DataSource = DS.Tables(0)
        cmbAutor.ValueMember = "IdAutor"
        cmbAutor.DisplayMember = "Nombre"

        Conexion.Close()
    End Sub

    Private Sub btnMostar_Click(sender As Object, e As EventArgs) Handles btnMostar.Click
        Dim cantidad As Integer = 0


        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        DR = Comando.ExecuteReader
        dgvDatos.Rows.Clear()

        If DR.HasRows Then
            Do While DR.Read

                If DR("IdAutor") = cmbAutor.SelectedValue Then
                    dgvDatos.Rows.Add(DR("Titulo"), DR("Año"), DR("Cantidad"), DR("Precio"))

                    cantidad = cantidad + 1
                End If
            Loop


        End If
        lblCantidad.Text = cantidad

        Conexion.Close()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim objArchivo As New StreamWriter("DatosExportados8.csv", False, System.Text.Encoding.UTF8)
        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        DR = Comando.ExecuteReader
        dgvDatos.Rows.Clear()

        If DR.HasRows Then
            Do While DR.Read


                If DR("IdAutor") = cmbAutor.SelectedValue Then
                    objArchivo.Write(DR("Titulo"))
                    objArchivo.Write(DR("Año"))
                    objArchivo.Write(DR("Cantidad"))
                    objArchivo.WriteLine(DR("Precio"))

                End If
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
        Dim titulo As String = "Autor: " & cmbAutor.Text



        e.Graphics.DrawString(titulo, LetraTitulo, Brushes.Blue, 80, 40)
        e.Graphics.DrawString("Titulo del Libro", LetraTituloColumna, Brushes.Black, 80, 80)
        e.Graphics.DrawString("Cantidad", LetraTituloColumna, Brushes.Black, 380, 80)
        e.Graphics.DrawString("Precio", LetraTituloColumna, Brushes.Black, 480, 80)


        Conexion.ConnectionString = CadenaDeConexion
        Conexion.Open()

        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Libro"

        DR = Comando.ExecuteReader
        dgvDatos.Rows.Clear()

        If DR.HasRows Then
            Do While DR.Read

                If DR("IdAutor") = cmbAutor.SelectedValue Then

                    e.Graphics.DrawString(DR("Titulo"), TipoLetra, Brushes.Black, 80, fila)
                    e.Graphics.DrawString(DR("Cantidad"), TipoLetra, Brushes.Black, 380, fila)
                    e.Graphics.DrawString(DR("Precio"), TipoLetra, Brushes.Black, 480, fila)

                    fila = fila + 15

                End If

            Loop

            e.Graphics.DrawString("Cantidad de datos: " & lblCantidad.Text, TipoLetra, Brushes.Black, 80, 200)
        End If


        Conexion.Close()


    End Sub
End Class