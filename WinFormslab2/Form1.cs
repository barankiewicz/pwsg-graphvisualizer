using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormslab2
{
    public partial class Form1 : Form
    {
        int r;
        float wid;
        Graph graph;
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
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            r = 15;
            wid = 3.5f;
            graph = new Graph(r, wid);
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
            {
                colorShower.BackColor = colorDialog1.Color;

                Vertex v = graph.GetSelected();
                if (v != null)
                {
                    v.SetColor(colorDialog1.Color);
                    mainWind.Refresh();
                    graph.DrawGraph(g);
                }
            }
        }

        private void mainWind_MouseDown(object sender, MouseEventArgs e)
        {
            var loc = e.Location;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    graph.AddVertex(e.Location, colorShower.BackColor, g);
                    break;
                case MouseButtons.Right:
                    var v = graph.ClickedOn(loc);
                    if(v!=null)
                    {
                        graph.SetSelected(v);
                        mainWind.Refresh();
                        graph.DrawGraph(g);
                    }
                    break;
                case MouseButtons.Middle:
                    break;
            }
        }

        private void deleteGraphButton_Click(object sender, EventArgs e)
        {
            mainWind.Refresh();
            graph = new Graph(r, wid);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
                Graph.WriteToFile(graph, saveFileDialog.FileName);
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    graph = Graph.ReadFromFile(openFileDialog.FileName);
                }
                catch (SerializationException)
                {
                    MessageBox.Show("Uszkodzony plik .graph!", "Uszkodzony plik.graph!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
            mainWind.Refresh();
            graph.DrawGraph(g);
        }
    }
}
