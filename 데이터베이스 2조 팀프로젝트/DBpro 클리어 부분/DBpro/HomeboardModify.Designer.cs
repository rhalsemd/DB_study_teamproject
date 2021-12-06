namespace DBpro
{
    partial class HomeboardModify
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeboardModify));
            this.modify_btn = new System.Windows.Forms.Button();
            this.writer_name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.post_add_picture = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.store_search_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.store_search_tb = new System.Windows.Forms.TextBox();
            this.post_add_context = new System.Windows.Forms.TextBox();
            this.secret_check = new System.Windows.Forms.CheckBox();
            this.post_load_image_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_add_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.Color.Black;
            this.modify_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(736, 438);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(152, 36);
            this.modify_btn.TabIndex = 34;
            this.modify_btn.Text = "Edit";
            this.modify_btn.UseVisualStyleBackColor = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click_1);
            // 
            // writer_name_label
            // 
            this.writer_name_label.AutoSize = true;
            this.writer_name_label.Location = new System.Drawing.Point(31, -20);
            this.writer_name_label.Name = "writer_name_label";
            this.writer_name_label.Size = new System.Drawing.Size(29, 12);
            this.writer_name_label.TabIndex = 33;
            this.writer_name_label.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-16, -20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 32;
            this.label3.Text = "작성자";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(914, 438);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(152, 36);
            this.exit_btn.TabIndex = 31;
            this.exit_btn.Text = "Cancel";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.post_add_picture);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.store_search_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.store_search_tb);
            this.panel1.Controls.Add(this.post_add_context);
            this.panel1.Controls.Add(this.secret_check);
            this.panel1.Controls.Add(this.post_load_image_btn);
            this.panel1.Location = new System.Drawing.Point(30, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 335);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(54, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(24, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Store Name";
            // 
            // post_add_picture
            // 
            this.post_add_picture.Location = new System.Drawing.Point(776, 12);
            this.post_add_picture.Name = "post_add_picture";
            this.post_add_picture.Size = new System.Drawing.Size(279, 204);
            this.post_add_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_add_picture.TabIndex = 4;
            this.post_add_picture.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(225, 222);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(740, 107);
            this.dataGridView2.TabIndex = 13;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // store_search_btn
            // 
            this.store_search_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.store_search_btn.Image = ((System.Drawing.Image)(resources.GetObject("store_search_btn.Image")));
            this.store_search_btn.Location = new System.Drawing.Point(144, 250);
            this.store_search_btn.Name = "store_search_btn";
            this.store_search_btn.Size = new System.Drawing.Size(36, 23);
            this.store_search_btn.TabIndex = 10;
            this.store_search_btn.UseVisualStyleBackColor = false;
            this.store_search_btn.Click += new System.EventHandler(this.store_search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // store_search_tb
            // 
            this.store_search_tb.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.store_search_tb.Location = new System.Drawing.Point(27, 250);
            this.store_search_tb.Name = "store_search_tb";
            this.store_search_tb.Size = new System.Drawing.Size(112, 25);
            this.store_search_tb.TabIndex = 5;
            // 
            // post_add_context
            // 
            this.post_add_context.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.post_add_context.Location = new System.Drawing.Point(225, 11);
            this.post_add_context.Multiline = true;
            this.post_add_context.Name = "post_add_context";
            this.post_add_context.Size = new System.Drawing.Size(533, 205);
            this.post_add_context.TabIndex = 0;
            // 
            // secret_check
            // 
            this.secret_check.AutoSize = true;
            this.secret_check.Font = new System.Drawing.Font("맑은 고딕", 13.2F);
            this.secret_check.Location = new System.Drawing.Point(66, 170);
            this.secret_check.Name = "secret_check";
            this.secret_check.Size = new System.Drawing.Size(85, 29);
            this.secret_check.TabIndex = 3;
            this.secret_check.Text = "비밀글";
            this.secret_check.UseVisualStyleBackColor = true;
            this.secret_check.CheckedChanged += new System.EventHandler(this.secret_check_CheckedChanged);
            // 
            // post_load_image_btn
            // 
            this.post_load_image_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_load_image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.post_load_image_btn.Image = global::DBpro.Properties.Resources.이미지_불러오기;
            this.post_load_image_btn.Location = new System.Drawing.Point(984, 305);
            this.post_load_image_btn.Name = "post_load_image_btn";
            this.post_load_image_btn.Size = new System.Drawing.Size(26, 24);
            this.post_load_image_btn.TabIndex = 1;
            this.post_load_image_btn.UseVisualStyleBackColor = false;
            this.post_load_image_btn.Click += new System.EventHandler(this.post_load_image_btn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 15F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(129, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Edit Post";
            // 
            // HomeboardModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면;
            this.ClientSize = new System.Drawing.Size(1121, 493);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.writer_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_btn);
            this.Name = "HomeboardModify";
            this.Text = "맛집찾아줘";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_add_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Label writer_name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox post_add_picture;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button store_search_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox store_search_tb;
        private System.Windows.Forms.TextBox post_add_context;
        private System.Windows.Forms.CheckBox secret_check;
        private System.Windows.Forms.Button post_load_image_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}