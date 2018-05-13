Public Class Form2
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 64)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(96, 8)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 64)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Button1"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(96, 80)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 64)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Button2"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(184, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(72, 64)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "Button1"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(184, 80)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 64)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Button2"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(96, 160)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 64)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Button2"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(8, 160)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 64)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Button2"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(184, 160)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 64)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Button2"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 229)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub C(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, Button).BackColor = Color.Red
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is Button Then
                AddHandler CType(o, Button).Click, AddressOf C
            End If
        Next
        Student.Show()

        'Student.Enterance = 1385

        Dim mys As New Student
        ' MessageBox.Show(mys.Enterance)
        mys.Enterance = 1385

        Dim mys1 As New Student
        MessageBox.Show(mys1.Enterance)
        ' Student.Enterance()
    End Sub


End Class

Public Class Student
    Public Shared Sub Show()
        MessageBox.Show(Now.Date.ToShortDateString)
    End Sub

    Private Shared cE As Integer

    Public Shared Property Enterance() As Integer
        Get
            Return (cE)
        End Get
        Set(ByVal Value As Integer)
            cE = Value
        End Set
    End Property
End Class