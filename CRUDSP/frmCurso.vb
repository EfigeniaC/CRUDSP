Imports CapaEntidad
Imports CapaNegocio

Public Class frmCurso
    Dim objNegocioC As New clsN_Curso
    Dim objEntidadC As New clsE_Curso
    Sub ListaCurso()
        Dim dt As DataTable = objNegocioC.N_obtenerTabla_Curso
        dgv_Curso.DataSource = dt

    End Sub
    Private Sub frmCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaCurso()
    End Sub
End Class