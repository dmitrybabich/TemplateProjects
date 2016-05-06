//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Windows.Forms;
//using DevExpress.XtraTreeList;
//using System.IO;
//using DevExpress.XtraGrid;
//using Microsoft.VisualBasic.MyServices;
//using Microsoft.VisualBasic.FileIO;
//using DevExpress.XtraTreeList.Nodes;
//using DevExpress.XtraEditors;
//using System.Diagnostics;
//using System.Threading;

//namespace TemplateProjects
//{
//    public class DirectoryHelper
//    {
//        TreeList treeList;
//        string folders;

//        public DirectoryHelper(TreeList TreeList, string Folders)
//        {
//            treeList = TreeList;
//            folders = Folders;
//        }

//        void CreateTargetDirectory(string targetDirectory)
//        {
//            Directory.CreateDirectory(targetDirectory);
//        }

//        public void CopyFilesToDirectory(string sourceDirectory, string targetDirectory)
//        {
//            try
//            {
//                //FileSystem.CopyDirectory(sourceDirectory, targetDirectory, true);

//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//            finally
//            {
                
//            }
//        }

//        private static string GetVslocation()
//        {
//            string vslocation = @"C:\Program Files\Microsoft Visual Studio 8\Common7\IDE\devenv.exe";
//            return vslocation;
//        }

 
//        public void CopyFilesToDirectoryAndExecute(string sourceDirectory, string targetDirectory)
//        {
//            if (targetDirectory == string.Empty) throw new Exception("Target directory not exists");
//            CopyFilesToDirectory(sourceDirectory, targetDirectory);
//            string[] slnFiles = Directory.GetFiles(targetDirectory, "*.sln", System.IO.SearchOption.AllDirectories);
//            if (slnFiles.Length > 0)
//                OpenFile(slnFiles[0],"");
//        }



//        static void OpenFile(string file, string param)
//        {
//            string vslocation = GetVslocation();
//            using (Process p = new Process { StartInfo = new ProcessStartInfo(file) })
//            {
//                p.StartInfo.Arguments = param;
//                p.Start();
//            } 
//        }

        
//        public void InitRootFolders()
//        {
//            InitFolders(folders, null);
//        }

//        public void InitFolders(string path, TreeListNode parentNode)
//        {
//            treeList.BeginUnboundLoad();
//            TreeListNode node;
//            DirectoryInfo di;
//            if (parentNode != null)
//                parentNode.Nodes.Clear();
//            try
//            {
//                string[] root = Directory.GetDirectories(path);
//                foreach (string s in root)
//                {
//                    di = new DirectoryInfo(s);
//                    string[] slnFiles = Directory.GetFiles(s, "*.sln", System.IO.SearchOption.AllDirectories);
//                    if (slnFiles.Length > 0)
//                    {
//                        node = treeList.AppendNode(new object[] { s, di.Name, "Folder", null, di.Attributes }, parentNode);
//                        node.HasChildren = slnFiles.Length > 1;
//                    }
//                }
//            }
//            catch { }
//            InitFiles(path, parentNode);
//            treeList.EndUnboundLoad();
//        }

//        public void InitFiles(string path, TreeListNode parentNode)
//        {
//            TreeListNode node;
//            FileInfo fi;
//            try
//            {
//                string[] root = Directory.GetFiles(path, "*.sln");
//                foreach (string s in root)
//                {
//                    fi = new FileInfo(s);
//                    node = treeList.AppendNode(new object[] { s, fi.Name, "File", fi.Length, fi.Attributes }, parentNode);
//                    node.HasChildren = false;
//                }
//            }
//            catch { }
//        }

//    }
//}
