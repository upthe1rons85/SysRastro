Imports System.Data.SqlClient
Public Class frmPesosBascula
    Public PesoBascula As String
    Public idBascula As Integer
    Public CadenaIni As String
    Public CadenaFin As String

    Dim strBufferOut As String
    Dim strBufferIn As String
    Public DatoPuerto As String
    Public FRM As Form
    Private Sub ConectarBasculas()
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
        ConectarBasculas()
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
                PesoBascula = Format(CDbl(strCadena), "##,##0.00")
            End If
        Catch ex As Exception
            spPuertos.Close()
            tmrTimer.Enabled = False

        End Try
    End Sub
End Class