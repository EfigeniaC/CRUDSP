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
    Public Function comprobar() As Boolean
        If Len(Trim$(txtCurso.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LimpiarDatos()
        txtCurso.Clear()
        txtCurso.Clear()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If comprobar() Then
            objEntidadC._curso = txtCurso.Text
            objNegocioC.N_registrarCurso(objEntidadC)
            LimpiarDatos()
            ListaCurso()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub dgv_Curso_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Curso.CellClick
        Dim i As Integer
        i = dgv_Curso.CurrentRow.Index
        txtIdCurso.Text = dgv_Curso.Item(0, i).Value()
        txtCurso.Text = dgv_Curso.Item(1, i).Value()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If comprobar() Then
            Dim idCurso As Integer
            Dim i As Integer
            i = dgv_Curso.CurrentRow.Index
            idCurso = dgv_Curso.Item(0, i).Value()
            objEntidadC._idCurso = txtIdCurso.Text
            objEntidadC._curso = txtCurso.Text
            objNegocioC.N_editarCurso(objEntidadC)
            LimpiarDatos()
            ListaCurso()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim idCurso As Integer
            Dim i As Integer
            i = dgv_Curso.CurrentRow.Index
            idCurso = dgv_Curso.Item(0, i).Value()
            objEntidadC._idCurso = idCurso
            objNegocioC.N_eliminarCurso(objEntidadC)
            MsgBox("Eliminacion Exitosa")
            LimpiarDatos()
            ListaCurso()
        Catch ex As Exception

        End Try
    End Sub

End Class