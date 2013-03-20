using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Linq;
using System.Data.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace ConnexIDE
{
    public class TabClosingEventArgs : EventArgs
    {
       
    }

    [ToolboxBitmap(typeof(System.Windows.Forms.TabControl))]
    public class TabControlEx : TabControl
    {


        protected override void WndProc(ref Message m)
        {
            if ((m.Msg == TCM_ADJUSTRECT))
            {
                RECT rc = (RECT)m.GetLParam(typeof(RECT));
                //Adjust these values to suit, dependant upon Appearance
                rc.Left -= 7;
                rc.Right += 7;
                rc.Top -= 3;
                rc.Bottom += 7;
                Marshal.StructureToPtr(rc, m.LParam, true);
            }
            base.WndProc(ref m);
        }

        private const Int32 TCM_FIRST = 0x1300;
        private const Int32 TCM_ADJUSTRECT = (TCM_FIRST + 40);
        private struct RECT
        {
            public Int32 Left;
            public Int32 Top;
            public Int32 Right;
            public Int32 Bottom;
        }

        public void AddTab(TabPage tp)
        {            
            if (tp != UnclosableTab)
            {
                tp.Text += "   ";
            }
            else
            {
                
            }
            this.TabPages.Add(tp);
        }

        [Browsable(true)]
        public string MainTab { get; set; }
        [DllImport("user32", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]

        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        public Dictionary<Button, TabPage> CloseButtonCollection = new Dictionary<Button, TabPage>();

        private bool _ShowCloseButtonOnTabs = true;
        [Browsable(true), DefaultValue(true), Category("Behavior"), Description("Indicates whether a close button should be shown on each TabPage")]
        public bool ShowCloseButtonOnTabs
        {
            get { return _ShowCloseButtonOnTabs; }
            set
            {
                _ShowCloseButtonOnTabs = value;
                foreach (Button btn in CloseButtonCollection.Keys)
                {
                    //btn = btn_loopVariable;
                    if (CloseButtonCollection[btn] != UnclosableTab)
                    {
                        btn.Visible = _ShowCloseButtonOnTabs;
                    }
                    else
                    {
                        btn.Visible = false;
                    }
                }
                RePositionCloseButtons();
            }
        }


        protected override void OnCreateControl()
        {
            base.OnCreateControl();


            foreach (KeyValuePair<Button, TabPage> item in CloseButtonCollection)
            {

                //item.Value.Text = item.Value.Text.Trim() + new string(' ', 8);

            }


            RePositionCloseButtons();

        }

        protected override void OnControlAdded(System.Windows.Forms.ControlEventArgs e)
        {
            base.OnControlAdded(e);
            TabPage tp = (TabPage)e.Control;
            //this.Controls[this.Controls.IndexOf(tp)].Text += "   ";
            Rectangle rect = this.GetTabRect(this.TabPages.IndexOf(tp));
            Button btn = AddCloseButton(tp);
            btn.Size = new Size(rect.Height - 1, rect.Height - 1);
            btn.Location = new Point((rect.X + rect.Width - rect.Height - 1) + 5, rect.Y + 1);
            SetParent(btn.Handle, this.Handle);
            btn.Click += OnCloseButtonClick;
            CloseButtonCollection.Add(btn, tp);
        }

        protected override void OnControlRemoved(System.Windows.Forms.ControlEventArgs e)
        {
            Button btn = CloseButtonOfTabPage((TabPage)e.Control);
            btn.Click -= OnCloseButtonClick;
            CloseButtonCollection.Remove(btn);
            SetParent(btn.Handle, new IntPtr());
            btn.Dispose();
            base.OnControlRemoved(e);
        }

        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            RePositionCloseButtons();
        }

        [Browsable(true)]
        public TabPage UnclosableTab { get; set; }

        public event CancelEventHandler CloseButtonClick;
        protected virtual void OnCloseButtonClick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                Button btn = (Button)sender;
                TabPage tp = CloseButtonCollection[btn];
                CancelEventArgs ee = new CancelEventArgs();
                if (CloseButtonClick != null)
                {
                    CloseButtonClick(sender, ee);
                }
                if (!ee.Cancel)
                {
                    this.TabPages.Remove(tp);                    
                }
                RePositionCloseButtons();
            }
        }

        protected virtual Button AddCloseButton(TabPage tp)
        {
            if (tp != UnclosableTab)
            {
                Button closeButton = new Button();
                var _with1 = closeButton;
                //' TODO: Give a good visual appearance to the Close button, maybe by assigning images etc.
                //'       Here I have not used images to keep things simple.
                _with1.Text = "X";
                _with1.FlatStyle = FlatStyle.Flat;
                _with1.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                _with1.ForeColor = Color.White;
                _with1.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                return closeButton;
            }
            else
            {
                Button closeButton = new Button();
                var _with1 = closeButton;
                //' TODO: Give a good visual appearance to the Close button, maybe by assigning images etc.
                //'       Here I have not used images to keep things simple.
                _with1.Text = "X";
                _with1.FlatStyle = FlatStyle.Flat;
                _with1.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                _with1.ForeColor = Color.White;
                _with1.Font = new Font("Microsoft Sans Serif", 6, FontStyle.Bold);
                _with1.Visible = false;
                return closeButton;
            }
        }

        public void RePositionCloseButtons()
        {
            foreach (KeyValuePair<Button, TabPage> item in CloseButtonCollection)
            {
                RePositionCloseButtons(item.Value);
            }
        }

        public void RePositionCloseButtons(TabPage tp)
        {
            if (tp != UnclosableTab)
            {
                Button btn = CloseButtonOfTabPage(tp);
                if (btn != null)
                {
                    int tpIndex = this.TabPages.IndexOf(tp);
                    if (tpIndex >= 0)
                    {
                        Rectangle rect = this.GetTabRect(tpIndex);
                        if (object.ReferenceEquals(this.SelectedTab, tp))
                        {
                            btn.BackColor = Color.Red;
                            btn.Size = new Size(rect.Height - 1, rect.Height - 1);
                            btn.Location = new Point(rect.X + rect.Width - rect.Height, rect.Y + 1);
                        }
                        else
                        {
                            btn.BackColor = Color.FromKnownColor(KnownColor.ButtonFace);
                            btn.Size = new Size(rect.Height - 3, rect.Height - 3);
                            btn.Location = new Point(rect.X + rect.Width - rect.Height - 1, rect.Y + 1);
                        }
                        btn.Visible = ShowCloseButtonOnTabs;
                        btn.BringToFront();
                    }
                }
            }
        }

        protected Button CloseButtonOfTabPage(TabPage tp)
	    {
            if (tp != UnclosableTab)
                return (from item in CloseButtonCollection where object.ReferenceEquals(item.Value, tp) select item.Key).FirstOrDefault();
            else
                return null;
	    }
    }
}
