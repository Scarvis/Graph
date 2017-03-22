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
            //Panel panel1 = new Panel();
            //panel1.AutoScroll = true;
            //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        public bool isTreeOrGraph = false;
        public bool closeForm = true;
        treeCode avlTree;

        private void treeForm_Load(object sender, EventArgs e)
        {
            isTreeOrGraph = false;
            Graphics asd = this.pictureBox1.CreateGraphics();
            avlTree = new treeCode(
                            asd
                            , pictureBox1.Width
                            , pictureBox1.Height
                            );
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

        private void aProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string caption = "О программе";
            const string message =
  "              Программа для построения деревьев и графов"
+ "               \n\n"
+ "              Автор:"
+ "            \n\n"
+ "              Бадаев Михаил"
+ "                \n\n"
+ "              2017 год";
            var aboutProg = MessageBox.Show(
                message
                , caption

                );
        }

        private void addVertex_Click(object sender, EventArgs e)
        {
            string temp = inputNodeBox.Text;
            int number = 0;
            if(int.TryParse(temp,out number))
            {
                number = int.Parse(temp);
                inputNodeBox.Text = "";
            }
            else
            {
                MessageBox.Show("Некооректные данные");
                inputNodeBox.Text = "";
                return;
            }

            avlTree.addNode(number);
            avlTree.drawTree();
        }

        private void deleteTree_Click(object sender, EventArgs e)
        {
            avlTree.clear();
        }
    }
}
