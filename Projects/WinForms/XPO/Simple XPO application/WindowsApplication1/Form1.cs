using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        XPCollection collection;
        public Form1()
        {
            InitializeComponent();
            collection = new DataHelper().Collection;
            gridControl1.DataSource = collection;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Session.DefaultSession.Delete(collection);
            Session.DefaultSession.Save(collection);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = new XPCollection(typeof(Customer));
        }
    }
}