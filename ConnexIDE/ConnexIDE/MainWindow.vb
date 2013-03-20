Imports System.IO

Public Class MainWindow

    Private Sub ProjectToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Dim dlg As New NewProjectDialog
        dlg.ShowDialog(Me)
    End Sub
    Dim WithEvents g As FastColoredTextBoxNS.FastColoredTextBox
    Public Sub LoadFSCode(file As String)
        Dim t As New TabPage
        g = New FastColoredTextBoxNS.FastColoredTextBox
        AddHandler g.TextChanged, AddressOf SetFlowScript
        'g.Load(file)
        t.Controls.Add(g)
        g.Dock = DockStyle.Fill
        g.Font = New CodeWin(LangType.FlowScript).rtb.Font

        t.Text = Path.GetFileName(file)
        MainTabControl.TabPages.Add(t)
    End Sub

    Public Sub LoadFSCode(code As Object)
        Dim t As New TabPage
        g = New FastColoredTextBoxNS.FastColoredTextBox
        AddHandler g.TextChanged, AddressOf SetFlowScript
        'g.Load(file)
        t.Controls.Add(g)
        g.Dock = DockStyle.Fill
        g.Font = New CodeWin(LangType.FlowScript).rtb.Font
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        g.Text = resources.GetString("Code1")
        t.Text = "code"
        MainTabControl.TabPages.Add(t)
    End Sub

    Private Sub MainTabControl_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles MainTabControl.SelectedIndexChanged
        ' MsgBox("changed")
        If MainTabControl.TabCount = 1 Then
            MainTabControl.ShowCloseButtonOnTabs = False
        Else
            MainTabControl.ShowCloseButtonOnTabs = True
        End If
    End Sub

    Private Sub MainWindow_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadFSCode("C:\Users\Tom2\test.fsc")
    End Sub

    Private Sub ProjectToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ProjectToolStripMenuItem.Click
        Dim prj As New NewProjectDialog
        prj.ShowDialog(Me)
    End Sub

    Private Sub lkblNewPrj_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub GroupBox1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles GroupBox1.Paint
        ControlPaint.DrawBorder(e.Graphics, GroupBox1.ClientRectangle, Drawing.Color.FromArgb(57, 74, 107), ButtonBorderStyle.Solid)
    End Sub
End Class
