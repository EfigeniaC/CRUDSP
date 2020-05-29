Public Class clsE_Curso
    Private idCurso
    Private curso

    Public Property _idCurso As Integer
        Get
            Return idCurso
        End Get
        Set(value As Integer)
            idCurso = value
        End Set
    End Property
    Public Property _curso As String
        Get
            Return curso
        End Get
        Set(value As String)
            curso = value
        End Set
    End Property
End Class
