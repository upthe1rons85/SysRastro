Imports SysRastro.clsBD
Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class clsUsuarios
    Function SeleccionaUsuarios(ByVal pusuario As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "sp_busUsuario"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pusuario
        dr = cmd.ExecuteReader()
        SeleccionaUsuarios = dr
    End Function
    Shared Sub CerrarConexion()
        Throw New NotImplementedException
    End Sub
    Sub CambiaContraseñaUsuario(ByVal pDatos As String, ByVal pContraseña As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spCambiaContraseña"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = pDatos
        cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = pContraseña
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub
    Function BuscaPerfil(ByVal pperfil As String)

        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "dbo.spBusPerfil"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = pperfil

        dr = cmd.ExecuteReader()
        BuscaPerfil = dr

    End Function
End Class
