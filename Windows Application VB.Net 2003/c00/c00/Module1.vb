Imports System.Data.SqlClient

Module Module1

    Sub Main()
        While (True)
            Console.Write("Enter Family [exit to quit] : ")
            Dim family As String = Console.ReadLine
            If family = "exit" Then
                Exit While
            End If
            Console.Write("Enter Name [exit to quit] : ")
            Dim name As String = Console.ReadLine
            If name = "exit" Then
                Exit While
            End If
            Dim sqlcon As New SqlConnection 'SqlClient.SqlConnection
            sqlcon.ConnectionString = "server=local;data source=""."";integrated security=sspi;database=phonebook"
            sqlcon.Open()
            Dim cmd As New SqlCommand 'SqlClient.SqlCommand
            cmd.Connection = sqlcon
            cmd.CommandText = "SELECT family ,phone FROM phones WHERE family='" & _
            family & "' AND name='" & name & "'"
            Dim sdr As SqlDataReader = cmd.ExecuteReader

            If sdr.Read() Then
                Console.WriteLine(sdr.GetString(0) & "->" & sdr.GetString(1))
            Else
                Console.WriteLine("Not Found !")
            End If
            sdr.Close()
            sqlcon.Close()
        End While
    End Sub

End Module
