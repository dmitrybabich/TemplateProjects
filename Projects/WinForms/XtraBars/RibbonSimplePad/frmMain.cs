using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Tutorials.Controls;
using DevExpress.XtraEditors.Controls;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Helpers;

namespace DevExpress.XtraBars.Demos.RibbonSimplePad {
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm {
        public frmMain() {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            SkinHelper.InitSkinGallery(rgbiSkins);
        }

  
    }
}
