Imports System.Data.SqlClient
Imports CapaEntidad

Public Class clsD_Notas
    Inherits clsD_conexion
    'Funcion OBTENER TABLA NOTAS
    Public Function D_obtenerTabla_Notas() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "SP_OBTENER_TABLA_NOTA"

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
    'Funcion Registrar Alumno
    Public Function D_registrarNota(objNota As clsE_Notas) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_INSERTA_NOTAS"
                Command.Parameters.AddWithValue("@notaAlumno", objNota._notaAlumno)
                Command.Parameters.AddWithValue("@notaCurso", objNota._notaCurso)
                Command.Parameters.AddWithValue("@nota1", objNota._nota1)
                Command.Parameters.AddWithValue("@nota2", objNota._nota2)
                Command.Parameters.AddWithValue("@nota3", objNota._nota3)
                Command.Parameters.AddWithValue("@nota4", objNota._nota4)

                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Notas ya Registradas")
                End Try

            End Using
        End Using
        Return False
    End Function
    'Funcion Editar Alumno
    Public Function D_EditarNota(objNota As clsE_Notas) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_MODIFICAR_NOTA"
                Command.Parameters.AddWithValue("@idNota", objNota._idNota)
                Command.Parameters.AddWithValue("@notaAlumno", objNota._notaAlumno)
                Command.Parameters.AddWithValue("@notaCurso", objNota._notaCurso)
                Command.Parameters.AddWithValue("@nota1", objNota._nota1)
                Command.Parameters.AddWithValue("@nota2", objNota._nota2)
                Command.Parameters.AddWithValue("@nota3", objNota._nota3)
                Command.Parameters.AddWithValue("@nota4", objNota._nota4)
                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Notas Modificadas")
                End Try
            End Using
        End Using
        Return False
    End Function
    Public Function D_eliminarNota(idNotas As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_ELIMINAR_Nota"
                Command.Parameters.AddWithValue("@idNotas", idNotas)
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

