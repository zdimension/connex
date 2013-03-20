Public Class SplashScreen
    Private Declare Function Beep Lib "kernel32" (ByVal dwFreq As Int32, ByVal dwDuration As Int32) As Int32
    Private Sub SplashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Me.Show()
        'Beep(600, 800)
        'Threading.Thread.Sleep(200)
        'Beep(600, 800)
        'Threading.Thread.Sleep(200)
        'Beep(1000, 1000)
        'Threading.Thread.Sleep(500)

        'MainWindow.Show()
        'Me.Close()
    End Sub
End Class