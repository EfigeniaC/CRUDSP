<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORMULARIOPRINCIPAL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORMULARIOPRINCIPAL))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnR_Alumnos = New FontAwesome.Sharp.IconButton()
        Me.btnCursos = New FontAwesome.Sharp.IconButton()
        Me.btnNotas = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(51, 79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnR_Alumnos
        '
        Me.btnR_Alumnos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnR_Alumnos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnR_Alumnos.FlatAppearance.BorderSize = 0
        Me.btnR_Alumnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnR_Alumnos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnR_Alumnos.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnR_Alumnos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnR_Alumnos.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnR_Alumnos.IconColor = System.Drawing.Color.AntiqueWhite
        Me.btnR_Alumnos.IconSize = 25
        Me.btnR_Alumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnR_Alumnos.Location = New System.Drawing.Point(51, 275)
        Me.btnR_Alumnos.Name = "btnR_Alumnos"
        Me.btnR_Alumnos.Rotation = 0R
        Me.btnR_Alumnos.Size = New System.Drawing.Size(200, 31)
        Me.btnR_Alumnos.TabIndex = 1
        Me.btnR_Alumnos.Text = "REGISTRAR ALUMNOS"
        Me.btnR_Alumnos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnR_Alumnos.UseVisualStyleBackColor = False
        '
        'btnCursos
        '
        Me.btnCursos.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCursos.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCursos.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCursos.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCursos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCursos.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.btnCursos.IconColor = System.Drawing.Color.BlanchedAlmond
        Me.btnCursos.IconSize = 25
        Me.btnCursos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCursos.Location = New System.Drawing.Point(51, 312)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Rotation = 0R
        Me.btnCursos.Size = New System.Drawing.Size(200, 31)
        Me.btnCursos.TabIndex = 2
        Me.btnCursos.Text = "REGISTRAR CURSOS"
        Me.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCursos.UseVisualStyleBackColor = False
        '
        'btnNotas
        '
        Me.btnNotas.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNotas.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnNotas.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNotas.IconChar = FontAwesome.Sharp.IconChar.Magic
        Me.btnNotas.IconColor = System.Drawing.SystemColors.ButtonFace
        Me.btnNotas.IconSize = 25
        Me.btnNotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNotas.Location = New System.Drawing.Point(51, 349)
        Me.btnNotas.Name = "btnNotas"
        Me.btnNotas.Rotation = 0R
        Me.btnNotas.Size = New System.Drawing.Size(200, 31)
        Me.btnNotas.TabIndex = 3
        Me.btnNotas.Text = "REGISTRAR NOTAS"
        Me.btnNotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "REGISTRO DE NOTAS DE ALUMNOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label2.Location = New System.Drawing.Point(47, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ALUMNO:CYNTHIA CARRILLO"
        '
        'FORMULARIOPRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(300, 393)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNotas)
        Me.Controls.Add(Me.btnCursos)
        Me.Controls.Add(Me.btnR_Alumnos)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FORMULARIOPRINCIPAL"
        Me.Text = "FORMULARIOPRINCIPAL"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnR_Alumnos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCursos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnNotas As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
