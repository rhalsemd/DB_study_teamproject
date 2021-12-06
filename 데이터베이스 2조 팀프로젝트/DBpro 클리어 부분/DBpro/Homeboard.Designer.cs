namespace DBpro
{
    partial class Homeboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gcomment_btn = new System.Windows.Forms.Button();
            this.comment_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.commentgridview = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.댓글수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.댓글삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_btn = new System.Windows.Forms.Button();
            this.refresh_comment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.context_textbox = new System.Windows.Forms.RichTextBox();
            this.post_picture = new System.Windows.Forms.PictureBox();
            this.post_user = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.commentgridview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_user)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // gcomment_btn
            // 
            this.gcomment_btn.BackColor = System.Drawing.Color.Black;
            this.gcomment_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.gcomment_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gcomment_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.gcomment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_btn.ForeColor = System.Drawing.Color.White;
            this.gcomment_btn.Location = new System.Drawing.Point(637, 452);
            this.gcomment_btn.Name = "gcomment_btn";
            this.gcomment_btn.Size = new System.Drawing.Size(83, 38);
            this.gcomment_btn.TabIndex = 25;
            this.gcomment_btn.Text = "Submit";
            this.gcomment_btn.UseVisualStyleBackColor = false;
            this.gcomment_btn.Click += new System.EventHandler(this.gcomment_btn_Click);
            // 
            // comment_textbox
            // 
            this.comment_textbox.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.comment_textbox.Location = new System.Drawing.Point(178, 460);
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(446, 23);
            this.comment_textbox.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(91, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Comment";
            // 
            // commentgridview
            // 
            this.commentgridview.AllowUserToAddRows = false;
            this.commentgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentgridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.commentgridview.BackgroundColor = System.Drawing.Color.White;
            this.commentgridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.commentgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentgridview.ColumnHeadersVisible = false;
            this.commentgridview.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.commentgridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.commentgridview.GridColor = System.Drawing.Color.White;
            this.commentgridview.Location = new System.Drawing.Point(78, 493);
            this.commentgridview.MultiSelect = false;
            this.commentgridview.Name = "commentgridview";
            this.commentgridview.RowTemplate.Height = 23;
            this.commentgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commentgridview.Size = new System.Drawing.Size(546, 137);
            this.commentgridview.TabIndex = 22;
            this.commentgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentgridview_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.댓글수정ToolStripMenuItem,
            this.댓글삭제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 48);
            // 
            // 댓글수정ToolStripMenuItem
            // 
            this.댓글수정ToolStripMenuItem.Name = "댓글수정ToolStripMenuItem";
            this.댓글수정ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.댓글수정ToolStripMenuItem.Text = "댓글 수정";
            this.댓글수정ToolStripMenuItem.Click += new System.EventHandler(this.댓글수정ToolStripMenuItem_Click);
            // 
            // 댓글삭제ToolStripMenuItem
            // 
            this.댓글삭제ToolStripMenuItem.Name = "댓글삭제ToolStripMenuItem";
            this.댓글삭제ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.댓글삭제ToolStripMenuItem.Text = "댓글 삭제";
            this.댓글삭제ToolStripMenuItem.Click += new System.EventHandler(this.댓글삭제ToolStripMenuItem_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(637, 10);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(115, 36);
            this.exit_btn.TabIndex = 27;
            this.exit_btn.Text = "Cancel";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // refresh_comment
            // 
            this.refresh_comment.BackColor = System.Drawing.Color.White;
            this.refresh_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_comment.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.refresh_comment.Location = new System.Drawing.Point(637, 493);
            this.refresh_comment.Name = "refresh_comment";
            this.refresh_comment.Size = new System.Drawing.Size(83, 38);
            this.refresh_comment.TabIndex = 28;
            this.refresh_comment.Text = "Refresh";
            this.refresh_comment.UseVisualStyleBackColor = false;
            this.refresh_comment.Click += new System.EventHandler(this.refresh_comment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.context_textbox);
            this.groupBox1.Controls.Add(this.post_picture);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(169, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(463, 414);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // context_textbox
            // 
            this.context_textbox.BackColor = System.Drawing.Color.White;
            this.context_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.context_textbox.Location = new System.Drawing.Point(10, 8);
            this.context_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.ReadOnly = true;
            this.context_textbox.Size = new System.Drawing.Size(445, 88);
            this.context_textbox.TabIndex = 9;
            this.context_textbox.Text = "";
            // 
            // post_picture
            // 
            this.post_picture.BackColor = System.Drawing.Color.Transparent;
            this.post_picture.Location = new System.Drawing.Point(10, 103);
            this.post_picture.Name = "post_picture";
            this.post_picture.Size = new System.Drawing.Size(445, 306);
            this.post_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_picture.TabIndex = 5;
            this.post_picture.TabStop = false;
            // 
            // post_user
            // 
            this.post_user.BackColor = System.Drawing.Color.Transparent;
            this.post_user.Location = new System.Drawing.Point(20, 49);
            this.post_user.Name = "post_user";
            this.post_user.Size = new System.Drawing.Size(144, 132);
            this.post_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_user.TabIndex = 5;
            this.post_user.TabStop = false;
            // 
            // Homeboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면;
            this.ClientSize = new System.Drawing.Size(770, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refresh_comment);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.gcomment_btn);
            this.Controls.Add(this.comment_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commentgridview);
            this.Controls.Add(this.post_user);
            this.Name = "Homeboard";
            this.Text = "맛집찾아줘";
            ((System.ComponentModel.ISupportInitialize)(this.commentgridview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.post_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.post_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox post_picture;
        private System.Windows.Forms.PictureBox post_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gcomment_btn;
        private System.Windows.Forms.TextBox comment_textbox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView commentgridview;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button refresh_comment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 댓글수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 댓글삭제ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox context_textbox;
    }
}