Imports System.Data.SqlClient

Public Class frmTipoAnimal

    Private Sub frmTipoAnimal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargalst()
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        MaximizeBox = False
        txtTipoAnimal.Enabled = True
        txtDesc.Enabled = False
        cbxSexo.Enabled = False
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
        Dim consulta As String = "select * from [Engorda].[DBO].[engTipoAnimal](nolock)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        da = New SqlDataAdapter
        da.SelectCommand = cmd
        da.Fill(ds, "engTipoAnimal")
        Dim objListItem As New ListViewItem
        Me.lstTipoAnimal.Items.Clear()
        For Each drw As DataRow In ds.Tables("engTipoAnimal").Rows
            objListItem = lstTipoAnimal.Items.Add(drw.Item("TipoAnimal").ToString, 0)
            objListItem.SubItems.Add(drw.Item("Descripcion").ToString)
            objListItem.SubItems.Add(drw.Item("Sexo").ToString)
        Next
    End Sub

    Sub limpiar()
        txtTipoAnimal.Clear()
        txtDesc.Clear()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim sexo As String

        If cbxSexo.SelectedIndex = 0 Then
            sexo = "M"
        Else
            sexo = "H"
        End If

        If txtTipoAnimal.Text = "" Or txtDesc.Text = "" Then
            MsgBox("No deben Quedar Datos Vacios..!!!", vbInformation, "Sistema Rastro")
            txtTipoAnimal.Focus()
            Cargalst()
        Else
            Try
                Dim cnnConexion = New SqlConnection()
                Dim clsDB = New clsBD()
                cnnConexion = clsDB.CreaConexion()
                Dim commandbus As New SqlCommand("spValidaTipoAnimal", cnnConexion)
                commandbus.CommandType = CommandType.StoredProcedure
                commandbus.Parameters.AddWithValue("@TipoAnimal", txtTipoAnimal.Text)
                Dim n As Integer
                n = RTrim(commandbus.ExecuteScalar())
                If n > 0 Then
                    Dim pclsan = New clsTipoAnimal()
                    pclsan.ActualizaTipoAnim(txtTipoAnimal.Text, txtDesc.Text, sexo)
                    MsgBox("Actualizado Correctamente", vbInformation, "Sistema Rastro")
                    limpiar()
                Else
                    Dim sXML = "<xAnimal>"
                    sXML += "<TipoAnimal>" + txtTipoAnimal.Text + "</TipoAnimal>"
                    sXML += "<Descripcion>" + txtDesc.Text + "</Descripcion>"
                    sXML += "<Sexo>" + sexo + "</Sexo>"
                    sXML += "</xAnimal>"
                    Dim pclsani = New clsTipoAnimal()

                    pclsani.InsertaAnim(sXML)
                    MsgBox("Registrado Correctamente", vbInformation, "Sistema Rastro")
                    limpiar()
                    Cargalst()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                MsgBox("Ocurrio un Error", vbInformation, "Sistema Rastro")
            End Try
            txtTipoAnimal.Enabled = True
            txtDesc.Enabled = False
            cbxSexo.Enabled = False
            BtnGrabar.Enabled = False
            BtnNuevo.Enabled = True
            BtnEliminar.Enabled = False
            btnModificar.Enabled = False
            Cargalst()
            limpiar()
            txtTipoAnimal.Focus()
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        TxtBuscar.Text = "Buscar Descripcion"
        TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic)
        txtTipoAnimal.Enabled = True
        txtDesc.Enabled = True
        cbxSexo.Enabled = True
        BtnGrabar.Enabled = True
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        Cargalst()
        limpiar()
        txtTipoAnimal.Focus()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        txtTipoAnimal.Enabled = True
        txtDesc.Enabled = True
        BtnGrabar.Enabled = True
        cbxSexo.Enabled = True
        BtnNuevo.Enabled = False
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtDesc.Focus()
        Cargalst()
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        If txtTipoAnimal.Text = "" Then
            MsgBox("Debe capturar un Codigo", vbInformation, "Sistema Rastro")
            txtTipoAnimal.Focus()
        Else
            If MessageBox.Show("¿Desea ELIMINAR Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim oclsan = New clsTipoAnimal()
                oclsan.EliminaTipoAnimal(txtTipoAnimal.Text)
                MsgBox("Registro Eliminado", vbInformation, "Sistema Rastro")
            End If
        End If
        BtnGrabar.Enabled = False
        BtnNuevo.Enabled = True
        btnModificar.Enabled = False
        BtnEliminar.Enabled = False
        txtTipoAnimal.Enabled = True
        limpiar()
        Cargalst()
        txtTipoAnimal.Focus()
    End Sub

    Private Sub TxtBuscar_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TxtBuscar.MouseClick
        TxtBuscar.Clear()
    End Sub

    Private Sub TxtBuscar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscar.KeyPress
        Dim clsBD As New clsBD()
        Dim dr As SqlDataReader
        Dim oclsan = New clsTipoAnimal()
        dr = oclsan.BuscaAnim(Me.TxtBuscar.Text)
        Dim dt = New DataTable()
        dt.Load(dr)
        lstTipoAnimal.Items.Clear()
        For Each rRow As DataRow In dt.Rows
            Dim lstLista As New ListViewItem(rRow("TipoAnimal").ToString)
            lstLista.SubItems.Add(rRow("Descripcion").ToString)
            lstLista.SubItems.Add(rRow("Sexo").ToString)
            lstTipoAnimal.Items.Add(lstLista)
        Next
    End Sub

    Private Sub lstTipoAnimal_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstTipoAnimal.MouseDoubleClick
        txtTipoAnimal.Text = lstTipoAnimal.SelectedItems(0).SubItems(0).Text
        txtDesc.Text = lstTipoAnimal.SelectedItems(0).SubItems(1).Text
        txtTipoAnimal.Enabled = False
        txtDesc.Enabled = False
        cbxSexo.Enabled = False
        btnModificar.Enabled = True
        BtnGrabar.Enabled = False
        BtnEliminar.Enabled = True
        BtnNuevo.Enabled = True
    End Sub
End Class