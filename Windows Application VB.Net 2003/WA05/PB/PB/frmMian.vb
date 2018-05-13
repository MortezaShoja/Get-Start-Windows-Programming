Public Class frmMian
    Inherits System.Windows.Forms.Form

    Dim tbl As DataTable
    Dim dvw As DataView

    Dim b As Boolean
    Public Shared f As Boolean

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
    Friend WithEvents cmu As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents pnlIns As System.Windows.Forms.Panel
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnR As System.Windows.Forms.Button
    Friend WithEvents txtP As System.Windows.Forms.TextBox
    Friend WithEvents txtN As System.Windows.Forms.TextBox
    Friend WithEvents txtF As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnD As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents pnlD As System.Windows.Forms.Panel
    Friend WithEvents pnlAll As System.Windows.Forms.Panel
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents txtSF As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents btnE As System.Windows.Forms.Button
    Friend WithEvents tlp As System.Windows.Forms.ToolTip
    Friend WithEvents sqlcon As System.Data.SqlClient.SqlConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cmu = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.pnlIns = New System.Windows.Forms.Panel
        Me.txtF = New System.Windows.Forms.TextBox
        Me.txtN = New System.Windows.Forms.TextBox
        Me.txtP = New System.Windows.Forms.TextBox
        Me.btnR = New System.Windows.Forms.Button
        Me.btnA = New System.Windows.Forms.Button
        Me.pnlD = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnD = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.pnlAll = New System.Windows.Forms.Panel
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.txtSF = New System.Windows.Forms.TextBox
        Me.txtSN = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnE = New System.Windows.Forms.Button
        Me.tlp = New System.Windows.Forms.ToolTip(Me.components)
        Me.sqlcon = New System.Data.SqlClient.SqlConnection
        Me.pnlIns.SuspendLayout()
        Me.pnlD.SuspendLayout()
        Me.pnlAll.SuspendLayout()
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmu
        '
        Me.cmu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem3})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "open"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.Text = "new"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "close"
        '
        'pnlIns
        '
        Me.pnlIns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlIns.Controls.Add(Me.txtF)
        Me.pnlIns.Controls.Add(Me.txtN)
        Me.pnlIns.Controls.Add(Me.txtP)
        Me.pnlIns.Controls.Add(Me.btnR)
        Me.pnlIns.Controls.Add(Me.btnA)
        Me.pnlIns.Location = New System.Drawing.Point(16, 16)
        Me.pnlIns.Name = "pnlIns"
        Me.pnlIns.Size = New System.Drawing.Size(176, 160)
        Me.pnlIns.TabIndex = 0
        Me.pnlIns.Tag = "Ins"
        Me.pnlIns.Visible = False
        '
        'txtF
        '
        Me.txtF.Location = New System.Drawing.Point(40, 16)
        Me.txtF.Name = "txtF"
        Me.txtF.TabIndex = 4
        Me.txtF.Text = ""
        '
        'txtN
        '
        Me.txtN.Location = New System.Drawing.Point(40, 48)
        Me.txtN.Name = "txtN"
        Me.txtN.TabIndex = 3
        Me.txtN.Text = ""
        '
        'txtP
        '
        Me.txtP.Location = New System.Drawing.Point(40, 80)
        Me.txtP.Name = "txtP"
        Me.txtP.TabIndex = 2
        Me.txtP.Text = ""
        '
        'btnR
        '
        Me.btnR.Location = New System.Drawing.Point(88, 112)
        Me.btnR.Name = "btnR"
        Me.btnR.Size = New System.Drawing.Size(56, 23)
        Me.btnR.TabIndex = 1
        Me.btnR.Text = "Reset"
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(40, 112)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(40, 23)
        Me.btnA.TabIndex = 0
        Me.btnA.Text = "Add"
        '
        'pnlD
        '
        Me.pnlD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlD.Controls.Add(Me.TextBox1)
        Me.pnlD.Controls.Add(Me.TextBox2)
        Me.pnlD.Controls.Add(Me.Button1)
        Me.pnlD.Controls.Add(Me.btnD)
        Me.pnlD.Location = New System.Drawing.Point(16, 16)
        Me.pnlD.Name = "pnlD"
        Me.pnlD.Size = New System.Drawing.Size(176, 160)
        Me.pnlD.TabIndex = 5
        Me.pnlD.Tag = "del"
        Me.pnlD.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(8, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(56, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 16)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Reset"
        '
        'btnD
        '
        Me.btnD.Location = New System.Drawing.Point(8, 96)
        Me.btnD.Name = "btnD"
        Me.btnD.Size = New System.Drawing.Size(40, 23)
        Me.btnD.TabIndex = 0
        Me.btnD.Text = "Del"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8, Me.MenuItem9, Me.MenuItem10, Me.MenuItem11})
        Me.MenuItem4.Text = "Actions"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "New"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "-"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Delete"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Text = "View"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 5
        Me.MenuItem10.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 6
        Me.MenuItem11.Text = "Search &&   Edit"
        '
        'pnlAll
        '
        Me.pnlAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAll.Controls.Add(Me.dbg)
        Me.pnlAll.Location = New System.Drawing.Point(16, 8)
        Me.pnlAll.Name = "pnlAll"
        Me.pnlAll.Size = New System.Drawing.Size(304, 192)
        Me.pnlAll.TabIndex = 6
        Me.pnlAll.Tag = "All"
        Me.pnlAll.Visible = False
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dbg.Size = New System.Drawing.Size(302, 190)
        Me.dbg.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.txtSF)
        Me.Panel1.Controls.Add(Me.txtSN)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnE)
        Me.Panel1.Location = New System.Drawing.Point(16, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 152)
        Me.Panel1.TabIndex = 1
        Me.Panel1.Tag = "s"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(168, 80)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(168, 48)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(168, 16)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'txtSF
        '
        Me.txtSF.Location = New System.Drawing.Point(32, 16)
        Me.txtSF.Name = "txtSF"
        Me.txtSF.TabIndex = 2
        Me.txtSF.Text = ""
        '
        'txtSN
        '
        Me.txtSN.Location = New System.Drawing.Point(32, 48)
        Me.txtSN.Name = "txtSN"
        Me.txtSN.TabIndex = 1
        Me.txtSN.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 80)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Search"
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(168, 112)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(104, 23)
        Me.btnE.TabIndex = 0
        Me.btnE.Text = "Edit"
        '
        'sqlcon
        '
        Me.sqlcon.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=PhoneBook"
        '
        'frmMian
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlAll)
        Me.Controls.Add(Me.pnlD)
        Me.Controls.Add(Me.pnlIns)
        Me.Controls.Add(Me.Panel1)
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMian"
        Me.Text = "frmMian"
        Me.pnlIns.ResumeLayout(False)
        Me.pnlD.ResumeLayout(False)
        Me.pnlAll.ResumeLayout(False)
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim frm As New frmL
        'frm.ShowDialog()

        'If Not f Then
        '    Application.Exit()
        'End If
        'If frm.DialogResult <> DialogResult.OK Then
        '    Application.Exit()
        'End If

        tbl = New DataTable("Phones")

    End Sub

    Private Sub frmMian_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            cmu.Show(Me, New Point(e.X, e.Y))
        End If
    End Sub

    Private Sub btnA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnA.Click
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        Dim cmd As New SqlClient.SqlCommand("INSERT INTO phones(family,name,phone) VALUES('" & _
        txtF.Text & "','" & txtN.Text & "','" & txtP.Text & "')", sqlcon)
        sqlcon.Open()
        If cmd.ExecuteNonQuery <> 1 Then
            MessageBox.Show("Failed", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Commited", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        sqlcon.Close()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is Panel Then
                If c.Tag <> "del" Then
                    c.Visible = False
                Else
                    c.Visible = True
                End If
            End If
        Next
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is Panel Then
                If c.Tag <> "Ins" Then
                    c.Visible = False
                Else
                    c.Visible = True
                End If
            End If
        Next
    End Sub

    Private Sub btnD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnD.Click
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        Dim cmd As New SqlClient.SqlCommand("DELETE phones WHERE family='" & TextBox2.Text & " AND name='" & TextBox1.Text & "'", sqlcon)
        sqlcon.Open()
        If cmd.ExecuteNonQuery <> 1 Then
            MessageBox.Show("Failed", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Commited", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        sqlcon.Close()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim c As Control
        tbl.Rows.Clear()
        For Each c In Me.Controls
            If TypeOf c Is Panel Then
                If c.Tag <> "All" Then
                    c.Visible = False
                Else
                    c.Visible = True
                End If
            End If
        Next
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        Dim cmd As New SqlClient.SqlCommand("SELECT family 'نام خانوادگی' ,Name 'نام' ,phone 'تلفن'" & _
        "FROM phones", sqlcon)

        sqlcon.Open()

        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Dim fc As Integer
        While (sdr.Read)
            'populating columns
            If Not b Then
                For fc = 0 To sdr.FieldCount - 1
                    tbl.Columns.Add(sdr.GetName(fc))
                Next
                b = True
            End If
            'populating rows
            Dim row As DataRow = tbl.NewRow
            For fc = 0 To sdr.FieldCount - 1
                row(fc) = sdr(fc)
            Next
            tbl.Rows.Add(row)
        End While
        dvw = New DataView(tbl)
        dbg.DataSource = dvw
        sqlcon.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
        Dim cmd As New SqlClient.SqlCommand("SELECT family,name,phone FROM phones WHERE family='" & _
        txtSF.Text & "' AND name='" & txtSN.Text & "'", sqlcon)
        sqlcon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

        If sdr.Read() Then
            TextBox3.Text = sdr("family")
            TextBox4.Text = sdr(1)
            TextBox5.Text = sdr(2)
        End If

        sqlcon.Close()
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim c As Control
        Dim b As Boolean
        For Each c In Me.Controls
            If TypeOf c Is Panel Then
                If c.Tag <> "s" Then
                    c.Visible = False
                Else
                    c.Visible = True
                End If
            End If
        Next
    End Sub

    Private Sub btnE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnE.Click
        If btnE.Text = "Edit" Then
            btnE.Text = "Update"
            TextBox3.Enabled = True
            TextBox4.Enabled = True
            TextBox5.Enabled = True
        Else
            btnE.Text = "Edit"
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            TextBox5.Enabled = False

            Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=phonebook")
            Dim cmd As New SqlClient.SqlCommand("UPDATE phones SET family='" & _
            TextBox3.Text & "' ,name='" & _
            TextBox4.Text & "',phone='" & TextBox5.Text & "' WHERE family='" & txtSF.Text & _
            "' AND name='" & txtSN.Text & "'", sqlcon)
            sqlcon.Open()
            MsgBox(cmd.CommandText)
            If cmd.ExecuteNonQuery <> 1 Then
                MessageBox.Show("Failed", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Commited", "PhoneBook", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            sqlcon.Close()
        End If
    End Sub
End Class
