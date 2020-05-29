Imports System.Data.SqlClient
Public Class clsD_Curso
    Inherits clsD_conexion

    'Funcion OBTENER TABLA Curso
    Public Function D_obtenerTabla_Curso() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "SP_OBTENER_TABLA_CURSO"

                If Command.ExecuteNonQuery Then
                    dt = New DataTable
                    da = New SqlDataAdapter(Command)
                    da.Fill(dt)
                    Return dt
                Else
                    Return Nothing
                End If
            End Using
        End Using
    End Function
End Class
