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
    #region Laba 6
    //enum Figure
    //{
    //    Circle,
    //    Ellipse,
    //    Line,
    //    Rectangle,
    //    Rhomb,
    //    Square
    //}
    #endregion

    public partial class Form1 : Form
    {
        Bitmap bitmap;

        Square[] list_squares;
        Circle[] list_circles;
        Line[] list_lines;
        Ring[] list_rings;
        MyFigure[] list_myfigures;
        Ellipse[] list_ellipses;
        Square[] list_inher;
        TFigure[] list_figures;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);
            

            list_squares = new Square[0] { };
            list_circles = new Circle[0] { };
            list_lines = new Line[0] { };
            list_rings = new Ring[0] { };
            list_myfigures = new MyFigure[0] { };
            list_ellipses = new Ellipse[0] { };
            list_inher = new Square[0] { };
            list_figures = new TFigure[0] { };


            comboBoxInher.SelectedIndexChanged += ComboBoxInher_SelectedIndexChanged;

            trackBarRectX.Scroll += TrackBarRectX_Scroll;
            trackBarRectY.Scroll += TrackBarRectY_Scroll;
            trackBarCircX.Scroll += TrackBarCircX_Scroll;
            trackBarCircY.Scroll += TrackBarCircY_Scroll;
            
            trackBarLineX.Scroll += TrackBarLineX_Scroll;
            trackBarLineY.Scroll += TrackBarLineY_Scroll;
         
            trackBarEllipsX.Scroll += TrackBarEllipsX_Scroll;
            trackBarEllipsY.Scroll += TrackBarEllipsY_Scroll;
            trackBarInherX.Scroll += TrackBarInherX_Scroll;
            trackBarInherY.Scroll += TrackBarInherY_Scroll;

            listBoxRect.SelectedIndexChanged += ListBoxRect_SelectedIndexChanged;
            listBoxCirc.SelectedIndexChanged += ListBoxCirc_SelectedIndexChanged;
            
            listBoxLine.SelectedIndexChanged += ListBoxLine_SelectedIndexChanged;
      
            listBoxEllips.SelectedIndexChanged += ListBoxEllips_SelectedIndexChanged;
            listBoxInher.SelectedIndexChanged += ListBoxInher_SelectedIndexChanged;

            TFigure.bitmap = bitmap;
            TFigure.pictureBox = PictureArea;
            
        }

        private void ListBoxInher_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDInher.Text = listBoxInher.SelectedIndex.ToString();
        }

        private void TrackBarInherY_Scroll(object sender, EventArgs e)
        {
            textBoxInherY.Text = Convert.ToString(trackBarInherY.Value);
        }

        private void TrackBarInherX_Scroll(object sender, EventArgs e)
        {
            textBoxInherX.Text = Convert.ToString(trackBarInherX.Value);
        }

        private void ComboBoxInher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInher.SelectedIndex == 0)
            {
                labelInherSize1.Text = "Размер 1-ой диагонали";
                labelInherSize2.Text = "Размер 2-ой диагонали";
            }
            else if (comboBoxInher.SelectedIndex == 1)
            {
                labelInherSize1.Text = "Размер 1-ой стороны";
                labelInherSize2.Text = "Размер 2-ой стороны";
            }
        }

        private void TrackBarEllipsY_Scroll(object sender, EventArgs e)
        {
            textBoxEllipsY.Text = Convert.ToString(trackBarEllipsY.Value);
        }

        private void TrackBarEllipsX_Scroll(object sender, EventArgs e)
        {
            textBoxEllipsX.Text = Convert.ToString(trackBarEllipsX.Value);
        }

        private void ListBoxEllips_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIDEllips.Text = listBoxEllips.SelectedIndex.ToString();
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

            Square rectangle;

            if ((textBoxRecX.Text == String.Empty) && (textBoxRecY.Text == String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Square();
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.X} y = {rectangle.Y}");
            }
            else if ((textBoxRecX.Text != String.Empty) && (textBoxRecY.Text != String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Square(Convert.ToDouble(textBoxRecX.Text), Convert.ToDouble(textBoxRecY.Text));
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.X} y = {rectangle.Y}");
            }
            else if ((textBoxRecX.Text != String.Empty) && (textBoxRecY.Text == String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Square(Convert.ToDouble(textBoxRecX.Text), true);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.X} y = {rectangle.Y}");
            }
            else if ((textBoxRecX.Text == String.Empty) && (textBoxRecY.Text != String.Empty) && (textBoxSizeRec.Text == String.Empty))
            {
                rectangle = new Square(Convert.ToDouble(textBoxRecY.Text), false);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.X} y = {rectangle.Y}");
            }
            else
            {
                double x_rec = Convert.ToDouble(textBoxRecX.Text);
                double y_rec = Convert.ToDouble(textBoxRecY.Text);
                double size_rec = Convert.ToDouble(textBoxSizeRec.Text);
                rectangle = new Square(x_rec, y_rec, size_rec);
                MessageBox.Show($"Вы создали квадрат размера {rectangle.Size} на {rectangle.Size}. Координаты: x = {rectangle.X} y = {rectangle.Y}");
            }

            list_squares = ArrayOperation.AddElement(list_squares, rectangle);

            listBoxRect.Items.Add(rectangle.ToString() + $"№{list_squares.Length}");

            rectangle.Draw();
        }

        private void Move_Rec_Click(object sender, EventArgs e)
        {
            
            double x_move = Convert.ToDouble(textBoxMoveRecX.Text);
            double y_move = Convert.ToDouble(textBoxMoveRecY.Text);

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_squares.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_squares.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_squares[Convert.ToInt32(textBoxIDRec.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_squares)
                {
                    item.Move(x_move, y_move);
                }
            }
            
        }

        private void Change_Rec_Click(object sender, EventArgs e)
        {

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_squares.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_squares.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_squares[Convert.ToInt32(textBoxIDRec.Text)].Change();
            }
            else
            {

                foreach (var item in list_squares)
                {
                    item.Change();
                }
            }
        }

        private void DeleteRec_Click(object sender, EventArgs e)
        {

            if (textBoxIDRec.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDRec.Text) < 0 || Convert.ToInt32(textBoxIDRec.Text) >= list_squares.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_squares.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_squares[Convert.ToInt32(textBoxIDRec.Text)].Delete();
                //list_rectangles.RemoveAt(Convert.ToInt32(textBoxIDRec.Text));
                list_squares = ArrayOperation.RemoveElement(list_squares, Convert.ToInt32(textBoxIDRec.Text));
                listBoxRect.Items.RemoveAt(Convert.ToInt32(textBoxIDRec.Text));
                listBoxRect.Refresh();
            }
            else
            {          

                foreach (var item in list_squares)
                {
                    item.Delete();
                }
                //list_rectangles.Clear();
                list_squares = ArrayOperation.Clear(list_squares);
                listBoxRect.Items.Clear();
                listBoxRect.Refresh();
            }
        }

        private void Create_Circ_Click(object sender, EventArgs e)
        {
            Circle circle;

            if ((textBoxCircX.Text == String.Empty) && (textBoxCircY.Text == String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle();
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.X} y = {circle.Y}");
            }
            else if ((textBoxCircX.Text != String.Empty) && (textBoxCircY.Text != String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircX.Text), Convert.ToDouble(textBoxCircY.Text));
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.X} y = {circle.Y}");
            }
            else if ((textBoxCircX.Text != String.Empty) && (textBoxCircY.Text == String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircX.Text), true);
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.X} y = {circle.Y}");
            }
            else if ((textBoxCircX.Text == String.Empty) && (textBoxCircY.Text != String.Empty) && (textBoxSizeCirc.Text == String.Empty))
            {
                circle = new Circle(Convert.ToDouble(textBoxCircY.Text), false);
                MessageBox.Show($"Вы создали радиуса {circle.Size}. Координаты: x = {circle.X} y = {circle.Y}");
            }
            else
            {
                double x_circ = Convert.ToDouble(textBoxCircX.Text);
                double y_circ = Convert.ToDouble(textBoxCircY.Text);
                double size_circ = Convert.ToDouble(textBoxSizeCirc.Text);
                circle = new Circle(x_circ, y_circ, size_circ);
                MessageBox.Show($"Вы создали круг радиуса {circle.Size}. Координаты: x = {circle.X} y = {circle.Y}");
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
            Line line;

            if ((textBoxLineX.Text == String.Empty) && (textBoxLineY.Text == String.Empty) && (textBoxLineSize.Text == String.Empty))
            {
                line = new Line();
                MessageBox.Show($"Вы создали линию. Координаты базовой точки: x1 = {line.X} y1 = {line.Y}. Размер: {line.Size}");
            }
            else
            {
                double x1_line = Convert.ToDouble(textBoxLineX.Text);
                double y1_line = Convert.ToDouble(textBoxLineY.Text);
                double size_line = Convert.ToDouble(textBoxLineSize.Text);
                line = new Line(x1_line, y1_line, size_line);
                MessageBox.Show($"Вы создали линию. Координаты базовой точки: x1 = {line.X} y1 = {line.Y}. Размер: {line.Size}");
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

        

        
        
        private void Create_Ellips_Click(object sender, EventArgs e)
        {
            Ellipse ellipse;

            if ((textBoxEllipsX.Text == String.Empty) && (textBoxEllipsY.Text == String.Empty) && (textBoxEllipsSize1.Text == String.Empty) && (textBoxEllipsSize2.Text == String.Empty))
            {
                ellipse = new Ellipse();
                MessageBox.Show($"Вы создали эллипс 1-ая полуось: {ellipse.Size} 2-ая полуось: {ellipse.Size2}. Координаты: x = {ellipse.X} y = {ellipse.Y}");
            }
            else
            {
                double x_ellip = Convert.ToDouble(textBoxEllipsX.Text);
                double y_ellip = Convert.ToDouble(textBoxEllipsY.Text);
                double size1_ellip = Convert.ToDouble(textBoxEllipsSize1.Text);
                double size2_ellip = Convert.ToDouble(textBoxEllipsSize2.Text);               
                ellipse = new Ellipse(x_ellip, y_ellip, size1_ellip, size2_ellip);
                MessageBox.Show($"Вы создали эллипс 1-ая полуось: {ellipse.Size} 2-ая полуось: {ellipse.Size2}. Координаты: x = {ellipse.X} y = {ellipse.Y}");
            }

            list_ellipses = ArrayOperation.AddElement(list_ellipses, ellipse);

            listBoxEllips.Items.Add(ellipse.ToString() + $"№{list_ellipses.Length}");

            ellipse.Draw();
        }

        private void Move_Ellip_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveElX.Text);
            double y_move = Convert.ToDouble(textBoxMoveElY.Text);

            if (textBoxIDEllips.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDEllips.Text) < 0 || Convert.ToInt32(textBoxIDEllips.Text) >= list_ellipses.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_ellipses.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_ellipses[Convert.ToInt32(textBoxIDEllips.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_ellipses)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void Change_Ellip_Click(object sender, EventArgs e)
        {
            if (textBoxIDEllips.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDEllips.Text) < 0 || Convert.ToInt32(textBoxIDEllips.Text) >= list_ellipses.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_ellipses.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                list_ellipses[Convert.ToInt32(textBoxIDEllips.Text)].ChangeSemiAxis();
            }
            else
            {
                foreach (var item in list_ellipses)
                {
                    item.ChangeSemiAxis();
                }
            }
        }

        private void Delete_Ellip_Click(object sender, EventArgs e)
        {
            if (textBoxIDEllips.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDEllips.Text) < 0 || Convert.ToInt32(textBoxIDEllips.Text) >= list_ellipses.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_ellipses.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_ellipses[Convert.ToInt32(textBoxIDEllips.Text)].Delete();
                list_ellipses = ArrayOperation.RemoveElement(list_ellipses, Convert.ToInt32(textBoxIDEllips.Text));
                listBoxEllips.Items.RemoveAt(Convert.ToInt32(textBoxIDEllips.Text));
                listBoxEllips.Refresh();
            }
            else
            {
                foreach (var item in list_ellipses)
                {
                    item.Delete();
                }
                list_ellipses = ArrayOperation.Clear(list_ellipses);
                listBoxEllips.Items.Clear();
                listBoxEllips.Refresh();
            }
        }

        private void Create_Inher_Click(object sender, EventArgs e)
        {
            if (comboBoxInher.SelectedIndex == 0)
            {
                Rhomb rhomb;
                if ((textBoxInherX.Text == String.Empty) && (textBoxInherY.Text == String.Empty) && (textBoxInherSize1.Text == String.Empty) && (textBoxInherSize2.Text == String.Empty))
                {
                    rhomb = new Rhomb();
                    MessageBox.Show($"Вы создали эллипс 1-ая полуось: {rhomb.Size} 2-ая полуось: {rhomb.Size2}. Координаты: x = {rhomb.X} y = {rhomb.Y}");
                }
                else
                {
                    double x_rhomb = Convert.ToDouble(textBoxInherX.Text);
                    double y_rhomb = Convert.ToDouble(textBoxInherY.Text);
                    double size1_rhomb = Convert.ToDouble(textBoxInherSize1.Text);
                    double size2_rhomb = Convert.ToDouble(textBoxInherSize2.Text);
                    rhomb = new Rhomb(x_rhomb, y_rhomb, size1_rhomb, size2_rhomb);
                    MessageBox.Show($"Вы создали эллипс 1-ая полуось: {rhomb.Size} 2-ая полуось: {rhomb.Size2}. Координаты: x = {rhomb.X} y = {rhomb.Y}");
                }

                list_inher = ArrayOperation.AddElement(list_inher, rhomb);

                listBoxInher.Items.Add(rhomb.ToString() + $"№{list_inher.Length}");

                rhomb.Draw();
            }
            else if (comboBoxInher.SelectedIndex == 1)
            {
                MyRectangle rec;
                if ((textBoxInherX.Text == String.Empty) && (textBoxInherY.Text == String.Empty) && (textBoxInherSize1.Text == String.Empty) && (textBoxInherSize2.Text == String.Empty))
                {
                    rec = new MyRectangle();
                    MessageBox.Show($"Вы создали эллипс 1-ая полуось: {rec.Size} 2-ая полуось: {rec.Size2}. Координаты: x = {rec.X} y = {rec.Y}");
                }
                else
                {
                    double x_rec = Convert.ToDouble(textBoxInherX.Text);
                    double y_rec = Convert.ToDouble(textBoxInherY.Text);
                    double size1_rec = Convert.ToDouble(textBoxInherSize1.Text);
                    double size2_rec = Convert.ToDouble(textBoxInherSize2.Text);
                    rec = new MyRectangle(x_rec, y_rec, size1_rec, size2_rec);
                    MessageBox.Show($"Вы создали эллипс 1-ая полуось: {rec.Size} 2-ая полуось: {rec.Size2}. Координаты: x = {rec.X} y = {rec.Y}");
                }
                list_inher = ArrayOperation.AddElement(list_inher, rec);

                listBoxInher.Items.Add(rec.ToString() + $"№{list_inher.Length}");

                rec.Draw();
            }

        }

        private void Move_Inher_Click(object sender, EventArgs e)
        {
            double x_move = Convert.ToDouble(textBoxMoveInherX.Text);
            double y_move = Convert.ToDouble(textBoxMoveInherY.Text);

            if (textBoxIDInher.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDInher.Text) < 0 || Convert.ToInt32(textBoxIDInher.Text) >= list_inher.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_inher.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_inher[Convert.ToInt32(textBoxIDInher.Text)].Move(x_move, y_move);
            }
            else
            {
                foreach (var item in list_inher)
                {
                    item.Move(x_move, y_move);
                }
            }
        }

        private void Delete_Inher_Click(object sender, EventArgs e)
        {
            if (textBoxIDInher.Text != String.Empty)
            {
                if (Convert.ToInt32(textBoxIDInher.Text) < 0 || Convert.ToInt32(textBoxIDInher.Text) >= list_inher.Length)
                {
                    MessageBox.Show($"Ошибка\nИндекс должен быть от {0} до {list_inher.Length - 1}", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                list_inher[Convert.ToInt32(textBoxIDInher.Text)].Delete();
                list_inher = ArrayOperation.RemoveElement(list_inher, Convert.ToInt32(textBoxIDInher.Text));
                listBoxInher.Items.RemoveAt(Convert.ToInt32(textBoxIDInher.Text));
                listBoxInher.Refresh();
            }
            else
            {
                foreach (var item in list_inher)
                {
                    item.Delete();
                }
                list_inher = ArrayOperation.Clear(list_inher);
                listBoxInher.Items.Clear();
                listBoxInher.Refresh();
            }
        }

        #region Laba_6
        //private void Create_Figures_Click(object sender, EventArgs e)
        //{
        //    Random rand = new Random();
        //    TFigure figure;

        //    for (int i = 0; i < 15; i++)
        //    {

        //        switch (rand.Next(0, 5))
        //        {
        //            case (int)Figure.Circle:
        //                figure = new Circle((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //            case (int)Figure.Ellipse:
        //                figure = new Ellipse((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //            case (int)Figure.Line:
        //                figure = new Line((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //            case (int)Figure.Rectangle:
        //                figure = new MyRectangle((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //            case (int)Figure.Rhomb:
        //                figure = new Rhomb((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //            default:
        //                figure = new Square((double)rand.Next(300), (double)rand.Next(300), (double)rand.Next(300));
        //                break;
        //        }

        //        list_figures = ArrayOperation.AddElement(list_figures, figure);
        //        figure.Draw();
        //        //listBoxFigures.Items.Add(figure.ToString() + $"№{list_figures.Length}");
        //    }
        //}
        #endregion
    }
}
