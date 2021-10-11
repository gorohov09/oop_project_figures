using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class MyFigure
    {
        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public Circle circle { get; private set; }

        public Square rectangle { get; private set; }

        public MyFigure(Circle circle, Square rectangle)
        {
            this.circle = circle;
            this.rectangle = rectangle;
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawEllipse(Pens.LightGreen, (float)this.circle.point.X, (float)this.circle.point.Y, (float)this.circle.Size, (float)this.circle.Size);
            gr.DrawRectangle(Pens.LightGreen, (float)this.rectangle.point.X, (float)this.rectangle.point.Y, (float)this.rectangle.Size, (float)this.rectangle.Size);
            pictureBox.Image = bitmap;
        }

        public void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawEllipse(pen, (float)this.circle.point.X, (float)this.circle.point.Y, (float)this.circle.Size, (float)this.circle.Size);
            gr.DrawRectangle(pen, (float)this.rectangle.point.X, (float)this.rectangle.point.Y, (float)this.rectangle.Size, (float)this.rectangle.Size);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Draw(Color.White);

            this.circle.point.X += dx;
            this.circle.point.Y += dy;

            this.rectangle.point.X += dx;
            this.rectangle.point.Y += dy;

            Draw(Color.LightGreen);
        }

        public void Delete()
        {
            Draw(Color.White);
        }

        public override string ToString()
        {
            return "Фигура";
        }
    }
}
