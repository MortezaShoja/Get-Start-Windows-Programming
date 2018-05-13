Public Class cNewTeen
    Private cA As Byte
    Public Event OutOfRange(ByVal argAge As Byte, ByVal message As String)

    Public Property Age() As Byte
        Get
            Return (cA)
        End Get
        Set(ByVal Value As Byte)
            If Value > 12 And Value < 20 Then
                cA = Value
            Else
                Dim msg As String
                If Value < 13 Then
                    msg = " is younger than a teen"
                Else
                    msg = " is older than a teen"
                End If
                RaiseEvent OutOfRange(Value, msg)
            End If
        End Set
    End Property
End Class
