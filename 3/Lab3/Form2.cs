using FiguresLib;
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void change_rect_Click(object sender, EventArgs e)
        {
            try
            {
                int w = int.Parse(change_rect_w.Text);
                int h = int.Parse(change_rect_h.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.ToString() == "FiguresLib.Rectangle")
                    {
                        if (Init.Coords_check(figure.x, figure.y, w, h))
                        {
                            figure.w = w;
                            figure.h = h;
                            figure.DeleteF(figure, false);
                            figure.Draw();
                        }
                        else
                        {
                            MessageBox.Show("Фигура вышла за границы.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы выбрали не прямоугольник.");
                    }
                }
                else
                    {
                        MessageBox.Show("Вы не выбрали фигуру.");
                    }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
            }
        }
    }
}
