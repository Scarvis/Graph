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
                fo = new Font("Arial", 15);
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
                gr.DrawString(Convert.ToString(lastVertex), fo, br, point);
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
                drawVertex(x1, y1, indexv1 + 1);
                drawVertex(x2, y2, indexv2 + 1);
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

                int heightLeftSon = 0, heightRightSon = 0;
                public node leftSon, rightSon, parent;

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
                    return Math.Abs(heightLeftSon - heightRightSon) <= 1;
                }

                public int getHeightLeftSon()
                {
                    return heightLeftSon;
                }

                public int getHeightRightSon()
                {
                    return heightRightSon;
                }

                public bool isError()
                {
                    return x == y && y  == value && value == -777;
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
            List<node> avlTree = new List<node>();
            node errorWithFind = new node(-777, -777, -777);
            node root;

            public binaryTree()
            {
                root = errorWithFind;
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

            public node find(int value, node finder = null, node parent = null)
            {
                int v = 0;
                if (finder.value == -1 && finder != null)
                {
                    int u = parent.index;
                    int x = avlTree[u].x;
                    int y = avlTree[u].y;
                    if (x <= root.x)
                    {
                        x /= 2;
                        y += 10;
                    }
                    else
                    {
                        x += x / 2;
                        y += 10;
                    }
                    finder.value = value;
                    finder.x = x;
                    finder.y = y;
                    finder.parent = parent;
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
                if (finder != null) v = finder.index;
                if (value > avlTree[v].value)
                {
                    avlTree[v].incrementHeightRightSon();
                    if (finder != null)
                        return find(
                            value
                            ,avlTree[v].getRightSon()
                            ,root
                            );
                    else
                        return find(
                            value
                            , avlTree[v].getRightSon()
                            , finder
                            );
                }
                else if (value < avlTree[v].value)
                {
                    avlTree[v].incrementHeightLeftSon();
                    if (finder != null)
                    {
                        return find(
                            value,
                            avlTree[v].getLeftSon()
                            , root
                            );
                    }
                    else
                    {
                        return find(
                            value,
                            avlTree[v].getLeftSon()
                            , finder
                            );
                    }
                }
                else
                {
                    return errorWithFind;
                }
            }

            public bool addNode(int value)
            {
                if (root == errorWithFind)
                {
                    root.x = height / 2;
                    root.y = 10;
                    root.value = value;
                    root.index = 0;
                    avlTree.Add(root);
                    return true;
                }
                node flag = find(value);

                if (flag == errorWithFind)
                {
                    return false;
                }

                avlTree.Add(flag);
                Count++;
                return true;
            }

            public List<node> getListTree()
            {
                return avlTree;
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
            return avlTree.addNode(value);
        }

        public void drawTree()
        {
            var temp = avlTree.getListTree();

            for(int i = 0; i < temp.Count; ++i)
            {
                graphics.drawVertex(temp[i].x, temp[i].y, temp[i].value);
            }

        }
    }
}
