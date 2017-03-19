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
        int u, v;

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics asd = this.pictureBox1.CreateGraphics();
            fs = new graph(
                            asd
                            );
            u = v = -1;
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
                textBox1.Text = point.ToString();//DEBUG

            }
            else if(!edge.Enabled)
            {
                var point = this.PointToClient(Cursor.Position);
                fs.hitVertex(point);
                fs.drawLineBetweenVertices();
            }
            else if (!view.Enabled)
            {

            }
        }
        private void view_Click(object sender, EventArgs e)
        {
            vertex.Enabled = true;
            view.Enabled = false;
            edge.Enabled = true;
            dfs.Enabled = true;
        }

        private void vertex_Click(object sender, EventArgs e)
        {
            vertex.Enabled = false;
            view.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
        }

        private void edge_Click(object sender, EventArgs e)
        {
            vertex.Enabled = true;
            view.Enabled = true;
            edge.Enabled = false;
            dfs.Enabled = true;
        }

        private void delVertex_Click(object sender, EventArgs e)
        {

        }

        private void delEdge_Click(object sender, EventArgs e)
        {

        }

        private void delGraph_Click(object sender, EventArgs e)
        {

        }

        private void dfs_Click(object sender, EventArgs e)
        {
            vertex.Enabled = true;
            view.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = false;

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
