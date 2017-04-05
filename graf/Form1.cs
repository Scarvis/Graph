﻿using System;
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

        public bool isTreeOrGraph = false;
        public bool closeForm = true;
        graph fs;   //граф и рисование графа

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics asd = this.pictureBox1.CreateGraphics();
            fs = new graph(
                            asd
                            );
            isTreeOrGraph = false;
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
            else if (!edge.Enabled)
            {
                fs.hitVertex(point);
            }
            else if (!delVertex.Enabled)
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
            else if (!bfs.Enabled)
            {
                int v = fs.getHitVertex(point);
                if (v != -1)
                {
                    fs.bfs(v);
                    textBox1.Text = "BFS закончен";
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;
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
            bfs.Enabled = true;

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

        private void aProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string caption = "О программе";
            const string message = 
  "              Программа для построения графов и деревьев"
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

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Вы действительно хотите выйти?";
            const string caption = "Выход";
            var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MBSave == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void saveFile_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void forward_Click(object sender, EventArgs e)
        {

        }

        private void деревоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isTreeOrGraph = true;
            this.Close();
        }

        public void close()
        {
            isTreeOrGraph = false;
        }

        private void bfs_Click(object sender, EventArgs e)
        {
            view.Enabled = true;
            vertex.Enabled = true;
            edge.Enabled = true;
            dfs.Enabled = true;
            delVertex.Enabled = true;
            delEdge.Enabled = true;
            delGraph.Enabled = true;
            bfs.Enabled = false;


        }

        private void сохранитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
