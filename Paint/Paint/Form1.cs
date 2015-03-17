using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        SolidBrush brush;
        bool drawSquare, fillSquare, drawRectangle, fillRectangle, drawCicle, fillCicle;
        ColorDialog co = new ColorDialog();
        int ? prevX = null;
        int ? prevY = null;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            SizeCB.Text = 1.ToString();
            SizeTB.Text = 50.ToString();
            toolStripStatusPenColor.Text = "\t\t\tPen Color \t\t";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            prevX = null;
            prevY = null;
            if (drawSquare)
            {
                p = new Pen(co.Color, float.Parse(SizeCB.Text));
                if (SizeTB.Text!="")
                {
                    g.DrawRectangle(p, e.X, e.Y, Convert.ToInt32(SizeTB.Text), Convert.ToInt32(SizeTB.Text));
                    drawSquare = false;   
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
            }
            else if (fillSquare)
            {
                brush = new SolidBrush(co.Color);
                if (SizeTB.Text != "")
                {
                    g.FillRectangle(brush, e.X, e.Y, Convert.ToInt32(SizeTB.Text), Convert.ToInt32(SizeTB.Text));
                    fillSquare = false;
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
                
            }
            else if (drawRectangle )
            {
                p = new Pen(co.Color, float.Parse(SizeCB.Text));
                if (SizeTB.Text!="")
                {
                    g.DrawRectangle(p, e.X, e.Y, Convert.ToInt32(SizeTB.Text)*2, Convert.ToInt32(SizeTB.Text));
                    drawRectangle = false;   
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
            }
            else if (fillRectangle)
            {
                brush = new SolidBrush(co.Color);
                if (SizeTB.Text != "")
                {
                    g.FillRectangle(brush, e.X, e.Y, Convert.ToInt32(SizeTB.Text)*2, Convert.ToInt32(SizeTB.Text));
                    fillRectangle = false;
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
            }
            else if (drawCicle)
            {
                p=new Pen(co.Color, float.Parse(SizeCB.Text));
                if (SizeTB.Text != "")
                {
                    g.DrawEllipse(p, e.X, e.Y, Convert.ToInt32(SizeTB.Text), Convert.ToInt32(SizeTB.Text));
                    drawCicle = false;
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
            }
            else if (fillCicle)
            {
                brush = new SolidBrush(co.Color);
                if (SizeTB.Text != "")
                {
                    g.FillEllipse(brush, e.X, e.Y, Convert.ToInt32(SizeTB.Text), Convert.ToInt32(SizeTB.Text));
                    fillCicle = false;
                }
                else
                {
                    MessageBox.Show("Check the Shaps Size ..");
                }
            }

        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MouseHover.Text = "Col : " + e.Y + "   Row : " + e.X;
            if (e.Button!=MouseButtons.Left)
                return;
            if (SizeCB.Text!="")
            {
                p = new Pen(co.Color, float.Parse(SizeCB.Text));
                g.DrawLine(p, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                prevX = e.X;
                prevY = e.Y;
            }
            else
            {
                MessageBox.Show("check for pen size first .. ");
            }
            
        }

        private void ColorBT_Click(object sender, EventArgs e)
        {
            if (co.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusPenColor.ForeColor = co.Color;
            }
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (co.ShowDialog()==DialogResult.OK)
            {
                panel1.BackColor = co.Color;
                toolStripStatusBgColor.ForeColor = co.Color;
            }
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        private void fillSquareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillSquare = true;
        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void drawRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void fillRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillRectangle = true;
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] pathing = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string  path in pathing)
            {
                g.DrawImage(Image.FromFile(path), new Point(0, 0));
            }
        }

        private void drawCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCicle = true;
        }

        private void fillCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fillCicle = true;
        }

    }
}
