using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Circle
    {
        Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public MyPoint point { get; private set; }

        public double Size { get; set; }

        public Circle(MyPoint point, double size)
        {
            this.point = point;
            this.Size = size;
        }

        public Circle(double x, double y, double size)
        {
            point = new MyPoint(x, y);
            this.Size = size;
        }

        public Circle(double x, double y) :
            this(x, y, (double)new Random().Next(20, 200))
        {
        }

        public Circle(double value, bool isValue)
        {
            if (isValue == true)
            {
                point = new MyPoint(value, (double)new Random().Next(20, 500));
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {
                point = new MyPoint((double)new Random().Next(20, 500), value);
                this.Size = (double)new Random().Next(20, 300);
            }
        }

        public Circle()
        {
            point = new MyPoint((double)r.Next(20, 400), (double)r.Next(20, 400));
            this.Size = (double)r.Next(30, 150);
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.LightGreen, (float)this.point.X, (float)this.point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.White, (float)this.point.X, (float)this.point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;

            this.point.X += dx;
            this.point.Y += dy;

            gr.DrawEllipse(Pens.LightGreen, (float)this.point.X, (float)this.point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Delete()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.White, (float)this.point.X, (float)this.point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }
    }
}
