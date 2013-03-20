using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class Installed : System.Windows.Forms.Form
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("FlowScript Application", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installed));
            this.mainlst = new System.Windows.Forms.ListView();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // mainlst
            // 
            this.mainlst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainlst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlst.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.mainlst.LargeImageList = this.ImageList1;
            this.mainlst.Location = new System.Drawing.Point(0, 0);
            this.mainlst.Name = "mainlst";
            this.mainlst.Size = new System.Drawing.Size(364, 327);
            this.mainlst.TabIndex = 0;
            this.mainlst.UseCompatibleStateImageBehavior = false;
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "flowscript.png");
            // 
            // Installed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 327);
            this.Controls.Add(this.mainlst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Installed";
            this.Text = "Installed";
            this.Load += new System.EventHandler(this.Installed_Load);
            this.ResumeLayout(false);

	}
	internal System.Windows.Forms.ListView mainlst;
	internal System.Windows.Forms.ImageList ImageList1;
	public Installed()
	{
		InitializeComponent();
        Load += Installed_Load;
	}
}
