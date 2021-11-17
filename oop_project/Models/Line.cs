﻿using System;
using System.Drawing;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public class Line : TFigure
    {
        public Line(double x1, double y1, double size) :
            base(x1, y1, size)
        {
        }

        public Line() :
            base()
        {
        }

        public override void Draw()
        {
            Draw(Color.LightGreen);
        }

        public void Draw(Color color)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen pen = new Pen(color);
            gr.DrawLine(pen, (float)X, (float)Y, (float)(X + Size), (float)(Y + Size));
            pictureBox.Image = bitmap;
        }

        public override void Move(double dx, double dy)
        {
            Draw(Color.White);
            X += dx;
            Y += dy;
            Draw(Color.LightGreen);
        }

        public override void Delete()
        {
            Draw(Color.White);
        }

        public override string ToString()
        {
            return "Линия";
        }
    }
}
