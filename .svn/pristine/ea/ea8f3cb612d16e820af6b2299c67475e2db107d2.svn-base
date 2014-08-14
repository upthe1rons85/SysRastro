Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports SysRastro.clsTools
Imports SysRastro.clsUsuarios
Public Class frmPielEnSangre
    Dim Fecha As String
    Private Sub frmPielEnSangre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Captura Peso Pie" + Space(50) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Fecha = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")
        Me.DtpFecha.Focus()
        llenaLista()
    End Sub
    Private Sub limpiar()
        Me.TxtLote.Clear()
        Me.TxtPeso.Clear()
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click

        'Dim DtpFecha As String = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")
        Fecha = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")

        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        cnnConexion = clsDB.CreaConexion()

        Dim transaction As SqlTransaction
        transaction = cnnConexion.BeginTransaction

        Try

            Dim sXML = "<xPesoPiel>"
            sXML += "<Fecha>" + Fecha + "</Fecha>"
            sXML += "<Lote>" + Me.TxtLote.Text + "</Lote>"
            sXML += "<PesoPiel>" + Me.TxtPeso.Text + "</PesoPiel>"
            sXML += "<UsuarioModificacion>" + LoginUsuario + "</UsuarioModificacion>"
            sXML += "</xPesoPiel>"

            Dim aclsInsertaPesoPieles = New clsPesoPieles()
            aclsInsertaPesoPieles.InsertaPesoPieles(sXML)

            transaction.Commit()
            limpiar()
            Me.DtpFecha.Focus()
            llenaLista()
        Catch
            transaction.Rollback()
            MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
        Finally
            cnnConexion.Dispose()
            cnnConexion.Close()
        End Try

    End Sub
    Private Sub DtpFecha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DtpFecha.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Fecha = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")
            limpiar()
            Me.TxtLote.Focus()
        End If
    End Sub
    Private Sub TxtLote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLote.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtPeso.Focus()
        End If
    End Sub
    Private Sub TxtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPeso.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
    End Sub
    Private Sub llenaLista()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet

        Dim consulta As String = "Select Consecutivo,Fecha,Lote,PesoPiel from Rastro.dbo.rasPielesCanal(nolock) where fecha='" & Fecha & "' order by consecutivo desc"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        'cmd.CommandType = CommandType.Text
        da = New SqlDataAdapter
        da.SelectCommand = cmd

        da.Fill(ds, "rasPielesCanal")


        Dim objListItem As New ListViewItem
        Me.lstPieles.Items.Clear()

        For Each drw As DataRow In ds.Tables("rasPielesCanal").Rows
            objListItem = lstPieles.Items.Add(drw.Item("Consecutivo").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Fecha").ToString)
            objListItem.SubItems.Add(drw.Item("Lote").ToString)
            objListItem.SubItems.Add(drw.Item("PesoPiel").ToString)
        Next
    End Sub

    Private Sub DtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFecha.ValueChanged
        MsgBox("ssss", MsgBoxStyle.Critical)
    End Sub
End Class