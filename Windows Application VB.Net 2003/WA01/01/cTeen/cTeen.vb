Public Class cTeen
    Private cA As Byte
    Public Event Older(ByVal argAge As Byte)
    Public Event Younger(ByVal argAge As Byte)

    Public Property Age() As Byte
        Get
            Return (cA)
        End Get
        Set(ByVal Value As Byte)
            If Value < 13 Then
                RaiseEvent Younger(Value)
            ElseIf Value > 19 Then
                RaiseEvent Older(Value)
            Else
                cA = Value
            End If
        End Set
    End Property
End Class
