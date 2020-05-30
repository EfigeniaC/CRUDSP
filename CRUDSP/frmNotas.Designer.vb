<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotas))
        Me.dgv_Notas = New System.Windows.Forms.DataGridView()
        Me.NOTAS = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.txtIdNota = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnota4 = New System.Windows.Forms.TextBox()
        Me.txtnota3 = New System.Windows.Forms.TextBox()
        Me.txtnota2 = New System.Windows.Forms.TextBox()
        Me.txtnota1 = New System.Windows.Forms.TextBox()
        Me.btnEliminar = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New FontAwesome.Sharp.IconButton()
        Me.btnAgregar = New FontAwesome.Sharp.IconButton()
        Me.cmbAlumno = New System.Windows.Forms.ComboBox()
        Me.cmbCursos = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_Notas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NOTAS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Notas
        '
        Me.dgv_Notas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Notas.Location = New System.Drawing.Point(12, 168)
        Me.dgv_Notas.Name = "dgv_Notas"
        Me.dgv_Notas.RowHeadersVisible = False
        Me.dgv_Notas.Size = New System.Drawing.Size(766, 187)
        Me.dgv_Notas.TabIndex = 0
        '
        'NOTAS
        '
        Me.NOTAS.Controls.Add(Me.PictureBox1)
        Me.NOTAS.Controls.Add(Me.IconButton1)
        Me.NOTAS.Controls.Add(Me.txtIdNota)
        Me.NOTAS.Controls.Add(Me.Label6)
        Me.NOTAS.Controls.Add(Me.Label5)
        Me.NOTAS.Controls.Add(Me.Label4)
        Me.NOTAS.Controls.Add(Me.Label3)
        Me.NOTAS.Controls.Add(Me.Label2)
        Me.NOTAS.Controls.Add(Me.Label1)
        Me.NOTAS.Controls.Add(Me.txtnota4)
        Me.NOTAS.Controls.Add(Me.txtnota3)
        Me.NOTAS.Controls.Add(Me.txtnota2)
        Me.NOTAS.Controls.Add(Me.txtnota1)
        Me.NOTAS.Controls.Add(Me.btnEliminar)
        Me.NOTAS.Controls.Add(Me.btnEditar)
        Me.NOTAS.Controls.Add(Me.btnAgregar)
        Me.NOTAS.Controls.Add(Me.cmbAlumno)
        Me.NOTAS.Controls.Add(Me.cmbCursos)
        Me.NOTAS.Location = New System.Drawing.Point(12, 12)
        Me.NOTAS.Name = "NOTAS"
        Me.NOTAS.Size = New System.Drawing.Size(766, 150)
        Me.NOTAS.TabIndex = 1
        Me.NOTAS.TabStop = False
        Me.NOTAS.Text = "NOTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 110)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(653, 20)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(75, 23)
        Me.IconButton1.TabIndex = 16
        Me.IconButton1.Text = "NUEVO"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'txtIdNota
        '
        Me.txtIdNota.BackColor = System.Drawing.SystemColors.Desktop
        Me.txtIdNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIdNota.Enabled = False
        Me.txtIdNota.ForeColor = System.Drawing.SystemColors.Info
        Me.txtIdNota.Location = New System.Drawing.Point(6, 19)
        Me.txtIdNota.Name = "txtIdNota"
        Me.txtIdNota.Size = New System.Drawing.Size(29, 13)
        Me.txtIdNota.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(502, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "NOTAFINAL:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(430, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "NOTA3:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "NOTA2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "NOTA1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ALUMNO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(234, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CURSO:"
        '
        'txtnota4
        '
        Me.txtnota4.Location = New System.Drawing.Point(505, 96)
        Me.txtnota4.Name = "txtnota4"
        Me.txtnota4.Size = New System.Drawing.Size(65, 20)
        Me.txtnota4.TabIndex = 8
        '
        'txtnota3
        '
        Me.txtnota3.Location = New System.Drawing.Point(433, 96)
        Me.txtnota3.Name = "txtnota3"
        Me.txtnota3.Size = New System.Drawing.Size(65, 20)
        Me.txtnota3.TabIndex = 7
        '
        'txtnota2
        '
        Me.txtnota2.Location = New System.Drawing.Point(362, 96)
        Me.txtnota2.Name = "txtnota2"
        Me.txtnota2.Size = New System.Drawing.Size(65, 20)
        Me.txtnota2.TabIndex = 6
        '
        'txtnota1
        '
        Me.txtnota1.Location = New System.Drawing.Point(291, 96)
        Me.txtnota1.Name = "txtnota1"
        Me.txtnota1.Size = New System.Drawing.Size(65, 20)
        Me.txtnota1.TabIndex = 5
        '
        'btnEliminar
        '
        Me.btnEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEliminar.IconColor = System.Drawing.Color.Black
        Me.btnEliminar.IconSize = 16
        Me.btnEliminar.Location = New System.Drawing.Point(653, 110)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Rotation = 0R
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnEditar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEditar.IconColor = System.Drawing.Color.Black
        Me.btnEditar.IconSize = 16
        Me.btnEditar.Location = New System.Drawing.Point(653, 81)
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
        Me.btnAgregar.Location = New System.Drawing.Point(653, 52)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Rotation = 0R
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'cmbAlumno
        '
        Me.cmbAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbAlumno.FormattingEnabled = True
        Me.cmbAlumno.Location = New System.Drawing.Point(291, 49)
        Me.cmbAlumno.Name = "cmbAlumno"
        Me.cmbAlumno.Size = New System.Drawing.Size(227, 21)
        Me.cmbAlumno.TabIndex = 1
        Me.cmbAlumno.Text = "SELECIONAR OPCION"
        '
        'cmbCursos
        '
        Me.cmbCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbCursos.FormattingEnabled = True
        Me.cmbCursos.Location = New System.Drawing.Point(291, 20)
        Me.cmbCursos.Name = "cmbCursos"
        Me.cmbCursos.Size = New System.Drawing.Size(227, 21)
        Me.cmbCursos.TabIndex = 0
        Me.cmbCursos.Text = "SELECIONAR OPCION"
        '
        'frmNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(802, 369)
        Me.Controls.Add(Me.NOTAS)
        Me.Controls.Add(Me.dgv_Notas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FROMULARIOS NOTAS"
        CType(Me.dgv_Notas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NOTAS.ResumeLayout(False)
        Me.NOTAS.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Notas As DataGridView
    Friend WithEvents NOTAS As GroupBox
    Friend WithEvents cmbCursos As ComboBox
    Friend WithEvents cmbAlumno As ComboBox
    Friend WithEvents btnEliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAgregar As FontAwesome.Sharp.IconButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnota4 As TextBox
    Friend WithEvents txtnota3 As TextBox
    Friend WithEvents txtnota2 As TextBox
    Friend WithEvents txtnota1 As TextBox
    Friend WithEvents txtIdNota As TextBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
