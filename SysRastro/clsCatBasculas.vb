Imports System.Data.SqlClient
Public Class clsCatBasculas
    Function SeleccionaListaOrdenCompra(ByVal nOpcion As Integer, ByVal FolioBascula As String) As SqlDataReader
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()

        cnnConexion = clsDB.CreaConexion()

        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader

        cmd.CommandText = "spSelBascula"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Opcion", SqlDbType.Int).Value = nOpcion
        cmd.Parameters.Add("@FolioBascula", SqlDbType.VarChar).Value = FolioBascula



        dr = cmd.ExecuteReader()
        SeleccionaListaOrdenCompra = dr
    End Function
End Class
