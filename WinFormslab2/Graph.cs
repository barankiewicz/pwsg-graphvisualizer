using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormslab2
{
    class Vertex
    {
        private Color color;
        private Point location;
        private int r;
        Pen mainPen;
        SolidBrush drawBrush;

        public Vertex(Point _loc, int _r, Color _col, float _wid)
        {
            color = _col;
            location = _loc;
            r = _r;
            mainPen = new Pen(_col, _wid);
            drawBrush = new SolidBrush(_col);
        }

        public void Draw(Graphics g, string s)
        {
            g.DrawEllipse(mainPen, new Rectangle(location, new Size(2*r, 2*r)));
            PointF stringLocation = new PointF(location.X - r, location.Y - r);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(s, new Font("Arial", 10), drawBrush, stringLocation, sf);
        }
    }
    class Graph
    {
        private List<Vertex> vertices;
        private int r;
        private float wid;

        public Graph(int _r, float _wid)
        {
            vertices = new List<Vertex>();
            r = _r;
            wid = _wid;
        }

        public void AddVertex(Point loc, Color col, Graphics g)
        {
            Point circleLocation = new Point(loc.X - r, loc.Y - r);
            vertices.Add(new Vertex(circleLocation, r, col, wid));
            vertices.Last().Draw(g, vertices.Count.ToString());
        }

        public void DrawGraph(Graphics g)
        {
            for(int i = 0; i < vertices.Count; i++)
            {
                vertices[i].Draw(g, (i + 1).ToString());
            }
        }
    }
}
