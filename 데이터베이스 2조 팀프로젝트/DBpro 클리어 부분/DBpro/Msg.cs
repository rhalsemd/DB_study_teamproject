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
    public partial class Msg : Form
    {
        public Msg()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                datagrid_set();
                this.dataGridView_msg.Columns[0].Visible = false;
                user_label.Text = ConfigManager.GetInstance().userid + "님 반갑습니다";
            }
            catch { }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Home form1 = new Home();
                //Hide();
                //form1.ShowDialog();
                Close();
            }
            catch { }
        }
        private void sentmsg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigManager.GetInstance().issender = true;
                ConfigManager.GetInstance().isgroup = false;
                dataGridView_msg.Refresh();

                String query1 = "SELECT id AS '쪽지번호', rid AS '받은 이', title AS '제목', sent_time AS '보낸시간', update_time AS '받은시간' FROM msg WHERE uid ='" + ConfigManager.GetInstance().userid + "' ORDER BY sent_time DESC";

                DataTable datagrid;

                datagrid = DBManager.getInstance().select(query1);
                dataGridView_msg.DataSource = datagrid;
            }
            catch { }
        }

        private void groupmsg_btn_Click(object sender, EventArgs e)
        {
            try
            {

                ConfigManager.GetInstance().issender = false;
                ConfigManager.GetInstance().isgroup = true;
                dataGridView_msg.Refresh();

                String query1 = "SELECT groupmsg.id AS '쪽지번호', groupmsg.uid AS '보낸 이', title AS '제목', sent_time AS '보낸시간',groupinfo.name AS '보낸 그룹' FROM groupmsg, groupjoin, groupinfo WHERE groupinfo.id = groupjoin.gid AND groupmsg.gid = groupjoin.gid AND groupjoin.uid='" + ConfigManager.GetInstance().userid + "' ORDER BY sent_time DESC";

                DataTable datagrid;

                datagrid = DBManager.getInstance().select(query1);
                dataGridView_msg.DataSource = datagrid;
            }
            catch { }
        }

        private void writemsg_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SendMsg send = new SendMsg();
                send.Show();
            }
            catch { }
        }

        public void datagrid_set()
        {
            try
            {
                String query1 = "SELECT id AS '쪽지번호', uid AS '보낸 이', title AS '제목', sent_time AS '보낸시간' FROM msg WHERE rid ='" + ConfigManager.GetInstance().userid + "' ORDER BY sent_time DESC";

                DataTable datagrid;

                datagrid = DBManager.getInstance().select(query1);
                dataGridView_msg.DataSource = datagrid;
            }
            catch { }

        }

        private void goback_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigManager.GetInstance().issender = false;
                ConfigManager.GetInstance().isgroup = false;
                dataGridView_msg.Refresh();
                datagrid_set();
            }
            catch { }
        }

        private void dataGridView_msg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = dataGridView_msg.SelectedRows[0];
                ConfigManager.GetInstance().msg_id = Convert.ToInt32(dr.Cells[0].Value);

                MsgView msg = new MsgView();
                msg.Show();
            }
            catch { }
        }
    }
}
