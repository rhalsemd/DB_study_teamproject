namespace DBpro
{
    partial class CommentModify
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
            this.gcomment_exit = new System.Windows.Forms.Button();
            this.gcomment_modify = new System.Windows.Forms.Button();
            this.gcomment_modfy_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gcomment_exit
            // 
            this.gcomment_exit.BackColor = System.Drawing.Color.White;
            this.gcomment_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_exit.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_exit.Location = new System.Drawing.Point(520, 158);
            this.gcomment_exit.Name = "gcomment_exit";
            this.gcomment_exit.Size = new System.Drawing.Size(98, 30);
            this.gcomment_exit.TabIndex = 5;
            this.gcomment_exit.Text = "Cancel";
            this.gcomment_exit.UseVisualStyleBackColor = false;
            this.gcomment_exit.Click += new System.EventHandler(this.gcomment_exit_Click);
            // 
            // gcomment_modify
            // 
            this.gcomment_modify.BackColor = System.Drawing.Color.Black;
            this.gcomment_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_modify.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_modify.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gcomment_modify.Location = new System.Drawing.Point(520, 117);
            this.gcomment_modify.Name = "gcomment_modify";
            this.gcomment_modify.Size = new System.Drawing.Size(98, 30);
            this.gcomment_modify.TabIndex = 4;
            this.gcomment_modify.Text = "Edit";
            this.gcomment_modify.UseVisualStyleBackColor = false;
            this.gcomment_modify.Click += new System.EventHandler(this.gcomment_modify_Click);
            // 
            // gcomment_modfy_textbox
            // 
            this.gcomment_modfy_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcomment_modfy_textbox.Location = new System.Drawing.Point(32, 117);
            this.gcomment_modfy_textbox.Multiline = true;
            this.gcomment_modfy_textbox.Name = "gcomment_modfy_textbox";
            this.gcomment_modfy_textbox.Size = new System.Drawing.Size(463, 71);
            this.gcomment_modfy_textbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Edit Your Comment";
            // 
            // CommentModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면_60퍼;
            this.ClientSize = new System.Drawing.Size(656, 240);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcomment_exit);
            this.Controls.Add(this.gcomment_modify);
            this.Controls.Add(this.gcomment_modfy_textbox);
            this.Name = "CommentModify";
            this.Text = "맛집찾아줘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gcomment_exit;
        private System.Windows.Forms.Button gcomment_modify;
        private System.Windows.Forms.TextBox gcomment_modfy_textbox;
        private System.Windows.Forms.Label label1;
    }
}