Public Class Form4
    Inherits System.Windows.Forms.Form

    Dim myParent As Form3

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal argF As Form3)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        myParent = argF
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
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents btnF As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtF = New System.Windows.Forms.TextBox
        Me.btnF = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(8, 8)
        Me.txtF.Name = "txtF"
        Me.txtF.TabIndex = 0
        Me.txtF.Text = ""
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(120, 8)
        Me.btnF.Name = "btnF"
        Me.btnF.TabIndex = 1
        Me.btnF.Text = "Filter"
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(208, 45)
        Me.Controls.Add(Me.btnF)
        Me.Controls.Add(Me.txtF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Opacity = 0.5
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF.Click
        myParent.rf = "Family='" & txtF.Text & "'"
        Me.Close()
    End Sub
End Class
