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
using Microsoft.VisualBasic.FileIO;

namespace Marathon.Admin
{
    public partial class Loadvolunteer : MetroForm
    {
        public OpenFileDialog fileInfo;
        bool checkImport = false;
        public Loadvolunteer()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            fileInfo = new OpenFileDialog();
            fileInfo.Filter = "Файлы CSV|*.csv";
            fileInfo.Multiselect = false;
            if (fileInfo.ShowDialog() != DialogResult.OK) return;
            metroTextBox1.Text = fileInfo.FileName.ToString();
            checkImport = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Volunteer vt = new Volunteer();
            vt.Show();
            this.Close();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {

            if (checkImport == true)
            {
                int count = 0;
                try
                {
                    using (TextFieldParser parser = new TextFieldParser(fileInfo.FileName))
                    {
                        parser.TextFieldType = FieldType.Delimited;
                        parser.SetDelimiters(",");
                        Program.connection.Open();
                        while (!parser.EndOfData)
                        {
                            string[] fields = parser.ReadFields();
                            if (count != 0)
                            {
                                switch (fields[4])
                                {
                                    case "F":
                                        fields[4] = "Female";
                                        break;
                                    case "M":
                                        fields[4] = "Male";
                                        break;
                                }
                                string sql = $"INSERT INTO Volunteer (VolunteerId, FirstName, LastName, CountryCode, Gender) VALUES ('{fields[0]}', '{fields[1]}', '{fields[2]}', '{fields[3]}', '{fields[4]}')";
                                MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                                sqlCommand.ExecuteNonQuery();
                                count++;
                            }
                            else { count++; }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка, обратитесь к администратору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    metroLabel2.Visible = true;
                    metroLabel2.Text = "Успешно добавлено: " + count;
                    Program.connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Для начало загрузите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
