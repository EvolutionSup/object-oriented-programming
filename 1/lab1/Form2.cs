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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_label.Text = "";
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            float num_a = 0; float num_b = 0; float num_c = 0; float P = 0;
            try
            {
                num_a = float.Parse(a);
                num_b = float.Parse(b);
                num_c = float.Parse(c);
                P = (Math.Max(num_a, Math.Max(num_b, num_c)) - Math.Min(num_a, Math.Max(num_b, num_c))) / 2;
                result_label.Text = P.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
