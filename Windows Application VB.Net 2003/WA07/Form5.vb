Public Class Form5
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
    Friend WithEvents cboEmployee As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents sdaE As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents sdaS As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsAll1 As wa07.dsAll
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboEmployee = New System.Windows.Forms.ComboBox
        Me.DsAll1 = New wa07.dsAll
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.sdaE = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sdaS = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsAll1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEmployee
        '
        Me.cboEmployee.DataSource = Me.DsAll1.authors
        Me.cboEmployee.DisplayMember = "au_id"
        Me.cboEmployee.Location = New System.Drawing.Point(16, 16)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(264, 21)
        Me.cboEmployee.TabIndex = 0
        Me.cboEmployee.ValueMember = "au_id"
        '
        'DsAll1
        '
        Me.DsAll1.DataSetName = "dsAll"
        Me.DsAll1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 48)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(264, 216)
        Me.DataGrid1.TabIndex = 1
        '
        'sdaE
        '
        Me.sdaE.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaE.InsertCommand = Me.SqlInsertCommand1
        Me.sdaE.SelectCommand = Me.SqlSelectCommand1
        Me.sdaE.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "authors", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("au_id", "au_id")})})
        Me.sdaE.UpdateCommand = Me.SqlUpdateCommand1
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
        'sdaS
        '
        Me.sdaS.DeleteCommand = Me.SqlDeleteCommand2
        Me.sdaS.InsertCommand = Me.SqlInsertCommand2
        Me.sdaS.SelectCommand = Me.SqlSelectCommand2
        Me.sdaS.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "titleauthor", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("au_id", "au_id"), New System.Data.Common.DataColumnMapping("title_id", "title_id"), New System.Data.Common.DataColumnMapping("au_ord", "au_ord"), New System.Data.Common.DataColumnMapping("royaltyper", "royaltyper")})})
        Me.sdaS.UpdateCommand = Me.SqlUpdateCommand2
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
        'Form5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 273)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.cboEmployee)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DsAll1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaE.Fill(DsAll1)
        sdaS.Fill(DsAll1)
        r = New DataRelation("au_Title", DsAll1.Tables(0).Columns("au_id"), DsAll1.Tables(1).Columns("au_id"))
        DsAll1.Relations.Add(r)
    End Sub

    Private Sub cboEmployee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEmployee.SelectedIndexChanged
        Dim row() As DataRow = DsAll1.Tables(0).Select("au_id='" & cboEmployee.SelectedValue & "'")

        DataGrid1.DataSource = row(0).GetChildRows("au_title")
    End Sub
End Class
