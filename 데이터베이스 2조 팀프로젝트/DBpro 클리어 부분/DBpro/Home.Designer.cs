namespace DBpro
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Message_move_btn = new System.Windows.Forms.Button();
            this.Group_move_btn = new System.Windows.Forms.Button();
            this.Friends_move_btn = new System.Windows.Forms.Button();
            this.post_move_btn = new System.Windows.Forms.Button();
            this.postMenu = new System.Windows.Forms.MenuStrip();
            this.post_search_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.post_add_picture = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.store_search_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.store_search_tb = new System.Windows.Forms.TextBox();
            this.post_add_context = new System.Windows.Forms.TextBox();
            this.secret_check = new System.Windows.Forms.CheckBox();
            this.post_add_btn = new System.Windows.Forms.Button();
            this.post_load_image_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.게시물수정 = new System.Windows.Forms.ToolStripMenuItem();
            this.게시물삭제 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.board_search_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_add_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Message_move_btn
            // 
            this.Message_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Message_move_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            this.Message_move_btn.MouseLeave += new System.EventHandler(this.Message_move_btn_MouseLeave);
            this.Message_move_btn.MouseHover += new System.EventHandler(this.Message_move_btn_MouseHover);
            // 
            // Group_move_btn
            // 
            this.Group_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Group_move_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            this.Group_move_btn.MouseLeave += new System.EventHandler(this.Group_move_btn_MouseLeave);
            this.Group_move_btn.MouseHover += new System.EventHandler(this.Group_move_btn_MouseHover);
            // 
            // Friends_move_btn
            // 
            this.Friends_move_btn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Friends_move_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
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
            this.Friends_move_btn.MouseLeave += new System.EventHandler(this.Friends_move_btn_MouseLeave);
            this.Friends_move_btn.MouseHover += new System.EventHandler(this.Friends_move_btn_MouseHover);
            // 
            // post_move_btn
            // 
            this.post_move_btn.BackColor = System.Drawing.Color.White;
            this.post_move_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.post_move_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.post_move_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
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
            this.post_move_btn.MouseLeave += new System.EventHandler(this.post_move_btn_MouseLeave);
            this.post_move_btn.MouseHover += new System.EventHandler(this.post_move_btn_MouseHover);
            // 
            // postMenu
            // 
            this.postMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.postMenu.Location = new System.Drawing.Point(0, 0);
            this.postMenu.Name = "postMenu";
            this.postMenu.Size = new System.Drawing.Size(1520, 24);
            this.postMenu.TabIndex = 14;
            // 
            // post_search_tb
            // 
            this.post_search_tb.Location = new System.Drawing.Point(1067, 18);
            this.post_search_tb.Name = "post_search_tb";
            this.post_search_tb.Size = new System.Drawing.Size(144, 21);
            this.post_search_tb.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.imageLabel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.post_add_picture);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.store_search_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.store_search_tb);
            this.panel1.Controls.Add(this.post_add_context);
            this.panel1.Controls.Add(this.secret_check);
            this.panel1.Controls.Add(this.post_add_btn);
            this.panel1.Controls.Add(this.post_load_image_btn);
            this.panel1.Location = new System.Drawing.Point(274, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 335);
            this.panel1.TabIndex = 7;
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.imageLabel.Location = new System.Drawing.Point(991, 115);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(89, 20);
            this.imageLabel.TabIndex = 14;
            this.imageLabel.Text = "포스트 사진";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(43, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 22);
            this.label7.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(32, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "store name";
            // 
            // post_add_picture
            // 
            this.post_add_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_add_picture.Location = new System.Drawing.Point(902, 13);
            this.post_add_picture.Name = "post_add_picture";
            this.post_add_picture.Size = new System.Drawing.Size(279, 236);
            this.post_add_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_add_picture.TabIndex = 4;
            this.post_add_picture.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.Location = new System.Drawing.Point(225, 225);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(660, 107);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // store_search_btn
            // 
            this.store_search_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store_search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.store_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.store_search_btn.Image = ((System.Drawing.Image)(resources.GetObject("store_search_btn.Image")));
            this.store_search_btn.Location = new System.Drawing.Point(162, 236);
            this.store_search_btn.Name = "store_search_btn";
            this.store_search_btn.Size = new System.Drawing.Size(36, 23);
            this.store_search_btn.TabIndex = 10;
            this.store_search_btn.UseVisualStyleBackColor = false;
            this.store_search_btn.Click += new System.EventHandler(this.store_search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // store_search_tb
            // 
            this.store_search_tb.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.store_search_tb.Location = new System.Drawing.Point(31, 236);
            this.store_search_tb.Name = "store_search_tb";
            this.store_search_tb.Size = new System.Drawing.Size(126, 25);
            this.store_search_tb.TabIndex = 5;
            // 
            // post_add_context
            // 
            this.post_add_context.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.post_add_context.Location = new System.Drawing.Point(225, 11);
            this.post_add_context.Multiline = true;
            this.post_add_context.Name = "post_add_context";
            this.post_add_context.Size = new System.Drawing.Size(660, 205);
            this.post_add_context.TabIndex = 0;
            // 
            // secret_check
            // 
            this.secret_check.AutoSize = true;
            this.secret_check.Font = new System.Drawing.Font("Ink Free", 13.8F);
            this.secret_check.Location = new System.Drawing.Point(71, 174);
            this.secret_check.Name = "secret_check";
            this.secret_check.Size = new System.Drawing.Size(80, 27);
            this.secret_check.TabIndex = 3;
            this.secret_check.Text = "비밀글";
            this.secret_check.UseVisualStyleBackColor = true;
            this.secret_check.CheckedChanged += new System.EventHandler(this.secret_check_CheckedChanged);
            // 
            // post_add_btn
            // 
            this.post_add_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.post_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_add_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.post_add_btn.Location = new System.Drawing.Point(902, 266);
            this.post_add_btn.Name = "post_add_btn";
            this.post_add_btn.Size = new System.Drawing.Size(234, 64);
            this.post_add_btn.TabIndex = 1;
            this.post_add_btn.Text = "POST";
            this.post_add_btn.UseVisualStyleBackColor = false;
            this.post_add_btn.Click += new System.EventHandler(this.post_add_btn_Click);
            // 
            // post_load_image_btn
            // 
            this.post_load_image_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_load_image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.post_load_image_btn.Image = global::DBpro.Properties.Resources.이미지_불러오기;
            this.post_load_image_btn.Location = new System.Drawing.Point(1155, 255);
            this.post_load_image_btn.Name = "post_load_image_btn";
            this.post_load_image_btn.Size = new System.Drawing.Size(26, 24);
            this.post_load_image_btn.TabIndex = 1;
            this.post_load_image_btn.UseVisualStyleBackColor = false;
            this.post_load_image_btn.Click += new System.EventHandler(this.post_load_image_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.post_move_btn);
            this.panel2.Controls.Add(this.Message_move_btn);
            this.panel2.Controls.Add(this.Friends_move_btn);
            this.panel2.Controls.Add(this.Group_move_btn);
            this.panel2.Location = new System.Drawing.Point(64, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 234);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "menu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(274, 601);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 288);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게시물수정,
            this.게시물삭제});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            // 
            // 게시물수정
            // 
            this.게시물수정.Name = "게시물수정";
            this.게시물수정.Size = new System.Drawing.Size(138, 22);
            this.게시물수정.Text = "게시물 수정";
            this.게시물수정.Click += new System.EventHandler(this.게시물수정_Click);
            // 
            // 게시물삭제
            // 
            this.게시물삭제.Name = "게시물삭제";
            this.게시물삭제.Size = new System.Drawing.Size(138, 22);
            this.게시물삭제.Text = "게시물 삭제";
            this.게시물삭제.Click += new System.EventHandler(this.게시물삭제_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.login);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.board_search_btn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.post_search_tb);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1517, 52);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Message";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.Color.White;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(1412, 10);
            this.logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(88, 28);
            this.logout.TabIndex = 12;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Group";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Black;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(1290, 10);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(117, 28);
            this.login.TabIndex = 11;
            this.login.Text = "edit profile ";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Friend";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // board_search_btn
            // 
            this.board_search_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.board_search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.board_search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_search_btn.Image = ((System.Drawing.Image)(resources.GetObject("board_search_btn.Image")));
            this.board_search_btn.Location = new System.Drawing.Point(1223, 14);
            this.board_search_btn.Name = "board_search_btn";
            this.board_search_btn.Size = new System.Drawing.Size(36, 23);
            this.board_search_btn.TabIndex = 10;
            this.board_search_btn.UseVisualStyleBackColor = false;
            this.board_search_btn.Click += new System.EventHandler(this.board_search_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Location = new System.Drawing.Point(0, 51);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1520, 168);
            this.panel5.TabIndex = 15;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1424, 825);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.postMenu);
            this.MainMenuStrip = this.postMenu;
            this.Name = "Home";
            this.Text = "맛집찾아줘";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_add_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button post_move_btn;
        private System.Windows.Forms.Button Message_move_btn;
        private System.Windows.Forms.Button Group_move_btn;
        private System.Windows.Forms.Button Friends_move_btn;
        private System.Windows.Forms.MenuStrip postMenu;
        private System.Windows.Forms.TextBox post_search_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox post_add_context;
        private System.Windows.Forms.Button post_add_btn;
        private System.Windows.Forms.CheckBox secret_check;
        private System.Windows.Forms.Button post_load_image_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button board_search_btn;
        private System.Windows.Forms.TextBox store_search_tb;
        private System.Windows.Forms.Button store_search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox post_add_picture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 게시물수정;
        private System.Windows.Forms.ToolStripMenuItem 게시물삭제;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label imageLabel;
    }
}

