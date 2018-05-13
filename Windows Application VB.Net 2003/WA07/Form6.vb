Public Class Form6
    Inherits System.Windows.Forms.Form

    Dim r As DataRelation

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents cboA As System.Windows.Forms.ComboBox
    Friend WithEvents sdaA As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsAll1 As wa07.dsAll
    Friend WithEvents sdaD As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cboA = New System.Windows.Forms.ComboBox
        Me.DsAll1 = New wa07.dsAll
        Me.sdaA = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sdaD = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAll1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 57)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(292, 216)
        Me.DataGrid1.TabIndex = 0
        '
        'cboA
        '
        Me.cboA.DataSource = Me.DsAll1.authors
        Me.cboA.DisplayMember = "au_id"
        Me.cboA.Location = New System.Drawing.Point(8, 16)
        Me.cboA.Name = "cboA"
        Me.cboA.Size = New System.Drawing.Size(121, 21)
        Me.cboA.TabIndex = 1
        Me.cboA.ValueMember = "au_id"
        '
        'DsAll1
        '
        Me.DsAll1.DataSetName = "dsAll"
        Me.DsAll1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'sdaA
        '
        Me.sdaA.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaA.InsertCommand = Me.SqlInsertCommand1
        Me.sdaA.SelectCommand = Me.SqlSelectCommand1
        Me.sdaA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "authors", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("au_id", "au_id")})})
        Me.sdaA.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM authors WHERE (au_id = @Original_au_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=pubs"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO authors(au_id) VALUES (@au_id); SELECT au_id FROM authors WHERE (au_i" & _
        "d = @au_id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT au_id FROM authors"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE authors SET au_id = @au_id WHERE (au_id = @Original_au_id); SELECT au_id F" & _
        "ROM authors WHERE (au_id = @au_id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        '
        'sdaD
        '
        Me.sdaD.DeleteCommand = Me.SqlDeleteCommand2
        Me.sdaD.InsertCommand = Me.SqlInsertCommand2
        Me.sdaD.SelectCommand = Me.SqlSelectCommand2
        Me.sdaD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "titleauthor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("au_id", "au_id"), New System.Data.Common.DataColumnMapping("title_id", "title_id"), New System.Data.Common.DataColumnMapping("au_ord", "au_ord"), New System.Data.Common.DataColumnMapping("royaltyper", "royaltyper")})})
        Me.sdaD.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM titleauthor WHERE (au_id = @Original_au_id) AND (title_id = @Original" & _
        "_title_id) AND (au_ord = @Original_au_ord OR @Original_au_ord IS NULL AND au_ord" & _
        " IS NULL) AND (royaltyper = @Original_royaltyper OR @Original_royaltyper IS NULL" & _
        " AND royaltyper IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_ord", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_ord", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_royaltyper", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "royaltyper", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO titleauthor(au_id, title_id, au_ord, royaltyper) VALUES (@au_id, @tit" & _
        "le_id, @au_ord, @royaltyper); SELECT au_id, title_id, au_ord, royaltyper FROM ti" & _
        "tleauthor WHERE (au_id = @au_id) AND (title_id = @title_id)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 6, "title_id"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_ord", System.Data.SqlDbType.TinyInt, 1, "au_ord"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@royaltyper", System.Data.SqlDbType.Int, 4, "royaltyper"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT au_id, title_id, au_ord, royaltyper FROM titleauthor"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE titleauthor SET au_id = @au_id, title_id = @title_id, au_ord = @au_ord, ro" & _
        "yaltyper = @royaltyper WHERE (au_id = @Original_au_id) AND (title_id = @Original" & _
        "_title_id) AND (au_ord = @Original_au_ord OR @Original_au_ord IS NULL AND au_ord" & _
        " IS NULL) AND (royaltyper = @Original_royaltyper OR @Original_royaltyper IS NULL" & _
        " AND royaltyper IS NULL); SELECT au_id, title_id, au_ord, royaltyper FROM titlea" & _
        "uthor WHERE (au_id = @au_id) AND (title_id = @title_id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@title_id", System.Data.SqlDbType.VarChar, 6, "title_id"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_ord", System.Data.SqlDbType.TinyInt, 1, "au_ord"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@royaltyper", System.Data.SqlDbType.Int, 4, "royaltyper"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_title_id", System.Data.SqlDbType.VarChar, 6, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "title_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_ord", System.Data.SqlDbType.TinyInt, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_ord", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_royaltyper", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "royaltyper", System.Data.DataRowVersion.Original, Nothing))
        '
        'Form6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.cboA)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAll1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaA.Fill(DsAll1)
        sdaD.Fill(DsAll1)
        r = New DataRelation("au_Title", DsAll1.Tables(0).Columns("au_id"), DsAll1.Tables(1).Columns("au_id"))

        DsAll1.Relations.Add(r)
    End Sub

    Private Sub cboA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles cboA.SelectedIndexChanged
        Dim rows() As DataRow = DsAll1.Tables(0).Select("au_id='" & cboA.SelectedValue & "'")
        DataGrid1.DataSource = rows(0).GetChildRows("au_title")
    End Sub
End Class
