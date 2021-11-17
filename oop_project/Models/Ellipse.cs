using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class Ellipse : Circle
    {
        public double Size2 { get; private set; }

        public Ellipse(double x, double y, double size1, double size2) :
            base(x, y, size1)
        {
            this.Size2 = size2;
        }

        public Ellipse() :
            base()
        {
            this.Size2 = (double)r.Next(0, 300);
        }

        public override void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawEllipse(pen, (float)X, (float)Y, (float)Size, (float)Size2);
            pictureBox.Image = bitmap;
        }

        public void ChangeSemiAxis()
        {
            Draw(Color.White);
            double temp = Size;
            Size = Size2;
            Size2 = temp;
            Draw(Color.LightGreen);
        }

        public override string ToString()
        {
            return "Эллипс";
        }
    }
}
