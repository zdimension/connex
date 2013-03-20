using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
partial class NewProjectDialog
{

	private void NewProjectDialog_Load(System.Object sender, System.EventArgs e)
	{
		Functions.SetWindowTheme(trvLngs.Handle, "Explorer", null);
		//Remove3dMDI();
        Functions.SetWindowTheme(lstInstalled.Handle, "Explorer", null);

        Functions.SetWindowTheme(lstOnline.Handle, "Explorer", null);

       /* foreach (string s in System.IO.Directory.GetDirectories("%temppath%"))
        {
            nodeInst.Nodes.Add(Path.GetDirectoryName(s));
        }*/
	}


	private void trvLngs_AfterSelect(System.Object sender, System.Windows.Forms.TreeViewEventArgs e)
    {

    }

    private void lstInstalled_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void trvLngs_AfterSelect_1(object sender, TreeViewEventArgs e)
    {
        if (trvLngs.SelectedNode.Parent == nodeInst)
        {
            tbx.SelectedTab = tabPage1;
        }
        else if (trvLngs.SelectedNode.Parent == nodeOnline)
        {
            tbx.SelectedTab = tabPage2;
        }
    }

   
	
}
