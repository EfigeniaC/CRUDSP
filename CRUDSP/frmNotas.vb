Imports CapaEntidad
Imports CapaNegocio

Public Class frmNotas
    Dim objNegocioN As New clsN_Notas
    Dim objEntidadN As New clsE_Notas
    Sub ListaNotas()
        Dim dt As DataTable = objNegocioN.N_obtenerTabla_Curso
        dgv_Notas.DataSource = dt
    End Sub

    Private Sub frmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaNotas()
    End Sub
End Class