using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormslab2
{
    public partial class Form1 : Form
    {
        Pen mainPen = new Pen(Color.Black, 3.5f);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        int vertexCount = 1;

        List<Point> locations = new List<Point>();
        List<PointF> locationsString = new List<PointF>();
        List<Color> colors = new List<Color>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPanel.Width = (int)(this.Width * 0.2);
            mainWind.Width = (int)(this.Width * 0.8);
            colorShower.BackColor = Color.Black;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            menuPanel.Width = (int)(this.Width * 0.2);
            mainWind.Width = (int)(this.Width * 0.8);

            
            Graphics g = mainWind.CreateGraphics();
            for (int i = 0; i < locations.Count; i++)
            {
                Pen pen = new Pen(colors[i], 3.5f);
                SolidBrush brush = new SolidBrush(colors[i]);
                g.DrawEllipse(pen, new Rectangle(locations[i], new Size(40, 40)));
                g.DrawString((i+1).ToString(), new Font("Arial", 10), brush, locationsString[i]);
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorShower.BackColor = colorDialog1.Color;
                mainPen.Color = colorDialog1.Color;
                drawBrush.Color = colorDialog1.Color;
            }
        }

        private void mainWind_MouseDown(object sender, MouseEventArgs e)
        {
            //CREATE A VERTEX
            var loc = e.Location;
            foreach (Point location in locations)
            {
                int x = location.X;
                int y = location.Y;
                if (Math.Abs(loc.X - x) < 60 && Math.Abs(loc.Y - y) < 60)
                    return;
            }
            Point circleLocation = new Point(e.Location.X - 20, e.Location.Y - 20);
            PointF stringLocation = new PointF(e.Location.X - 5, e.Location.Y - 6);
            locations.Add(circleLocation);
            locationsString.Add(stringLocation);
            colors.Add(drawBrush.Color);
            Graphics g = mainWind.CreateGraphics();

            g.DrawEllipse(mainPen, new Rectangle(circleLocation, new Size(40,40)));
            g.DrawString(vertexCount.ToString(), new Font("Arial", 10), drawBrush, stringLocation);
            vertexCount++;
        }

        private void mainWind_Click(object sender, EventArgs e)
        {

        }

        private void mainWind_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
