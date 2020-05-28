Imports System.Data.SqlClient
Imports CapaEntidad

Public Class clsD_Alumno
    Inherits clsD_conexion
    'Funcion OBTENER TABLA ALUMNO
    Public Function D_obtenerTabla() As DataTable
        Using conexion = ObtenerConexion()
            conexion.Open()
            Dim dt As DataTable
            Dim da As SqlDataAdapter
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandType = CommandType.StoredProcedure
                Command.CommandText = "SP_OBTENER_TABLA"

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
    Public Function D_registrarAlumno(objAlumno As clsE_Alumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_INSERTAR_ALUMNO"
                Command.Parameters.AddWithValue("@nombre", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellido", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@sexo", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@numero", objAlumno._numeroAlumno)
                Command.Parameters.AddWithValue("@email", objAlumno._emailAlumno)

                Command.CommandType = CommandType.StoredProcedure
                Try
                    If Command.ExecuteNonQuery Then
                        Return True
                    Else
                        Return False
                    End If
                Catch ex As Exception
                    MsgBox("Alumno ya registrado")
                End Try
            End Using
        End Using
        Return False
    End Function
    'Funcion Editar Alumno
    Public Function D_editarAlumno(objAlumno As clsE_Alumno) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_MODIFICAR_ALUMNO"
                Command.Parameters.AddWithValue("@idAlumnos", objAlumno._idAlumno)
                Command.Parameters.AddWithValue("@nombre", objAlumno._nombreAlumno)
                Command.Parameters.AddWithValue("@apellido", objAlumno._apellidoAlumno)
                Command.Parameters.AddWithValue("@sexo", objAlumno._sexoAlumno)
                Command.Parameters.AddWithValue("@numero", objAlumno._numeroAlumno)
                Command.Parameters.AddWithValue("@email", objAlumno._emailAlumno)
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
    'Funcion Eliminar Alumno
    Public Function D_eliminarAlumno(idAlumnos As Integer) As Boolean
        Using conexion = ObtenerConexion()
            conexion.Open()
            Using Command = New SqlCommand()
                Command.Connection = conexion
                Command.CommandText = "SP_ELIMINIAR_ALUMNO"
                Command.Parameters.AddWithValue("@id_Alumno", idAlumnos)
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
