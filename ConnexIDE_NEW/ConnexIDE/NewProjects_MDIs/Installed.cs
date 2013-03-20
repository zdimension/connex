using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
partial class Installed
{

	private void Installed_Load(System.Object sender, System.EventArgs e)
	{
		Functions.SetWindowTheme(mainlst.Handle, "Explorer", null);

        foreach (string s in System.IO.Directory.GetDirectories("%temppath%"))
        {

        }
	}

}
