Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions

Public Class CodeWin
    Public Property Type As LangType

    Dim BlueStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim BoldStyle As TextStyle = New TextStyle(Nothing, Nothing, FontStyle.Bold Or FontStyle.Underline)
    Dim GrayStyle As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    Dim MagentaStyle As TextStyle = New TextStyle(Brushes.Magenta, Nothing, FontStyle.Regular)
    Dim GreenStyle As TextStyle = New TextStyle(Brushes.Green, Nothing, FontStyle.Italic)
    Dim BrownStyle As TextStyle = New TextStyle(Brushes.Brown, Nothing, FontStyle.Italic)
    Dim MaroonStyle As TextStyle = New TextStyle(Brushes.Maroon, Nothing, FontStyle.Regular)
    Dim SameWordsStyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))


    Public Sub New(type As LangType)
        InitializeComponent()
        Me.Type = type
    End Sub

    Private Sub InitFlowScript()
        rtb.Selection.Start = Place.Empty
        rtb.DoCaretVisible()
        rtb.IsChanged = False
        rtb.ClearUndo()


    End Sub

    Private Sub rtb_TextChanged(sender As Object, e As System.EventArgs) Handles rtb.TextChanged
        If Type = LangType.FlowScript Then
            FlowScriptSyntaxHighlight(e)
        End If
    End Sub

    Private Sub FlowScriptSyntaxHighlight(ByVal e As TextChangedEventArgs)
        'FastColoredTextBox1.LeftBracket = "("
        'FastColoredTextBox1.RightBracket = ")"
        'FastColoredTextBox1.LeftBracket2 = "\x0"
        'FastColoredTextBox1.RightBracket2 = "\x0"
        'clear style of changed range
        e.ChangedRange.ClearStyle(BlueStyle, BoldStyle, GrayStyle, MagentaStyle, GreenStyle, BrownStyle)
        'string highlighting
        e.ChangedRange.SetStyle(BrownStyle, """.*?""|'.+?'")
        'comment highlighting
        e.ChangedRange.SetStyle(GreenStyle, "//.*$", RegexOptions.Multiline)
        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(/\*.*)", RegexOptions.Singleline)
        e.ChangedRange.SetStyle(GreenStyle, "(/\*.*?\*/)|(.*\*/)", RegexOptions.Singleline Or RegexOptions.RightToLeft)
        'number highlighting
        e.ChangedRange.SetStyle(MagentaStyle, "\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b")
        'attribute highlighting
        'e.ChangedRange.SetStyle(GrayStyle, "^\s*(?<range>\[.+?\])\s*$", RegexOptions.Multiline)
        'class name highlighting
        'e.ChangedRange.SetStyle(BoldStyle, "\b(class|struct|enum|interface)\s+(?<range>\w+?)\b")
        'keyword highlighting
        e.ChangedRange.SetStyle(BlueStyle, "\b(push|push$|print|cls|wait|show|frm)\b|#region\b|#endregion\b")

        'clear folding markers
        e.ChangedRange.ClearFoldingMarkers()
        'set folding markers
        'e.ChangedRange.SetFoldingMarkers("{", "}") 'allow to collapse brackets block
        'e.ChangedRange.SetFoldingMarkers("#region\b", "#endregion\b") 'allow to collapse #region blocks
        'e.ChangedRange.SetFoldingMarkers("/\*", "\*/") 'allow to collapse comment block
    End Sub
End Class