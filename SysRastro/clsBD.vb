﻿Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class clsBD
    Public Function CreaConexion() As SqlConnection
        Dim cn As New SqlConnection("Data Source=SERVERCONTA;Initial Catalog=Rastro;User ID=controlnomina;Password=Denes1257")
        Dim cmd As New SqlCommand
        cmd.Connection = cn

        cn.Open()

        Return cn
    End Function

    Public Sub CierraConexion(ByVal pCn As SqlConnection)
        pCn.Close()
    End Sub
End Class
