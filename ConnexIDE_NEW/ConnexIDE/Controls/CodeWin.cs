using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using FastColoredTextBoxNS;
using System.Text.RegularExpressions;
using System.Drawing;
using System.IO;

partial class CodeWin
{
	public LangType Type { get; set; }

	TextStyle BlueStyle = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
	TextStyle BoldStyle = new TextStyle(null, null, FontStyle.Bold | FontStyle.Underline);
	TextStyle GrayStyle = new TextStyle(Brushes.Gray, null, FontStyle.Regular);
	TextStyle MagentaStyle = new TextStyle(Brushes.Magenta, null, FontStyle.Regular);
	TextStyle GreenStyle = new TextStyle(Brushes.Green, null, FontStyle.Italic);
	TextStyle BrownStyle = new TextStyle(Brushes.Brown, null, FontStyle.Italic);
	TextStyle MaroonStyle = new TextStyle(Brushes.Maroon, null, FontStyle.Regular);

	MarkerStyle SameWordsStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(40, Color.Gray)));

	public CodeWin(LangType type)
	{
		InitializeComponent();
		this.Type = type;
	}

    public CodeWin(LangType type, string filePath)
    {
        InitializeComponent();
        this.Type = type;
        rtb.Text = System.IO.File.ReadAllText(filePath);
    }

    public CodeWin(string code, LangType type)
    {
        InitializeComponent();
        this.Type = type;
        this.rtb.Text = code;
        
    }

	

	private void rtb_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (Type == LangType.FlowScript) {
            Functions.SetFlowScript(sender, e);
		}
	}

	

    private void CodeWin_Load(object sender, EventArgs e)
    {

    }
}
