namespace DBpro
{
    partial class Gboard
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gboard));
            this.usermanage_btn = new System.Windows.Forms.Button();
            this.storeaddrlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.storetypelabel = new System.Windows.Forms.Label();
            this.storenamelabel = new System.Windows.Forms.Label();
            this.gnamelabel = new System.Windows.Forms.Label();
            this.exitgroup_btn = new System.Windows.Forms.Button();
            this.joingroup_btn = new System.Windows.Forms.Button();
            this.Storetype = new System.Windows.Forms.Label();
            this.Storename = new System.Windows.Forms.Label();
            this.Groupname = new System.Windows.Forms.Label();
            this.grouppicture = new System.Windows.Forms.PictureBox();
            this.Groupboard = new System.Windows.Forms.DataGridView();
            this.gboardstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.글수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.post_gboard_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.refresh_datagrid = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.message_label = new System.Windows.Forms.Label();
            this.Home_label = new System.Windows.Forms.Label();
            this.group_label = new System.Windows.Forms.Label();
            this.friend_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.post_move_btn = new System.Windows.Forms.Button();
            this.Message_move_btn = new System.Windows.Forms.Button();
            this.Friends_move_btn = new System.Windows.Forms.Button();
            this.Group_move_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grouppicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groupboard)).BeginInit();
            this.gboardstrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usermanage_btn
            // 
            this.usermanage_btn.BackColor = System.Drawing.Color.Black;
            this.usermanage_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usermanage_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.usermanage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usermanage_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.usermanage_btn.ForeColor = System.Drawing.Color.White;
            this.usermanage_btn.Location = new System.Drawing.Point(28, 220);
            this.usermanage_btn.Name = "usermanage_btn";
            this.usermanage_btn.Size = new System.Drawing.Size(252, 38);
            this.usermanage_btn.TabIndex = 12;
            this.usermanage_btn.Text = "Membership Management";
            this.usermanage_btn.UseVisualStyleBackColor = false;
            this.usermanage_btn.Click += new System.EventHandler(this.usermanage_btn_Click);
            // 
            // storeaddrlabel
            // 
            this.storeaddrlabel.AutoSize = true;
            this.storeaddrlabel.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.storeaddrlabel.Location = new System.Drawing.Point(196, 152);
            this.storeaddrlabel.Name = "storeaddrlabel";
            this.storeaddrlabel.Size = new System.Drawing.Size(134, 22);
            this.storeaddrlabel.TabIndex = 11;
            this.storeaddrlabel.Text = "storeaddrlabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(50, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Store Address:";
            // 
            // storetypelabel
            // 
            this.storetypelabel.AutoSize = true;
            this.storetypelabel.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.storetypelabel.Location = new System.Drawing.Point(178, 111);
            this.storetypelabel.Name = "storetypelabel";
            this.storetypelabel.Size = new System.Drawing.Size(133, 22);
            this.storetypelabel.TabIndex = 9;
            this.storetypelabel.Text = "storetypelabel";
            // 
            // storenamelabel
            // 
            this.storenamelabel.AutoSize = true;
            this.storenamelabel.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.storenamelabel.Location = new System.Drawing.Point(481, 71);
            this.storenamelabel.Name = "storenamelabel";
            this.storenamelabel.Size = new System.Drawing.Size(138, 22);
            this.storenamelabel.TabIndex = 8;
            this.storenamelabel.Text = "storenamelabel";
            // 
            // gnamelabel
            // 
            this.gnamelabel.AutoSize = true;
            this.gnamelabel.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.gnamelabel.Location = new System.Drawing.Point(178, 71);
            this.gnamelabel.Name = "gnamelabel";
            this.gnamelabel.Size = new System.Drawing.Size(104, 22);
            this.gnamelabel.TabIndex = 7;
            this.gnamelabel.Text = "gnamelabel";
            // 
            // exitgroup_btn
            // 
            this.exitgroup_btn.BackColor = System.Drawing.Color.Black;
            this.exitgroup_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitgroup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exitgroup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitgroup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitgroup_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exitgroup_btn.ForeColor = System.Drawing.Color.White;
            this.exitgroup_btn.Location = new System.Drawing.Point(824, 219);
            this.exitgroup_btn.Name = "exitgroup_btn";
            this.exitgroup_btn.Size = new System.Drawing.Size(167, 38);
            this.exitgroup_btn.TabIndex = 6;
            this.exitgroup_btn.Text = "Leave This Group";
            this.exitgroup_btn.UseVisualStyleBackColor = false;
            this.exitgroup_btn.Click += new System.EventHandler(this.exitgroup_btn_Click);
            // 
            // joingroup_btn
            // 
            this.joingroup_btn.BackColor = System.Drawing.Color.White;
            this.joingroup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joingroup_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.joingroup_btn.Location = new System.Drawing.Point(668, 219);
            this.joingroup_btn.Name = "joingroup_btn";
            this.joingroup_btn.Size = new System.Drawing.Size(150, 38);
            this.joingroup_btn.TabIndex = 5;
            this.joingroup_btn.Text = "Join This Group";
            this.joingroup_btn.UseVisualStyleBackColor = false;
            this.joingroup_btn.Click += new System.EventHandler(this.joingroup_btn_Click);
            // 
            // Storetype
            // 
            this.Storetype.AutoSize = true;
            this.Storetype.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.Storetype.Location = new System.Drawing.Point(50, 111);
            this.Storetype.Name = "Storetype";
            this.Storetype.Size = new System.Drawing.Size(110, 22);
            this.Storetype.TabIndex = 4;
            this.Storetype.Text = "Store Type:";
            // 
            // Storename
            // 
            this.Storename.AutoSize = true;
            this.Storename.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.Storename.Location = new System.Drawing.Point(355, 71);
            this.Storename.Name = "Storename";
            this.Storename.Size = new System.Drawing.Size(115, 22);
            this.Storename.TabIndex = 3;
            this.Storename.Text = "Store Name:";
            // 
            // Groupname
            // 
            this.Groupname.AutoSize = true;
            this.Groupname.Font = new System.Drawing.Font("Ink Free", 13F, System.Drawing.FontStyle.Bold);
            this.Groupname.Location = new System.Drawing.Point(50, 71);
            this.Groupname.Name = "Groupname";
            this.Groupname.Size = new System.Drawing.Size(119, 22);
            this.Groupname.TabIndex = 2;
            this.Groupname.Text = "Group Name:";
            // 
            // grouppicture
            // 
            this.grouppicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grouppicture.Location = new System.Drawing.Point(752, 11);
            this.grouppicture.Name = "grouppicture";
            this.grouppicture.Size = new System.Drawing.Size(240, 202);
            this.grouppicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grouppicture.TabIndex = 1;
            this.grouppicture.TabStop = false;
            // 
            // Groupboard
            // 
            this.Groupboard.AllowUserToAddRows = false;
            this.Groupboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Groupboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Groupboard.BackgroundColor = System.Drawing.Color.White;
            this.Groupboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groupboard.ContextMenuStrip = this.gboardstrip;
            this.Groupboard.Location = new System.Drawing.Point(130, 633);
            this.Groupboard.Name = "Groupboard";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Groupboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Groupboard.RowTemplate.Height = 23;
            this.Groupboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Groupboard.Size = new System.Drawing.Size(1038, 223);
            this.Groupboard.TabIndex = 1;
            this.Groupboard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groupboard_CellClick);
            this.Groupboard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groupboard_CellDoubleClick);
            // 
            // gboardstrip
            // 
            this.gboardstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gboardstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.글수정ToolStripMenuItem,
            this.글삭제ToolStripMenuItem});
            this.gboardstrip.Name = "gboardstrip";
            this.gboardstrip.Size = new System.Drawing.Size(115, 48);
            // 
            // 글수정ToolStripMenuItem
            // 
            this.글수정ToolStripMenuItem.Name = "글수정ToolStripMenuItem";
            this.글수정ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.글수정ToolStripMenuItem.Text = "글 수정";
            this.글수정ToolStripMenuItem.Click += new System.EventHandler(this.글수정ToolStripMenuItem_Click);
            // 
            // 글삭제ToolStripMenuItem
            // 
            this.글삭제ToolStripMenuItem.Name = "글삭제ToolStripMenuItem";
            this.글삭제ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.글삭제ToolStripMenuItem.Text = "글 삭제";
            this.글삭제ToolStripMenuItem.Click += new System.EventHandler(this.글삭제ToolStripMenuItem_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // post_gboard_btn
            // 
            this.post_gboard_btn.BackColor = System.Drawing.Color.White;
            this.post_gboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_gboard_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.post_gboard_btn.Location = new System.Drawing.Point(1024, 590);
            this.post_gboard_btn.Name = "post_gboard_btn";
            this.post_gboard_btn.Size = new System.Drawing.Size(144, 37);
            this.post_gboard_btn.TabIndex = 7;
            this.post_gboard_btn.Text = "Write Post";
            this.post_gboard_btn.UseVisualStyleBackColor = false;
            this.post_gboard_btn.Click += new System.EventHandler(this.post_gboard_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(1210, 600);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 19);
            this.textBox1.TabIndex = 9;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(1317, 595);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 27);
            this.button5.TabIndex = 10;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(1210, 630);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 212);
            this.listBox1.TabIndex = 11;
            // 
            // refresh_datagrid
            // 
            this.refresh_datagrid.BackColor = System.Drawing.Color.White;
            this.refresh_datagrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_datagrid.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.refresh_datagrid.Location = new System.Drawing.Point(920, 590);
            this.refresh_datagrid.Name = "refresh_datagrid";
            this.refresh_datagrid.Size = new System.Drawing.Size(99, 36);
            this.refresh_datagrid.TabIndex = 12;
            this.refresh_datagrid.Text = "Refresh";
            this.refresh_datagrid.UseVisualStyleBackColor = false;
            this.refresh_datagrid.Click += new System.EventHandler(this.refresh_datagrid_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(-161, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1673, 177);
            this.panel2.TabIndex = 16;
            // 
            // message_label
            // 
            this.message_label.AutoSize = true;
            this.message_label.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.Location = new System.Drawing.Point(411, 23);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(72, 19);
            this.message_label.TabIndex = 28;
            this.message_label.Text = "Message";
            this.message_label.Click += new System.EventHandler(this.message_label_Click);
            // 
            // Home_label
            // 
            this.Home_label.AutoSize = true;
            this.Home_label.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_label.Location = new System.Drawing.Point(141, 23);
            this.Home_label.Name = "Home_label";
            this.Home_label.Size = new System.Drawing.Size(47, 19);
            this.Home_label.TabIndex = 25;
            this.Home_label.Text = "Home";
            this.Home_label.Click += new System.EventHandler(this.Home_label_Click);
            // 
            // group_label
            // 
            this.group_label.AutoSize = true;
            this.group_label.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_label.Location = new System.Drawing.Point(318, 23);
            this.group_label.Name = "group_label";
            this.group_label.Size = new System.Drawing.Size(49, 19);
            this.group_label.TabIndex = 27;
            this.group_label.Text = "group";
            // 
            // friend_label
            // 
            this.friend_label.AutoSize = true;
            this.friend_label.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friend_label.Location = new System.Drawing.Point(229, 23);
            this.friend_label.Name = "friend_label";
            this.friend_label.Size = new System.Drawing.Size(51, 19);
            this.friend_label.TabIndex = 26;
            this.friend_label.Text = "friend";
            this.friend_label.Click += new System.EventHandler(this.friend_label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.usermanage_btn);
            this.panel1.Controls.Add(this.grouppicture);
            this.panel1.Controls.Add(this.storeaddrlabel);
            this.panel1.Controls.Add(this.Groupname);
            this.panel1.Controls.Add(this.Storename);
            this.panel1.Controls.Add(this.Storetype);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.joingroup_btn);
            this.panel1.Controls.Add(this.exitgroup_btn);
            this.panel1.Controls.Add(this.storetypelabel);
            this.panel1.Controls.Add(this.gnamelabel);
            this.panel1.Controls.Add(this.storenamelabel);
            this.panel1.Location = new System.Drawing.Point(130, 282);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 269);
            this.panel1.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.post_move_btn);
            this.panel3.Controls.Add(this.Message_move_btn);
            this.panel3.Controls.Add(this.Friends_move_btn);
            this.panel3.Controls.Add(this.Group_move_btn);
            this.panel3.Location = new System.Drawing.Point(1234, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 218);
            this.panel3.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(56, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 23);
            this.label10.TabIndex = 1;
            this.label10.Text = "menu";
            // 
            // post_move_btn
            // 
            this.post_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.post_move_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.post_move_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.post_move_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.post_move_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_move_btn.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_move_btn.ForeColor = System.Drawing.Color.Black;
            this.post_move_btn.Location = new System.Drawing.Point(3, 38);
            this.post_move_btn.Name = "post_move_btn";
            this.post_move_btn.Size = new System.Drawing.Size(162, 37);
            this.post_move_btn.TabIndex = 0;
            this.post_move_btn.Text = "Post";
            this.post_move_btn.UseVisualStyleBackColor = false;
            this.post_move_btn.Click += new System.EventHandler(this.post_move_btn_Click);
            // 
            // Message_move_btn
            // 
            this.Message_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Message_move_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Message_move_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.Message_move_btn.ForeColor = System.Drawing.Color.Black;
            this.Message_move_btn.Location = new System.Drawing.Point(3, 169);
            this.Message_move_btn.Name = "Message_move_btn";
            this.Message_move_btn.Size = new System.Drawing.Size(162, 37);
            this.Message_move_btn.TabIndex = 0;
            this.Message_move_btn.Text = "Message";
            this.Message_move_btn.UseVisualStyleBackColor = false;
            this.Message_move_btn.Click += new System.EventHandler(this.Message_move_btn_Click);
            // 
            // Friends_move_btn
            // 
            this.Friends_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Friends_move_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friends_move_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.Friends_move_btn.ForeColor = System.Drawing.Color.Black;
            this.Friends_move_btn.Location = new System.Drawing.Point(3, 81);
            this.Friends_move_btn.Name = "Friends_move_btn";
            this.Friends_move_btn.Size = new System.Drawing.Size(162, 39);
            this.Friends_move_btn.TabIndex = 0;
            this.Friends_move_btn.Text = "Friends";
            this.Friends_move_btn.UseVisualStyleBackColor = false;
            this.Friends_move_btn.Click += new System.EventHandler(this.Friends_move_btn_Click);
            // 
            // Group_move_btn
            // 
            this.Group_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Group_move_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Group_move_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.Group_move_btn.ForeColor = System.Drawing.Color.Black;
            this.Group_move_btn.Location = new System.Drawing.Point(3, 126);
            this.Group_move_btn.Name = "Group_move_btn";
            this.Group_move_btn.Size = new System.Drawing.Size(162, 36);
            this.Group_move_btn.TabIndex = 0;
            this.Group_move_btn.Text = "Group";
            this.Group_move_btn.UseVisualStyleBackColor = false;
            this.Group_move_btn.Click += new System.EventHandler(this.Group_move_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(1207, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "아이디를 입력해주세요!";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(1208, 18);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 28);
            this.login.TabIndex = 33;
            this.login.Text = "edit profile ";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1330, 18);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 28);
            this.logout.TabIndex = 32;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(136, 874);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1268, 18);
            this.panel4.TabIndex = 34;
            // 
            // Gboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1474, 825);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.message_label);
            this.Controls.Add(this.Home_label);
            this.Controls.Add(this.group_label);
            this.Controls.Add(this.friend_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.refresh_datagrid);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.post_gboard_btn);
            this.Controls.Add(this.Groupboard);
            this.Name = "Gboard";
            this.Text = "맛집찾아줘";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grouppicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Groupboard)).EndInit();
            this.gboardstrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Storename;
        private System.Windows.Forms.Label Groupname;
        private System.Windows.Forms.PictureBox grouppicture;
        private System.Windows.Forms.Label Storetype;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button exitgroup_btn;
        private System.Windows.Forms.Button joingroup_btn;
        private System.Windows.Forms.Button post_gboard_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label storetypelabel;
        private System.Windows.Forms.Label storenamelabel;
        private System.Windows.Forms.Label gnamelabel;
        private System.Windows.Forms.Label storeaddrlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip gboardstrip;
        private System.Windows.Forms.ToolStripMenuItem 글수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글삭제ToolStripMenuItem;
        private System.Windows.Forms.Button refresh_datagrid;
        public System.Windows.Forms.DataGridView Groupboard;
        private System.Windows.Forms.Button usermanage_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label message_label;
        private System.Windows.Forms.Label Home_label;
        private System.Windows.Forms.Label group_label;
        private System.Windows.Forms.Label friend_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button post_move_btn;
        private System.Windows.Forms.Button Message_move_btn;
        private System.Windows.Forms.Button Friends_move_btn;
        private System.Windows.Forms.Button Group_move_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel4;
    }
}
