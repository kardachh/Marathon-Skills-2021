﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
namespace Marathon.Admin
{
    public partial class AdminUser : MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 20);
        public AdminUser()
        {
            InitializeComponent();
            this.Resizable = false;
            this.MaximizeBox = false;
            timer1.Start();
            metroGrid1.ReadOnly = true;
            metroGrid1.BackgroundColor = Color.WhiteSmoke;
            metroGrid1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(102, 102, 102);
            try
            {
                Program.connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Email, FirstName, Lastname, RoleId FROM Usеr ORDER BY RoleId ASC", Program.connection);
                DataSet DS = new DataSet();
                da.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Columns[0].HeaderText = "Email";
                metroGrid1.Columns[1].HeaderText = "Фамилия";
                metroGrid1.Columns[2].HeaderText = "Имя";
                metroGrid1.Columns[3].HeaderText = "Роль";
                MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(Email) FROM Usеr", Program.connection);
                countCommand.Prepare();
                var value = countCommand.ExecuteScalar();
                metroLabel3.Text = "Участников: " + value.ToString();
            }
            finally
            {
                Program.connection.Close();
            }
            metroComboBox1.Text = "Администратор";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string role = "A";
                if (metroComboBox1.SelectedIndex == 1) { role = "C"; }
                else if (metroComboBox1.SelectedIndex == 2) { role = "R"; }
                Program.connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Email, FirstName, Lastname, RoleId FROM Usеr WHERE RoleId =\"" + role + "\"", Program.connection);
                DataSet DS = new DataSet();
                da.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Columns[0].HeaderText = "Email";
                metroGrid1.Columns[1].HeaderText = "Фамилия";
                metroGrid1.Columns[2].HeaderText = "Имя";
                metroGrid1.Columns[3].HeaderText = "Роль";
                MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(Email) FROM Usеr WHERE RoleId =\"" + role + "\"", Program.connection);
                countCommand.Prepare();
                var value = countCommand.ExecuteScalar();
                metroLabel3.Text = "Участников: " + value.ToString();
            }
            finally
            {
                Program.connection.Close();
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Program.connection.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT Email, FirstName, Lastname, RoleId FROM Usеr ORDER BY RoleId ASC", Program.connection);
                DataSet DS = new DataSet();
                da.Fill(DS);
                metroGrid1.DataSource = DS.Tables[0];
                metroGrid1.Columns[0].HeaderText = "Email";
                metroGrid1.Columns[1].HeaderText = "Фамилия";
                metroGrid1.Columns[2].HeaderText = "Имя";
                metroGrid1.Columns[3].HeaderText = "Роль";
                MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(Email) FROM Usеr", Program.connection);
                countCommand.Prepare();
                var value = countCommand.ExecuteScalar();
                metroLabel3.Text = "Участников: " + value.ToString();
            }
            finally
            {
                Program.connection.Close();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Admin.AddUser add = new AddUser();
            add.Show();
        }

        private void metroGrid1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            string index = metroGrid1.SelectedCells[0].Value.ToString();
            Admin.EditUser eu = new Admin.EditUser(index);
            eu.Show();
        }
    }
}
