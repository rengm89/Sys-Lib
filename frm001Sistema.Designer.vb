<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm001Sistema
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm001Sistema))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnPaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeUnIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorAutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorPaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosPorIdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaísToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IdiomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.ListadosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.EstadísticasToolStripMenuItem, Me.AgregarToolStripMenuItem, Me.ModificarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(787, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosToolStripMenuItem, Me.AutoresToolStripMenuItem, Me.IdiomasToolStripMenuItem, Me.PaisesToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'LibrosToolStripMenuItem
        '
        Me.LibrosToolStripMenuItem.Name = "LibrosToolStripMenuItem"
        Me.LibrosToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LibrosToolStripMenuItem.Text = "Libros..."
        '
        'AutoresToolStripMenuItem
        '
        Me.AutoresToolStripMenuItem.Name = "AutoresToolStripMenuItem"
        Me.AutoresToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AutoresToolStripMenuItem.Text = "Autores..."
        '
        'IdiomasToolStripMenuItem
        '
        Me.IdiomasToolStripMenuItem.Name = "IdiomasToolStripMenuItem"
        Me.IdiomasToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.IdiomasToolStripMenuItem.Text = "Idiomas..."
        '
        'PaisesToolStripMenuItem
        '
        Me.PaisesToolStripMenuItem.Name = "PaisesToolStripMenuItem"
        Me.PaisesToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.PaisesToolStripMenuItem.Text = "Países..."
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosDeUnAutorToolStripMenuItem, Me.LibrosDeUnPaísToolStripMenuItem, Me.LibrosDeUnIdiomaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'LibrosDeUnAutorToolStripMenuItem
        '
        Me.LibrosDeUnAutorToolStripMenuItem.Name = "LibrosDeUnAutorToolStripMenuItem"
        Me.LibrosDeUnAutorToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnAutorToolStripMenuItem.Text = "Libros de un autor..."
        '
        'LibrosDeUnPaísToolStripMenuItem
        '
        Me.LibrosDeUnPaísToolStripMenuItem.Name = "LibrosDeUnPaísToolStripMenuItem"
        Me.LibrosDeUnPaísToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnPaísToolStripMenuItem.Text = "Libros de un país..."
        '
        'LibrosDeUnIdiomaToolStripMenuItem
        '
        Me.LibrosDeUnIdiomaToolStripMenuItem.Name = "LibrosDeUnIdiomaToolStripMenuItem"
        Me.LibrosDeUnIdiomaToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.LibrosDeUnIdiomaToolStripMenuItem.Text = "Libros de un idioma..."
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibrosPorAutorToolStripMenuItem, Me.LibrosPorPaísToolStripMenuItem, Me.LibrosPorIdiomaToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'LibrosPorAutorToolStripMenuItem
        '
        Me.LibrosPorAutorToolStripMenuItem.Name = "LibrosPorAutorToolStripMenuItem"
        Me.LibrosPorAutorToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorAutorToolStripMenuItem.Text = "Libros por autor..."
        '
        'LibrosPorPaísToolStripMenuItem
        '
        Me.LibrosPorPaísToolStripMenuItem.Name = "LibrosPorPaísToolStripMenuItem"
        Me.LibrosPorPaísToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorPaísToolStripMenuItem.Text = "Libros por país..."
        '
        'LibrosPorIdiomaToolStripMenuItem
        '
        Me.LibrosPorIdiomaToolStripMenuItem.Name = "LibrosPorIdiomaToolStripMenuItem"
        Me.LibrosPorIdiomaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.LibrosPorIdiomaToolStripMenuItem.Text = "Libros por idioma..."
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibroToolStripMenuItem, Me.PaísToolStripMenuItem, Me.AutorToolStripMenuItem, Me.IdiomaToolStripMenuItem})
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'LibroToolStripMenuItem
        '
        Me.LibroToolStripMenuItem.Name = "LibroToolStripMenuItem"
        Me.LibroToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LibroToolStripMenuItem.Text = "Libro..."
        '
        'PaísToolStripMenuItem
        '
        Me.PaísToolStripMenuItem.Name = "PaísToolStripMenuItem"
        Me.PaísToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.PaísToolStripMenuItem.Text = "País..."
        '
        'AutorToolStripMenuItem
        '
        Me.AutorToolStripMenuItem.Name = "AutorToolStripMenuItem"
        Me.AutorToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AutorToolStripMenuItem.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem
        '
        Me.IdiomaToolStripMenuItem.Name = "IdiomaToolStripMenuItem"
        Me.IdiomaToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.IdiomaToolStripMenuItem.Text = "Idioma..."
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LibroToolStripMenuItem1, Me.PaísToolStripMenuItem1, Me.AutorToolStripMenuItem1, Me.IdiomaToolStripMenuItem1})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'LibroToolStripMenuItem1
        '
        Me.LibroToolStripMenuItem1.Name = "LibroToolStripMenuItem1"
        Me.LibroToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.LibroToolStripMenuItem1.Text = "Libro..."
        '
        'PaísToolStripMenuItem1
        '
        Me.PaísToolStripMenuItem1.Name = "PaísToolStripMenuItem1"
        Me.PaísToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.PaísToolStripMenuItem1.Text = "País..."
        '
        'AutorToolStripMenuItem1
        '
        Me.AutorToolStripMenuItem1.Name = "AutorToolStripMenuItem1"
        Me.AutorToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AutorToolStripMenuItem1.Text = "Autor..."
        '
        'IdiomaToolStripMenuItem1
        '
        Me.IdiomaToolStripMenuItem1.Name = "IdiomaToolStripMenuItem1"
        Me.IdiomaToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.IdiomaToolStripMenuItem1.Text = "Idioma..."
        '
        'frm001Sistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(787, 447)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm001Sistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sistema"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaisesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnPaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosDeUnIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorAutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorPaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibrosPorIdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibroToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PaísToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AutorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents IdiomaToolStripMenuItem1 As ToolStripMenuItem
End Class
