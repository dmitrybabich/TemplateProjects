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
        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable("Parent");
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            tbl.Columns.Add("DETAILID", typeof(int));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i), i });
            return tbl;
        }

        private DataTable CreateDet1Table(int RowCount)
        {
            DataTable tbl = new DataTable("Det1");
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            for (int j = 0; j < RowCount; j++)
                for (int i = 0; i < RowCount; i++)
                    tbl.Rows.Add(new object[] { String.Format("Detail1Name{0}", i), i });
            return tbl;
        }

        private DataTable CreateDet2Table(int RowCount)
        {
            DataTable tbl = new DataTable("Det2");
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            for (int j = 0; j < RowCount; j++)
                for (int i = 0; i < RowCount; i++)
                    tbl.Rows.Add(new object[] { String.Format("Detail2Name{0}", i), i });
            return tbl;
        }


        private DataSet GetMasterDetail()
        {
            DataSet ds = new DataSet("TestDS");
            ds.Tables.Add(CreateTable(20));
            ds.Tables.Add(CreateDet1Table(20));
            ds.Tables.Add(CreateDet2Table(20));
            DataColumn parentColumn = ds.Tables["Parent"].Columns["DETAILID"];
            DataColumn childColumn = ds.Tables["Det1"].Columns["ID"];
            ds.Relations.Add(new DataRelation("relDet1", parentColumn, childColumn));
            childColumn = ds.Tables["Det2"].Columns["ID"];
            ds.Relations.Add(new DataRelation("relDet2", parentColumn, childColumn));
            return ds;
        }


        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = GetMasterDetail();
            gridControl1.DataMember = "Parent";
        }
    }
}