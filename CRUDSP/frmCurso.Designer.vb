<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurso
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_Curso = New System.Windows.Forms.DataGridView()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_Curso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Curso
        '
        Me.dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Curso.Location = New System.Drawing.Point(34, 35)
        Me.dgv_Curso.Name = "dgv_Curso"
        Me.dgv_Curso.Size = New System.Drawing.Size(259, 209)
        Me.dgv_Curso.TabIndex = 0
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(119, 117)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtCurso.TabIndex = 1
        '
        'btnEliminar
        '
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconSize = 16
        Me.btnEliminar.Location = New System.Drawing.Point(22, 153)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEditar.IconColor = System.Drawing.Color.Black
        Me.btnEditar.IconSize = 16
        Me.btnEditar.Location = New System.Drawing.Point(119, 153)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Rotation = 0R
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 3
        Me.btnEditar.Text = "EDITAR"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnAgregar.IconColor = System.Drawing.Color.Black
        Me.btnAgregar.IconSize = 16
        Me.btnAgregar.Location = New System.Drawing.Point(216, 153)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Rotation = 0R
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtIdCurso
        '
        Me.txtIdCurso.Location = New System.Drawing.Point(119, 91)
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(28, 20)
        Me.txtIdCurso.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCurso)
        Me.GroupBox1.Controls.Add(Me.txtIdCurso)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Location = New System.Drawing.Point(313, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 209)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURSO"
        '
        'frmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 281)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_Curso)
        Me.Name = "frmCurso"
        Me.Text = "frmCurso"
        CType(Me.dgv_Curso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Curso As DataGridView
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents txtIdCurso As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
