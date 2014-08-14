Imports System.Data.SqlClient
Public Class clsLoteMovimiento
    Function SeleccionaProveedoresListaItem()
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelProveedor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        dr = cmd.ExecuteReader()
        SeleccionaProveedoresListaItem = dr
    End Function
    Function CantidadCabezasFecha(ByVal Fechas As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spCantidadCabezasEngorda"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Fechas
        dr = cmd.ExecuteReader()
        CantidadCabezasFecha = dr
    End Function

    Function SelLoteProduccion(ByVal nLote As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelLoteMovimiento"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@nLote", SqlDbType.VarChar).Value = nLote
        dr = cmd.ExecuteReader()
        SelLoteProduccion = dr
    End Function

    Function SeleccionaTipoProceso(ByVal nOpcion As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCBXTipoProceso"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion

        dr = cmd.ExecuteReader()
        SeleccionaTipoProceso = dr
    End Function
    Function SeleccionaCliente(ByVal nOpcion As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spCBXCliente"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@nOpcion", SqlDbType.Int).Value = nOpcion

        dr = cmd.ExecuteReader()
        SeleccionaCliente = dr
    End Function
End Class
