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

namespace MyHomeWork
{
    public partial class FrmAdventureWorks : Form
    {
        bool sortBy = true;
        public FrmAdventureWorks()
        {
            InitializeComponent();
            LoadDataGridView();
            LoadComboBox();
        }

        private void LoadDataGridView()
        {
            productPhotoTableAdapter.Fill(advantureWork2019.ProductPhoto);
            bindingSource1.DataSource = advantureWork2019.ProductPhoto;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            button13.Enabled = button14.Enabled = false;
            dataGridView1.CurrentCellChanged += dataGridView1_CurrentCellChanged;
        }

        private void LoadComboBox()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=AdventureWorks2019;Integrated Security=true");
            SqlDataAdapter adapter = new SqlDataAdapter("Select Distinct Datepart(yyyy,ModifiedDate) as DateTime from Production.ProductPhoto", conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            comboBox1.Items.Add("All Years");
            foreach (DataRow row in ds.Tables[0].Rows)
                comboBox1.Items.Add(row[0]);
            comboBox1.SelectedIndex = 0;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            label4.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
            if (bindingSource1.Position == 0)
            {
                button13.Enabled = button14.Enabled = false;
                button15.Enabled = button16.Enabled = true;
            }
            else if (bindingSource1.Position == bindingSource1.Count - 1)
            {
                button15.Enabled = button16.Enabled = false;
                button13.Enabled = button14.Enabled = true;
            }
            else
            {
                button13.Enabled = button14.Enabled = button15.Enabled = button16.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime star = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            productPhotoTableAdapter.FillByTimePicker(advantureWork2019.ProductPhoto, star, end);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(sortBy)
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
            else
                dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Descending);
            sortBy = !sortBy;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string yyyy = comboBox1.Text;
            if (yyyy=="All Years")
            {
                LoadDataGridView();
            }
            else
            {
                productPhotoTableAdapter.FillByYYYY(advantureWork2019.ProductPhoto, yyyy);
            }
            
        }
    }
}
