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
    public partial class makingGroup : Form
    {
        public makingGroup()
        {
            InitializeComponent();
            gridview_set();
            storelist_gridview.Columns[0].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //만들기 버튼
        {
            try
            {
                string gid = "";
                string getsid = "";
                string alreadyexist = "";
                string gname = groupName.Text; //생성하고 싶은 그룹의 이름
                string userId = ConfigManager.GetInstance().userid;

                DataGridViewRow dr = storelist_gridview.SelectedRows[0];
                getsid = dr.Cells[0].Value.ToString();

                String query_already = "SELECT * FROM groupinfo WHERE name LIKE '" + gname + "'";

                DataTable dt_already = DBManager.getInstance().select(query_already);

                foreach (DataRow row in dt_already.Rows)
                {
                    alreadyexist = row["name"].ToString();
                }



                if (getsid == "" || gname == "" || pictureBox1.Image == null) MessageBox.Show("반드시 모두 입력하셔야 합니다 ");
                else if (getsid == "")
                {
                    MessageBox.Show("Store id 오류!");
                }
                else if (alreadyexist != "")
                {
                    MessageBox.Show("중복된 그룹명입니다!");
                }
                else
                {
                    string query = "INSERT INTO groupinfo (name, uid, storeid) VALUES ('" + gname + "', '" + userId + "', '" + Convert.ToInt32(getsid) + "')";
                    DBManager.getInstance().insert(query);

                    DataTable get_gid = DBManager.getInstance().select("SELECT * FROM groupinfo WHERE name='" + gname + "'");
                    foreach (DataRow row in get_gid.Rows)
                    {
                        gid = row["id"].ToString();
                    }

                    string insert_join = "INSERT INTO groupjoin (gid, uid, admin) VALUES ('" + gid + "', '" + userId + "', 2)";
                    DBManager.getInstance().insert(insert_join);

                    byte[] img = null;
                    MemoryStream ms = new MemoryStream();

                    try
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        img = ms.ToArray();
                        String insertQuery = "update mydb.groupinfo set photo=@img WHERE name='" + gname + "' AND uid='" + userId + "'";
                        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!;Charset=utf8");
                        MySqlCommand command;
                        connection.Open();
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@img", MySqlDbType.Blob);
                        command.Parameters["@img"].Value = img;
                        if (command.ExecuteNonQuery() == 1)
                        {
                            //MessageBox.Show("사진삽입 성공!");
                            MessageBox.Show(gname + "의 그룹이 생성되었습니다. ");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("사진삽입 실패!");
                            DBManager.getInstance().delete("delete from mydb.groupinfo where name='" + gname + "' AND uid='" + userId + "'");
                        }

                        connection.Close();
                    }
                    catch { }

                }

            }
            catch { }
        }

        private void storeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(opf.FileName);
                }
                label2.Text = "";
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                gridview_set();
            }
            catch { }
        }

        private void gridview_set()
        {
            try
            {
                string search = textBox.Text;
                string query = "SELECT id AS '상점번호', name AS '상점이름', type AS '업종', addr AS '주소'  FROM store WHERE store.name LIKE '%" + search + "%'";
                DataTable dt = DBManager.getInstance().select(query);

                storelist_gridview.DataSource = dt;
            }
            catch { }
        }

        private void makingGroup_Load(object sender, EventArgs e)
        {

        }

        private void storelist_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}


