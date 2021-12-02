using oop_project.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project.Containers
{
    public class TContainerArr
    {
        private TFigure[] figures;

        private int index;

        private Random rand;

        public TContainerArr()
        {
            figures = new TFigure[15];
            this.index = 0;
            rand = new Random();
        }

        public TContainerArr(int count)
        {
            this.index = 0;
            figures = new TFigure[count];
            rand = new Random();
            Load();
        }

        public void Add(TFigure figure)
        {
            this.Resize(index >= this.figures.Length);
            this.figures[index] = figure;
            this.index++;
        }

        public void Draw()
        {
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                    figures[i].Draw();
            }
        }

        public void Move(int base_x, int base_y, string condition)
        {
            if (condition == "Все")
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (figures[i] != null)
                        figures[i].Move_In_BasePoint(base_x, base_y);
                }
            }
            else if (condition == "Крг и элпс")
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (figures[i] is Circle && figures[i] != null)
                    {
                        figures[i].Move_In_BasePoint(base_x, base_y);
                    }
                }
            }
            else if (condition == "Квадраты, прм и рмб")
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (figures[i] is Square && figures[i] != null)
                    {
                        figures[i].Move_In_BasePoint(base_x, base_y);
                    }
                }
            }
            else if (condition == "Линии")
            {
                for (int i = 0; i < figures.Length; i++)
                {
                    if (figures[i] is Line && figures[i] != null)
                    {
                        figures[i].Move_In_BasePoint(base_x, base_y);
                    }
                }
            }
        }

        public void Delete()
        {
            RemoveAll();
            for (int i = 0; i < figures.Length; i++)
            {
                figures[i] = null;
            }
            figures = null;
        }

        public void Paint_Red(int index_el)
        {
            for (int i = 0; i < figures.Length; i++)
            {
                if (index_el == i + 1 && figures[i] != null)
                {
                    figures[index_el].Draw(Color.Red);
                    break;
                }
            }
        }

        public void RemoveAll()
        {
            for (int i = 0; i < figures.Length; i++)
            {
                if (figures[i] != null)
                    figures[i].Delete();
            }
        }

        private void Resize(bool Flag)
        {
            if (Flag)
            {
                Array.Resize(ref this.figures, Convert.ToInt32(Math.Round(this.figures.Length * 1.1)));
            }
        }

        private void Load()
        {
            for (int i = 0; i < this.figures.Length; i++)
            {
                TFigure figure = Select_Figures();
                
                figures[index] = figure;
                index++;
            }
        }

        private TFigure Select_Figures()
        {
            TFigure figure;
            switch (rand.Next(0, 5))
            {
                case (int)Figure.Circle:
                    figure = new Circle((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
                case (int)Figure.Ellipse:
                    figure = new Ellipse((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
                case (int)Figure.Line:
                    figure = new Line((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
                case (int)Figure.Rectangle:
                    figure = new MyRectangle((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
                case (int)Figure.Rhomb:
                    figure = new Rhomb((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
                default:
                    figure = new Square((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
                    break;
            }
            return figure;
        }

        public int Count
        {
            get { return figures.Length; }
        }

        public IEnumerator<TFigure> GetEnumerator()
        {
            for(int i = 0; i < this.figures.Length; i++)
            {
                yield return this.figures[i];
            }
        }
    }
}
