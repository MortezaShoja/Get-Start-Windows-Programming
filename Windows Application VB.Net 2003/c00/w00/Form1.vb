Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim dvwPhones As DataView


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
    Friend WithEvents dbgphone As System.Windows.Forms.DataGrid
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents btnF As System.Windows.Forms.Button
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbgphone = New System.Windows.Forms.DataGrid
        Me.btnE = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnN = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtF = New System.Windows.Forms.TextBox
        Me.btnF = New System.Windows.Forms.Button
        Me.txtN = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.dbgphone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dbgphone
        '
        Me.dbgphone.DataMember = ""
        Me.dbgphone.Dock = System.Windows.Forms.DockStyle.Top
        Me.dbgphone.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgphone.Location = New System.Drawing.Point(0, 0)
        Me.dbgphone.Name = "dbgphone"
        Me.dbgphone.Size = New System.Drawing.Size(264, 325)
        Me.dbgphone.TabIndex = 0
        '
        'btnE
        '
        Me.btnE.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnE.Location = New System.Drawing.Point(232, 328)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(24, 23)
        Me.btnE.TabIndex = 5
        Me.btnE.Text = "a"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.btnN)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtF)
        Me.Panel1.Controls.Add(Me.btnF)
        Me.Panel1.Controls.Add(Me.txtN)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(8, 360)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 112)
        Me.Panel1.TabIndex = 6
        '
        'btnN
        '
        Me.btnN.Location = New System.Drawing.Point(71, 77)
        Me.btnN.Name = "btnN"
        Me.btnN.TabIndex = 10
        Me.btnN.Text = "No Filter"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Family"
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(71, 13)
        Me.txtF.Name = "txtF"
        Me.txtF.Size = New System.Drawing.Size(160, 20)
        Me.txtF.TabIndex = 7
        Me.txtF.Text = ""
        '
        'btnF
        '
        Me.btnF.Location = New System.Drawing.Point(159, 77)
        Me.btnF.Name = "btnF"
        Me.btnF.TabIndex = 5
        Me.btnF.Text = "Filter"
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(71, 45)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(160, 20)
        Me.txtN.TabIndex = 6
        Me.txtN.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(7, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(264, 357)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.dbgphone)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Silver
        CType(Me.dbgphone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        sqlcon.Open()
        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM phones", sqlcon)
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Dim tbl As New DataTable("Phones")
        Dim fc As Integer
        For fc = 0 To sdr.FieldCount - 1
            tbl.Columns.Add(sdr.GetName(fc))
        Next
        While sdr.Read
            Dim Row As DataRow = tbl.NewRow
            For fc = 0 To sdr.FieldCount - 1
                Row.Item(fc) = sdr(fc)
            Next
            tbl.Rows.Add(Row)
        End While
        dvwPhones = New DataView(tbl)
        dbgphone.DataSource = dvwPhones
        sqlcon.Close()
    End Sub

    Private Sub btnN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dvwPhones.RowFilter = ""
    End Sub

    Private Sub btnF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dvwPhones.RowFilter = "family='" & txtF.Text & "' AND name='" & txtN.Text & "'"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If btnE.Text = "a" Then
            btnE.Text = "r"
            Me.Height = 504
        Else
            btnE.Text = "a"
            Me.Height = 384
        End If
    End Sub
End Class
