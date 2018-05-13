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
    Friend WithEvents dbg As System.Windows.Forms.DataGrid
    Friend WithEvents sdaNew As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsNew11 As dc.dsNew1
    Friend WithEvents DataView1 As System.Data.DataView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbg = New System.Windows.Forms.DataGrid
        Me.sdaNew = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.DsNew11 = New dc.dsNew1
        Me.DataView1 = New System.Data.DataView
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsNew11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg
        '
        Me.dbg.AlternatingBackColor = System.Drawing.Color.Gainsboro
        Me.dbg.BackColor = System.Drawing.Color.Silver
        Me.dbg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dbg.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dbg.CaptionFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.dbg.CaptionForeColor = System.Drawing.Color.White
        Me.dbg.DataMember = ""
        Me.dbg.DataSource = Me.DataView1
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.FlatMode = True
        Me.dbg.ForeColor = System.Drawing.Color.Black
        Me.dbg.GridLineColor = System.Drawing.Color.White
        Me.dbg.HeaderBackColor = System.Drawing.Color.DarkGray
        Me.dbg.HeaderForeColor = System.Drawing.Color.Black
        Me.dbg.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.ParentRowsBackColor = System.Drawing.Color.Black
        Me.dbg.ParentRowsForeColor = System.Drawing.Color.White
        Me.dbg.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dbg.SelectionForeColor = System.Drawing.Color.White
        Me.dbg.Size = New System.Drawing.Size(424, 389)
        Me.dbg.TabIndex = 0
        '
        'sdaNew
        '
        Me.sdaNew.DeleteCommand = Me.SqlDeleteCommand1
        Me.sdaNew.InsertCommand = Me.SqlInsertCommand1
        Me.sdaNew.SelectCommand = Me.SqlSelectCommand1
        Me.sdaNew.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "employee", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("fname", "‰«„"), New System.Data.Common.DataColumnMapping("lname", "›«„Ì·Ì"), New System.Data.Common.DataColumnMapping("emp_id", "‘‰«”Â")})})
        Me.sdaNew.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT emp_id, fname, lname FROM employee ORDER BY lname"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO employee(emp_id, fname, lname) VALUES (@emp_id, @fname, @lname); SELE" & _
        "CT emp_id, fname, lname FROM employee WHERE (emp_id = @emp_id) ORDER BY lname"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection2
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@emp_id", System.Data.SqlDbType.VarChar, 9, "emp_id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.VarChar, 20, "fname"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.VarChar, 30, "lname"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE employee SET emp_id = @emp_id, fname = @fname, lname = @lname WHERE (emp_i" & _
        "d = @Original_emp_id) AND (fname = @Original_fname) AND (lname = @Original_lname" & _
        "); SELECT emp_id, fname, lname FROM employee WHERE (emp_id = @emp_id) ORDER BY l" & _
        "name"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@emp_id", System.Data.SqlDbType.VarChar, 9, "emp_id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fname", System.Data.SqlDbType.VarChar, 20, "fname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@lname", System.Data.SqlDbType.VarChar, 30, "lname"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_emp_id", System.Data.SqlDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "emp_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lname", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lname", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM employee WHERE (emp_id = @Original_emp_id) AND (fname = @Original_fna" & _
        "me) AND (lname = @Original_lname)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_emp_id", System.Data.SqlDbType.VarChar, 9, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "emp_id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fname", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fname", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_lname", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "lname", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=""EWQ-Y0WOMYLLM1E"";packet size=4096;integrated security=SSPI;data s" & _
        "ource=""."";persist security info=False;initial catalog=pubs"
        '
        'DsNew11
        '
        Me.DsNew11.DataSetName = "dsNew1"
        Me.DsNew11.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.ApplyDefaultSort = True
        Me.DataView1.RowStateFilter = CType((System.Data.DataViewRowState.Unchanged Or System.Data.DataViewRowState.Added), System.Data.DataViewRowState)
        Me.DataView1.Sort = "‘‰«”Â"
        Me.DataView1.Table = Me.DsNew11.employee
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 389)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsNew11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sdaNew.Fill(DsNew11)
    End Sub
End Class
