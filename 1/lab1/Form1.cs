namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
        }

    }
}