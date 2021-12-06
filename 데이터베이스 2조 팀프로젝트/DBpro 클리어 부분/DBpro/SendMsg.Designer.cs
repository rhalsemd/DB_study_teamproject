namespace DBpro
{
    partial class SendMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMsg));
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.context_textbox = new System.Windows.Forms.RichTextBox();
            this.receive_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupradio1 = new System.Windows.Forms.RadioButton();
            this.send_btn = new System.Windows.Forms.Button();
            this.groupradio2 = new System.Windows.Forms.RadioButton();
            this.exit_btn = new System.Windows.Forms.Button();
            this.group_combo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // title_textbox
            // 
            this.title_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.title_textbox.Location = new System.Drawing.Point(216, 119);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(223, 21);
            this.title_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // context_textbox
            // 
            this.context_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.context_textbox.Font = new System.Drawing.Font("Ink Free", 10.2F);
            this.context_textbox.Location = new System.Drawing.Point(105, 158);
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.Size = new System.Drawing.Size(482, 273);
            this.context_textbox.TabIndex = 2;
            this.context_textbox.Text = "";
            // 
            // receive_textbox
            // 
            this.receive_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.receive_textbox.Location = new System.Drawing.Point(216, 93);
            this.receive_textbox.Name = "receive_textbox";
            this.receive_textbox.Size = new System.Drawing.Size(223, 21);
            this.receive_textbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // groupradio1
            // 
            this.groupradio1.AutoSize = true;
            this.groupradio1.BackColor = System.Drawing.Color.White;
            this.groupradio1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupradio1.BackgroundImage")));
            this.groupradio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupradio1.ForeColor = System.Drawing.Color.Black;
            this.groupradio1.Location = new System.Drawing.Point(23, 8);
            this.groupradio1.Name = "groupradio1";
            this.groupradio1.Size = new System.Drawing.Size(88, 28);
            this.groupradio1.TabIndex = 5;
            this.groupradio1.Text = "그룹쪽지";
            this.groupradio1.UseVisualStyleBackColor = false;
            this.groupradio1.CheckedChanged += new System.EventHandler(this.groupradio1_CheckedChanged);
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.send_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send_btn.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.send_btn.Location = new System.Drawing.Point(458, 95);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(74, 46);
            this.send_btn.TabIndex = 7;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // groupradio2
            // 
            this.groupradio2.AutoSize = true;
            this.groupradio2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupradio2.BackgroundImage")));
            this.groupradio2.Checked = true;
            this.groupradio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.groupradio2.ForeColor = System.Drawing.Color.Black;
            this.groupradio2.Location = new System.Drawing.Point(149, 8);
            this.groupradio2.Name = "groupradio2";
            this.groupradio2.Size = new System.Drawing.Size(88, 28);
            this.groupradio2.TabIndex = 8;
            this.groupradio2.TabStop = true;
            this.groupradio2.Text = "개인쪽지";
            this.groupradio2.UseVisualStyleBackColor = true;
            this.groupradio2.CheckedChanged += new System.EventHandler(this.groupradio2_CheckedChanged);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 13.2F, System.Drawing.FontStyle.Bold);
            this.exit_btn.Location = new System.Drawing.Point(602, 10);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(73, 38);
            this.exit_btn.TabIndex = 9;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // group_combo
            // 
            this.group_combo.BackColor = System.Drawing.SystemColors.Window;
            this.group_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_combo.FormattingEnabled = true;
            this.group_combo.Location = new System.Drawing.Point(216, 93);
            this.group_combo.Name = "group_combo";
            this.group_combo.Size = new System.Drawing.Size(223, 20);
            this.group_combo.TabIndex = 10;
            // 
            // SendMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(687, 538);
            this.Controls.Add(this.group_combo);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.groupradio2);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.groupradio1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.receive_textbox);
            this.Controls.Add(this.context_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textbox);
            this.DoubleBuffered = true;
            this.Name = "SendMsg";
            this.Text = "맛집찾아줘";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox context_textbox;
        private System.Windows.Forms.TextBox receive_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton groupradio1;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.RadioButton groupradio2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.ComboBox group_combo;
    }
}