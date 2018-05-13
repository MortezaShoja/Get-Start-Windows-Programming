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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOrders As System.Windows.Forms.ComboBox
    Friend WithEvents sdaM As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsM1 As newrpt.dsM
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents sdaD As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsD1 As newrpt.dsD
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboOrders = New System.Windows.Forms.ComboBox
        Me.sdaM = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DsM1 = New newrpt.dsM
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.sdaD = New System.Data.SqlClient.SqlDataAdapter
        Me.DsD1 = New newrpt.dsD
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsM1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "orderid : "
        '
        'cboOrders
        '
        Me.cboOrders.DataSource = Me.DsM1
        Me.cboOrders.DisplayMember = "Orders.OrderID"
        Me.cboOrders.Location = New System.Drawing.Point(136, 8)
        Me.cboOrders.Name = "cboOrders"
        Me.cboOrders.Size = New System.Drawing.Size(160, 21)
        Me.cboOrders.TabIndex = 1
        Me.cboOrders.ValueMember = "Orders.OrderID"
        '
        'sdaM
        '
        Me.sdaM.SelectCommand = Me.SqlSelectCommand1
        Me.sdaM.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID")})})
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
        'DsM1
        '
        Me.DsM1.DataSetName = "dsM"
        Me.DsM1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv.DisplayGroupTree = False
        Me.crv.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.crv.Location = New System.Drawing.Point(0, 48)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Nothing
        Me.crv.Size = New System.Drawing.Size(392, 312)
        Me.crv.TabIndex = 2
        '
        'sdaD
        '
        Me.sdaD.SelectCommand = Me.SqlSelectCommand2
        Me.sdaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount"), New System.Data.Common.DataColumnMapping("Total", "Total")})})
        '
        'DsD1
        '
        Me.DsD1.DataSetName = "dsD"
        Me.DsD1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount, UnitPrice * Quantity - " & _
        "UnitPrice * Quantity * Discount AS Total FROM [Order Details] WHERE (OrderID = @" & _
        "oid)"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        Me.SqlSelectCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@oid", System.Data.SqlDbType.Int, 4, "OrderID"))
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 365)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.cboOrders)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DsM1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsD1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaM.Fill(DsM1)

    End Sub

    Private Sub cboOrders_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOrders.SelectedIndexChanged
        DsD1.Clear()
        sdaD.SelectCommand.Parameters(0).Value = cboOrders.SelectedValue
        sdaD.Fill(DsD1)
        DsD1.WriteXml("..\datan.xml")
        crv.ReportSource = "..\rpt.rpt"
        crv.RefreshReport()
    End Sub
End Class
