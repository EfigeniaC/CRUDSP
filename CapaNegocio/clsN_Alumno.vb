Imports CapaDatos
Imports CapaEntidad

Public Class clsN_Alumno
    Private objDatosA As New clsD_Alumno

    Public Function N_obtenerTabla() As DataTable
        Return objDatosA.D_obtenerTabla()
    End Function
    Public Function N_registrarAlumno(objAlumno) As Boolean
        Return objDatosA.D_registrarAlumno(objAlumno)
    End Function
    Public Function N_editarAlumno(objAlumno) As Boolean
        Return objDatosA.D_editarAlumno(objAlumno)
    End Function
    Public Function N_eliminarAlumno(objAlumno) As Boolean
        Return objDatosA.D_eliminarAlumno(objAlumno)
    End Function

End Class
