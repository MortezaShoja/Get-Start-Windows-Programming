Public Class Form1
    Inherits System.Windows.Forms.Form

    'Dim fs As IO.FileStream
    'Dim twtl As TextWriterTraceListener

    Dim ev As EventLog
    Dim eltl As EventLogTraceListener

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(208, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(208, 128)
        Me.Button3.Name = "Button3"
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "temp"
    'Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Try
    '    '    Dim i, j As Integer
    '    '    j = 1
    '    '    i = j / 0
    '    'Catch ex As Exception
    '    '    Dim sw As New IO.StreamWriter("log.txt", True)
    '    '    sw.WriteLine(Now.Date.ToShortDateString & "  " & _
    '    '    Now.TimeOfDay.ToString & "  " & ex.Message)
    '    '    sw.Flush()
    '    'End Try

    '    If IO.File.Exists("trace.txt") Then
    '        fs = New IO.FileStream("trace.txt", IO.FileMode.Append)
    '    Else
    '        fs = New IO.FileStream("trace.txt", IO.FileMode.Create)
    '    End If

    '    ' twtl = New TextWriterTraceListener(fs)
    '    twtl = New TextWriterTraceListener("sample.txt")
    '    Trace.Listeners.Add(twtl)
    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        Dim i, j As Integer
    '        j = 1
    '        i = j / 0
    '    Catch ex As Exception
    '        Trace.WriteLine(Now.ToString & " : " & ex.Message)
    '        Trace.Flush()
    '    End Try
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Debug.Assert(2 < 1)
    'End Sub
#End Region
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim i, j As Integer
            i = 1
            j = i / 0
        Catch ex As Exception
            Trace.Write(ex.Message)
            Trace.Flush()
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ev = New EventLog("App")
        ev.Source = "App"
        eltl = New EventLogTraceListener(ev)
        Trace.Listeners.Add(eltl)
    End Sub
End Class
