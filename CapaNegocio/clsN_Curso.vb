Imports CapaDatos

Public Class clsN_Curso
    Private objDatosC As New clsD_Curso

    Public Function N_obtenerTabla_Curso() As DataTable
        Return objDatosC.D_obtenerTabla_Curso()
    End Function
End Class
