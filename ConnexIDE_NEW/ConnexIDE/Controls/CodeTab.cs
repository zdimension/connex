using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FastColoredTextBoxNS;
using System.Drawing;
using System.Windows.Forms;

namespace ConnexIDE
{
    class CodeTab : TabPage
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

    FastColoredTextBox rtb = new FastColoredTextBox();

	public CodeTab(LangType type)
	{
		InitializeComponent();
        
		this.Type = type;
	}

    public CodeTab(LangType type, string filePath)
    {
        InitializeComponent();
        this.Type = type;
        rtb.Text = System.IO.File.ReadAllText(filePath);
    }

    public CodeTab(string code, LangType type)
    {
        InitializeComponent();
        this.Type = type;
        this.rtb.Text = code;
        
    }

    public void InitializeComponent()
    {
        // 
        // rtb
        // 
        this.rtb.AllowDrop = true;
        this.rtb.AutoScrollMinSize = new System.Drawing.Size(25, 15);
        this.rtb.BackBrush = null;
        this.rtb.Cursor = System.Windows.Forms.Cursors.IBeam;
        this.rtb.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
        this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
        this.rtb.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        this.rtb.IsReplaceMode = false;
        this.rtb.Location = new System.Drawing.Point(0, 0);
        this.rtb.Name = "rtb";
        this.rtb.Paddings = new System.Windows.Forms.Padding(0);
        this.rtb.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
        this.rtb.Size = new System.Drawing.Size(712, 515);
        this.rtb.TextChanged += rtb_TextChanged;
        this.rtb.TabIndex = 0;

        this.Controls.Add(this.rtb);
    }

	

	private void rtb_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (Type == LangType.FlowScript) {
            Functions.SetFlowScript(sender, e);
		}
        else if (Type == LangType.SplitSharp)
        {
            Functions.SetSplitSharp(sender, e);
        }
        else if (Type == LangType.Flow)
        {
            Functions.SetFlow(sender, e);
        }
	}

    string _codetext;

    public string CodeText 
    { 
        get 
        {
            return this._codetext;
        }
        set 
        {
            _codetext = value;
            rtb.Text = _codetext;
        } 
    }


	

    private void CodeWin_Load(object sender, EventArgs e)
    {

    }
    }
}
