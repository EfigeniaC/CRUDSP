Imports CapaEntidad
Imports CapaNegocio

Public Class frmNotas
    Dim objNegocioN As New clsN_Notas
    Dim objEntidadN As New clsE_Notas
    Dim objNegocioC As New clsN_Curso
    Dim objNegocioA As New clsN_Alumno
    Sub ListaNotas()
        Dim dt As DataTable = objNegocioN.N_obtenerTabla_Notas
        dgv_Notas.DataSource = dt
    End Sub
    Sub ListaCurso()
        cmbCursos.DataSource = objNegocioC.N_obtenerTabla_Curso
        cmbCursos.Text = "Seleccione una Opción"
        cmbCursos.ValueMember = "idCurso"
        cmbCursos.DisplayMember = "curso"

    End Sub
    Sub ListaAlumno()
        cmbAlumno.DataSource = objNegocioA.N_obtenerTabla
        cmbAlumno.Text = "Seleccione una Opción"
        cmbAlumno.DisplayMember = "apellidos"
        cmbAlumno.ValueMember = "idAlumnos"
    End Sub
    Private Sub limpiar()
        txtIdNota.Clear()
        cmbAlumno.Refresh()
        cmbCursos.Refresh()
        txtnota1.Clear()
        txtnota2.Clear()
        txtnota3.Clear()
        txtnota4.Clear()
    End Sub
    Private Sub frmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaNotas()
        ListaCurso()
        ListaAlumno()
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Public Function comprobar() As Boolean
        If Len(Trim$(txtnota1.Text)) <> 0 And Len(Trim$(txtnota2.Text)) <> 0 And Len(Trim$(txtnota3.Text)) <> 0 And Len(Trim$(txtnota4.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If comprobar() Then
            objEntidadN._notaAlumno = CInt(cmbAlumno.SelectedValue)
            objEntidadN._notaCurso = CInt(cmbCursos.SelectedValue)
            objEntidadN._nota1 = txtnota1.Text
            objEntidadN._nota2 = txtnota2.Text
            objEntidadN._nota3 = txtnota3.Text
            objEntidadN._nota4 = txtnota4.Text
            objNegocioN.N_registrarNota(objEntidadN)
            ListaNotas()
            MsgBox("Registro Exitoso")
            limpiar()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim idNota As Integer
            Dim i As Integer
            i = dgv_Notas.CurrentRow.Index
            idNota = dgv_Notas.Item(0, i).Value()
            objNegocioN.N_eliminarNota(idNota)
            ListaNotas()
            MsgBox("Eliminacion Exitosa")
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgv_Notas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Notas.CellClick
        btnAgregar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
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
        objEntidadN._idNota = txtIdNota.Text
        objEntidadN._notaAlumno = CInt(cmbAlumno.SelectedValue)
        objEntidadN._notaCurso = CInt(cmbCursos.SelectedValue)
        objEntidadN._nota1 = txtnota1.Text
        objEntidadN._nota2 = txtnota2.Text
        objEntidadN._nota3 = txtnota3.Text
        objEntidadN._nota4 = txtnota4.Text
        objNegocioN.N_editarNota(objEntidadN)
        ListaNotas()
        MsgBox("Actualización Exitosa")
        limpiar()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        limpiar()
        btnAgregar.Enabled = True
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub txtnota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnota1.KeyPress, txtnota2.KeyPress, txtnota3.KeyPress, txtnota4.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not sender.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnota1_TextChanged(sender As Object, e As EventArgs) Handles txtnota1.KeyPress, txtnota2.KeyPress, txtnota3.KeyPress, txtnota4.KeyPress
        If Val(txtnota1.Text) >= 0 And Val(txtnota1.Text) < 20 Then

        Else
            MessageBox.Show("La calificación debe estar entre 0 y 20")
            txtnota1.Clear()
        End If
    End Sub
End Class