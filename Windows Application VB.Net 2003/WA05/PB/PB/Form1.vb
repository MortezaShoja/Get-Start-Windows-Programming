Public Class frmL
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
    Friend WithEvents btnL As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents txtU As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnL = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.txtP = New System.Windows.Forms.TextBox
        Me.txtU = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnL
        '
        Me.btnL.Location = New System.Drawing.Point(120, 80)
        Me.btnL.Name = "btnL"
        Me.btnL.Size = New System.Drawing.Size(48, 23)
        Me.btnL.TabIndex = 2
        Me.btnL.Text = "LogIn"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Reset"
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(120, 40)
        Me.txtP.Name = "txtP"
        Me.txtP.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtP.Size = New System.Drawing.Size(112, 20)
        Me.txtP.TabIndex = 1
        Me.txtP.Text = ""
        '
        'txtU
        '
        Me.txtU.Location = New System.Drawing.Point(120, 8)
        Me.txtU.Name = "txtU"
        Me.txtU.Size = New System.Drawing.Size(112, 20)
        Me.txtU.TabIndex = 0
        Me.txtU.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password : "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username : "
        '
        'frmL
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(242, 119)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtU)
        Me.Controls.Add(Me.txtP)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmL"
        Me.Text = "LogIn"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
    End Sub

    Private Sub btnL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnL.Click
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        Dim cmd As New SqlClient.SqlCommand("SELECT COUNT(un) FROM Users WHERE un='" & _
        txtU.Text & "' AND pwd='" & txtP.Text & "'", sqlcon)
        sqlcon.Open()
        If CType(cmd.ExecuteScalar, Integer) = 1 Then
            frmMian.f = True
            Me.Close()

        Else
            Button2_Click(Me, New EventArgs)
        End If
        sqlcon.Close()
    End Sub
End Class
