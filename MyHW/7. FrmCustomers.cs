using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WindowsFormsApp1.Properties;

namespace Starter
{
    public partial class FrmCustomers : Form
    {
        bool haveSelected = false;
        List<string> listFlag=new List<string>();
        Dictionary<string, int> numOfGroMem = new Dictionary<string, int>();

        public FrmCustomers()
        {
            InitializeComponent();
            LoadConutrys();
            CreatListVies();
            listView1.View = View.Details;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            tabControl1.SelectedIndex = 0;
        }

        private void LoadConutrys()
        {
          try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    
                    SqlCommand cmd = new SqlCommand("Select distinct Country from Customers", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = reader.GetSchemaTable();
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("All Countries");
                    while (reader.Read())
                    {
                        string s = reader["Country"].ToString();
                        comboBox1.Items.Add(s);
                        listFlag.Add(s);
                    }
                    comboBox1.SelectedIndex=0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"1");
            }
        }

        private void CreatListVies()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    
                    SqlCommand cmd = new SqlCommand("Select * from Customers", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = reader.GetSchemaTable();
                    for (int i = 0; i < table.Rows.Count; i++)
                    {             //columns for headers; items for contains.
                        listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"2");
            }
        }

        private void AddMemberNum()
        {
            for (int i = 0; i < numOfGroMem.Count; i++)
            {
                int n = numOfGroMem[listView1.Groups[i].Header] + 1;
                string s = $" ({n.ToString()}";
                s += n > 1 ? " members )" : " member )";
                listView1.Groups[i].Header += s;
            }
        }

        private void resetInfo()
        {
            listView1.Items.Clear();
            listView1.Groups.Clear();
            numOfGroMem.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!haveSelected)
            {
                haveSelected= true;
                OrderByID();
                return;
            }
            GroupByCountry();
        }

        private void OrderByID(string sortOrder="")
        {
            resetInfo();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = $"Select * from Customers{sortOrder}";
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string s = reader["Country"].ToString();
                        ListViewItem lVI = listView1.Items.Add(reader[0].ToString());
                        int f = listFlag.IndexOf(s);
                        f = f > 18 ? f % 18 : f; // lacks of flagImages
                        lVI.ImageIndex = f;
                        
                        if (lVI.Index %2==0)  lVI.BackColor = Color.LightBlue;
                        else                 lVI.BackColor = Color.LightGray;

                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            if (reader.IsDBNull(i))  
                                lVI.SubItems.Add("null");
                            else
                                lVI.SubItems.Add(reader[i].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "3");
            }
        }

        private void GroupByCountry(string sortOrder = "")
        {
            resetInfo();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {

                    SqlCommand cmd = new SqlCommand();
                    if (comboBox1.Text == "All Countries")
                    {
                        cmd.CommandText = $"Select * from Customers {sortOrder}";
                    }
                    else
                    {
                        cmd.CommandText = $"Select * from Customers where country = '{comboBox1.Text}' {sortOrder}";
                    }
                    cmd.Connection = conn;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string s = reader["Country"].ToString();
                        ListViewItem lVI = listView1.Items.Add(reader[0].ToString());
                        if (listView1.Groups[s] == null)
                        {
                            ListViewGroup group = listView1.Groups.Add(s, s);
                            numOfGroMem.Add(s, 0);
                            lVI.Group = group;
                            lVI.ImageIndex = listFlag.IndexOf(s);
                            int f = listFlag.IndexOf(s);
                            f = f > 18 ? f % 18 : f; // lacks of flagImages
                            lVI.ImageIndex = f;
                            lVI.BackColor = Color.LightBlue;
                        }
                        else
                        {
                            ListViewGroup group = listView1.Groups[s];
                            numOfGroMem[s]++;
                            lVI.Group = group;
                            lVI.ImageIndex = listFlag.IndexOf(s);
                            int f = listFlag.IndexOf(s);
                            f = f > 18 ? f % 18 : f; // lacks of flagImages
                            lVI.ImageIndex = f;
                            if (numOfGroMem[s] % 2 == 0) lVI.BackColor = Color.LightBlue;
                            else lVI.BackColor = Color.LightGray;
                        }

                        for (int i = 1; i < reader.FieldCount; i++)
                        {

                            if (reader.IsDBNull(i))
                                lVI.SubItems.Add("null");
                            else
                                lVI.SubItems.Add(reader[i].ToString());
                        }
                    }
                    AddMemberNum();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "4");
            }
        }

        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
                comboBox1.SelectedIndex = 0;
            else
                GroupByCountry();
        }
        private void iDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            OrderByID();
        }
        private void aSCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupOrID(" Order By 'customerID'");
        }
        private void dESCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupOrID(" Order By 'customerID' Desc");
        }
        private void aSCToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GroupOrID(" Order By 'Country'");
        }
        private void dESCToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GroupOrID(" Order By 'Country' Desc");
        }
        private void GroupOrID(string mode)
        {
            if (listView1.Groups.Count == 0)
                OrderByID(mode);
            else
                GroupByCountry(mode);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }
        
    }
}
