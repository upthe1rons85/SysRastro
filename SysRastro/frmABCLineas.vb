Imports System.Data.SqlClient
Imports SysRastro.clsTools
Public Class frmABCLineas

    Private Sub frmABCLineas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Mantenimiento Lineas de Produccion" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario

            Me.MaximizeBox = False

        Else
            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()

        End If
        LlenarListaLineas()
        txtEquipoAct.Text = UCase(System.Net.Dns.GetHostName())



    End Sub


    Private Sub LlenarListaLineas()
        Dim clsBD As New clsBD()

        Dim dr As SqlDataReader
        Dim oclsABCLineas = New clsABCLineas()

        dr = oclsABCLineas.SeleccionaLinea(txtLineaProd.Text, txtEquipo.Text, LoginUsuario, 0)

        Dim dt = New DataTable()
        dt.Load(dr)
        lstLineas.Items.Clear()
        If dt.Rows.Count > 0 Then
            lstLineas.Items.Clear()
            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("Linea").ToString)
                lstLista.SubItems.Add(rRow("Equipo").ToString)
                lstLista.SubItems.Add(rRow("Usuario").ToString)
                lstLista.SubItems.Add(rRow("FechaModificacion").ToString)
                lstLineas.Items.Add(lstLista)
            Next
        End If
    End Sub

    Private Sub BtnSelEquipoAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelEquipoAct.Click
        txtEquipo.Text = txtEquipoAct.Text
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtEquipo.Text = "" Then
            MsgBox("No Se ha Capturado el Nombre de Equipo", MsgBoxStyle.Critical, "Sistema Rastro")
            Exit Sub
        End If


        Dim dr As SqlDataReader
        Dim oclsABCLineas = New clsABCLineas()
        dr = oclsABCLineas.SeleccionaLinea(txtLineaProd.Text, txtEquipo.Text, LoginUsuario, 1)
        If dr.Read Then
            txtLineaProd.Text = dr("Linea").ToString()
            MsgBox("Se Grabo Correctamente la Linea de Produccion " & txtLineaProd.Text, MsgBoxStyle.Information, "Sistema Rastro")
            LlenarListaLineas()
        Else
            MsgBox("No se Puso Obtener Numero de Linea", MsgBoxStyle.Critical, "Sistema Rastro")
        End If

    End Sub
End Class