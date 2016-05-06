using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TemplateProjects.Providers;

namespace TemplateProjects
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var targetDir = args.Length > 0 ? args[0] : @"c:\TemplateProjectsTest\Copied";
            ProjectsProvider.Current.TargetDirectory = targetDir;
            Application.Run(new TemplateChooserForm());
        }
    }
}
