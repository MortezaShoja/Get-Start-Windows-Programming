Public Class Form1
    Inherits System.Windows.Forms.Form

    Public DirName As String

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
    Friend WithEvents dir As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents drv As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents fil As Microsoft.VisualBasic.Compatibility.VB6.FileListBox
    Friend WithEvents cmuFile As System.Windows.Forms.ContextMenu
    Friend WithEvents dItem As System.Windows.Forms.MenuItem
    Friend WithEvents cpItem As System.Windows.Forms.MenuItem
    Friend WithEvents cItem As System.Windows.Forms.MenuItem
    Friend WithEvents cmuDir As System.Windows.Forms.ContextMenu
    Friend WithEvents nItem As System.Windows.Forms.MenuItem
    Friend WithEvents foItem As System.Windows.Forms.MenuItem
    Friend WithEvents fiItem As System.Windows.Forms.MenuItem
    Friend WithEvents DeItem As System.Windows.Forms.MenuItem
    Friend WithEvents paItem As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dir = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.drv = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.fil = New Microsoft.VisualBasic.Compatibility.VB6.FileListBox
        Me.cmuFile = New System.Windows.Forms.ContextMenu
        Me.dItem = New System.Windows.Forms.MenuItem
        Me.cpItem = New System.Windows.Forms.MenuItem
        Me.cItem = New System.Windows.Forms.MenuItem
        Me.cmuDir = New System.Windows.Forms.ContextMenu
        Me.nItem = New System.Windows.Forms.MenuItem
        Me.foItem = New System.Windows.Forms.MenuItem
        Me.fiItem = New System.Windows.Forms.MenuItem
        Me.DeItem = New System.Windows.Forms.MenuItem
        Me.paItem = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'dir
        '
        Me.dir.ContextMenu = Me.cmuDir
        Me.dir.IntegralHeight = False
        Me.dir.Location = New System.Drawing.Point(8, 40)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(200, 360)
        Me.dir.TabIndex = 0
        '
        'drv
        '
        Me.drv.Location = New System.Drawing.Point(8, 8)
        Me.drv.Name = "drv"
        Me.drv.Size = New System.Drawing.Size(208, 21)
        Me.drv.TabIndex = 1
        '
        'fil
        '
        Me.fil.ContextMenu = Me.cmuFile
        Me.fil.Location = New System.Drawing.Point(216, 40)
        Me.fil.Name = "fil"
        Me.fil.Pattern = "*.*"
        Me.fil.Size = New System.Drawing.Size(208, 355)
        Me.fil.TabIndex = 2
        '
        'cmuFile
        '
        Me.cmuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.dItem, Me.cpItem, Me.cItem, Me.paItem})
        '
        'dItem
        '
        Me.dItem.Index = 0
        Me.dItem.Text = "Delete"
        '
        'cpItem
        '
        Me.cpItem.Index = 1
        Me.cpItem.Text = "Copy"
        '
        'cItem
        '
        Me.cItem.Index = 2
        Me.cItem.Text = "Cut"
        '
        'cmuDir
        '
        Me.cmuDir.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.nItem, Me.DeItem})
        '
        'nItem
        '
        Me.nItem.Index = 0
        Me.nItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.foItem, Me.fiItem})
        Me.nItem.Text = "New"
        '
        'foItem
        '
        Me.foItem.Index = 0
        Me.foItem.Text = "Folder"
        '
        'fiItem
        '
        Me.fiItem.Index = 1
        Me.fiItem.Text = "File"
        '
        'DeItem
        '
        Me.DeItem.Index = 1
        Me.DeItem.Text = "Delete"
        '
        'paItem
        '
        Me.paItem.Enabled = False
        Me.paItem.Index = 3
        Me.paItem.Text = "Paste"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 406)
        Me.Controls.Add(Me.fil)
        Me.Controls.Add(Me.drv)
        Me.Controls.Add(Me.dir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub drv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drv.SelectedIndexChanged
        dir.Path = drv.Drive
    End Sub

    Private Sub dir_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dir.SelectedIndexChanged
        fil.Path = dir.Path
    End Sub

    Private Sub fil_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fil.DoubleClick
        System.Diagnostics.Process.Start(fil.Path & "\" & fil.FileName)
    End Sub

    Private Sub dItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dItem.Click
        IO.File.Delete(fil.Path & "\" & fil.FileName)
    End Sub

    Private Sub foItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foItem.Click
        Dim frm As New Form2(Me)
        frm.ShowDialog()
        IO.Directory.CreateDirectory(dir.Path & "\" & DirName)
        dir.Refresh()
    End Sub

    Private Sub DeItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeItem.Click
        IO.Directory.Delete(dir.Path & dir.SelectedItem, True)
        dir.Refresh()
    End Sub

    Private Sub fiItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fiItem.Click
        Dim frm As New Form2(Me)
        frm.ShowDialog()
        IO.File.Create(dir.Path & "\" & DirName)
        fil.Refresh()
    End Sub

    Private Sub cpItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cpItem.Click
        DirName = fil.Path & "\" & fil.FileName
        paItem.Enabled = True
    End Sub

    Private Sub paItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles paItem.Click
        Dim tmp() As String = DirName.Split("\")
        IO.File.Copy(DirName, dir.Path & tmp(tmp.Length - 1))
        fil.Refresh()
        paItem.Enabled = False
    End Sub
End Class
