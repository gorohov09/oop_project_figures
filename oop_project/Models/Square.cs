using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Square : TFigure
    {
        public Square(MyPoint point, double size) :
            base(point, size)
        {
        }

        public Square(double x, double y, double size) :
            base(x, y, size)
        {
        }

        public Square(double x, double y) :
            this(x, y, (double)new Random().Next(20, 200))
        {
        }

        public Square(double value, bool isValue) :
            base(value, isValue)
        {
        }

        public Square() :
            base()
        {
        }

        public override void Draw()
        {
            Draw(Color.LightGreen, Size, Size);
        }

        protected void Draw(Color color, double size1, double size2)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawRectangle(pen, (float)point.X, (float)point.Y, (float)size1, (float)size2);
            pictureBox.Image = bitmap;
        }

        public override void Move(double dx, double dy)
        {
            Draw(Color.White, Size, Size);
            this.point.X += dx;
            this.point.Y += dy;
            Draw(Color.LightGreen, Size, Size);
        }

        public void Change()
        {
            Draw(Color.White, Size, Size);
            this.Size += r.Next(-50, 50);
            Draw(Color.LightGreen, Size, Size);
        }

        public override void Delete()
        {
            Draw(Color.White, Size, Size);
        }

        public override string ToString()
        {
            return "Квадрат";
        }

    }
}
