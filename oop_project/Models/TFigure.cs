using System;
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

        public void Draw()
        {
            Draw(Color.LightGreen);
        }

        public virtual void Draw(Color color)
        {
            
        }

        /// <summary>
        /// Смещение фигуры
        /// </summary>
        /// <param name="dx">Смещение по x</param>
        /// <param name="dy">Смещение по y</param>
        public void Move(double dx, double dy)
        {
            Draw(Color.White);
            this.X += dx;
            this.Y += dy;
            Draw(Color.LightGreen);
        }

        public void Move_In_BasePoint(double x_base, double y_base)
        {
            Draw(Color.White);
            this.X = x_base;
            this.Y = y_base;
            Draw(Color.LightGreen);
        }

        public void Delete()
        {
            Draw(Color.White);
        }
    }
}
