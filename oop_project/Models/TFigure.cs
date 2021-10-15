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

        public MyPoint point { get; protected set; }

        public double Size { get; protected set; }

        public TFigure(MyPoint point, double size)
        {
            this.point = point;
            this.Size = size;
        }

        public TFigure(double x, double y, double size)
        {
            point = new MyPoint(x, y);
            this.Size = size;
        }

        public TFigure(double value, bool isValue)
        {
            if (isValue == true)
            {
                point = new MyPoint(value, (double)new Random().Next(20, 500));
                this.Size = (double)new Random().Next(20, 300);
            }
            else
            {
                point = new MyPoint((double)new Random().Next(20, 500), value);
                this.Size = (double)new Random().Next(20, 300);
            }
        }

        public TFigure()
        {
            point = new MyPoint((double)r.Next(20, 400), (double)r.Next(20, 400));
            this.Size = (double)r.Next(30, 150);
        }

        public virtual void Draw()
        {

        }

        public virtual void Draw(Color color)
        {
            
        }

        public virtual void Move(double dx, double dy)
        {
            Draw(Color.White);
            this.point.X += dx;
            this.point.Y += dy;
            Draw(Color.LightGreen);
        }

        public virtual void Delete()
        {
            Draw(Color.White);
        }

        //public abstract void Draw();

        //public abstract void Move(double dx, double dy);

        //public abstract void Delete();
    }
}
