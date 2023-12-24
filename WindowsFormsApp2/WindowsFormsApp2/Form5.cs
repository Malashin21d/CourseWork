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
    public partial class Form5 : Form
    {
        Hote_BusinessEntities db;
        public Form5()
        {
            db = new Hote_BusinessEntities();
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hote_BusinessDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hote_BusinessDataSet.Rooms);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Rooms ro = new Rooms();
            if (textBox4.Text == "Да" || textBox4.Text == "Нет")
            {
                ro.name_hotel = textBox1.Text;
                ro.number_room = int.Parse(textBox2.Text);
                ro.price = int.Parse(textBox3.Text);
                ro.Employment = textBox4.Text;
                ro.departure_date = DateTime.Parse(dateTimePicker1.Text);
                db.Rooms.Add(ro);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ошибка в сточках");
            }
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
