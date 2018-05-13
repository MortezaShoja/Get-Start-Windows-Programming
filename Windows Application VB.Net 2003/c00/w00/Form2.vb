'Public Class Form2
'    Inherits System.Windows.Forms.Form

'    Dim sqlcon As SqlClient.SqlConnection

'    Dim dvwPhones As DataView

'#Region " Windows Form Designer generated code "

'    Public Sub New()
'        MyBase.New()

'        'This call is required by the Windows Form Designer.
'        InitializeComponent()

'        'Add any initialization after the InitializeComponent() call

'    End Sub

'    'Form overrides dispose to clean up the component list.
'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    Friend WithEvents cboD As System.Windows.Forms.ComboBox
'    Friend WithEvents cboT As System.Windows.Forms.ComboBox
'    Friend WithEvents Label1 As System.Windows.Forms.Label
'    Friend WithEvents Label2 As System.Windows.Forms.Label
'    Friend WithEvents dbgPhones As System.Windows.Forms.DataGrid
'    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
'        Me.dbgPhones = New System.Windows.Forms.DataGrid
'        Me.cboD = New System.Windows.Forms.ComboBox
'        Me.cboT = New System.Windows.Forms.ComboBox
'        Me.Label1 = New System.Windows.Forms.Label
'        Me.Label2 = New System.Windows.Forms.Label
'        CType(Me.dbgPhones, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'dbgPhones
'        '
'        Me.dbgPhones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
'                    Or System.Windows.Forms.AnchorStyles.Left) _
'                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
'        Me.dbgPhones.DataMember = ""
'        Me.dbgPhones.HeaderForeColor = System.Drawing.SystemColors.ControlText
'        Me.dbgPhones.Location = New System.Drawing.Point(0, 56)
'        Me.dbgPhones.Name = "dbgPhones"
'        Me.dbgPhones.Size = New System.Drawing.Size(488, 336)
'        Me.dbgPhones.TabIndex = 0
'        '
'        'cboD
'        '
'        Me.cboD.Location = New System.Drawing.Point(112, 8)
'        Me.cboD.Name = "cboD"
'        Me.cboD.Size = New System.Drawing.Size(121, 21)
'        Me.cboD.TabIndex = 1
'        '
'        'cboT
'        '
'        Me.cboT.Location = New System.Drawing.Point(352, 8)
'        Me.cboT.Name = "cboT"
'        Me.cboT.Size = New System.Drawing.Size(121, 21)
'        Me.cboT.TabIndex = 2
'        '
'        'Label1
'        '
'        Me.Label1.Location = New System.Drawing.Point(240, 8)
'        Me.Label1.Name = "Label1"
'        Me.Label1.TabIndex = 3
'        Me.Label1.Text = "Tables : "
'        '
'        'Label2
'        '
'        Me.Label2.Location = New System.Drawing.Point(8, 8)
'        Me.Label2.Name = "Label2"
'        Me.Label2.TabIndex = 4
'        Me.Label2.Text = "Databases : "
'        '
'        'Form2
'        '
'        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
'        Me.ClientSize = New System.Drawing.Size(488, 397)
'        Me.Controls.Add(Me.Label2)
'        Me.Controls.Add(Me.Label1)
'        Me.Controls.Add(Me.cboT)
'        Me.Controls.Add(Me.cboD)
'        Me.Controls.Add(Me.dbgPhones)
'        Me.Name = "Form2"
'        Me.Text = "Form2"
'        CType(Me.dbgPhones, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)

'    End Sub

'#End Region

'    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        sqlcon = New SqlClient.SqlConnection("server=local;data source=""."";integrated security=sspi;database=master")
'        sqlcon.Open()
'        Dim cmd As New SqlClient.SqlCommand("SELECT name FROM sysdatabases", sqlcon)
'        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
'        While sdr.Read
'            cboD.Items.Add(sdr(0))
'        End While
'        sqlcon.Close()
'    End Sub

'    Private Sub cboD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboD.SelectedIndexChanged
'        Dim sqlconTbl As New SqlClient.SqlConnection("server=local;data source=""."";
'integrated security=sspi;database=" & cboD.SelectedItem.ToString)
'        sqlconTbl.Open()
'        Dim cmd As New SqlClient.SqlCommand("SELECT name FROM sysobjects WHERE type='u'", sqlconTbl)
'        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
'        cboT.Items.Clear()
'        While sdr.Read
'            cboT.Items.Add(sdr(0))
'        End While
'        sqlconTbl.Close()
'    End Sub

'    Private Sub cboT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboT.SelectedIndexChanged
'        Dim sqlcon As New SqlClient.SqlConnection("server=local;data source=""."";
'integrated security=sspi;database=" & cboD.SelectedItem.ToString)
'        sqlcon.Open()
'        Dim cmd As New SqlClient.SqlCommand("SELECT * FROM " & cboT.SelectedItem.ToString, sqlcon)
'        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
'        Dim tbl As New DataTable("Phones")
'        Dim fc As Integer
'        For fc = 0 To sdr.FieldCount - 1
'            tbl.Columns.Add(sdr.GetName(fc))
'        Next
'        While sdr.Read
'            Dim Row As DataRow = tbl.NewRow
'            For fc = 0 To sdr.FieldCount - 1
'                Row.Item(fc) = sdr(fc)
'            Next
'            tbl.Rows.Add(Row)
'        End While
'        dvwPhones = New DataView(tbl)
'        dbgPhones.DataSource = dvwPhones
'        sqlcon.Close()
'    End Sub
'End Class
