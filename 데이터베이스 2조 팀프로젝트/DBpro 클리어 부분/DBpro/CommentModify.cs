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
    public partial class CommentModify : Form
    {
        public CommentModify()
        {
            InitializeComponent();
            DataTable dt = DBManager.getInstance().select("select comment from comment where pid=" + ConfigManager.GetInstance().postid + " AND id=" + ConfigManager.GetInstance().cid);

            foreach (DataRow row in dt.Rows)
            {
                gcomment_modfy_textbox.Text = row["comment"].ToString();
            }
        }

        private void gcomment_modify_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                DBManager.getInstance().insert("UPDATE comment SET comment='" + gcomment_modfy_textbox.Text + "', update_time='" + date + "' WHERE pid=" + ConfigManager.GetInstance().postid + " AND id=" + ConfigManager.GetInstance().cid);
                MessageBox.Show("수정되었습니다!");

                this.Close();
            }
            catch
            {
            }
            
        }

        private void gcomment_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch
            {
            }
        }
    }
}
