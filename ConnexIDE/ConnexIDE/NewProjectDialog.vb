Public Class NewProjectDialog

    Private Sub NewProjectDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SetWindowTheme(trvLngs.Handle, "Explorer", Nothing)
        Remove3dMDI()
    End Sub


    Private Sub trvLngs_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles trvLngs.AfterSelect
        'If Not Me.MdiChildren.Equals(Nothing) Then
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next
        'End If
        Select Case e.Node.Name
            Case "nodeInst"
              
                Dim fIn As New Installed
                fIn.MdiParent = Me
                fIn.Show()
                fIn.Dock = DockStyle.Fill
            Case "nodeOnline"
               
                Dim fOnline As New Online
                fOnline.MdiParent = Me
                fOnline.Show()
                fOnline.Dock = DockStyle.Fill
            Case Else
                For Each f As Form In Me.MdiChildren
                    f.Close()
                Next
        End Select
    End Sub
End Class
