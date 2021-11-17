﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace oop_project.Models
{
    public abstract class TFigure
    {
        protected Random r = new Random();

        public static PictureBox pictureBox;
        public static Bitmap bitmap;

        public double X { get; protected set; }

        public double Y { get; protected set; }

        public double Size { get; protected set; }

        public TFigure(double x, double y, double size)
        {
            this.X = x;
            this.Y = y;
            this.Size = size;
        }

        public TFigure(double value, bool isValue)
        {
            if (isValue == true)
            {               
                this.X = value;
                this.Y = (double)new Random().Next(20, 500);
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {               
                this.X = (double)new Random().Next(20, 500);
                this.Y = value;
                this.Size = (double)new Random().Next(20, 300);
            }
        }

        public TFigure()
        {
            this.X = (double)r.Next(20, 400);
            this.Y = (double)r.Next(20, 400);
            this.Size = (double)r.Next(30, 150);
        }

        #region Laba_5
        //public virtual void Draw()
        //{

        //}

        //public virtual void Draw(Color color)
        //{

        //}

        //public void Move(double dx, double dy)
        //{
        //    Draw(Color.White);
        //    this.point.X += dx;
        //    this.point.Y += dy;
        //    Draw(Color.LightGreen);
        //}

        //public void Delete()
        //{
        //    Draw(Color.White);
        //}
        #endregion

        public abstract void Draw();

        public abstract void Move(double dx, double dy);

        public abstract void Delete();
    }
}
