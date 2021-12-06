using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpro
{
    public partial class Homeboard : Form
    {
        int selectedrowindex=0;
        int removecheck = 0;
        public Homeboard()
        {
            InitializeComponent();
            DataTable dt = DBManager.getInstance().select("select b.uid, b.content, b.update_time, s.name from board b, store s where b.id='"+ConfigManager.GetInstance().postid+"' and s.id=b.store_id");
            //String postuserid = "";
            string name = String.Empty;
            string context = String.Empty;
            string date = String.Empty;
            string store = String.Empty;

            foreach (DataRow row in dt.Rows)
            {
                name = string.Format("{0}", row["uid"]);
                context = string.Format("{0}", row["content"]);
                date = string.Format("{0}", row["update_time"]);
                store = string.Format("{0}", row["name"]);
            }
            label1.Text = name + " [" + store + "] \n" + date;
            context_textbox.Text = context;

            try
            {
                post_picture.SizeMode = PictureBoxSizeMode.StretchImage;

                //string uid = ConfigManager.GetInstance().GetUid();
                Query query = new Query().Select("photo").From("board").Where("id = '" + ConfigManager.GetInstance().postid + "'");
                DataTable board_dt = DBManager.getInstance().select(query.query);
                if (!(board_dt.Rows[0][0].Equals(DBNull.Value)))
                {
                    byte[] img = (byte[])board_dt.Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    post_picture.Image = Image.FromStream(ms);
                }
            }
            catch
            {

            }

            String selectQuery = "SELECT * FROM mydb.user WHERE id = '" + name + "'";
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                MySqlCommand command = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                da.Fill(table);
                byte[] img = (byte[])table.Rows[0][7];
                MemoryStream ms = new MemoryStream(img);
                post_user.Image = Image.FromStream(ms);
                da.Dispose();
            }
            catch { }
            DataTable datesell = DBManager.getInstance().select("select id as '댓글 번호', uid as '사용자', comment as '내용', update_time as '댓글시간' from comment WHERE pid=" + ConfigManager.GetInstance().postid + " ORDER BY update_time");
            commentgridview.DataSource = datesell;
            commentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            commentgridview.Columns[0].Visible = false;
            commentgridview.ClearSelection();

        }

        private void exit_btn_Click(object sender, EventArgs e) //나가기
        {
            try
            {
                //Home home = new Home();
                //Hide();
                //home.ShowDialog();
                Close();
            }
            catch { }
        }
        private void gcomment_btn_Click(object sender, EventArgs e) 
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                DBManager.getInstance().insert("insert into comment(pid, uid, comment, update_time) values('" + ConfigManager.GetInstance().postid + "','" + ConfigManager.GetInstance().userid + "','" + comment_textbox.Text + "','" + date + "')");

                DataTable datesell = DBManager.getInstance().select("select id as '댓글 번호', uid as '사용자', comment as '내용', update_time as '댓글시간' from comment WHERE pid=" + ConfigManager.GetInstance().postid + " ORDER BY update_time");
                commentgridview.DataSource = datesell;
                commentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;

                comment_textbox.Text = "";//댓글 작성 후 텍스트박스 내용 없애기
            }
            catch { }
        }

        private void refresh_comment_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("select id as '댓글 번호', uid as '사용자', comment as '내용', update_time as '댓글시간' from comment WHERE pid=" + ConfigManager.GetInstance().postid + " ORDER BY update_time");
                commentgridview.DataSource = datesell;
                commentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                commentgridview.ClearSelection();
                removecheck = -1;
            }
            catch { }
        }

        private void 댓글수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = commentgridview.SelectedRows[0];
                CommentModify commentmodify = new CommentModify();

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
                        DBManager.getInstance().insert("DELETE FROM comment WHERE id=" + ConfigManager.GetInstance().cid + " AND pid=" + ConfigManager.GetInstance().postid);
                        removecheck++;
                        MessageBox.Show("삭제되었습니다!");
                    }
                    else
                    {

                    }
                }
                else { MessageBox.Show("내가 쓴 댓글이 아닙니다!"); }
                DataTable datesell = DBManager.getInstance().select("select id as '댓글 번호', uid as '사용자', comment as '내용', update_time as '댓글시간' from comment WHERE pid=" + ConfigManager.GetInstance().postid + " ORDER BY update_time");
                commentgridview.DataSource = datesell;
                commentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
                commentgridview.ClearSelection();
            }
            catch { }
        }

        private void commentgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (removecheck == 1)
                {
                    removecheck = 0;
                }
                else if (removecheck == -1)
                {
                    removecheck = 0;
                }
                else
                {
                    ConfigManager.GetInstance().cid = Convert.ToInt32(commentgridview.Rows[e.RowIndex].Cells[0].Value);
                    selectedrowindex = e.RowIndex;
                    MessageBox.Show("선택 되었습니다.");   
                }
            }
            catch { }
        }
    }
}
