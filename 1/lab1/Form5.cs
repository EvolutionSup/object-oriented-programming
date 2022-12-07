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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox1.Text;
            int num_n = 0;
            try
            {
                num_n = Convert.ToInt32(n);
                if (num_n % 3 == 0)
                {
                    result_label.Text = "N кратно трем";
                }
                else
                {
                    result_label.Text = "N не кратно трем";
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "";
                result_label.Text = "";
                Console.WriteLine(ex.Message);
            }
        }
    }
}
