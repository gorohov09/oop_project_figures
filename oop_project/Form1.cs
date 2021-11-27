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
    #region Список фигур
    enum Figure
    {
        Circle,
        Ellipse,
        Line,
        Rectangle,
        Rhomb,
        Square
    }
    #endregion

    public partial class Form1 : Form
    {
        Bitmap bitmap;
        TFigure[] List_Figures;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);

            TFigure.bitmap = bitmap;
            TFigure.pictureBox = PictureArea;

            listBoxFigures.SelectedIndexChanged += ListBoxFigures_SelectedIndexChanged;

        }

        private void ShowCollection()
        {
            for (int i = 0; i < List_Figures.Length; i++)
            {
                List_Figures[i].Draw();
            }
        }

        private void ListBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCollection();
            int index_el = listBoxFigures.SelectedIndex;
            for (int i = 0; i < List_Figures.Length; i++)
            {
                if (index_el == i + 1)
                {
                    List_Figures[index_el].Draw(Color.Red);
                    break;
                }                  
            }
        }

        private void Create_Collection_Click(object sender, EventArgs e)
        {
            Form_Create_Collection f = new Form_Create_Collection();

            if (f.ShowDialog() == DialogResult.OK)
            {
                int count_element = Convert.ToInt32(f.textBoxCountEl.Text);
                Random rand = new Random();
                List_Figures = new TFigure[count_element];

                for (int i = 0; i < count_element; i++)
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
                    List_Figures[i] = figure;
                    listBoxFigures.Items.Add(figure.ToString() + $"№{i + 1}");
                }
            }

        }

        private void Show_Collection_Click(object sender, EventArgs e)
        {
            ShowCollection();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            Form_Move_Collection f = new Form_Move_Collection();

            if (f.ShowDialog() == DialogResult.OK)
            {
                double base_x = Convert.ToDouble(f.textBoxMoveX.Text);
                double base_y = Convert.ToDouble(f.textBoxMoveY.Text);
                string el = f.cmbbxItemFig.SelectedItem.ToString();

                if (el == "Все")
                {
                    for (int i = 0; i < List_Figures.Length; i++)
                    {
                        List_Figures[i].Move_In_BasePoint(base_x, base_y);
                    }
                }
                else if (el == "Крг и элпс")
                {
                    for (int i = 0; i < List_Figures.Length; i++)
                    {
                        if (List_Figures[i] is Circle)
                        {
                            List_Figures[i].Move_In_BasePoint(base_x, base_y);
                        }
                    }
                }
                else if (el == "Квадраты, прм и рмб")
                {
                    for (int i = 0; i < List_Figures.Length; i++)
                    {
                        if (List_Figures[i] is Square)
                        {
                            List_Figures[i].Move_In_BasePoint(base_x, base_y);
                        }
                    }
                }
                else if (el == "Линии")
                {
                    for (int i = 0; i < List_Figures.Length; i++)
                    {
                        if (List_Figures[i] is Line)
                        {
                            List_Figures[i].Move_In_BasePoint(base_x, base_y);
                        }
                    }
                }

            }
        }

        private void Delete_Figures_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < List_Figures.Length; i++)
            {
                List_Figures[i].Delete();
            }
        }

        private void buttonDelete_Collection_Click(object sender, EventArgs e)
        {

            for(int i = 0; i < List_Figures.Length; i++)
            {
                List_Figures[i].Delete();
                List_Figures[i] = null;
            }
            List_Figures = null;
            listBoxFigures.Items.Clear();
        }

        private void buttonEllipseMethod_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < List_Figures.Length; i++)
            {
                if (List_Figures[i] is Ellipse)
                {
                    (List_Figures[i] as Ellipse).ChangeSemiAxis();
                  
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                foreach (var e in List_Figures)
                {
                    e.Move(0, -17);
                }
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                foreach (var e in List_Figures)
                {
                    e.Move(0, 17);
                }
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                foreach (var e in List_Figures)
                {
                    e.Move(-17, 0);
                }
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                foreach (var e in List_Figures)
                {
                    e.Move(17, 0);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

