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
    Friend WithEvents sdaPhones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPhones1 As dc.dsPhones
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.DsPhones1 = New dc.dsPhones
        Me.sdaPhones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPhones1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg
        '
        Me.dbg.DataMember = "phones"
        Me.dbg.DataSource = Me.DsPhones1
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(328, 309)
        Me.dbg.TabIndex = 0
        '
        'DsPhones1
        '
        Me.DsPhones1.DataSetName = "dsPhones"
        Me.DsPhones1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'sdaPhones
        '
        Me.sdaPhones.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaPhones.InsertCommand = Me.SqlInsertCommand1
        Me.sdaPhones.SelectCommand = Me.SqlSelectCommand1
        Me.sdaPhones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "phones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Family", "Family"), New System.Data.Common.DataColumnMapping("Name", "Name"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        Me.sdaPhones.UpdateCommand = Me.SqlUpdateCommand1
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
        "amily, Name, Phone FROM phones WHERE (Family = @Family) AND (Name = @Name) ORDER" & _
        " BY Name"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Family", System.Data.SqlDbType.VarChar, 50, "Family"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 10, "Phone"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Family, Name, Phone FROM phones ORDER BY Name"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE phones SET Family = @Family, Name = @Name, Phone = @Phone WHERE (Family = " & _
        "@Original_Family) AND (Name = @Original_Name) AND (Phone = @Original_Phone OR @O" & _
        "riginal_Phone IS NULL AND Phone IS NULL); SELECT Family, Name, Phone FROM phones" & _
        " WHERE (Family = @Family) AND (Name = @Name) ORDER BY Name"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Family", System.Data.SqlDbType.VarChar, 50, "Family"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Name", System.Data.SqlDbType.VarChar, 50, "Name"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.VarChar, 10, "Phone"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Family", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Family", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Name", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Name", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(328, 309)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPhones1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaPhones.Fill(DsPhones1)
    End Sub

    Private Sub dbg_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dbg.Navigate

    End Sub
End Class
