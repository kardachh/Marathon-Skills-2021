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
using MetroFramework;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace Marathon.Runner
{
    public partial class FormMyResults : MetroForm
    {
        public int registrationId = 0;
        bool checkCancelButton = false;
        public FormMyResults()
        {
            InitializeComponent();
            int ageUser = Program.userInfo.DateOfBirth.Year;
            labelGender.Text += Program.userInfo.Gender == "Male" ? "мужской" : "женский";
            labelAge.Text += Program.userInfo.AgeGroup == 1 ? "до 18" : Program.userInfo.AgeGroup == 2 ? "18-29" : Program.userInfo.AgeGroup == 3 ? "30-39" : Program.userInfo.AgeGroup == 4 ? "40-55" : Program.userInfo.AgeGroup == 5 ? "56-70" : "от 70";
            List<string> eventId = new List<string>();
            List<string> raceTime = new List<string>();
            listViewResults.Items.Clear();
            Program.connection.Open();
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT EventId, RaceTime, RegistrationId FROM `RegistrationEvent` WHERE `RegistrationId` = (SELECT `RegistrationId` FROM `Registration` WHERE `RunnerId` = '{Program.userInfo.RunnerId}')", Program.connection);
            ListViewItem item;
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                eventId.Add(reader.GetString("EventId"));
                raceTime.Add(reader.GetString("RaceTime"));
                registrationId = reader.GetInt32("RegistrationId");
            }
            reader.Close();
            for (int i = 0; i < eventId.Count; i++)
            {
                int position = CheckNumRunner(eventId[i]);
                int groupPosition = CheckGroupNum(eventId[i]);
                sqlCommand = new MySqlCommand($"SELECT YearHeld, CountryCode FROM Marаthоn WHERE MarathonId = (SELECT MarathonId FROM Evеnt WHERE EventId = '{eventId[i]}')", Program.connection);
                MySqlDataReader newReader = sqlCommand.ExecuteReader();
                newReader.Read();
                string lengthRun = eventId[i].ToString().Contains("FM") ? "42 км. Полный марафон" : eventId[i].ToString().Contains("FR") ? "5 км. Мини-марафон" : "21 км. Полу-марафон";
                item = new ListViewItem(new string[] { $"{newReader.GetString("YearHeld")} {newReader.GetString("CountryCode")}", lengthRun, $"{raceTime[i]} секунд", $"{position}", $"{groupPosition}" });
                listViewResults.Items.Add(item);
                newReader.Close();
            }
            Program.connection.Close();
        }
        private int CheckNumRunner(string Id)
        {
            int counter = 1;
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT RegistrationId FROM RegistrationEvent WHERE EventId = '{Id}' ORDER BY RaceTime", Program.connection);
            MySqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read() && (dataReader.GetInt32("RegistrationId") != registrationId))
            {
                counter++;
            }
            dataReader.Close();
            return counter;
        }
        private int CheckGroupNum(string Id)
        {
            int counter = 1;
            MySqlCommand sqlCommand = new MySqlCommand($"SELECT RegistrationEvent.RegistrationId FROM `RegistrationEvent`,`Registration` WHERE Registration.AgeId = {Program.userInfo.AgeGroup} AND RegistrationEvent.EventId = '11_1FM' AND Registration.RegistrationId = RegistrationEvent.RegistrationId ORDER BY RegistrationEvent.RaceTime", Program.connection);
            MySqlDataReader newDataReader = sqlCommand.ExecuteReader();
            while (newDataReader.Read() && (newDataReader.GetInt32("RegistrationId") != registrationId))
            {
                counter++;
            }
            newDataReader.Close();
            return counter;
        }
    }
}
