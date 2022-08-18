using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHomeWork
{
    public partial class FrmProducts : Form
    {
        int p1, p2;
        public FrmProducts()
        {
            InitializeComponent();
            productsTableAdapter1.Fill(nwDataSet1.Products);
            bindingSource1.DataSource = nwDataSet1.Products;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            button1.Enabled = button13.Enabled=false;
            textBox1.KeyPress += txtInputCheck;
            textBox2.KeyPress += txtInputCheck;
            lblResult.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            label2.Text = $"{bindingSource1.Position + 1} / {bindingSource1.Count}";
            if (bindingSource1.Position == 0)
            {
                button1.Enabled = button13.Enabled = false;
                button14.Enabled = button15.Enabled = true;
            }
            else if (bindingSource1.Position == bindingSource1.Count-1)
            {
                button14.Enabled = button15.Enabled = false;
                button1.Enabled = button13.Enabled= true;
            }
            else
            {
                button1.Enabled = button13.Enabled = button14.Enabled = button15.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNum())
            {
                productsTableAdapter1.FillByUnitPrice(nwDataSet1.Products, p1, p2);
                bindingSource1.DataSource = nwDataSet1.Products;
                dataGridView1.DataSource = bindingSource1;
                bindingNavigator1.BindingSource = bindingSource1;
                lblResult.Text = $"Search結果 {bindingSource1.Count} 筆";
                lblResult.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = $"%{textBox3.Text}%";
            productsTableAdapter1.FillByProName(nwDataSet1.Products, name);
            bindingSource1.DataSource = nwDataSet1.Products;
            dataGridView1.DataSource = bindingSource1;
            bindingNavigator1.BindingSource = bindingSource1;
            lblResult.Text = $"Search結果 {bindingSource1.Count} 筆";
            lblResult.Visible = true;
        }

        private void txtInputCheck(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (e.KeyChar != '\b' && (e.KeyChar < '0' || e.KeyChar > '9'))
                e.Handled = true;
        }

        private bool isNum()
        {
            if (int.TryParse(textBox1.Text, out p1) && int.TryParse(textBox2.Text, out p2))
                return true;
            else
                MessageBox.Show("請輸入數值");
            return false;
        }
    }
}
