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

        //List<Rectangle> list_rectangles;
        Rectangle[] list_rectangles;
        List<Circle> list_circles;
        List<Line> list_lines;
        List<Ring> list_rings;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);

            list_rectangles = new Rectangle[0] { };
            list_circles = new List<Circle>();
            list_lines = new List<Line>();
            list_rings = new List<Ring>();

            trackBarRectX.Scroll += TrackBarRectX_Scroll;
            trackBarRectY.Scroll += TrackBarRectY_Scroll;
            trackBarCircX.Scroll += TrackBarCircX_Scroll;
            trackBarCircY.Scroll += TrackBarCircY_Scroll;

            listBoxRect.SelectedIndexChanged += ListBoxRect_SelectedIndexChanged;
            listBoxCirc.SelectedIndexChanged += ListBoxCirc_SelectedIndexChanged;
            
        }

        private void ListBoxCirc_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDCirc.Text = listBoxCirc.SelectedIndex.ToString();
        }

        private void TrackBarCircY_Scroll(object sender, EventArgs e)
        {
            textBoxCircY.Text = Convert.ToString(trackBarCircY.Value);
        }

        private void TrackBarCircX_Scroll(object sender, EventArgs e)
        {
            textBoxCircX.Text = Convert.ToString(trackBarCircX.Value);
        }

        private void ListBoxRect_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDRec.Text = listBoxRect.SelectedIndex.ToString(); 
        }

        private void TrackBarRectY_Scroll(object sender, EventArgs e)
        {
            textBoxRecY.Text = Convert.ToString(trackBarRectY.Value);
        }

        private void TrackBarRectX_Scroll(object sender, EventArgs e)
        {
            textBoxRecX.Text = Convert.ToString(trackBarRectX.Value);
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
                //rectangle = Rectangle.X(Convert.ToDouble(textBoxRecX.Text));
                rectangle = new Rectangle(Convert.ToDouble(textBoxRecX.Text), true);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.point.X} y = {rectangle.point.Y}");
            }
            else if ((textBoxRecX.Text == String.Empty) && (textBoxRecY.Text != String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                //rectangle = Rectangle.Y(Convert.ToDouble(textBoxRecY.Text));
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

            //list_rectangles.Add(rectangle);
            ArrayOperation.AddElement(list_rectangles, rectangle);

            listBoxRect.Items.Add(rectangle.ToString() + $"№{list_rectangles.Length}");

            rectangle.Draw();
        }

        private void Move_Rec_Click(object sender, EventArgs e)
        {
            
            double x_move = Convert.ToDouble(textBoxMoveRecX.Text);
            double y_move = Convert.ToDouble(textBoxMoveRecY.Text);

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_rectangles.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rectangles.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rectangles[Convert.ToInt32(textBoxIDRec.Text)].Delete();
                //list_rectangles.RemoveAt(Convert.ToInt32(textBoxIDRec.Text));
                ArrayOperation.RemoveElement(list_rectangles, Convert.ToInt32(textBoxIDRec.Text));
                listBoxRect.Items.RemoveAt(Convert.ToInt32(textBoxIDRec.Text));
                listBoxRect.Refresh();
            }
            else
            {          

                foreach (var item in list_rectangles)
                {
                    item.Delete();
                }
                //list_rectangles.Clear();
                ArrayOperation.Clear(list_rectangles);
                listBoxRect.Items.Clear();
                listBoxRect.Refresh();
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

            listBoxCirc.Items.Add(circle.ToString() + $"№{list_circles.Count}");

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
                listBoxCirc.Items.RemoveAt(Convert.ToInt32(textBoxIDCirc.Text));
                listBoxCirc.Refresh();
            }
            else
            {
                foreach (var item in list_circles)
                {
                    item.Delete();
                }
                list_circles.Clear();
                listBoxCirc.Items.Clear();
                listBoxCirc.Refresh();
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

        private void Create_Ring_Click(object sender, EventArgs e)
        {
            Ring.bitmap = bitmap;
            Ring.pictureBox = PictureArea;

            Ring ring;

            double x_circ_1 = Convert.ToDouble(textBoxRingX.Text);
            double y_circ_1 = Convert.ToDouble(textBoxRingY.Text);
            double x_circ_2 = Convert.ToDouble(textBoxRingX.Text);
            double y_circ_2 = Convert.ToDouble(textBoxRingY.Text);

            double circ1_size = Convert.ToDouble(textBoxSizeRing1.Text);

            double circ2_size = Convert.ToDouble(textBoxSizeRing2.Text);

            double n = Math.Abs(circ2_size - circ1_size);

            if (circ2_size > circ1_size)
            {    
                x_circ_2 -= n / 2;
                y_circ_2 -= n / 2;
            }
            else
            {
                x_circ_1 -= n / 2;
                y_circ_1 -= n / 2;
            }

            Circle circle1 = new Circle(x_circ_1, y_circ_1, circ1_size);
            Circle circle2 = new Circle(x_circ_2, y_circ_2, circ2_size);

            ring = new Ring(circle1, circle2);
            ring.Draw();
            list_rings.Add(ring);
        }

        private void Move_Ring_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveRingX.Text);
            double y_move = Convert.ToDouble(textBoxMoveRingY.Text);

            if (textBoxIDCirc.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRing.Text) < 0 || Convert.ToInt32(textBoxIDRing.Text) >= list_rings.Count)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rings.Count - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rings[Convert.ToInt32(textBoxIDRing.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_rings)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRect_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
