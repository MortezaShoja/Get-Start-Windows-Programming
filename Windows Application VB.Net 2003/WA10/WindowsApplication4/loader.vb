Public Class loader
    Public Shared Sub main(ByVal args() As String)
        Dim frm As Form

        If args.Length <> 0 Then
            Select Case args(0)
                Case Is = "form1"
                    frm = New Form1

                Case Is = "form2"
                    frm = New Form2

                Case Is = "form3"
                    frm = New Form3

                Case Else
                    frm = New Form4

            End Select
        End If
        If args.Length = 2 Then
            Select Case args(1)
                Case Is = "red"
                    frm.BackColor = Color.Red
                Case Is = "green"
                    frm.BackColor = Color.Green
            End Select
        End If
        Application.Run(frm)
    End Sub
End Class
