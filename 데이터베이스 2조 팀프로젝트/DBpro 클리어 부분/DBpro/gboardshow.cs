using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpro
{
    public partial class gboardshow : Form
    {
        public gboardshow()
        {
            InitializeComponent();
            InitContent();
            InitComment();
            this.commentgridview.Columns[0].Visible = false;
        }

        private void InitContent()
        {
            try
            {
                String postuserid = "";
                String selectQuery = "SELECT * FROM mydb.gboard WHERE id = " + ConfigManager.GetInstance().gpostid + "";
                DataTable dt = DBManager.getInstance().select(selectQuery);

                foreach (DataRow row in dt.Rows)
                {
                    postuserid = writer_name_label.Text = row["uid"].ToString();
                    context_textbox.Text = row["content"].ToString();
                }

                try
                {
                    gboard_image.SizeMode = PictureBoxSizeMode.StretchImage;

                    //string uid = ConfigManager.GetInstance().GetUid();
                    Query query = new Query().Select("photo").From("gboard").Where("id = '" + ConfigManager.GetInstance().gpostid + "'");
                    DataTable gboard_dt = DBManager.getInstance().select(query.query);
                    if (!(gboard_dt.Rows[0][0].Equals(DBNull.Value)))
                    {
                        byte[] img = (byte[])gboard_dt.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);
                        gboard_image.Image = Image.FromStream(ms);
                    }
                }
                catch { }

                try
                {
                    post_user.Image = Properties.Resources.default_user;
                    //pictureBox1.Load("default");
                    post_user.SizeMode = PictureBoxSizeMode.StretchImage;

                    //string uid = ConfigManager.GetInstance().GetUid();
                    Query query = new Query().Select("photo").From("user").Where("id = '" + postuserid + "'");
                    DataTable user_dt = DBManager.getInstance().select(query.query);
                    if (!(user_dt.Rows[0][0].Equals(DBNull.Value)))
                    {
                        byte[] img = (byte[])user_dt.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);
                        post_user.Image = Image.FromStream(ms);
                    }
                }
                catch { }
            }
            catch { }
        }

        public void InitComment()
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("select id as '댓글번호', uid as 'id', comment as '내용', update_time as '댓글시간' from gcomment WHERE gid=" + ConfigManager.GetInstance().gid + " AND pid=" + ConfigManager.GetInstance().gpostid + " ORDER BY update_time DESC");
                commentgridview.DataSource = datesell;
                commentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch { }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch { }
        }

        private void gcomment_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                DBManager.getInstance().insert("insert into gcomment(pid, uid, comment, gid, update_time) values('" + ConfigManager.GetInstance().gpostid + "','" + ConfigManager.GetInstance().userid + "','" + comment_textbox.Text + "'," + ConfigManager.GetInstance().gid + ",'" + date + "')");
                InitComment();
                comment_textbox.Clear();
            }
            catch { }
        }

        private void 댓글수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = commentgridview.SelectedRows[0];
                gcommentmodify commentmodify = new gcommentmodify();

                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString())
                {
                    commentmodify.ShowDialog();
                }
                else { MessageBox.Show("내가 쓴 댓글이 아닙니다!"); }
            }
            catch { }
        }

        private void 댓글삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = commentgridview.SelectedRows[0];
                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString())
                {
                    if (MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBManager.getInstance().insert("DELETE FROM gcomment WHERE id=" + ConfigManager.GetInstance().gcid + " AND pid=" + ConfigManager.GetInstance().gpostid);
                        MessageBox.Show("삭제되었습니다!");
                        InitComment();
                    }
                    else
                    {

                    }
                }
                else { MessageBox.Show("내가 쓴 댓글이 아닙니다!"); }
            }
            catch { }
        }

        private void commentgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = commentgridview.SelectedRows[0];
                ConfigManager.GetInstance().gcid = Convert.ToInt32(dr.Cells[0].Value);
                MessageBox.Show("선택 되었습니다.");
            }
            catch { }
        }

        private void refresh_comment_Click(object sender, EventArgs e)
        {
            try
            {
                InitComment();
            }
            catch { }
        }
    }
}
