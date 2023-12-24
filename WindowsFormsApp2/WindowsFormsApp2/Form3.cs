using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {

        Hote_BusinessEntities db;
        public Form3()
        {
            db = new Hote_BusinessEntities();
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hote_BusinessDataSet.Guest". При необходимости она может быть перемещена или удалена.
            this.guestTableAdapter.Fill(this.hote_BusinessDataSet.Guest);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guest gu = new Guest();
            gu.FCs = textBox1.Text;
            gu.name_hotel = textBox2.Text;
            gu.date_of_entry = DateTime.Parse(dateTimePicker1.Text);
            gu.departure_date = DateTime.Parse(dateTimePicker2.Text);
            gu.number_of_room = Convert.ToInt32(textBox3.Text);
            gu.phone_number = textBox4.Text;
            db.Guest.Add(gu);
            db.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();

        }
    }
}
