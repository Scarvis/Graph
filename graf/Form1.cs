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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        graph fs;   //граф и рисование графа

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics asd = this.pictureBox1.CreateGraphics();
            fs = new graph(
                            asd
                            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var point = pictureBox1.PointToClient(Cursor.Position);
            if (!vertex.Enabled)
            {
                if (fs.addVertex(point))
                {
                    fs.drawVertex(
                        point.X,
                        point.Y
                        );
                }
            }
            else if(!edge.Enabled)
            {
                fs.hitVertex(point);
            }
            else if(!delVertex.Enabled)
            {
                int v = fs.getHitVertex(point);
                if (v == -1)
                {
                    return;
                }
                fs.delVertex(v);
                fs.clearPicture();
                fs.drawGraph();
            }
            else if (!delEdge.Enabled)
            {
                if (fs.delEdge(point))
                {
                    fs.clearPicture();
                    fs.drawGraph();
                }
            }
        }
        private void view_Click(object sender, EventArgs e)
        {
            view.Enabled = false;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
        }

        private void vertex_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = false;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
        }

        private void edge_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = false;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
        }

        private void delVertex_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = false;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
        }

        private void delEdge_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = false;
            delGraph.Enabled = true;
        }

        private void delGraph_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;

            const string message = "Вы действительно хотите полностью удалить граф?";
            const string caption = "Удаление";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                fs.clear();
            }
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
            if (fs.connected())
            {
                textBox1.Text = "СВЯЗНЫЙ ГРАФ";
            }
            else
            {
                textBox1.Text = "НЕСВЯЗНЫЙ ГРАФ";
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
