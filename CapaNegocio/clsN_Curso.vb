Imports CapaDatos

Public Class clsN_Curso
    Private objDatosC As New clsD_Curso

    Public Function N_obtenerTabla_Curso() As DataTable
        Return objDatosC.D_obtenerTabla_Curso()
    End Function
    Public Function N_registrarCurso(objCurso) As Boolean
        Return objDatosC.D_registrarCurso(objCurso)
    End Function
    Public Function N_editarCurso(objCurso) As Boolean
        Return objDatosC.D_editarCurso(objCurso)
    End Function
    Public Function N_eliminarCurso(objCurso) As Boolean
        Return objDatosC.D_eliminarCurso(objCurso)
    End Function
End Class
