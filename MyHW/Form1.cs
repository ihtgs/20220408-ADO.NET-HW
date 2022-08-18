using MyHomeWork;
using MyHW;
using Starter;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace HomeWork_All
{
    public partial class Form1 : Form
    {
        string[] titleForButton = { "1.FrmHomeWork", "2.FrmCategoryProducts", "3.FrmProducts",
            "4.FrmListBox", "5.FrmAdventureWorks","6.FrmMyAlbum_V2","7.FrmCustomers","Ex.FrmTreeView"};
        Button[] btn ;
        bool created = false;

        public Form1()
        {
            InitializeComponent();
            CreateButton();
        }

        private void CreateButton()
        {
            btn = new Button[titleForButton.Length];
            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                btn[i].Location = new Point(19, 1 + i * 50);
                btn[i].Size = new Size(150, 30);
                btn[i].BackColor = Color.Black;
                btn[i].ForeColor = Color.White;
                if (i == btn.Length - 1)
                {
                    btn[i].BackColor = Color.DarkBlue;
                    btn[i].ForeColor = Color.NavajoWhite;
                }
                btn[i].Text = titleForButton[i];
                this.splitContainer2.Panel1.Controls.Add(btn[i]);
                btn[i].Click += new EventHandler(btnClick);
            }
            created = true;
        }

        private void splitContainer2_Panel1_Resize(object sender, EventArgs e)
        {
            if (created) 
                for(int i=0;i<btn.Length;i++)
                {
                    btn[i].Width = splitContainer2.Panel1.Width - 40;
                }
        }

        void btnClick(object sender, EventArgs e)
        {  
            splitContainer2.Panel2.Controls.Clear();
            Button bt=(Button)sender;

            if (bt.Text == btn[0].Text)
            {
                FrmHomeWork newF=new FrmHomeWork();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if(bt.Text == btn[1].Text)
            {
                FrmCategoryProducts newF = new FrmCategoryProducts();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[2].Text)
            {
                FrmProducts newF = new FrmProducts();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[3].Text)
            {
                FrmListBox newF = new FrmListBox();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[4].Text)
            {
                FrmAdventureWorks newF = new FrmAdventureWorks();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[5].Text)
            {
                FrmMyAlbum_V2 newF = new FrmMyAlbum_V2();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[6].Text)
            {
                FrmCustomers newF = new FrmCustomers();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
            }
            else if (bt.Text == btn[7].Text)
            {
                FrmTreeView newF = new FrmTreeView();
                newF.TopLevel = false;
                newF.Visible = true;
                splitContainer2.Panel2.Controls.Add(newF);
                newF.Focus();
            }
            //else if (bt.Text == btn[8].Text)
            //{
                
            //}

        }
    }
}
