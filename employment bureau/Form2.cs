using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employment_bureau

{
    public partial class Form2 : Form
    {
     
        public int applicantId { get => applicantId; set => applicantId = value; }
        public string firstName { get => firstName; set => firstName = value; } 
        public int KOAid {get => KOAid; set => KOAid = value; }
        public string lastName { get => lastName; set => lastName = value; }
        public string phoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string skill { get => skill; set => skill = value; }
        public Form2()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
           SQLiteConnection con = new SQLiteConnection(@"data source=E:\politeh\2022 industrial practice\application\employment bureau\employment bureau\EB.db");
            con.Open();
            string query = "SELECT* from applicants";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

           dataGridView1.DataSource = dt;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ApplicantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}
