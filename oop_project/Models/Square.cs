﻿using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Square : TFigure
    {
        public Square(double x, double y, double size) :
            base(x, y, size)
        {
        }

        public Square(double x, double y) :
            this(x, y, (double)new Random().Next(20, 200))
        {
        }

        public Square(double value, bool isValue) :
            base(value, isValue)
        {
        }

        public Square() :
            base()
        {
        }

        public override void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawRectangle(pen, (float)X, (float)Y, (float)Size, (float)Size);
            pictureBox.Image = bitmap;
        }

        public void Change()
        {
            Draw(Color.White);
            this.Size += r.Next(-50, 50);
            Draw(Color.LightGreen);
        }

        public override string ToString()
        {
            return "Квадрат";
        }

    }
}
