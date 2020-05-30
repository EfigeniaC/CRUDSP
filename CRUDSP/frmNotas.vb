Imports CapaEntidad
Imports CapaNegocio

Public Class frmNotas
    Dim objNegocioN As New clsN_Notas
    Dim objEntidadN As New clsE_Notas
    Dim objEntidadC As New clsE_Curso
    Dim objNegocioC As New clsN_Curso
    Dim objNegocioA As New clsN_Alumno
    Sub ListaNotas()
        Dim dt As DataTable = objNegocioN.N_obtenerTabla_Notas
        dgv_Notas.DataSource = dt
    End Sub
    Sub ListaCurso()
        cmbCursos.DataSource = objNegocioC.N_obtenerTabla_Curso
        cmbCursos.Text = "Seleccione una Opción"
        cmbCursos.DisplayMember = "curso"
        cmbCursos.ValueMember = "idCurso"
    End Sub
    Sub ListaAlumno()
        cmbAlumno.DataSource = objNegocioA.N_obtenerTabla
        cmbAlumno.Text = "Seleccione una Opción"
        cmbAlumno.DisplayMember = "apellidos"
        cmbAlumno.ValueMember = "idAlumnos"
    End Sub
    Private Sub frmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaNotas()
        ListaCurso()
        ListaAlumno()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        objEntidadN._notaAlumno = CInt(cmbAlumno.SelectedValue)
        objEntidadN._notaCurso = CInt(cmbCursos.SelectedValue)
        objEntidadN._nota1 = txtnota1.Text
        objEntidadN._nota2 = txtnota2.Text
        objEntidadN._nota3 = txtnota3.Text
        objEntidadN._nota4 = txtnota4.Text
        objNegocioN.N_registrarNota(objEntidadN)
        ListaNotas()

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim idNota As Integer
            Dim i As Integer
            i = dgv_Notas.CurrentRow.Index
            idNota = dgv_Notas.Item(0, i).Value()
            objNegocioC.N_eliminarCurso(idNota)
            MsgBox("Eliminacion Exitosa")
            ListaNotas()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_Notas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Notas.CellClick
        Dim i As Integer
        i = dgv_Notas.CurrentRow.Index
        txtIdNota.Text = dgv_Notas.Item(0, i).Value()
        cmbAlumno.Text = dgv_Notas.Item(1, i).Value()
        cmbCursos.Text = dgv_Notas.Item(3, i).Value()
        txtnota1.Text = dgv_Notas.Item(4, i).Value()
        txtnota2.Text = dgv_Notas.Item(5, i).Value()
        txtnota3.Text = dgv_Notas.Item(6, i).Value()
        txtnota4.Text = dgv_Notas.Item(7, i).Value()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim idNota As Integer
        Dim i As Integer
        i = dgv_Notas.CurrentRow.Index
        idNota = dgv_Notas.Item(0, i).Value()
        objEntidadN._notaAlumno = CInt(cmbAlumno.SelectedValue)
        objEntidadN._notaCurso = CInt(cmbCursos.SelectedValue)
        objEntidadN._nota1 = txtnota1.Text
        objEntidadN._nota2 = txtnota2.Text
        objEntidadN._nota3 = txtnota3.Text
        objEntidadN._nota4 = txtnota4.Text
        objNegocioN.N_editarNota(objEntidadN)
        ListaCurso()
    End Sub
End Class