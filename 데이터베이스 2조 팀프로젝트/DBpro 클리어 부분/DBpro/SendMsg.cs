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
    public partial class SendMsg : Form
    {
        public SendMsg()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            try
            {
                group_combo_set();
                group_combo.Hide();

                context_textbox.MaxLength = 50;
                receive_textbox.MaxLength = 10;
                title_textbox.MaxLength = 20;
            }
            catch { }
        }

        private void group_combo_set()
        {
            try
            {
                Query query = new Query().select("groupinfo.name").From("groupjoin, groupinfo").Where("groupinfo.id = groupjoin.gid AND groupjoin.uid='" + ConfigManager.GetInstance().userid + "'");
                DataTable dt = DBManager.getInstance().select(query.query);

                foreach (DataRow row in dt.Rows)
                {
                    group_combo.Items.Add(row["name"].ToString());
                }
            }
            catch { }

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (groupradio1.Checked) //그룹
                {
                    String gid = "";
                    if (group_combo.SelectedIndex != -1)
                    {
                        Query query_gid =
                            new Query().select("id").From("groupinfo").Where("name ='" + group_combo.SelectedItem.ToString() + "'");
                        DataTable dt_gid = DBManager.getInstance().select(query_gid.query);

                        foreach (DataRow row in dt_gid.Rows)
                        {
                            gid = row["id"].ToString();
                        }
                    }
                    else { }

                    if (group_combo.SelectedIndex != -1 && title_textbox.Text != "")
                    {
                        String sent_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        Query query =
                        new Query().Insert("groupmsg(title,context,gid,uid,sent_time)").Values("('" + title_textbox.Text + "','" + context_textbox.Text + "','" + gid + "','" + ConfigManager.GetInstance().userid + "','" + sent_time + "')");
                        DataTable dt = DBManager.getInstance().select(query.query);
                        MessageBox.Show("전송되었습니다!");
                        this.Close();
                    }
                    else if (group_combo.SelectedIndex == -1)
                    {
                        MessageBox.Show("수신그룹을 입력해주세요!");
                    }
                    else if (title_textbox.Text == "")
                    {
                        MessageBox.Show("제목을 입력해주세요!");
                    }
                }
                else if (groupradio2.Checked) //개인
                {
                    String userexist = "";
                    String existquery = "SELECT id FROM user WHERE id='" + receive_textbox.Text + "'";
                    DataTable exist_dt = DBManager.getInstance().select(existquery);
                    foreach (DataRow row in exist_dt.Rows)
                    {
                        userexist = row["id"].ToString();
                    }

                    if (receive_textbox.Text != "" && title_textbox.Text != "" && userexist != "")
                    {
                        String sent_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                        Query query =
                        new Query().Insert("msg(title,context,rid,uid,sent_time)").Values("('" + title_textbox.Text + "','" + context_textbox.Text + "','" + receive_textbox.Text + "','" + ConfigManager.GetInstance().userid + "','" + sent_time + "')");
                        DataTable dt = DBManager.getInstance().select(query.query);
                        MessageBox.Show("전송되었습니다!");
                        this.Close();
                    }
                    else if (receive_textbox.Text == "")
                    {
                        MessageBox.Show("수신자를 입력해주세요!");
                    }

                    else if (userexist == "")
                    {
                        MessageBox.Show("존재하지 않는 수신자입니다.");
                    }
                    else if (title_textbox.Text == "")
                    {
                        MessageBox.Show("제목을 입력해주세요!");
                    }
                }
            }
            catch { }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
            }
            catch { }
        }

        private void groupradio1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "받는그룹";
                receive_textbox.Hide();
                group_combo.Show();
            }
            catch { }
        }

        private void groupradio2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                label2.Text = "  받는 이";
                receive_textbox.Show();
                group_combo.Hide();
            }
            catch { }
        }
    }
}
