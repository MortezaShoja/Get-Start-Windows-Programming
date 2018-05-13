Public Class Form1
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
    Friend WithEvents NText1 As NTEXT.NText
    Friend WithEvents UserControl11 As MyC.UserControl1
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.NText1 = New NTEXT.NText
        Me.UserControl11 = New MyC.UserControl1
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'NText1
        '
        Me.NText1.Location = New System.Drawing.Point(168, 8)
        Me.NText1.Name = "NText1"
        Me.NText1.TabIndex = 0
        Me.NText1.Text = ""
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(8, 8)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(150, 112)
        Me.UserControl11.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 125)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.NText1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'messagebox.Show
        Dim mys As New sample
        'mys.Show()
        'Dim j As Integer = 2
        mys.Age = 10
        'mys.Show(j)
        'mys.Mark(0) = 100
        'mys(1) = 90
        'MessageBox.Show(mys(1).ToString)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles Button1.Click, Button2.Click
        MessageBox.Show("clicked")
    End Sub

    Public Sub bc(ByVal o As Object, ByVal ev As EventArgs) Handles Button1.Click
        MessageBox.Show("Again Handled")
    End Sub

    Private Sub Button1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Enter

    End Sub
End Class

Public Class sample

    Private cF As String
    Private cA As Byte

    Public Property Age() As Byte
        Get
            Return (cA)
        End Get
        Set(ByVal Value As Byte)
            If Value > 1 AndAlso Value < 100 Then
                cA = Value
            Else
                MessageBox.Show("Invalid Age !")
            End If
        End Set
    End Property

    Public Property Family() As String
        Get
            Return (cF)
        End Get
        Set(ByVal Value As String)
            cF = Value
        End Set
    End Property

    Public ReadOnly Property F()
        Get

        End Get
    End Property

    Public Function Show()
        MessageBox.Show("NOTHING")
    End Function

    Public Function Show(ByVal i As Integer)
        MessageBox.Show((i * 2).ToString)
    End Function

    Private cM(2) As Double

    Default Public Property Mark(ByVal index As Integer) As Double
        Get
            Return (cM(index))
        End Get
        Set(ByVal Value As Double)
            cM(index) = Value
        End Set
    End Property
End Class