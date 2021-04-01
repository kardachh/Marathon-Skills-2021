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
using System.IO;
using System.Text.RegularExpressions;

namespace Marathon.Admin
{
    public partial class InventoryReceipt : MetroForm
    {
        private bool checkCancelButton = false;
        Inventory formInventory = new Inventory();
        public InventoryReceipt()
        {
            InitializeComponent();
            updateCountLabels();
        }
        private void updateCountLabels()
        {
            labelCount1.Text = formInventory.counts[0].ToString();
            labelCount2.Text = formInventory.counts[1].ToString();
            labelCount3.Text = formInventory.counts[2].ToString();
        }

        private void InventoryReceipt_Load(object sender, EventArgs e)
        {

        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {

            TextBox[] textBoxes = new TextBox[3] { textBoxA, textBoxB, textBoxC };
            Label[] labelsInfo = new Label[3] { labelInfo1, labelInfo2, labelInfo3 };
            int i = 0;
            Program.connection.Open();
            foreach (TextBox textBox in textBoxes)
            {
                if (textBox.Text != "")
                {
                    if (Regex.IsMatch(textBox.Text, @"^-+\d+$"))
                    {
                        if (formInventory.counts[i] >= Math.Abs(Convert.ToInt32(textBox.Text)))
                        {
                            labelsInfo[i].Text = "";
                            int sum = formInventory.counts[i] + Convert.ToInt32(textBox.Text);
                            string sql = $"UPDATE racеkitоption  SET Count={sum} WHERE RaceKitOptionId = '{formInventory.Ids[i]}'";
                            MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                            sqlCommand.ExecuteNonQuery();
                            labelsInfo[i].Text = $"\nДанные обновленны для комплекта {formInventory.Ids[i]}!";
                        }
                        else
                        {
                            labelsInfo[i].Text = $"\nДанные превышают количество существующее количество для комплекта {formInventory.Ids[i]}!";
                        }
                    }
                    else if (Regex.IsMatch(textBox.Text, @"^[^-]\d+$"))
                    {
                        labelsInfo[i].Text = "";
                        int sum = formInventory.counts[i] + Convert.ToInt32(textBox.Text);
                        string sql = $"UPDATE racеkitоption SET Count={sum} WHERE RaceKitOptionId = '{formInventory.Ids[i]}'";
                        MySqlCommand sqlCommand = new MySqlCommand(sql, Program.connection);
                        sqlCommand.ExecuteNonQuery();
                        labelsInfo[i].Text = $"\nДанные обновленны для комплекта {formInventory.Ids[i]}!";
                    }
                }
                else
                {
                    labelsInfo[i].Text = $"\nЯчейка для {formInventory.Ids[i]} заполненна не верно!";
                }

                i++;
            }

            Program.connection.Close();
            this.formInventory.updateCounts();
            this.updateCountLabels();
        }

        private void metroButtonCancel_Click(object sender, EventArgs e)
        {
            this.checkCancelButton = true;
            Inventory inv = new Inventory();
            this.Close();
        }
    }
}
