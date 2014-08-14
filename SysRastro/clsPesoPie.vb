Imports SysRastro.clsBD
Imports System.Data.SqlClient
Public Class clsPesoPie
    Sub InsertaPesoPie(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand

        cmd.CommandText = "spInsPesoPie"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion

        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos

        cmd.ExecuteNonQuery()

        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function SeleccionaFolio(ByVal pFolio As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New ClsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spBusArete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Arete", SqlDbType.VarChar).Value = pFolio

        dr = cmd.ExecuteReader()
        SeleccionaFolio = dr
    End Function
End Class
