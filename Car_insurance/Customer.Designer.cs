namespace Car_insurance
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Saler = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.已购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.将要过期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.所有保险信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Car = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.我的车辆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部车辆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加车辆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除车辆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保险信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已经购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.即将过期ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.全部种类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保险购买ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新的保险ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保险续费ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更改保险ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆事故ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事故查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.赔偿事宜ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询赔偿ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Saler);
            this.groupBox1.Controls.Add(this.textBox_Address);
            this.groupBox1.Controls.Add(this.textBox_Phone);
            this.groupBox1.Controls.Add(this.textBox_Name);
            this.groupBox1.Controls.Add(this.textBox_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "个人信息";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(159, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Enabled = false;
            this.textBox_password.Location = new System.Drawing.Point(116, 340);
            this.textBox_password.MaxLength = 6;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(143, 28);
            this.textBox_password.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(5, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password:";
            // 
            // textBox_Saler
            // 
            this.textBox_Saler.Enabled = false;
            this.textBox_Saler.Location = new System.Drawing.Point(102, 381);
            this.textBox_Saler.Name = "textBox_Saler";
            this.textBox_Saler.Size = new System.Drawing.Size(157, 28);
            this.textBox_Saler.TabIndex = 3;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Enabled = false;
            this.textBox_Address.Location = new System.Drawing.Point(102, 304);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(157, 28);
            this.textBox_Address.TabIndex = 3;
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Enabled = false;
            this.textBox_Phone.Location = new System.Drawing.Point(102, 257);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(157, 28);
            this.textBox_Phone.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(102, 212);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(157, 28);
            this.textBox_Name.TabIndex = 3;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Enabled = false;
            this.textBox_ID.Location = new System.Drawing.Point(102, 169);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(157, 28);
            this.textBox_ID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saler:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG文件|*.jpg|PNG图片|*.png";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(572, 378);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.已购买ToolStripMenuItem,
            this.将要过期ToolStripMenuItem,
            this.所有保险信息ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 94);
            // 
            // 已购买ToolStripMenuItem
            // 
            this.已购买ToolStripMenuItem.Name = "已购买ToolStripMenuItem";
            this.已购买ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.已购买ToolStripMenuItem.Text = "已购买";
            // 
            // 将要过期ToolStripMenuItem
            // 
            this.将要过期ToolStripMenuItem.Name = "将要过期ToolStripMenuItem";
            this.将要过期ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.将要过期ToolStripMenuItem.Text = "将要过期";
            // 
            // 所有保险信息ToolStripMenuItem
            // 
            this.所有保险信息ToolStripMenuItem.Name = "所有保险信息ToolStripMenuItem";
            this.所有保险信息ToolStripMenuItem.Size = new System.Drawing.Size(201, 30);
            this.所有保险信息ToolStripMenuItem.Text = "所有保险信息";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(326, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "车牌：";
            // 
            // textBox_Car
            // 
            this.textBox_Car.Location = new System.Drawing.Point(431, 98);
            this.textBox_Car.Name = "textBox_Car";
            this.textBox_Car.Size = new System.Drawing.Size(213, 28);
            this.textBox_Car.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(659, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "确 认";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.Location = new System.Drawing.Point(659, 96);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(100, 33);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "查询";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Visible = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("黑体", 10.5F);
            this.label8.Location = new System.Drawing.Point(326, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "受保车辆";
            this.label8.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(306, 185);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(568, 247);
            this.dataGridView2.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.我的车辆ToolStripMenuItem,
            this.保险信息ToolStripMenuItem,
            this.车辆事故ToolStripMenuItem,
            this.赔偿事宜ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(566, 32);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 我的车辆ToolStripMenuItem
            // 
            this.我的车辆ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部车辆ToolStripMenuItem,
            this.添加车辆ToolStripMenuItem,
            this.删除车辆ToolStripMenuItem});
            this.我的车辆ToolStripMenuItem.Name = "我的车辆ToolStripMenuItem";
            this.我的车辆ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.我的车辆ToolStripMenuItem.Text = "我的车辆";
            // 
            // 全部车辆ToolStripMenuItem
            // 
            this.全部车辆ToolStripMenuItem.Name = "全部车辆ToolStripMenuItem";
            this.全部车辆ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.全部车辆ToolStripMenuItem.Text = "全部车辆";
            this.全部车辆ToolStripMenuItem.Click += new System.EventHandler(this.全部车辆ToolStripMenuItem_Click);
            // 
            // 添加车辆ToolStripMenuItem
            // 
            this.添加车辆ToolStripMenuItem.Name = "添加车辆ToolStripMenuItem";
            this.添加车辆ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.添加车辆ToolStripMenuItem.Text = "添加车辆";
            this.添加车辆ToolStripMenuItem.Click += new System.EventHandler(this.添加车辆ToolStripMenuItem_Click);
            // 
            // 删除车辆ToolStripMenuItem
            // 
            this.删除车辆ToolStripMenuItem.Name = "删除车辆ToolStripMenuItem";
            this.删除车辆ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.删除车辆ToolStripMenuItem.Text = "删除车辆";
            this.删除车辆ToolStripMenuItem.Click += new System.EventHandler(this.删除车辆ToolStripMenuItem_Click);
            // 
            // 保险信息ToolStripMenuItem
            // 
            this.保险信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.已经购买ToolStripMenuItem,
            this.即将过期ToolStripMenuItem,
            this.全部种类ToolStripMenuItem,
            this.保险购买ToolStripMenuItem});
            this.保险信息ToolStripMenuItem.Name = "保险信息ToolStripMenuItem";
            this.保险信息ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.保险信息ToolStripMenuItem.Text = "保险信息";
            // 
            // 已经购买ToolStripMenuItem
            // 
            this.已经购买ToolStripMenuItem.Name = "已经购买ToolStripMenuItem";
            this.已经购买ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.已经购买ToolStripMenuItem.Text = "已经购买";
            this.已经购买ToolStripMenuItem.Click += new System.EventHandler(this.已经购买ToolStripMenuItem_Click);
            // 
            // 即将过期ToolStripMenuItem
            // 
            this.即将过期ToolStripMenuItem.Name = "即将过期ToolStripMenuItem";
            this.即将过期ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.即将过期ToolStripMenuItem.Text = "即将过期";
            this.即将过期ToolStripMenuItem.Click += new System.EventHandler(this.即将过期ToolStripMenuItem_Click);
            // 
            // 全部种类ToolStripMenuItem
            // 
            this.全部种类ToolStripMenuItem.Name = "全部种类ToolStripMenuItem";
            this.全部种类ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.全部种类ToolStripMenuItem.Text = "全部种类";
            this.全部种类ToolStripMenuItem.Click += new System.EventHandler(this.全部种类ToolStripMenuItem_Click);
            // 
            // 保险购买ToolStripMenuItem
            // 
            this.保险购买ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新的保险ToolStripMenuItem,
            this.保险续费ToolStripMenuItem,
            this.更改保险ToolStripMenuItem});
            this.保险购买ToolStripMenuItem.Name = "保险购买ToolStripMenuItem";
            this.保险购买ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.保险购买ToolStripMenuItem.Text = "保险管理";
            // 
            // 新的保险ToolStripMenuItem
            // 
            this.新的保险ToolStripMenuItem.Name = "新的保险ToolStripMenuItem";
            this.新的保险ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.新的保险ToolStripMenuItem.Text = "新的保险";
            this.新的保险ToolStripMenuItem.Click += new System.EventHandler(this.新的保险ToolStripMenuItem_Click);
            // 
            // 保险续费ToolStripMenuItem
            // 
            this.保险续费ToolStripMenuItem.Name = "保险续费ToolStripMenuItem";
            this.保险续费ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.保险续费ToolStripMenuItem.Text = "保险续费";
            this.保险续费ToolStripMenuItem.Click += new System.EventHandler(this.保险续费ToolStripMenuItem_Click);
            // 
            // 更改保险ToolStripMenuItem
            // 
            this.更改保险ToolStripMenuItem.Name = "更改保险ToolStripMenuItem";
            this.更改保险ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.更改保险ToolStripMenuItem.Text = "删除保险";
            this.更改保险ToolStripMenuItem.Click += new System.EventHandler(this.更改保险ToolStripMenuItem_Click);
            // 
            // 车辆事故ToolStripMenuItem
            // 
            this.车辆事故ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事故查询ToolStripMenuItem});
            this.车辆事故ToolStripMenuItem.Name = "车辆事故ToolStripMenuItem";
            this.车辆事故ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.车辆事故ToolStripMenuItem.Text = "车辆事故";
            // 
            // 事故查询ToolStripMenuItem
            // 
            this.事故查询ToolStripMenuItem.Name = "事故查询ToolStripMenuItem";
            this.事故查询ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.事故查询ToolStripMenuItem.Text = "事故查询";
            this.事故查询ToolStripMenuItem.Click += new System.EventHandler(this.事故查询ToolStripMenuItem_Click);
            // 
            // 赔偿事宜ToolStripMenuItem
            // 
            this.赔偿事宜ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询赔偿ToolStripMenuItem});
            this.赔偿事宜ToolStripMenuItem.Name = "赔偿事宜ToolStripMenuItem";
            this.赔偿事宜ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.赔偿事宜ToolStripMenuItem.Text = "赔偿事宜";
            // 
            // 查询赔偿ToolStripMenuItem
            // 
            this.查询赔偿ToolStripMenuItem.Name = "查询赔偿ToolStripMenuItem";
            this.查询赔偿ToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.查询赔偿ToolStripMenuItem.Text = "查询赔偿";
            this.查询赔偿ToolStripMenuItem.Click += new System.EventHandler(this.查询赔偿ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(305, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 70);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 480);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_Car);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Saler;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 已购买ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 将要过期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 所有保险信息ToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Car;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 我的车辆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部车辆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加车辆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除车辆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保险信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已经购买ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 即将过期ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全部种类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保险购买ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新的保险ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保险续费ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更改保险ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆事故ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 事故查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 赔偿事宜ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询赔偿ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}