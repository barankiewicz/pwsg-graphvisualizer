using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
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
        bool isMiddleClicked;
        bool isLeft;
        Vertex middleClicked;
        Point curClick;
        Stopwatch st;
        string errorMessage;

        string graphLoaded = "";
        string graphLoadFailed = "";
        string graphSaved = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            isLeft = false;
            st = new Stopwatch();
            SetStyle(ControlStyles.DoubleBuffer, true);
            isMiddleClicked = false;
            curClick = new Point(0,0);
            this.KeyPreview = true;
            deleteVertexButton.Enabled = false;
            middleClicked = null;
            menuPanel.Width = (int)(this.Width * 0.2);
            pictureContainer.Width = (int)(this.Width * 0.8);
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;
            mainWind.Width = area.Width;
            mainWind.Height = area.Height;
            colorShower.BackColor = Color.Black;
            g = mainWind.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            CultureInfo pl = new CultureInfo("pl-PL");
            Assembly a = Assembly.Load("WinFormsLab2");
            ResourceManager rm = new ResourceManager("WinFormsLab2.Lang.pl", a);
            this.Text = rm.GetString("mainText");
            colorButton.Text = rm.GetString("colorBtn");
            deleteGraphButton.Text = rm.GetString("delGr");
            deleteVertexButton.Text = rm.GetString("delVer");
            saveButton.Text = rm.GetString("fileExp");
            importButton.Text = rm.GetString("fileImp");
            editBox.Text = rm.GetString("menuEdit");
            langBox.Text = rm.GetString("menuLang");
            saveBox.Text = rm.GetString("menuFile");
            errorMessage = rm.GetString("errMessage");

            r = 15;
            wid = 3.5f;
            graph = new Graph(r, wid);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            menuPanel.Width = (int)(this.Width * 0.2);
            pictureContainer.Width = (int)(this.Width * 0.8);
            
            graph.DrawGraph(mainWind);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorShower.BackColor = colorDialog1.Color;

                Vertex v = graph.GetSelected();
                if (v != null)
                {
                    v.SetColor(colorDialog1.Color);
                    graph.DrawGraph(mainWind);
                }
            }
        }

        private void mainWind_MouseDown(object sender, MouseEventArgs e)
        {
            var loc = e.Location;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (graph.ClickedOn(loc) == null)
                    {
                        graph.AddVertex(e.Location, colorShower.BackColor, mainWind);
                        graph.DrawGraph(mainWind);
                    }
                        
                    else
                    {
                        Vertex clicked = graph.ClickedOn(loc);
                        bool fl = graph.AddEdge(clicked, graph.GetSelected(), g);

                        graph.DrawGraph(mainWind);
                    }

                    break;
                case MouseButtons.Right:
                    var v = graph.ClickedOn(loc);

                    if (v != null)
                    {
                        deleteVertexButton.Enabled = true;
                        graph.SetSelected(v);
                    }
                    else
                    {
                        deleteVertexButton.Enabled = false;
                        graph.SetSelected(null);
                    }

                    graph.DrawGraph(mainWind);
                    break;
                case MouseButtons.Middle:
                    Vertex ver = graph.GetSelected();
                    if (ver != null)
                    {
                        curClick = loc;
                        middleClicked = ver;
                        isMiddleClicked = true;
                        st.Start();
                    }
                    break;
            }
        }

        private void mainWind_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Middle && middleClicked != null)
            {
                isMiddleClicked = false;
                curClick = new Point(0, 0);

                int picX = mainWind.Width;
                int contX = (int)(this.Width * 0.8);
                int picY = mainWind.Height;
                int contY = this.Height;
                
                var toSet = new Point(middleClicked.location.X, middleClicked.location.Y);
                if (toSet.X < 0)
                    toSet.X = 0;
                else if (toSet.X > contX)
                    toSet.X = contX - 4*r;

                if (toSet.Y < 0)
                    toSet.Y = 0;
                else if (toSet.Y > contY)
                    toSet.Y = contY - 6*r;

                middleClicked.location = toSet;
                graph.DrawGraph(mainWind);
                st.Reset();
            }
        }

        private void deleteGraphButton_Click(object sender, EventArgs e)
        {
            graph = new Graph(r, wid);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
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
                    MessageBox.Show(errorMessage, errorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            graph.DrawGraph(mainWind);
        }

        private void deleteVertexButton_Click(object sender, EventArgs e)
        {
            if (graph.GetSelected() != null)
            {
                graph.DeleteVertex(graph.GetSelected());
                graph.SetSelected(null);
                deleteVertexButton.Enabled = false;

                graph.DrawGraph(mainWind);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && graph.GetSelected() != null)
            {
                graph.DeleteVertex(graph.GetSelected());
                graph.SetSelected(null);
                deleteVertexButton.Enabled = false;

                graph.DrawGraph(mainWind);
            }
        }

        private void mainWind_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (middleClicked == null)
                    return;
                if(st.ElapsedMilliseconds >= 10)
                {
                    Point offset = new Point(e.Location.X - curClick.X, e.Location.Y - curClick.Y);
                    Point p = middleClicked.location;
                    p.Offset(offset);

                    middleClicked.location = p;
                    curClick = e.Location;

                    graph.DrawGraph(mainWind);
                    st.Restart();
                }
            }
        }

        //Localisation helper functions

        private void plLangButton_Click(object sender, EventArgs e)
        {
            CultureInfo pl = new CultureInfo("pl-PL");
            Assembly a = Assembly.Load("WinFormsLab2");
            ResourceManager rm = new ResourceManager("WinFormsLab2.Lang.pl", a);
            this.Text = rm.GetString("mainText");
            colorButton.Text = rm.GetString("colorBtn");
            deleteGraphButton.Text = rm.GetString("delGr");
            deleteVertexButton.Text = rm.GetString("delVer");
            saveButton.Text = rm.GetString("fileExp");
            importButton.Text = rm.GetString("fileImp");
            editBox.Text = rm.GetString("menuEdit");
            langBox.Text = rm.GetString("menuLang");
            saveBox.Text = rm.GetString("menuFile");
            errorMessage = rm.GetString("errMessage");
        }

        private void engLangButton_Click(object sender, EventArgs e)
        {
            CultureInfo pl = new CultureInfo("en-EN");
            Assembly a = Assembly.Load("WinFormsLab2");
            ResourceManager rm = new ResourceManager("WinFormsLab2.Lang.en", a);
            this.Text = rm.GetString("mainText");
            colorButton.Text = rm.GetString("colorBtn");
            deleteGraphButton.Text = rm.GetString("delGr");
            deleteVertexButton.Text = rm.GetString("delVer");
            saveButton.Text = rm.GetString("fileExp");
            importButton.Text = rm.GetString("fileImp");
            editBox.Text = rm.GetString("menuEdit");
            langBox.Text = rm.GetString("menuLang");
            saveBox.Text = rm.GetString("menuFile");
            errorMessage = rm.GetString("errMessage");
        }
    }
}
