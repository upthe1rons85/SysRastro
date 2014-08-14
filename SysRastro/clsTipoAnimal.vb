﻿Imports System.Data.SqlClient

Public Class clsTipoAnimal
    Function SeleccionaAnim(ByVal animn As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spSelTipoAnimal"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoAnimal", SqlDbType.Int).Value = animn
        dr = cmd.ExecuteReader()
        SeleccionaAnim = dr
    End Function

    Sub InsertaAnim(ByVal pDatos As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spInsTipoAnimal"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@XMLDoc", SqlDbType.VarChar).Value = pDatos
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub EliminaTipoAnimal(ByVal anim As Integer)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spEliTipoAnimal"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoAnimal", SqlDbType.Int).Value = anim
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Sub ActualizaTipoAnim(ByVal tipo As Integer, ByVal desc As String, ByVal sexo As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        cmd.CommandText = "spActTipoAnimal"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@TipoAnimal", SqlDbType.Int).Value = tipo
        cmd.Parameters.Add("@Descripcion", SqlDbType.NChar).Value = desc
        cmd.Parameters.Add("@Sexo", SqlDbType.NChar).Value = sexo
        cmd.ExecuteNonQuery()
        cmd.Dispose()
        clsDB.CierraConexion(cnnConexion)
    End Sub

    Function BuscaAnim(ByVal anim As String)
        Dim cnnConexion = New SqlConnection()
        Dim clsDB = New clsBD()
        cnnConexion = clsDB.CreaConexion()
        Dim cmd As New SqlCommand
        Dim dr As SqlDataReader
        cmd.CommandText = "spBusTipoAnimal"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnnConexion
        cmd.Parameters.Add("@Descripcion", SqlDbType.NChar).Value = anim
        dr = cmd.ExecuteReader()
        BuscaAnim = dr
    End Function
End Class
