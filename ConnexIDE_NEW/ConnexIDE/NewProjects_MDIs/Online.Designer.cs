using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class Online : System.Windows.Forms.Form
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
		this.SuspendLayout();
		//
		//Online
		//
		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(187)), Convert.ToInt32(Convert.ToByte(206)), Convert.ToInt32(Convert.ToByte(230)));
		this.ClientSize = new System.Drawing.Size(284, 262);
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		this.Name = "Online";
		this.Text = "Online";
		this.ResumeLayout(false);

	}
	public Online()
	{
		InitializeComponent();
	}
}
