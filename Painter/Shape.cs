using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Painter
{
    class Shape
    {
        protected Color ShapeColor;

        public Shape(Color ShapeColor)
        {
            this.ShapeColor = ShapeColor;
        }

        public virtual void Show(Graphics g)
        {
        }
    }

    class Rectangle : Shape
    {
        protected Point LeftTop;
        protected Point RightBottom;

        public Rectangle(Point LeftTop, Point RightBottom, Color ShapeColor) : base(ShapeColor)
        {
            this.LeftTop = LeftTop;
            this.RightBottom = RightBottom;
        }

        public override void Show(Graphics g)
        {
            g.FillRectangle(new SolidBrush(ShapeColor),
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);

            g.DrawRectangle(Pens.Black,
                LeftTop.X, LeftTop.Y,
                RightBottom.X - LeftTop.X,
                RightBottom.Y - LeftTop.Y);
        }
    }

    class Circle : Shape
    {
        private Point LeftTop;
        private Point RightBottom;

        public Circle(Point LeftTop, Point RightBottom, Color ShapeColor) : base(ShapeColor)
        {
            this.LeftTop = LeftTop;
            this.RightBottom = RightBottom;
        }

        public override void Show(Graphics g)
        {
            g.FillEllipse(new SolidBrush(ShapeColor), LeftTop.X, LeftTop.Y, RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
            g.DrawEllipse(Pens.Coral, LeftTop.X, LeftTop.Y, RightBottom.X - LeftTop.X, RightBottom.Y - LeftTop.Y);
        }
    }

    class Triangle : Shape
    {
        private Point[] points = new Point[3];

        public Triangle(Point pt1, Point pt2, Point pt3, Color ShapeColor) : base(ShapeColor)
        {
            points[0] = pt1;
            points[1] = pt2;
            points[2] = pt3;
        }

        public override void Show(Graphics g)
        {
            g.FillPolygon(new SolidBrush(ShapeColor), points);
            g.DrawPolygon(Pens.Black, points);
        }

    }
}