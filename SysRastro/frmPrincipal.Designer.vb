﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CATALOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDeContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasculasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoAnimalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesoCalienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasculaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturaDePielesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoteProduccionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDeSysAlamcenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AYUDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndiceAyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDelSysAlamacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.STBlblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PgsGrabar = New System.Windows.Forms.ToolStripProgressBar()
        Me.LineasProducciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATALOGOSToolStripMenuItem, Me.ENTRADASToolStripMenuItem, Me.SALIDAToolStripMenuItem, Me.AYUDAToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1276, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CATALOGOSToolStripMenuItem
        '
        Me.CATALOGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.RolasToolStripMenuItem, Me.BasculasToolStripMenuItem, Me.TipoAnimalesToolStripMenuItem, Me.LineasProducciónToolStripMenuItem})
        Me.CATALOGOSToolStripMenuItem.Name = "CATALOGOSToolStripMenuItem"
        Me.CATALOGOSToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CATALOGOSToolStripMenuItem.Text = "CATALOGOS"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilDeUsuarioToolStripMenuItem, Me.ResetDeContraseñaToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PerfilDeUsuarioToolStripMenuItem
        '
        Me.PerfilDeUsuarioToolStripMenuItem.Name = "PerfilDeUsuarioToolStripMenuItem"
        Me.PerfilDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.PerfilDeUsuarioToolStripMenuItem.Text = "Perfil de Usuario"
        '
        'ResetDeContraseñaToolStripMenuItem
        '
        Me.ResetDeContraseñaToolStripMenuItem.Name = "ResetDeContraseñaToolStripMenuItem"
        Me.ResetDeContraseñaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ResetDeContraseñaToolStripMenuItem.Text = "Reset de Contraseña"
        '
        'RolasToolStripMenuItem
        '
        Me.RolasToolStripMenuItem.Name = "RolasToolStripMenuItem"
        Me.RolasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RolasToolStripMenuItem.Text = "Rolas"
        '
        'BasculasToolStripMenuItem
        '
        Me.BasculasToolStripMenuItem.Name = "BasculasToolStripMenuItem"
        Me.BasculasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.BasculasToolStripMenuItem.Text = "Basculas"
        '
        'TipoAnimalesToolStripMenuItem
        '
        Me.TipoAnimalesToolStripMenuItem.Name = "TipoAnimalesToolStripMenuItem"
        Me.TipoAnimalesToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TipoAnimalesToolStripMenuItem.Text = "Tipo Animales"
        '
        'ENTRADASToolStripMenuItem
        '
        Me.ENTRADASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesoCalienteToolStripMenuItem, Me.BasculaToolStripMenuItem, Me.CapturaDePielesToolStripMenuItem, Me.LoteProduccionToolStripMenuItem})
        Me.ENTRADASToolStripMenuItem.Name = "ENTRADASToolStripMenuItem"
        Me.ENTRADASToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ENTRADASToolStripMenuItem.Text = "ENTRADAS"
        '
        'PesoCalienteToolStripMenuItem
        '
        Me.PesoCalienteToolStripMenuItem.Name = "PesoCalienteToolStripMenuItem"
        Me.PesoCalienteToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.PesoCalienteToolStripMenuItem.Text = "Peso Pie"
        '
        'BasculaToolStripMenuItem
        '
        Me.BasculaToolStripMenuItem.Name = "BasculaToolStripMenuItem"
        Me.BasculaToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.BasculaToolStripMenuItem.Text = "Peso Canal Caliente"
        '
        'CapturaDePielesToolStripMenuItem
        '
        Me.CapturaDePielesToolStripMenuItem.Name = "CapturaDePielesToolStripMenuItem"
        Me.CapturaDePielesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CapturaDePielesToolStripMenuItem.Text = "Captura de Pieles"
        '
        'LoteProduccionToolStripMenuItem
        '
        Me.LoteProduccionToolStripMenuItem.Name = "LoteProduccionToolStripMenuItem"
        Me.LoteProduccionToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.LoteProduccionToolStripMenuItem.Text = "Lote Produccion"
        '
        'SALIDAToolStripMenuItem
        '
        Me.SALIDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarSesionToolStripMenuItem, Me.SalirDeSysAlamcenToolStripMenuItem})
        Me.SALIDAToolStripMenuItem.Name = "SALIDAToolStripMenuItem"
        Me.SALIDAToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.SALIDAToolStripMenuItem.Text = "SALIDA"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'SalirDeSysAlamcenToolStripMenuItem
        '
        Me.SalirDeSysAlamcenToolStripMenuItem.Name = "SalirDeSysAlamcenToolStripMenuItem"
        Me.SalirDeSysAlamcenToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SalirDeSysAlamcenToolStripMenuItem.Text = "Salir de sysRastro"
        '
        'AYUDAToolStripMenuItem
        '
        Me.AYUDAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndiceAyudaToolStripMenuItem, Me.AcercaDelSysAlamacenToolStripMenuItem})
        Me.AYUDAToolStripMenuItem.Name = "AYUDAToolStripMenuItem"
        Me.AYUDAToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.AYUDAToolStripMenuItem.Text = "AYUDA"
        '
        'IndiceAyudaToolStripMenuItem
        '
        Me.IndiceAyudaToolStripMenuItem.Name = "IndiceAyudaToolStripMenuItem"
        Me.IndiceAyudaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.IndiceAyudaToolStripMenuItem.Text = "Indice Ayuda"
        '
        'AcercaDelSysAlamacenToolStripMenuItem
        '
        Me.AcercaDelSysAlamacenToolStripMenuItem.Name = "AcercaDelSysAlamacenToolStripMenuItem"
        Me.AcercaDelSysAlamacenToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AcercaDelSysAlamacenToolStripMenuItem.Text = "Acerca del sysRastro"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1157, 483)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(107, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.STBlblUsuario, Me.PgsGrabar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1276, 22)
        Me.StatusStrip1.TabIndex = 105
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(256, 17)
        Me.ToolStripStatusLabel1.Text = "Desarrollo de Engordas Estabuladas S.A. de C.V."
        '
        'STBlblUsuario
        '
        Me.STBlblUsuario.Name = "STBlblUsuario"
        Me.STBlblUsuario.Size = New System.Drawing.Size(80, 17)
        Me.STBlblUsuario.Text = "STBlblUsuario"
        '
        'PgsGrabar
        '
        Me.PgsGrabar.Name = "PgsGrabar"
        Me.PgsGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PgsGrabar.Size = New System.Drawing.Size(185, 16)
        Me.PgsGrabar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'LineasProducciónToolStripMenuItem
        '
        Me.LineasProducciónToolStripMenuItem.Name = "LineasProducciónToolStripMenuItem"
        Me.LineasProducciónToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LineasProducciónToolStripMenuItem.Text = "Lineas Producción"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 538)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CATALOGOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetDeContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirDeSysAlamcenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AYUDAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndiceAyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDelSysAlamacenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RolasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasculasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoAnimalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents STBlblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PgsGrabar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ENTRADASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasculaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesoCalienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturaDePielesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoteProduccionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineasProducciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
