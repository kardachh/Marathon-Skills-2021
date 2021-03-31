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
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace Marathon
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 23);
        public Login()
        {
            InitializeComponent();
            this.Resizable = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != "" && metroTextBox2.Text != "")
            {
                try
                {
                        Program.connection.Open();
                        string sql = String.Format("SELECT * FROM Usеr WHERE Email='{0}' AND Password='{1}'", metroTextBox1.Text, metroTextBox2.Text);
                        MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Email = Program.sqlDataReader.GetString("Email");
                        Program.userInfo.Password = Program.sqlDataReader.GetString("Password");
                        Program.userInfo.FirstName = Program.sqlDataReader.GetString("FirstName");
                        Program.userInfo.LastName = Program.sqlDataReader.GetString("LastName");
                        Program.userInfo.RoleId = Program.sqlDataReader.GetString("RoleId");
                        Program.sqlDataReader.Close();
                        
                        if (Program.userInfo.RoleId == "R")
                        {
                        sqlCommand = new MySqlCommand($"SELECT RunnerId, Gender, CountryCode, DateOfBirth, IsCheckROM FROM Runnеr WHERE Email='{metroTextBox1.Text}'", Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.Gender = Program.sqlDataReader.GetString("Gender");
                        Program.userInfo.CountryCode = Program.sqlDataReader.GetString("CountryCode");
                        Program.userInfo.DateOfBirth = Program.sqlDataReader.GetDateTime("DateOfBirth");
                        Program.userInfo.RunnerId = Program.sqlDataReader.GetInt32("RunnerId");
                        Program.userInfo.checkIsRegisterOnMarafon = Program.sqlDataReader.GetBoolean("IsCheckROM");
                        Program.sqlDataReader.Close();
                        DateTime Age = Program.userInfo.DateOfBirth;
                        Program.userInfo.AgeGroup = Age.Year > 2003 ? 1 : Age.Year > 1991 ? 2 : Age.Year > 1981 ? 3 : Age.Year > 1964 ? 4 : Age.Year > 1950 ? 5 : 6;
                        sqlCommand = new MySqlCommand($"SELECT CountryName FROM Cоuntry WHERE CountryCode='{Program.userInfo.CountryCode}'", Program.connection);
                        Program.sqlDataReader = sqlCommand.ExecuteReader();
                        Program.sqlDataReader.Read();
                        Program.userInfo.CountryName = Program.sqlDataReader.GetString("CountryName");
                        Program.connection.Close();
                        Runner.RunnerAuthMenu ram = new Runner.RunnerAuthMenu(this.metroTextBox1.Text);
                            ram.Show();
                            this.Close();
                            Program.connection.Close();
                        }
                        if (Program.userInfo.RoleId == "A")
                        {
                            Admin.AdminMenu am = new Admin.AdminMenu();
                            am.Show();
                            this.Close();
                            Program.connection.Close();
                        }
                        if (Program.userInfo.RoleId == "C")
                        {
                            Coordinator.runed cm = new Coordinator.runed();
                            cm.Show();
                            this.Close();
                            Program.connection.Close();
                        }
                        this.Close();
                }
                catch
                {
                    MessageBox.Show("Не верные Email или пароль", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Program.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!", "Закрыть", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    }
