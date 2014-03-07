namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.saveButton = new System.Windows.Forms.Button();
            this.dayMenuTab2 = new System.Windows.Forms.ComboBox();
            this.monthMenuTab1 = new System.Windows.Forms.ComboBox();
            this.yearMenuTab2 = new System.Windows.Forms.TextBox();
            this.numChildTextBox = new System.Windows.Forms.TextBox();
            this.numAdultsTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addrTextBox2 = new System.Windows.Forms.TextBox();
            this.addrTextBox1 = new System.Windows.Forms.TextBox();
            this.miTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextBox = new System.Windows.Forms.TextBox();
            this.fNameTextBox = new System.Windows.Forms.TextBox();
            this.dateVistLabelTab1 = new System.Windows.Forms.Label();
            this.numChildLabel = new System.Windows.Forms.Label();
            this.numAdultsLabel = new System.Windows.Forms.Label();
            this.phoneLabel2 = new System.Windows.Forms.Label();
            this.addrLabel2 = new System.Windows.Forms.Label();
            this.addrLabel1 = new System.Windows.Forms.Label();
            this.miLabel = new System.Windows.Forms.Label();
            this.lNameLabel = new System.Windows.Forms.Label();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.searchMenuTab2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midInit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.children = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchButtonTab2 = new System.Windows.Forms.Button();
            this.searchTextTab2 = new System.Windows.Forms.TextBox();
            this.searchLabelTab2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.yearMenuTab3 = new System.Windows.Forms.TextBox();
            this.statsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.searchButtonTab3 = new System.Windows.Forms.Button();
            this.searchMenuTab3 = new System.Windows.Forms.ComboBox();
            this.monthMenuTab3 = new System.Windows.Forms.ComboBox();
            this.dayMenuTab3 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabs.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage4);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F);
            this.tabs.ItemSize = new System.Drawing.Size(150, 70);
            this.tabs.Location = new System.Drawing.Point(48, 55);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1380, 692);
            this.tabs.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.saveButton);
            this.tabPage4.Controls.Add(this.dayMenuTab2);
            this.tabPage4.Controls.Add(this.monthMenuTab1);
            this.tabPage4.Controls.Add(this.yearMenuTab2);
            this.tabPage4.Controls.Add(this.numChildTextBox);
            this.tabPage4.Controls.Add(this.numAdultsTextBox);
            this.tabPage4.Controls.Add(this.phoneTextBox);
            this.tabPage4.Controls.Add(this.addrTextBox2);
            this.tabPage4.Controls.Add(this.addrTextBox1);
            this.tabPage4.Controls.Add(this.miTextBox);
            this.tabPage4.Controls.Add(this.lNameTextBox);
            this.tabPage4.Controls.Add(this.fNameTextBox);
            this.tabPage4.Controls.Add(this.dateVistLabelTab1);
            this.tabPage4.Controls.Add(this.numChildLabel);
            this.tabPage4.Controls.Add(this.numAdultsLabel);
            this.tabPage4.Controls.Add(this.phoneLabel2);
            this.tabPage4.Controls.Add(this.addrLabel2);
            this.tabPage4.Controls.Add(this.addrLabel1);
            this.tabPage4.Controls.Add(this.miLabel);
            this.tabPage4.Controls.Add(this.lNameLabel);
            this.tabPage4.Controls.Add(this.fNameLabel);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage4.Location = new System.Drawing.Point(4, 74);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1372, 614);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ADD NEW ENTRY";
            // 
            // saveButton
            // 
            this.saveButton.AutoEllipsis = true;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Location = new System.Drawing.Point(932, 505);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(275, 66);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dayMenuTab2
            // 
            this.dayMenuTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dayMenuTab2.FormattingEnabled = true;
            this.dayMenuTab2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayMenuTab2.Location = new System.Drawing.Point(360, 433);
            this.dayMenuTab2.Name = "dayMenuTab2";
            this.dayMenuTab2.Size = new System.Drawing.Size(121, 33);
            this.dayMenuTab2.TabIndex = 19;
            this.dayMenuTab2.Text = "Day";
            // 
            // monthMenuTab1
            // 
            this.monthMenuTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.monthMenuTab1.FormattingEnabled = true;
            this.monthMenuTab1.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthMenuTab1.Location = new System.Drawing.Point(176, 429);
            this.monthMenuTab1.Name = "monthMenuTab1";
            this.monthMenuTab1.Size = new System.Drawing.Size(121, 33);
            this.monthMenuTab1.TabIndex = 18;
            this.monthMenuTab1.Text = "Month";
            // 
            // yearMenuTab2
            // 
            this.yearMenuTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearMenuTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.yearMenuTab2.Location = new System.Drawing.Point(560, 435);
            this.yearMenuTab2.Name = "yearMenuTab2";
            this.yearMenuTab2.Size = new System.Drawing.Size(208, 31);
            this.yearMenuTab2.TabIndex = 17;
            this.yearMenuTab2.Text = "Year";
            // 
            // numChildTextBox
            // 
            this.numChildTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numChildTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numChildTextBox.Location = new System.Drawing.Point(230, 374);
            this.numChildTextBox.Name = "numChildTextBox";
            this.numChildTextBox.Size = new System.Drawing.Size(315, 31);
            this.numChildTextBox.TabIndex = 16;
            // 
            // numAdultsTextBox
            // 
            this.numAdultsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAdultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numAdultsTextBox.Location = new System.Drawing.Point(220, 316);
            this.numAdultsTextBox.Name = "numAdultsTextBox";
            this.numAdultsTextBox.Size = new System.Drawing.Size(315, 31);
            this.numAdultsTextBox.TabIndex = 15;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.phoneTextBox.Location = new System.Drawing.Point(120, 266);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(315, 31);
            this.phoneTextBox.TabIndex = 14;
            // 
            // addrTextBox2
            // 
            this.addrTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrTextBox2.Location = new System.Drawing.Point(176, 216);
            this.addrTextBox2.Name = "addrTextBox2";
            this.addrTextBox2.Size = new System.Drawing.Size(315, 31);
            this.addrTextBox2.TabIndex = 13;
            // 
            // addrTextBox1
            // 
            this.addrTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addrTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrTextBox1.Location = new System.Drawing.Point(176, 177);
            this.addrTextBox1.Name = "addrTextBox1";
            this.addrTextBox1.Size = new System.Drawing.Size(315, 31);
            this.addrTextBox1.TabIndex = 12;
            // 
            // miTextBox
            // 
            this.miTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.miTextBox.Location = new System.Drawing.Point(81, 135);
            this.miTextBox.Name = "miTextBox";
            this.miTextBox.Size = new System.Drawing.Size(315, 31);
            this.miTextBox.TabIndex = 11;
            // 
            // lNameTextBox
            // 
            this.lNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lNameTextBox.Location = new System.Drawing.Point(176, 83);
            this.lNameTextBox.Name = "lNameTextBox";
            this.lNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.lNameTextBox.TabIndex = 10;
            // 
            // fNameTextBox
            // 
            this.fNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fNameTextBox.Location = new System.Drawing.Point(176, 39);
            this.fNameTextBox.Name = "fNameTextBox";
            this.fNameTextBox.Size = new System.Drawing.Size(315, 31);
            this.fNameTextBox.TabIndex = 9;
            // 
            // dateVistLabelTab1
            // 
            this.dateVistLabelTab1.AutoSize = true;
            this.dateVistLabelTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dateVistLabelTab1.Location = new System.Drawing.Point(28, 433);
            this.dateVistLabelTab1.Name = "dateVistLabelTab1";
            this.dateVistLabelTab1.Size = new System.Drawing.Size(128, 25);
            this.dateVistLabelTab1.TabIndex = 8;
            this.dateVistLabelTab1.Text = "Date of Visit";
            // 
            // numChildLabel
            // 
            this.numChildLabel.AutoSize = true;
            this.numChildLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numChildLabel.Location = new System.Drawing.Point(27, 374);
            this.numChildLabel.Name = "numChildLabel";
            this.numChildLabel.Size = new System.Drawing.Size(197, 25);
            this.numChildLabel.TabIndex = 7;
            this.numChildLabel.Text = "Number of Children";
            // 
            // numAdultsLabel
            // 
            this.numAdultsLabel.AutoSize = true;
            this.numAdultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.numAdultsLabel.Location = new System.Drawing.Point(28, 322);
            this.numAdultsLabel.Name = "numAdultsLabel";
            this.numAdultsLabel.Size = new System.Drawing.Size(177, 25);
            this.numAdultsLabel.TabIndex = 6;
            this.numAdultsLabel.Text = "Number of Adults";
            // 
            // phoneLabel2
            // 
            this.phoneLabel2.AutoSize = true;
            this.phoneLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.phoneLabel2.Location = new System.Drawing.Point(27, 272);
            this.phoneLabel2.Name = "phoneLabel2";
            this.phoneLabel2.Size = new System.Drawing.Size(74, 25);
            this.phoneLabel2.TabIndex = 5;
            this.phoneLabel2.Text = "Phone";
            // 
            // addrLabel2
            // 
            this.addrLabel2.AutoSize = true;
            this.addrLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrLabel2.Location = new System.Drawing.Point(27, 222);
            this.addrLabel2.Name = "addrLabel2";
            this.addrLabel2.Size = new System.Drawing.Size(150, 25);
            this.addrLabel2.TabIndex = 4;
            this.addrLabel2.Text = "Address Line2";
            // 
            // addrLabel1
            // 
            this.addrLabel1.AutoSize = true;
            this.addrLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.addrLabel1.Location = new System.Drawing.Point(27, 177);
            this.addrLabel1.Name = "addrLabel1";
            this.addrLabel1.Size = new System.Drawing.Size(150, 25);
            this.addrLabel1.TabIndex = 3;
            this.addrLabel1.Text = "Address Line1";
            // 
            // miLabel
            // 
            this.miLabel.AutoSize = true;
            this.miLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.miLabel.Location = new System.Drawing.Point(28, 135);
            this.miLabel.Name = "miLabel";
            this.miLabel.Size = new System.Drawing.Size(47, 25);
            this.miLabel.TabIndex = 2;
            this.miLabel.Text = "M.I.";
            // 
            // lNameLabel
            // 
            this.lNameLabel.AutoSize = true;
            this.lNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lNameLabel.Location = new System.Drawing.Point(27, 83);
            this.lNameLabel.Name = "lNameLabel";
            this.lNameLabel.Size = new System.Drawing.Size(109, 25);
            this.lNameLabel.TabIndex = 1;
            this.lNameLabel.Text = "LastName";
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.fNameLabel.Location = new System.Drawing.Point(27, 39);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(110, 25);
            this.fNameLabel.TabIndex = 0;
            this.fNameLabel.Text = "FirstName";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.searchMenuTab2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.searchButtonTab2);
            this.tabPage1.Controls.Add(this.searchTextTab2);
            this.tabPage1.Controls.Add(this.searchLabelTab2);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tabPage1.Location = new System.Drawing.Point(4, 74);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1372, 614);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "SEARCH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchMenuTab2
            // 
            this.searchMenuTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.searchMenuTab2.FormattingEnabled = true;
            this.searchMenuTab2.Items.AddRange(new object[] {
            "Name",
            "Phone",
            "LastVisit"});
            this.searchMenuTab2.Location = new System.Drawing.Point(716, 31);
            this.searchMenuTab2.Name = "searchMenuTab2";
            this.searchMenuTab2.Size = new System.Drawing.Size(281, 54);
            this.searchMenuTab2.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.midInit,
            this.addr1,
            this.addr2,
            this.phone,
            this.adults,
            this.children,
            this.lastVisit});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 109);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(1342, 499);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FirstName.FillWeight = 10F;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 236;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.Width = 233;
            // 
            // midInit
            // 
            this.midInit.HeaderText = "MI";
            this.midInit.Name = "midInit";
            // 
            // addr1
            // 
            this.addr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.addr1.HeaderText = "AddressLine1";
            this.addr1.Name = "addr1";
            this.addr1.Width = 299;
            // 
            // addr2
            // 
            this.addr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addr2.HeaderText = "Address Line 2";
            this.addr2.Name = "addr2";
            this.addr2.Width = 321;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.Width = 164;
            // 
            // adults
            // 
            this.adults.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.adults.HeaderText = "Adults";
            this.adults.Name = "adults";
            this.adults.Width = 160;
            // 
            // children
            // 
            this.children.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.children.HeaderText = "Children";
            this.children.Name = "children";
            this.children.Width = 201;
            // 
            // lastVisit
            // 
            this.lastVisit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastVisit.HeaderText = "Last Visit";
            this.lastVisit.Name = "lastVisit";
            this.lastVisit.Width = 213;
            // 
            // searchButtonTab2
            // 
            this.searchButtonTab2.Location = new System.Drawing.Point(1110, 26);
            this.searchButtonTab2.Name = "searchButtonTab2";
            this.searchButtonTab2.Size = new System.Drawing.Size(232, 62);
            this.searchButtonTab2.TabIndex = 2;
            this.searchButtonTab2.Text = "SEARCH";
            this.searchButtonTab2.UseVisualStyleBackColor = true;
            // 
            // searchTextTab2
            // 
            this.searchTextTab2.Location = new System.Drawing.Point(169, 31);
            this.searchTextTab2.Name = "searchTextTab2";
            this.searchTextTab2.Size = new System.Drawing.Size(388, 53);
            this.searchTextTab2.TabIndex = 1;
            this.searchTextTab2.TextChanged += new System.EventHandler(this.searchTextTab2_TextChanged);
            // 
            // searchLabelTab2
            // 
            this.searchLabelTab2.AutoSize = true;
            this.searchLabelTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.searchLabelTab2.Location = new System.Drawing.Point(42, 42);
            this.searchLabelTab2.Name = "searchLabelTab2";
            this.searchLabelTab2.Size = new System.Drawing.Size(121, 38);
            this.searchLabelTab2.TabIndex = 0;
            this.searchLabelTab2.Text = "Search";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearMenuTab3);
            this.tabPage2.Controls.Add(this.statsChart);
            this.tabPage2.Controls.Add(this.searchButtonTab3);
            this.tabPage2.Controls.Add(this.searchMenuTab3);
            this.tabPage2.Controls.Add(this.monthMenuTab3);
            this.tabPage2.Controls.Add(this.dayMenuTab3);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 74);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1372, 614);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "STATISTICS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // yearMenuTab3
            // 
            this.yearMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.yearMenuTab3.Location = new System.Drawing.Point(913, 66);
            this.yearMenuTab3.Name = "yearMenuTab3";
            this.yearMenuTab3.Size = new System.Drawing.Size(173, 44);
            this.yearMenuTab3.TabIndex = 25;
            this.yearMenuTab3.Text = "Year";
            // 
            // statsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.statsChart.Legends.Add(legend1);
            this.statsChart.Location = new System.Drawing.Point(273, 146);
            this.statsChart.Name = "statsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statsChart.Series.Add(series1);
            this.statsChart.Size = new System.Drawing.Size(813, 431);
            this.statsChart.TabIndex = 24;
            this.statsChart.Text = "chart1";
            // 
            // searchButtonTab3
            // 
            this.searchButtonTab3.Location = new System.Drawing.Point(1099, 66);
            this.searchButtonTab3.Name = "searchButtonTab3";
            this.searchButtonTab3.Size = new System.Drawing.Size(216, 51);
            this.searchButtonTab3.TabIndex = 23;
            this.searchButtonTab3.Text = "SEARCH";
            this.searchButtonTab3.UseVisualStyleBackColor = true;
            // 
            // searchMenuTab3
            // 
            this.searchMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.searchMenuTab3.FormattingEnabled = true;
            this.searchMenuTab3.Location = new System.Drawing.Point(46, 66);
            this.searchMenuTab3.Name = "searchMenuTab3";
            this.searchMenuTab3.Size = new System.Drawing.Size(262, 45);
            this.searchMenuTab3.TabIndex = 22;
            this.searchMenuTab3.Text = "Search Criteria";
            // 
            // monthMenuTab3
            // 
            this.monthMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.monthMenuTab3.FormattingEnabled = true;
            this.monthMenuTab3.Location = new System.Drawing.Point(378, 66);
            this.monthMenuTab3.Name = "monthMenuTab3";
            this.monthMenuTab3.Size = new System.Drawing.Size(229, 45);
            this.monthMenuTab3.TabIndex = 21;
            this.monthMenuTab3.Text = "January";
            // 
            // dayMenuTab3
            // 
            this.dayMenuTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.dayMenuTab3.FormattingEnabled = true;
            this.dayMenuTab3.Location = new System.Drawing.Point(654, 66);
            this.dayMenuTab3.Name = "dayMenuTab3";
            this.dayMenuTab3.Size = new System.Drawing.Size(223, 45);
            this.dayMenuTab3.TabIndex = 20;
            this.dayMenuTab3.Text = "Day";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 74);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1372, 614);
            this.tabPage3.TabIndex = 6;
            this.tabPage3.Text = "VIEW ALL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(39, 34);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Size = new System.Drawing.Size(1296, 533);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 10F;
            this.dataGridViewTextBoxColumn1.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 236;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 233;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "MI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "AddressLine1";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 299;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Address Line 2";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 321;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 164;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "Adults";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 160;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "Children";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 201;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Last Visit";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 213;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label lNameLabel;
        private System.Windows.Forms.Label miLabel;
        private System.Windows.Forms.TextBox fNameTextBox;
        private System.Windows.Forms.Label dateVistLabelTab1;
        private System.Windows.Forms.Label numChildLabel;
        private System.Windows.Forms.Label numAdultsLabel;
        private System.Windows.Forms.Label phoneLabel2;
        private System.Windows.Forms.Label addrLabel2;
        private System.Windows.Forms.Label addrLabel1;
        private System.Windows.Forms.ComboBox dayMenuTab2;
        private System.Windows.Forms.ComboBox monthMenuTab1;
        private System.Windows.Forms.TextBox yearMenuTab2;
        private System.Windows.Forms.TextBox numChildTextBox;
        private System.Windows.Forms.TextBox numAdultsTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox addrTextBox2;
        private System.Windows.Forms.TextBox addrTextBox1;
        private System.Windows.Forms.TextBox miTextBox;
        private System.Windows.Forms.TextBox lNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label searchLabelTab2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox searchTextTab2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchButtonTab2;
        private System.Windows.Forms.ComboBox searchMenuTab2;
        private System.Windows.Forms.DataVisualization.Charting.Chart statsChart;
        private System.Windows.Forms.Button searchButtonTab3;
        private System.Windows.Forms.ComboBox searchMenuTab3;
        private System.Windows.Forms.ComboBox monthMenuTab3;
        private System.Windows.Forms.ComboBox dayMenuTab3;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn midInit;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adults;
        private System.Windows.Forms.DataGridViewTextBoxColumn children;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastVisit;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TextBox yearMenuTab3;
    }
}

