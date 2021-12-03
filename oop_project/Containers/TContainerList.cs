using oop_project.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project.Containers
{
    public class TContainerList : IEnumerable<TFigure>
    {
        Node head;
        Node tail;
        int count;
        Random rand;

        public TContainerList()
        {
            head = null;
            tail = null;
            count = 0;
            rand = new Random();
        }

        public TContainerList(int count)
        {
            rand = new Random();
            this.count = 0;
            Load(count);
        }

        public void Add(TFigure figure)
        {
            Node node = new Node(figure);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public void Draw()
        {
            Node current = head;
            while (current != null)
            {
                current.Data.Draw();
                current = current.Next;
            }
        }

        public void Move(int base_x, int base_y, string condition)
        {
            if (condition == "Все")
            {
                Node current = head;
                while (current != null)
                {
                    current.Data.Move_In_BasePoint(base_x, base_y);
                    current = current.Next;
                }
            }
            else if (condition == "Крг и элпс")
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data is Circle)
                        current.Data.Move_In_BasePoint(base_x, base_y);
                    current = current.Next;
                }
            }
            else if (condition == "Квадраты, прм и рмб")
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data is Square)
                        current.Data.Move_In_BasePoint(base_x, base_y);
                    current = current.Next;
                }
            }
            else if (condition == "Линии")
            {
                Node current = head;
                while (current != null)
                {
                    if (current.Data is Line)
                        current.Data.Move_In_BasePoint(base_x, base_y);
                    current = current.Next;
                }
            }
        }

        public void Delete()
        {
            RemoveAll();
            Node current = head;
            while (current != null)
            {
                current.Data = null;
                current = current.Next;
            }
            head = null;
            tail = null;
            count = 0;
        }

        public void RemoveAll()
        {
            Node current = head;
            while (current != null)
            {
                current.Data.Delete();
                current = current.Next;
            }
        }

        private void Load(int count)
        {
            for (int i = 0; i < count; i++)
            {
                TFigure fig = Select_Figures();
                Add(fig);
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

        public IEnumerator<TFigure> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count
        {
            get { return this.count; }
        }
    }
}
