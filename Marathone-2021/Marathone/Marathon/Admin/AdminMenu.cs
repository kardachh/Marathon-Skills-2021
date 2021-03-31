using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace Marathon.Admin
{
    public partial class AdminMenu : MetroForm
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Volunteer volunteer = new Volunteer();
            volunteer.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AdminUser user = new AdminUser();
            user.Show();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Organization org = new Organization();
            org.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            AdminUser user = new AdminUser();
            user.Show();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            Volunteer volunteer = new Volunteer();
            volunteer.Show();
        }

        private void metroButton3_Click_1(object sender, EventArgs e)
        {
            Organization org = new Organization();
            org.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
        }
    }
}
