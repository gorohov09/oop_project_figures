using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_project
{
    public class Line
    {
        Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public double X1 { get; private set; }

        public double Y1 { get; private set; }

        public double X2 { get; private set; }

        public double Y2 { get; private set; }

        public Line(double x1, double y1, double x2, double y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }

        public Line()
        {
            this.X1 = (double)r.Next(-500, 500);
            this.Y1 = (double)r.Next(-500, 500);
            this.X2 = (double)r.Next(-500, 500);
            this.Y2 = (double)r.Next(-500, 500);
        }

        public void Draw()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.LightGreen, (float)X1, (float)Y1, (float)X2, (float)Y2);
            pictureBox.Image = bitmap;
        }

        public void Move(double dx, double dy)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.White, (float)X1, (float)Y1, (float)X2, (float)Y2);
            pictureBox.Image = bitmap;
            this.X1 += dx;
            this.Y1 += dy;
            this.X2 += dx;
            this.Y2 += dy;

            gr.DrawLine(Pens.LightGreen, (float)X1, (float)Y1, (float)X2, (float)Y2);
            pictureBox.Image = bitmap;
        }

        public void Delete()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            gr.DrawLine(Pens.White, (float)X1, (float)Y1, (float)X2, (float)Y2);
            pictureBox.Image = bitmap;
        }
    }
}
