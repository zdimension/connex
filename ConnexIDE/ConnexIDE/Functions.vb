Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Imports System.Xml
Imports System.IO
Imports FastColoredTextBoxNS
Imports System.Runtime.InteropServices

Module Functions
    Dim BlueStyle As TextStyle = New TextStyle(Brushes.Blue, Nothing, FontStyle.Regular)
    Dim BoldStyle As TextStyle = New TextStyle(Nothing, Nothing, FontStyle.Bold Or FontStyle.Underline)
    Dim GrayStyle As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    Dim MagentaStyle As TextStyle = New TextStyle(Brushes.Magenta, Nothing, FontStyle.Regular)
    Dim GreenStyle As TextStyle = New TextStyle(Brushes.Green, Nothing, FontStyle.Italic)
    Dim BrownStyle As TextStyle = New TextStyle(New SolidBrush(Color.FromArgb(163, 21, 21)), Nothing, FontStyle.Regular)
    Dim MaroonStyle As TextStyle = New TextStyle(Brushes.Maroon, Nothing, FontStyle.Regular)
    Dim SameWordsStyle As MarkerStyle = New MarkerStyle(New SolidBrush(Color.FromArgb(40, Color.Gray)))

    <DllImport("uxtheme.dll", CharSet:=CharSet.Unicode)> _
    Public Function SetWindowTheme(hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer
    End Function

    Private FScriptStringRegex As Regex, FScriptCommentRegex As Regex, FScriptNumberRegex As Regex, FScriptKeywordRegex As Regex

    ''' <summary>
    ''' String style
    ''' </summary>
    Public Property StringStyle() As Style
        Get
            Return m_StringStyle
        End Get
        Set(value As Style)
            m_StringStyle = value
        End Set
    End Property
    Private m_StringStyle As Style
    ''' <summary>
    ''' Comment style
    ''' </summary>
    Public Property CommentStyle() As Style
        Get
            Return m_CommentStyle
        End Get
        Set(value As Style)
            m_CommentStyle = value
        End Set
    End Property
    Private m_CommentStyle As Style
    ''' <summary>
    ''' Number style
    ''' </summary>
    Public Property NumberStyle() As Style
        Get
            Return m_NumberStyle
        End Get
        Set(value As Style)
            m_NumberStyle = value
        End Set
    End Property
    Private m_NumberStyle As Style

    ''' <summary>
    ''' Keyword style
    ''' </summary>
    Public Property KeywordStyle() As Style
        Get
            Return m_KeywordStyle
        End Get
        Set(value As Style)
            m_KeywordStyle = value
        End Set
    End Property
    Private m_KeywordStyle As Style

    Private Sub InitFScriptRegex()
        FScriptStringRegex = New Regex("""""|@""""|''|@"".*?""|(?<!@)(?<range>"".*?[^\\]"")|'.*?[^\\]'", RegexOptions.Compiled)
        FScriptCommentRegex = New Regex("//.*$", RegexOptions.Multiline Or RegexOptions.Compiled)
        FScriptNumberRegex = New Regex("\b\d+[\.]?\d*([eE]\-?\d+)?\b", RegexOptions.Compiled)
        'FScriptClassNameRegex = New Regex("\b(Class|Structure|Enum|Interface)[ ]+(?<range>\w+?)\b", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        FScriptKeywordRegex = New Regex("\b(|break)\b|#lib\b|#ref\b|#begin\b|#end\b", RegexOptions.IgnoreCase Or RegexOptions.Compiled)

        StringStyle = BrownStyle
        CommentStyle = GreenStyle
        NumberStyle = MagentaStyle
        KeywordStyle = BlueStyle
    End Sub

    Public Sub SetFlowScript(sender As Object, ByVal e As TextChangedEventArgs)
        e.ChangedRange.tb.CommentPrefix = "//"
        'e.ChangedRange.tb.LeftBracket = "("c
        'e.ChangedRange.tb.RightBracket = ")"c
        'e.ChangedRange.tb.LeftBracket2 = ControlChars.NullChar
        'e.ChangedRange.tb.RightBracket2 = ControlChars.NullChar
        'clear style of changed range
        e.ChangedRange.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle)
        '
        If FScriptStringRegex Is Nothing Then
            InitFScriptRegex()
        End If
        'string highlighting
        e.ChangedRange.SetStyle(StringStyle, FScriptStringRegex)
        'comment highlighting
        e.ChangedRange.SetStyle(CommentStyle, FScriptCommentRegex)
        'number highlighting
        e.ChangedRange.SetStyle(NumberStyle, FScriptNumberRegex)
        'class name highlighting
        'e.ChangedRange.SetStyle(ClassNameStyle, FScriptClassNameRegex)
        'keyword highlighting
        e.ChangedRange.SetStyle(KeywordStyle, FScriptKeywordRegex)

        'clear folding markers
        e.ChangedRange.ClearFoldingMarkers()
        'set folding markers

    End Sub
End Module
