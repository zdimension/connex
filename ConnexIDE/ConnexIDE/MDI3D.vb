Imports System.Runtime.InteropServices

Module MDI3D
    <DllImport("User32.dll", EntryPoint:="GetWindowLong")> _
    Private Function GetWindowLong(ByVal HWND As IntPtr, ByVal Index As Integer) As Integer
    End Function

    <DllImport("user32.dll")> _
    Private Function SetWindowLong(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As IntPtr) As Integer
    End Function

    'Style constants
    Private Const GWL_STYLE As Integer = (-16)
    Private Const GWL_EXSTYLE As Integer = (-20)

    'BorderStyle Constants
    Private Const WS_BORDER As Integer = &H800000
    Private Const WS_EX_CLIENTEDGE As Integer = &H200

    Public Sub Remove3dMDI()
        Dim MDIContainer As MdiClient = Nothing
        'Grab the MdiClient as a control
        For Each c As Control In NewProjectDialog.Controls
            MDIContainer = TryCast(c, MdiClient)
            If Not MDIContainer Is Nothing Then Exit For
        Next
        'If the MDIClient control wasn't found then terminate the rest of the functoin
        If MDIContainer Is Nothing Then Exit Sub

        'Now we can change it's backcolor property
        MDIContainer.BackColor = Color.LightBlue

        'Use the API's to get the MDIContainers style/extended style
        Dim MDIStyle As Integer = GetWindowLong(MDIContainer.Handle, GWL_STYLE)
        Dim MDIExStyle As Integer = GetWindowLong(MDIContainer.Handle, GWL_EXSTYLE)
        'Update the controls styles
        SetWindowLong(MDIContainer.Handle, GWL_STYLE, MDIStyle And Not (WS_BORDER))
        SetWindowLong(MDIContainer.Handle, GWL_EXSTYLE, MDIExStyle And Not (WS_EX_CLIENTEDGE))
    End Sub
End Module
