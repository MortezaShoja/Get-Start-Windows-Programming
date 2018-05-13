Public Class MyException
    Inherits Exception


    Public Overrides ReadOnly Property Message() As String
        Get
            Return ("division by one occured !")
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return ("Œÿ«Ì œ·ŒÊ«Â ‘„« —Œ ‰œ«œÂ")
    End Function
End Class
Public Class YourException
    Inherits Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return ("division by Two Occured ! :)")
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return ("Œÿ«Ì œ·ŒÊ«Â ‘„« —Œ œ«œÂ")
    End Function
End Class

Public Class OptionalException
    Inherits Exception

    Dim ts As String
    Dim msg As String

    Public Sub New(ByVal argTS As String, ByVal argMSG As String)
        ts = argTS
        msg = argMSG
    End Sub


    Public Overrides ReadOnly Property Message() As String
        Get
            Return (msg)
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return (ts)
    End Function
End Class