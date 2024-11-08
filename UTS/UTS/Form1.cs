namespace UTS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text != "")
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form1 = new Form2();

            this.Hide();

            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();

            this.Hide();

            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();

            this.Hide();

            form6.Show();
        }
    }
}
