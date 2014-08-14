Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports SysRastro.clsTools
Public Class frmPesoPie
    Dim TipoAnimal As String
    Private Sub frmPesoCaliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Captura Peso Pie" + Space(50) + CStr(VersionCont())
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        Me.RbtHembra.Checked = True
        Me.DtpFecha.Focus()
    End Sub
    Private Sub limpiar()
        Me.TxtArete.Clear()
        Me.TxtAreteSagarpa.Clear()
        Me.TxtPeso.Clear()
        Me.TxtSalida.Clear()
        Me.RbtHembra.Checked = True
        Me.TxtArete.Focus()
    End Sub
    Private Sub RegresaMovimientos()
        Dim bclsFletes = New clsPesoPie()
        Dim dr As SqlDataReader

        dr = bclsFletes.SeleccionaFolio(Me.TxtArete.Text)

        If dr.Read() Then
            Me.TxtArete.Text = dr("Arete").ToString()
            Me.TxtAreteSagarpa.Text = dr("AreteSagarpa").ToString()
            Me.TxtSalida.Text = dr("Salida").ToString()
            Me.lblconsecutivoArete.Text = dr("ConsecutivodeArete").ToString()
            Me.BtnGrabar.Enabled = True
            Me.TxtPeso.Focus()
        Else
            Me.TxtArete.Clear()
            Me.TxtAreteSagarpa.Clear()
            Me.lblconsecutivoArete.Text = ""
            Me.TxtSalida.Clear()
            Me.TxtPeso.Clear()

        End If
    End Sub
    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        'Dim DtpFecha As String = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")
        Dim Fecha As String = Format(CDate(Me.DtpFecha.Value.ToShortDateString), "yyyyMMdd")

        'se asigna el valor para el tipo de moneda 1=Dollares,0=Pesos
        If RbtHembra.Checked = True Then
            TipoAnimal = 0
        Else
            TipoAnimal = 1
        End If

        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        cnnConexion = clsDB.CreaConexion()

        Dim transaction As SqlTransaction
        transaction = cnnConexion.BeginTransaction

        Try

            Dim sXML = "<xPesoPie>"
            sXML += "<Fecha>" + Fecha + "</Fecha>"
            sXML += "<Arete>" + Me.TxtArete.Text + "</Arete>"
            sXML += "<AreteSagarpa>" + Me.TxtAreteSagarpa.Text + "</AreteSagarpa>"
            sXML += "<ConsecutivoDeArete>" + Me.lblconsecutivoArete.Text + "</ConsecutivoDeArete>"
            sXML += "<Lote>" + Me.TxtLote.Text + "</Lote>"
            sXML += "<PesoPie>" + Me.TxtPeso.Text + "</PesoPie>"
            sXML += "<Salida>" + Me.TxtSalida.Text + "</Salida>"
            sXML += "<TipoAnimal>" + TipoAnimal + "</TipoAnimal>"
            sXML += "</xPesoPie>"

            Dim aclsInsertaPesoPie = New clsPesoPie()
            aclsInsertaPesoPie.InsertaPesoPie(sXML)

            transaction.Commit()
            limpiar()
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
            Me.TxtArete.Focus()
        End If
    End Sub
    Private Sub TxtArete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtArete.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            RegresaMovimientos()
        End If
    End Sub
    Private Sub TxtAreteSagarpa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAreteSagarpa.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtSalida.Focus()
        End If
    End Sub
    Private Sub TxtSalida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSalida.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.TxtPeso.Focus()
        End If
    End Sub
    Private Sub TxtPeso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPeso.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.RbtHembra.Focus()
        End If
    End Sub
    Private Sub RbtHembra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RbtHembra.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
    End Sub
    Private Sub RbtMacho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RbtMacho.KeyPress
        If e.KeyChar = ChrW(Keys.Tab) Or e.KeyChar = ChrW(Keys.Enter) Then
            Me.BtnGrabar.Focus()
        End If
    End Sub

    Private Sub TxtArete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtArete.TextChanged

    End Sub
End Class