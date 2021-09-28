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
            this.point.X = x;
            this.point.Y = y;
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
                this.point.X = value;
                this.point.Y = (double)new Random().Next(20, 500);
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {
                this.point.X = (double)new Random().Next(20, 500);
                this.point.Y = value;
                this.Size = (double)new Random().Next(20, 300);
            }
        }

        public Circle()
        {
            this.point.X = (double)r.Next(20, 400);
            this.point.Y = (double)r.Next(20, 400);
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

            this.X += dx;
            this.Y += dy;

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
