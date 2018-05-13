Public Class Form9
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "TextBox1"
        '
        'Form9
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try
        '    If Integer.Parse(TextBox1.Text) = 1 Then
        '        Throw New MyException
        '    ElseIf Integer.Parse(TextBox1.Text) = 2 Then
        '        Throw New YourException
        '    Else
        '        Dim i As Integer
        '        i = 10 / Integer.Parse(TextBox1.Text)
        '        MsgBox(i.ToString)
        '    End If
        'Catch e1 As MyException
        '    MsgBox("division by One !")
        '    MsgBox(e1.Message)
        '    MsgBox(e1.ToString)
        'Catch e2 As YourException
        '    MsgBox("division by Two !")
        '    MsgBox(e2.Message)
        '    MsgBox(e2.ToString)
        'Catch ex As OverflowException
        '    MsgBox("division by zero !")
        '    MsgBox(ex.Message)
        'End Try
        Try

            If TextBox1.Text = "" Then
                Throw New OptionalException("Œ«·ÌÂ", "Is empty")
            End If
        Catch ex As OptionalException
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
