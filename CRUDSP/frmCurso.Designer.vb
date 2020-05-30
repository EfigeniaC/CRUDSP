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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurso))
        Me.dgv_Curso = New System.Windows.Forms.DataGridView()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_Curso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Curso
        '
        Me.dgv_Curso.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_Curso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Curso.Location = New System.Drawing.Point(17, 173)
        Me.dgv_Curso.Name = "dgv_Curso"
        Me.dgv_Curso.RowHeadersVisible = False
        Me.dgv_Curso.Size = New System.Drawing.Size(238, 95)
        Me.dgv_Curso.TabIndex = 0
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(143, 147)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(110, 20)
        Me.txtCurso.TabIndex = 1
        '
        'txtIdCurso
        '
        Me.txtIdCurso.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCurso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdCurso.Enabled = False
        Me.txtIdCurso.ForeColor = System.Drawing.Color.Ivory
        Me.txtIdCurso.Location = New System.Drawing.Point(6, 19)
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(28, 13)
        Me.txtIdCurso.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.dgv_Curso)
        Me.GroupBox1.Controls.Add(Me.btnAgregar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnEditar)
        Me.GroupBox1.Controls.Add(Me.txtCurso)
        Me.GroupBox1.Controls.Add(Me.txtIdCurso)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 287)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURSO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CURSO:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnNuevo.IconColor = System.Drawing.Color.Black
        Me.btnNuevo.IconSize = 18
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevo.Location = New System.Drawing.Point(261, 158)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Rotation = 0R
        Me.btnNuevo.Size = New System.Drawing.Size(90, 23)
        Me.btnNuevo.TabIndex = 17
        Me.btnNuevo.Text = "NUEVO"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.User
        Me.btnAgregar.IconColor = System.Drawing.Color.Black
        Me.btnAgregar.IconSize = 18
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.Location = New System.Drawing.Point(261, 187)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Rotation = 0R
        Me.btnAgregar.Size = New System.Drawing.Size(90, 23)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconSize = 18
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.Location = New System.Drawing.Point(261, 245)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(90, 23)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEditar.IconColor = System.Drawing.Color.Black
        Me.btnEditar.IconSize = 18
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditar.Location = New System.Drawing.Point(261, 216)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Rotation = 0R
        Me.btnEditar.Size = New System.Drawing.Size(90, 23)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "MODIFICAR"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 145)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'frmCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(401, 319)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCurso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORMULARIO CURSO"
        CType(Me.dgv_Curso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Curso As DataGridView
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents txtIdCurso As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
