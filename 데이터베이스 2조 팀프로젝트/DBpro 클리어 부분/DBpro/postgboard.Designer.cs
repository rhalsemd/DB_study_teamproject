namespace DBpro
{
    partial class postgboard
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
            this.group = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboard_image = new System.Windows.Forms.PictureBox();
            this.context_textbox = new System.Windows.Forms.TextBox();
            this.post_add_btn = new System.Windows.Forms.Button();
            this.post_load_image_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).BeginInit();
            this.SuspendLayout();
            // 
            // group
            // 
            this.group.Controls.Add(this.label2);
            this.group.Controls.Add(this.gboard_image);
            this.group.Location = new System.Drawing.Point(577, 133);
            this.group.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group.Name = "group";
            this.group.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.group.Size = new System.Drawing.Size(316, 229);
            this.group.TabIndex = 21;
            this.group.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Image";
            // 
            // gboard_image
            // 
            this.gboard_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gboard_image.Location = new System.Drawing.Point(11, 15);
            this.gboard_image.Name = "gboard_image";
            this.gboard_image.Size = new System.Drawing.Size(300, 205);
            this.gboard_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gboard_image.TabIndex = 4;
            this.gboard_image.TabStop = false;
            // 
            // context_textbox
            // 
            this.context_textbox.Font = new System.Drawing.Font("맑은 고딕", 9.8F);
            this.context_textbox.Location = new System.Drawing.Point(30, 148);
            this.context_textbox.Multiline = true;
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.Size = new System.Drawing.Size(508, 205);
            this.context_textbox.TabIndex = 13;
            // 
            // post_add_btn
            // 
            this.post_add_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_add_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.post_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.post_add_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.post_add_btn.Location = new System.Drawing.Point(808, 368);
            this.post_add_btn.Name = "post_add_btn";
            this.post_add_btn.Size = new System.Drawing.Size(84, 24);
            this.post_add_btn.TabIndex = 14;
            this.post_add_btn.Text = "POST";
            this.post_add_btn.UseVisualStyleBackColor = false;
            this.post_add_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // post_load_image_btn
            // 
            this.post_load_image_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.post_load_image_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.post_load_image_btn.Image = global::DBpro.Properties.Resources.이미지_불러오기;
            this.post_load_image_btn.Location = new System.Drawing.Point(777, 368);
            this.post_load_image_btn.Name = "post_load_image_btn";
            this.post_load_image_btn.Size = new System.Drawing.Size(26, 23);
            this.post_load_image_btn.TabIndex = 15;
            this.post_load_image_btn.UseVisualStyleBackColor = false;
            this.post_load_image_btn.Click += new System.EventHandler(this.post_load_image_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Post Content";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.White;
            this.return_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Ink Free", 12F);
            this.return_btn.Location = new System.Drawing.Point(30, 363);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(80, 28);
            this.return_btn.TabIndex = 23;
            this.return_btn.Text = "EXIT";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 37);
            this.label8.TabIndex = 98;
            this.label8.Text = "Post";
            // 
            // postgboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(928, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.group);
            this.Controls.Add(this.context_textbox);
            this.Controls.Add(this.post_add_btn);
            this.Controls.Add(this.post_load_image_btn);
            this.Name = "postgboard";
            this.Text = "맛집찾아줘";
            this.group.ResumeLayout(false);
            this.group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gboard_image;
        private System.Windows.Forms.TextBox context_textbox;
        private System.Windows.Forms.Button post_add_btn;
        private System.Windows.Forms.Button post_load_image_btn;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label label8;
    }
}