Public Class FORMULARIOPRINCIPAL
    Private Sub btnR_Alumnos_Click(sender As Object, e As EventArgs) Handles btnR_Alumnos.Click
        Dim frmAlumno As New FORMULARIO_ALUMNO
        frmAlumno.Show()
    End Sub

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        Dim frmCurso As New frmCurso
        frmCurso.Show()
    End Sub

    Private Sub btnNotas_Click(sender As Object, e As EventArgs) Handles btnNotas.Click
        Dim frmNotas As New frmNotas
        frmNotas.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class