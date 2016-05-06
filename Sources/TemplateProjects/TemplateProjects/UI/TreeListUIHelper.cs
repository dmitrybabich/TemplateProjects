using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateProjects.Providers;
using DevExpress.XtraTreeList.Nodes;

namespace TemplateProjects.UI
{
    public class TreeListUIHelper
    {

        public TreeList TreeList { get; set; }

        public TreeListUIHelper(TreeList treeList)
        {
            TreeList = treeList;
            InitState();
            InitEvents();
        }

        private void InitEvents()
        {
            TreeList.KeyDown += TreeList_KeyDown;
            TreeList.NodeCellStyle += TreeList_NodeCellStyle;
            TreeList.DoubleClick += TreeList_DoubleClick;
        }

        private void TreeList_DoubleClick(object sender, EventArgs e)
        {
            DoJob();
        }

        private void TreeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (!e.Node.HasChildren)
                e.Appearance.ForeColor = Color.Sienna;
          
        }

        private void TreeList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
                TreeList.FocusedNode.Expanded = true;
            if (e.KeyCode == Keys.Left)
                TreeList.FocusedNode.Expanded = false;
            if (e.KeyCode == Keys.Return)
            {
                DoJob();
            }
        }

        private void DoJob()
        {
            ProjectsProvider.Current.DoJob((TreeItem)TreeList.FocusedNode.GetValue("Value"));
        }

        void InitData()
        {
            var tree = ProjectsProvider.Current.GetTree();
            TreeList.BeginUnboundLoad();
            AppendTreeNodes(TreeList.Nodes, tree);
            TreeList.EndUnboundLoad();
        }
        void AppendTreeNode(TreeListNodes nodes, TreeItem item)
        {
            var node = nodes.Add();
            node.SetValue("Name", item.Name);
            node.SetValue("Value", item);
            AppendTreeNodes(node.Nodes, item.Children);
        }

        private void AppendTreeNodes(TreeListNodes nodes, List<TreeItem> tree)
        {
            if (tree == null)
                return;
            foreach (var item in tree)
            {
                AppendTreeNode(nodes, item);
            }
        }

        private void InitState()
        {
            TreeList.Focus();
            TreeList.ShowFindPanel();
            InitData();
            TreeList.ExpandToLevel(1);
        }



   
    }
}
