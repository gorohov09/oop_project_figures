using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Circle : TFigure
    {
        public Circle(double x, double y, double size) : 
            base(x, y, size)
        {
        }

        public Circle(double x, double y) :
            base(x, y, (double)new Random().Next(20, 200))
        {
        }

        public Circle(double value, bool isValue) :
            base(value, isValue)
        {
        }

        public Circle() :
            base()
        {
        }
        
        public override void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawEllipse(pen, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public override string ToString()
        {
            return "Круг";
        }
    }
}
