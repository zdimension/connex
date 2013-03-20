Public Class Installed

    Private Sub Installed_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        SetWindowTheme(mainlst.Handle, "Explorer", Nothing)
    End Sub
End Class