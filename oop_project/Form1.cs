using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oop_project.Models;

namespace oop_project
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        List<Rectangle> list_rectangles;
        List<Circle> list_circles;
        List<Line> list_lines;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);

            list_rectangles = new List<Rectangle>();
            list_circles = new List<Circle>();
            list_lines = new List<Line>();
        }

        private void Create_Rec_Click(object sender, EventArgs e)
        {
            Rectangle.bitmap = bitmap;
            Rectangle.pictureBox = PictureArea;

            Rectangle rectangle;
            
            
            if ((textBoxRecX.Text == String.Empty) && (textBoxRecY.Text == String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Rectangle();
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }
            else if ((textBoxRecX.Text != String.Empty) && (textBoxRecY.Text != String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Rectangle(Convert.ToDouble(textBoxRecX.Text), Convert.ToDouble(textBoxRecY.Text));
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }
            else if ((textBoxRecX.Text != String.Empty) && (textBoxRecY.Text == String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Rectangle(Convert.ToDouble(textBoxRecX.Text), true);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }
            else if ((textBoxRecX.Text == String.Empty) && (textBoxRecY.Text != String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Rectangle(Convert.ToDouble(textBoxRecY.Text), false);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }
            else
            {
                double x_rec = Convert.ToDouble(textBoxRecX.Text);
                double y_rec = Convert.ToDouble(textBoxRecY.Text);
                double size_rec = Convert.ToDouble(textBoxSizeRec.Text);
                MyPoint point = new MyPoint(x_rec, y_rec);
                rectangle = new Rectangle(point, size_rec);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }

            list_rectangles.Add(rectangle);

            rectangle.Draw();
        }

        private void Move_Rec_Click(object sender, EventArgs e)
        {
            
            double x_move = Convert.ToDouble(textBoxMoveRecX.Text);
            double y_move = Convert.ToDouble(textBoxMoveRecY.Text);

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rectangles[Convert.ToInt32(textBoxIDRec.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_rectangles)
                {
                    item.Move(x_move, y_move);
                }
            }
            
        }

        private void Change_Rec_Click(object sender, EventArgs e)
        {

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rectangles[Convert.ToInt32(textBoxIDRec.Text)].Change();
            }
            else
            {

                foreach (var item in list_rectangles)
                {
                    item.Change();
                }
            }
        }

        private void DeleteRec_Click(object sender, EventArgs e)
        {

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rectangles[Convert.ToInt32(textBoxIDRec.Text)].Delete();
                list_rectangles.RemoveAt(Convert.ToInt32(textBoxIDRec.Text));
            }
            else
            {          

                foreach (var item in list_rectangles)
                {
                    item.Delete();
                }
                list_rectangles.Clear();
            }
        }

        private void Create_Circ_Click(object sender, EventArgs e)
        {
            Circle.bitmap = bitmap;
            Circle.pictureBox = PictureArea;

            Circle circle;


            if ((textBoxCircX.Text == String.Empty) && (textBoxCircY.Text == String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle();
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.point.X} y = {circle.point.Y}");
            }
            else if ((textBoxCircX.Text != String.Empty) && (textBoxCircY.Text != String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircX.Text), Convert.ToDouble(textBoxCircY.Text));
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.point.X} y = {circle.point.Y}");
            }
            else if ((textBoxCircX.Text != String.Empty) && (textBoxCircY.Text == String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircX.Text), true);
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.point.X} y = {circle.point.Y}");
            }
            else if ((textBoxCircX.Text == String.Empty) && (textBoxCircY.Text != String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircY.Text), false);
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.point.X} y = {circle.point.Y}");
            }
            else
            {
                double x_circ = Convert.ToDouble(textBoxCircX.Text);
                double y_circ = Convert.ToDouble(textBoxCircY.Text);
                double size_circ = Convert.ToDouble(textBoxSizeCirc.Text);
                MyPoint point = new MyPoint(x_circ, y_circ);
                circle = new Circle(point, size_circ);
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.point.X} y = {circle.point.Y}");
            }

            list_circles.Add(circle);

            circle.Draw();
        }

        private void Move_Circ_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveCircX.Text);
            double y_move = Convert.ToDouble(textBoxMoveCircY.Text);

            if (textBoxIDCirc.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDCirc.Text) < 0 || Convert.ToInt32(textBoxIDCirc.Text) >= list_circles.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_circles.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_circles[Convert.ToInt32(textBoxIDCirc.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_circles)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void Delete_Circ_Click(object sender, EventArgs e)
        {
            if (textBoxIDCirc.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDCirc.Text) < 0 || Convert.ToInt32(textBoxIDCirc.Text) >= list_circles.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_circles.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_circles[Convert.ToInt32(textBoxIDCirc.Text)].Delete();
                list_circles.RemoveAt(Convert.ToInt32(textBoxIDCirc.Text));
            }
            else
            {
                foreach (var item in list_circles)
                {
                    item.Delete();
                }
                list_circles.Clear();
            }
        }

        private void Create_Line_Click(object sender, EventArgs e)
        {
            Line.bitmap = bitmap;
            Line.pictureBox = PictureArea;

            Line line;


            if ((textBoxLineX1.Text == String.Empty) && (textBoxLineY1.Text == String.Empty) && (textBoxLineX2.Text == String.Empty) && (textBoxLineY2.Text == String.Empty))
            {
                line = new Line();
                MessageBox.Show($"Вы создали линию. Координаты: x1 = {line.point1.X} y1 = {line.point1.Y} x2 = {line.point2.X} y2 = {line.point2.Y}");
            }
            else
            {
                double x1_line = Convert.ToDouble(textBoxLineX1.Text);
                double y1_line = Convert.ToDouble(textBoxLineY1.Text);
                double x2_line = Convert.ToDouble(textBoxLineX2.Text);
                double y2_line = Convert.ToDouble(textBoxLineY2.Text);
                line = new Line(x1_line, y1_line, x2_line, y2_line);
                MessageBox.Show($"Вы создали линию. Координаты: x1 = {line.point1.X} y1 = {line.point1.Y} x2 = {line.point2.X} y2 = {line.point2.Y}");
            }

            list_lines.Add(line);

            line.Draw();
        }

        private void Move_Line_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveLineX.Text);
            double y_move = Convert.ToDouble(textBoxMoveLineY.Text);

            if (textBoxIDRec.Text != String.Empty)
            {
                list_lines[Convert.ToInt32(textBoxIDRec.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_lines)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void Delete_Line_Click(object sender, EventArgs e)
        {
            if (textBoxIDLine.Text != String.Empty)
            {
                list_lines[Convert.ToInt32(textBoxIDLine.Text)].Delete();
                list_lines.RemoveAt(Convert.ToInt32(textBoxIDLine.Text));
            }
            else
            {
                foreach (var item in list_lines)
                {
                    item.Delete();
                }
                list_lines.Clear();
            }
        }
    }
}
