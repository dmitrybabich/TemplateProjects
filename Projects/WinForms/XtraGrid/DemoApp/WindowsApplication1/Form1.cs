using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        #region Initialization
        Random r = new Random();
        Color GetRandomColor()
        {
            return Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
        }

        Bitmap GetBitmap(Size size, Color color, Color textColor, string text)
        {
            Bitmap image = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(image);
            g.FillRectangle(new SolidBrush(textColor), new Rectangle(new Point(1, 1), size));
            g.FillEllipse(new SolidBrush(color), new Rectangle(new Point(0, 0), size));
            g.DrawString(text, this.Font, new SolidBrush(textColor), new Rectangle(new Point(1, 1), size));
            return image;
        }

        Bitmap GetBitmap(object text)
        {
            return GetBitmap(new Size(16, 16), GetRandomColor(), GetRandomColor(), text.ToString());
        }




        private DataTable CreateTable(int RowCount, string prefix)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("Key", typeof(int));
            tbl.Columns.Add("Image", typeof(Image));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("{0}Name{1}", prefix, i), i, 3 - i, DateTime.Now.AddDays(i), i % 3, GetBitmap(i) });
            return tbl;
        }

        

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = CreateTable(20,"");
            repositoryItemGridLookUpEdit1.DataSource = CreateTable(20, "LookUp");
            gridView1.BestFitColumns();
        }

        #endregion
    }
}