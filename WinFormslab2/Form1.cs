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
        Graph graph = new Graph(15, 3.5f);
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuPanel.Width = (int)(this.Width * 0.2);
            pictureContainer.Width = (int)(this.Width * 0.8);
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            mainWind.Width = area.Width;
            mainWind.Height = area.Height;
            colorShower.BackColor = Color.Black;
            g = mainWind.CreateGraphics();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            menuPanel.Width = (int)(this.Width * 0.2);
            mainWind.Width = (int)(this.Width * 0.8);

            mainWind.Refresh();
            graph.DrawGraph(g);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
                colorShower.BackColor = colorDialog1.Color;
        }

        private void mainWind_MouseDown(object sender, MouseEventArgs e)
        {
            //CREATE A VERTEX
            var loc = e.Location;
            //foreach (Point location in locations)
            //{
            //    int x = location.X;
            //    int y = location.Y;
            //    if (Math.Abs(loc.X - x) < 60 && Math.Abs(loc.Y - y) < 60)
            //        return;
            //}
            graph.AddVertex(e.Location, colorShower.BackColor, g);
        }

        private void deleteGraphButton_Click(object sender, EventArgs e)
        {
            mainWind.Refresh();
            graph = new Graph(15, 3.5f);
        }
    }
}
