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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_label.Text = "";
            string n = textBox1.Text;
            int num_n = 0;
            try
            {
                num_n = Convert.ToInt32(n);
                dataGridView1.RowCount = num_n;
                dataGridView1.ColumnCount = num_n;
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                Console.WriteLine(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            error_label.Text = "";
            result_label.Text = "";

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

                bool symm = true;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr[i, j] != arr[j, i])
                        {
                            symm = false;
                        }
                    }
                }
                if (symm)
                {
                    result_label.Text = "Введенная матрица симметрична";
                }
                else
                {
                    result_label.Text = "Введенная матрица несимметрична";
                }
            }
            catch (Exception ex)
            {
                error_label.Text = "Введите в матрицу числа";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
