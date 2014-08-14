﻿Imports System.Data.SqlClient
Imports System.Data
Imports SysRastro.clsUsuarios
Imports SysRastro.mdVariables
Imports SysRastro.clsTools
Public Class frmPrincipal
    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Space(160) + "Desarrollo de Engordas Estabuladas S.A. de C.V." + Space(10) + VersionCont()
        Me.Hide()
        Login.Show()
        Me.WindowState = 2
    End Sub
    Private Sub RolasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RolasToolStripMenuItem.Click
        'Dim isOpen As Boolean = False
        'For Each f As Form In Application.OpenForms
        '    If f.Name = frmCatRolas.Name Then
        '        isOpen = True
        '    End If
        'Next
        'If isOpen = False Then
        '    My.Forms.frmCatRolas.Show()
        'Else
        '    My.Forms.frmCatRolas.Focus()
        'End If
        Dim frm1 As New frmCatRolas
        frm1.MdiParent = Me
        ' Para mostrarlo maximizado al crear la ventana
        'frm2.WindowState = FormWindowState.Maximized
        frm1.Show()
    End Sub
    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MsgBox("Desea Cerrar Sesion ? ", MessageBoxButtons.YesNo, "               SysRastro [V 1.0]") = MsgBoxResult.Yes Then
            Me.Hide()
            Login.Show()
        End If
    End Sub
    Private Sub SalirDeSysAlamcenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirDeSysAlamcenToolStripMenuItem.Click
        If MsgBox("Desea Salir de SysRastro ? ", MessageBoxButtons.YesNo, "               SysRastro [V 1.0]") = MsgBoxResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub BasculasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasculasToolStripMenuItem.Click
        Dim frm As New frmCatBasculas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub TipoAnimalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoAnimalesToolStripMenuItem.Click
        Dim frm1 As New frmTipoAnimal
        frm1.MdiParent = Me
        frm1.Show()
    End Sub

    Private Sub BasculaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasculaToolStripMenuItem.Click
        Dim frm As New frmBascula
        frm.MdiParent = Me
        frm.Show()
        If frm.aprobado = 0 Then
            frm.Close()
        End If
    End Sub

    Private Sub PesoCalienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesoCalienteToolStripMenuItem.Click
        Dim frm As New frmPesoPie
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub CapturaDePielesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturaDePielesToolStripMenuItem.Click
        Dim frm As New frmPielEnSangre
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LoteProduccionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoteProduccionToolStripMenuItem.Click
        Dim frm As New frmLoteMovimiento
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub LineasProducciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineasProducciónToolStripMenuItem.Click
        Dim isOpen As Boolean = False
        For Each f As Form In Application.OpenForms
            If f.Name = frmABCLineas.Name Then
                isOpen = True
            End If
        Next
        If isOpen = False Then
            My.Forms.frmABCLineas.Show()
        Else
            My.Forms.frmABCLineas.Focus()
        End If
    End Sub
End Class