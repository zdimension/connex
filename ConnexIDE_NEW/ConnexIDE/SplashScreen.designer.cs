using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class SplashScreen : System.Windows.Forms.Form
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
		//SplashScreen
		//
		this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackgroundImage = global::ConnexIDE.Properties.Resources.connex;
		this.ClientSize = new System.Drawing.Size(600, 300);
		this.ControlBox = false;
		this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		this.MaximizeBox = false;
		this.MinimizeBox = false;
		this.Name = "SplashScreen";
		this.ShowIcon = false;
		this.ShowInTaskbar = false;
		this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "com.connex.splash";
		this.TopMost = true;
		this.ResumeLayout(false);

	}
	public SplashScreen()
	{
		InitializeComponent();
	}
}
