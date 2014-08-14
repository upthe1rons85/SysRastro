Imports System.Data.SqlClient

Public Class frmCatRolas

    Private Sub frmCatRolas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargalst()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        txtCodRola.Enabled = True
        txtPeso.Enabled = False
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub Cargalst()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cn As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim consulta As String = "select * from [Rastro].[DBO].[rasTaraRolas](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "rasTaraRolas")
        Dim objListItem As New ListViewItem
        Me.lstRolas.Items.Clear()
        For Each drw As DataRow In ds.Tables("rasTaraRolas").Rows
            objListItem = lstRolas.Items.Add(drw.Item("CodigoRola").ToString, 0)
            objListItem.SubItems.Add(drw.Item("PesoRola").ToString)
        Next
    End Sub

    Sub limpiar()
        txtCodRola.Clear()
        txtPeso.Clear()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtCodRola.Text = "" Or txtPeso.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Rastro")
            txtCodRola.Focus()
            Cargalst()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaRola", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@CodRola", txtCodRola.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsRola = New clsRolas()
                    pclsRola.ActualizaRola(txtCodRola.Text, txtPeso.Text)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Rastro")
                    limpiar()
                Else
                    Dim sXML = "<xRola>"
                    sXML += "<CodigoRola>" + txtCodRola.Text + "</CodigoRola>"
                    sXML += "<PesoRola>" + txtPeso.Text + "</PesoRola>"
                    sXML += "</xRola>"
                    Dim pclsRolas = New clsRolas()
                    pclsRolas.InsertaRola(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Rastro")
                    limpiar()
                    Cargalst()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Rastro")
            End Try
            txtCodRola.Enabled = True
            txtPeso.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            Cargalst()
            limpiar()
            txtCodRola.Focus()
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtBuscar.Text = "Buscar Codigo Rola"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtCodRola.Enabled = True
        txtPeso.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Cargalst()
        limpiar()
        txtCodRola.Focus()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtCodRola.Enabled = True
        txtPeso.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtPeso.Focus()
        Cargalst()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtCodRola.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Rastro")
            txtCodRola.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsRola = New clsRolas()
                oclsRola.EliminaRola(txtCodRola.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Rastro")
            End If
        End If
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtCodRola.Enabled = True
        limpiar()
        Cargalst()
        txtCodRola.Focus()
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub

    Private Sub TxtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsRola = New clsRolas()
        dr = oclsRola.BuscaRola(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstRolas.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("CodigoRola").ToString)
            lstLista.SubItems.Add(rRow("PesoRola").ToString)
            lstRolas.Items.Add(lstLista)
        Next
    End Sub

    Private Sub lstRolas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstRolas.MouseDoubleClick
        txtCodRola.Text = lstRolas.SelectedItems(0).SubItems(0).Text
        txtPeso.Text = lstRolas.SelectedItems(0).SubItems(1).Text
        txtCodRola.Enabled = False
        txtPeso.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        BtnNuevo.Enabled = True
    End Sub
End Class