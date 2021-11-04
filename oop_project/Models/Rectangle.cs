using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class MyRectangle : Square
    {
        public double Size2 { get; private set; }

        public MyRectangle(MyPoint point, double size1, double size2) :
            base(point, size1)
        {
            this.Size2 = size2;
        }

        public MyRectangle(double x, double y, double size1, double size2) :
            base(x, y, size1)
        {
            this.Size2 = size2;
        }

        public MyRectangle() :
            base()
        {
            this.Size2 = (double)r.Next(0, 300);
        }

        public override void Draw()
        {
            Draw(Color.LightGreen);
        }

        public override void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawRectangle(pen, (float)point.X, (float)point.Y, (float)Size, (float)Size2);
            pictureBox.Image = bitmap;
        }

        public override string ToString()
        {
            return "Прямоугольник";
        }
    }
}
