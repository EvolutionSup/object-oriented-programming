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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;
            int m = dataGridView1.Columns.Count;
            var rand = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(101);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Count;
            int m = dataGridView1.Columns.Count;
            dataGridView2.RowCount = m;
            dataGridView2.ColumnCount = n;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[j].Cells[m - i - 1].Value;
                }
            }
        }
    }
}
