using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using TemplateProjects.UI;
using TemplateProjects.Providers;

namespace TemplateProjects
{
    public partial class TemplateChooserForm : XtraForm
    {
        
        public TemplateChooserForm()
        {
            InitializeComponent(); 
            textEdit1.Text = ProjectsProvider.Current.TargetDirectory;
            ProjectsProvider.Current.JobComplete += Current_JobComplete;
        }

        private void Current_JobComplete(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            new TreeListUIHelper(treeList1);
        }


        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            ProjectsProvider.Current.TargetDirectory = textEdit1.Text;
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                treeList1.Focus();
        }

        
 
 
    }
}