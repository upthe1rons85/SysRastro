Imports System.Data.SqlClient
Imports SysRastro.clsTools

Public Class clsABCLineas
    Function SeleccionaLinea(ByVal pLinea As String, ByVal pEquipoLinea As String, ByVal pUsuario As String, ByVal pagrega As Integer) As SqlDataReader

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spLineaProduccion"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@pLinea", SqlDbType.VarChar).Value = pLinea
        cmd.Parameters.Add("@pEquipoLinea", SqlDbType.VarChar).Value = pEquipoLinea
        cmd.Parameters.Add("@pUsuario", SqlDbType.VarChar).Value = pUsuario
        cmd.Parameters.Add("@pAgrega", SqlDbType.Int).Value = pagrega

        dr = cmd.ExecuteReader()
        SeleccionaLinea = dr
    End Function
End Class
