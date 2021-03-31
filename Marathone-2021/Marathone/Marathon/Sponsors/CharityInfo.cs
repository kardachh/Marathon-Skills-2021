using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace Marathon.Sponsors
{
    public partial class CharityInfo : MetroFramework.Forms.MetroForm
    {
        public CharityInfo()
        {
            string NameLogo = "";
           string startPath = Application.StartupPath + "\\Charity\\";
            InitializeComponent();
            Program.connection.Open();//необходимая команда MySql
            MySqlCommand chart = new MySqlCommand("SELECT CharityName, CharityDescription, CharityLogo FROM Chаritу WHERE CharityId =\"" + AddSponsors.charity + "\"  ", Program.connection);
            MySqlDataReader chartreader = chart.ExecuteReader();
            while (chartreader.Read())
            {
                NameLogo = chartreader.GetString("CharityLogo");
                metroLabel1.Text = chartreader.GetString("CharityName");
                metroLabel2.Text = chartreader.GetString("CharityDescription");
            }
            //var bit = new Bitmap(startPath + NameLogo);
            //pictureBox1.Image = bit;
            Program.connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
