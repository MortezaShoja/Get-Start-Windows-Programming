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
    Friend WithEvents MyControl1 As MyControl.MyControl
    Friend WithEvents MyControl2 As MyControl.MyControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MyControl1 = New MyControl.MyControl
        Me.MyControl2 = New MyControl.MyControl
        Me.SuspendLayout()
        '
        'MyControl1
        '
        Me.MyControl1.Location = New System.Drawing.Point(0, 0)
        Me.MyControl1.Name = "MyControl1"
        Me.MyControl1.Size = New System.Drawing.Size(88, 20)
        Me.MyControl1.TabIndex = 0
        Me.MyControl1.Text = "MyControl1"
        '
        'MyControl2
        '
        Me.MyControl2.Location = New System.Drawing.Point(0, 0)
        Me.MyControl2.Name = "MyControl2"
        Me.MyControl2.Size = New System.Drawing.Size(88, 20)
        Me.MyControl2.TabIndex = 1
        Me.MyControl2.Text = "MyControl2"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.MyControl2)
        Me.Controls.Add(Me.MyControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
