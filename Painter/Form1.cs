using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Painter
{
    enum Shapes { RECTANGLE, TRIANGLE, CIRCLE }
 
    public partial class Form1 : Form
    {
        private bool isMoving = false;                  // 마우스 이동 중인지의 여부
        private Point start;                            // 시작 위치
        private Point end;                              // 종료 위치

        private Shapes shapeType = Shapes.RECTANGLE;    // 그림의 종류
        private Color shapeColor = Color.Blue;          // 색상
        
        private ArrayList shapes = new ArrayList();     // 도형의 목록
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
            {
                shape.Show(e.Graphics);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            start = end = e.Location;
            DrawDragRange(start, end);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMoving)
            {
                return;
            }

            RedrawDragRange(e.Location);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isMoving)
            {
                return;
            }

            CreateShape(e.Location);
            Invalidate();
            isMoving = false;
        }

        private void RedrawDragRange(Point current)
        {
            EraseDragRange(start, end);
            end = current;
            DrawDragRange(start, end);
        }


        private void CreateShape(Point current)
        {
            EraseDragRange(start, end);
            end = current;
            AddShapes();
        }

        private void AddShapes()
        {
            switch (shapeType)
            {
                case Shapes.RECTANGLE:
                    shapes.Add(new Rectangle(start, end, shapeColor));
                    break;
                case Shapes.TRIANGLE:
                    shapes.Add(new Triangle(new Point(start.X + (end.X - start.X) / 2, start.Y),
                            new Point(start.X, end.Y), end, shapeColor));
                    break;
                case Shapes.CIRCLE:
                    shapes.Add(new Circle(start, end, shapeColor));
                    break;
            }

            Invalidate();
        }

        private void EraseDragRange(Point start, Point end)
        {
            DrawDragRange(start, end);
        }

        private void DrawDragRange(Point start, Point end)
        {
            ControlPaint.DrawReversibleFrame(new System.Drawing.Rectangle(PointToScreen(start), new Size(end.X - start.X, end.Y - start.Y)), Color.Gray, FrameStyle.Dashed);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            shapeType = Shapes.RECTANGLE;

            RectangleTool.Checked = true;
            CircleTool.Checked = false;
            TriangleTool.Checked = false;
        }

        private void TriangleTool_Click(object sender, EventArgs e)
        {
            shapeType = Shapes.TRIANGLE;
            
            RectangleTool.Checked = false;
            CircleTool.Checked = false;
            TriangleTool.Checked = true;
        }

        private void CircleTool_Click(object sender, EventArgs e)
        {
            shapeType = Shapes.CIRCLE;
            
            RectangleTool.Checked = false;
            CircleTool.Checked = true;
            TriangleTool.Checked = false;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                shapeColor = dialog.Color;
            }
        }
    }
}
