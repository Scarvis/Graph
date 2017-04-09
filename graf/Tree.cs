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
        treeCode avlTree;

        private void treeForm_Load(object sender, EventArgs e)
        {
            isTreeOrGraph = false;
            //Graphics asd = this.pictureBox1.CreateGraphics();
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
            if (panel1.HorizontalScroll.Value == 0)
            {
                panel1.HorizontalScroll.Value = 785;
            }
            string temp = inputNodeBox.Text;
            int number = 0;
            if (int.TryParse(temp, out number))
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
            avlTree.clearScreen();
            avlTree.drawTree();
            avlTree.drawTree();
            listVertex.Items.Add(number.ToString());
            viewList.Items.Add(number.ToString());
            view_Click(sender, e);
            listVertex.SelectedIndex = 0;
        }

        private void deleteTree_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            const string message = "Вы действительно хотите полностью удалить дерево?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                avlTree.clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            avlTree.drawTree();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            avlTree.drawTree();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            avlTree.drawTree();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            avlTree.drawTree();
        }

        private void deleteVertex_Click(object sender, EventArgs e)
        {
            var buf = listVertex.SelectedItem;
            if (buf == null)
            {
                return;
            }
            string s = buf.ToString();
            int num = 0;
            if (int.TryParse(s, out num))
            {
                num = int.Parse(s);
                Console.WriteLine(num);
                avlTree.deleteNode(num);
                avlTree.clearScreen();
                avlTree.drawTree();
                listVertex.Items.RemoveAt(listVertex.SelectedIndex);
                listVertex.SelectedIndex = 0;
            }
            else
            {
                return;
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            var res = avlTree.getPropertiesByIndex();
            propertiesBox.Text = "";
            for (int i = 0; i < res.Count; i += 2)
            {
                propertiesBox.Text += "value (";
                propertiesBox.Text += res[i].ToString();
                propertiesBox.Text += ") = ";
                propertiesBox.Text += res[i + 1].ToString();
                propertiesBox.Text += Environment.NewLine;
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //avlTree.getPropertiesByIndex();
        }
    }
}
