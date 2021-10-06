using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class Ring
    {
        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public Circle circle1 { get; private set; }

        public Circle circle2 { get; private set; }

        public Ring(Circle circle1, Circle circle2)
        {
            this.circle1 = circle1;
            this.circle2 = circle2;
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.LightGreen, (float)this.circle1.point.X, (float)this.circle1.point.Y, (float)this.circle1.Size, (float)this.circle1.Size);
            gr.DrawEllipse(Pens.LightGreen, (float)this.circle2.point.X, (float)this.circle2.point.Y, (float)this.circle2.Size, (float)this.circle2.Size);
            pictureBox.Image = bitmap;
        }

        public void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawEllipse(pen, (float)this.circle1.point.X, (float)this.circle1.point.Y, (float)this.circle1.Size, (float)this.circle1.Size);
            gr.DrawEllipse(pen, (float)this.circle2.point.X, (float)this.circle2.point.Y, (float)this.circle2.Size, (float)this.circle2.Size);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Draw(Color.White);

            this.circle1.point.X += dx;
            this.circle1.point.Y += dy;

            this.circle2.point.X += dx;
            this.circle2.point.Y += dy;

            Draw(Color.LightGreen);
        }

        public void Delete()
        {
            Draw(Color.White);
        }

        public override string ToString()
        {
            return "Кольцо";
        }
    }
}
