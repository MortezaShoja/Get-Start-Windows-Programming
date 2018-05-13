Public Class Form2
    Inherits System.Windows.Forms.Form

    Dim Result As String
    Dim MyParent As Form1

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal parent As Form1)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        MyParent = parent
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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnC As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox
        Me.btnC = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(8, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(216, 20)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = ""
        '
        'btnC
        '
        Me.btnC.Location = New System.Drawing.Point(8, 40)
        Me.btnC.Name = "btnC"
        Me.btnC.TabIndex = 1
        Me.btnC.Text = "Create"
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(232, 72)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnC.Click
        MyParent.DirName = txtName.Text
        Me.Close()
    End Sub
End Class
