Public Class Form5
    Inherits System.Windows.Forms.Form

    Dim tbl As DataTable
    Dim dvwPhone As DataView
    Public rf As String

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
    Friend WithEvents dbgPhone As System.Windows.Forms.DataGrid
    Friend WithEvents cmu As System.Windows.Forms.ContextMenu
    Friend WithEvents fItem As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dbgPhone = New System.Windows.Forms.DataGrid
        Me.cmu = New System.Windows.Forms.ContextMenu
        Me.fItem = New System.Windows.Forms.MenuItem
        CType(Me.dbgPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgPhone
        '
        Me.dbgPhone.ContextMenu = Me.cmu
        Me.dbgPhone.DataMember = ""
        Me.dbgPhone.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dbgPhone.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dbgPhone.Location = New System.Drawing.Point(0, 0)
        Me.dbgPhone.Name = "dbgPhone"
        Me.dbgPhone.Size = New System.Drawing.Size(292, 273)
        Me.dbgPhone.TabIndex = 1
        '
        'cmu
        '
        Me.cmu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fItem})
        '
        'fItem
        '
        Me.fItem.Index = 0
        Me.fItem.Text = "Filter"
        '
        'Form5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.dbgPhone)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.dbgPhone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sr As New IO.StreamReader("phone.dat")
        tbl = New DataTable("Phone")

        'tbl.Columns.Add("Family")
        'tbl.Columns.Add("Name")
        'tbl.Columns.Add("Phone")

        Dim columns() As String = sr.ReadLine.Split(",")
        Dim cc As Integer
        For cc = 0 To columns.Length - 1
            tbl.Columns.Add(columns(cc))
        Next



        While sr.Peek <> -1
            Dim row As DataRow = tbl.NewRow
            Dim tmp() As String = sr.ReadLine.Split(",")
            Dim c As Integer
            For c = 0 To tmp.Length - 1
                row.Item(c) = tmp(c)
            Next
            tbl.Rows.Add(row)
        End While


        dvwPhone = New DataView(tbl)

        ' dvwPhone.RowFilter = "Family='Ramezani'"
        dbgPhone.DataSource = dvwPhone
    End Sub

    Private Sub Form5_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        dbgPhone.NavigateBack()
        Dim result As DialogResult = MessageBox.Show("Save changes ?", "PhoneBook", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        Select Case result
            Case DialogResult.Cancel
                e.Cancel = True
            Case DialogResult.Yes
                Dim sw As New IO.StreamWriter("Phone.dat")
                Dim str As String
                Dim c As Integer
                Dim tmpC(tbl.Columns.Count - 1) As String
                For c = 0 To tbl.Columns.Count - 1
                    tmpC(c) = tbl.Columns(c).ColumnName
                Next
                str = String.Join(",", tmpC)
                sw.WriteLine(str)
                sw.Flush()
                str = ""

                Dim rc As Integer
                For rc = 0 To dbgPhone.VisibleRowCount - 2
                    Dim cc As Integer
                    Dim tmpR(dbgPhone.VisibleColumnCount - 1) As String
                    For cc = 0 To dbgPhone.VisibleColumnCount - 1
                        tmpR(cc) = dbgPhone(rc, cc)
                    Next
                    sw.WriteLine(String.Join(",", tmpR))
                    sw.Flush()
                Next
                sw.Close()
        End Select
    End Sub

    Private Sub fItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fItem.Click
        Dim frm As New Form6(Me)
        frm.ShowDialog()
        dvwPhone.RowFilter = rf
    End Sub
End Class
