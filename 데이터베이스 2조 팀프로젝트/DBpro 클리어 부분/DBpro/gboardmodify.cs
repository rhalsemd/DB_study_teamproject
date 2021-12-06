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
    public partial class gboardmodify : Form
    {
        //static Gboard gboard = Application.OpenForms.OfType<Gboard>().FirstOrDefault();

        String image_file = string.Empty;

        public gboardmodify()
        {
            InitializeComponent();
            InitContent();
        }

        private void InitContent()
        {
            try
            {
                String selectQuery = "SELECT * FROM mydb.gboard WHERE id = " + ConfigManager.GetInstance().gpostid + "";
                DataTable dt = DBManager.getInstance().select(selectQuery);

                foreach (DataRow row in dt.Rows)
                {
                    writer_name_label.Text = row["uid"].ToString();
                    context_textbox.Text = row["content"].ToString();
                }

                try
                {
                    MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0][3];
                    MemoryStream ms = new MemoryStream(img);
                    gboard_image.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                catch { }
            }
            catch { }
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

        private void modify_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                byte[] img = null;

                DBManager.getInstance().insert("UPDATE gboard SET content='" + context_textbox.Text + "', update_time='" + date + "' WHERE id = " + ConfigManager.GetInstance().gpostid);

                MemoryStream ms = new MemoryStream();
                try
                {
                    gboard_image.Image.Save(ms, gboard_image.Image.RawFormat);
                    img = ms.ToArray();
                    String insertQuery = "update mydb.gboard set photo=@img where id=" + ConfigManager.GetInstance().gpostid;
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
                }
                catch { }
            }
            catch { }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
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
            catch{ }
        }

        private void post_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                byte[] img = null;

                DBManager.getInstance().insert("UPDATE gboard SET content='" + context_textbox.Text + "', update_time='" + date + "' WHERE id = " + ConfigManager.GetInstance().gpostid);

                MemoryStream ms = new MemoryStream();
                try
                {
                    gboard_image.Image.Save(ms, gboard_image.Image.RawFormat);
                    img = ms.ToArray();
                    String insertQuery = "update mydb.gboard set photo=@img where id=" + ConfigManager.GetInstance().gpostid;
                    MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
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
                MessageBox.Show("수정 완료");
                Close();
            }
            catch { }
        }
    }
}

