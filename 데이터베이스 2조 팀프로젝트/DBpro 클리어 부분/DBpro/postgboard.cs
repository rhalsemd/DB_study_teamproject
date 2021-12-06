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
    public partial class postgboard : Form
    {

        String image_file = string.Empty;
        public postgboard()
        {
            InitializeComponent();
        }

        private void image_insert_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    image_file = ofd.FileName.ToString();
                    gboard_image.Image = new Bitmap(ofd.FileName);
                    gboard_image.Tag = ofd.FileName;
                }
            }
            catch { }
        }

        private void post_btn_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                    byte[] img = null;

                    DBManager.getInstance().insert("insert into gboard(uid, content, gid, update_time) values('" + ConfigManager.GetInstance().userid + "','" + context_textbox.Text + "'," + ConfigManager.GetInstance().gid + ",'" + date + "')");
                    MemoryStream ms = new MemoryStream();
                    gboard_image.Image.Save(ms, gboard_image.Image.RawFormat);
                    img = ms.ToArray();
                    String insertQuery = "update mydb.gboard set photo=@img where uid='" + ConfigManager.GetInstance().userid + "' and content='" + context_textbox.Text + "' and update_time='" + date + "'";
                    MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!;Charset=utf8");
                    MySqlCommand command;
                    connection.Open();
                    command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.Add("@img", MySqlDbType.Blob);
                    command.Parameters["@img"].Value = img;
                    if (command.ExecuteNonQuery() == 1)
                    {

                    }
                    connection.Close();


                }
                catch { }
                MessageBox.Show("게시글 등록이 완료되었습니다!");
                this.Close();
            }
            catch { }
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
                    gboard_image.Image = new Bitmap(ofd.FileName);
                    gboard_image.Tag = ofd.FileName;
                }
            }
            catch { }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }
    }
}
