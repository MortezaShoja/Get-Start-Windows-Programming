Public Class Form3
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbg = New System.Windows.Forms.DataGrid
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbg
        '
        Me.dbg.DataMember = ""
        Me.dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbg.Location = New System.Drawing.Point(0, 0)
        Me.dbg.Name = "dbg"
        Me.dbg.Size = New System.Drawing.Size(292, 273)
        Me.dbg.TabIndex = 0
        '
        'Form3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New DataSet("PhoneBook")
        Dim tbl As New DataTable("Phone")
        tbl.Columns.Add("Family")
        tbl.Columns.Add("Name")
        tbl.Columns.Add("Phone")
        ds.Tables.Add(tbl)
        dbg.DataSource = ds
        ' ds.Tables(0).Columns(0).Unique = True
        Dim c(1) As DataColumn
        c(0) = ds.Tables(0).Columns(0)
        c(1) = ds.Tables(0).Columns(1)
        Dim uc As New UniqueConstraint("pk_phone", c)
        'Dim uc As New UniqueConstraint("pk_phone", ds.Tables(0).Columns(0))
        ds.Tables(0).Constraints.Add(uc)

    End Sub
End Class
