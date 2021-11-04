using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class Rhomb : Square
    {
        public double Size2 { get; private set; }

        public Rhomb(MyPoint point, double size1, double size2) :
            base(point, size1)
        {
            this.Size2 = size2;
        }

        public Rhomb(double x, double y, double size1, double size2) :
            base(x, y, size1)
        {
            this.Size2 = size2;
        }

        public Rhomb() :
            base()
        {
            this.Size2 = (double)r.Next(0, 300);
        }

        public override void Draw(Color color)
        {
            int x1 = (int)point.X;
            int y1 = (int)point.Y;

            int size1 = (int)Size;
            int size2 = (int)Size2;

            int x2 = x1 + size1 / 2;
            int y2 = y1 - size2 / 2;

            int x3 = x1 + size1;
            int y3 = y1;

            int x4 = x2;
            int y4 = y1 + size2 / 2;

            Point[] points = new Point[4];
            points[0] = new Point(x1, y1);
            points[1] = new Point(x2, y2);
            points[2] = new Point(x3, y3);
            points[3] = new Point(x4, y4);

            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawPolygon(pen, points);
            pictureBox.Image = bitmap;
        }

        public override void Draw()
        {
            Draw(Color.LightGreen);
        }

        public override string ToString()
        {
            return "Ромб";
        }
    }
}
