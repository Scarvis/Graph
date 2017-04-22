using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace graf
{
    public partial class Form1 : Form
    {

        string programVersion;

        public Form1(string programVersion)
        {
            InitializeComponent();
            this.programVersion = programVersion;
            
        }

        public bool isTreeOrGraph = false;
        public bool closeForm = true;
        private bool lastRBSelect = false;
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
                string fr = weightVertexTextBox.Text;
                int num;
                if (int.TryParse(fr, out num))
                {
                    num = int.Parse(fr);
                    if (fs.hitVertex(point, num))
                    {
                        lastWeightVertexTextBox.Text = num.ToString();
                        if (!weightVertexRB.Checked)
                            weightVertexTextBox.Text = "";
                    }
                }
                else
                {
                    Random x = new Random();
                    num = x.Next(0, 200);
                    if (fs.hitVertex(point))
                    {
                        lastWeightVertexTextBox.Text = num.ToString();
                    }
                }
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
                    progressBar.Minimum = 0;
                    progressBar.Maximum = fs.size();
                    progressBar.Value = 0;
                    textBox1.Text = "";
                    fs.bfs(v,progressBar);
                    textBox1.Text = "BFS закончен";
                }
            }
            else
            {
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
            сохранитьТестToolStripMenuItem_Click(sender, e);
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
            var g = fs.getListGraph();
            bool isEmpty = false;
            if (g.Count == 0)
            {
                isEmpty = true;
            }
            XmlDocument doc = new XmlDocument();
            XmlDeclaration XmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(XmlDec);
            XmlElement root = doc.CreateElement("vertex");
            XmlAttribute maxVer = doc.CreateAttribute("max_size");
            XmlText MVT = doc.CreateTextNode(g.Count.ToString());
            maxVer.AppendChild(MVT);
            root.Attributes.Append(maxVer);

            for (int i = 0; i < g.Count; ++i)
            {
                XmlElement abc = doc.CreateElement("number");
                XmlAttribute rootAtr = doc.CreateAttribute("index");
                XmlText rootTxt = doc.CreateTextNode(g[i].index.ToString());

                XmlElement curX = doc.CreateElement("x");
                XmlElement curY = doc.CreateElement("y");
                XmlText xTxt = doc.CreateTextNode(g[i].x.ToString());
                XmlText yTxt = doc.CreateTextNode(g[i].y.ToString());

                XmlElement edges = doc.CreateElement("edges");

                for (int j = 0; j < g[i].col.Count; ++j)
                {
                    XmlElement edge = doc.CreateElement("index");
                    edges.AppendChild(edge);
                    XmlAttribute edgeAtr = doc.CreateAttribute("value");
                    edge.Attributes.Append(edgeAtr);
                    XmlText edgeTxt = doc.CreateTextNode(g[i].col[j].ToString());
                    edgeAtr.AppendChild(edgeTxt);
                }
                rootAtr.AppendChild(rootTxt);
                curX.AppendChild(xTxt);
                curY.AppendChild(yTxt);

                abc.Attributes.Append(rootAtr);
                abc.AppendChild(curX);
                abc.AppendChild(curY);
                abc.AppendChild(edges);

                root.AppendChild(abc);
                doc.AppendChild(root);
            }
            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Сохранить тест...";
            saveDialog.OverwritePrompt = true;
            saveDialog.CheckPathExists = true;
            saveDialog.Filter = "XML-File | *.xml";
            saveDialog.ShowHelp = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                if (isEmpty)
                {
                    MessageBox.Show("ГРАФ ПУСТОЙ");
                    return;
                }
                doc.Save(saveDialog.FileName);
            }
        }

        private void bFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            Stream stream = null;
            string dirc = Directory.GetCurrentDirectory() + "\\tests\\";
            ofd.InitialDirectory = dirc;
            ofd.Filter = "XML-File | *.xml";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = ofd.OpenFile()) != null)
                    {
                        dirc = ofd.FileName;
                        stream = null;
                    }
                    else
                    {
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            else
            {
                return;
            }

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(dirc);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNode af = xRoot.Attributes.GetNamedItem("max_size");
            int maxSz = int.Parse(af.Value);
            fs.setMaxSize(maxSz);

            foreach (XmlNode xnode in xRoot)
            {
                int index = -1;
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("index");
                    if (attr != null)
                    {
                        Console.WriteLine("index: {0}", attr.Value);
                        index = int.Parse(attr.Value);
                    }
                }
                Point buf = new Point();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - company
                    if (childnode.Name == "x")
                    {
                        Console.WriteLine("x: {0}", childnode.InnerText);
                        buf.X = int.Parse(childnode.InnerText);
                    }
                    // если узел age
                    else if (childnode.Name == "y")
                    {
                        Console.WriteLine("y: {0}", childnode.InnerText);
                        buf.Y = int.Parse(childnode.InnerText);
                        Console.Write("x = {0} , y = {0}\n", buf.X, buf.Y);
                        fs.addVertex(buf, index);
                    }
                    else if (childnode.Name == "edges")
                    {
                        foreach(XmlNode edge in childnode.ChildNodes)
                        {
                            if (edge.Attributes.Count > 0)
                            {
                                XmlNode attr = edge.Attributes.GetNamedItem("value");
                                if (attr != null)
                                {
                                    Console.WriteLine("edge index: {0}", attr.Value);
                                    fs.addEdge(index, int.Parse(attr.Value));
                                }
                            }
                        }
                    }
                }
            }
            fs.drawGraph();
        }

        private void загрузитьТестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bFSToolStripMenuItem_Click(sender, e);
        }

        private void weightVertexRB_Click(object sender, EventArgs e)
        {
            if (!lastRBSelect)
                weightVertexRB.Checked = true;
            else
                weightVertexRB.Checked = false;
            if (!lastRBSelect) lastRBSelect = true;
            else lastRBSelect = false;
        }

        private void prima_Click(object sender, EventArgs e)
        {
            string algorithmPrimaString = fs.algorithmPrima();
            algorithmPrimaSumVertexTextBox.Text = algorithmPrimaString;
        }
    }
}
