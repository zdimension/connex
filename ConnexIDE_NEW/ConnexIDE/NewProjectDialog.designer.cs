using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class NewProjectDialog : ComponentFactory.Krypton.Toolkit.KryptonForm
{

	//Form overrides dispose to clean up the component list.
	[System.Diagnostics.DebuggerNonUserCode()]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	//Required by the Windows Form Designer

	private System.ComponentModel.IContainer components;
	//NOTE: The following procedure is required by the Windows Form Designer
	//It can be modified using the Windows Form Designer.  
	//Do not modify it using the code editor.
	[System.Diagnostics.DebuggerStepThrough()]
	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("FlowScript");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Split#");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Installed languages", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Get templates online (Coming soon)");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectDialog));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("FlowScript", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Split#", 1);
            this.trvLngs = new System.Windows.Forms.TreeView();
            this.KryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.Panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tbx = new ConnexIDE.Controls.TablessControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstInstalled = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstOnline = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.tbx.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvLngs
            // 
            this.trvLngs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.trvLngs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trvLngs.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvLngs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvLngs.Location = new System.Drawing.Point(0, 0);
            this.trvLngs.Name = "trvLngs";
            treeNode1.Name = "nodeFlowScript";
            treeNode1.Text = "FlowScript";
            treeNode2.Name = "Nœud2";
            treeNode2.Text = "Split#";
            treeNode3.Name = "nodeInst";
            treeNode3.Text = "Installed languages";
            treeNode4.ForeColor = System.Drawing.Color.Gray;
            treeNode4.Name = "nodeOnline";
            treeNode4.NodeFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Get templates online (Coming soon)";
            this.trvLngs.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.trvLngs.ShowLines = false;
            this.trvLngs.Size = new System.Drawing.Size(261, 382);
            this.trvLngs.TabIndex = 0;
            this.trvLngs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvLngs_AfterSelect_1);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(261, 310);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(436, 72);
            this.Panel1.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "flowscript.png");
            this.imageList1.Images.SetKeyName(1, "splitsharp98x98.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tbx
            // 
            this.tbx.Controls.Add(this.tabPage1);
            this.tbx.Controls.Add(this.tabPage2);
            this.tbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx.Location = new System.Drawing.Point(261, 0);
            this.tbx.Name = "tbx";
            this.tbx.SelectedIndex = 0;
            this.tbx.Size = new System.Drawing.Size(436, 310);
            this.tbx.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstInstalled);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(428, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstInstalled
            // 
            this.lstInstalled.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInstalled.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lstInstalled.LargeImageList = this.imageList1;
            this.lstInstalled.Location = new System.Drawing.Point(3, 3);
            this.lstInstalled.MultiSelect = false;
            this.lstInstalled.Name = "lstInstalled";
            this.lstInstalled.Size = new System.Drawing.Size(422, 276);
            this.lstInstalled.TabIndex = 3;
            this.lstInstalled.UseCompatibleStateImageBehavior = false;
            this.lstInstalled.SelectedIndexChanged += new System.EventHandler(this.lstInstalled_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstOnline);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(428, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstOnline
            // 
            this.lstOnline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOnline.LargeImageList = this.imageList2;
            this.lstOnline.Location = new System.Drawing.Point(3, 3);
            this.lstOnline.MultiSelect = false;
            this.lstOnline.Name = "lstOnline";
            this.lstOnline.Size = new System.Drawing.Size(422, 301);
            this.lstOnline.TabIndex = 4;
            this.lstOnline.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "<Template name>";
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.tbx);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.trvLngs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 420);
            this.Name = "NewProjectDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Create a new project";
            this.Load += new System.EventHandler(this.NewProjectDialog_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.tbx.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

	}


	public NewProjectDialog()
	{
		// This call is required by the Windows Form Designer.
		InitializeComponent();

		// Add any initialization after the InitializeComponent() call.
		//SetWindowTheme(trvLngs.Handle, "explorer", Nothing)
        Load += NewProjectDialog_Load;
	}

	protected override void Finalize()
	{
		//base.Finalize();
	}
	internal System.Windows.Forms.TreeView trvLngs;
	private ComponentFactory.Krypton.Toolkit.KryptonManager KryptonManager;
	internal System.Windows.Forms.TreeNode nodeInst;
	internal System.Windows.Forms.TreeNode nodeOnline;
    internal System.Windows.Forms.Panel Panel1;
    private System.Windows.Forms.ListView lstInstalled;
    private System.Windows.Forms.ImageList imageList1;
    private ConnexIDE.Controls.TablessControl tbx;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.ListView lstOnline;
    private System.Windows.Forms.ImageList imageList2;
    private System.Windows.Forms.Label label1;
}
