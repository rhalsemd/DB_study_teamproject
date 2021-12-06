namespace DBpro
{
    partial class groupHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(groupHome));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupdeletestrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.그룹삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_message = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.label_friend = new System.Windows.Forms.Label();
            this.label_home = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.post_move_btn = new System.Windows.Forms.Button();
            this.Message_move_btn = new System.Windows.Forms.Button();
            this.Friends_move_btn = new System.Windows.Forms.Button();
            this.Group_move_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupdeletestrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.groupdeletestrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(127, 318);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 440);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupdeletestrip
            // 
            this.groupdeletestrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.groupdeletestrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그룹삭제ToolStripMenuItem});
            this.groupdeletestrip.Name = "contextMenuStrip1";
            this.groupdeletestrip.Size = new System.Drawing.Size(123, 26);
            // 
            // 그룹삭제ToolStripMenuItem
            // 
            this.그룹삭제ToolStripMenuItem.Name = "그룹삭제ToolStripMenuItem";
            this.그룹삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.그룹삭제ToolStripMenuItem.Text = "그룹삭제";
            this.그룹삭제ToolStripMenuItem.Click += new System.EventHandler(this.그룹삭제ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(127, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "New group";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1188, 280);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 31);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(1032, 286);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 21);
            this.textBox1.TabIndex = 4;
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Location = new System.Drawing.Point(685, 783);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(44, 42);
            this.refresh.TabIndex = 9;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label_message);
            this.panel1.Controls.Add(this.label_group);
            this.panel1.Controls.Add(this.label_friend);
            this.panel1.Controls.Add(this.label_home);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 55);
            this.panel1.TabIndex = 11;
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.Location = new System.Drawing.Point(393, 17);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(72, 19);
            this.label_message.TabIndex = 20;
            this.label_message.Text = "Message";
            this.label_message.Click += new System.EventHandler(this.label_message_Click);
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_group.Location = new System.Drawing.Point(299, 17);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(52, 19);
            this.label_group.TabIndex = 19;
            this.label_group.Text = "Group";
            // 
            // label_friend
            // 
            this.label_friend.AutoSize = true;
            this.label_friend.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_friend.Location = new System.Drawing.Point(200, 17);
            this.label_friend.Name = "label_friend";
            this.label_friend.Size = new System.Drawing.Size(54, 19);
            this.label_friend.TabIndex = 18;
            this.label_friend.Text = "Friend";
            this.label_friend.Click += new System.EventHandler(this.label_friend_Click);
            // 
            // label_home
            // 
            this.label_home.AutoSize = true;
            this.label_home.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_home.Location = new System.Drawing.Point(108, 17);
            this.label_home.Name = "label_home";
            this.label_home.Size = new System.Drawing.Size(47, 19);
            this.label_home.TabIndex = 17;
            this.label_home.Text = "Home";
            this.label_home.Click += new System.EventHandler(this.label_home_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1426, 11);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 28);
            this.logout.TabIndex = 13;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(1304, 11);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 28);
            this.login.TabIndex = 21;
            this.login.Text = "edit profile ";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(972, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Group";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(3, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1583, 179);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.post_move_btn);
            this.panel3.Controls.Add(this.Message_move_btn);
            this.panel3.Controls.Add(this.Friends_move_btn);
            this.panel3.Controls.Add(this.Group_move_btn);
            this.panel3.Location = new System.Drawing.Point(1320, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 234);
            this.panel3.TabIndex = 22;
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
            this.post_move_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.post_move_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(262, 279);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 33);
            this.button3.TabIndex = 23;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 825);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "groupHome";
            this.Text = "맛집찾아줘";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupdeletestrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.ContextMenuStrip groupdeletestrip;
        private System.Windows.Forms.ToolStripMenuItem 그룹삭제ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.Label label_friend;
        private System.Windows.Forms.Label label_home;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button post_move_btn;
        private System.Windows.Forms.Button Message_move_btn;
        private System.Windows.Forms.Button Friends_move_btn;
        private System.Windows.Forms.Button Group_move_btn;
        private System.Windows.Forms.Button button3;
    }
}

