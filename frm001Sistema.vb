Public Class frm001Sistema
    Private Sub LibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosToolStripMenuItem.Click
        frm003Libros.Show()
    End Sub

    Private Sub AutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoresToolStripMenuItem.Click
        frm004Autores.Show()
    End Sub

    Private Sub IdiomasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomasToolStripMenuItem.Click
        frm005Idiomas.Show()
    End Sub

    Private Sub PaisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisesToolStripMenuItem.Click
        frm006Paises.Show()
    End Sub

    Private Sub LibrosDeUnAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnAutorToolStripMenuItem.Click
        frm007ConsultaAutor.Show()
    End Sub

    Private Sub LibrosDeUnPaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnPaísToolStripMenuItem.Click
        frm008ConsultaPais.Show()
    End Sub

    Private Sub LibrosDeUnIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosDeUnIdiomaToolStripMenuItem.Click
        frm009ConsultaIdioma.Show()
    End Sub

    Private Sub LibrosPorAutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorAutorToolStripMenuItem.Click
        frm010LibroPorAutor.Show()
    End Sub

    Private Sub LibrosPorPaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorPaísToolStripMenuItem.Click
        frm011LibroPorPais.Show()
    End Sub

    Private Sub LibrosPorIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibrosPorIdiomaToolStripMenuItem.Click
        frm012LibroPorIdioma.Show()
    End Sub

    Private Sub LibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LibroToolStripMenuItem.Click
        frm013AgregarLibro.Show()
    End Sub

    Private Sub PaísToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaísToolStripMenuItem.Click
        frm014AgregarPais.Show()
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        frm015AgregarAutor.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem.Click
        frm016AgregarIdioma.Show()
    End Sub

    Private Sub LibroToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LibroToolStripMenuItem1.Click
        frm017ModificarLibro.Show()
    End Sub

    Private Sub PaísToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PaísToolStripMenuItem1.Click
        frm018ModificarPais.Show()
    End Sub

    Private Sub AutorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem1.Click
        frm019ModificarAutor.Show()
    End Sub

    Private Sub IdiomaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IdiomaToolStripMenuItem1.Click
        frm020ModificarIdioma.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frm021AcercaDe.Show()
    End Sub
End Class
