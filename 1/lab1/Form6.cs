using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string m = textBox1.Text;
            string n = textBox2.Text;
            int num_m = 0; int num_n = 0;
            try
            {
                num_m = Convert.ToInt32(m);
                num_n = Convert.ToInt32(n);
                dataGridView1.RowCount = num_m;
                dataGridView1.ColumnCount = num_n;
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                Console.WriteLine(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            error_label.Text = "";

            int n = dataGridView1.Rows.Count;
            int m = dataGridView1.Columns.Count;
            double[,] arr = new double[n, m];
            try
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                double count = 0;
                for (int i = 0; i < n; i++)
                {
                    double max_x = 0;
                    for (int j = 0; j < m; j++)
                    {
                        if (j == 0 || max_x < arr[i, j])
                        {
                            max_x = arr[i, j];
                        }
                    }
                    count += max_x;
                }
                label3.Text = "Сумма = " + count.ToString();
            }
            catch (Exception ex)
            {
                error_label.Text = "Введите в матрицу числа";
                label3.Text = "Сумма = ";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
