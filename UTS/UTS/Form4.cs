using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS
{

    public partial class Form4 : Form
    {

        List<Tugas> list = new List<Tugas>();
        public Form4()
        {
            InitializeComponent();
            Tugas tugas1 = new Tugas();
            tugas1.judul = "PBO";
            tugas1.deskripsi = "Membuat Database Menggunakan Datagridview";
            tugas1.deadline = "Rabu, 23:59 WIB";
            list.Add(tugas1);

            Tugas tugas2 = new Tugas();
            tugas2.judul = "OOD";
            tugas2.deskripsi = "Membuat Class Diagram";
            tugas2.deadline = "Minggu, 22:00 WIB";
            list.Add(tugas2);

            Tugas tugas3 = new Tugas();
            tugas3.judul = "APS";
            tugas3.deskripsi = "Revisi Sequence & Collaboration";
            tugas3.deadline = "Selasa, 23:59 WIB";
            list.Add(tugas3);

            Tugas tugas4 = new Tugas();
            tugas4.judul = "PKB";
            tugas4.deskripsi = "Membuat Code Perceptron";
            tugas4.deadline = "Senin, 23:59 WIB";
            list.Add(tugas4);

            Tugas tugas5 = new Tugas();
            tugas5.judul = "Riset Operasi";
            tugas5.deskripsi = "Membuat PPT Tentang Teori Antri";
            tugas5.deadline = "Selasa, 00:00 WIB";
            list.Add(tugas5);

            dataGridView1.DataSource = list;
        }

        public void AddTugas(Tugas tugas)
        {
            list.Add(tugas);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 TambahData = new Form5(this);

            this.Hide();

            TambahData.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }

    public class Tugas
    {
        public string judul { get; set; }
        public string deskripsi { get; set; }
        public string deadline { get; set; }
    }
}
