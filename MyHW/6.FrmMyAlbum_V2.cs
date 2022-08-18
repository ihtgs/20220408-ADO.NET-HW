using MyHW.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHW
{
    public partial class FrmMyAlbum_V2 : Form
    {
        public FrmMyAlbum_V2()
        {
            InitializeComponent();
            CreatLinkLabAndComboBox();
            bindingNavigator1.BindingSource = photosBindingSource;
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.DragEnter += FlowLayoutPanel2_DragEnter;
            flowLayoutPanel2.DragDrop += FlowLayoutPanel2_DragDrop;
            categoryNameTextBox.TextChanged += ConnectToPhotoComboBox;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = folderBrowserDialog1.SelectedPath;
                string[] files = Directory.GetFiles(path, "*.*");
                DealWitAddedFiles(files);
            }
        }
        private void FlowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = ((string[])e.Data.GetData(DataFormats.FileDrop));
            DealWitAddedFiles(files);
        }

        private void DealWitAddedFiles(string[] files)
        {
            files=files.Where(s => s.EndsWith(".bmp") || s.EndsWith(".jpg") || s.EndsWith(".gif") || s.EndsWith(".png") || s.EndsWith(".tiff")).ToArray();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString1))
                {
                    for (int i = 0; i <= files.Length - 1; i++)
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(files[i]);

                        MemoryStream ms = new MemoryStream();
                        byte[] bytes = null;
                        pic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        bytes = ms.GetBuffer();
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "Insert into Photos(Picture,CategoryID) values (@Image,@city)";
                        cmd.Connection = conn;
                        cmd.Parameters.Add("@Image", SqlDbType.Image).Value = bytes;
                        cmd.Parameters.Add("@city", SqlDbType.Int).Value = returnCityID(comboBox1.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        SetPicBox(pic);
                        flowLayoutPanel2.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        
        private void SetPicBox(PictureBox pic)
        {
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Width = 160;
            pic.Height = 120;
            pic.Padding = new Padding(5, 5, 5, 5);
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.MouseEnter += PicMouseEnter;
            pic.MouseLeave += PicMouseLeave;
        }


        private void FlowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        
        private int returnCityID(string city)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select CategoryID, CategoryName from PhotoCategory where CategoryName = @city", conn);
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    return (int)reader["CategoryID"];
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }


        private void CreatLinkLabAndComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            splitContainer2.Panel1.Controls.Clear();

            List<string> citys = new List<string>();
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.Default.MyAlbumConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("Select CategoryName, CategoryID from PhotoCategory", conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable table = reader.GetSchemaTable();
                    citys.Add("AllCitys");
                    while (reader.Read())
                    {
                        string s = reader["CategoryName"].ToString();
                        int n = (int)reader["CategoryID"];
                        //dict.Add(s, n);
                        citys.Add(s);
                        comboBox1.Items.Add(s);
                        comboBox2.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

            LinkLabel[] LB = new LinkLabel[citys.Count];
            for (int i = 0; i < LB.Length; i++)
            {
                LB[i] = new LinkLabel();
                LB[i].AutoSize = true;
                LB[i].Location = new Point(26, 24 + i * 50);
                LB[i].Text = citys[i];
                LB[i].Click += LinkClicked;
                LB[i].Font = new Font("微軟正黑體", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                LB[i].Tag = i + 1;
                splitContainer2.Panel1.Controls.Add(LB[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox c = (ComboBox)sender;
            flowLayoutPanel2.Controls.Clear();
            ShowSelectedPhoto(c.Text, 'c');
        }

        private void LinkClicked(object sender, EventArgs e)
        {
            LinkLabel l = (LinkLabel)sender;
            flowLayoutPanel1.Controls.Clear();
            ShowSelectedPhoto(l.Text, 'l');
        }

        private void ShowSelectedPhoto(string city, char obj)
        {
            if (city == "AllCitys")
                photoCityTableAdapter1.FillByCity(myAlbum.PhotoCity);
            else
                photoCityTableAdapter1.FillByCtP(myAlbum.PhotoCity, city);
            //dataGridView1.DataSource = myAlbum.PhotoCity;
            foreach (DataRow r in myAlbum.PhotoCity)
            {
                PictureBox pic = new PictureBox();
                MemoryStream ms = new MemoryStream((byte[])r["picture"]);
                pic.Image = Image.FromStream(ms);
                SetPicBox(pic);
                if (obj == 'c')
                    flowLayoutPanel2.Controls.Add(pic);
                else
                {
                    pic.Click += Pic_Click;
                    flowLayoutPanel1.Controls.Add(pic);
                }
            }
        }

        private void PicMouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = Color.White;
        }

        private void PicMouseEnter(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.BackColor = Color.Red;
        }
        internal int index;
        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            FrmShowPic f = new FrmShowPic();
            index = flowLayoutPanel1.Controls.GetChildIndex(pic);
            f.pictureBox1.Image = ((PictureBox)flowLayoutPanel1.Controls[index]).Image;
            f.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            f.Owner = this;
            f.index = index;
            f.border = flowLayoutPanel1.Controls.Count - 1;
            f.Show();
        }

        private void photoCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.photoCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myAlbum);
            CreatLinkLabAndComboBox();
            string city = photoCategoryDataGridView.CurrentCell.Value.ToString();
            try
            {
                comboBox2.SelectedIndex = returnCityID(city) - 1;
            }
            catch(Exception ex)
            {

            }
            categoryIDTextBox1.Text = returnCityID(city).ToString();
        }

        private void FrmMyAlbum_V2_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myAlbum.Photos' 資料表。您可以視需要進行移動或移除。
            this.photosTableAdapter.Fill(this.myAlbum.Photos);
            this.photoCategoryTableAdapter.Fill(this.myAlbum.PhotoCategory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void ConnectToPhotoComboBox(object sender, EventArgs e)
        {
            string s = categoryNameTextBox.Text;
            try
            {
                comboBox2.SelectedIndex = returnCityID(s) - 1;
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK " + openFileDialog1.FileName);

                picturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Cancel");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = returnCityID(comboBox2.Text);
            photosTableAdapter.FillByID(myAlbum.Photos, n);
            photosDataGridView1.DataSource = myAlbum.Photos;
        }

    }
}
