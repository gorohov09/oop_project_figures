using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Line
    {
        Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public MyPoint point { get; private set; }

        public double Size { get; private set; }

        public Line(MyPoint point, double size)
        {
            this.point = point;
            this.Size = size;
        }

        public Line(double x1, double y1, double size)
        {
            point = new MyPoint(x1, y1);
            this.Size = size;
        }

        public Line()
        {
            point = new MyPoint((double)r.Next(-500, 500), (double)r.Next(-500, 500));
            this.Size = (double)r.Next(-500, 500);
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.LightGreen, (float)point.X, (float)point.Y, (float)(point.X + Size), (float)(point.Y + Size));
            pictureBox.Image = bitmap;
        }

        public void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawLine(pen, (float)point.X, (float)point.Y, (float)(point.X + Size), (float)(point.Y + Size));
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Draw(Color.White);
            this.point.X += dx;
            this.point.Y += dy;
            Draw(Color.LightGreen);
        }

        public void Delete()
        {
            Draw(Color.White);
        }

        public override string ToString()
        {
            return "Линия";
        }
    }
}
