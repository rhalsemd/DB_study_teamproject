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
    public partial class MsgView : Form
    {
        public MsgView()
        {
            InitializeComponent();
            SetContext();
        }

        private String is_time_null()
        {

                String Update_time = "";

                if (ConfigManager.GetInstance().isgroup == true)
                {
                    Query query = new Query().select("update_time").From("groupmsg").Where("id=" + ConfigManager.GetInstance().msg_id);
                    DataTable dt = DBManager.getInstance().select(query.query);

                    foreach (DataRow row in dt.Rows)
                    {
                        Update_time = row["update_time"].ToString();
                    }
                }
                else
                {
                    Query query = new Query().select("update_time").From("msg").Where("id=" + ConfigManager.GetInstance().msg_id);
                    DataTable dt = DBManager.getInstance().select(query.query);

                    foreach (DataRow row in dt.Rows)
                    {
                        Update_time = row["update_time"].ToString();
                    }
                }

                return Update_time;
        }

        private void readtimeset()
        {
            try
            {
                String update_time = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                if (ConfigManager.GetInstance().isgroup == true)
                {
                    String query = "UPDATE groupmsg SET update_time ='" + update_time + "' WHERE id =" + ConfigManager.GetInstance().msg_id;
                    DataTable dt = DBManager.getInstance().select(query);
                }
                else
                {
                    String query = "UPDATE msg SET update_time ='" + update_time + "' WHERE id =" + ConfigManager.GetInstance().msg_id;
                    DataTable dt = DBManager.getInstance().select(query);
                }
            }
            catch { }
        }
        private void SetContext()
        {
            try
            {
                String time_check = is_time_null();
                if (ConfigManager.GetInstance().isgroup != true)
                {
                    if (time_check == "Notread" && ConfigManager.GetInstance().issender == false)
                    {
                        readtimeset();
                    }
                    else
                    {
                    }

                    String sendid_text = "";
                    String context_text = "";
                    String title = "";

                    Query query = new Query().select("title, context, uid").From("msg").Where("id=" + ConfigManager.GetInstance().msg_id);
                    DataTable dt = DBManager.getInstance().select(query.query);

                    foreach (DataRow row in dt.Rows)
                    {
                        sendid_text = row["uid"].ToString();
                        context_text = row["context"].ToString();
                        title = row["title"].ToString();
                    }

                    sendid_textbox.Text = sendid_text;
                    context_textbox.Text = context_text;
                    title_textbox.Text = title;
                }
                else
                {
                    readtimeset();
                    String sendid_text = "";
                    String context_text = "";
                    String title = "";


                    Query query = new Query().select("title, context, groupinfo.name").From("groupmsg, groupinfo").Where("groupmsg.id=" + ConfigManager.GetInstance().msg_id + " AND groupinfo.id = groupmsg.gid");
                    DataTable dt = DBManager.getInstance().select(query.query);


                    foreach (DataRow row in dt.Rows)
                    {
                        sendid_text = row["name"].ToString();
                        context_text = row["context"].ToString();
                        title = row["title"].ToString();
                    }

                    sendid_textbox.Text = sendid_text;
                    context_textbox.Text = context_text;
                    title_textbox.Text = title;
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

        private void sendback_btn_Click(object sender, EventArgs e)
        {

        }
    }
}