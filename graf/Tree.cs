using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graf
{
    public partial class treeForm : Form
    {
        public treeForm()
        {
            InitializeComponent();
        }

        public bool isTreeOrGraph = false;
        public bool closeForm = true;

        private void treeForm_Load(object sender, EventArgs e)
        {
            isTreeOrGraph = false;
        }

        private void деревоToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void графToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeForm = true;
            isTreeOrGraph = true;
            this.Close();
        }
    }
}
