Imports CapaDatos

Public Class clsN_Notas
    Private objDatosN As New clsD_Notas

    Public Function N_obtenerTabla_Curso() As DataTable
        Return objDatosN.D_obtenerTabla_Notas()
    End Function

End Class
