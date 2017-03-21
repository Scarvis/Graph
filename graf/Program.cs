using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graf
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Forma = new Form1();
            treeForm treeForms = new treeForm();
            System.IO.StreamReader file = new System.IO.StreamReader("data\\lastInclusion.txt");
            string lineFromFile;
            lineFromFile = file.ReadLine();
            file.Close();
            if ((lineFromFile == null) || (lineFromFile != "graph" && lineFromFile != "tree"))
            {
                const string message = "ERROR";
                const string caption = "Не найден файл\ndata\\lastInclusion.txt";
                var MBSave = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int lastForm = 0;
            if (lineFromFile == "graph")
            {
                //Application.Run(Forma);
                Forma.ShowDialog();
                lastForm = 1;
            }
            else if (lineFromFile == "tree")
            {
                //Application.Run(treeForms);
                treeForms.ShowDialog();
                lastForm = 2;
            }
            else
            {
                //Application.Run(Forma);
                Forma.ShowDialog();
                lastForm = 1;
                System.IO.File.WriteAllText("data\\lastInclusion.txt", "graph");
            }
            while (true)
            {
                if (treeForms.isTreeOrGraph)
                {
                    //Application.Run(Forma);
                    Forma.ShowDialog();
                    if (Forma.isTreeOrGraph)
                    {
                        treeForms.closeForm = false;
                        Forma.closeForm = true;
                    }
                    else
                    {
                        Forma.closeForm = true;
                    }
                }
                if (Forma.isTreeOrGraph)
                {
                    //Application.Run(treeForms);
                    treeForms.ShowDialog();
                    if (treeForms.isTreeOrGraph)
                    {
                        Forma.closeForm = false;
                        treeForms.closeForm = true;
                    }
                    else
                    {
                        treeForms.closeForm = true;
                    }
                }

                if (Forma.closeForm && treeForms.closeForm)
                {
                    if (lastForm == 1 && lineFromFile != "graph")
                    {
                        System.IO.File.WriteAllText("data\\lastInclusion.txt", "graph");
                    }
                    else if(lastForm==2 && lineFromFile != "tree")
                    {
                        System.IO.File.WriteAllText("data\\lastInclusion.txt", "tree");
                    }

                    break;
                }
            }
        }
    }
}
