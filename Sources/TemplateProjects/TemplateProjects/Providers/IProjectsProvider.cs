using System;
using System.Collections.Generic;
using System.Linq;

namespace TemplateProjects.Providers
{
    public static class ProjectsProvider
    {
        static IProjectsProvider _Current;
        public static IProjectsProvider Current
        {
            get
            {
                bool useTestProvider = false;
                //#if DEBUG
                //                useTestProvider = true;
                //#endif
                if (_Current == null)
                    _Current = useTestProvider ? (IProjectsProvider)new TestFilesProjectsProvider(): (IProjectsProvider)new FileSystemProjectsProvider();
                return _Current;
            }

        }
    }

    public interface IProjectsProvider
    {
        string TargetDirectory { get; set; }
        event EventHandler JobComplete;
        void DoJob(TreeItem item);
        List<TreeItem> GetTree();
    }

    

    

    public class TreeItem
    {
        public List<TreeItem> Children { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public TreeItem Parent { get; set; }

        public TreeItem()
        {
              
        }
    }
}
