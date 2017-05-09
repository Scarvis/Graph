using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf
{
    class treeCode
    {
        private class graphicsTree
        {
            Graphics gr;
            Pen blackPen;
            Pen redPen;
            PointF point;
            Font fo;
            Brush br;
            public int radius = 20;

            public graphicsTree(Graphics picha)
            {
                gr = picha;
                blackPen = new Pen(Color.Black);
                blackPen.Width = 2;
                redPen = new Pen(Color.Red);
                redPen.Width = 2;
                fo = new Font("Arial", 12);
                br = Brushes.Black;
            }

            public void drawSelectedVertex(int x, int y)
            {
                int R = radius;
                gr.DrawEllipse(redPen, (x - R), (y - R), 2 * R, 2 * R);
            }

            public void drawVertex(int x, int y, int lastVertex, int R = 20)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(blackPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                string buf = Convert.ToString(lastVertex);
                gr.DrawString(buf, fo, br, point.X - (buf.Count<char>()) * 2, point.Y);
            }

            public void drawVertex(int x, int y, int lastVertex, Pen customPen, int R = 20)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(customPen, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                string buf = Convert.ToString(lastVertex);
                gr.DrawString(buf, fo, br, point.X - (buf.Count<char>()) * 2, point.Y);
            }

            public void drawEdge
                (
                  int x1
                , int y1
                , int x2
                , int y2
                , int indexv1
                , int indexv2
                )
            {
                gr.DrawLine(
                    blackPen
                    , x1
                    , y1
                    , x2
                    , y2
                    );
                drawVertex(x1, y1, indexv1);
                drawVertex(x2, y2, indexv2);
            }

            public void drawEdge(binaryTree.node left, binaryTree.node right, Pen customPen)
            {
                gr.DrawLine(
                    customPen
                    , left.x
                    , left.y
                    , right.x
                    , right.y
                    );
            }

            public void drawHeight(binaryTree.node val, Brush customBr = null)
            {
                if (customBr == null)
                    customBr = br;
                string buf1 = val.getHeightLeftSon().ToString();
                string buf2 = val.getHeightRightSon().ToString();
                string buf = buf1 + ' ' + buf2;
                gr.DrawString(buf, new Font("Arial", 8), customBr, val.x - (buf.Count<char>()) * 2 - 4, val.y - 30);
            }

            public void clearPicture()
            {
                gr.Clear(Color.White);
                
            }
        }

        private class binaryTree
        {
            public class node
            {
                public int x, y;
                public int value;
                public int index;
                public int heightNode = 0;
                public int prevHeightNode = 0;
                public int heightLeftSon = 0, heightRightSon = 0;
                public node leftSon, rightSon, parent;
                public bool isAdd = false;
                public int lastFactor = 0;

                public node()
                {
                    value = -1;
                    index = 0;
                }

                public node(int x, int y, int value)
                {
                    this.value = value;
                    index = 0;
                    this.x = x;
                    this.y = y;
                }

                public node(int value)
                {
                    this.value = value;
                    index = 0;
                }

                public node getLeftSon()
                {
                    return leftSon;
                }

                public node getRightSon()
                {
                    return rightSon;
                }

                public bool isBalanced()
                {
                    return Math.Abs(heightNode) <= 1;
                }

                public int getHeightLeftSon()
                {
                    return heightLeftSon;
                }

                public int getHeightRightSon()
                {
                    return heightRightSon;
                }

                public void setHeightLeftSon(int val)
                {
                    heightLeftSon = val;
                }

                public void setHeightRightSon(int val)
                {
                    heightRightSon = val;
                }

                public bool isError()
                {
                    return x == y && y == value && value == -777;
                }

                public void incrementHeightRightSon()
                {
                    heightRightSon++;
                }

                public void incrementHeightLeftSon()
                {
                    heightLeftSon++;
                }
            }

            public int height, width;
            public int Count = 0;
            public node root = new node(-777, -777, -777);
            public bool addNewLevel = false;
            List<node> avlTree = new List<node>();
            string lastAdd = " ";


            public binaryTree()
            {
            }

            public binaryTree(node unit)
            {
                root = unit;
                avlTree.Add(root);
            }

            public binaryTree(int value)
            {
                root.value = value;
                root.index = 0;
                avlTree.Add(root);
            }

            private node rotateright(node p) // правый поворот вокруг p
            {
                node q = p.leftSon;
                p.leftSon = q.rightSon;
                q.rightSon = p;
                return q;
            }

            private node rotateleft(node q) // левый поворот вокруг q
            {
                node p = q.rightSon;
                q.rightSon = p.leftSon;
                p.leftSon = q;
                return p;
            }

            private node curBalance(node cur)
            {
                //fixHeight(cur);
                if (cur.heightRightSon - cur.heightLeftSon == 2)
                {
                    if (/*cur.rightSon != null && */cur.rightSon.heightNode < 0)
                        cur.rightSon = rotateright(cur.rightSon);
                    return rotateleft(cur);
                }
                if (cur.heightRightSon - cur.heightLeftSon == -2)
                {
                    if (/*cur.leftSon != null &&*/ cur.leftSon.heightNode > 0)
                        cur.leftSon = rotateleft(cur.leftSon);
                    return rotateright(cur);
                }
                return cur; // балансировка не нужна
            }

            public node tempFunction(node cur)
            {
                if (cur == null) return cur;
                if (Math.Abs(cur.heightNode) >= 2)
                {
                    cur = curBalance(cur);
                    funcForBalanceHeight(cur);
                    return cur;
                }
                cur.leftSon = tempFunction(cur.leftSon);
                cur.rightSon = tempFunction(cur.rightSon);
                return cur;
            }

            public void balance()
            {
                //lastAdd = "balance";
                funcForBalanceHeight(root);

                root = tempFunction(root);

                //root = curBalance(root);

                avlTree.Clear();
                reBuildArrayForBalance(root);
                reBuild();
            }

            private void fixHeight(node cur)
            {
                cur.heightNode = (
                        ph(cur.leftSon) >
                        ph(cur.rightSon) ?
                        ph(cur.leftSon) :
                        ph(cur.rightSon)
                        )
                        + 1;
            }

            private int ph(node cur)
            {
                return cur != null ? cur.heightNode : 0;
            }

            private void funcForBalanceHeight(node cur)
            {
                if (cur != null)
                {
                    cur.heightNode = cur.heightRightSon - cur.heightLeftSon;
                }
                else return;
                funcForBalanceHeight(cur.leftSon);
                funcForBalanceHeight(cur.rightSon);
            }

            public bool isBalance(node cur)
            {
                if (cur == null) return true;
                if (!cur.isBalanced()) return false;
                return isBalance(cur.leftSon) && isBalance(cur.rightSon);
            }

            public node findNode(int value, node finder = null, node parent = null)
            {
                if (finder == null)
                {
                    finder = root;
                    if (finder.isError())
                    {
                        return new node(-777, -777, -777);
                    }
                }
                if (value > finder.value)
                {
                    return findNode(value, finder.rightSon, finder);
                }
                else if (value < finder.value)
                {
                    return findNode(value, finder.leftSon, finder);
                }
                else
                {
                    return finder;
                }
            }

            private node findAndAdd(int value, node finder = null, node parent = null, int hNode = 0)
            {
                int v = 0;
                if (finder == null)
                {
                    if (parent.leftSon == parent.rightSon && !addNewLevel)
                    {
                        addNewLevel = true;
                        parent.isAdd = true;
                    }
                    int u = parent.index;
                    int x = avlTree[u].x;
                    int y = avlTree[u].y + 60;
                    if (value < parent.value)
                    {
                        if (parent == root)
                            x -= 80;
                        else
                            x -= 40;
                        parent.heightLeftSon++;
                    }
                    else
                    {
                        if (parent == root)
                            x += 80;
                        else
                            x += 40;
                        parent.heightRightSon++;
                    }
                    finder = new node(x, y, value);
                    finder.parent = parent;
                    finder.index = avlTree.Count;
                    if (value < parent.value)
                    {
                        parent.leftSon = finder;
                    }
                    else
                    {
                        parent.rightSon = finder;
                    }
                    return finder;
                }
                v = finder.index;
                hNode++;
                if (value == finder.value)
                {
                    return new node(-777, -777, -777);
                }
                if (value > finder.value)
                {

                    //avlTree[v].incrementHeightRightSon();
                    if (lastAdd.Count<char>() == 0 && finder == root)
                    {
                        lastAdd = "right";
                    }
                    var res = findAndAdd(
                       value
                       , finder.getRightSon()
                       , finder
                       , hNode
                       );
                    if (addNewLevel)
                    {
                        if (finder.getHeightRightSon() >= finder.getHeightLeftSon())
                        {
                            //if (finder.value < finder.parent.value)
                            //{
                            //    //finder.x -= 80;
                            //}
                            //else
                            //{
                            //    //finder.x += 80;
                            //}
                        }
                        //finder.incrementHeightRightSon();
                    }
                    if (!addNewLevel && res.parent.leftSon == null)
                        addNewLevel = true;
                    return res;
                }
                else if (value < finder.value)
                {
                    if (lastAdd.Count<char>() == 0 && finder == root)
                    {
                        lastAdd = "left";
                    }
                    if (v != 0 && finder.parent.value > finder.value)
                    {
                        //finder.x -= 80;
                    }
                    var res = findAndAdd(
                        value,
                         finder.getLeftSon()
                        , finder
                        , hNode
                        );
                    if (addNewLevel)
                    {
                        if (finder.getHeightRightSon() <= finder.getHeightLeftSon())
                        {
                            //if (finder.value < finder.parent.value)
                            //{
                            //    //finder.x -= 80;
                            //}
                            //else
                            //{
                            //    //finder.x += 80;
                            //}
                        }
                        //finder.incrementHeightLeftSon();
                    }
                    if (parent != null)
                        if (!addNewLevel && res.parent.rightSon == null)
                            addNewLevel = true;
                    return res;
                }
                else
                {
                    return new node(-777, -777, -777);
                }
            }

            public bool addNode(int value)
            {
                if (root.isError())
                {
                    root.x = height / 2;
                    root.y = 30;
                    root.value = value;
                    root.index = 0;
                    avlTree.Add(root);
                    return true;
                }
                node flag = findAndAdd(value, root);

                if (flag.isError())
                {
                    return false;
                }

                if (flag.parent == root)
                {
                    flag.lastFactor = 1;
                }

                avlTree.Add(flag);
                ++Count;
                return true;
            }

            private int setHeightRec(node val)
            {
                if (val == null)
                    return 0;
                if (val.leftSon == null && val.rightSon == null)
                    return 0;
                int buf1 = val.heightLeftSon;
                int buf2 = val.heightRightSon;

                if (val.leftSon != null)
                {
                    setHeightRec(val.leftSon);
                    val.heightLeftSon = //Math.Max(
                        Math.Max(val.leftSon.heightLeftSon, val.leftSon.heightRightSon) + 1
                        //, val.heightLeftSon)
                        ;
                    if (buf1 != val.heightLeftSon)
                        val.isAdd = true;
                }
                if (val.rightSon != null)
                {
                    setHeightRec(val.rightSon);
                    val.heightRightSon = Math.Max(Math.Max(val.rightSon.heightLeftSon, val.rightSon.heightRightSon) + 1, val.heightRightSon);
                    if (buf2 != val.heightRightSon)
                        val.isAdd = true;
                }

                return 0;
            }

            public void setHeight()
            {
                if (lastAdd == "left")
                {
                    setHeightRec(root.leftSon);
                    if (root.leftSon != null)
                    {
                        root.heightLeftSon = Math.Max(root.leftSon.heightLeftSon, root.leftSon.heightRightSon) + 1;
                    }
                }
                else if (lastAdd == "right")
                {
                    setHeightRec(root.rightSon);
                    if (root.rightSon != null)
                    {
                        root.heightRightSon = Math.Max(root.rightSon.heightLeftSon, root.rightSon.heightRightSon) + 1;
                    }
                }
                else if (lastAdd == "deleteNode")
                {
                    setHeightRec(root.leftSon);
                    if (root.leftSon != null)
                    {
                        root.heightLeftSon = Math.Max(root.leftSon.heightLeftSon, root.leftSon.heightRightSon) + 1;
                    }
                    setHeightRec(root.rightSon);
                    if (root.rightSon != null)
                    {
                        root.heightRightSon = Math.Max(root.rightSon.heightLeftSon, root.rightSon.heightRightSon) + 1;
                    }
                }
                else if (lastAdd == "balance")
                {

                }
                lastAdd = "";
            }

            public void clear()
            {
                avlTree.Clear();
                root = new node(-777, -777, -777);
                Count = 0;
            }

            public List<node> getListTree()
            {
                return avlTree;
            }

            public bool delNode(int value)
            {
                node temp = findNode(value);
                int bufV = 0;
                int x, y;
                if (temp.isError())
                {
                    return false;
                }
                lastAdd = "deleteNode";
                if (temp.leftSon == null && temp.rightSon == null)
                {
                    int val = temp.value;
                    if (val < temp.parent.value)
                    {
                        temp.parent.leftSon = null;
                        temp.parent.heightLeftSon--;
                    }

                    else if (val > temp.parent.value)
                    {
                        temp.parent.rightSon = null;
                        temp.parent.heightRightSon--;
                    }

                    temp = null;

                    for (int i = 0; i < avlTree.Count; i++)
                    {
                        if (avlTree[i].value == value)
                        {
                            avlTree.RemoveAt(i);
                            return true;
                        }
                    }
                }
                else if (temp.leftSon == null && temp.rightSon != null)
                {
                    bufV = temp.rightSon.value;
                    temp = temp.rightSon;
                    x = temp.parent.x;
                    y = temp.parent.y;
                    temp.parent = temp;
                    temp.x = x;
                    temp.y = y;

                }
                else if (temp.leftSon != null && temp.rightSon == null)
                {
                    bufV = temp.leftSon.value;
                    temp = temp.leftSon;
                    x = temp.parent.x;
                    y = temp.parent.y;
                    temp.parent = temp;
                    temp.x = x;
                    temp.y = y;

                }
                else
                {
                    temp = temp.rightSon;
                    while (temp.leftSon != null)
                    {
                        temp = temp.leftSon;
                    }
                    int val = temp.value;
                    int rigVal = (temp.rightSon != null) ? temp.rightSon.value : -1;
                    if (temp.parent != root)
                    {
                        temp.parent.leftSon = temp.leftSon;
                        temp.parent.heightLeftSon--;
                    }
                    else
                    {
                        temp.parent.rightSon = temp.rightSon;
                        temp.parent.heightRightSon--;
                    }
                    temp = findNode(value);
                    int k = -1;
                    int thirdIt = -1;
                    for (int i = 0; i < avlTree.Count; i++)
                    {
                        if (avlTree[i].value == rigVal) thirdIt = i;
                        if (avlTree[i].value == val)
                        {
                            k = i;
                            if (rigVal != -1)
                            {
                                avlTree[i].value = rigVal;
                            }
                        }
                        if (avlTree[i].value == temp.value)
                        {
                            avlTree[i].value = val;
                        }
                    }
                    if (rigVal != -1)
                        avlTree.RemoveAt(thirdIt);
                    else
                        avlTree.RemoveAt(k);
                    temp.value = val;
                    reBuild();
                    return true;
                }
                int it = -1;
                for (int i = 0; i < avlTree.Count; i++)
                {
                    if (avlTree[i].value == bufV)
                    {
                        it = i;
                    }
                    if (avlTree[i].value == value)
                    {
                        avlTree[i].value = bufV;
                    }
                }
                avlTree.RemoveAt(it);
                reBuild();
                return true;
            }

            private void reconRec(node val, string dir, int mnozhitel = 0, int alpha = 0, bool parentAdd = false)
            {
                if (val == null) return;
                int diff = Math.Max(val.lastFactor, mnozhitel);
                if (dir == "left" /*&& val.lastFactor != mnozhitel*/)
                {
                    if (val.parent != root)
                    {
                        int um = (Math.Max(val.heightLeftSon, val.heightRightSon) + 1);
                        val.x = val.parent.x - 40 * (Math.Max(val.heightLeftSon, val.heightRightSon) + 1);
                        if (um > 1 && um % 2 == 1)
                        {
                            val.x -= 40;
                        }
                    }
                    else if (val.lastFactor != mnozhitel)
                    {
                        val.x -= 80;
                    }
                    val.isAdd = false;
                    parentAdd = true;
                    val.lastFactor = mnozhitel;
                }
                else
                    parentAdd = false;

                if (dir == "right" /*&& val.lastFactor != mnozhitel*/)
                {
                    if (val.parent != root)
                    {
                        int um = (Math.Max(val.heightLeftSon, val.heightRightSon) + 1);
                        val.x = val.parent.x + 40 * (Math.Max(val.heightLeftSon, val.heightRightSon) + 1);
                        if (um > 1 && um % 2 == 1)
                        {
                            val.x += 40;
                        }
                    }
                    else if (val.lastFactor != mnozhitel)
                    {
                        val.x += 80;
                    }
                    val.isAdd = false;
                    parentAdd = true;
                    val.lastFactor = mnozhitel;
                }

                reconRec(val.leftSon, "left", val.heightLeftSon, alpha, parentAdd);
                reconRec(val.rightSon, "right", val.heightRightSon, alpha, parentAdd);
            }

            public void reconstr()
            {
                reconRec(root.leftSon, "left", root.heightLeftSon);
                reconRec(root.rightSon, "right", root.heightRightSon);
            }

            public void reBuild()
            {
                root = new node(-777, -777, -777);
                List<node> temp = new List<node>();
                for (int i = 0; i < avlTree.Count; ++i)
                {
                    temp.Add(avlTree[i]);
                }
                avlTree.Clear();
                for (int i = 0; i < temp.Count; i++)
                {
                    addNode(temp[i].value);
                    setHeight();
                    reconstr();
                }
            }

            public void reBuildArrayForBalance(node cur) // cur==root first call
            {
                if (cur == null) return;
                avlTree.Add(cur);
                reBuildArrayForBalance(cur.leftSon);
                reBuildArrayForBalance(cur.rightSon);
            }
        }

        graphicsTree graphics;
        binaryTree avlTree = new binaryTree();

        public treeCode(Graphics grafouni, int h, int w)
        {
            graphics = new graphicsTree(grafouni);
            avlTree.height = h;
            avlTree.width = w;
        }

        public bool addNode(int value)
        {
            bool res = avlTree.addNode(value);
            graphics.clearPicture();
            avlTree.addNewLevel = false;
            avlTree.setHeight();
            avlTree.reconstr();
            return res;
        }

        public void balance()
        {
            avlTree.balance();
        }

        public List<int> getPropertiesByIndex()
        {
            List<int> res = new List<int>();
            var buf = avlTree.getListTree();
            for(int i = 0; i < buf.Count; ++i)
            {
                res.Add(buf[i].value);
                res.Add(buf[i].x);
            }
            return res;
        }

        public bool deleteNode(int value)
        {
            return avlTree.delNode(value);
        }

        public void clear()
        {
            avlTree.clear();
            graphics.clearPicture();
        }

        public void clearScreen()
        {
            var temp = avlTree.getListTree();

            for (int i = 0; i < temp.Count; ++i)
            {
                graphics.drawVertex(temp[i].x, temp[i].y, temp[i].value, new Pen(Color.White, 2));

            }
            if (temp.Count > 0)
                drawEdgesFromClearScreen(temp[0]);
            
            for (int i = 0; i < temp.Count; ++i)
            {
                graphics.drawHeight(temp[i], Brushes.White);
            }
        }

        public void fullClearScreen()
        {
            graphics.clearPicture();
        }

        //рекурсия для стирания линий
        private void drawEdgesFromClearScreen(binaryTree.node v)
        {
            if (v == null) return;
            if (v.leftSon != null)
            {
                graphics.drawEdge(v, v.leftSon, new Pen(Color.White, 2));
                drawEdgesFromDrawTree(v.leftSon);
            }
            if (v.rightSon != null)
            {
                graphics.drawEdge(v, v.rightSon, new Pen(Color.White, 2));
                //graphics.drawEdge(
                //    v.x,
                //    v.y,
                //    v.rightSon.x,
                //    v.rightSon.y,
                //    v.value,
                //    v.rightSon.value
                //    );
                drawEdgesFromDrawTree(v.rightSon);
            }
        }

        //рекурсия для рисования линий
        private void drawEdgesFromDrawTree(binaryTree.node v)
        {
            if (v == null) return;
            if (v.leftSon != null)
            {
                graphics.drawEdge(
                   v.x,
                   v.y,
                   v.leftSon.x,
                   v.leftSon.y,
                   v.value,
                   v.leftSon.value
                   );
                drawEdgesFromDrawTree(v.leftSon);
            }
            if (v.rightSon != null)
            {
                graphics.drawEdge(
                    v.x, 
                    v.y,
                    v.rightSon.x,
                    v.rightSon.y,
                    v.value,
                    v.rightSon.value
                    );
                drawEdgesFromDrawTree(v.rightSon);
            }
        }

        public void drawTree()
        {
            var temp = avlTree.getListTree();

            for (int i = 0; i < temp.Count; ++i)
            {
                graphics.drawVertex(temp[i].x, temp[i].y, temp[i].value);
            }
            if (temp.Count > 0)
                drawEdgesFromDrawTree(temp[0]);
            drawHeightVertex();
        }

        public void drawHeightVertex()
        {
            var mas = avlTree.getListTree();
            for(int i = 0; i < mas.Count; ++i)
            {
                graphics.drawHeight(mas[i]);
            }
        }
    }
}
