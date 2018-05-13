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
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsO1 As FilteredReport.dsO
    Friend WithEvents cboO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sdaD As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsD1 As FilteredReport.dsD
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.sdaReport = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsO1 = New FilteredReport.dsO
        Me.cboO = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.sdaD = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DsD1 = New FilteredReport.dsD
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        CType(Me.DsO1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sdaReport
        '
        Me.sdaReport.SelectCommand = Me.SqlSelectCommand1
        Me.sdaReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT OrderID FROM Orders"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=nwind"
        '
        'DsO1
        '
        Me.DsO1.DataSetName = "dsO"
        Me.DsO1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'cboO
        '
        Me.cboO.DataSource = Me.DsO1.Orders
        Me.cboO.DisplayMember = "OrderID"
        Me.cboO.Location = New System.Drawing.Point(144, 16)
        Me.cboO.Name = "cboO"
        Me.cboO.Size = New System.Drawing.Size(121, 21)
        Me.cboO.TabIndex = 0
        Me.cboO.ValueMember = "OrderID"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order Id : "
        '
        'sdaD
        '
        Me.sdaD.SelectCommand = Me.SqlSelectCommand2
        Me.sdaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHE" & _
        "RE (OrderID = @oid)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@oid", System.Data.SqlDbType.Int, 4, "OrderID"))
        '
        'DsD1
        '
        Me.DsD1.DataSetName = "dsD"
        Me.DsD1.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.crv.Size = New System.Drawing.Size(384, 288)
        Me.crv.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 349)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DsO1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaReport.Fill(DsO1)
    End Sub

    Private Sub cboO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboO.SelectedIndexChanged
        DsD1.Clear()
        sdaD.SelectCommand.Parameters(0).Value = cboO.SelectedValue
        sdaD.Fill(DsD1)
        DsD1.WriteXml("..\data.xml")
        crv.ReportSource = "..\report.rpt"
        crv.RefreshReport()
    End Sub
End Class
