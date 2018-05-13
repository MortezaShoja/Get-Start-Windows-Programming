Public Class cStd

    Private myPersonalInfo As cPersonalInfo

    Private myAddress As cAddress

    Private myED As cED

    Public Property PersonalInfo() As cPersonalInfo
        Get
            Return (myPersonalInfo)
        End Get
        Set(ByVal Value As cPersonalInfo)
            myPersonalInfo = Value
        End Set
    End Property

    Public Property Address() As cAddress
        Get
            Return (myAddress)
        End Get
        Set(ByVal Value As cAddress)
            myAddress = Value
        End Set
    End Property

    Public Property ED() As cED
        Get
            Return (myED)
        End Get
        Set(ByVal Value As cED)
            myED = Value
        End Set
    End Property

    Public Class cPersonalInfo
        Private cF As String
        Private cN As String

        Public Property Family() As String
            Get
                Return (cF)
            End Get
            Set(ByVal Value As String)
                cF = Value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return (cN)
            End Get
            Set(ByVal Value As String)
                cN = Value
            End Set
        End Property
    End Class

    Public Class cAddress
        Private cC As String
        Private cN As Integer

        Public Property City() As String
            Get
                Return (cC)
            End Get
            Set(ByVal Value As String)
                cC = Value
            End Set
        End Property

        Public Property Number() As Integer
            Get
                Return (cN)
            End Get
            Set(ByVal Value As Integer)
                cN = Value
            End Set
        End Property
    End Class

    Public Class cED
        Private cY As Integer
        Private cM As Integer
        Private cD As Integer

        Public Property Year() As Integer
            Get
                Return (cY)
            End Get
            Set(ByVal Value As Integer)
                cY = Value
            End Set
        End Property

        Public Property Month() As Integer
            Get
                Return (cM)
            End Get
            Set(ByVal Value As Integer)
                cM = Value
            End Set
        End Property


        Public Property Day() As Integer
            Get
                Return (cD)
            End Get
            Set(ByVal Value As Integer)
                cD = Value
            End Set
        End Property
    End Class

    Public Sub New()
        myPersonalInfo = New cPersonalInfo
        myAddress = New cAddress
        myED = New cED
    End Sub
End Class
