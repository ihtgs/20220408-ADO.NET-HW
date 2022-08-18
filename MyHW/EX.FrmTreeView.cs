using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyHW.Properties;

namespace MyHW
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
            LoadNodes();
            treeView1.NodeMouseClick += showListView;
        }

        private void LoadNodes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "Select country, city, customerID from Customers order By Country, City ";
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    HashSet<string> h1 = new HashSet<string>();
                    HashSet<string> h2 = new HashSet<string>();
                    TreeNode n1 = new TreeNode();
                    TreeNode n2 = new TreeNode();
                    TreeNode n3 = new TreeNode();
                    int count = 0;
                    while (reader.Read())
                    {
                        string s1 = reader["country"].ToString();
                        string s2 = reader["city"].ToString();
                        string s3 = reader["customerID"].ToString();
                        if (h1.Add(s1))
                        {
                            n1 = treeView1.Nodes.Add(s1);
                            n1.Name = s1;
                            n2 = new TreeNode(s2);
                            n2.Name = s2;
                            h2.Add(s2);
                            n3 = new TreeNode(s3);
                            n3.Name = s3;
                            n2.Nodes.Add(n3);
                            n1.Nodes.Add(n2);
                            count++;
                        }
                        else
                        {
                            if (!h2.Add(s2))
                            {
                                n3 = new TreeNode(s3);
                                n3.Name = s3;
                                n2.Nodes.Add(n3);
                                count++;
                            }
                            else
                            {
                                n2 = new TreeNode(s2);
                                n2.Name = s2;
                                h2.Add(s2);
                                n3 = new TreeNode(s3);
                                n3.Name = s3;
                                n2.Nodes.Add(n3);
                                n1.Nodes.Add(n2);
                                count++;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            foreach (TreeNode n1 in treeView1.Nodes)
            {
                int count = 0;
                n1.Text += $" (含 {n1.Nodes.Count.ToString()} 個城市，";
                ;
                foreach (TreeNode n2 in n1.Nodes)
                {
                    int num2 = n2.Nodes.Count;
                    n2.Text += $" (含 {num2.ToString()} 個客戶)";
                    count += num2;
                }
                n1.Text += $" {count} 個客戶)";
            }
        }

        

        private void showListView(object sender, TreeNodeMouseClickEventArgs e)
        {
            listView1.Clear();
            TreeNode n = e.Node;

            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.NorthwindConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (n.Parent == null)
                    {
                        listView1.View = View.List;
                        cmd.CommandText = $"select distinct city from customers where country='{n.Name}'"; conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        listView1.Items.Add($"國家<{n.Name}>中的客戶所在城市如下：");
                        listView1.Items.Add("============================================");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {   
                                string s = $"城市：{reader[i]}";
                                listView1.Items.Add(s);
                            }
                        }
                    }
                    else if (n.Parent.Parent == null)
                    {
                        listView1.View = View.List;
                        cmd.CommandText = $"select CustomerID + '  ('+CompanyName +')' from customers where city='{n.Name}'";
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        listView1.Items.Add($"國家<{n.Parent.Name}>城市<{n.Name}>中的客戶如下：");
                        listView1.Items.Add("============================================");
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string s = $"客戶ID：{reader[i]}";
                                listView1.Items.Add(s);
                            }
                        }
                    }
                    else
                    {
                        listView1.View = View.Details;
                        showLiveBoxTitle();
                        cmd.CommandText = $"select * from customers where customerID='{n.Text}'";
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        ListViewItem lvi = listView1.Items.Add(n.Text);
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            if (reader.IsDBNull(i))
                                lvi.SubItems.Add("null");
                            else
                                lvi.SubItems.Add(reader[i].ToString());
                        }
                        listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showLiveBoxTitle()
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
                    {           
                        listView1.Columns.Add(table.Rows[i][0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool flag = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                treeView1.ExpandAll();
                treeView1.SelectedNode = treeView1.Nodes[0];
                button1.Text = "全部收闔";
            }
            else
            {
                treeView1.Nodes[0].Collapse();
                //treeView1.CollapseAll();
                button1.Text = "全部展開";
            }
            flag = !flag;
        }


    }
}
