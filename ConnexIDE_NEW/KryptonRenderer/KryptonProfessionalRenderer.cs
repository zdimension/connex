namespace ComponentFactory.Krypton.Toolkit
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Reflection;
    using System.Windows.Forms;
    using ComponentFactory.Krypton.Toolkit;

    public class KryptonProfessionalRenderer : ToolStripProfessionalRenderer
    {
        private KryptonColorTable _kct;

        public KryptonProfessionalRenderer(KryptonColorTable kct) : base(kct)
        {
            this._kct = kct;
        }

        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            if (e.Item.GetType().ToString() == "System.Windows.Forms.MdiControlStrip+ControlBoxMenuItem")
            {
                Form topLevelControl = e.ToolStrip.Parent.TopLevelControl as Form;
                if (topLevelControl != null)
                {
                    PropertyInfo property = typeof(Form).GetProperty("MdiControlStrip", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                    if (property != null)
                    {
                        object obj2 = property.GetValue(topLevelControl, null);
                        if (obj2 != null)
                        {
                            System.Type type = obj2.GetType();
                            FieldInfo field = type.GetField("minimize", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                            FieldInfo info3 = type.GetField("restore", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                            FieldInfo info4 = type.GetField("close", BindingFlags.GetField | BindingFlags.NonPublic | BindingFlags.Instance);
                            if (((field != null) && (info3 != null)) && (info4 != null))
                            {
                                ToolStripMenuItem item = field.GetValue(obj2) as ToolStripMenuItem;
                                ToolStripMenuItem item2 = info3.GetValue(obj2) as ToolStripMenuItem;
                                ToolStripMenuItem item3 = info4.GetValue(obj2) as ToolStripMenuItem;
                                if (((item != null) && (item2 != null)) && (item3 != null))
                                {
                                    PaletteButtonSpecStyle generic = PaletteButtonSpecStyle.Generic;
                                    if (item.Image == e.Image)
                                    {
                                        generic = PaletteButtonSpecStyle.PendantMin;
                                    }
                                    else if (item2.Image == e.Image)
                                    {
                                        generic = PaletteButtonSpecStyle.PendantRestore;
                                    }
                                    else if (item3.Image == e.Image)
                                    {
                                        generic = PaletteButtonSpecStyle.PendantClose;
                                    }
                                    if (generic != PaletteButtonSpecStyle.Generic)
                                    {
                                        Image buttonSpecImage = this.KCT.Palette.GetButtonSpecImage(generic, PaletteState.Normal);
                                        Color buttonSpecImageTransparentColor = this.KCT.Palette.GetButtonSpecImageTransparentColor(generic);
                                        if (buttonSpecImage != null)
                                        {
                                            using (ImageAttributes attributes = new ImageAttributes())
                                            {
                                                ColorMap map = new ColorMap {
                                                    OldColor = buttonSpecImageTransparentColor,
                                                    NewColor = Color.Transparent
                                                };
                                                attributes.SetRemapTable(new ColorMap[] { map });
                                                e.Graphics.DrawImage(buttonSpecImage, e.ImageRectangle, 0, 0, e.Image.Width, e.Image.Height, GraphicsUnit.Pixel, attributes);
                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            base.OnRenderItemImage(e);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            /*if (!(e.ToolStrip is StatusStrip))
            {
                base.OnRenderToolStripBorder(e);
            }*/
        }

        public KryptonColorTable KCT
        {
            get
            {
                return this._kct;
            }
        }
    }
}

