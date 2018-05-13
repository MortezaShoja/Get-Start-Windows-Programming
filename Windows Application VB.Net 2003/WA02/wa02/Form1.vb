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
    Friend WithEvents txta As System.Windows.Forms.TextBox
    Friend WithEvents cmu As System.Windows.Forms.ContextMenu
    Friend WithEvents wItem As System.Windows.Forms.MenuItem
    Friend WithEvents sfd As System.Windows.Forms.SaveFileDialog
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents rItem As System.Windows.Forms.MenuItem
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txta = New System.Windows.Forms.TextBox
        Me.cmu = New System.Windows.Forms.ContextMenu
        Me.wItem = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.rItem = New System.Windows.Forms.MenuItem
        Me.sfd = New System.Windows.Forms.SaveFileDialog
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.SuspendLayout()
        '
        'txta
        '
        Me.txta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txta.ContextMenu = Me.cmu
        Me.txta.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txta.Location = New System.Drawing.Point(0, 0)
        Me.txta.Multiline = True
        Me.txta.Name = "txta"
        Me.txta.Size = New System.Drawing.Size(292, 224)
        Me.txta.TabIndex = 1
        Me.txta.Text = "TextBox1"
        '
        'cmu
        '
        Me.cmu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.wItem, Me.MenuItem1, Me.rItem})
        '
        'wItem
        '
        Me.wItem.Index = 0
        Me.wItem.Text = "Write"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 1
        Me.MenuItem1.Text = "-"
        '
        'rItem
        '
        Me.rItem.Index = 2
        Me.rItem.Text = "Read"
        '
        'sfd
        '
        Me.sfd.DefaultExt = "txt"
        Me.sfd.FileName = "test.txt"
        Me.sfd.Filter = "TextFiles|(*.txt)"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.txta)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub btnW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim sw As New IO.StreamWriter(txta.Text)
    '    sw.AutoFlush = True
    '    sw.Write("Hi")
    '    sw.Flush()
    '    sw.Close()
    'End Sub

    Private Sub wItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wItem.Click
        sfd.ShowDialog()
        Dim sw As New IO.StreamWriter(sfd.FileName)
        sw.Write(txta.Text)
        sw.Close()
    End Sub

    Private Sub rItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rItem.Click
        ofd.ShowDialog()
        Dim sr As New IO.StreamReader(ofd.FileName)
        txta.Text = sr.ReadToEnd()
        sr.Close()
    End Sub
End Class
