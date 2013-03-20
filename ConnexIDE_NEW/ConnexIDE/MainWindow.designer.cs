using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

partial class MainWindow : ComponentFactory.Krypton.Toolkit.KryptonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomize = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PrintToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.KryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.StripContainer = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.KryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.MainTabControl = new ConnexIDE.TabControlEx();
            this.tbStart = new System.Windows.Forms.TabPage();
            this.KryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.KryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label3 = new System.Windows.Forms.Label();
            this.lkblNewPrj = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.lkblOpenPrj = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.Label1 = new System.Windows.Forms.Label();
            this.rctProjectsGrpbx = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.MenuStrip1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StripContainer)).BeginInit();
            this.StripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel)).BeginInit();
            this.KryptonPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tbStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel1)).BeginInit();
            this.KryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rctProjectsGrpbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rctProjectsGrpbx.Panel)).BeginInit();
            this.rctProjectsGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.StatusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusStrip1.Location = new System.Drawing.Point(0, 456);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip1.Size = new System.Drawing.Size(798, 22);
            this.StatusStrip1.TabIndex = 0;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(177, 24);
            this.MenuStrip1.Stretch = false;
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            this.MenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StripContainer_MouseDown);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator,
            this.menuSave,
            this.menuSaveAs,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.menuPrint,
            this.menuPrintPreview,
            this.toolStripSeparator2,
            this.menuExit});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.BackColor = System.Drawing.SystemColors.Control;
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewProject});
            this.menuNew.Image = global::ConnexIDE.Properties.Resources.NewFile_6276;
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(146, 22);
            this.menuNew.Text = "&New";
            // 
            // menuNewProject
            // 
            this.menuNewProject.Name = "menuNewProject";
            this.menuNewProject.Size = new System.Drawing.Size(111, 22);
            this.menuNewProject.Text = "Project";
            this.menuNewProject.Click += new System.EventHandler(this.ProjectToolStripMenuItem_Click_1);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::ConnexIDE.Properties.Resources.Open_6529;
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(146, 22);
            this.menuOpen.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::ConnexIDE.Properties.Resources.Save_6530;
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(146, 22);
            this.menuSave.Text = "&Save";
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuSaveAs.Text = "Save &As";
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Image = global::ConnexIDE.Properties.Resources.Saveall_6518;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAllToolStripMenuItem.Text = "Save all";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menuPrint
            // 
            this.menuPrint.Image = ((System.Drawing.Image)(resources.GetObject("menuPrint.Image")));
            this.menuPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrint.Name = "menuPrint";
            this.menuPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPrint.Size = new System.Drawing.Size(146, 22);
            this.menuPrint.Text = "&Print";
            // 
            // menuPrintPreview
            // 
            this.menuPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("menuPrintPreview.Image")));
            this.menuPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPrintPreview.Name = "menuPrintPreview";
            this.menuPrintPreview.Size = new System.Drawing.Size(146, 22);
            this.menuPrintPreview.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(146, 22);
            this.menuExit.Text = "E&xit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUndo,
            this.menuRedo,
            this.toolStripSeparator3,
            this.menuCut,
            this.menuCopy,
            this.menuPaste,
            this.toolStripSeparator4,
            this.menuSelAll});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // menuUndo
            // 
            this.menuUndo.Image = global::ConnexIDE.Properties.Resources.Undo_16x;
            this.menuUndo.Name = "menuUndo";
            this.menuUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuUndo.Size = new System.Drawing.Size(144, 22);
            this.menuUndo.Text = "&Undo";
            // 
            // menuRedo
            // 
            this.menuRedo.Image = global::ConnexIDE.Properties.Resources.Redo_16x;
            this.menuRedo.Name = "menuRedo";
            this.menuRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuRedo.Size = new System.Drawing.Size(144, 22);
            this.menuRedo.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // menuCut
            // 
            this.menuCut.Image = ((System.Drawing.Image)(resources.GetObject("menuCut.Image")));
            this.menuCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCut.Name = "menuCut";
            this.menuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuCut.Size = new System.Drawing.Size(144, 22);
            this.menuCut.Text = "Cu&t";
            // 
            // menuCopy
            // 
            this.menuCopy.Image = ((System.Drawing.Image)(resources.GetObject("menuCopy.Image")));
            this.menuCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopy.Size = new System.Drawing.Size(144, 22);
            this.menuCopy.Text = "&Copy";
            // 
            // menuPaste
            // 
            this.menuPaste.Image = global::ConnexIDE.Properties.Resources.Paste_6520;
            this.menuPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuPaste.Name = "menuPaste";
            this.menuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuPaste.Size = new System.Drawing.Size(144, 22);
            this.menuPaste.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // menuSelAll
            // 
            this.menuSelAll.Name = "menuSelAll";
            this.menuSelAll.Size = new System.Drawing.Size(144, 22);
            this.menuSelAll.Text = "Select &All";
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCustomize,
            this.menuOptions});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // menuCustomize
            // 
            this.menuCustomize.Name = "menuCustomize";
            this.menuCustomize.Size = new System.Drawing.Size(130, 22);
            this.menuCustomize.Text = "&Customize";
            // 
            // menuOptions
            // 
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(130, 22);
            this.menuOptions.Text = "&Options";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpContents,
            this.menuHelpIndex,
            this.menuHelpSearch,
            this.toolStripSeparator5,
            this.menuAbout});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // menuHelpContents
            // 
            this.menuHelpContents.Name = "menuHelpContents";
            this.menuHelpContents.Size = new System.Drawing.Size(122, 22);
            this.menuHelpContents.Text = "&Contents";
            // 
            // menuHelpIndex
            // 
            this.menuHelpIndex.Name = "menuHelpIndex";
            this.menuHelpIndex.Size = new System.Drawing.Size(122, 22);
            this.menuHelpIndex.Text = "&Index";
            // 
            // menuHelpSearch
            // 
            this.menuHelpSearch.Name = "menuHelpSearch";
            this.menuHelpSearch.Size = new System.Drawing.Size(122, 22);
            this.menuHelpSearch.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(122, 22);
            this.menuAbout.Text = "&About...";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.ToolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripButton,
            this.OpenToolStripButton,
            this.SaveToolStripButton,
            this.PrintToolStripButton,
            this.toolStripSeparator6,
            this.CutToolStripButton,
            this.CopyToolStripButton,
            this.PasteToolStripButton,
            this.toolStripSeparator7,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator9,
            this.ToolStripButton1,
            this.toolStripButton4,
            this.toolStripButton3,
            this.ToolStripButton2});
            this.ToolStrip1.Location = new System.Drawing.Point(177, 1);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(297, 25);
            this.ToolStrip1.TabIndex = 2;
            this.ToolStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StripContainer_MouseDown);
            // 
            // NewToolStripButton
            // 
            this.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStripButton.Image = global::ConnexIDE.Properties.Resources.NewFile_6276;
            this.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStripButton.Name = "NewToolStripButton";
            this.NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.NewToolStripButton.Text = "&New";
            // 
            // OpenToolStripButton
            // 
            this.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStripButton.Image = global::ConnexIDE.Properties.Resources.Open_6529;
            this.OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripButton.Name = "OpenToolStripButton";
            this.OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStripButton.Text = "&Open";
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = global::ConnexIDE.Properties.Resources.Save_6530;
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "&Save";
            // 
            // PrintToolStripButton
            // 
            this.PrintToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripButton.Image")));
            this.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripButton.Name = "PrintToolStripButton";
            this.PrintToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PrintToolStripButton.Text = "&Print";
            this.PrintToolStripButton.Visible = false;
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // CutToolStripButton
            // 
            this.CutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStripButton.Image = global::ConnexIDE.Properties.Resources.Cut_6523;
            this.CutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripButton.Name = "CutToolStripButton";
            this.CutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CutToolStripButton.Text = "C&ut";
            // 
            // CopyToolStripButton
            // 
            this.CopyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStripButton.Image = global::ConnexIDE.Properties.Resources.Copy_6524;
            this.CopyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripButton.Name = "CopyToolStripButton";
            this.CopyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.CopyToolStripButton.Text = "&Copy";
            // 
            // PasteToolStripButton
            // 
            this.PasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteToolStripButton.Image = global::ConnexIDE.Properties.Resources.Paste_6520;
            this.PasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripButton.Name = "PasteToolStripButton";
            this.PasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::ConnexIDE.Properties.Resources.Undo_16x;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::ConnexIDE.Properties.Resources.Redo_16x;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton1
            // 
            this.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton1.Image = global::ConnexIDE.Properties.Resources.BuildSolution_104;
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            this.ToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton1.Text = "Build";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::ConnexIDE.Properties.Resources.start;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Debug & Run";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::ConnexIDE.Properties.Resources.startwithoutdebugging_6556;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Run";
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton2.Image = global::ConnexIDE.Properties.Resources.Stroke;
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton2.Text = "Stop running";
            // 
            // StripContainer
            // 
            this.StripContainer.Controls.Add(this.MenuStrip1);
            this.StripContainer.Controls.Add(this.ToolStrip1);
            this.StripContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.StripContainer.Location = new System.Drawing.Point(0, 0);
            this.StripContainer.Name = "StripContainer";
            this.StripContainer.Size = new System.Drawing.Size(798, 29);
            this.StripContainer.TabIndex = 3;
            this.StripContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.StripContainer_Paint);
            this.StripContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StripContainer_MouseDown);
            // 
            // KryptonPanel
            // 
            this.KryptonPanel.Controls.Add(this.MainTabControl);
            this.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KryptonPanel.Location = new System.Drawing.Point(0, 29);
            this.KryptonPanel.Name = "KryptonPanel";
            this.KryptonPanel.Size = new System.Drawing.Size(798, 427);
            this.KryptonPanel.TabIndex = 4;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.tbStart);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.MainTab = "Start Page";
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(798, 427);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.UnclosableTab = this.tbStart;
            this.MainTabControl.CloseButtonClick += new System.ComponentModel.CancelEventHandler(this.MainTabControl_CloseButtonClick);
            // 
            // tbStart
            // 
            this.tbStart.Controls.Add(this.KryptonPanel1);
            this.tbStart.Location = new System.Drawing.Point(-3, 21);
            this.tbStart.Name = "tbStart";
            this.tbStart.Padding = new System.Windows.Forms.Padding(3);
            this.tbStart.Size = new System.Drawing.Size(804, 409);
            this.tbStart.TabIndex = 0;
            this.tbStart.Text = "Start Page";
            this.tbStart.UseVisualStyleBackColor = true;
            // 
            // KryptonPanel1
            // 
            this.KryptonPanel1.Controls.Add(this.rctProjectsGrpbx);
            this.KryptonPanel1.Controls.Add(this.KryptonLabel1);
            this.KryptonPanel1.Controls.Add(this.Label3);
            this.KryptonPanel1.Controls.Add(this.lkblNewPrj);
            this.KryptonPanel1.Controls.Add(this.lkblOpenPrj);
            this.KryptonPanel1.Controls.Add(this.Label1);
            this.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KryptonPanel1.Location = new System.Drawing.Point(3, 3);
            this.KryptonPanel1.Name = "KryptonPanel1";
            this.KryptonPanel1.Size = new System.Drawing.Size(798, 403);
            this.KryptonPanel1.TabIndex = 9;
            // 
            // KryptonLabel1
            // 
            this.KryptonLabel1.Location = new System.Drawing.Point(360, 301);
            this.KryptonLabel1.Name = "KryptonLabel1";
            this.KryptonLabel1.Size = new System.Drawing.Size(89, 20);
            this.KryptonLabel1.TabIndex = 10;
            this.KryptonLabel1.Values.Text = "KryptonLabel1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Label3.Location = new System.Drawing.Point(31, 29);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(258, 65);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "ConnexIDE";
            // 
            // lkblNewPrj
            // 
            this.lkblNewPrj.Location = new System.Drawing.Point(44, 145);
            this.lkblNewPrj.Name = "lkblNewPrj";
            this.lkblNewPrj.Size = new System.Drawing.Size(131, 20);
            this.lkblNewPrj.TabIndex = 7;
            this.lkblNewPrj.Values.Text = "Create a new project...";
            // 
            // lkblOpenPrj
            // 
            this.lkblOpenPrj.Location = new System.Drawing.Point(44, 175);
            this.lkblOpenPrj.Name = "lkblOpenPrj";
            this.lkblOpenPrj.Size = new System.Drawing.Size(152, 20);
            this.lkblOpenPrj.TabIndex = 8;
            this.lkblOpenPrj.Values.Text = "Open an existing project...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.Label1.Location = new System.Drawing.Point(293, 90);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 45);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "2013";
            // 
            // rctProjectsGrpbx
            // 
            this.rctProjectsGrpbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rctProjectsGrpbx.Location = new System.Drawing.Point(44, 207);
            this.rctProjectsGrpbx.Name = "rctProjectsGrpbx";
            this.rctProjectsGrpbx.Size = new System.Drawing.Size(244, 176);
            this.rctProjectsGrpbx.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(206)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.KryptonPanel);
            this.Controls.Add(this.StripContainer);
            this.Controls.Add(this.StatusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip1;
            this.MinimumSize = new System.Drawing.Size(814, 516);
            this.Name = "MainWindow";
            this.Text = "ConnexIDE";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StripContainer)).EndInit();
            this.StripContainer.ResumeLayout(false);
            this.StripContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel)).EndInit();
            this.KryptonPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.tbStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel1)).EndInit();
            this.KryptonPanel1.ResumeLayout(false);
            this.KryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rctProjectsGrpbx.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rctProjectsGrpbx)).EndInit();
            this.rctProjectsGrpbx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

	}
	internal System.Windows.Forms.StatusStrip StatusStrip1;
	internal System.Windows.Forms.MenuStrip MenuStrip1;
	internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem menuNew;
	internal System.Windows.Forms.ToolStripMenuItem menuOpen;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator;
	internal System.Windows.Forms.ToolStripMenuItem menuSave;
	internal System.Windows.Forms.ToolStripMenuItem menuSaveAs;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	internal System.Windows.Forms.ToolStripMenuItem menuPrint;
	internal System.Windows.Forms.ToolStripMenuItem menuPrintPreview;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	internal System.Windows.Forms.ToolStripMenuItem menuExit;
	internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem menuUndo;
	internal System.Windows.Forms.ToolStripMenuItem menuRedo;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
	internal System.Windows.Forms.ToolStripMenuItem menuCut;
	internal System.Windows.Forms.ToolStripMenuItem menuCopy;
	internal System.Windows.Forms.ToolStripMenuItem menuPaste;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
	internal System.Windows.Forms.ToolStripMenuItem menuSelAll;
	internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem menuCustomize;
	internal System.Windows.Forms.ToolStripMenuItem menuOptions;
	internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
	internal System.Windows.Forms.ToolStripMenuItem menuHelpContents;
	internal System.Windows.Forms.ToolStripMenuItem menuHelpIndex;
	internal System.Windows.Forms.ToolStripMenuItem menuHelpSearch;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
	internal System.Windows.Forms.ToolStripMenuItem menuAbout;
	internal System.Windows.Forms.ToolStrip ToolStrip1;
	internal System.Windows.Forms.ToolStripButton NewToolStripButton;
	internal System.Windows.Forms.ToolStripButton OpenToolStripButton;
	internal System.Windows.Forms.ToolStripButton SaveToolStripButton;
	internal System.Windows.Forms.ToolStripButton PrintToolStripButton;
	internal System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
	internal System.Windows.Forms.ToolStripButton CutToolStripButton;
	internal System.Windows.Forms.ToolStripButton CopyToolStripButton;
	internal System.Windows.Forms.ToolStripButton PasteToolStripButton;
    internal System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

	public MainWindow()
	{
		// Cet appel est requis par le concepteur.
        this.tabPage1 = new ConnexIDE.CodeTab(LangType.SplitSharp);
		InitializeComponent();

        Load += MainWindow_Load_1;

		// Ajoutez une initialisation quelconque apr�s l'appel InitializeComponent().
		//Me.ToolStrip1.Renderer = New ConnexToolStripRenderer()
		this.ToolStrip1.Renderer = new KryptonRenderer.KryptonStandardRenderer(new ComponentFactory.Krypton.Toolkit.KryptonColorTable2010(KryptonRenderer.Colors123._schemeColors, ComponentFactory.Krypton.Toolkit.InheritBool.True, ComponentFactory.Krypton.Toolkit.KryptonManager.PaletteOffice2010Blue));
		this.StatusStrip1.Renderer = new ConnexToolStripRenderer();

        this.MenuStrip1.Renderer = new KryptonRenderer.KryptonStandardRenderer2(new ComponentFactory.Krypton.Toolkit.KryptonColorTable2010(KryptonRenderer.Colors123._schemeColors, ComponentFactory.Krypton.Toolkit.InheritBool.True, ComponentFactory.Krypton.Toolkit.KryptonManager.PaletteOffice2010Blue));
	}
	internal System.Windows.Forms.ToolStripMenuItem menuNewProject;
	internal System.Windows.Forms.ToolStripButton ToolStripButton1;
	internal System.Windows.Forms.ToolStripButton ToolStripButton2;
	private ComponentFactory.Krypton.Toolkit.KryptonManager KryptonManager1;
	private ComponentFactory.Krypton.Toolkit.KryptonPanel StripContainer;
	private ComponentFactory.Krypton.Toolkit.KryptonPanel KryptonPanel;
	internal System.Windows.Forms.Label Label3;
	internal System.Windows.Forms.Label Label1;
	internal ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lkblNewPrj;
	internal ComponentFactory.Krypton.Toolkit.KryptonLinkLabel lkblOpenPrj;
	internal ConnexIDE.TabControlEx MainTabControl;
	internal System.Windows.Forms.TabPage tbStart;
	internal ComponentFactory.Krypton.Toolkit.KryptonPanel KryptonPanel1;
    internal ComponentFactory.Krypton.Toolkit.KryptonLabel KryptonLabel1;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.ToolStripButton toolStripButton6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
    private ConnexIDE.CodeTab tabPage1;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private ComponentFactory.Krypton.Toolkit.KryptonGroupBox rctProjectsGrpbx;
}
