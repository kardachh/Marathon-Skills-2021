using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Marathon.Runner
{
    public partial class RunnerRegister : MetroForm
    {
        string image;
        TimeSpan d = new TimeSpan();
        DateTime date = new DateTime(2021, 3, 23);
        public RunnerRegister()
        {
            InitializeComponent();
            this.Resizable = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            timer1.Start();
            Program.connection.Open();
            MySqlCommand newcommand = new MySqlCommand("SELECT DISTINCT CountryCode FROM Cоuntry", Program.connection);
            MySqlDataReader reader = newcommand.ExecuteReader();
            while (reader.Read())
            {
                metroComboBox1.Items.Add(reader.GetString("CountryCode"));
            }
            Program.connection.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            d = date - DateTime.Now;
            metroLabel1.Text = "До начала марафона осталось: " + d.Days + " д. " + d.Hours + " ч. " + d.Minutes + " мин. " + d.Seconds + " с. ";
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox2.Text != "")
            {
                if (metroTextBox4.Text.Length != 0 && metroTextBox5.Text.Length != 0 && metroDateTime1.Text.Length != 0 && metroComboBox1.Text.Length != 0)
                {
                    if (metroTextBox2.Text.Length >= 6)
                    {

                        if (CheckForCorrectData())
                        {
                            if (metroTextBox2.Text == metroTextBox3.Text)
                            {
                                Program.connection.Open();
                                MySqlCommand command = new MySqlCommand("INSERT INTO Usеr (Email, Password, FirstName, LastName, RoleId) VALUES (@login, @password, @firstname, @lastname, @role)", Program.connection);
                                command.Parameters.AddWithValue("@login", metroTextBox1.Text);
                                command.Parameters.AddWithValue("@password", metroTextBox2.Text);
                                command.Parameters.AddWithValue("@firstname", metroTextBox4.Text);
                                command.Parameters.AddWithValue("@lastname", metroTextBox5.Text);
                                command.Parameters.AddWithValue("@role", "R");
                                command.Prepare();
                                command.ExecuteNonQuery();
                                Program.connection.Close();
                                Program.connection.Open();
                                var gender = "";
                                if (metroRadioButton1.Checked)
                                {
                                    gender = "Male";
                                }
                                else
                                {
                                    gender = "Female";
                                }
                                MySqlCommand command1 = new MySqlCommand("INSERT INTO Runnеr (Email,Gender,DateOfBirth,CountryCode,image) values(@login,@gender,@dateOfBirth,@countryCode,@image)", Program.connection);
                                command1.Parameters.AddWithValue("@login", metroTextBox1.Text);
                                command1.Parameters.AddWithValue("@gender", gender);
                                command1.Parameters.AddWithValue("@dateOfBirth", metroDateTime1.Value);
                                command1.Parameters.AddWithValue("@countryCode", metroComboBox1.Text);
                                command1.Parameters.AddWithValue("@image", image);
                                command1.Prepare();
                                Program.connection.Close();
                                MetroMessageBox.Show(this, "Вы успешно зарегистрированы!");
                                this.Hide();
                            }
                     
                            else
                            {
                                MetroMessageBox.Show(this, "Введенные пароли не совпадают!");
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Корректно введите Email!");
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Введённый пароль слишком короткий!");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Один из параметров не введён!");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Пароль не подходит к требованиям!");
            }
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckForCorrectData()
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,17})+)$"; ;
            return Regex.IsMatch(metroTextBox1.Text, pattern);
        }
        private void metroTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar == 33 || e.KeyChar == 35 || e.KeyChar == 64 || e.KeyChar == 36 || e.KeyChar == 94)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 33 || e.KeyChar == 35 || e.KeyChar == 64 || e.KeyChar == 36 || e.KeyChar == 94)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox4_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private void metroTextBox5_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
        }

        private Random _random = new Random(Environment.TickCount);

        public string RandomString(int length)
        {
            string chars = "0123456789abcdefghijklmnopqrstuvwxyz";
            StringBuilder builder = new StringBuilder(length);

            for (int i = 0; i < length; ++i)
                builder.Append(chars[_random.Next(chars.Length)]);

            return builder.ToString();
        }
        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                File.Delete(image);
            }
            var ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string newFileName = RandomString(10) + ".jpg";
                var bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                metroTextBox6.Text = ofd.FileName;
                string directory = AppDomain.CurrentDomain.BaseDirectory;
                string path = ofd.FileName;
                string newPath = directory + newFileName;
                FileInfo fileInf = new FileInfo(path);
                if (fileInf.Exists)
                {
                    fileInf.CopyTo(newPath, true);
                    image = newFileName;
                    // альтернатива с помощью класса File
                    // File.Copy(path, newPath, true);
                }
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            if(image != null)
            {
                File.Delete(image);
            }
            Close();
        }
    }
}
