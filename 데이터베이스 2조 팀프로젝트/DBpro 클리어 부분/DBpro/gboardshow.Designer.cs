namespace DBpro
{
    partial class gboardshow
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
            this.label2 = new System.Windows.Forms.Label();
            this.context_textbox = new System.Windows.Forms.RichTextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.writer_name_label = new System.Windows.Forms.Label();
            this.commentgridview = new System.Windows.Forms.DataGridView();
            this.gcommentstrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.댓글수정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.댓글삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.gcomment_btn = new System.Windows.Forms.Button();
            this.comment_textbox = new System.Windows.Forms.TextBox();
            this.refresh_comment = new System.Windows.Forms.Button();
            this.post_user = new System.Windows.Forms.PictureBox();
            this.gboard_image = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentgridview)).BeginInit();
            this.gcommentstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.post_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "내용";
            // 
            // context_textbox
            // 
            this.context_textbox.BackColor = System.Drawing.Color.White;
            this.context_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.context_textbox.Location = new System.Drawing.Point(6, 23);
            this.context_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.context_textbox.Name = "context_textbox";
            this.context_textbox.ReadOnly = true;
            this.context_textbox.Size = new System.Drawing.Size(525, 125);
            this.context_textbox.TabIndex = 8;
            this.context_textbox.Text = "";
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Black;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.exit_btn.ForeColor = System.Drawing.Color.White;
            this.exit_btn.Location = new System.Drawing.Point(753, 60);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(113, 48);
            this.exit_btn.TabIndex = 13;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(39, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "작성자";
            // 
            // writer_name_label
            // 
            this.writer_name_label.AutoSize = true;
            this.writer_name_label.BackColor = System.Drawing.Color.Transparent;
            this.writer_name_label.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.writer_name_label.Location = new System.Drawing.Point(88, 345);
            this.writer_name_label.Name = "writer_name_label";
            this.writer_name_label.Size = new System.Drawing.Size(31, 15);
            this.writer_name_label.TabIndex = 15;
            this.writer_name_label.Text = "이름";
            // 
            // commentgridview
            // 
            this.commentgridview.AllowUserToAddRows = false;
            this.commentgridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.commentgridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.commentgridview.BackgroundColor = System.Drawing.Color.White;
            this.commentgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentgridview.ColumnHeadersVisible = false;
            this.commentgridview.ContextMenuStrip = this.gcommentstrip;
            this.commentgridview.GridColor = System.Drawing.Color.White;
            this.commentgridview.Location = new System.Drawing.Point(208, 594);
            this.commentgridview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.commentgridview.Name = "commentgridview";
            this.commentgridview.RowTemplate.Height = 23;
            this.commentgridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.commentgridview.Size = new System.Drawing.Size(525, 132);
            this.commentgridview.TabIndex = 16;
            this.commentgridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.commentgridview_CellClick);
            // 
            // gcommentstrip
            // 
            this.gcommentstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gcommentstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.댓글수정ToolStripMenuItem,
            this.댓글삭제ToolStripMenuItem});
            this.gcommentstrip.Name = "gcommentstrip";
            this.gcommentstrip.Size = new System.Drawing.Size(123, 48);
            // 
            // 댓글수정ToolStripMenuItem
            // 
            this.댓글수정ToolStripMenuItem.Name = "댓글수정ToolStripMenuItem";
            this.댓글수정ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.댓글수정ToolStripMenuItem.Text = "댓글수정";
            this.댓글수정ToolStripMenuItem.Click += new System.EventHandler(this.댓글수정ToolStripMenuItem_Click);
            // 
            // 댓글삭제ToolStripMenuItem
            // 
            this.댓글삭제ToolStripMenuItem.Name = "댓글삭제ToolStripMenuItem";
            this.댓글삭제ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.댓글삭제ToolStripMenuItem.Text = "댓글삭제";
            this.댓글삭제ToolStripMenuItem.Click += new System.EventHandler(this.댓글삭제ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(104, 559);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Comment";
            // 
            // gcomment_btn
            // 
            this.gcomment_btn.BackColor = System.Drawing.Color.Black;
            this.gcomment_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gcomment_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.gcomment_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gcomment_btn.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.gcomment_btn.ForeColor = System.Drawing.Color.White;
            this.gcomment_btn.Location = new System.Drawing.Point(760, 559);
            this.gcomment_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcomment_btn.Name = "gcomment_btn";
            this.gcomment_btn.Size = new System.Drawing.Size(100, 38);
            this.gcomment_btn.TabIndex = 19;
            this.gcomment_btn.Text = "Submit";
            this.gcomment_btn.UseVisualStyleBackColor = false;
            this.gcomment_btn.Click += new System.EventHandler(this.gcomment_btn_Click);
            // 
            // comment_textbox
            // 
            this.comment_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comment_textbox.Location = new System.Drawing.Point(208, 559);
            this.comment_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comment_textbox.Name = "comment_textbox";
            this.comment_textbox.Size = new System.Drawing.Size(525, 23);
            this.comment_textbox.TabIndex = 18;
            // 
            // refresh_comment
            // 
            this.refresh_comment.BackColor = System.Drawing.Color.White;
            this.refresh_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh_comment.Font = new System.Drawing.Font("Ink Free", 10.8F, System.Drawing.FontStyle.Bold);
            this.refresh_comment.Location = new System.Drawing.Point(758, 605);
            this.refresh_comment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refresh_comment.Name = "refresh_comment";
            this.refresh_comment.Size = new System.Drawing.Size(102, 37);
            this.refresh_comment.TabIndex = 21;
            this.refresh_comment.Text = "Refresh";
            this.refresh_comment.UseVisualStyleBackColor = false;
            this.refresh_comment.Click += new System.EventHandler(this.refresh_comment_Click);
            // 
            // post_user
            // 
            this.post_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.post_user.Location = new System.Drawing.Point(43, 197);
            this.post_user.Name = "post_user";
            this.post_user.Size = new System.Drawing.Size(132, 125);
            this.post_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.post_user.TabIndex = 22;
            this.post_user.TabStop = false;
            // 
            // gboard_image
            // 
            this.gboard_image.Location = new System.Drawing.Point(6, 156);
            this.gboard_image.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gboard_image.Name = "gboard_image";
            this.gboard_image.Size = new System.Drawing.Size(525, 192);
            this.gboard_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gboard_image.TabIndex = 12;
            this.gboard_image.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.context_textbox);
            this.groupBox1.Controls.Add(this.gboard_image);
            this.groupBox1.Location = new System.Drawing.Point(208, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 370);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Group Post";
            // 
            // gboardshow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::DBpro.Properties.Resources.커피_배경화면2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.post_user);
            this.Controls.Add(this.refresh_comment);
            this.Controls.Add(this.gcomment_btn);
            this.Controls.Add(this.comment_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.commentgridview);
            this.Controls.Add(this.writer_name_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "gboardshow";
            this.Text = "맛집찾아줘";
            ((System.ComponentModel.ISupportInitialize)(this.commentgridview)).EndInit();
            this.gcommentstrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.post_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboard_image)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gboard_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox context_textbox;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label writer_name_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gcomment_btn;
        private System.Windows.Forms.ContextMenuStrip gcommentstrip;
        private System.Windows.Forms.ToolStripMenuItem 댓글수정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 댓글삭제ToolStripMenuItem;
        private System.Windows.Forms.TextBox comment_textbox;
        private System.Windows.Forms.Button refresh_comment;
        public System.Windows.Forms.DataGridView commentgridview;
        private System.Windows.Forms.PictureBox post_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}