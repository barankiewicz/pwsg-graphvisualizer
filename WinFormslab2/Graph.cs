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
        private Point location;
        private int r;
        private float wid;

        public Vertex(Point _loc, int _r, Color _col, float _wid)
        {
            color = _col;
            location = _loc;
            r = _r;
            wid = _wid;
        }

        public void Draw(Graphics g, string s, bool selected)
        {
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
            return location;
        }
    }

    [Serializable]
    class Graph
    {
        private List<Vertex> vertices;
        private int r;
        private float wid;
        private Vertex selected;

        public Graph(int _r, float _wid)
        {
            vertices = new List<Vertex>();
            r = _r;
            wid = _wid;
            selected = null;
        }

        public Vertex ClickedOn(Point click)
        {
            foreach (Vertex v in vertices)
            {
                Point neighLoc = v.GetLocation();
                int x = neighLoc.X + r;
                int y = neighLoc.Y + r;
                if (Math.Abs(click.X - x) < 2 * r && Math.Abs(click.Y - y) < 2 * r)
                    return v;
            }
            return null;
        }

        public void SetSelected(Vertex v)
        {
            selected = v;
        }

        public Vertex GetSelected()
        {
            return selected;
        }

        public void AddVertex(Point loc, Color col, Graphics g)
        {
            if (ClickedOn(loc) != null)
                return;

            Point circleLocation = new Point(loc.X - r, loc.Y - r);
            vertices.Add(new Vertex(circleLocation, r, col, wid));
            vertices.Last().Draw(g, vertices.Count.ToString(), false);
        }

        public void DrawGraph(Graphics g)
        {
            for(int i = 0; i < vertices.Count; i++)
            {
                if(selected != null && vertices[i] == selected) //If selected, we want to draw it differently
                {
                    vertices[i].Draw(g, (i + 1).ToString(), true);
                    continue;
                }
                vertices[i].Draw(g, (i + 1).ToString(), false);
            }
        }

        public static void WriteToFile(Graph graph, string path)
        {
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
