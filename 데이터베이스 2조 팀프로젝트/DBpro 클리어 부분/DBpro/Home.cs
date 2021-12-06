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
    public partial class Home : Form
    {
        string image_file = string.Empty;
        int secret = 0;
        int selectedrowindex;
        int removecheck = 0;
        int postid = -1;
        public string userID { get; internal set; }

        public Home()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            SetHomeUserInterface();
        }
        private void SetHomeUserInterface()
        {
            dataGridView1.Refresh();
            try
            {
                DataTable datesell = DBManager.getInstance().select("SELECT distinct(b.id) as '게시물 번호', b.uid as '글쓴이', b.content as '글내용', b.update_time as '작성 시간', s.name as '태그 가게' FROM mydb.board b, follow f, store s where (b.uid='" + ConfigManager.GetInstance().userid + "' or (b.uid in (select f4.target_uid from follow f4 where f4.uid='" + ConfigManager.GetInstance().userid + "' and f4.friend = 'o') and b.secret=0)) and s.id = b.store_id and f.uid=b.uid order by b.update_time DESC");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

                try
                {
                    pictureBox1.Image = Properties.Resources.default_user;
                    //pictureBox1.Load("default");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    string uid = ConfigManager.GetInstance().GetUid();
                    Query query = new Query().Select("photo").From("user").Where("id = '" + uid + "'");
                    DataTable dt = DBManager.getInstance().select(query.query);
                    if (!(dt.Rows[0][0].Equals(DBNull.Value)))
                    {
                        byte[] img = (byte[])dt.Rows[0][0];
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                catch { }
                dataGridView1.ClearSelection();
            }
            catch { }
        }

        private void post_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("SELECT distinct(b.id) as '게시물 번호', b.uid as '글쓴이', b.content as '글내용', b.update_time as '작성 시간', s.name as '태그 가게' FROM mydb.board b, follow f, store s where (b.uid='" + ConfigManager.GetInstance().userid + "' or (b.uid in (select f4.target_uid from follow f4 where f4.uid='" + ConfigManager.GetInstance().userid + "' and f4.friend = 'o') and b.secret=0)) and s.id = b.store_id and f.uid=b.uid order by b.update_time DESC");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView1.ClearSelection();
                dataGridView2.Refresh();
                post_add_context.Text = "";
                secret_check.Checked = false;
                post_add_picture.Image = null;
                removecheck = 0;
            }
            catch { }
        }

        private void post_move_btn_MouseHover(object sender, EventArgs e)
        {
            try
            {
                post_move_btn.ForeColor = Color.Blue;
            }
            catch { }
        }

        private void post_move_btn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                post_move_btn.ForeColor = Color.Black;
            }
            catch { }
        }

        private void Friends_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Friend friend = new Friend();
                Hide();
                friend.ShowDialog();
                Close();
            }
            catch { }
        }

        private void Friends_move_btn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Friends_move_btn.ForeColor = Color.Black;
            }
            catch { }
        }

        private void Friends_move_btn_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Friends_move_btn.ForeColor = Color.Blue;
            }
            catch { }
        }

        private void Group_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                groupHome groupHome = new groupHome();
                this.Hide();
                groupHome.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void Group_move_btn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Group_move_btn.ForeColor = Color.Black;
            }
            catch { }
        }

        private void Group_move_btn_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Group_move_btn.ForeColor = Color.Blue;
            }
            catch { }
        }
        private void Message_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Msg msg = new Msg();
                //Hide();
                msg.ShowDialog();
                //Close();
            }
            catch { }
        }

        private void Message_move_btn_MouseHover(object sender, EventArgs e)
        {
            try
            {
                Message_move_btn.ForeColor = Color.Blue;
            }
            catch { }
        }

        private void Message_move_btn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                Message_move_btn.ForeColor = Color.Black;
            }
            catch { }
        }

        private void post_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                byte[] img = null;

                if (ConfigManager.GetInstance().poststore_id == -1)
                {
                    MessageBox.Show("가게 이름을 검색하세요.");
                }
                else
                {
                    DBManager.getInstance().insert("insert into board(uid, content, secret, store_id, update_time) values('" + ConfigManager.GetInstance().userid + "','" + post_add_context.Text + "'," + secret + "," + ConfigManager.GetInstance().poststore_id + ",'" + date + "')");
                    DataTable datesell = DBManager.getInstance().select("select MAX(id) from board where uid ='" + ConfigManager.GetInstance().userid + "'");
                    foreach (DataRow row in datesell.Rows)
                    {
                        if ((string.Format("{0}", row["MAX(id)"])) == "")
                        {
                            postid = -1;
                        }
                        else
                        {
                            postid = Convert.ToInt32((string.Format("{0}", row["MAX(id)"])));
                        }
                    }
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        post_add_picture.Image.Save(ms, post_add_picture.Image.RawFormat);
                        img = ms.ToArray();
                        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!;Charset=utf8");
                        MySqlCommand command;
                        connection.Open();
                        string insertQuery = "update mydb.board set photo = @img where id = " + postid;
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@img", MySqlDbType.Blob);
                        command.Parameters["@img"].Value = img;
                        if (command.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("사진 삽입 성공");
                            ResetTextBoxAndCheckBox();
                            SetHomeUserInterface();
                        }
                        else
                        {
                            Console.WriteLine("사진 삽입 실패");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("예외 발생");
                    }
                    MessageBox.Show("게시글 작성 성공");
                }
            }
            catch { }
        }
        private void ResetTextBoxAndCheckBox()
        {
            post_add_context.Text = "";
            post_add_picture.Image = null;
            secret_check.Checked = false;
            imageLabel.Text = "포스트 사진";
        }
        private void post_load_image_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    image_file = ofd.FileName.ToString();
                    post_add_picture.Image = new Bitmap(ofd.FileName);
                    post_add_picture.Tag = ofd.FileName;
                }
                imageLabel.Text = "";
            }
            catch { }
        }

        private void secret_check_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (secret_check.Checked == true)
                {
                    secret = 1;
                }
                else
                {
                    secret = 0;
                }
            }
            catch { }
        }

        private void board_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("SELECT distinct(b.id) as '게시물 번호', b.uid as '글쓴이', b.content as '글내용', b.update_time as '작성 시간', s.name as '태그 가게' FROM mydb.board b, follow f, store s where (b.uid='" + ConfigManager.GetInstance().userid + "' or (b.uid in (select f4.target_uid from follow f4 where f4.uid='" + ConfigManager.GetInstance().userid + "' and f4.friend = 'o') and b.secret=0)) and s.id = b.store_id and f.uid=b.uid and b.id in (select b.id from board as b where b.uid like'%" + post_search_tb.Text + "%' or b.content like'%" + post_search_tb.Text + "%') order by b.update_time DESC");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            }
            catch { }
        }
        private void login_Click(object sender, EventArgs e) //자기 정보 변경
        {
            try
            {
                UserInfoUpdate ui = new UserInfoUpdate();
                Hide();
                ui.ShowDialog();
                Close();
            }
            catch { }
        }

        private void logout_Click(object sender, EventArgs e)
        {   try
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e) //새로고침
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("SELECT distinct(b.id) as '게시물 번호', b.uid as '글쓴이', b.content as '글내용', b.update_time as '작성 시간', s.name as '태그 가게' FROM mydb.board b, follow f, store s where (b.uid='" + ConfigManager.GetInstance().userid + "' or (b.uid in (select f4.target_uid from follow f4 where f4.uid='" + ConfigManager.GetInstance().userid + "' and f4.friend = 'o') and b.secret=0)) and s.id = b.store_id and f.uid=b.uid order by b.update_time DESC");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
                dataGridView1.ClearSelection();
                dataGridView2.Refresh();
                post_add_context.Text = "";
                secret_check.Checked = false;
                post_add_picture.Image = null;
                removecheck = 0;
            }
            catch { }
        }

        private void label3_Click(object sender, EventArgs e) //친구창
        {
            try
            {
                Friend friend = new Friend();
                Hide();
                friend.ShowDialog();
                Close();
            }
            catch { }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            try
            {
                groupHome groupHome = new groupHome();
                Hide();
                groupHome.ShowDialog();
                Close();
            }
            catch { }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                //Hide();
                Msg msg = new Msg();
                msg.ShowDialog();
                //Close();
            }
            catch { }
        }

        private void store_search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string storename = store_search_tb.Text;
                DataTable datesell = null;
                if (store_search_tb.Text == "")
                {
                    datesell = DBManager.getInstance().select("select id as '가게 번호', name as '가게이름', type as '업종', addr as '주소' from store");
                }
                else
                {
                    datesell = DBManager.getInstance().select("select id as '가게 번호', name as '가게이름', type as '업종', addr as '주소' from store where name like'%" + storename + "%'");
                }
                dataGridView2.DataSource = datesell;
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;

                dataGridView2.ClearSelection();
            }
            catch { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ConfigManager.GetInstance().poststore_id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                label7.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show("선택 되었습니다.");
            }
            catch { }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    MessageBox.Show("지울 게시물을 선택하세요.");
                }
                else
                {
                    ConfigManager.GetInstance().postid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    ConfigManager.GetInstance().postuserid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    selectedrowindex = e.RowIndex;
                    Homeboard homeboard = new Homeboard();
                }
            }
            catch { }
        }

        public void InitDatagrid()
        {   try
            {
                DataTable datesell = DBManager.getInstance().select("SELECT distinct(b.id) as '게시물 번호', b.uid as '글쓴이', b.content as '글내용', b.update_time as '작성 시간', s.name as '태그 가게' FROM mydb.board b, follow f, store s where (b.uid='" + ConfigManager.GetInstance().userid + "' or (b.uid in (select f4.target_uid from follow f4 where f4.uid='" + ConfigManager.GetInstance().userid + "' and f4.friend = 'o') and b.secret=0)) and s.id = b.store_id and f.uid=b.uid order by b.update_time DESC");
                dataGridView1.DataSource = datesell;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch { }
        }

        private void 게시물삭제_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.Rows[selectedrowindex];
                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString())
                {
                    if (MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBManager.getInstance().insert("DELETE FROM board WHERE id=" + ConfigManager.GetInstance().postid);
                        removecheck++;
                        MessageBox.Show("삭제되었습니다!");
                        InitDatagrid();
                    }
                    else
                    {

                    }
                }
                else { MessageBox.Show("내가 쓴 글이 아닙니다!"); }
            }
            catch { }
        }

        private void 게시물수정_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.Rows[selectedrowindex];
                HomeboardModify modify = new HomeboardModify();

                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString())
                {
                    modify.ShowDialog();
                }
                else { MessageBox.Show("내가 쓴 글이 아닙니다!"); }
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ConfigManager.GetInstance().postid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                ConfigManager.GetInstance().postuserid = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Homeboard homeboard = new Homeboard();

                MessageBox.Show("선택 되었습니다. 게시판 내용으로 넘어갑니다.");
                //Hide();
                homeboard.ShowDialog();
                //Close();
            }
            catch { }
        }
    }
}
