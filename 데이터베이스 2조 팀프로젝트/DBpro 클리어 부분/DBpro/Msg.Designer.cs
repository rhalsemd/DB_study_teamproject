namespace DBpro
{
    partial class Msg
    {
        /// <summary>
        /// Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Msg));
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridView_msg = new System.Windows.Forms.DataGridView();
            this.writemsg_btn = new System.Windows.Forms.Button();
            this.sentmsg_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.goback_btn = new System.Windows.Forms.Button();
            this.groupmsg_btn = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_msg)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView_msg
            // 
            this.dataGridView_msg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_msg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_msg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_msg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_msg.Location = new System.Drawing.Point(153, 80);
            this.dataGridView_msg.MultiSelect = false;
            this.dataGridView_msg.Name = "dataGridView_msg";
            this.dataGridView_msg.ReadOnly = true;
            this.dataGridView_msg.RowTemplate.Height = 23;
            this.dataGridView_msg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_msg.Size = new System.Drawing.Size(645, 388);
            this.dataGridView_msg.TabIndex = 0;
            this.dataGridView_msg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_msg_CellDoubleClick);
            // 
            // writemsg_btn
            // 
            this.writemsg_btn.BackColor = System.Drawing.Color.White;
            this.writemsg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writemsg_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.writemsg_btn.Location = new System.Drawing.Point(10, 217);
            this.writemsg_btn.Name = "writemsg_btn";
            this.writemsg_btn.Size = new System.Drawing.Size(123, 39);
            this.writemsg_btn.TabIndex = 1;
            this.writemsg_btn.Text = "쪽지 쓰기";
            this.writemsg_btn.UseVisualStyleBackColor = false;
            this.writemsg_btn.Click += new System.EventHandler(this.writemsg_btn_Click);
            // 
            // sentmsg_btn
            // 
            this.sentmsg_btn.BackColor = System.Drawing.Color.White;
            this.sentmsg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sentmsg_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.sentmsg_btn.Location = new System.Drawing.Point(10, 171);
            this.sentmsg_btn.Name = "sentmsg_btn";
            this.sentmsg_btn.Size = new System.Drawing.Size(123, 39);
            this.sentmsg_btn.TabIndex = 2;
            this.sentmsg_btn.Text = "보낸 쪽지함";
            this.sentmsg_btn.UseVisualStyleBackColor = false;
            this.sentmsg_btn.Click += new System.EventHandler(this.sentmsg_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.home_btn.Location = new System.Drawing.Point(757, 22);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(78, 38);
            this.home_btn.TabIndex = 4;
            this.home_btn.Text = "Exit";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // goback_btn
            // 
            this.goback_btn.BackColor = System.Drawing.Color.White;
            this.goback_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.goback_btn.Location = new System.Drawing.Point(10, 80);
            this.goback_btn.Name = "goback_btn";
            this.goback_btn.Size = new System.Drawing.Size(123, 39);
            this.goback_btn.TabIndex = 5;
            this.goback_btn.Text = "받은쪽지함";
            this.goback_btn.UseVisualStyleBackColor = false;
            this.goback_btn.Click += new System.EventHandler(this.goback_btn_Click);
            // 
            // groupmsg_btn
            // 
            this.groupmsg_btn.BackColor = System.Drawing.Color.White;
            this.groupmsg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupmsg_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.groupmsg_btn.Location = new System.Drawing.Point(10, 126);
            this.groupmsg_btn.Name = "groupmsg_btn";
            this.groupmsg_btn.Size = new System.Drawing.Size(123, 39);
            this.groupmsg_btn.TabIndex = 6;
            this.groupmsg_btn.Text = "그룹 쪽지함";
            this.groupmsg_btn.UseVisualStyleBackColor = false;
            this.groupmsg_btn.Click += new System.EventHandler(this.groupmsg_btn_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.BackColor = System.Drawing.Color.White;
            this.user_label.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.user_label.Location = new System.Drawing.Point(602, 22);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(51, 19);
            this.user_label.TabIndex = 7;
            this.user_label.Text = "label1";
            // 
            // Msg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(855, 546);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.groupmsg_btn);
            this.Controls.Add(this.goback_btn);
            this.Controls.Add(this.home_btn);
            this.Controls.Add(this.sentmsg_btn);
            this.Controls.Add(this.writemsg_btn);
            this.Controls.Add(this.dataGridView_msg);
            this.Name = "Msg";
            this.Text = "맛집찾아줘";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_msg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView_msg;
        private System.Windows.Forms.Button writemsg_btn;
        private System.Windows.Forms.Button sentmsg_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button goback_btn;
        private System.Windows.Forms.Button groupmsg_btn;
        private System.Windows.Forms.Label user_label;
    }
}