using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project.Models
{
    public class Ellipse : Circle
    {
        public double Size2 { get; private set; }

        public Ellipse(MyPoint point, double size1, double size2) :
            base(point, size1)
        {
            this.Size2 = size2;
        }

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

        public override void Draw()
        {
            base.Draw(Color.LightGreen, Size, Size2);
        }

        public void ChangeSemiAxis()
        {
            base.Draw(Color.White, Size, Size2);
            double temp = Size;
            Size = Size2;
            Size2 = temp;
            Draw();
        }

        public override void Move(double dx, double dy)
        {
            Draw(Color.White, Size, Size2);
            point.X += dx;
            point.Y += dy;
            Draw(Color.LightGreen, Size, Size2);
        }

        public override void Delete()
        {
            Draw(Color.White, Size, Size2);
        }

        public override string ToString()
        {
            return "Эллипс";
        }
    }
}
