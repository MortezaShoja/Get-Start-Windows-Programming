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
    Friend WithEvents sdaReport As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents cboO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sdaD As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dsd1 As FilteredReport.DSD
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Dso1 As FilteredReport.DSO
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaReport = New System.Data.SqlClient.SqlDataAdapter
        Me.cboO = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.sdaD = New System.Data.SqlClient.SqlDataAdapter
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Dsd1 = New FilteredReport.DSD
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Dso1 = New FilteredReport.DSO
        CType(Me.Dsd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dso1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sdaReport
        '
        Me.sdaReport.SelectCommand = Me.SqlSelectCommand1
        Me.sdaReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserName", "UserName")})})
        '
        'cboO
        '
        Me.cboO.DataSource = Me.Dso1.Login
        Me.cboO.DisplayMember = "UserName"
        Me.cboO.Location = New System.Drawing.Point(256, 16)
        Me.cboO.Name = "cboO"
        Me.cboO.Size = New System.Drawing.Size(121, 21)
        Me.cboO.TabIndex = 0
        Me.cboO.ValueMember = "OrderID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(200, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Id : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sdaD
        '
        Me.sdaD.SelectCommand = Me.SqlSelectCommand2
        Me.sdaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Login", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("UserName", "UserName"), New System.Data.Common.DataColumnMapping("Password", "Password")})})
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv.DisplayGroupTree = False
        Me.crv.Location = New System.Drawing.Point(0, 56)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Nothing
        Me.crv.Size = New System.Drawing.Size(520, 384)
        Me.crv.TabIndex = 2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT UserName, Password FROM Login WHERE (UserName = @User)"
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@User", System.Data.SqlDbType.NVarChar, 100, "UserName"))
        '
        'Dsd1
        '
        Me.Dsd1.DataSetName = "DSD"
        Me.Dsd1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT UserName FROM Login"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVER;packet size=4096;integrated security=SSPI;data source=SERVE" & _
        "R;persist security info=False;initial catalog=parmisshop"
        '
        'Dso1
        '
        Me.Dso1.DataSetName = "DSO"
        Me.Dso1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(520, 445)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Dsd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dso1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaReport.Fill(DsO1)
    End Sub

    Private Sub cboO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboO.SelectedIndexChanged
        DsD1.Clear()
        sdaD.SelectCommand.Parameters(0).Value = cboO.SelectedValue
        sdaD.Fill(Dsd1)
        DsD1.WriteXml("..\data.xml")
        crv.ReportSource = "..\report.rpt"
        crv.RefreshReport()
    End Sub


End Class
