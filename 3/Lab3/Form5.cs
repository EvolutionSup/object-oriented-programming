using FiguresLib;
using System;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int r = int.Parse(circ_r.Text);
                if (Init.figuresListBox.SelectedIndex != -1)
                {
                    Figure figure = (Figure)Init.figuresListBox.SelectedItem;
                    if (figure.ToString() == "FiguresLib.Circle")
                    {
                        if (Init.Coords_check(figure.x, figure.y, r * 2, r * 2))
                        {
                            figure.w = r * 2;
                            figure.h = r * 2;
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
                        MessageBox.Show("Вы выбрали не окружность.");
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
