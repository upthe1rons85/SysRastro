Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.SqlClient.SqlDataReader
Imports SysRastro.clsTools
Imports SysRastro.clsUsuarios
Public Class frmLoteMovimiento

    Private Sub frmLoteMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        STBlblUsuario.Text = "||  Usuario Actual : " + LoginUsuario
        DtpFechaSacrificio.Value = Now.Date
        DtpFecha.Value = Now.Date
        txtLote.Text = Format(DtpFechaSacrificio.Value, "yyyyMMdd")
        CargaTipoMovimiento()
        CargaClientes()

        cbxCliente.SelectedValue = 9999
        cbxCliente.Enabled = False
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If MessageBox.Show("¿Desea GUARDAR el Registro?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim clsDB = New clsBD()
            Dim cnnConexion = New SqlConnection()
            Dim cmd As SqlCommand
            Dim transaction As SqlTransaction
            Dim wFolio As String = 0

            cnnConexion = clsDB.CreaConexion()
            transaction = cnnConexion.BeginTransaction
            cmd = New Data.SqlClient.SqlCommand()
            cmd.Connection = cnnConexion
            cmd.Transaction = transaction

            Try
                cmd.Parameters.Clear()
                cmd.CommandText = "spIncMovimientoCanal"
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.Add("@Opcion", SqlDbType.VarChar).Value = 1
                cmd.Parameters.Add("@FechaSacrificio", SqlDbType.DateTime).Value = DtpFechaSacrificio.Value
                cmd.Parameters.Add("@Lote", SqlDbType.VarChar).Value = txtLote.Text
                cmd.Parameters.Add("@TipoProceso", SqlDbType.VarChar).Value = cbxTipoProceso.SelectedValue
                cmd.Parameters.Add("@CodigoCliente", SqlDbType.VarChar).Value = cbxCliente.SelectedValue
                cmd.Parameters.Add("@FechaSalidaEng", SqlDbType.DateTime).Value = DtpFecha.Value
                cmd.Parameters.Add("@CantidadCabezas", SqlDbType.VarChar).Value = txtCantidadCabezas.Text
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = LoginUsuario
  

                cmd.ExecuteNonQuery()

                transaction.Commit()
                MsgBox("Se Grabo Correctamente, Lote  : " & DtpFechaSacrificio.Value, MsgBoxStyle.Information)
                
            Catch ex As Exception
                transaction.Rollback()
                MsgBox("Ocurrio un Error al Grabar ", MsgBoxStyle.Critical)
                MessageBox.Show("Error:" & ex.Message)
            Finally
                cnnConexion.Dispose()
                cnnConexion.Close()
            End Try
        End If
    End Sub

    Private Sub DtpFechaSacrificio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFechaSacrificio.ValueChanged
        txtLote.Text = Format(DtpFechaSacrificio.Value, "yyyyMMdd")

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim ocls = New clsLoteMovimiento
        Dim dr As SqlDataReader

        dr = ocls.SelLoteProduccion(txtLote.Text)

        If dr.Read() Then
            txtCantidadCabezas.Text = dr("CantidadCabezas").ToString()
            cbxTipoProceso.SelectedValue = dr("TipoProceso").ToString()
            DtpFecha.Value = dr("FechaSalidaEng").ToString()
            cbxCliente.SelectedValue = dr("CodigoCliente").ToString()
        Else
            txtCantidadCabezas.Text = ""
            cbxTipoProceso.SelectedValue = 0
            cbxCliente.SelectedValue = 9999
            DtpFecha.Value = Now.Date
        End If

    End Sub

    Private Sub DtpFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFecha.ValueChanged
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()
        Dim oclsProveedores = New clsLoteMovimiento
        Dim dr As SqlDataReader

        dr = oclsProveedores.CantidadCabezasFecha(DtpFecha.Value)

        If dr.Read() Then
            If CDbl(dr("lote").ToString()) = 0 Then
                txtCantidadCabezas.Text = dr("Cabezas").ToString()
                BtnGrabar.Enabled = True
            Else
                MsgBox("Esta fecha de salida ya se encuenta en lote " & dr("lote").ToString(), MsgBoxStyle.Information, Me.Text)
                txtCantidadCabezas.Text = dr("Cabezas").ToString()
                BtnGrabar.Enabled = False
            End If
        Else
            txtCantidadCabezas.Text = 0
        End If
    End Sub
    Private Sub CargaTipoMovimiento()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New clsLoteMovimiento
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaTipoProceso(2)

        dt.Load(dr)

        cbxTipoProceso.ValueMember = Trim("idPro")
        cbxTipoProceso.DisplayMember = Trim("descripcion")
        cbxTipoProceso.DataSource = dt
        cbxTipoProceso.SelectedValue = 0
    End Sub

    Private Sub CargaClientes()
        Dim dr As SqlDataReader
        Dim oclsProveedor As New clsLoteMovimiento
        Dim dt As New DataTable
        dr = oclsProveedor.SeleccionaCliente(2)

        dt.Load(dr)

        cbxCliente.ValueMember = Trim("Folio")
        cbxCliente.DisplayMember = Trim("descripcion")
        cbxCliente.DataSource = dt
        'cbxCliente.SelectedValue = 0
    End Sub

    Private Sub cbxTipoProceso_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbxTipoProceso.SelectedValueChanged
        If cbxTipoProceso.SelectedValue = 2 Then
            cbxCliente.Enabled = True
            cbxCliente.SelectedValue = 0
        Else
            cbxCliente.Enabled = False
            cbxCliente.SelectedValue = 9999
        End If
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        txtCantidadCabezas.Text = ""
        cbxTipoProceso.SelectedValue = 0
        cbxCliente.SelectedValue = 9999
        DtpFecha.Value = Now.Date
        DtpFechaSacrificio.Value = Now.Date
        txtCantidadCabezas.Text = 0
        BtnGrabar.Enabled = True
    End Sub
End Class