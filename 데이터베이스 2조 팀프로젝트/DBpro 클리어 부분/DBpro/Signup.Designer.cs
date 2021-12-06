namespace DBpro
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.Phonetextbox = new System.Windows.Forms.TextBox();
            this.Birthtextbox = new System.Windows.Forms.TextBox();
            this.checkMale = new System.Windows.Forms.CheckBox();
            this.checkFemale = new System.Windows.Forms.CheckBox();
            this.PWwritetextbox = new System.Windows.Forms.TextBox();
            this.PWConfirmtextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AssignConfirm = new System.Windows.Forms.Button();
            this.AssignCancel = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Addrtextbox = new System.Windows.Forms.TextBox();
            this.주소 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nametextbox
            // 
            this.Nametextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.Nametextbox.Location = new System.Drawing.Point(173, 312);
            this.Nametextbox.Multiline = true;
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(346, 34);
            this.Nametextbox.TabIndex = 0;
            // 
            // Phonetextbox
            // 
            this.Phonetextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.Phonetextbox.Location = new System.Drawing.Point(173, 395);
            this.Phonetextbox.Multiline = true;
            this.Phonetextbox.Name = "Phonetextbox";
            this.Phonetextbox.Size = new System.Drawing.Size(346, 34);
            this.Phonetextbox.TabIndex = 2;
            this.Phonetextbox.Text = "\'-\'를 제외한 11자리를 입력하십시오";
            this.Phonetextbox.Click += new System.EventHandler(this.Phonetextbox_Click);
            // 
            // Birthtextbox
            // 
            this.Birthtextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.Birthtextbox.Location = new System.Drawing.Point(173, 435);
            this.Birthtextbox.Multiline = true;
            this.Birthtextbox.Name = "Birthtextbox";
            this.Birthtextbox.Size = new System.Drawing.Size(346, 34);
            this.Birthtextbox.TabIndex = 3;
            // 
            // checkMale
            // 
            this.checkMale.AutoSize = true;
            this.checkMale.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.checkMale.Location = new System.Drawing.Point(174, 475);
            this.checkMale.Name = "checkMale";
            this.checkMale.Size = new System.Drawing.Size(56, 23);
            this.checkMale.TabIndex = 4;
            this.checkMale.Text = "남자";
            this.checkMale.UseVisualStyleBackColor = true;
            // 
            // checkFemale
            // 
            this.checkFemale.AutoSize = true;
            this.checkFemale.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.checkFemale.Location = new System.Drawing.Point(260, 475);
            this.checkFemale.Name = "checkFemale";
            this.checkFemale.Size = new System.Drawing.Size(56, 23);
            this.checkFemale.TabIndex = 5;
            this.checkFemale.Text = "여자";
            this.checkFemale.UseVisualStyleBackColor = true;
            // 
            // PWwritetextbox
            // 
            this.PWwritetextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.PWwritetextbox.Location = new System.Drawing.Point(173, 503);
            this.PWwritetextbox.Multiline = true;
            this.PWwritetextbox.Name = "PWwritetextbox";
            this.PWwritetextbox.PasswordChar = '*';
            this.PWwritetextbox.Size = new System.Drawing.Size(346, 34);
            this.PWwritetextbox.TabIndex = 6;
            // 
            // PWConfirmtextbox
            // 
            this.PWConfirmtextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.PWConfirmtextbox.Location = new System.Drawing.Point(174, 543);
            this.PWConfirmtextbox.Multiline = true;
            this.PWConfirmtextbox.Name = "PWConfirmtextbox";
            this.PWConfirmtextbox.PasswordChar = '*';
            this.PWConfirmtextbox.Size = new System.Drawing.Size(345, 34);
            this.PWConfirmtextbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(57, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "전화번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(57, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "나이";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "비밀번호입력";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(57, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "비밀번호확인";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(57, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "성별";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "SIGN UP";
            // 
            // AssignConfirm
            // 
            this.AssignConfirm.BackColor = System.Drawing.Color.Black;
            this.AssignConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignConfirm.Font = new System.Drawing.Font("Ink Free", 11.2F, System.Drawing.FontStyle.Bold);
            this.AssignConfirm.ForeColor = System.Drawing.Color.White;
            this.AssignConfirm.Location = new System.Drawing.Point(227, 597);
            this.AssignConfirm.Name = "AssignConfirm";
            this.AssignConfirm.Size = new System.Drawing.Size(115, 39);
            this.AssignConfirm.TabIndex = 16;
            this.AssignConfirm.Text = "sign";
            this.AssignConfirm.UseVisualStyleBackColor = false;
            this.AssignConfirm.Click += new System.EventHandler(this.AssignConfirm_Click);
            // 
            // AssignCancel
            // 
            this.AssignCancel.BackColor = System.Drawing.Color.White;
            this.AssignCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignCancel.Font = new System.Drawing.Font("Ink Free", 11.2F, System.Drawing.FontStyle.Bold);
            this.AssignCancel.Location = new System.Drawing.Point(347, 597);
            this.AssignCancel.Name = "AssignCancel";
            this.AssignCancel.Size = new System.Drawing.Size(110, 39);
            this.AssignCancel.TabIndex = 17;
            this.AssignCancel.Text = "cancel";
            this.AssignCancel.UseVisualStyleBackColor = false;
            this.AssignCancel.Click += new System.EventHandler(this.AssignCancel_Click);
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
            // IDtextbox
            // 
            this.IDtextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.IDtextbox.Location = new System.Drawing.Point(173, 270);
            this.IDtextbox.Multiline = true;
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.Size = new System.Drawing.Size(346, 37);
            this.IDtextbox.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(57, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "아이디";
            // 
            // Addrtextbox
            // 
            this.Addrtextbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.Addrtextbox.Location = new System.Drawing.Point(173, 352);
            this.Addrtextbox.Multiline = true;
            this.Addrtextbox.Name = "Addrtextbox";
            this.Addrtextbox.Size = new System.Drawing.Size(346, 37);
            this.Addrtextbox.TabIndex = 20;
            // 
            // 주소
            // 
            this.주소.AutoSize = true;
            this.주소.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold);
            this.주소.Location = new System.Drawing.Point(57, 362);
            this.주소.Name = "주소";
            this.주소.Size = new System.Drawing.Size(39, 20);
            this.주소.TabIndex = 21;
            this.주소.Text = "주소";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.주소);
            this.groupBox1.Controls.Add(this.Addrtextbox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.IDtextbox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AssignCancel);
            this.groupBox1.Controls.Add(this.AssignConfirm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PWConfirmtextbox);
            this.groupBox1.Controls.Add(this.PWwritetextbox);
            this.groupBox1.Controls.Add(this.checkFemale);
            this.groupBox1.Controls.Add(this.checkMale);
            this.groupBox1.Controls.Add(this.Birthtextbox);
            this.groupBox1.Controls.Add(this.Phonetextbox);
            this.groupBox1.Controls.Add(this.Nametextbox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(468, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(605, 653);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::DBpro.Properties.Resources.default_user;
            this.pictureBox1.Location = new System.Drawing.Point(174, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(57, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "프로필 사진";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Ink Free", 11.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(416, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "찾아보기";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(1078, 38);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(391, 123);
            this.panel4.TabIndex = 25;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1684, 825);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Signup";
            this.Text = "맛집찾아줘";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.TextBox Phonetextbox;
        private System.Windows.Forms.TextBox Birthtextbox;
        private System.Windows.Forms.CheckBox checkMale;
        private System.Windows.Forms.CheckBox checkFemale;
        private System.Windows.Forms.TextBox PWwritetextbox;
        private System.Windows.Forms.TextBox PWConfirmtextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AssignConfirm;
        private System.Windows.Forms.Button AssignCancel;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Addrtextbox;
        private System.Windows.Forms.Label 주소;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
    }
}

