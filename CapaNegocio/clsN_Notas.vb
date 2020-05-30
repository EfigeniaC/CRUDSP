Imports CapaDatos

Public Class clsN_Notas
    Private objDatosN As New clsD_Notas

    Public Function N_obtenerTabla_Notas() As DataTable
        Return objDatosN.D_obtenerTabla_Notas()
    End Function
    Public Function N_registrarNota(objNota) As Boolean
        Return objDatosN.D_registrarNota(objNota)
    End Function
    Public Function N_editarNota(objNota) As Boolean
        Return objDatosN.D_EditarNota(objNota)
    End Function
    Public Function N_eliminarNota(objNota) As Boolean
        Return objDatosN.D_eliminarNota(objNota)
    End Function
End Class
