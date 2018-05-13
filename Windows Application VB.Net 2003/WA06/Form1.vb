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
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents sdaUpd As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPhones1 As wa06.dsPhones
    Friend WithEvents sdaE As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPubs1 As wa06.dsPubs
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.DsPhones1 = New wa06.dsPhones
        Me.sdaUpd = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sdaE = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.DsPubs1 = New wa06.dsPubs
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPhones1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPubs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg
        '
        Me.dbg.DataMember = "authors"
        Me.dbg.DataSource = Me.DsPubs1
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(352, 310)
        Me.dbg.TabIndex = 0
        '
        'DsPhones1
        '
        Me.DsPhones1.DataSetName = "dsPhones"
        Me.DsPhones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'sdaUpd
        '
        Me.sdaUpd.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaUpd.InsertCommand = Me.SqlInsertCommand1
        Me.sdaUpd.SelectCommand = Me.SqlSelectCommand1
        Me.sdaUpd.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        Me.sdaUpd.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM phones WHERE (Family = @Original_Family) AND (Name = @Original_Name) " & _
        "AND (Phone = @Original_Phone OR @Original_Phone IS NULL AND Phone IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Family", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Family", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=PhoneBook"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO phones(Family, Name, Phone) VALUES (@Family, @Name, @Phone); SELECT F" & _
        "amily, Name, Phone FROM phones WHERE (Family = @Family) AND (Name = @Name)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Family", System.Data.SqlDbType.VarChar, 50, "Family"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 10, "Phone"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Family, Name, Phone FROM phones"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE phones SET Family = @Family, Name = @Name, Phone = @Phone WHERE (Family = " & _
        "@Original_Family) AND (Name = @Original_Name) AND (Phone = @Original_Phone OR @O" & _
        "riginal_Phone IS NULL AND Phone IS NULL); SELECT Family, Name, Phone FROM phones" & _
        " WHERE (Family = @Family) AND (Name = @Name)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Family", System.Data.SqlDbType.VarChar, 50, "Family"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 10, "Phone"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Family", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Family", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'sdaE
        '
        Me.sdaE.DeleteCommand = Me.SqlDeleteCommand2
        Me.sdaE.InsertCommand = Me.SqlInsertCommand2
        Me.sdaE.SelectCommand = Me.SqlSelectCommand2
        Me.sdaE.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "authors", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("au_id", "au_id"), New System.Data.Common.DataColumnMapping("au_lname", "au_lname"), New System.Data.Common.DataColumnMapping("au_fname", "au_fname"), New System.Data.Common.DataColumnMapping("phone", "phone")})})
        Me.sdaE.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT au_id, au_lname, au_fname, phone FROM authors"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO authors(au_id, au_lname, au_fname, phone) VALUES (@au_id, @au_lname, " & _
        "@au_fname, @phone); SELECT au_id, au_lname, au_fname, phone FROM authors WHERE (" & _
        "au_id = @au_id)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_lname", System.Data.SqlDbType.VarChar, 40, "au_lname"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_fname", System.Data.SqlDbType.VarChar, 20, "au_fname"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 12, "phone"))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE authors SET au_id = @au_id, au_lname = @au_lname, au_fname = @au_fname, ph" & _
        "one = @phone WHERE (au_id = @Original_au_id) AND (au_fname = @Original_au_fname)" & _
        " AND (au_lname = @Original_au_lname) AND (phone = @Original_phone); SELECT au_id" & _
        ", au_lname, au_fname, phone FROM authors WHERE (au_id = @au_id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_id", System.Data.SqlDbType.VarChar, 11, "au_id"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_lname", System.Data.SqlDbType.VarChar, 40, "au_lname"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@au_fname", System.Data.SqlDbType.VarChar, 20, "au_fname"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@phone", System.Data.SqlDbType.VarChar, 12, "phone"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_lname", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM authors WHERE (au_id = @Original_au_id) AND (au_fname = @Original_au_" & _
        "fname) AND (au_lname = @Original_au_lname) AND (phone = @Original_phone)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_id", System.Data.SqlDbType.VarChar, 11, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_au_lname", System.Data.SqlDbType.VarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "au_lname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_phone", System.Data.SqlDbType.VarChar, 12, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;user id=sa;integrated security=" & _
        "SSPI;data source=""."";persist security info=False;initial catalog=pubs"
        '
        'DsPubs1
        '
        Me.DsPubs1.DataSetName = "dsPubs"
        Me.DsPubs1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 310)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPhones1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPubs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaUpd.Fill(DsPhones1)
        sdaE.Fill(DsPubs1)
    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'sdaUpd.Update(DsPhones1)

        'Dim r(0) As DataRow
        'r(0) = DsPhones1.Tables(0).Rows(0)
        'sdaUpd.Update(r)

        'Dim r(1) As DataRow
        'r(0) = DsPhones1.Tables(0).Rows(0)
        'r(1) = DsPhones1.Tables(0).Rows(1)
        'sdaUpd.Update(r)
        Dim i As Integer

        'Dim count As Integer
        'For i = 0 To DsPubs1.Tables(0).Rows.Count - 1 Step 2
        '    count += 1
        'Next

        'Dim r(count - 1) As DataRow

        'For i = 0 To DsPubs1.Tables(0).Rows.Count - 1 Step 2
        '    r(i) = DsPubs1.Tables(0).Rows(i)
        'Next


        'Dim count As Integer
        'For i = 0 To DsPubs1.Tables(0).Rows.Count - 1 Step 2
        '    count += 1
        'Next

        'Dim r((DsPubs1.Tables(0).Rows.Count \ 2) - 1) As DataRow
        'Dim ri As Integer
        Dim R() As DataRow
        Dim empty As Boolean
        For i = 0 To DsPubs1.Tables(0).Rows.Count - 1 Step 2
            If Not empty Then
                ReDim R(0)
                empty = True
            Else
                ReDim Preserve R(R.Length)
            End If
            R(R.Length - 1) = DsPubs1.Tables(0).Rows(i)
        Next

        sdaE.Update(r)
    End Sub
End Class
