using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateProjects.Providers
{

    

    public class TestFilesProjectsProvider : IProjectsProvider
    {
        public string TargetDirectory { get; set; }

        public event EventHandler JobComplete;

        public void DoJob(TreeItem item)
        {
            System.Windows.Forms.MessageBox.Show(string.Format("Copied to {0}", TargetDirectory));
        }

        public List<TreeItem> GetTree()
        {
            var result = new List<TreeItem>() { new TreeItem() { Name = "WinForms", Children = new List<TreeItem>() { new TreeItem() { Name = "XtraGrid", Children = new List<TreeItem>() { new TreeItem() { Name = "Simple Grid" }, new TreeItem() { Name = "Grid2" } } } } } };
            return result;
        }
    }
}
