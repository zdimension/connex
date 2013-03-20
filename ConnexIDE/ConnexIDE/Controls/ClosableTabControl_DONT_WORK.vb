Public Class TabControlEx_DONT_WORK
    Inherits TabControl

    Dim _imgHitArea As Point = New Point(13, 2)
    Dim _imageLocation As Point = New Point(15, 5)

    Public Sub New()
        Me.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed

        AddHandler Me.DrawItem, AddressOf Me_DrawItem
    End Sub




    Private Sub Me_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            'Close Image to draw
            'Dim img As Image = New Bitmap("C:\Close.gif")
            Dim r As Rectangle = e.Bounds

            r = Me.GetTabRect(e.Index)
            r.Offset(2, 2)
            Dim TitleBrush As Brush = New SolidBrush(Color.Black)
            Dim f As Font = Me.Font
            Dim title As String = Me.TabPages(e.Index).Text
            e.Graphics.DrawString(title, f, TitleBrush, New PointF(r.X, r.Y))
            'e.Graphics.DrawImage(img, New Point(r.X + (Me.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Me_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        Dim tc As TabControl = CType(sender, TabControl)
        Dim p As Point = e.Location
        Dim _tabWidth As Integer

        _tabWidth = Me.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X)
        Dim r As Rectangle = Me.GetTabRect(tc.SelectedIndex)
        r.Offset(_tabWidth, _imgHitArea.Y)
        r.Width = 16
        r.Height = 16
        If r.Contains(p) Then
            Dim TabP As TabPage = DirectCast(tc.TabPages.Item(tc.SelectedIndex), TabPage)
            tc.TabPages.Remove(TabP)
        End If
    End Sub
End Class