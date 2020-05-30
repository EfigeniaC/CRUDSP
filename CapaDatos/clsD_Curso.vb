Imports System.Data.SqlClient
Imports CapaEntidad

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

    'Funcion Registrar Curso
    Public Function D_registrarCurso(objCurso As clsE_Curso) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_INSERTA_CURSO"
                Command.Parameters.AddWithValue("@curso", objCurso._curso)

                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Curso ya registrado")
                End Try
            End Using
        End Using
        Return False
    End Function
    'Funcion Editar Curso
    Public Function D_editarCurso(objCurso As clsE_Curso) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_MODIFICAR_CURSO"
                Command.Parameters.AddWithValue("@idcurso", objCurso._idCurso)
                Command.Parameters.AddWithValue("@curso", objCurso._curso)
                Command.CommandType = CommandType.StoredProcedure
                If Command.ExecuteNonQuery Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
        Return False
    End Function
    'Funcion ELIMINAR Curso
    Public Function D_eliminarCurso(idCurso As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_ELIMINAR_CURSO"
                Command.Parameters.AddWithValue("@idCurso", idCurso)
                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try

            End Using
        End Using
        Return False
    End Function

End Class
