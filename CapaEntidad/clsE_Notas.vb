Public Class clsE_Notas
    Private idNota
    Private notaAlumno
    Private notaCurso
    Private nota1
    Private nota2
    Private nota3
    Private nota4

    Public Property _idNota As Integer
        Get
            Return idNota
        End Get
        Set(value As Integer)
            idNota = value
        End Set
    End Property
    Public Property _notaAlumno As Integer
        Get
            Return notaAlumno
        End Get
        Set(value As Integer)
            notaAlumno = value
        End Set
    End Property
    Public Property _notaCurso As Integer
        Get
            Return notaCurso
        End Get
        Set(value As Integer)
            notaCurso = value
        End Set
    End Property
    Public Property _nota1 As Double
        Get
            Return nota1
        End Get
        Set(value As Double)
            nota1 = value
        End Set
    End Property
    Public Property _nota2 As Double
        Get
            Return nota2
        End Get
        Set(value As Double)
            nota2 = value
        End Set
    End Property
    Public Property _nota3 As Double
        Get
            Return nota3
        End Get
        Set(value As Double)
            nota3 = value
        End Set
    End Property
    Public Property _nota4 As Double
        Get
            Return nota4
        End Get
        Set(value As Double)
            nota4 = value
        End Set
    End Property

End Class
