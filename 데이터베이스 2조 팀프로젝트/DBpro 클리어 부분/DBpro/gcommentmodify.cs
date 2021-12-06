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
    public partial class gcommentmodify : Form
    {
        public gcommentmodify()
        {
            InitializeComponent();
            InitContent();
        }

        private void InitContent()
        {
            try
            {
                DataTable dt = DBManager.getInstance().select("select comment from gcomment where pid=" + ConfigManager.GetInstance().gpostid + " AND id=" + ConfigManager.GetInstance().gcid);

                foreach (DataRow row in dt.Rows)
                {
                    gcomment_modfy_textbox.Text = row["comment"].ToString();
                }
            }
            catch { }
        }

        private void gcomment_modify_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                DBManager.getInstance().insert("UPDATE gcomment SET comment='" + gcomment_modfy_textbox.Text + "', update_time='" + date + "' WHERE pid=" + ConfigManager.GetInstance().gpostid + " AND id=" + ConfigManager.GetInstance().gcid);

                MessageBox.Show("수정되었습니다!");

                this.Close();
            }
            catch { }
        }

        private void gcomment_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch { }
        }
    }
}

