using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace TreeSearch
{
    public partial class Form1 : MetroForm
    {
        #region Declaration
        //To initialize the collection
        Dictionary<string, bool> dic = new Dictionary<string, bool>();
        #endregion

        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Implementation
        //To save TreeViewAdv.
        public Dictionary<string, bool> SaveTreeState(TreeViewAdv tree)
        {
            Dictionary<string, bool> nodeStates = new Dictionary<string, bool>();
          
            foreach (TreeNodeAdv node in Collect(tree.Nodes))
            {
                nodeStates.Add(node.Text, node.Expanded);
            }
            return nodeStates;
        }

        //To load TreeViewAdv
        private void RestoreTreeState(TreeViewAdv tree, Dictionary<string, bool> treeState)
        {
            foreach (TreeNodeAdv node in Collect(tree.Nodes))
            {
                if (treeState.Keys.Count != 0 && treeState[node.Text])
                    node.Expand();
                else
                    node.Expanded = false;
            }
        }

        //To iterate through all the nodes in TreeViewAdv
        IEnumerable<TreeNodeAdv> Collect(TreeNodeAdvCollection nodes)
        {
           foreach(TreeNodeAdv node in nodes)
           {
              yield return node;

              foreach (TreeNodeAdv child in Collect(node.Nodes))
              yield return child;
           }
        }
        #endregion

        #region Events
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            //To save the Tree State
            dic = SaveTreeState(this.treeViewAdv1);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            //To load the Tree state
            this.RestoreTreeState(this.treeViewAdv1, dic);
        }
        #endregion
    }
}
