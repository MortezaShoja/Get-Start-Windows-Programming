Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim WithEvents myT As cTeen.cTeen

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
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents btnS As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtA = New System.Windows.Forms.TextBox
        Me.btnS = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(8, 24)
        Me.txtA.Name = "txtA"
        Me.txtA.TabIndex = 0
        Me.txtA.Text = ""
        '
        'btnS
        '
        Me.btnS.Location = New System.Drawing.Point(16, 72)
        Me.btnS.Name = "btnS"
        Me.btnS.TabIndex = 1
        Me.btnS.Text = "submit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(128, 125)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.txtA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myT = New cTeen.cTeen
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        myT.Age = Byte.Parse(txtA.Text)
    End Sub

    Public Sub myT_older(ByVal i As Byte) Handles myT.Older
        MessageBox.Show(i.ToString & " is older than a teen")
    End Sub

    Public Sub myT_younger(ByVal i As Byte) Handles myT.Younger
        MessageBox.Show(i.ToString & " is younger than a teen")
    End Sub

End Class
