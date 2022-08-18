using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(nwDataSet1.Products);
            customersTableAdapter1.Fill(nwDataSet1.Customers);
            categoriesTableAdapter1.Fill(nwDataSet1.Categories);

            dataGridView1.DataSource = nwDataSet1.Products;
            dataGridView2.DataSource = nwDataSet1.Customers;
            dataGridView3.DataSource = nwDataSet1.Categories;

            listBox1.Items.Clear();
            for (int t = 0; t < nwDataSet1.Tables.Count; t++)
            {
                DataTable table = nwDataSet1.Tables[t];
                listBox1.Items.Add("<< "+ table.TableName +" >>");

                string strT = "";
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    strT += $"<{table.Columns[c].ColumnName+">",-34}";
                }
                listBox1.Items.Add(strT);

                for (int r = 0; r < table.Rows.Count; r++)
                {
                    string strC="";
                    for(int c= 0; c < table.Columns.Count; c++)
                    {
                        strC+=$"{table.Rows[r][c],-35}";
                    }
                    listBox1.Items.Add(strC);
                }
                listBox1.Items.Add("===================================================" +
                    "==================================================================" +
                    "==================================================================" +
                    "==================================================================" +
                    "==================================================================" +
                    "==================================================");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(nwDataSet1.Products.Rows[0]["ProductName"].ToString());
            MessageBox.Show(nwDataSet1.Products.Rows[0][1].ToString());  
            MessageBox.Show(nwDataSet1.Products[0].ProductName);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nwDataSet1.Products.WriteXml("Products.xml", XmlWriteMode.WriteSchema);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nwDataSet1.Products.Clear();
            nwDataSet1.Products.ReadXml("Products.xml");
            dataGridView1.DataSource = nwDataSet1.Products;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel1Collapsed = !splitContainer2.Panel1Collapsed;
        }
    }
}
