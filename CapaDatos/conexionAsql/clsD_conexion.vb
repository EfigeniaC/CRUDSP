﻿Imports System.Data.SqlClient
Public Class clsD_conexion
    Private cadena_conexion As String
    Protected Sub New()
        cadena_conexion = "Data Source=DESKTOP-3GC35CO\EFI_SERVER;Integrated Security= true; Database=crudAlumnos;User ID=sa;Password=sa"
    End Sub
    Protected Function ObtenerConexion() As SqlConnection
        Return New SqlConnection(cadena_conexion)
    End Function
End Class
