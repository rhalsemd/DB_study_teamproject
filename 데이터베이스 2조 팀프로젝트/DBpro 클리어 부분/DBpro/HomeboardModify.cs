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
    public partial class HomeboardModify : Form
    {
        String image_file = string.Empty;
        int secret = 0;
        public HomeboardModify()
        {
            InitializeComponent();
            InitContent();
        }

        private void InitContent()
        {
            try
            {
                DataTable dt = DBManager.getInstance().select("select b.uid, b.content, b.update_time, s.name, b.store_id, secret from board b, store s where b.id='" + ConfigManager.GetInstance().postid + "' and s.id=b.store_id");
                string name = String.Empty;
                string date = String.Empty;
                string store = String.Empty;

                foreach (DataRow row in dt.Rows)
                {
                    name = string.Format("{0}", row["uid"]);
                    post_add_context.Text = string.Format("{0}", row["content"]);
                    date = string.Format("{0}", row["update_time"]);
                    label1.Text = string.Format("{0}", row["name"]);
                    ConfigManager.GetInstance().poststore_id = Convert.ToInt32(string.Format("{0}", row["store_id"]));
                    secret = Convert.ToInt32(string.Format("{0}", row["secret"]).ToString());
                    if (secret == 1)
                    {
                        secret_check.Checked = true;
                    }
                    else
                    {
                        secret_check.Checked = false;
                    }
                }

                string selectQuery = "SELECT * FROM mydb.board WHERE id = " + ConfigManager.GetInstance().postid + "";
                try
                {
                    MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0][3];
                    MemoryStream ms = new MemoryStream(img);
                    post_add_picture.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                catch { }
                selectQuery = "SELECT * FROM mydb.user WHERE id = '" + ConfigManager.GetInstance().userid + "'";
                try
                {
                    MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0][7];
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                catch { }
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
            }
            catch { }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ConfigManager.GetInstance().poststore_id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
                label1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                MessageBox.Show("선택 되었습니다.");
            }
            catch { }
        }

        private void modify_btn_Click_1(object sender, EventArgs e)
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

                    DBManager.getInstance().insert("UPDATE board SET content='" + post_add_context.Text + "', update_time='" + date + "', secret='" + secret + "', store_id=" + ConfigManager.GetInstance().poststore_id + "  WHERE id = " + ConfigManager.GetInstance().postid);

                    MemoryStream ms = new MemoryStream();
                    try
                    {
                        post_add_picture.Image.Save(ms, post_add_picture.Image.RawFormat);
                        img = ms.ToArray();
                        String insertQuery = "update mydb.board set photo=@img where id=" + ConfigManager.GetInstance().postid;
                        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                        MySqlCommand command;
                        connection.Open();
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@img", MySqlDbType.Blob);
                        command.Parameters["@img"].Value = img;
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Data Inserted");
                        }
                        else
                        {
                            MessageBox.Show("Data insert failed");
                        }

                        connection.Close();
                        MessageBox.Show("수정되었습니다.");
                        Close();
                    }
                    catch { }
                }
            }
            catch { }
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch { }
        }

        private void post_load_image_btn_Click_1(object sender, EventArgs e)
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
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

