using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class CodeWin : System.Windows.Forms.Form
{

	//Form remplace la méthode Dispose pour nettoyer la liste des composants.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		try {
			if (disposing && components != null) {
				components.Dispose();
			}
		} finally {
			base.Dispose(disposing);
		}
	}

	//Requise par le Concepteur Windows Form

	private System.ComponentModel.IContainer components;
	//REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	//Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	//Ne la modifiez pas à l'aide de l'éditeur de code.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
            this.rtb = new FastColoredTextBoxNS.FastColoredTextBox();
            this.SuspendLayout();
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
            this.rtb.TabIndex = 0;
            // 
            // CodeWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 515);
            this.Controls.Add(this.rtb);
            this.Name = "CodeWin";
            this.Text = "CodeWin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CodeWin_Load);
            this.ResumeLayout(false);

	}
	internal FastColoredTextBoxNS.FastColoredTextBox rtb;
	public CodeWin()
	{
		InitializeComponent();
	}
}
