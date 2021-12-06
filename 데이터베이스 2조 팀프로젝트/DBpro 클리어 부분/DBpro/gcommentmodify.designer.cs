namespace DBpro
{
    partial class gcommentmodify
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
            this.gcomment_modfy_textbox = new System.Windows.Forms.TextBox();
            this.gcomment_modify = new System.Windows.Forms.Button();
            this.gcomment_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gcomment_modfy_textbox
            // 
            this.gcomment_modfy_textbox.Location = new System.Drawing.Point(32, 110);
            this.gcomment_modfy_textbox.Multiline = true;
            this.gcomment_modfy_textbox.Name = "gcomment_modfy_textbox";
            this.gcomment_modfy_textbox.Size = new System.Drawing.Size(463, 71);
            this.gcomment_modfy_textbox.TabIndex = 0;
            // 
            // gcomment_modify
            // 
            this.gcomment_modify.BackColor = System.Drawing.Color.Black;
            this.gcomment_modify.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gcomment_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_modify.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_modify.ForeColor = System.Drawing.Color.White;
            this.gcomment_modify.Location = new System.Drawing.Point(527, 110);
            this.gcomment_modify.Name = "gcomment_modify";
            this.gcomment_modify.Size = new System.Drawing.Size(98, 30);
            this.gcomment_modify.TabIndex = 1;
            this.gcomment_modify.Text = "Edit";
            this.gcomment_modify.UseVisualStyleBackColor = false;
            this.gcomment_modify.Click += new System.EventHandler(this.gcomment_modify_Click);
            // 
            // gcomment_exit
            // 
            this.gcomment_exit.BackColor = System.Drawing.Color.White;
            this.gcomment_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_exit.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_exit.Location = new System.Drawing.Point(527, 150);
            this.gcomment_exit.Name = "gcomment_exit";
            this.gcomment_exit.Size = new System.Drawing.Size(98, 30);
            this.gcomment_exit.TabIndex = 2;
            this.gcomment_exit.Text = "Cancel";
            this.gcomment_exit.UseVisualStyleBackColor = false;
            this.gcomment_exit.Click += new System.EventHandler(this.gcomment_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Edit Your Comment";
            // 
            // gcommentmodify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면_60퍼;
            this.ClientSize = new System.Drawing.Size(646, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcomment_exit);
            this.Controls.Add(this.gcomment_modify);
            this.Controls.Add(this.gcomment_modfy_textbox);
            this.Name = "gcommentmodify";
            this.Text = "맛집찾아줘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gcomment_modfy_textbox;
        private System.Windows.Forms.Button gcomment_modify;
        private System.Windows.Forms.Button gcomment_exit;
        private System.Windows.Forms.Label label1;
    }
}