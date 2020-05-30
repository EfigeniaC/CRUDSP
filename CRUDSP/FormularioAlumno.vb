Imports CapaEntidad
Imports CapaNegocio

Public Class FORMULARIO_ALUMNO
    Dim objNegocioA As New clsN_Alumno
    Dim objEntidadA As New clsE_Alumno
    Sub ListaAlumnos()
        Dim dt As DataTable = objNegocioA.N_obtenerTabla
        Dgv_Alumnos.DataSource = dt

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListaAlumnos()
        FALSO()
    End Sub
    Public Function comprobar() As Boolean
        If Len(Trim$(txtNombreAlumno.Text)) <> 0 And Len(Trim$(txtApellidosAlumnos.Text)) <> 0 And Len(Trim$(txtTelefono.Text)) <> 0 And Len(Trim$(txtCorreo.Text)) <> 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LimpiarDatos()
        txtidAlumno.Clear()
        txtNombreAlumno.Clear()
        txtApellidosAlumnos.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()
    End Sub
    Private Sub ENABLE()
        'txtidAlumno.Enabled = False
        'txtNombreAlumno.Enabled = True
        'txtApellidosAlumnos.Enabled = True
        'txtTelefono.Enabled = True
        'txtCorreo.Enabled = True
        btnAgregar.Enabled = True
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
    End Sub
    Private Sub FALSO()
        'txtidAlumno.Enabled = False
        'txtNombreAlumno.Enabled = False
        'txtApellidosAlumnos.Enabled = False
        'rbMasculino.Enabled = False
        'rbFemenino.Enabled = False
        'txtTelefono.Enabled = False
        'txtCorreo.Enabled = False
        btnAgregar.Enabled = False
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub
    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If comprobar() Then
            objEntidadA._nombreAlumno = txtNombreAlumno.Text
            objEntidadA._apellidoAlumno = txtApellidosAlumnos.Text
            Dim sexo As String
            If rbFemenino.Checked = True Then
                sexo = "F"
            ElseIf rbMasculino.Checked = True Then
                sexo = "M"
            End If
            objEntidadA._sexoAlumno = sexo
            objEntidadA._numeroAlumno = txtTelefono.Text
            objEntidadA._emailAlumno = txtCorreo.Text
            objNegocioA.N_registrarAlumno(objEntidadA)
            LimpiarDatos()
            ListaAlumnos()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If

    End Sub
    Private Sub Dgv_Alumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Alumnos.CellClick
        btnAgregar.Enabled = False
        btnEditar.Enabled = True
        btnEliminar.Enabled = True
        Dim i As Integer
        i = Dgv_Alumnos.CurrentRow.Index
        txtidAlumno.Text = Dgv_Alumnos.Item(0, i).Value()
        txtNombreAlumno.Text = Dgv_Alumnos.Item(1, i).Value()
        txtApellidosAlumnos.Text = Dgv_Alumnos.Item(2, i).Value()
        Dim sexo As String
        sexo = Dgv_Alumnos.Item(3, i).Value()
        Dim comparar As Integer
        Dim sexoA As String = "F"
        comparar = sexo.CompareTo(sexoA)
        If comparar = 0 Then
            rbFemenino.Checked = True
        Else
            rbMasculino.Checked = True
        End If
        txtTelefono.Text = Dgv_Alumnos.Item(4, i).Value()
        txtCorreo.Text = Dgv_Alumnos.Item(5, i).Value()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If comprobar() Then
            Dim idAlumno As Integer
            Dim i As Integer
            i = Dgv_Alumnos.CurrentRow.Index
            idAlumno = Dgv_Alumnos.Item(0, i).Value()
            objEntidadA._idAlumno = txtidAlumno.Text
            objEntidadA._nombreAlumno = txtNombreAlumno.Text
            objEntidadA._apellidoAlumno = txtApellidosAlumnos.Text
            Dim sexo As String
            If rbFemenino.Checked = True Then
                sexo = "F"
            ElseIf rbMasculino.Checked = True Then
                sexo = "M"
            End If
            objEntidadA._sexoAlumno = sexo
            objEntidadA._numeroAlumno = txtTelefono.Text
            objEntidadA._emailAlumno = txtCorreo.Text
            objNegocioA.N_editarAlumno(objEntidadA)
            LimpiarDatos()
            ListaAlumnos()
        Else
            MsgBox("DEBE DE LLENAR TODOS LOS CAMPOS", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim idAlumno As Integer
            Dim i As Integer
            i = Dgv_Alumnos.CurrentRow.Index
            idAlumno = Dgv_Alumnos.Item(0, i).Value()
            objNegocioA.N_eliminarAlumno(idAlumno)
            ListaAlumnos()
            MsgBox("Eliminacion Exitosa")
            LimpiarDatos()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        LimpiarDatos()
        ENABLE()
        btnEditar.Enabled = False
        btnEliminar.Enabled = False
    End Sub


End Class
