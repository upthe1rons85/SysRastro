Imports System.IO
Imports SysRastro.clsTools
Imports SysRastro.clsBD
Imports SysRastro.mdVariables
Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class frmBascula
    Dim CadenaImpresion As String
    Dim consecutivo As String
    Public Aprobado As Integer = 1

    Private Sub frmBascula_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If aprobado = 1 Then
            If MessageBox.Show("¿Desea Terminar Captura?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Exit Sub
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '-----------------VALIDA PERFIL USUARIO------------------
        Dim Perfil As String
        Perfil = "00-05-06"

        If Perfil Like "*" + Perfilesusuario + "*" Then
            Me.Text = "Captura de Entradas" + Space(10) + CStr(VersionCont())
            STBlblUsuario.Text = LoginUsuario

            Me.MaximizeBox = False
            dtpFechaProd.Text = Today
        Else

            MsgBox("No tiene Derechos Sobre esta Opcion", vbCritical, "Sistema Contable")
            Me.Close()
        End If
        Cargabasculas()
        '--------NUMERO LINEA-----
        ValidaLineaProduccion()

    End Sub


    Private Sub Cargabasculas()

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim consulta As String = "select IdBascula,Descripcion from catBasculas (NOLOCK)"
        Dim cmd As New SqlCommand(consulta, cnnConexion)
        cmd.CommandType = CommandType.Text

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)

        cbxBascula.ValueMember = "IdBascula"
        cbxBascula.DisplayMember = "Descripcion"

        cbxBascula.DataSource = dt
        cbxBascula.SelectedIndex = -1
        '--------------------------------
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        ''-----------------VALIDA LA EXISTENCIA DE LA CARPETA----------------
        If Directory.Exists("C:\SYSDENES") = False Then ' si no existe la carpeta se crea
            Directory.CreateDirectory("C:\SYSDENES")
        End If

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Dim RutaArchivo As String = "C:\SYSDENES\Etiqueta.txt"
        ''-----------------VALIDA LA EXISTENCIA DEL ARCHIVO----------------
        'Se abre el archivo y si este no existe se crea
        Dim strStreamW As Stream
        Dim escritor As StreamWriter
        If File.Exists(RutaArchivo) Then
            strStreamW = File.Open(RutaArchivo, FileMode.Open) 'Abrimos el archivo
        Else
            strStreamW = File.Create(RutaArchivo) ' lo creamos
        End If
        escritor = New StreamWriter(strStreamW, System.Text.Encoding.Default) ' tipo de codificacion para escritura
        '-------------------------------------------------------------------

        Dim dr As SqlDataReader
        Dim oClsBascula As New clsBascula
        '-------------EXTRAER CONCECUTIVO GENERAL --------------
        dr = oClsBascula.SeleccionaConsecutivoGRAL(0)
        If dr.Read Then
            consecutivo = dr("Consecutivo").ToString()
        Else
            MsgBox("No se Pudo Obtener el Folio Consecutivo General")
            Exit Sub
        End If
        dr.Close()
        '-----------------------------------------------------
        '-------------EXTRAER CONCECUTIVO CANAL --------------
        Dim ConsecutivoCanal As Integer
        dr = oClsBascula.SeleccionaConsecutivoCanal(Format(dtpFechaProd.Value, "yyyyMMdd"), CInt(STBlblLinea.Text), 0)
        If dr.Read Then
            ConsecutivoCanal = dr("ConsecutivoCanal").ToString()
        Else
            MsgBox("No se Pudo Obtener el Folio Consecutivo Canal")
            Exit Sub
        End If

        Try
            Dim eFecha As String = Format(dtpFechaProd.Value, "dd/MM/yyyy")
            Dim eLote As String = Trim(txtLote.Text)
            Dim eNumGeneral As String = CInt(STBlblLinea.Text) & Long.Parse(consecutivo).ToString("0000000")
            Dim eNumCanal As String = Long.Parse(ConsecutivoCanal).ToString("000")
            Dim eLado As String
            If cbxLado.SelectedIndex = 0 Then
                eLado = "I"
            ElseIf cbxLado.SelectedIndex = 1 Then
                eLado = "D"
            End If
            Dim eCodigoProd As String = Long.Parse(Trim(txtCodigoProd.Text)).ToString("000")
            Dim eDesProd As String = Trim(txtProducto.Text)
            Dim ePeso As String = Trim(lblPeso.Text)
            Dim ePresentacion As String = Trim("MANTENGASE FRESCO / KEEP REFRIGERATED")
            Dim eClasificacion As String = Trim("BUENO")
            Dim eTIF As String = Trim("560")
            Dim eLineaInferior1 = Trim("PROCESADO EN BODEGA DE PRODUCTOS INTERNACIONAL S.A DE C.V.")
            Dim eLineaInferior2 = Trim("PARA DESARROLLO DE ENGORDAS ESTABULADAS S.A. DE C.V.")
            Dim eLineaPagina = Trim("WWW.DENES.COM.MX")
            '------- Codigo Barras lo conforman 1.-Numero de Linea (1) 2.-Consecutivo General (7) 3.-Fecha Formato AAMMDD 4.-CodigoProducto (3) 5.-Peso Sin Punto (5)
            Dim eCodBarras As String = eNumGeneral _
                           & Format(dtpFechaProd.Value, "yyMMdd") _
                           & eCodigoProd _
                           & Long.Parse(Replace(ePeso, ".", "")).ToString("00000")

            escritor.Write("^XA~TA000~JSN^LT0^MNW^MTT^PON^PMN^LH0,0^JMA^PR5,5~SD15^JUS^LRN^CI0^XZ")
            escritor.WriteLine()
            escritor.Write("^XA")
            escritor.WriteLine()
            escritor.Write("^MMT")
            escritor.WriteLine()
            escritor.Write("^PW406")
            escritor.WriteLine()
            escritor.Write("^LL0812")
            escritor.WriteLine()
            escritor.Write("^LS0")
            escritor.WriteLine()
            escritor.Write("^FT0,288^XG000.GRF,1,1^FS")
            escritor.WriteLine()
            escritor.Write("^FT151,641^A0B,76,96^FH\^FD" & ePeso & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT155,378^A0B,37,43^FH\^FDKG.^FS")
            escritor.WriteLine()
            escritor.Write("^FT91,340^A0B,28,43^FH\^FD" & eLado & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT143,790^A0B,51,50^FH\^FD" & eCodigoProd & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT72,455^A0B,34,40^FH\^FD" & eNumCanal & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT29,419^A0B,25,31^FH\^FD" & "L " & eLote & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT28,575^A0B,25,26^FH\^FD" & eFecha & "^FS")
            escritor.WriteLine()
            escritor.Write("^BY2,3,60^FT111,308^B3B,N,,N,N")
            escritor.WriteLine()
            escritor.Write("^FD" & Long.Parse(consecutivo).ToString("0000000") & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT143,305^A0B,14,14^FH\^FDGRADO DE CLASIFICACION^FS")
            escritor.WriteLine()
            escritor.Write("^FT365,792^A0B,23,24^FH\^FD" & eLineaInferior1 & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT387,792^A0B,23,24^FH\^FD" & eLineaInferior2 & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT331,335^A0B,13,21^FH\^FD" & eLineaPagina & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT335,793^A0B,23,24^FH\^FD" & eCodBarras & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT127,303^A0B,14,14^FH\^FD" & ePresentacion & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT148,121^A0B,20,26^FH\^FD" & eClasificacion & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT43,292^A0B,43,74^FH\^FD" & Long.Parse(consecutivo).ToString("0000000") & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT204,793^A0B,65,60^FH\^FD" & eDesProd & "^FS")
            escritor.WriteLine()
            escritor.Write("^BY2,3,98^FT309,790^B3B,N,,N,N")
            escritor.WriteLine()
            escritor.Write("^FD" & eCodBarras & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT397,166^A0B,34,43^FH\^FD" & "TIF " & eTIF & "^FS")
            escritor.WriteLine()
            escritor.Write("^FT93,577^A0B,20,36^FH\^FDPeso/Weight ^FS")
            escritor.WriteLine()
            escritor.Write("^FT28,791^A0B,25,24^FH\^FDFecha de Sacrificio^FS")
            escritor.WriteLine()
            escritor.Write("^FO34,309^GB0,483,3^FS")
            escritor.WriteLine()
            escritor.Write("^PQ1,0,1,Y")
            escritor.WriteLine()
            escritor.Write("^XZ")
            escritor.WriteLine()
            escritor.Write("^XA^ID000.GRF^FS")
            escritor.WriteLine()
            escritor.Write("^XZ")

            escritor.Flush()
            escritor.Close()
            'MessageBox.Show("Escritura realizada con éxito")

            Dim comando As String
            comando = "TYPE C:\SYSDENES\Etiqueta.txt>LPT1"
            Shell("cmd.exe /c" & comando)

            '------------- ADELANTA FOLIO CONSECUTIVO -----------------
            oClsBascula.SeleccionaConsecutivoGRAL(1) '--Agrega + 1 al foliador
            oClsBascula.SeleccionaConsecutivoCanal(Format(dtpFechaProd.Value, "yyyyMMdd"), STBlblLinea.Text, 1) '--Agrega + 1 al foliador
            '-----------------------------------------------------------
        Catch err As Exception
            MsgBox("Ocurrio un Error al Generar Layout", MsgBoxStyle.Critical)
            MessageBox.Show("Error:" & err.Message)
            escritor.Flush()
            escritor.Close()
        End Try
    End Sub

    Private Sub dtpFechaProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpFechaProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Dim dr As SqlDataReader
            Dim oClsBascula As New clsBascula
            '-------------VERIFICAR EXISTENCIA - AGREGAR o CONSULTAR --------------
            dr = oClsBascula.SeleccionaConsecutivoCanal(Format(dtpFechaProd.Value, "yyyyMMdd"), STBlblLinea.Text, 0)
            If dr.Read Then
                lblConsecutivo.Text = dr("ConsecutivoCanal").ToString()
                lblConsecutivo.Text = Long.Parse(lblConsecutivo.Text).ToString("000")

                txtLote.Focus()
            Else
                If MessageBox.Show("No se Encontro Informacion en la fecha Seleccionada, ¿Desea Inicializar el Consecutivo para la Fecha Seleccionada?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Try
                        dr = oClsBascula.SeleccionaConsecutivoCanal(Format(dtpFechaProd.Value, "yyyyMMdd"), STBlblLinea.Text, 2)
                        MsgBox("Se Creo Consecutivo para la fecha " & Format(dtpFechaProd.Value, "dd/MM/yyyy"), MsgBoxStyle.Information, "Captura de Entradas")
                    Catch err As Exception
                        MsgBox("Ocurrio un Error al crear Consecutivo", MsgBoxStyle.Critical)
                        MessageBox.Show("Error:" & err.Message)
                    End Try
                Else
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub txtPesoManual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPesoManual.Click
        txtPesoManual.SelectAll()
    End Sub

    Private Sub txtPesoManual_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPesoManual.GotFocus
        txtPesoManual.SelectAll()
    End Sub

    Private Sub txtPesoManual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPesoManual.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            lblPeso.Text = Format(CDec(txtPesoManual.Text), "##0.#0")
            txtPesoManual.Text = Format(CDec(txtPesoManual.Text), "##0.#0")
            cbxLado.Focus()
        End If
    End Sub

    Private Sub txtLote_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLote.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True

            Dim dr As SqlDataReader
            Dim oClsBascula As New clsBascula
            '-------------VERIFICAR EXISTENCIA - AGREGAR o CONSULTAR --------------
            dr = oClsBascula.SeleccionaLoteProduccion(txtLote.Text)
            If dr.Read Then
                lblProceso.Text = UCase(dr("Descripcion").ToString())
                lblInfLote.Text = Long.Parse(txtLote.Text).ToString("0000000000")
                lblInfCabezas.Text = dr("CantidadCabezas").ToString()
                lblInfFechaSal.Text = dr("FechaSalidaEng").ToString()
                'lblInfFechaSal.Text = Format(lblInfFechaSal.Text, "dd/MM/yyyy")
                lblInfCliente.Text = Long.Parse(dr("Codigocliente").ToString).ToString("000000")

                txtLote.Focus()
            Else
                MsgBox("No Se encontro Lote Produccion Verifique", MsgBoxStyle.Information, "Sistema Rastro")
                lblInfLote.Text = ""
                lblProceso.Text = ""
                lblInfCabezas.Text = ""
                lblInfFechaSal.Text = ""
                lblInfCliente.Text = ""
            End If

            txtCodigoProd.Focus()
        End If
    End Sub

    Private Sub txtCodigoProd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoProd.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtProducto.Focus()

        End If
    End Sub

    Private Sub txtProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cbxBascula.Focus()
        End If
    End Sub

    Private Sub cbxLado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxLado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            btnGenerar.Focus()

        End If
    End Sub

    Private Sub cbxBascula_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbxBascula.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            txtPesoManual.Focus()

        End If
    End Sub

    Private Sub ValidaLineaProduccion()

         Dim dr As SqlDataReader
        Dim oClsBascula As New clsBascula
        '------------- CONSULTAR NUMERO DE LINEA --------------
        dr = oClsBascula.SeleccionaLineaProduccion(0, 0)
        If dr.Read Then
            STBlblLinea.Text = dr("Linea").ToString()
        Else
            MsgBox("No se Encontro Maquina Asociada con algun Numero de linea", MsgBoxStyle.Information, "Sistema Rastro")
            aprobado = 0
            'If MessageBox.Show("No se Encontro Maquina Asociada con algun Numero de linea, ¿Desea Agregar una Linea Nueva?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            'End If
        End If
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        ConectarBasculas(1)
    End Sub

    Public PesoBascula As String
    Public idBascula As Integer
    Public CadenaIni As String
    Public CadenaFin As String

    Dim strBufferOut As String
    Dim strBufferIn As String
    Public DatoPuerto As String

    Private Sub ConectarBasculas(ByVal idBascula As Integer)
        Dim dr As SqlDataReader
        Dim oclsMovientosBanco = New clsCatBasculas

        dr = oclsMovientosBanco.SeleccionaListaOrdenCompra(1, idBascula)

        'dr = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.

        If dr.Read Then
            Try
                spPuertos.PortName = dr("puerto").ToString 'puerto de comunicacion
                spPuertos.BaudRate = dr("velocidad").ToString ' velocidad
                spPuertos.DataBits = dr("bitsparidad").ToString ' bits  de paridad
                spPuertos.Parity = CInt(dr("paridad").ToString)
                spPuertos.StopBits = dr("bitsparada").ToString ' bits de parada
                CadenaIni = dr("cadenaini").ToString
                CadenaFin = dr("cadenafin").ToString
                spPuertos.Open()
                tmrTimer.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No se encuentra la bascula seleccionada " & idBascula)
        End If

        dr.Close()
    End Sub

    Private Sub frmPesosBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ConectarBasculas()
        Me.Visible = False
    End Sub
    Private Sub tmrTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        If IsNothing(DatoPuerto) = False Then
            ConvertirPeso(Replace(DatoPuerto, ",", "."))
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

    End Sub

    Private Sub ConvertirPeso(ByVal DatosCom As String)
        Dim nCadenaIni As Integer
        Dim nCadenaFin As Integer
        Dim strCadena As String

        Try

            nCadenaIni = InStrRev(DatosCom, CadenaIni) + Len(CadenaIni)

            nCadenaFin = InStrRev(DatosCom, CadenaFin)
            If nCadenaFin = 0 Then
                nCadenaFin = (CInt(Len(DatosCom)))
            End If

            PesoBascula = "0.00"
            strCadena = Mid(DatosCom, nCadenaIni, nCadenaFin - nCadenaIni)

            If IsNumeric(strCadena) = True Then
                lblPeso.Text = Format(CDbl(strCadena), "##,##0.00")
            End If
        Catch ex As Exception
            spPuertos.Close()
            tmrTimer.Enabled = False

        End Try
    End Sub
End Class