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

        Rectangle[] list_rectangles;
        Circle[] list_circles;
        Line[] list_lines;
        Ring[] list_rings;
        MyFigure[] list_myfigures;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);

            list_rectangles = new Rectangle[0] { };
            list_circles = new Circle[0] { };
            list_lines = new Line[0] { };
            list_rings = new Ring[0] { };
            list_myfigures = new MyFigure[0] { };

            trackBarRectX.Scroll += TrackBarRectX_Scroll;
            trackBarRectY.Scroll += TrackBarRectY_Scroll;
            trackBarCircX.Scroll += TrackBarCircX_Scroll;
            trackBarCircY.Scroll += TrackBarCircY_Scroll;
            trackBarRingX.Scroll += TrackBarRingX_Scroll;
            trackBarRingY.Scroll += TrackBarRingY_Scroll;
            trackBarLineX.Scroll += TrackBarLineX_Scroll;
            trackBarLineY.Scroll += TrackBarLineY_Scroll;
            trackBarMyFigureX.Scroll += TrackBarMyFigureX_Scroll;
            trackBarMyFigureY.Scroll += TrackBarMyFigureY_Scroll;

            listBoxRect.SelectedIndexChanged += ListBoxRect_SelectedIndexChanged;
            listBoxCirc.SelectedIndexChanged += ListBoxCirc_SelectedIndexChanged;
            listBoxRing.SelectedIndexChanged += ListBoxRing_SelectedIndexChanged;
            listBoxLine.SelectedIndexChanged += ListBoxLine_SelectedIndexChanged;
            listBoxMyFigures.SelectedIndexChanged += ListBoxMyFigures_SelectedIndexChanged;
            
        }

        private void ListBoxMyFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDMyFigure.Text = listBoxMyFigures.SelectedIndex.ToString();
        }

        private void TrackBarMyFigureY_Scroll(object sender, EventArgs e)
        {
            textBoxMyFigureY.Text = Convert.ToString(trackBarMyFigureY.Value);
        }

        private void TrackBarMyFigureX_Scroll(object sender, EventArgs e)
        {
            textBoxMyFigureX.Text = Convert.ToString(trackBarMyFigureX.Value);
        }

        private void ListBoxLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDLine.Text = listBoxLine.SelectedIndex.ToString();
        }

        private void TrackBarLineY_Scroll(object sender, EventArgs e)
        {
            textBoxLineY.Text = Convert.ToString(trackBarLineY.Value);
        }

        private void TrackBarLineX_Scroll(object sender, EventArgs e)
        {
            textBoxLineX.Text = Convert.ToString(trackBarLineX.Value);
        }

        private void ListBoxRing_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDRing.Text = listBoxRing.SelectedIndex.ToString();
        }

        private void TrackBarRingY_Scroll(object sender, EventArgs e)
        {
            textBoxRingY.Text = Convert.ToString(trackBarRingY.Value);
        }

        private void TrackBarRingX_Scroll(object sender, EventArgs e)
        {
            textBoxRingX.Text = Convert.ToString(trackBarRingX.Value);
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

            list_rectangles = ArrayOperation.AddElement(list_rectangles, rectangle);

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
                list_rectangles = ArrayOperation.RemoveElement(list_rectangles, Convert.ToInt32(textBoxIDRec.Text));
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
                list_rectangles = ArrayOperation.Clear(list_rectangles);
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

            list_circles = ArrayOperation.AddElement(list_circles, circle);

            listBoxCirc.Items.Add(circle.ToString() + $"№{list_circles.Length}");

            circle.Draw();
        }

        private void Move_Circ_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveCircX.Text);
            double y_move = Convert.ToDouble(textBoxMoveCircY.Text);

            if (textBoxIDCirc.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDCirc.Text) < 0 || Convert.ToInt32(textBoxIDCirc.Text) >= list_circles.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_circles.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (Convert.ToInt32(textBoxIDCirc.Text) < 0 || Convert.ToInt32(textBoxIDCirc.Text) >= list_circles.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_circles.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_circles[Convert.ToInt32(textBoxIDCirc.Text)].Delete();
                list_circles = ArrayOperation.RemoveElement(list_circles, Convert.ToInt32(textBoxIDCirc.Text));
                listBoxCirc.Items.RemoveAt(Convert.ToInt32(textBoxIDCirc.Text));
                listBoxCirc.Refresh();
            }
            else
            {
                foreach (var item in list_circles)
                {
                    item.Delete();
                }
                //list_circles.Clear();
                list_circles = ArrayOperation.Clear(list_circles);
                listBoxCirc.Items.Clear();
                listBoxCirc.Refresh();
            }
        }

        private void Create_Line_Click(object sender, EventArgs e)
        {
            Line.bitmap = bitmap;
            Line.pictureBox = PictureArea;

            Line line;


            if ((textBoxLineX.Text == String.Empty) && (textBoxLineY.Text == String.Empty) && (textBoxLineSize.Text == String.Empty))
            {
                line = new Line();
                MessageBox.Show($"Вы создали линию. Координаты базовой точки: x1 = {line.point.X} y1 = {line.point.Y}. Размер: {line.Size}");
            }
            else
            {
                double x1_line = Convert.ToDouble(textBoxLineX.Text);
                double y1_line = Convert.ToDouble(textBoxLineY.Text);
                double size_line = Convert.ToDouble(textBoxLineSize.Text);
                line = new Line(x1_line, y1_line, size_line);
                MessageBox.Show($"Вы создали линию. Координаты базовой точки: x1 = {line.point.X} y1 = {line.point.Y}. Размер: {line.Size}");
            }

            list_lines = ArrayOperation.AddElement(list_lines, line);

            listBoxLine.Items.Add(line.ToString() + $"№{list_lines.Length}");

            line.Draw();
        }

        private void Move_Line_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveLineX.Text);
            double y_move = Convert.ToDouble(textBoxMoveLineY.Text);

            if (textBoxIDLine.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDLine.Text) < 0 || Convert.ToInt32(textBoxIDLine.Text) >= list_lines.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_lines.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_lines[Convert.ToInt32(textBoxIDLine.Text)].Move(x_move, y_move);
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
                if (Convert.ToInt32(textBoxIDLine.Text) < 0 || Convert.ToInt32(textBoxIDLine.Text) >= list_lines.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_lines.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_lines[Convert.ToInt32(textBoxIDLine.Text)].Delete();
                list_lines = ArrayOperation.RemoveElement(list_lines, Convert.ToInt32(textBoxIDLine.Text));
                listBoxLine.Items.RemoveAt(Convert.ToInt32(textBoxIDLine.Text));
                listBoxLine.Refresh();
            }
            else
            {
                foreach (var item in list_lines)
                {
                    item.Delete();
                }
                list_lines = ArrayOperation.Clear(list_lines);
                listBoxLine.Items.Clear();
                listBoxLine.Refresh();
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
           
            list_rings = ArrayOperation.AddElement(list_rings, ring);

            listBoxRing.Items.Add(ring.ToString() + $"№{list_rings.Length}");

            ring.Draw();
        }

        private void Move_Ring_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveRingX.Text);
            double y_move = Convert.ToDouble(textBoxMoveRingY.Text);

            if (textBoxIDRing.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRing.Text) < 0 || Convert.ToInt32(textBoxIDRing.Text) >= list_rings.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rings.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Delete_Ring_Click(object sender, EventArgs e)
        {
            if (textBoxIDRing.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRing.Text) < 0 || Convert.ToInt32(textBoxIDRing.Text) >= list_rings.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_rings.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_rings[Convert.ToInt32(textBoxIDRing.Text)].Delete();
                list_rings = ArrayOperation.RemoveElement(list_rings, Convert.ToInt32(textBoxIDRing.Text));
                listBoxRing.Items.RemoveAt(Convert.ToInt32(textBoxIDRing.Text));
                listBoxRing.Refresh();
            }
            else
            {
                foreach (var item in list_rings)
                {
                    item.Delete();
                }
                list_rings = ArrayOperation.Clear(list_rings);
                listBoxRing.Items.Clear();
                listBoxRing.Refresh();
            }
        }

        private void Create_MyFigure_Click(object sender, EventArgs e)
        {
            MyFigure.bitmap = bitmap;
            MyFigure.pictureBox = PictureArea;

            MyFigure my_figure;

            double x_center = Convert.ToDouble(textBoxMyFigureX.Text);
            double y_center = Convert.ToDouble(textBoxMyFigureY.Text);
            double size_figure = Convert.ToDouble(textBoxMyFigureCircSize.Text);

            Circle circle = new Circle(x_center, y_center, size_figure);
            Rectangle rectangle = new Rectangle(x_center, y_center, size_figure);

            my_figure = new MyFigure(circle, rectangle);

            list_myfigures = ArrayOperation.AddElement(list_myfigures, my_figure);

            listBoxMyFigures.Items.Add(my_figure.ToString() + $"№{list_myfigures.Length}");

            my_figure.Draw();
        }

        private void Move_MyFigure_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveMyFigureX.Text);
            double y_move = Convert.ToDouble(textBoxMoveMyFigureY.Text);

            if (textBoxIDMyFigure.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDMyFigure.Text) < 0 || Convert.ToInt32(textBoxIDMyFigure.Text) >= list_myfigures.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_myfigures.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_myfigures[Convert.ToInt32(textBoxIDMyFigure.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_rings)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void Delete_MyFigure_Click(object sender, EventArgs e)
        {
            if (textBoxIDMyFigure.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDMyFigure.Text) < 0 || Convert.ToInt32(textBoxIDMyFigure.Text) >= list_myfigures.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_myfigures.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_myfigures[Convert.ToInt32(textBoxIDMyFigure.Text)].Delete();
                list_myfigures = ArrayOperation.RemoveElement(list_myfigures, Convert.ToInt32(textBoxIDMyFigure.Text));
                listBoxMyFigures.Items.RemoveAt(Convert.ToInt32(textBoxIDMyFigure.Text));
                listBoxMyFigures.Refresh();
            }
            else
            {
                foreach (var item in list_rings)
                {
                    item.Delete();
                }
                list_myfigures = ArrayOperation.Clear(list_myfigures);
                listBoxMyFigures.Items.Clear();
                listBoxMyFigures.Refresh();
            }
        }
    }
}
