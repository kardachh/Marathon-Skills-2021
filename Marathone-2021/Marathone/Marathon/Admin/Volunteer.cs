using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace Marathon.Admin
{
    public partial class Volunteer : MetroForm
    {
        public Volunteer()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 102, 102);

            string script = "Select COUNT(*) from Volunteеr";
            MySqlDataAdapter ms_data = new MySqlDataAdapter(script, Program.connection);
            Program.connection.Open();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT FirstName, LastName, CountryCode, Gender FROM Volunteеr", Program.connection);
                DataSet DS = new DataSet();
                da.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Страна";
                dataGridView1.Columns[3].HeaderText = "Пол";
            }
            finally
            {
                Program.connection.Close();
            }
        }

        private void Update(int i)
        {
            Program.connection.Open();
            try
            {
                string[] words = { "FirstName", "LastName", "CountryCode", "Gender" };
                string sql = $"SELECT FirstName, LastName, CountryCode, Gender FROM Volunteеr ORDER BY {words[i]}";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, Program.connection);
                DataSet DS = new DataSet();
                da.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Страна";
                dataGridView1.Columns[3].HeaderText = "Пол";
            }
            finally
            {
                Program.connection.Close();
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Loadvolunteer loadvolunteer = new Loadvolunteer();
            loadvolunteer.Show();
            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Update(metroComboBox1.SelectedIndex);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            Loadvolunteer loadvolunteer = new Loadvolunteer();
            loadvolunteer.Show();
            this.Close();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
