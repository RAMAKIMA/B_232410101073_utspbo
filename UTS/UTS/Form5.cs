namespace UTS
{
    public partial class Form5 : Form
    {
        private Form4 _form4; // Field untuk menyimpan referensi Form4 yang aktif

        public Form5(Form4 form4)
        {
            InitializeComponent();
            _form4 = form4; // Simpan referensi Form4 yang diterima
        }



        public Tugas getTugas()
        {
            Tugas tugasBaru = new Tugas
            {
                judul = textBox1.Text,
                deskripsi = textBox2.Text,
                deadline = textBox3.Text
            };

            return tugasBaru;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _form4.AddTugas(getTugas()); // Tambahkan data ke Form4 yang sedang aktif
            this.Hide();
            _form4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form1 = new Form4();
            this.Hide();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
