using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Xml;
using System.IO;
using FastColoredTextBoxNS;
using System.Runtime.InteropServices;

static class Functions
{
	static TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
    static TextStyle RedStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);
	static TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
	static TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
	static TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
	static TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
	static TextStyle BrownStyle = new TextStyle(new SolidBrush(Color.FromArgb(163, 21, 21)), null, FontStyle.Regular);
	static TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);
    static TextStyle LightGreenStyle = new TextStyle(new SolidBrush(Color.FromArgb(78, 201, 176)), null, FontStyle.Regular);

	static MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));
    [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
    public static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);
	

	
	/// <summary>
	/// String style
	/// </summary>
	public static Style StringStyle {
		get { return m_StringStyle; }
		set { m_StringStyle = value; }
	}
	private static Style m_StringStyle;
	/// <summary>
	/// Comment style
	/// </summary>
	public static Style CommentStyle {
		get { return m_CommentStyle; }
		set { m_CommentStyle = value; }
	}
	private static Style m_CommentStyle;
	/// <summary>
	/// Number style
	/// </summary>
	public static Style NumberStyle {
		get { return m_NumberStyle; }
		set { m_NumberStyle = value; }
	}

	private static Style m_NumberStyle;
	/// <summary>
	/// Keyword style
	/// </summary>
	public static Style KeywordStyle {
		get { return m_KeywordStyle; }
		set { m_KeywordStyle = value; }
	}

	private static Style m_KeywordStyle;

    /// <summary>
    /// Class name style
    /// </summary>
    public static Style ClassNameStyle
    {
        get { return m_ClassNameStyle; }
        set { m_ClassNameStyle = value; }
    }

    private static Style m_ClassNameStyle;

    #region FlowScript
    private static Regex FScriptStringRegex;
	private static Regex FScriptCommentRegex;
	private static Regex FScriptNumberRegex;

	private static Regex FScriptKeywordRegex;

    private static Regex FScriptVarTypeRegex;
	private static void InitFScriptRegex()
	{
		FScriptStringRegex = new Regex("\"\"|@\"\"|''|@\".*?\"|(?<!@)(?<range>\".*?[^\\\\]\")|'.*?[^\\\\]'", RegexOptions.Compiled);
		FScriptCommentRegex = new Regex("//.*$", RegexOptions.Multiline | RegexOptions.Compiled);
		FScriptNumberRegex = new Regex("\\b\\d+[\\.]?\\d*([eE]\\-?\\d+)?\\b", RegexOptions.Compiled);
		//FScriptClassNameRegex = New Regex("\b(Class|Structure|Enum|Interface)[ ]+(?<range>\w+?)\b", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
		FScriptKeywordRegex = new Regex("\\b(begin|end|as|break|self)\\b|#use\\b|#inc\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        FScriptVarTypeRegex = new Regex("\\b(string|)\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

		StringStyle = BrownStyle;
		CommentStyle = GreenStyle;
		NumberStyle = MagentaStyle;
		KeywordStyle = BlueStyle;
	}

	public static void SetFlowScript(object sender, TextChangedEventArgs e)
	{
		e.ChangedRange.tb.CommentPrefix = "//";
		//e.ChangedRange.tb.LeftBracket = "("c
		//e.ChangedRange.tb.RightBracket = ")"c
		//e.ChangedRange.tb.LeftBracket2 = ControlChars.NullChar
		//e.ChangedRange.tb.RightBracket2 = ControlChars.NullChar
		//clear style of changed range
		e.ChangedRange.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle);
		//
		if (FScriptStringRegex == null) {
			InitFScriptRegex();
		}
		//string highlighting
		e.ChangedRange.SetStyle(StringStyle, FScriptStringRegex);
		//comment highlighting
		e.ChangedRange.SetStyle(CommentStyle, FScriptCommentRegex);
		//number highlighting
		e.ChangedRange.SetStyle(NumberStyle, FScriptNumberRegex);
		//class name highlighting
		//e.ChangedRange.SetStyle(ClassNameStyle, FScriptClassNameRegex)
		//keyword highlighting
		e.ChangedRange.SetStyle(KeywordStyle, FScriptKeywordRegex);

		//clear folding markers
		e.ChangedRange.ClearFoldingMarkers();
		//set folding markers

    }
    #endregion

    #region Split#
    private static Regex SplitSharpStringRegex;
    private static Regex SplitSharpCommentRegex;
    private static Regex SplitSharpNumberRegex;
    private static Regex SplitSharpClassNameRegex;
    private static Regex SplitSharpKeywordRegex;

    private static Regex SplitSharpVarTypeRegex;
    private static void InitSplitSharpRegex()
    {
        SplitSharpStringRegex = new Regex("\"\"|@\"\"|@\".*?\"|(?<!@)(?<range>\".*?[^\\\\]\")|'.*?[^\\\\]'", RegexOptions.Compiled);
        SplitSharpCommentRegex = new Regex("//.*$", RegexOptions.Multiline | RegexOptions.Compiled);
        SplitSharpNumberRegex = new Regex("\\b((\\d+[\\.]?\\d*([eE]\\-?\\d+)?)|(::))\\b", RegexOptions.Compiled);
        SplitSharpClassNameRegex = new Regex("\\b(Console|libCore|libWin|Window|Button|Input)\\b", RegexOptions.Compiled);
        SplitSharpKeywordRegex = new Regex("\\b(internal|const|from|use|xse|all|var|meta|method|structure|memwrite|memread|memfill|function|return|event|for|base|self|library)\\b|#import\\b|#redirect\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        SplitSharpVarTypeRegex = new Regex("\\b(char|string|byte|int|float|hex|ptr|size|point|color)\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        StringStyle = BrownStyle;
        CommentStyle = GreenStyle;
        NumberStyle = MagentaStyle;
        KeywordStyle = BlueStyle;
        ClassNameStyle = LightGreenStyle;
    }

    public static void SetSplitSharp(object sender, TextChangedEventArgs e)
    {
        e.ChangedRange.tb.CommentPrefix = "//";
     
        //e.ChangedRange.tb.LeftBracket = "("c
        //e.ChangedRange.tb.RightBracket = ")"c
        //e.ChangedRange.tb.LeftBracket2 = ControlChars.NullChar
        //e.ChangedRange.tb.RightBracket2 = ControlChars.NullChar
        //clear style of changed range
        e.ChangedRange.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle);
        //
        if (SplitSharpStringRegex == null)
        {
            InitSplitSharpRegex();
        }
        //string highlighting
        e.ChangedRange.SetStyle(StringStyle, SplitSharpStringRegex);
        //comment highlighting
        e.ChangedRange.SetStyle(CommentStyle, SplitSharpCommentRegex);
        //number highlighting
        e.ChangedRange.SetStyle(NumberStyle, SplitSharpNumberRegex);
        //class name highlighting
        e.ChangedRange.SetStyle(ClassNameStyle, SplitSharpClassNameRegex);
        //keyword highlighting
        e.ChangedRange.SetStyle(KeywordStyle, SplitSharpKeywordRegex);
        // var type highlighting
        e.ChangedRange.SetStyle(KeywordStyle, SplitSharpVarTypeRegex);

        //clear folding markers
        e.ChangedRange.ClearFoldingMarkers();
        //set folding markers

    }
    #endregion
    #region Split#2
    private static
          TextStyle comments = new TextStyle(
              Brushes.MediumPurple, Brushes.Transparent, FontStyle.Regular);
    private static
        TextStyle strings = new TextStyle(
            new SolidBrush(Color.FromArgb(175, 20, 20)),
            Brushes.Transparent, FontStyle.Regular);
    private static
    TextStyle keywords = new TextStyle(
            Brushes.DodgerBlue, Brushes.Transparent, FontStyle.Bold);
    private static
    TextStyle numerics = new TextStyle(
        Brushes.Yellow, Brushes.Transparent, FontStyle.Regular);
    public static
        void SplitSharp(object sender, TextChangedEventArgs e)
    {
        #region Regex

        e.ChangedRange.Use(x =>
        {
            x.ClearStyle(comments, strings, keywords, numerics);
            //x.SetStyle(comments, @"(/\*([^*]|[\r\n]|(\*+([^*/]|[\r\n])))*\*+/)|(//.*)", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //x.SetStyle(strings, "(\\\".*\\\"|\\\".*$(^\\\")?)");
            //x.SetStyle(comments, "#.*$", RegexOptions.Multiline);
            x.SetStyle(comments, "(^\\s*#.*$)");
            x.SetStyle(strings, "(\"[^\"\\\\\\r\\n]*(?:\\\\.[^\"\\\\\\r\\n]*)*\")|('[^'\\\\\\r\\n]*(?:\\\\.[^'\\\\\\r\\n]*)*')");
            x.SetStyle(keywords, "\\b(import|(class {0,})|(library {0,})|(struct {0,})|function|void|true|false|return|var|for|while|if|asm|string|int|ptr|float)\\b", RegexOptions.IgnoreCase);
            x.SetStyle(numerics, @"\b(-{0,1}(\&[hH])*[0-9]{1,}[xX]*[a-fA-F]*[0-9]{0,}([hH]*|[a-fA-F]*))\b");
        });
        #endregion
    }
    #endregion

    #region Split#
    private static Regex FlowStringRegex;
    private static Regex FlowCommentRegex;
    private static Regex FlowNumberRegex;
    //private static Regex FlowClassNameRegex;
    private static Regex FlowKeywordRegex;
    private static Regex FlowRedSymbolRegex;

    //private static Regex FlowVarTypeRegex;
    private static void InitFlowRegex()
    {
        FlowStringRegex = new Regex("\"\"|@\"\"|@\".*?\"|(?<!@)(?<range>\".*?[^\\\\]\")|'.*?[^\\\\]'", RegexOptions.Compiled);
        FlowCommentRegex = new Regex("//.*$", RegexOptions.Multiline | RegexOptions.Compiled);
        FlowNumberRegex = new Regex("\\b((\\d+[\\.]?\\d*([eE]\\-?\\d+)?)|(::))\\b", RegexOptions.Compiled);
        //FlowClassNameRegex = new Regex("\\b(Console|libCore|libWin|Window|Button|Input)\\b", RegexOptions.Compiled);
        FlowKeywordRegex = new Regex("\\b(class|\\$|string|var|break|every)\\b|\u0023\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        //FlowVarTypeRegex = new Regex("\\b(char|string|byte|int|float|hex|ptr|size|point|color)\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        FlowRedSymbolRegex = new Regex("\\b\\%\\b", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        StringStyle = BrownStyle;
        CommentStyle = GreenStyle;
        NumberStyle = MagentaStyle;
        KeywordStyle = BlueStyle;
        ClassNameStyle = LightGreenStyle;
    }

    public static void SetFlow(object sender, TextChangedEventArgs e)
    {
        e.ChangedRange.tb.CommentPrefix = "//";

        e.ChangedRange.tb.LeftBracket = '(';
        e.ChangedRange.tb.RightBracket = ')';
        //e.ChangedRange.tb.LeftBracket2 = ControlChars.NullChar
        //e.ChangedRange.tb.RightBracket2 = ControlChars.NullChar
        //clear style of changed range
        e.ChangedRange.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle);
        //
        if (FlowStringRegex == null)
        {
            InitFlowRegex();
        }
        //string highlighting
        e.ChangedRange.SetStyle(StringStyle, FlowStringRegex);
        //comment highlighting
        e.ChangedRange.SetStyle(CommentStyle, FlowCommentRegex);
        //number highlighting
        e.ChangedRange.SetStyle(NumberStyle, FlowNumberRegex);
        //class name highlighting
        //e.ChangedRange.SetStyle(ClassNameStyle, FlowClassNameRegex);
        //keyword highlighting
        e.ChangedRange.SetStyle(KeywordStyle, FlowKeywordRegex);
        // var type highlighting
        //e.ChangedRange.SetStyle(KeywordStyle, FlowVarTypeRegex);

        //clear folding markers
        e.ChangedRange.ClearFoldingMarkers();
        //set folding markers

    }
    #endregion
}

public static class Extensions
{
    public static
        void Use<Range>(this Range obj, Action<Range> action)
    {
        action(obj);
    }
}