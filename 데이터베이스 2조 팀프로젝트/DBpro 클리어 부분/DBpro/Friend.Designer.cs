namespace DBpro
{
    partial class Friend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Friend));
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.listView4 = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.post_move_btn = new System.Windows.Forms.Button();
            this.Message_move_btn = new System.Windows.Forms.Button();
            this.Friends_move_btn = new System.Windows.Forms.Button();
            this.Group_move_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.logout);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-16, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1411, 50);
            this.panel1.TabIndex = 11;
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1282, 13);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 28);
            this.logout.TabIndex = 14;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Message";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(1132, 13);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(136, 28);
            this.login.TabIndex = 13;
            this.login.Text = "edit profile ";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(160, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Home";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "group";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(262, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "friend";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.listView2);
            this.panel5.Location = new System.Drawing.Point(788, 622);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 293);
            this.panel5.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "<UnFollow List>";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(27, 48);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(417, 230);
            this.listView2.TabIndex = 10;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "아이디";
            this.columnHeader11.Width = 96;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "이름";
            this.columnHeader12.Width = 95;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "나이";
            this.columnHeader13.Width = 88;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "성별";
            this.columnHeader14.Width = 94;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "지역";
            this.columnHeader15.Width = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.listView4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(286, 622);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(469, 293);
            this.panel4.TabIndex = 20;
            // 
            // listView4
            // 
            this.listView4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20});
            this.listView4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(22, 48);
            this.listView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(417, 230);
            this.listView4.TabIndex = 11;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "아이디";
            this.columnHeader16.Width = 96;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "이름";
            this.columnHeader17.Width = 95;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "나이";
            this.columnHeader18.Width = 88;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "성별";
            this.columnHeader19.Width = 94;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "지역";
            this.columnHeader20.Width = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(27, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "<Follow List>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.post_move_btn);
            this.panel2.Controls.Add(this.Message_move_btn);
            this.panel2.Controls.Add(this.Friends_move_btn);
            this.panel2.Controls.Add(this.Group_move_btn);
            this.panel2.Location = new System.Drawing.Point(88, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 234);
            this.panel2.TabIndex = 18;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.listView3);
            this.groupBox1.Location = new System.Drawing.Point(286, 270);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(971, 334);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tempus Sans ITC", 12.8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(444, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 23);
            this.label12.TabIndex = 14;
            this.label12.Text = "<User List>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tempus Sans ITC", 12.8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(95, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "<My Friend>";
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(85, 145);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(818, 176);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick_1);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "아이디";
            this.columnHeader6.Width = 123;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "이름";
            this.columnHeader7.Width = 134;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "나이";
            this.columnHeader8.Width = 153;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "성별";
            this.columnHeader9.Width = 201;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "지역";
            this.columnHeader10.Width = 150;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(255, 39);
            this.listView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(494, 81);
            this.listView3.TabIndex = 2;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView3_MouseClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "아이디";
            this.columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "나이";
            this.columnHeader3.Width = 73;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "성별";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "지역";
            this.columnHeader5.Width = 108;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(966, 232);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 16;
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.search_button.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.Color.White;
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.search_button.Location = new System.Drawing.Point(1170, 223);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(82, 38);
            this.search_button.TabIndex = 15;
            this.search_button.Text = "search";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(-16, 42);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1385, 177);
            this.panel3.TabIndex = 22;
            // 
            // Friend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1376, 825);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Friend";
            this.Text = "맛집찾아줘";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button post_move_btn;
        private System.Windows.Forms.Button Message_move_btn;
        private System.Windows.Forms.Button Friends_move_btn;
        private System.Windows.Forms.Button Group_move_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.ColumnHeader columnHeader10;
        public System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
    }
}