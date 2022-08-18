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



namespace MyHomeWork
{
    public partial class FrmCategoryProducts : Form
    {
        public FrmCategoryProducts()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter("select CategoryName from Categories", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow row in ds.Tables[0].Rows)
                comboBox2.Items.Add(row[0]);

            using (conn)
            {   
                SqlCommand cmd = new SqlCommand("select CategoryName from Categories", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["CategoryName"]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cateName = comboBox1.SelectedItem.ToString();

            SqlConnection conn = null;
            try
            {             
                conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
                string cmdStr = "Select * from Products p join Categories c on p.CategoryID = c.CategoryID where CategoryName = '" + cateName + "'";
                SqlCommand cmd = new SqlCommand(cmdStr, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                listBox1.Items.Clear();

                while (reader.Read())
                {
                    string s = $"{reader["ProductName"],-40} - {reader["UnitPrice"]:C2}";
                    
                    listBox1.Items.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connDisC = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            string cateName = comboBox2.SelectedItem.ToString();
            string cmdStr = "Select ProductName, UnitPrice from Products p join Categories c on p.CategoryID = c.CategoryID where CategoryName = '" + cateName + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmdStr,connDisC);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
