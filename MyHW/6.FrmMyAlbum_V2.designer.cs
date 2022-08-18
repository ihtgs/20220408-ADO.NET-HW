
namespace MyHW
{
    partial class FrmMyAlbum_V2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label photoIDLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            System.Windows.Forms.Label photoNameLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMyAlbum_V2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.photosDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myAlbum = new MyHW.MyAlbum();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.photoCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.photoCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.photoCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.photoCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.photoIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox1 = new System.Windows.Forms.TextBox();
            this.photoNameTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.photoCategoryTableAdapter = new MyHW.MyAlbumTableAdapters.PhotoCategoryTableAdapter();
            this.tableAdapterManager = new MyHW.MyAlbumTableAdapters.TableAdapterManager();
            this.dataTable1TableAdapter1 = new MyHW.TheirTripTableAdapters.DataTable1TableAdapter();
            this.photoCityTableAdapter1 = new MyHW.MyAlbumTableAdapters.PhotoCityTableAdapter();
            this.photosTableAdapter = new MyHW.MyAlbumTableAdapters.PhotosTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataSet11 = new MyHW.DataSet1();
            this.dataSet12 = new MyHW.DataSet1();
            this.dataSet13 = new MyHW.DataSet1();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            categoryIDLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            photoIDLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            photoNameLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).BeginInit();
            this.photoCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(14, 90);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 12);
            categoryIDLabel.TabIndex = 1;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(14, 118);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(81, 12);
            categoryNameLabel.TabIndex = 3;
            categoryNameLabel.Text = "Category Name:";
            // 
            // photoIDLabel
            // 
            photoIDLabel.AutoSize = true;
            photoIDLabel.Location = new System.Drawing.Point(10, 65);
            photoIDLabel.Name = "photoIDLabel";
            photoIDLabel.Size = new System.Drawing.Size(50, 12);
            photoIDLabel.TabIndex = 1;
            photoIDLabel.Text = "Photo ID:";
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Location = new System.Drawing.Point(10, 93);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(66, 12);
            categoryIDLabel1.TabIndex = 3;
            categoryIDLabel1.Text = "Category ID:";
            // 
            // photoNameLabel
            // 
            photoNameLabel.AutoSize = true;
            photoNameLabel.Location = new System.Drawing.Point(10, 121);
            photoNameLabel.Name = "photoNameLabel";
            photoNameLabel.Size = new System.Drawing.Size(65, 12);
            photoNameLabel.TabIndex = 5;
            photoNameLabel.Text = "Photo Name:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(333, 60);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(40, 12);
            pictureLabel.TabIndex = 7;
            pictureLabel.Text = "Picture:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(10, 155);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(10, 184);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(29, 12);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Date:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(995, 678);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Album";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(991, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(983, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "瀏覽相片";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(977, 548);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(760, 546);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(983, 554);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "新增相片管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            this.splitContainer3.Panel1.Controls.Add(this.comboBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(977, 548);
            this.splitContainer3.SplitterDistance = 170;
            this.splitContainer3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "城市";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(179, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drag Drop Pictures  ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Folder...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(975, 372);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(983, 554);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tool";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1.Controls.Add(this.photosDataGridView1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(983, 554);
            this.splitContainer4.SplitterDistance = 67;
            this.splitContainer4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 57);
            this.label5.TabIndex = 3;
            this.label5.Text = "相片管理";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // photosDataGridView1
            // 
            this.photosDataGridView1.AutoGenerateColumns = false;
            this.photosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.photosDataGridView1.DataSource = this.photosBindingSource;
            this.photosDataGridView1.Location = new System.Drawing.Point(163, 35);
            this.photosDataGridView1.Name = "photosDataGridView1";
            this.photosDataGridView1.RowTemplate.Height = 24;
            this.photosDataGridView1.Size = new System.Drawing.Size(10, 10);
            this.photosDataGridView1.TabIndex = 17;
            this.photosDataGridView1.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn8.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn9.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn10.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Picture";
            this.dataGridViewImageColumn2.HeaderText = "Picture";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn11.HeaderText = "Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.myAlbum;
            // 
            // myAlbum
            // 
            this.myAlbum.DataSetName = "MyAlbum";
            this.myAlbum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.AutoScroll = true;
            this.splitContainer5.Panel1.Controls.Add(this.label4);
            this.splitContainer5.Panel1.Controls.Add(this.photoCategoryBindingNavigator);
            this.splitContainer5.Panel1.Controls.Add(categoryIDLabel);
            this.splitContainer5.Panel1.Controls.Add(this.categoryIDTextBox);
            this.splitContainer5.Panel1.Controls.Add(categoryNameLabel);
            this.splitContainer5.Panel1.Controls.Add(this.categoryNameTextBox);
            this.splitContainer5.Panel1.Controls.Add(this.photoCategoryDataGridView);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.AutoScroll = true;
            this.splitContainer5.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainer5.Panel2.Controls.Add(this.photosDataGridView);
            this.splitContainer5.Panel2.Controls.Add(this.label6);
            this.splitContainer5.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer5.Panel2.Controls.Add(this.button2);
            this.splitContainer5.Panel2.Controls.Add(photoIDLabel);
            this.splitContainer5.Panel2.Controls.Add(this.photoIDTextBox);
            this.splitContainer5.Panel2.Controls.Add(categoryIDLabel1);
            this.splitContainer5.Panel2.Controls.Add(this.categoryIDTextBox1);
            this.splitContainer5.Panel2.Controls.Add(photoNameLabel);
            this.splitContainer5.Panel2.Controls.Add(this.photoNameTextBox);
            this.splitContainer5.Panel2.Controls.Add(pictureLabel);
            this.splitContainer5.Panel2.Controls.Add(this.picturePictureBox);
            this.splitContainer5.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer5.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer5.Panel2.Controls.Add(dateLabel);
            this.splitContainer5.Panel2.Controls.Add(this.dateDateTimePicker);
            this.splitContainer5.Size = new System.Drawing.Size(983, 483);
            this.splitContainer5.SplitterDistance = 305;
            this.splitContainer5.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(13, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Photo Category";
            // 
            // photoCategoryBindingNavigator
            // 
            this.photoCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.photoCategoryBindingNavigator.BindingSource = this.photoCategoryBindingSource;
            this.photoCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.photoCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.photoCategoryBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.photoCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.photoCategoryBindingNavigatorSaveItem});
            this.photoCategoryBindingNavigator.Location = new System.Drawing.Point(1, 3);
            this.photoCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.photoCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.photoCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.photoCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.photoCategoryBindingNavigator.Name = "photoCategoryBindingNavigator";
            this.photoCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.photoCategoryBindingNavigator.Size = new System.Drawing.Size(270, 25);
            this.photoCategoryBindingNavigator.TabIndex = 1;
            this.photoCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // photoCategoryBindingSource
            // 
            this.photoCategoryBindingSource.DataMember = "PhotoCategory";
            this.photoCategoryBindingSource.DataSource = this.myAlbum;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // photoCategoryBindingNavigatorSaveItem
            // 
            this.photoCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.photoCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("photoCategoryBindingNavigatorSaveItem.Image")));
            this.photoCategoryBindingNavigatorSaveItem.Name = "photoCategoryBindingNavigatorSaveItem";
            this.photoCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.photoCategoryBindingNavigatorSaveItem.Text = "儲存資料";
            this.photoCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.photoCategoryBindingNavigatorSaveItem_Click);
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(101, 87);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoryIDTextBox.TabIndex = 2;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photoCategoryBindingSource, "CategoryName", true));
            this.categoryNameTextBox.Location = new System.Drawing.Point(101, 115);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.categoryNameTextBox.TabIndex = 4;
            // 
            // photoCategoryDataGridView
            // 
            this.photoCategoryDataGridView.AutoGenerateColumns = false;
            this.photoCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photoCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.photoCategoryDataGridView.DataSource = this.photoCategoryBindingSource;
            this.photoCategoryDataGridView.Location = new System.Drawing.Point(26, 177);
            this.photoCategoryDataGridView.Name = "photoCategoryDataGridView";
            this.photoCategoryDataGridView.RowTemplate.Height = 24;
            this.photoCategoryDataGridView.Size = new System.Drawing.Size(245, 295);
            this.photoCategoryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // photosDataGridView
            // 
            this.photosDataGridView.AutoGenerateColumns = false;
            this.photosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.photosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.photosDataGridView.DataSource = this.photosBindingSource;
            this.photosDataGridView.Location = new System.Drawing.Point(12, 223);
            this.photosDataGridView.Name = "photosDataGridView";
            this.photosDataGridView.RowTemplate.Height = 50;
            this.photosDataGridView.Size = new System.Drawing.Size(638, 252);
            this.photosDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhotoID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhotoID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CategoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "CategoryID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PhotoName";
            this.dataGridViewTextBoxColumn5.HeaderText = "PhotoName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Picture";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "Picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn7.HeaderText = "Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(8, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Photos";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(184, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 20);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(567, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // photoIDTextBox
            // 
            this.photoIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoID", true));
            this.photoIDTextBox.Location = new System.Drawing.Point(82, 62);
            this.photoIDTextBox.Name = "photoIDTextBox";
            this.photoIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.photoIDTextBox.TabIndex = 2;
            // 
            // categoryIDTextBox1
            // 
            this.categoryIDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "CategoryID", true));
            this.categoryIDTextBox1.Location = new System.Drawing.Point(82, 90);
            this.categoryIDTextBox1.Name = "categoryIDTextBox1";
            this.categoryIDTextBox1.Size = new System.Drawing.Size(96, 22);
            this.categoryIDTextBox1.TabIndex = 4;
            // 
            // photoNameTextBox
            // 
            this.photoNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "PhotoName", true));
            this.photoNameTextBox.Location = new System.Drawing.Point(82, 118);
            this.photoNameTextBox.Name = "photoNameTextBox";
            this.photoNameTextBox.Size = new System.Drawing.Size(200, 22);
            this.photoNameTextBox.TabIndex = 6;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.photosBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(388, 60);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(160, 140);
            this.picturePictureBox.TabIndex = 8;
            this.picturePictureBox.TabStop = false;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.photosBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(82, 152);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.photosBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(82, 180);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 12;
            // 
            // photoCategoryTableAdapter
            // 
            this.photoCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhotoCategoryTableAdapter = this.photoCategoryTableAdapter;
            this.tableAdapterManager.PhotosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MyHW.MyAlbumTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // photoCityTableAdapter1
            // 
            this.photoCityTableAdapter1.ClearBeforeFill = true;
            // 
            // photosTableAdapter
            // 
            this.photosTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet13
            // 
            this.dataSet13.DataSetName = "DataSet1";
            this.dataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton8;
            this.bindingNavigator1.BindingSource = this.photoCategoryBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel2;
            this.bindingNavigator1.DeleteItem = this.toolStripButton9;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton10;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton13;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton12;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton11;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator1.Size = new System.Drawing.Size(270, 25);
            this.bindingNavigator1.TabIndex = 18;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "加入新的";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(27, 22);
            this.toolStripLabel2.Text = "/{0}";
            this.toolStripLabel2.ToolTipText = "項目總數";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "刪除";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "移到最前面";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "移到上一個";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "位置";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "目前的位置";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "移到下一個";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "移到最後面";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "儲存資料";
            // 
            // FrmMyAlbum_V2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 678);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMyAlbum_V2";
            this.Text = "FrmMyAlbum_V2";
            this.Load += new System.EventHandler(this.FrmMyAlbum_V2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAlbum)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            this.splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingNavigator)).EndInit();
            this.photoCategoryBindingNavigator.ResumeLayout(false);
            this.photoCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private MyAlbum myAlbum;
        private System.Windows.Forms.BindingSource photoCategoryBindingSource;
        private MyAlbumTableAdapters.PhotoCategoryTableAdapter photoCategoryTableAdapter;
        private MyAlbumTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator photoCategoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton photoCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView photoCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private TheirTripTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private MyAlbumTableAdapters.PhotoCityTableAdapter photoCityTableAdapter1;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.BindingSource photosBindingSource;
        private MyAlbumTableAdapters.PhotosTableAdapter photosTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox photoIDTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox1;
        private System.Windows.Forms.TextBox photoNameTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView photosDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridView photosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
        private DataSet1 dataSet13;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
    }
}