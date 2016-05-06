using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Threading.Tasks;
using DevExpress.Data.Linq;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        private async void GenerateData()
        {
            try
            {
               
                splashScreenManager1.ShowWaitForm();
                await Task.Run(() => { new DataHelper().CreateRecords((x) => { splashScreenManager1.SetWaitFormDescription(String.Format("{0}%", x)); }); });
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                
                splashScreenManager1.CloseWaitForm();    
            }
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            GenerateData();
        }



        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = new LinqInstantFeedbackSource(x =>
            {
                x.KeyExpression = "Oid"; 
                System.Linq.IQueryable query = DataHelper.GetQueryable();
                x.QueryableSource = query;
            });
        }
    }
}