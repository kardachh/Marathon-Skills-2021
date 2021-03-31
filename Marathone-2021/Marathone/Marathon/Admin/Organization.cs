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
using MySql.Data.MySqlClient;
using System.IO;
using System.Threading.Tasks;

namespace Marathon.Admin
{
    public partial class Organization : MetroForm
    {
        MySqlDataAdapter da;
        DataTable dt;
        public Organization()
        {
            InitializeComponent();
            loadData();
        }
        protected void loadData()
        {
            listViewCompany.Items.Clear();
            ImageList image = new ImageList();
            image.ImageSize = new Size(80, 40);


            Bitmap emptyImage = new Bitmap(30, 30);

            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }

            string sql = "SELECT Chаritу.CharityName, Chаritу.CharityDescription, Chаritу.CharityLogo FROM Chаritу";
            MySqlCommand command = new MySqlCommand(sql, Program.connection);
            da = new MySqlDataAdapter();
            da.SelectCommand = command;
            dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                image.Images.Add(new Bitmap(String.Format("charity/{0}", dt.Rows[i]["CharityLogo"].ToString())));

                ListViewItem listViewItem = new ListViewItem(new string[] { "", dt.Rows[i]["CharityName"].ToString(), dt.Rows[i]["CharityDescription"].ToString() });
                listViewItem.ImageIndex = i;
                listViewCompany.Items.Add(listViewItem);
            }
            image.Images.Add(emptyImage);
            listViewCompany.SmallImageList = image;
            listViewCompany.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AddOrg addorg = new AddOrg();
            addorg.Show();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            AddOrg addorg = new AddOrg();
            addorg.Show();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            AddOrg addorg = new AddOrg();
            addorg.Show();
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            AddOrg addorg = new AddOrg();
            addorg.Show();
        }
    }
}
