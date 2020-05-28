Public Class clsE_Alumno
    Private idAlumno
    Private nombreAlumno
    Private apellidoAlumno
    Private sexoAlumno
    Private numeroAlumno
    Private emailAlumno

    Public Property _idAlumno As Integer
        Get
            Return idAlumno
        End Get
        Set(value As Integer)
            idAlumno = value
        End Set
    End Property
    Public Property _nombreAlumno As String
        Get
            Return nombreAlumno
        End Get
        Set(value As String)
            nombreAlumno = value
        End Set
    End Property
    Public Property _apellidoAlumno As String
        Get
            Return apellidoAlumno
        End Get
        Set(value As String)
            apellidoAlumno = value
        End Set
    End Property
    Public Property _sexoAlumno As Char
        Get
            Return sexoAlumno
        End Get
        Set(value As Char)
            sexoAlumno = value
        End Set
    End Property
    Public Property _numeroAlumno As String
        Get
            Return numeroAlumno
        End Get
        Set(value As String)
            numeroAlumno = value
        End Set
    End Property
    Public Property _emailAlumno As String
        Get
            Return emailAlumno
        End Get
        Set(value As String)
            emailAlumno = value
        End Set
    End Property
End Class
