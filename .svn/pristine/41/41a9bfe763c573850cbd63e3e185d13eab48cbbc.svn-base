Imports System.Data.SqlClient
Public Class frmCatBasculas
    Dim strBufferOut As String
    Dim strBufferIn As String
    Public DatoPuerto As String

    Private Sub frmCatBasculas_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If spPuertos.IsOpen = True Then
            spPuertos.Close()
        End If
    End Sub

    Private Sub frmCatBasculas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strBufferOut = ""
        strBufferIn = ""

        btnConectar.Enabled = False
        tmrTimer.Enabled = False

        cboPuertos.Items.Clear()

        For Each PuertosDisponibles As String In My.Computer.Ports.SerialPortNames
            cboPuertos.Items.Add(PuertosDisponibles)
        Next

        If cboPuertos.Items.Count > 0 Then
            cboPuertos.Text = cboPuertos.Items(0)
            btnConectar.Enabled = True
        Else
            btnConectar.Enabled = False
            cboPuertos.Text = ""
        End If

        cboParidad.Text = cboParidad.Items(0)
        ListaBascula()

    End Sub


    Private Sub ListaBascula()
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsCatBasculas
        Dim Folio As Integer
        lstBasculas.Items.Clear()
        If txtFolio.Text = "" Then
            Folio = 0
        Else
            Folio = txtFolio.Text
        End If
        dr = oclsMovientosBanco.SeleccionaListaOrdenCompra(0, Folio)

        Dim dt = New DataTable()
        dt.Load(dr)

        If dt.Rows.Count > 0 Then

            For Each rRow As DataRow In dt.Rows
                Dim lstLista As New ListViewItem(rRow("IDBascula").ToString)
                lstLista.SubItems.Add(rRow("Descripcion").ToString)
                lstLista.SubItems.Add(rRow("Consecutivo").ToString)
                lstBasculas.Items.Add(lstLista)
            Next
            '-----------------FIN CARGAR GRID
        End If

        dr.Close()

    End Sub
    Private Sub DatosBasculas(ByVal Folio As Integer)
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsCatBasculas

        dr = oclsMovientosBanco.SeleccionaListaOrdenCompra(1, Folio)

        'dr = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        txtFolio.ReadOnly = True
        BtnGrabar.Enabled = False
        If dr.Read Then
            txtFolio.Text = dr("IDBascula").ToString
            txtDescripcion.Text = dr("Descripcion").ToString
            txtVelocidad.Text = dr("velocidad").ToString
            txtDatoIni.Text = dr("cadenaini").ToString
            txtDatoFin.Text = dr("cadenafin").ToString
            cboPuertos.Text = dr("puerto").ToString
            cboParidad.Text = cboParidad.Items(CInt(dr("paridad").ToString))
            txtBistParidad.Text = dr("bitsparidad").ToString
            txtBitsParada.Text = dr("bitsparada").ToString
            txtFolio.Text = dr("IDBascula").ToString
        Else
            BtnNuevo.PerformClick()
            'txtFolioAnticipo.Text = FolioAnti
        End If

        dr.Close()

    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        Try
            If btnConectar.Text = "Conectar" Then
                btnConectar.Text = "DESCONECTAR"
                txtBufferIn.Text = ""
                txtDatoBasculaNumerico.Text = ""
                btnValidaDato.Enabled = True
                TraeConfiguracion()
                spPuertos.Open()
                tmrTimer.Enabled = True
            ElseIf btnConectar.Text = "DESCONECTAR" Then
                btnConectar.Text = "Conectar"
                tmrTimer.Enabled = False
                btnValidaDato.Enabled = False
                spPuertos.Close()
            End If
        Catch ex As Exception
            MsgBox("Falla en la Conecciond e Puerto, NO EXISTE PUERTO " + ex.Message, MsgBoxStyle.Critical)
            btnConectar.Text = "Conectar"
            tmrTimer.Enabled = False
            btnValidaDato.Enabled = False
        End Try

    End Sub

    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        'strBufferIn = spPuertos.ReadExisting

        'If strBufferIn <> "" Then
        '    txtBufferIn.Text = strBufferIn
        '    strBufferIn = ""
        '    spPuertos.DiscardInBuffer()

        'End If
        'CovertirPeso()
        If IsNothing(DatoPuerto) = False Then
            txtBufferIn.Text = Replace(DatoPuerto, ",", ".")
        End If
    End Sub

    Private Sub spPuertos_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles spPuertos.DataReceived
        strBufferIn = spPuertos.ReadLine

        If strBufferIn <> "" Then
            'txtBufferIn.Text = strBufferIn
            DatoPuerto = strBufferIn
            strBufferIn = ""
            spPuertos.DiscardInBuffer()

        End If
        CovertirPeso()
    End Sub

    Private Sub TraeConfiguracion()
        spPuertos.PortName = cboPuertos.Text 'puerto de comunicacion
        spPuertos.BaudRate = txtVelocidad.Text ' velocidad
        spPuertos.DataBits = txtBistParidad.Text ' bits  de paridad
        spPuertos.Parity = cboParidad.SelectedIndex
        spPuertos.StopBits = txtBitsParada.Text ' bits de parada

    End Sub

    Private Sub CovertirPeso()
        'If txtDatoIni.Text = "" Then
        '    txtDatoIni.Text = "1"
        'End If
        'If txtDatoFin.Text = "" Then
        '    txtDatoFin.Text = Len(txtBufferIn.Text)
        'End If

        'txtDatoBasculaNumerico.Text = Mid(txtBufferIn.Text, CInt(txtDatoIni.Text), (CInt(txtDatoFin.Text) + 1) - CInt(txtDatoIni.Text))
    End Sub

    Private Sub btnValidaDato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnValidaDato.Click
        Dim nCadenaIni As Integer
        Dim nCadenaFin As Integer
        Dim strCadena As String
        If txtBufferIn.Text = "" Then
            Exit Sub
        End If
        Try
            If txtDatoIni.Text = "" Then
                nCadenaIni = 1
            Else
                nCadenaIni = InStrRev(txtBufferIn.Text, txtDatoIni.Text) + Len(txtDatoIni.Text)
            End If
            nCadenaFin = InStrRev(txtBufferIn.Text, txtDatoFin.Text)  ' + (CInt(Len(txtBufferIn.Text)) - InStrRev(txtBufferIn.Text, txtDatoFin.Text))
            If nCadenaFin = 0 Then
                nCadenaFin = (CInt(Len(txtBufferIn.Text)))
            End If
            txtDatoBasculaNumerico.Text = ""
            'MsgBox(InStrRev(txtBufferIn.Text, txtDatoIni.Text))
            'If (nCadenaFin - nCadenaIni) > (-1) Then
            strCadena = Mid(txtBufferIn.Text, nCadenaIni, nCadenaFin - nCadenaIni)
            'Else
            ' strCadena = txtBufferIn.Text
            'End If
            If IsNumeric(strCadena) = True Then
                txtDatoBasculaNumerico.Text = Format(CDbl(strCadena), "##,##0.00")
                BtnGrabar.Enabled = True
            Else
                txtDatoBasculaNumerico.Text = "No es Numero"
            End If
        Catch ex As Exception
            txtDatoBasculaNumerico.Text = "Error en Datos INI,FIN"
        End Try


    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        txtFolio.ReadOnly = True
        txtFolio.Text = ""
        txtDescripcion.Text = ""
        txtBufferIn.Text = ""
        txtDatoBasculaNumerico.Text = ""
        txtDatoFin.Text = ""
        txtDatoIni.Text = ""
        txtBistParidad.Text = 8
        txtBitsParada.Text = 1
        txtVelocidad.Text = 9600
        cboParidad.SelectedIndex = 0
        cboPuertos.SelectedIndex = 0
        BtnGrabar.Enabled = False
        btnValidaDato.Enabled = False
        btnConectar.Text = "Conectar"
        tmrTimer.Enabled = False
        btnValidaDato.Enabled = False
        BtnGrabar.Enabled = False
        txtDescripcion.Select()
        spPuertos.Close()
    End Sub


    Private Sub lstBasculas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstBasculas.Click
        DatosBasculas(Trim(lstBasculas.SelectedItems(0).SubItems(0).Text))

    End Sub


    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        If txtDescripcion.Text = "" Then
            MsgBox("Favor de agregar el nombre de la bacula", vbInformation)
            Exit Sub
        End If
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim transaction As SqlTransaction
        Dim wQuery As String = ""
        Dim XError As String
        Dim wFolio As String = 0

        cnnConexion = clsDB.CreaConexion()
        wQuery = "SELECT Folio =isnull(MAX(IDBascula),0)+1 FROM catBasculas (NOLOCK)"
        XError = "Error al obtener Folio Consecutivo"
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        cmd.CommandType = Data.CommandType.Text
        transaction = cnnConexion.BeginTransaction

        cmd.Connection = cnnConexion
        cmd.Transaction = transaction

        Try
            dr = cmd.ExecuteReader()
            XError = "Error al Actualizar Folio consecutivo"
            If dr.Read Then
                wFolio = dr("Folio").ToString()
            Else
                MsgBox("No Se Genero Consecutivo de Folio Producto")

            End If
            dr.Close()
            XError = "Guardar Informacion de Bascula"
            cmd.Parameters.Clear()
            cmd.CommandText = "spInsCatBascula"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@Opcion", SqlDbType.VarChar).Value = 1
            cmd.Parameters.Add("@IDBascula", SqlDbType.VarChar).Value = wFolio
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
            cmd.Parameters.Add("@puerto", SqlDbType.VarChar).Value = cboPuertos.Text
            cmd.Parameters.Add("@velocidad", SqlDbType.VarChar).Value = txtVelocidad.Text
            cmd.Parameters.Add("@bitsparidad", SqlDbType.VarChar).Value = txtBistParidad.Text
            cmd.Parameters.Add("@paridad", SqlDbType.VarChar).Value = cboParidad.SelectedIndex
            cmd.Parameters.Add("@bitsparada", SqlDbType.VarChar).Value = txtBitsParada.Text
            cmd.Parameters.Add("@cadenaini", SqlDbType.VarChar).Value = txtDatoIni.Text
            cmd.Parameters.Add("@cadenafin", SqlDbType.VarChar).Value = txtDatoFin.Text
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = LoginUsuario

            cmd.ExecuteNonQuery()

            transaction.Commit()
            MsgBox("Se Grabo Correctamente, Bascula  Folio : " & txtDescripcion.Text, MsgBoxStyle.Information)
            txtFolio.Text = wFolio
            txtFolio.ReadOnly = True
            BtnGrabar.Enabled = False
            ListaBascula()
            DatosBasculas(wFolio)
        Catch ex As Exception
            transaction.Rollback()
            MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
            MessageBox.Show("Error:" & ex.Message)
        Finally
            cnnConexion.Dispose()
            cnnConexion.Close()
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If txtDescripcion.Text = "" Then
            MsgBox("No de puede actualizar si no se a agregado anteriomente la bascula", vbInformation, "Sistema Contabilidad")
            Exit Sub
        End If
        Dim clsDB = New clsBD()
        Dim cnnConexion = New SqlConnection()
        Dim cmd As SqlCommand
        'Dim dr As SqlDataReader
        Dim transaction As SqlTransaction
        Dim wQuery As String = ""
        Dim XError As String
        Dim wFolio As String = 0

        cnnConexion = clsDB.CreaConexion()
        wQuery = "SELECT Folio =isnull(MAX(IDBascula),0)+1 FROM catBasculas (NOLOCK)"
        XError = "Error al obtener Folio Consecutivo"
        cmd = New Data.SqlClient.SqlCommand(wQuery, cnnConexion)
        'cmd.CommandType = Data.CommandType.Text
        transaction = cnnConexion.BeginTransaction

        cmd.Connection = cnnConexion
        cmd.Transaction = transaction

        Try
            XError = "Guardar Informacion de Bascula"
            cmd.Parameters.Clear()
            cmd.CommandText = "spInsCatBascula"
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.Add("@Opcion", SqlDbType.VarChar).Value = 2
            cmd.Parameters.Add("@IDBascula", SqlDbType.VarChar).Value = txtFolio.Text
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text
            cmd.Parameters.Add("@puerto", SqlDbType.VarChar).Value = cboPuertos.Text
            cmd.Parameters.Add("@velocidad", SqlDbType.VarChar).Value = txtVelocidad.Text
            cmd.Parameters.Add("@bitsparidad", SqlDbType.VarChar).Value = txtBistParidad.Text
            cmd.Parameters.Add("@paridad", SqlDbType.VarChar).Value = cboParidad.SelectedIndex
            cmd.Parameters.Add("@bitsparada", SqlDbType.VarChar).Value = txtBitsParada.Text
            cmd.Parameters.Add("@cadenaini", SqlDbType.VarChar).Value = txtDatoIni.Text
            cmd.Parameters.Add("@cadenafin", SqlDbType.VarChar).Value = txtDatoFin.Text
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = LoginUsuario

            cmd.ExecuteNonQuery()

            transaction.Commit()
            MsgBox("Se Grabo Correctamente, Bascula  Folio : " & txtDescripcion.Text, MsgBoxStyle.Information)
            ListaBascula()
            DatosBasculas(wFolio)
        Catch ex As Exception
            transaction.Rollback()
            MsgBox("Ocurrio un Error al Grabar " & XError, MsgBoxStyle.Critical)
            MessageBox.Show("Error:" & ex.Message)
        Finally
            cnnConexion.Dispose()
            cnnConexion.Close()
        End Try
    End Sub


End Class