using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ConnexIDE;
using System.Runtime.InteropServices;

partial class MainWindow
{

	private void ProjectToolStripMenuItem_Click(System.Object sender, System.EventArgs e)
	{
		NewProjectDialog dlg = new NewProjectDialog();
		dlg.ShowDialog(this);
	}
	


    public void LoadCode(string code, LangType type, string title)
    {
       /* switch (type)
        {
            case LangType.FlowScript:*/

                CodeTab cw = new CodeTab(code, type);


                cw.Text = type.ToString();



                MainTabControl.AddTab(cw);
               
            /*    break;
            default:
                break;
        }*/
    }

    public void LoadCodeFromFile(string filePath, LangType type)
    {
        LoadCode(System.IO.File.ReadAllText(filePath), type, Path.GetFileName(filePath));
    }

	private void MainTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		// MsgBox("changed")
		if (MainTabControl.TabCount == 1) {
			MainTabControl.ShowCloseButtonOnTabs = false;
		} else {
			MainTabControl.ShowCloseButtonOnTabs = true;
		}
	}

	private void MainWindow_Load_1(System.Object sender, System.EventArgs e)
	{
		LoadCodeFromFile(@"C:\Users\Tom2\Documents\Visual Studio 2012\Projects\FlowScript\Samples\Sample 1 - Preview of FlowScript basics\main.fsc", LangType.FlowScript);
        LoadCode(@"/* libCore.Modules:
 * 	Gain access to the internal variables that defines a Module
 * libCore.Console:
 * 	Needed to use the In and Out streams 
 */
#import libCore use 'libCore.Console' // Import needed libraries
library libExample
{
	base()
	{		
// Add the basic information to the Module
		meta:author = 'Your Name'
		meta:name = 'libExample'
		meta:description = 'A short info about what the lib does'
		meta:version = '1.0.0'
	}
	method PrintLine(var:string aString, var:color aColor)
	{
		// Backup the current foreground color
		var:color backup = Console.Foreground
		// Set the new foreground color
		Console.Foreground = aColor
		// Print the text
		Console.Printn(aString)
		// Restore the foreground color
		Console.Foreground = backup
	}
}
// You just created a library!
// For a print code just copy the PrintLine method and replace
// Console.Printn(aString) with Console.Print(aString)", LangType.SplitSharp, "Split# Sample Code");
        LoadCodeFromFile(@"C:\Users\Tom2\Documents\1-Documents\Flow\flowlang\Samples\Prototype.flow", LangType.Flow);
        LoadCodeFromFile(@"C:\Users\Tom2\Documents\1-Documents\Flow\flowlang\Samples\Prototype.app.flow", LangType.Flow);
        MainTabControl.ShowCloseButtonOnTabs = true;
	}

	private void ProjectToolStripMenuItem_Click_1(System.Object sender, System.EventArgs e)
	{
		NewProjectDialog prj = new NewProjectDialog();
		prj.ShowDialog(this);
	}


	private void lkblNewPrj_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
	{
	}

	

    private void MainWindow_Load(object sender, EventArgs e)
    {
        
    }


    public const int WM_NCLBUTTONDOWN = 0xA1;
    public const int HT_CAPTION = 0x2;

    [DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd,
                     int Msg, int wParam, int lParam);
    [DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void StripContainer_Paint(object sender, PaintEventArgs e)
    {

    }

    private void StripContainer_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    private void MainTabControl_CloseButtonClick(object sender, System.ComponentModel.CancelEventArgs e)
    {
        if (MainTabControl.TabPages.Count == 1)
        {
            e.Cancel = true;
        }
        if (MainTabControl.CloseButtonCollection[(Button)sender] == tbStart)
        {
            e.Cancel = true;
        }
    }
	
}
