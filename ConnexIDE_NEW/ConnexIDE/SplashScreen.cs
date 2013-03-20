using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
partial class SplashScreen
{
	[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
	private static extern Int32 Beep(Int32 dwFreq, Int32 dwDuration);
	private void SplashScreen_Load(System.Object sender, System.EventArgs e)
	{
		//Me.Show()
		//Beep(600, 800)
		//Threading.Thread.Sleep(200)
		//Beep(600, 800)
		//Threading.Thread.Sleep(200)
		//Beep(1000, 1000)
		//Threading.Thread.Sleep(500)

		//MainWindow.Show()
		//Me.Close()
	}
	
}
