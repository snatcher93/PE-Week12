using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Painter
{
    enum Shapes { RECTANGLE, TRIANGLE, CIRCLE }
 
    public partial class Form1 : Form
    {
        private bool Drawing = false;
        private Point Start;
        private Point End;
        private Shapes Shape = Shapes.RECTANGLE;
        private Color ShapeColor = Color.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = !Drawing;
            if (Drawing)
            {
                Start = End = e.Location;
                ControlPaint.DrawReversibleFrame(new System.Drawing.Rectangle(PointToScreen(Start), new Size(End.X - Start.X, End.Y - Start.Y)), Color.Gray, FrameStyle.Dashed);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    ControlPaint.DrawReversibleFrame(new System.Drawing.Rectangle(PointToScreen(Start), new Size(End.X - Start.X, End.Y - Start.Y)), Color.Gray, FrameStyle.Dashed);
                    End = e.Location;
                    ControlPaint.DrawReversibleFrame(new System.Drawing.Rectangle(PointToScreen(Start), new Size(End.X - Start.X, End.Y - Start.Y)), Color.Gray, FrameStyle.Dashed);
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Drawing)
            {
                using (Graphics g = CreateGraphics())
                {
                    ControlPaint.DrawReversibleFrame(new System.Drawing.Rectangle(PointToScreen(Start), new Size(End.X - Start.X, End.Y - Start.Y)), Color.Gray, FrameStyle.Dashed);
                    End = e.Location;

                    switch (Shape)
                    {
                        case Shapes.RECTANGLE:
                            g.FillRectangle(new SolidBrush(ShapeColor), Start.X, Start.Y, e.Location.X - Start.X, e.Location.Y - Start.Y);
                            g.DrawRectangle(Pens.White, Start.X, Start.Y, e.Location.X - Start.X, e.Location.Y - Start.Y);
                            break;
                        case Shapes.TRIANGLE:
                            Point [] points = new Point [] {new Point(Start.X + (End.X - Start.X)/2, Start.Y), new Point(Start.X, End.Y), End};
                            g.FillPolygon(new SolidBrush(ShapeColor), points);
                            g.DrawPolygon(Pens.Black, points);
                            break;
                        case Shapes.CIRCLE:
                            g.FillEllipse(new SolidBrush(ShapeColor), Start.X, Start.Y, e.Location.X - Start.X, e.Location.Y - Start.Y);
                            g.DrawEllipse(Pens.Coral, Start.X, Start.Y, e.Location.X - Start.X, e.Location.Y - Start.Y);
                            break;
                    }
                }

                Drawing = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Shape = Shapes.RECTANGLE;
            RectangleTool.Checked = true;
            CircleTool.Checked = false;
            TriangleTool.Checked = false;
        }

        private void TriangleTool_Click(object sender, EventArgs e)
        {
            Shape = Shapes.TRIANGLE;
            RectangleTool.Checked = false;
            CircleTool.Checked = false;
            TriangleTool.Checked = true;
        }

        private void CircleTool_Click(object sender, EventArgs e)
        {
            Shape = Shapes.CIRCLE;
            RectangleTool.Checked = false;
            CircleTool.Checked = true;
            TriangleTool.Checked = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ShapeColor = dialog.Color;
            }
        }
    }
}
