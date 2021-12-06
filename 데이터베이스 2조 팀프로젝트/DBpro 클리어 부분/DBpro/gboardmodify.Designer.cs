namespace DBpro
{
    partial class gboardmodify
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
            this.writer_name_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.context_textbox = new System.Windows.Forms.TextBox();
            this.post_add_btn = new System.Windows.Forms.Button();
            this.post_load_image_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gboard_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).BeginInit();
            this.SuspendLayout();
            // 
            // writer_name_label
            // 
            this.writer_name_label.AutoSize = true;
            this.writer_name_label.BackColor = System.Drawing.Color.Transparent;
            this.writer_name_label.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.writer_name_label.Location = new System.Drawing.Point(179, 144);
            this.writer_name_label.Name = "writer_name_label";
            this.writer_name_label.Size = new System.Drawing.Size(39, 20);
            this.writer_name_label.TabIndex = 23;
            this.writer_name_label.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(108, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "작성자:";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.White;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(800, 29);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(115, 50);
            this.exit_btn.TabIndex = 21;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // context_textbox
            // 
            this.context_textbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.context_textbox.Location = new System.Drawing.Point(31, 188);
            this.context_textbox.Multiline = true;
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.Size = new System.Drawing.Size(508, 205);
            this.context_textbox.TabIndex = 26;
            // 
            // post_add_btn
            // 
            this.post_add_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_add_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.post_add_btn.Location = new System.Drawing.Point(748, 419);
            this.post_add_btn.Name = "post_add_btn";
            this.post_add_btn.Size = new System.Drawing.Size(95, 31);
            this.post_add_btn.TabIndex = 27;
            this.post_add_btn.Text = "MODIFY";
            this.post_add_btn.UseVisualStyleBackColor = false;
            this.post_add_btn.Click += new System.EventHandler(this.post_add_btn_Click);
            // 
            // post_load_image_btn
            // 
            this.post_load_image_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_load_image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.post_load_image_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_load_image_btn.Image = global::DBpro.Properties.Resources.이미지_불러오기;
            this.post_load_image_btn.Location = new System.Drawing.Point(858, 419);
            this.post_load_image_btn.Name = "post_load_image_btn";
            this.post_load_image_btn.Size = new System.Drawing.Size(26, 31);
            this.post_load_image_btn.TabIndex = 28;
            this.post_load_image_btn.UseVisualStyleBackColor = false;
            this.post_load_image_btn.Click += new System.EventHandler(this.post_load_image_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 31;
            this.label1.Text = "Edit Your Post";
            // 
            // gboard_image
            // 
            this.gboard_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gboard_image.Location = new System.Drawing.Point(584, 187);
            this.gboard_image.Name = "gboard_image";
            this.gboard_image.Size = new System.Drawing.Size(300, 205);
            this.gboard_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gboard_image.TabIndex = 4;
            this.gboard_image.TabStop = false;
            // 
            // gboardmodify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 540);
            this.Controls.Add(this.gboard_image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.context_textbox);
            this.Controls.Add(this.post_add_btn);
            this.Controls.Add(this.post_load_image_btn);
            this.Controls.Add(this.writer_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_btn);
            this.Name = "gboardmodify";
            this.Text = "맛집찾아줘";
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label writer_name_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox context_textbox;
        private System.Windows.Forms.Button post_add_btn;
        private System.Windows.Forms.Button post_load_image_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gboard_image;
    }
}