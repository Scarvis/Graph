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

        graph fs; //граф и рисование графа

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics asd = this.pictureBox1.CreateGraphics();
            fs = new graph(
                            asd
                            );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!vertex.Enabled)
            {
                var point = this.PointToClient(Cursor.Position);
                fs.addVertex(point);
                fs.drawVertex(
                    point.X,
                    point.Y
                    );
                textBox1.Text = point.ToString();   //DEBUG
            }
            else if(!edge.Enabled)
            {
                var point = this.PointToClient(Cursor.Position);
                fs.hitVertex(point);
            }
            else if(!delVertex.Enabled)
            {
                var point = this.PointToClient(Cursor.Position);
                int v = fs.getHitVertex(point);
                if (v == -1)
                {
                    return;
                }
                fs.delVertex(v);
                fs.clearPicture();
                fs.drawGraph();
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
            MessageBox.Show("to4NO");
            fs.clearPicture();
        }

        private void dfs_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = false;
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
    }
}
