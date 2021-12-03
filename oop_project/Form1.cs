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
using oop_project.Containers;

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
        TContainerArr containerArr;
        TContainerList containerList;
        Random rand;
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(PictureArea.Width, PictureArea.Height);

            TFigure.bitmap = bitmap;
            TFigure.pictureBox = PictureArea;

            listBoxFigures.SelectedIndexChanged += ListBoxFigures_SelectedIndexChanged;

            rand = new Random();
        }

        private void ShowArray()
        {
            containerArr.Draw();
        }

        private void ShowList()
        {
            containerList.Draw();
        }

        private void ListBoxFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ShowCollection();
            int index_el = listBoxFigures.SelectedIndex;
            containerArr.Paint_Red(index_el);
        }

        private void Create_Collection_Click(object sender, EventArgs e)
        {
            Form_Create_Collection f = new Form_Create_Collection();

            if (f.ShowDialog() == DialogResult.OK)
            {
                string sel = f.cmbbxCreate.SelectedItem.ToString();

                if (sel == "пустой")
                {
                    if (f.radioButtonArr.Checked)
                    {
                        containerArr = new TContainerArr();
                        MessageBox.Show("Пустой массив успешно создан");
                    }
                    else
                    {
                        containerList = new TContainerList();
                        MessageBox.Show("Пустой список успешно создан");
                    }                                     
                }
                else if (sel == "заполненный")
                {
                    int count_element = Convert.ToInt32(f.textBoxCountEl.Text);
                    if (f.radioButtonArr.Checked)
                    {
                        containerArr = new TContainerArr(count_element);
                        int count = 0;
                        foreach (var el in containerList)
                        {
                            listBoxFigures.Items.Add(el.ToString() + $"№{count + 1}");
                            count++;
                        }
                        MessageBox.Show("Заполненный массив успешно создан");
                    }
                    else
                    {
                        containerList = new TContainerList(count_element);
                        int count = 0;
                        foreach (var el in containerList)
                        {
                            listBoxFigures.Items.Add(el.ToString() + $"№{count + 1}");
                            count++;
                        }
                        MessageBox.Show("Заполненный список успешно создан");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Выберите что-нибудь");
                }
            }
        }

        private void Show_Collection_Click(object sender, EventArgs e)
        {
            if (containerArr != null)
            {
                ShowArray();
            }
            else
            {
                ShowList();
            }
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            Form_Move_Collection f = new Form_Move_Collection();

            if (f.ShowDialog() == DialogResult.OK)
            {
                double base_x = Convert.ToDouble(f.textBoxMoveX.Text);
                double base_y = Convert.ToDouble(f.textBoxMoveY.Text);
                string el = f.cmbbxItemFig.SelectedItem.ToString();
                if (containerArr != null)
                {
                    containerArr.Move((int)base_x, (int)base_y, el);
                }
                else
                {
                    containerList.Move((int)base_x, (int)base_y, el);
                }
                
            }
        }

        private void Delete_Figures_Click(object sender, EventArgs e)
        {
            if (containerArr != null)
            {
                containerArr.RemoveAll();
            }
            else
            {
                containerList.RemoveAll();
            }
        }

        private void buttonDelete_Collection_Click(object sender, EventArgs e)
        {
            if (containerArr != null)
            {
                containerArr.Delete();
                listBoxFigures.Items.Clear();
            }
            else
            {
                containerList.Delete();
                listBoxFigures.Items.Clear();
            }
            
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key

            if (keyData == Keys.W || keyData == Keys.Up)
            {
                foreach (var e in containerArr)
                {
                    e.Move(0, -17);
                }
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.S || keyData == Keys.Down)
            {
                foreach (var e in containerArr)
                {
                    e.Move(0, 17);
                }
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.A || keyData == Keys.Left)
            {
                foreach (var e in containerArr)
                {
                    e.Move(-17, 0);
                }
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.D || keyData == Keys.Right)
            {
                foreach (var e in containerArr)
                {
                    e.Move(17, 0);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button_Add_Click(object sender, EventArgs e)
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
            if (containerArr != null)
            {
                containerArr.Add(figure);
                listBoxFigures.Items.Add(figure.ToString() + $"№{listBoxFigures.Items.Count + 1}");
            }
            else
            {
                containerList.Add(figure);
                listBoxFigures.Items.Add(figure.ToString() + $"№{listBoxFigures.Items.Count + 1}");
            }
            
        }
    }
}

