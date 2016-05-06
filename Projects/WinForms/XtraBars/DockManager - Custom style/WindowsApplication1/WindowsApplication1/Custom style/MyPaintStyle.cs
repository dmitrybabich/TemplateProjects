using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Styles;
using DevExpress.LookAndFeel;

namespace WindowsApplication1
{
    public class MyPaintStyle : SkinBarManagerPaintStyle
    {
        public MyPaintStyle(BarManagerPaintStyleCollection collection)
            : base(collection)
        {

        }

        public static void Register(BarManager manager)
        {
            BarAndDockingController controller = manager.GetController();
            BarManagerPaintStyleCollection paintStyles = controller.PaintStyles;
            MyPaintStyle style = new MyPaintStyle(paintStyles);
            paintStyles.Remove(paintStyles[style.Name]);
            paintStyles.Add(style);
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();
        }

        protected override void RegisterItemInfo()
        {
            base.RegisterItemInfo();
        }

    }
}
