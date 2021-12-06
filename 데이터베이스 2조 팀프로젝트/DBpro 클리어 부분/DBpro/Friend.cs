using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpro
{
    public partial class Friend : Form
    {
        string strConn = "Server=106.10.36.221;Database=mydb;Uid=root;Pwd=DBdatabase1217!;Charset=utf8";
        public static string userID { get; internal set; }

        public Friend()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                {
                    ListView ListView = listView3;
                    string query = "select id,name,age,gender,addr from user";

                    DBManager.getInstance().follow(ListView, query);
                }
                {
                    ListView ListView = listView4;
                    string query = " select id, name, age, gender, addr from user inner join follow on user.id = follow.uid where follow.target_uid = '" + userID + "'and friend='o' and unfollow = 'x'";

                    DBManager.getInstance().follow(ListView, query);
                }
                {
                    ListView ListView = listView1;
                    string query = "select id,name,age,gender,addr from user inner join follow on user.id=follow.target_uid and follow.uid='" + userID + "' and follow.friend='o' and follow.unfollow='x'";

                    DBManager.getInstance().follow(ListView, query);
                }

                {
                    ListView ListView = listView2;
                    string query = " select id, name, age, gender, addr from user inner join follow on user.id = follow.uid where follow.target_uid = '" + userID + "'and friend='x' and unfollow = 'o'";
                    DBManager.getInstance().follow(ListView, query);
                }
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    ListView ListView = listView1;
                    string query = "select id,name,age,gender,addr from user inner join follow on user.id=follow.target_uid and follow.uid='" + userID + "'" +
                        "           and follow.friend='o' and (unfollow=''or unfollow is null)";

                    DBManager.getInstance().follow(ListView, query);
                }

                {
                    ListView ListView = listView2;
                    string query = " select id, name, age, gender, addr from user inner join follow on user.id = follow.uid where follow.target_uid = '" + userID + "' and unfollow = 'o'";
                    DBManager.getInstance().follow(ListView, query);
                }
            }
            catch { }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                UserInfoUpdate ui = new UserInfoUpdate();
                ui.ShowDialog();
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

        private void search_button_Click_1(object sender, EventArgs e)
        {
            try
            {


                MySqlConnection conn = new MySqlConnection(strConn);

                listView3.View = View.Details;
                MySqlDataAdapter adapt = new MySqlDataAdapter("select ID ,NAME ,AGE,GENDER,ADDR from user where NAME like '%" + textBox1.Text + "%'OR ID='" + textBox1.Text + "' ", conn);

                DataTable dt = new DataTable();
                adapt.Fill(dt);
                listView3.Items.Clear();

                if (dt.Rows.Count > 0)
                {

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["ID"].ToString());

                        listitem.SubItems.Add(dr["NAME"].ToString());
                        listitem.SubItems.Add(dr["AGE"].ToString());
                        listitem.SubItems.Add(dr["GENDER"].ToString());
                        listitem.SubItems.Add(dr["ADDR"].ToString());

                        listView3.Items.Add(listitem);

                    }

                }

                else { MessageBox.Show("검색 결과가 없습니다."); }

                conn.Close();
            }
            catch { }
        }

        private void label9_Click(object sender, EventArgs e)
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

        private void label8_Click(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
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

        private void listView3_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button.Equals(MouseButtons.Right))
                {
                    string selectedNickname = listView3.GetItemAt(e.X, e.Y).Text;
                    ContextMenu m = new ContextMenu();
                    MenuItem m1 = new MenuItem(); MenuItem m2 = new MenuItem();
                    m1.Text = "FOLLOW";
                    m1.Click += (senders, es) =>
                    {
                        ListView.SelectedListViewItemCollection items = listView3.SelectedItems;
                        ListViewItem lvItem = items[0];
                        string ID = lvItem.SubItems[0].Text;
                        string NAME = lvItem.SubItems[1].Text;
                        Boolean b = false;

                        if ((MessageBox.Show("follow 하시겠습니까?", "follow", MessageBoxButtons.YesNo) == DialogResult.Yes))
                        {
                            if (userID == ID)
                            {
                                MessageBox.Show("자신은 추가할 수 없습니다");
                            }
                            else
                            {
                                string query1 = "SELECT * FROM follow WHERE uid= '" + userID + "' and target_uid='" + ID + "' and friend='o' ";
                                MySqlConnection conn = new MySqlConnection(strConn);
                                MySqlCommand command = new MySqlCommand(query1, conn);

                                conn.Open();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        MessageBox.Show("이미 팔로우한 유저입니다");
                                    }
                                    else
                                    {
                                        string query = "delete from follow where uid='" + userID + "' and target_uid='.';" +
                                        "insert INTO follow(uid,target_uid) VALUES ('" + userID + "', '" + ID + "') on duplicate key update friend='o',unfollow='x';" +
                                        "update follow set friend='o',unfollow='x' where uid='" + userID + "' and target_uid='" + ID + "'";

                                        DBManager.getInstance().insert(query);
                                        MessageBox.Show("FOLLOW 완료!");

                                        ListView ListView = listView1;
                                        query = "select id,name,age,gender,addr from user inner join follow on user.id=follow.target_uid and follow.uid='" + userID + "' and follow.friend='o' and follow.unfollow='x'";
                                        DBManager.getInstance().follow(ListView, query);
                                        reader.Close();
                                    }
                                }
                            }
                        }
                    };
                    m.MenuItems.Add(m1);

                    m2.Text = "UNFOLLOW";
                    m2.Click += (senders, es) =>
                    {
                        ListView.SelectedListViewItemCollection items = listView3.SelectedItems;
                        ListViewItem lvItem = items[0];
                        string ID = lvItem.SubItems[0].Text;
                        string NAME = lvItem.SubItems[1].Text;
                        Boolean b = false;

                        if ((MessageBox.Show("unfollow 하시겠습니까?", "follow", MessageBoxButtons.YesNo) == DialogResult.Yes))
                        {
                            if (userID == ID)
                            {
                                MessageBox.Show("자신은 추가할 수 없습니다");
                            }
                            else
                            {
                                string query1 = "SELECT * FROM follow WHERE uid= '" + userID + "' and target_uid='" + ID + "' and friend='x' ";
                                MySqlConnection conn = new MySqlConnection(strConn);
                                MySqlCommand command = new MySqlCommand(query1, conn);

                                conn.Open();
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        MessageBox.Show("이미 언팔로우한 유저입니다");
                                    }
                                    else
                                    {
                                        string query = "delete from follow where uid='" + userID + "' and target_uid='.';" +
                                             "insert INTO follow(uid,target_uid) VALUES ('" + userID + "', '" + ID + "') on duplicate key update friend='x',unfollow='o';" +
                                             "update follow set friend='x',unfollow='o' where uid='" + userID + "' and target_uid='" + ID + "'";

                                        DBManager.getInstance().insert(query);
                                        MessageBox.Show("UNFOLLOW 완료!");

                                        ListView ListView = listView1;
                                        query = "select id,name,age,gender,addr from user inner join follow on user.id=follow.target_uid and follow.uid='" + userID + "' and follow.friend='o' and follow.unfollow='x'";

                                        DBManager.getInstance().follow1(listView1, query);
                                        reader.Close();
                                    }
                                }
                            }
                        }
                    };
                    m.MenuItems.Add(m2);

                    m.Show(listView3, new Point(e.X, e.Y));
                    Application.DoEvents();
                }
            }
            catch { }
        }
        
        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button.Equals(MouseButtons.Right))
                {
                    string selectedNickname = listView1.GetItemAt(e.X, e.Y).Text;
                    ContextMenu m = new ContextMenu();
                    MenuItem m1 = new MenuItem(); MenuItem m2 = new MenuItem();
                    m1.Text = "Unfollow";
                    m1.Click += (senders, es) =>
                    {
                        ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
                        ListViewItem lvItem = items[0];
                        string ID = lvItem.SubItems[0].Text;
                        string NAME = lvItem.SubItems[1].Text;

                        if ((MessageBox.Show("Unfollow 하시겠습니까?", "unfollow", MessageBoxButtons.YesNo) == DialogResult.Yes))
                        {
                            string query = "update follow set unfollow ='o',friend='x' where uid='" + userID + "' and target_uid='" + ID + "' ";
                            DBManager.getInstance().insert(query);
                            MessageBox.Show("Unfollow 완료!");
                        }

                        ListView ListView = listView1;
                        string query1 = "select id,name,age,gender,addr from user inner join follow on user.id=follow.target_uid and follow.uid='" + userID + "' and follow.friend='o' and follow.unfollow='x'";

                        DBManager.getInstance().follow1(ListView, query1);
                    };
                    m.MenuItems.Add(m1);
                    m.Show(listView1, new Point(e.X, e.Y));
                }
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

        private void label7_Click(object sender, EventArgs e)
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
    }
}
