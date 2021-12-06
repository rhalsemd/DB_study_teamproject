namespace DBpro
{
    partial class MsgView
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgView));
            this.sendid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.context_textbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // sendid_textbox
            // 
            this.sendid_textbox.Location = new System.Drawing.Point(130, 88);
            this.sendid_textbox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.sendid_textbox.Name = "sendid_textbox";
            this.sendid_textbox.ReadOnly = true;
            this.sendid_textbox.Size = new System.Drawing.Size(246, 28);
            this.sendid_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(50, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "발신:";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Location = new System.Drawing.Point(527, 16);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(72, 44);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(50, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "제목:";
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(130, 148);
            this.title_textbox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.ReadOnly = true;
            this.title_textbox.Size = new System.Drawing.Size(371, 28);
            this.title_textbox.TabIndex = 6;
            // 
            // context_textbox
            // 
            this.context_textbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.context_textbox.Location = new System.Drawing.Point(53, 208);
            this.context_textbox.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.ReadOnly = true;
            this.context_textbox.Size = new System.Drawing.Size(494, 299);
            this.context_textbox.TabIndex = 1;
            this.context_textbox.Text = "";
            // 
            // MsgView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(611, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendid_textbox);
            this.Controls.Add(this.context_textbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.Name = "MsgView";
            this.Text = "맛집찾아줘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox sendid_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.RichTextBox context_textbox;
    }
}