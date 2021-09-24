using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_project
{
    public class Circle
    {
        Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Size { get; set; }

        public Circle(double x, double y, double size)
        {
            this.X = x;
            this.Y = y;
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
                this.X = value;
                this.Y = (double)new Random().Next(20, 500);
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {
                this.X = (double)new Random().Next(20, 500);
                this.Y = value;
                this.Size = (double)new Random().Next(20, 300);
            }
        }

        public Circle()
        {
            this.X = (double)r.Next(20, 400);
            this.Y = (double)r.Next(20, 400);
            this.Size = (double)r.Next(30, 150);
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.LightGreen, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.White, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;

            this.X += dx;
            this.Y += dy;

            gr.DrawEllipse(Pens.LightGreen, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Delete()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.White, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }
    }
}
