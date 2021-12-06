using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpro
{
    public partial class groupHome : Form
    {
        public groupHome()
        {
            ConfigManager.GetInstance().priority = -1;
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            try
            {
                datagrid_set();
                this.dataGridView1.Columns[0].Visible = false;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string search = textBox1.Text;

                string query = "SELECT groupinfo.id AS '그룹번호', groupinfo.name AS '그룹이름', groupinfo.uid AS '그룹 생성자', store.name AS '가게이름', store.addr AS '가게주소' FROM groupinfo, store WHERE groupinfo.name LIKE '%" + search + "%' AND groupinfo.storeid = store.id";

                DataTable datagrid;
                datagrid = DBManager.getInstance().select(query);

                dataGridView1.DataSource = datagrid;
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                makingGroup send = new makingGroup();
                send.Show();
            }
            catch { }

        }

        public void datagrid_set()
        {
            try
            {
                String query1 =
                    "SELECT groupinfo.id AS '그룹번호', groupinfo.name AS '그룹이름', groupinfo.uid AS '그룹 생성자', store.name AS '가게이름', store.addr AS '가게주소' FROM groupinfo, store WHERE groupinfo.storeid = store.id";

                DataTable datagrid;
                datagrid = DBManager.getInstance().select(query1);

                dataGridView1.DataSource = datagrid;
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Refresh();
                datagrid_set();
            }
            catch { }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                ConfigManager.GetInstance().gid = Convert.ToInt32(dr.Cells[0].Value);
                Gboard gboard = new Gboard();
                this.Hide();
                gboard.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void 그룹삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                if (dr.Cells[2].Value.ToString() != ConfigManager.GetInstance().userid)
                {
                    MessageBox.Show("권한이 없습니다");
                }
                else
                {
                    String query = "DELETE FROM groupinfo WHERE id =" + dr.Cells[0].Value.ToString();
                    DBManager.getInstance().delete(query);
                    MessageBox.Show("삭제 되었습니다!");
                }
            }
            catch { }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Home home = new Home();
                home.ShowDialog();
                this.Show();
            }
            catch { }
        }

        private void label_home_Click(object sender, EventArgs e)
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

        private void label_friend_Click(object sender, EventArgs e)
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

        private void label_message_Click(object sender, EventArgs e)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                datagrid_set();
                this.dataGridView1.Columns[0].Visible = false;
            }
            catch { }
        }
    }
}

