Imports SysRastro.clsTools
Imports SysRastro.clsBD
Imports SysRastro.mdVariables
Imports System.Data.SqlClient
Public Class clsBascula
    Function SeleccionaConsecutivoGRAL(ByVal Agrega As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spConsultaConsecutivoBascula"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pAgrega", SqlDbType.VarChar).Value = Agrega

        dr = cmd.ExecuteReader()
        SeleccionaConsecutivoGRAL = dr
    End Function
    Function SeleccionaConsecutivoCanal(ByVal pFecha As String, ByVal pLinea As Integer, ByVal pAgrega As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spConsultaConsecutivoCANAL"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pFechaSacrificio", SqlDbType.VarChar).Value = pFecha
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = pLinea
        cmd.Parameters.Add("@pAgrega", SqlDbType.VarChar).Value = pAgrega

        dr = cmd.ExecuteReader()
        SeleccionaConsecutivoCanal = dr
    End Function
    Function SeleccionaLineaProduccion(ByVal pLinea As Integer, ByVal pAgrega As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spValidaBascula"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pNombreMaquina", SqlDbType.VarChar).Value = System.Net.Dns.GetHostName()
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = pLinea
        cmd.Parameters.Add("@pAgrega", SqlDbType.VarChar).Value = pAgrega


        dr = cmd.ExecuteReader()
        SeleccionaLineaProduccion = dr
    End Function

    Function SeleccionaLoteProduccion(ByVal pLote As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelLoteSacrificio"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pLote", SqlDbType.VarChar).Value = pLote

        dr = cmd.ExecuteReader()
        SeleccionaLoteProduccion = dr
    End Function
End Class
