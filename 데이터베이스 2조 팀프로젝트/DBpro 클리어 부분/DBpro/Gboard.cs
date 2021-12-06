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
    public partial class Gboard : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
        MySqlCommand command;
        MySqlDataAdapter da;

        public Gboard()
        {
            InitializeComponent();
            InitImage(ConfigManager.GetInstance().gid);
            Initstoreinfo(ConfigManager.GetInstance().gid);
            InitDatagrid();
            Inituserlist();
            Getpriority();
            this.Groupboard.Columns[0].Visible = false;
        }

        public void Getpriority()
        {
            try
            {
                int priority = -1;
                String query = "SELECT * FROM groupjoin WHERE uid='" + ConfigManager.GetInstance().userid + "' AND gid=" + ConfigManager.GetInstance().gid;
                DataTable dt = DBManager.getInstance().select(query);

                foreach (DataRow row in dt.Rows)
                {
                    if (row["admin"].ToString() == "")
                    {
                        priority = -1;
                    }
                    else
                    {
                        priority = Convert.ToInt32(row["admin"]);
                    }
                }

                if (priority != -1)
                {
                    ConfigManager.GetInstance().priority = priority;
                }
                else
                { }
            }
            catch { }
        }

        private void Inituserlist()
        {
            try
            {
                listBox1.Items.Clear();
                string queryall = $"SELECT * FROM user WHERE user.id IN (SELECT uid FROM groupjoin WHERE groupjoin.gid = {ConfigManager.GetInstance().gid}) ";
                DataTable alluser = DBManager.getInstance().select(queryall);
                for (int i = 0; i < alluser.Rows.Count; i++)
                {
                    string allresult = alluser.Rows[i][0].ToString() + " | " + alluser.Rows[i][2];
                    string id = alluser.Rows[i][0].ToString();

                    for (int j = 4; j < 6; j++)
                    {
                        allresult += " | " + alluser.Rows[i][j].ToString();
                    }
                    string checkgrade = $"SELECT * FROM groupjoin WHERE uid = '{id}' AND gid ='{ConfigManager.GetInstance().gid}'";
                    DataTable usergrade = DBManager.getInstance().select(checkgrade);
                    string grade = "";
                    foreach (DataRow row in usergrade.Rows)
                    {
                        grade = row["admin"].ToString();
                    }
                    if (grade == "0")
                    {
                        allresult += " | member";
                    }
                    else if (grade == "1")
                    {
                        allresult += " | manager";
                    }
                    else if (grade == "2")
                    {
                        allresult += " | admin";
                    }
                    else { }
                    listBox1.Items.Add(allresult);
                }
            }
            catch { }
        }

        public void InitImage(int id)
        {
            try
            {
                String selectQuery = "SELECT * FROM mydb.groupinfo WHERE id =" + id;

                command = new MySqlCommand(selectQuery, connection);

                da = new MySqlDataAdapter(command);

                DataTable table = new DataTable();

                da.Fill(table);

                byte[] img = (byte[])table.Rows[0][4];

                MemoryStream ms = new MemoryStream(img);

                grouppicture.Image = Image.FromStream(ms);

                da.Dispose();
            }
            catch { }
        }

        private void Initstoreinfo(int id)
        {
            try
            {
                int storeid = -1;
                String groupname = "";
                String storename = "";
                String storetype = "";
                String storeaddr = "";

                String query_info = "SELECT * FROM mydb.groupinfo WHERE id =" + id; //group정보
                DataTable dt = DBManager.getInstance().select(query_info);

                foreach (DataRow row in dt.Rows)
                {
                    groupname = row["name"].ToString();
                    storeid = Convert.ToInt32(row["storeid"]);
                }

                if (storeid != -1)
                {
                    String query_store = "SELECT * FROM mydb.store WHERE id =" + storeid;  //store정보
                    DataTable dt_store = DBManager.getInstance().select(query_store);
                    foreach (DataRow row in dt_store.Rows)
                    {
                        storename = row["name"].ToString();
                        storetype = row["type"].ToString();
                        storeaddr = row["addr"].ToString();
                    }

                    if (groupname != "" && storeid != -1 && storename != "" && storetype != "" && storeaddr != "")
                    {
                        gnamelabel.Text = groupname;
                        storenamelabel.Text = storename;
                        storetypelabel.Text = storetype;
                        storeaddrlabel.Text = storeaddr;
                    }
                    else { MessageBox.Show("정보불러오기 실패!"); }

                }
                else { MessageBox.Show("storeid 확인바랍니다."); }
            }
            catch { }
        }

        public void InitDatagrid()
        {
            try
            {
                DataTable datesell = DBManager.getInstance().select("select id as '게시물번호', uid as 'id', content as '내용', update_time as '글쓴시간' from  gboard where gid=" + ConfigManager.GetInstance().gid + " ORDER BY update_time DESC");
                Groupboard.DataSource = datesell;
                Groupboard.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            catch { }
        }

        private void post_gboard_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConfigManager.GetInstance().priority != -1)
                {
                    postgboard postboard = new postgboard();
                    postboard.Show();
                }
                else { MessageBox.Show("그룹에 가입해주세요!"); }
            }
            catch { }
        }

        private void 글수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = Groupboard.SelectedRows[0];
                gboardmodify modify = new gboardmodify();

                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString() || ConfigManager.GetInstance().priority == 1 || ConfigManager.GetInstance().priority == 2)
                {
                    modify.ShowDialog();
                }
                else { MessageBox.Show("내가 쓴 글이 아닙니다!"); }
            }
            catch { }

        }

        private void 글삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = Groupboard.SelectedRows[0];
                if (ConfigManager.GetInstance().userid == dr.Cells[1].Value.ToString() || ConfigManager.GetInstance().priority == 1 || ConfigManager.GetInstance().priority == 2)
                {
                    if (MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DBManager.getInstance().insert("DELETE FROM gboard WHERE id=" + ConfigManager.GetInstance().gpostid);
                        DBManager.getInstance().insert("DELETE FROM gcomment WHERE pid=" + ConfigManager.GetInstance().gpostid);
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

        private void Groupboard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = Groupboard.SelectedRows[0];
                ConfigManager.GetInstance().gpostid = Convert.ToInt32(dr.Cells[0].Value);
                int user_gid = -1;
                String query_usergroup = "SELECT gid FROM groupjoin WHERE uid='" + ConfigManager.GetInstance().userid + "' AND gid=" + ConfigManager.GetInstance().gid;

                DataTable dt = DBManager.getInstance().select(query_usergroup);

                foreach (DataRow row in dt.Rows)
                {
                    user_gid = Convert.ToInt32(row["gid"]);
                }

                if (user_gid == -1)
                {
                    MessageBox.Show("그룹에 가입해주세요!");
                }
                else if (dr.Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("잘못 선택하셨습니다.");
                }
                else
                {
                    gboardshow gboard = new gboardshow();
                    MessageBox.Show("선택 되었습니다.");
                    gboard.ShowDialog();
                }
            }
            catch { }
        }

        private void Groupboard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = Groupboard.SelectedRows[0];
                ConfigManager.GetInstance().gpostid = Convert.ToInt32(dr.Cells[0].Value);
            }
            catch { }
        }

        private void refresh_datagrid_Click(object sender, EventArgs e)
        {
            try
            {
                InitDatagrid();
            }
            catch { }
        }

        private void joingroup_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String alreadyexist = "";
                String query = "SELECT * FROM groupjoin WHERE gid=" + ConfigManager.GetInstance().gid + " AND uid='" + ConfigManager.GetInstance().userid + "'";
                DataTable gidtable = DBManager.getInstance().select(query);
                foreach (DataRow row in gidtable.Rows)
                {
                    alreadyexist = row["gid"].ToString();
                }

                if (alreadyexist != "")
                {
                    MessageBox.Show("이미 가입된 그룹입니다.");
                }
                else
                {
                    String groupjoin = "INSERT INTO groupjoin(gid,uid,admin) VALUES(" + ConfigManager.GetInstance().gid + ",'" + ConfigManager.GetInstance().userid + "', 0)";
                    DBManager.getInstance().insert(groupjoin);
                    MessageBox.Show("가입되었습니다!");
                    ConfigManager.GetInstance().priority = 0;
                }
            }
            catch { }
        }

        private void exitgroup_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String alreadyexist = "";
                String admincheck = "";
                String query = "SELECT * FROM groupjoin WHERE gid=" + ConfigManager.GetInstance().gid + " AND uid='" + ConfigManager.GetInstance().userid + "'";
                DataTable gidtable = DBManager.getInstance().select(query);
                foreach (DataRow row in gidtable.Rows)
                {
                    alreadyexist = row["gid"].ToString();
                    admincheck = row["admin"].ToString();
                }

                if (alreadyexist != "" && admincheck != "2")
                {
                    String groupjoin = "DELETE FROM groupjoin WHERE uid='" + ConfigManager.GetInstance().userid + "' AND gid=" + ConfigManager.GetInstance().gid;
                    DBManager.getInstance().insert(groupjoin);
                    MessageBox.Show("탈퇴되었습니다!");
                    ConfigManager.GetInstance().priority = -1;
                }
                else if (admincheck == "2")
                {
                    MessageBox.Show("운영자는 탈퇴할 수 없습니다.");
                }
                else
                {
                    MessageBox.Show("가입하지 않은 그룹입니다.");
                }
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")//검색창을 공백인 채로 검색하면 그룹내 모든 인원 리스트를 뽑습니다.
                {
                    listBox1.Items.Clear();
                    string queryall = $"SELECT * FROM user WHERE user.id IN (SELECT uid FROM groupjoin WHERE groupjoin.gid = {ConfigManager.GetInstance().gid}) ";
                    DataTable alluser = DBManager.getInstance().select(queryall);
                    for (int i = 0; i < alluser.Rows.Count; i++)
                    {
                        string allresult = alluser.Rows[i][0].ToString() + " | " + alluser.Rows[i][2];
                        string id = alluser.Rows[i][0].ToString();

                        for (int j = 4; j < 6; j++)
                        {
                            allresult += " | " + alluser.Rows[i][j].ToString();
                        }
                        string checkgrade = $"SELECT * FROM groupjoin WHERE uid = '{id}' AND gid ='{ConfigManager.GetInstance().gid}'";
                        DataTable usergrade = DBManager.getInstance().select(checkgrade);
                        string grade = "";
                        foreach (DataRow row in usergrade.Rows)
                        {
                            grade = row["admin"].ToString();
                        }
                        if (grade == "0")
                        {
                            allresult += " | member";
                        }
                        else if (grade == "1")
                        {
                            allresult += " | manager";
                        }
                        else if (grade == "2")
                        {
                            allresult += " | admin";
                        }
                        else { }
                        listBox1.Items.Add(allresult);
                    }
                }
                else
                {
                    string searchingUser = textBox1.Text;
                    string query = $"SELECT * FROM groupjoin WHERE uid LIKE '%{searchingUser}%' AND gid ='{ConfigManager.GetInstance().gid}'";//검색창에 id를 기입하고 검색하면 검색내용이 나옵니다.
                    string uid;
                    DataTable dt = DBManager.getInstance().select(query);
                    
                    if (dt.Rows.Count > 0)//이름에 searchingUser 문자를 포함하는 유저가 현재 그룹에 가입되어있으면
                    {
                        listBox1.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            uid = row["uid"].ToString();

                            string namequery = $"SELECT * FROM user WHERE id = '{uid}'";
                            DataTable username = DBManager.getInstance().select(namequery);
                            string result = username.Rows[0][0].ToString() + " | " + username.Rows[0][2];//아이디와 이름
                            for (int i = 4; i < 6; i++)
                            {
                                result += " | " + username.Rows[0][i].ToString();//주소와 나이
                            }
                            string checkgrade = $"SELECT * FROM groupjoin WHERE uid = '{uid}' AND gid ='{ConfigManager.GetInstance().gid}'";
                            DataTable usergrade = DBManager.getInstance().select(checkgrade);
                            string grade = "";
                            foreach (DataRow dataRow in usergrade.Rows)
                            {
                                grade = row["admin"].ToString();
                            }
                            if (grade == "0")
                            {
                                result += " | member";
                            }
                            else if (grade == "1")
                            {
                                result += " | manager";
                            }
                            else if (grade == "2")
                            {
                                result += " | admin";
                            }
                            else { }
                            listBox1.Items.Add(result);
                        }
                    }
                    else
                    {
                        MessageBox.Show("없는 유저 입니다.");
                    }
                }
            }
            catch { }

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                groupHome home = new groupHome();
                home.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void usermanage_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String admincheck = "";
                String query = "SELECT * FROM groupjoin WHERE gid=" + ConfigManager.GetInstance().gid + " AND uid='" + ConfigManager.GetInstance().userid + "'";
                DataTable gidtable = DBManager.getInstance().select(query);
                foreach (DataRow row in gidtable.Rows)
                {
                    admincheck = row["admin"].ToString();
                }

                if (admincheck != "2")
                {
                    MessageBox.Show("권한이 없습니다!");
                }
                else
                {
                    this.Hide();
                    GroupForm form = new GroupForm();
                    form.ShowDialog();
                    this.Close();
                }
            }
            catch { }
        }

        private void Home_label_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void friend_label_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Friend friend = new Friend();
                friend.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void message_label_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Hide();
                Msg msg = new Msg();
                msg.ShowDialog();
                //this.Close();
            }
            catch { }
        }

        private void post_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Home home = new Home();
                Hide();
                home.ShowDialog();
                Close();
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

        private void Group_move_btn_Click(object sender, EventArgs e)
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

        private void Message_move_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Msg m = new Msg();
                //Hide();
                m.ShowDialog();
                //Close();
            }
            catch { }
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                UserInfoUpdate update = new UserInfoUpdate();
                update.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();
            }
            catch { }
        }
    }
}
