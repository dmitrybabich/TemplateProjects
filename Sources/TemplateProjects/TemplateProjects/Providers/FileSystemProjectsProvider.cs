using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TemplateProjects.Providers
{

    public class FileSystemProjectsProvider : IProjectsProvider
    {
        public string TargetDirectory { get; set; }

        public event EventHandler JobComplete;



        public void DoJob(TreeItem item)
        {
            if (item.Children.Count > 0)
                return;
            try
            {

                Microsoft.VisualBasic.FileIO.FileSystem.CopyDirectory(item.Path, TargetDirectory, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (JobComplete != null)
                JobComplete(this, EventArgs.Empty);
        }



        public List<TreeItem> GetTree()
        {
            var result = GetTreeCore(Path.GetFullPath("Projects"));
            return result;
        }

        public List<TreeItem> GetTreeCore(string path)
        {

            List<TreeItem> result = new List<TreeItem>();
            if (Directory.Exists(path))
            {
                var files = Directory.GetFiles(path, "*.sln", SearchOption.TopDirectoryOnly);
                if (files.Count() > 0)
                {
                    //result.AddRange(files.Select(x => new TreeItem() { Name = Path.GetFileName(x) }));
                }
                else
                {
                    var directories = Directory.GetDirectories(path);
                    result.AddRange(directories.Select(x => new TreeItem() { Name = Path.GetFileName(x), Path = x, Children = GetTreeCore(x) }));
                }
            }
            return result;
        }
    }
}
