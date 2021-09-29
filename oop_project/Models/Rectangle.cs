using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Rectangle
    {
        Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public MyPoint point { get; private set; }

        public double Size { get; set; }

        public Rectangle(MyPoint point, double size)
        {
            this.point = point;
            this.Size = size;
        }

        public Rectangle(double x, double y, double size)
        {
            point = new MyPoint(x, y);
            this.Size = size;
        }

        public Rectangle(double x, double y) :
            this(x, y, (double)new Random().Next(20, 200))
        {
        }

        public Rectangle(double value, bool isValue)
        {
            if (isValue == true)
            {
                point = new MyPoint(value, (double)new Random().Next(20, 500));
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {
                point = new MyPoint((double)new Random().Next(20, 500), value);
                this.Size = (double)r.Next(20, 300);
            }
        }

        public Rectangle()
        {
            point = new MyPoint((double)r.Next(20, 400), (double)r.Next(20, 400));
            this.Size = (double)r.Next(30, 150);
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawRectangle(Pens.LightGreen, (float)point.X, (float)point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawRectangle(pen, (float)point.X, (float)point.Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Draw(Color.White);
            this.point.X += dx;
            this.point.Y += dy;
            Draw(Color.LightGreen);
        }

        public void Change()
        {
            Draw(Color.White);
            this.Size += r.Next(-50, 50);
            Draw(Color.LightGreen);
        }

        public void Delete()
        {
            Draw(Color.White);
        }

    }
}
