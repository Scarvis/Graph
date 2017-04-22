using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace graf
{
    class graph
    {
        class graphics
        {
            Bitmap bitmap;
            Graphics gr;
            Pen blackPen;
            Pen redPen;
            PointF point;
            Font fo;
            Brush br;
            public int radius = 20;

            public graphics(Graphics picha)
            {
                gr = picha;
                blackPen = new Pen(Color.Black);
                blackPen.Width = 2;
                redPen = new Pen(Color.Red);
                redPen.Width = 2;
                fo = new Font("Arial", 15);
                br = Brushes.Black;
            }

            public graphics(int width,int height)
            {
                bitmap = new Bitmap(width, height);
                gr = Graphics.FromImage(bitmap);
            }

            public void initGr(int width, int height)
            {
                gr = Graphics.FromImage(new Bitmap(width, height));
                blackPen = new Pen(Color.Black);
                blackPen.Width = 2;
                redPen = new Pen(Color.Red);
                redPen.Width = 2;
                fo = new Font("Arial", 15);
                br = Brushes.Black;
            }
            
            public Bitmap getBitmap()
            {
                return bitmap;
            }

            public void drawSelectedVertex(int x,int y)
            {
                int R = radius;
                gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
            }

            public void drawSelectedVertex(int x, int y, Pen pen)
            {
                int R = radius;
                gr.DrawEllipse(pen, (x - R), (y - R), 2 * R, 2 * R);
            }

            public void drawVertex(int x, int y, int lastVertex, int R = 20)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                gr.DrawString(Convert.ToString(lastVertex), fo, br, point);
            }

            public void drawEdge
                (
                vertex v1
                , vertex v2
                , int weight = 0
                , Pen customPen = null
                )
            {
                Pen lineS;
                if (customPen == null)
                {
                    lineS = new Pen(Color.Black, 3)
                    {
                        StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
                        ,
                        EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor
                    };
                }
                else
                {
                    lineS = customPen;
                    //lineS.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    //lineS.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                }
                PointF bufPt2 = new PointF(v1.x, v1.y);
                var pt2 = crossPoint(bufPt2, new PointF(v2.x, v2.y), 20);
                PointF bufPt1 = new PointF(v2.x, v2.y);
                var pt1 = crossPoint(bufPt1, new PointF(v1.x, v1.y), 20);
                gr.DrawLine(
                    lineS
                    , pt1
                    , pt2
                    );
                var pts = new PointF((v1.x + v2.x) / 2, (v1.y + v2.y) / 2);
                gr.DrawString(weight.ToString(), new Font("Arial", 20), Brushes.Blue, pts);
                drawVertex(v1.x, v1.y, v1.index + 1);
                drawVertex(v2.x, v2.y, v2.index + 1);
            }
            /// <summary>
            /// Вычисление точки пересечения с окружностью
            /// </summary>
            /// <param name="startPt">Первая точка отрезка</param>
            /// <param name="center">Центр окружности</param>
            /// <param name="r">Радиус окружности</param>
            /// http://www.cyberforum.ru/windows-forms/thread1049744.html
            /// оригинал
            private PointF crossPoint(PointF startPt, PointF center, float r)
            {
                PointF result = new Point();
                float signX, signY, deltaX, deltaY;
                signX = Math.Sign(center.X - startPt.X);
                signY = Math.Sign(center.Y - startPt.Y);
                float k = Math.Abs((center.Y - startPt.Y) / (center.X - startPt.X));
                deltaY = r * (float)Math.Sin(Math.Atan(k));
                deltaX = r * (float)Math.Cos(Math.Atan(k));
                result.X = center.X - (signX * deltaX);
                result.Y = center.Y - (signY * deltaY);
                return result;
            }

            public void clearPicture()
            {
                gr.Clear(Color.White);
            }
        }

        public class vertex
        {
            public struct versina
            {
                public int to;
                public int weight;
                public versina(int to, int weight)
                {
                    this.to = to;
                    this.weight = weight;
                }
            }
            public List<versina> col = new List<versina>();
            public Tuple <int, int> buf;
            public int x, y;
            public int index = 0;
            public vertex()
            {
                x = 0;
                y = 0;
            }
            public vertex(int x,int y)
            {
                this.x = x;
                this.y = y;
            }

            public vertex(int x, int y, int index)
            {
                this.x = x;
                this.y = y;
                this.index = index;
            }
            public void add(int v, int weight)
            {
                col.Add(new versina(v, weight));
            }
            public List<vertex> delVertex(int v, List<vertex> f)
            {
                //foreach (var i in f[v].col)
                //{
                //    f[i].col.Remove(v); //иначе эта конструкция
                //    for (int j = f[i].col.Count - 1; j >= 0; --j)
                //    {
                //        if (f[i].col[j] >= v+1)
                //        {
                //            f[i].col[j]--;
                //        }
                //    }
                //}
                //f[v].col.Clear();
                //f.RemoveAt(v);
                return f;
            }
        }

        /*
         * граф
         */
        List<vertex> g = new List<vertex>();
        /*
         * массив в котором запоминаем вершины которые мы пометили
        */
        int v1, v2;
        const int INF = 1000000000;
        /*
         * графическое отображение графа
         */
        graphics gr;

        //vertex v = new vertex();


        public graph(int width, int height)
        {
            gr.initGr(width, height);
            v1 = v2 = -1;
        }

        public graph(Graphics pikcha)
        {
            gr = new graphics(pikcha);
            v1 = v2 = -1;
        }

        public Bitmap getBitmap()
        {
            return gr.getBitmap();
        }

        public List<List<int>> getMatSmezh()
        {
            List<List<int>> res = new List<List<int>>();
            for (int i = 0; i < g.Count; ++i)
            {
                res.Add(new List<int>());
                for(int it = 0; it < g.Count; ++it)
                {
                    res[i].Add(INF);
                }
                for(int j = 0; j < g[i].col.Count; ++j)
                {
                    res[i][g[i].col[j].to] = g[i].col[j].weight;
                }
            }

            return res;
        }

        public void setMaxSize(int max_size)
        {
            for(int i = 0; i < max_size; ++i)
            {
                g.Add(new vertex());
            }
        }

        public int size()
        {
            return g.Count;
        }

        public bool addVertex(Point point)
        {
            int noDuplicateVertex = 4;
            if (getHitVertex(point, noDuplicateVertex) == -1)
            {
                g.Add(new vertex(point.X, point.Y));
                g[g.Count - 1].index = g.Count - 1;
                return true;
            }
            else
            {
                // вершина уже есть
                return false;
            }
        }

        public void addVertex(Point pt,int index)
        {
            g[index].x = pt.X;
            g[index].y = pt.Y;
            g[index].index = index;
        }

        public void drawVertex(int x, int y, int indexVertex = -2)
        {
            if (indexVertex == -2)
            {
                gr.drawVertex(x, y, g.Count);
            }
            else
            {
                gr.drawVertex(x, y, indexVertex);
            }
        }

        public void addEdge(int v, int u)
        {
            //g[u].col.Add(v);
            //g[v].col.Add(u);
        }
        public void addEdge(int v, int u, int weight)
        {
            g[u].col.Add(new vertex.versina(v, weight));
            g[v].col.Add(new vertex.versina(u, weight));
        }

        // соединение 2 вершин ребром
        public bool hitVertex
            (
            Point point //текущие координаты курсора мыши
            ,
            int weight=-1
            )
        {
            if (weight == -1)
            {
                Random x = new Random();
                weight = x.Next(0, 200);
            }
            bool isCheck = false;
            for (int i = 0; i < g.Count; i++)
            {
                if (Math.Pow((g[i].x - point.X), 2) + Math.Pow((g[i].y - point.Y), 2) <= gr.radius * gr.radius)
                {
                    if (v1 == -1)
                    {
                        v1 = i;
                        gr.drawSelectedVertex(g[i].x, g[i].y);
                    }
                    else if (v1 == i)
                    {
                        continue;
                    }
                    else if (v2 == -1)
                    {
                        v2 = i;
                        g[v1].add(v2, weight);
                        g[v2].add(v1, weight);
                        gr.drawEdge(g[v1], g[v2], weight);
                        v1 = v2 = -1;
                        isCheck = true;
                    }
                }
            }
            return isCheck;
        }

        // если нажата левая кнопка мышка, проверяем попали ли мы в вершину
        public int getHitVertex(Point pt, int defaultArc = 1)
        {
            for (int i = 0; i < g.Count; i++)
            {
                if (Math.Pow((g[i].x - pt.X), 2) + Math.Pow((g[i].y - pt.Y), 2) <=
                    //gr.radius * gr.radius если что то не работает, то используем эту формулу
                    Math.Pow(gr.radius, 2) * defaultArc
                    )
                {
                    return i;
                }
            }
            return -1;
        }

        public bool connected()
        {
            if (g.Count == 0) return false;

            bool isCheck = true;
            List<bool> used = new List<bool>();
            for (int i = 0; i < g.Count; i++)
            {
                used.Add(false);
            }
            for (int i = 0; i < g.Count; i++)
            {
                if(!used[i] && i > 0)
                {
                    isCheck = false;
                }
                if (!used[i])
                {
                    dfs(i, used);
                }
            }
            return isCheck;
        }

        private void dfs(int v, List<bool> used)
        {
            used[v] = true;
            for (int i = 0; i < g[v].col.Count; i++)
            {
                int u = g[v].col[i].to;
                if(!used[u])
                {
                    dfs(u, used);
                }
            }
        }

        public string algorithmPrima()
        {
            if (!connected()) return "несвязный граф";
            var G = getMatSmezh();
            int n = g.Count;
            int weightGraph = 0;
            List<Tuple<int, int, int>> ans = new List<Tuple<int, int, int>>();
            // значение "бесконечность"
            
            // алгоритм
            List<bool> used = new List<bool>();
            List<int> min_e = new List<int>();
            List<int> sel_e = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                used.Add(false);
                min_e.Add(INF);
                sel_e.Add(-1);
            }
            min_e[0] = 0;
            for (int i = 0; i < n; ++i)
            {
                int v = -1;
                for (int j = 0; j < n; ++j)
                    if (!used[j] && (v == -1 || min_e[j] < min_e[v]))
                        v = j;
                if (min_e[v] == INF)
                {
                    return "Нет путей";
                }

                used[v] = true;
                if (sel_e[v] != -1)
                {
                    //Console.WriteLine((v + 1).ToString() + " " + (sel_e[v] + 1).ToString());
                    weightGraph += G[v][sel_e[v]];
                    ans.Add(new Tuple<int, int, int>(v, sel_e[v], G[v][sel_e[v]]));
                }

                for (int to = 0; to < n; ++to)
                {
                    if (G[v][to] < min_e[to])
                    {
                        min_e[to] = G[v][to];
                        sel_e[to] = v;
                    }
                }
            }

            for(int i = 0; i < ans.Count; ++i)
            {
                int u = ans[i].Item1;
                int v = ans[i].Item2;
                int weight = ans[i].Item3;
                Pen redPens = new Pen(Color.Red, 7) { StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor};
                gr.drawEdge(new vertex(g[u].x, g[u].y, g[u].index), new vertex(g[v].x, g[v].y, g[v].index), weight, redPens);
            }
            

            //const string caption = "Алгоритм Прима";
            //string message = "Сумма ребер = " + weightGraph.ToString();
            //var aboutProg = MessageBox.Show(
            //    message
            //    , caption

            //    );


            return weightGraph.ToString();
        }

        public void bfs(int v, ProgressBar progress)
        {
            Thread.Sleep(500);
            List<bool> used = new List<bool>();
            for(int i = 0; i < g.Count; i++)
            {
                used.Add(false);
            }

            used[v] = true;
            gr.drawSelectedVertex(g[v].x, g[v].y);
            Thread.Sleep(1500);
            gr.drawSelectedVertex(g[v].x, g[v].y, new Pen(Color.Black, 2));
            if (g[v].col.Count == 0)
            {
                return;
            }
            progress.Value += 1;

            List<int> bufV = new List<int>();
            for(int i = 0; i < g[v].col.Count; i++)
            {
                int u = g[v].col[i].to;
                if (!used[u])
                {
                    used[u] = true;
                    bufV.Add(u);
                    gr.drawSelectedVertex(g[u].x, g[u].y);
                    progress.Value += 1;
                }
            }

            Thread.Sleep(1500);
            Pen tempPen = new Pen(Color.Black);
            tempPen.Width = 2;
            for (int i = 0; i < bufV.Count; i++)
            {
                int u = bufV[i];
                gr.drawSelectedVertex(g[u].x, g[u].y, tempPen);
            }
            while (bufV.Count > 0)
            {
                List<int> b = new List<int>();
                for(int i = 0; i < bufV.Count; i++)
                {
                    for(int j = 0; j < g[bufV[i]].col.Count; j++)
                    {
                        int u = g[bufV[i]].col[j].to;
                        if (!used[u])
                        {
                            b.Add(u);
                            used[u] = true;
                            gr.drawSelectedVertex(g[u].x, g[u].y);
                            progress.Value += 1;
                        }
                    }
                }
                for (int i = 0; i < bufV.Count; i++)
                {
                    int u = bufV[i];
                    gr.drawSelectedVertex(g[u].x, g[u].y, tempPen);
                }
                if (b.Count > 0)
                    Thread.Sleep(1500);
                bufV = b;
            }
        }

        public void delVertex(int v)
        {
            g = g[v].delVertex(v, g);
            for(int i = 0; i < g.Count; ++i)
            {
                if (g[i].index != i)
                    g[i].index = i;
            }
        }

        public bool delEdge(Point pt)
        {
            Point e = pt;
            for(int i = 0; i < g.Count; ++i)
            {
                for (int j = 0; j < g[i].col.Count; j++)
                {
                    //g[g[i].col[j]] вершина в которую ведет ребро из g[i]
                    if (((e.X - g[i].x) * (g[g[i].col[j].to].y - g[i].y) / (g[g[i].col[j].to].x - g[i].x) + g[i].y) <= (e.Y + 4) &&
                                    ((e.X - g[i].x) * (g[i].y - g[i].y) / (g[g[i].col[j].to].x - g[i].x) + g[i].y) >= (e.Y - 4))
                    {
                        if ((g[i].x <= g[g[i].col[j].to].x && g[i].x <= e.X && e.X <= g[g[i].col[j].to].x) ||
                            (g[i].x >= g[g[i].col[j].to].x && g[i].x >= e.X && e.X >= g[g[i].col[j].to].x))
                        {
                            int u = i;
                            var v = g[g[i].col[j].to].index;
                            g[u].col.RemoveAt(j);
                            g[v].col.Remove(new vertex.versina(u, g[i].col[j].weight));
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void clear()
        {
            gr.clearPicture();
            g.Clear();
        }

        public void clearPicture()
        {
            gr.clearPicture();
        }

        public void drawGraph()
        {
            bool[,] matrix = new bool[g.Count, g.Count];

            for(int i = 0; i < g.Count; ++i)
            {
                for (int j = 0; j < g[i].col.Count; ++j)
                {
                    if (!matrix[g[i].index, g[g[i].col[j].to].index] )
                    {
                        gr.drawEdge(g[i], g[g[i].col[j].to], g[i].col[j].weight);
                        matrix[g[i].index, g[g[i].col[j].to].index] = true;
                        matrix[g[g[i].col[j].to].index, g[i].index] = true;
                    }
                }
            }

            for(int i = 0; i < g.Count; ++i)
            {
                drawVertex(g[i].x, g[i].y, g[i].index + 1);
            }
        }

        public List<vertex> getListGraph()
        {
            return g;
        }
    }
}
