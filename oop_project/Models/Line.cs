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

        public MyPoint point1 { get; private set; }

        public MyPoint point2 { get; private set; }

        public Line(double x1, double y1, double x2, double y2)
        {
            point1 = new MyPoint(x1, y1);
            point2 = new MyPoint(x2, y2);
        }

        public Line()
        {
            point1 = new MyPoint((double)r.Next(-500, 500), (double)r.Next(-500, 500));
            point2 = new MyPoint((double)r.Next(-500, 500), (double)r.Next(-500, 500));
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.LightGreen, (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.White, (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
            pictureBox.Image = bitmap;
            this.point1.X += dx;
            this.point1.Y += dy;
            this.point2.X += dx;
            this.point2.Y += dy;

            gr.DrawLine(Pens.LightGreen, (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
            pictureBox.Image = bitmap;
        }

        public void Delete()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.White, (float)point1.X, (float)point1.Y, (float)point2.X, (float)point2.Y);
            pictureBox.Image = bitmap;
        }
    }
}
