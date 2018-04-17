using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WinFormslab2
{
    [Serializable]
    class Vertex
    {
        private Color color;
        private Point locc;
        private int pro;
        private float wid;

        public int r { get { return pro; } }
        public Point location { get { return locc; }}

        public Vertex(Point _loc, int _r, Color _col, float _wid)
        {
            color = _col;
            locc = _loc;
            pro = _r;
            wid = _wid;
        }

        public Vertex()
        {
            color = Color.Black;
            locc = new Point(0, 0);
            pro = 30;
            wid = 3.5f;
        }

        public void Draw(Graphics g, string s, bool selected)
        {
            g.FillEllipse(new SolidBrush(Color.White), new Rectangle(location, new Size(2 * r, 2 * r)));
            var temp = new Pen(color, wid);
            temp.DashPattern = new float[] { 1, 1.2f };
            if (selected)
                g.DrawEllipse(temp, new Rectangle(location, new Size(2 * r, 2 * r)));
            else
                g.DrawEllipse(new Pen(color, wid), new Rectangle(location, new Size(2 * r, 2 * r)));

            PointF stringLocation = new PointF(location.X + r, location.Y + r);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(s, new Font("Arial", 10), new SolidBrush(color), stringLocation, sf);
        }

        public Point GetLocation()
        {
            var newLoc = location;
            newLoc.Offset(r, r);
            return newLoc;
        }

        public void SetLocation(Point loc)
        {
            loc.Offset(r, r);
            locc = loc;
        }

        public void SetColor(Color _color)
        {
            color = _color;
        }
    }

    [Serializable]
    class Edge
    {
        private Vertex v1, v2;

        public Vertex from { get { return v1; } }
        public Vertex to { get { return v2; } }

        public Edge(Vertex _from, Vertex _to)
        {
            v1 = _from;
            v2 = _to;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black, 3.5f), from.GetLocation(), to.GetLocation());
        }
    }

    [Serializable]
    class Graph
    {
        private List<Vertex> vertices;
        private List<Edge> edges;
        private int r;
        private float wid;
        private Vertex selected;

        public Graph(int _r, float _wid)
        {
            vertices = new List<Vertex>();
            edges = new List<Edge>();
            r = _r;
            wid = _wid;
            selected = null;
        }

        public Vertex ClickedOn(Point click)
        {
            foreach (Vertex v in vertices)
            {
                Point neighLoc = v.GetLocation();
                int x = neighLoc.X;
                int y = neighLoc.Y;
                if (Math.Abs(click.X - x) < 2 * r && Math.Abs(click.Y - y) < 2 * r)
                    return v;
            }
            return null;
        }

        public Point GetCenter(Point p)
        {
            return new Point(p.X - 2*r, p.Y - 2*r);
        }

        public void SetSelected(Vertex v)
        {
            selected = v;
        }

        public Vertex GetSelected()
        {
            return selected;
        }

        public void AddVertex(Point loc, Color col, PictureBox p)
        {
            if (ClickedOn(loc) != null)
                return;

            Point circleLocation = new Point(loc.X - r, loc.Y - r);
            vertices.Add(new Vertex(circleLocation, r, col, wid));
        }

        public void DeleteVertex(Vertex v)
        {
            List<Edge> temp = new List<Edge>();
            for (int i = 0; i < edges.Count; i++)
                if (edges[i].from == v || edges[i].to == v)
                    temp.Add(edges[i]);

            foreach (Edge e in temp)
                edges.Remove(e);

            vertices.Remove(v);
        }

        public void DrawVertex(Vertex v, PictureBox p)
        {
            //Graphics g = Graphics.FromImage(p.Image);

            //for (int i = 0; i < vertices.Count; i++)
            //    if(vertices[i] == v)
            //        v.Draw(g, (i + 1).ToString(), v == selected);
        }

        public void DrawGraph(PictureBox p)
        {
            Bitmap bmp = new Bitmap(p.Width, p.Width);
            Graphics g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Edge e in edges)
                e.Draw(g);

            for (int i = 0; i < vertices.Count; i++)
            {
                if(selected != null && vertices[i] == selected) //If selected, we want to draw it differently
                {
                    vertices[i].Draw(g, (i + 1).ToString(), true);
                    continue;
                }
                vertices[i].Draw(g, (i + 1).ToString(), false);
            }

            if(p.Image != null)
                p.Image.Dispose();

            g.Dispose(); 

             p.Image = (Image)bmp;
        }

        public bool ExistEdge(Vertex v1, Vertex v2)
        {
            foreach (Edge e in edges)
                if ((e.from == v1 && e.to == v2) || (e.from == v2 && e.to == v1))
                    return true;
            return false;
        }

        public bool AddEdge(Vertex v1, Vertex v2, Graphics g)
        {
            if (v1 == null || v2 == null)
                return false;

            for(int i = 0; i < edges.Count; i++)
            {
                if ((edges[i].from == v1 && edges[i].to == v2) || (edges[i].from == v2 && edges[i].to == v1))
                {
                    edges.Remove(edges[i]);
                    return false;
                }    
            }
            edges.Add(new Edge(v1, v2));
            //edges.Last().Draw(g);
            return true;
        }

        public static void WriteToFile(Graph graph, string path)
        {
            graph.SetSelected(null);
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, graph);
            fs.Close();
        }

        public static Graph ReadFromFile(string path)
        {
            var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Graph obj = (Graph)bf.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}
