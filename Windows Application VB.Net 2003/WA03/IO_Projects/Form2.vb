Public Class Form2
    Inherits System.Windows.Forms.Form

    Dim tbl As DataTable
    Dim dvw As DataView

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
        Me.dbg.Size = New System.Drawing.Size(292, 266)
        Me.dbg.TabIndex = 1
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.dbg)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IO.File.Exists("SPhone.dat") Then
            Dim sw As New IO.StreamWriter("SPhone.dat")
            sw.WriteLine(FileSecurity.Encode.DoVerb("Family,Name,Phone", 2))
            sw.Close()
        End If
        tbl = New DataTable("SPhone")
        dvw = New DataView(tbl)
        Dim sr As New IO.StreamReader("SPhone.dat")
        Dim Columns As String() = FileSecurity.Decode.DoVerb(sr.ReadLine, 2).Split(",")
        Dim cc As Integer
        For cc = 0 To Columns.Length - 1
            tbl.Columns.Add(Columns(cc))
        Next
        Do While (sr.Peek <> -1)
            Dim Row As DataRow = tbl.NewRow
            Dim RowStr As String() = FileSecurity.Decode.DoVerb(sr.ReadLine, 2).Split(",")
            For cc = 0 To RowStr.Length - 1
                Row.Item(cc) = RowStr(cc)
            Next
            tbl.Rows.Add(Row)
        Loop
        sr.Close()
        dbg.DataSource = dvw
    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        dbg.NavigateBack()
        Dim sw As New IO.StreamWriter("SPhone.dat")
        sw.WriteLine(FileSecurity.Encode.DoVerb("Family,Name,Phone", 2))
        Dim rc, cc As Integer
        For rc = 0 To dbg.VisibleRowCount - 2
            Dim Row(dbg.VisibleColumnCount - 1) As String
            For cc = 0 To dbg.VisibleColumnCount - 1
                Row(cc) = dbg(rc, cc)
            Next
            sw.WriteLine(FileSecurity.Encode.DoVerb(String.Join(",", Row), 2))
        Next
        sw.Close()
    End Sub
End Class
