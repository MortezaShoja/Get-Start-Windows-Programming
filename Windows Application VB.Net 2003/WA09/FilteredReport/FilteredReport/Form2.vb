Public Class Form2
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
    Friend WithEvents DSReport As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Dsr1 As FilteredReport.dsr
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.DSReport = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Dsr1 = New FilteredReport.dsr
        CType(Me.Dsr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Location = New System.Drawing.Point(0, 8)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = "E:\Programing\VB.Net\Class Projects\VB.Net Projects\FilteredReport\FilteredReport" & _
        "\report.rpt"
        Me.crv.Size = New System.Drawing.Size(536, 424)
        Me.crv.TabIndex = 0
        '
        'DSReport
        '
        Me.DSReport.InsertCommand = Me.SqlInsertCommand1
        Me.DSReport.SelectCommand = Me.SqlSelectCommand1
        Me.DSReport.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Faktor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ShomareFaktor", "ShomareFaktor"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Lname", "Lname"), New System.Data.Common.DataColumnMapping("PesonaliNo", "PesonaliNo"), New System.Data.Common.DataColumnMapping("ShomareParvande", "ShomareParvande"), New System.Data.Common.DataColumnMapping("Sharhekhadamat", "Sharhekhadamat"), New System.Data.Common.DataColumnMapping("Tarikh", "Tarikh"), New System.Data.Common.DataColumnMapping("Hazinekhadamat", "Hazinekhadamat"), New System.Data.Common.DataColumnMapping("Hazinelabratuar", "Hazinelabratuar"), New System.Data.Common.DataColumnMapping("NameDandanpezeshk", "NameDandanpezeshk"), New System.Data.Common.DataColumnMapping("noekhadamat", "noekhadamat"), New System.Data.Common.DataColumnMapping("teded", "teded"), New System.Data.Common.DataColumnMapping("moaref", "moaref"), New System.Data.Common.DataColumnMapping("sharhh", "sharhh"), New System.Data.Common.DataColumnMapping("sahmedentist", "sahmedentist"), New System.Data.Common.DataColumnMapping("noetarefe", "noetarefe"), New System.Data.Common.DataColumnMapping("Deleted", "Deleted")})})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SERVER;packet size=4096;integrated security=SSPI;data source=SERVE" & _
        "R;persist security info=False;initial catalog=VIP"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ShomareFaktor, Name, Lname, PesonaliNo, ShomareParvande, Sharhekhadamat, T" & _
        "arikh, Hazinekhadamat, Hazinelabratuar, NameDandanpezeshk, noekhadamat, teded, m" & _
        "oaref, sharhh, sahmedentist, noetarefe, Deleted FROM Faktor"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Faktor(ShomareFaktor, Name, Lname, PesonaliNo, ShomareParvande, Sharh" & _
        "ekhadamat, Tarikh, Hazinekhadamat, Hazinelabratuar, NameDandanpezeshk, noekhadam" & _
        "at, teded, moaref, sharhh, sahmedentist, noetarefe, Deleted) VALUES (@ShomareFak" & _
        "tor, @Name, @Lname, @PesonaliNo, @ShomareParvande, @Sharhekhadamat, @Tarikh, @Ha" & _
        "zinekhadamat, @Hazinelabratuar, @NameDandanpezeshk, @noekhadamat, @teded, @moare" & _
        "f, @sharhh, @sahmedentist, @noetarefe, @Deleted); SELECT ShomareFaktor, Name, Ln" & _
        "ame, PesonaliNo, ShomareParvande, Sharhekhadamat, Tarikh, Hazinekhadamat, Hazine" & _
        "labratuar, NameDandanpezeshk, noekhadamat, teded, moaref, sharhh, sahmedentist, " & _
        "noetarefe, Deleted FROM Faktor"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShomareFaktor", System.Data.SqlDbType.Int, 4, "ShomareFaktor"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Lname", System.Data.SqlDbType.VarChar, 50, "Lname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PesonaliNo", System.Data.SqlDbType.VarChar, 50, "PesonaliNo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ShomareParvande", System.Data.SqlDbType.VarChar, 50, "ShomareParvande"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Sharhekhadamat", System.Data.SqlDbType.VarChar, 60, "Sharhekhadamat"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tarikh", System.Data.SqlDbType.VarChar, 50, "Tarikh"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hazinekhadamat", System.Data.SqlDbType.Int, 4, "Hazinekhadamat"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Hazinelabratuar", System.Data.SqlDbType.Int, 4, "Hazinelabratuar"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NameDandanpezeshk", System.Data.SqlDbType.VarChar, 50, "NameDandanpezeshk"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@noekhadamat", System.Data.SqlDbType.VarChar, 50, "noekhadamat"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@teded", System.Data.SqlDbType.Int, 4, "teded"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@moaref", System.Data.SqlDbType.VarChar, 50, "moaref"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sharhh", System.Data.SqlDbType.VarChar, 70, "sharhh"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sahmedentist", System.Data.SqlDbType.Int, 4, "sahmedentist"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@noetarefe", System.Data.SqlDbType.VarChar, 50, "noetarefe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Deleted", System.Data.SqlDbType.Bit, 1, "Deleted"))
        '
        'Dsr1
        '
        Me.Dsr1.DataSetName = "dsr"
        Me.Dsr1.Locale = New System.Globalization.CultureInfo("fa-IR")
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 445)
        Me.Controls.Add(Me.crv)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.Dsr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DSReport.Fill(Dsr1)
        crv.ReportSource = "..\report.rpt"
        crv.RefreshReport()
    End Sub
End Class
