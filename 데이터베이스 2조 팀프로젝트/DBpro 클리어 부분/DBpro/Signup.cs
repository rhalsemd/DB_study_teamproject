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
    public partial class Signup : Form
    {
        string image_file = string.Empty;
        public Signup()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AssignConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool somthingWrong = false;
                string ID = IDtextbox.Text;
                string Name = Nametextbox.Text;
                string PhoneNum = (Phonetextbox.Text);
                string Addr = Addrtextbox.Text;
                int Age;
                try
                {
                    Age = Convert.ToInt32(Birthtextbox.Text);
                }
                catch
                {
                    MessageBox.Show("나이가 제대로 입력되지 않았습니다.");
                    return;
                }
                string Gender = null;
                string PWwrite = PWwritetextbox.Text;
                string PWconfirm = PWConfirmtextbox.Text;
                string queryId = "SELECT * FROM user";
                DataTable dt = DBManager.getInstance().select(queryId);
                StringBuilder sb = new StringBuilder();

                foreach (DataRow row in dt.Rows)
                {
                    string str = string.Format($"{row["ID"]}");
                    sb.Append(str + " ");
                    if (sb.ToString().Contains(IDtextbox.Text))
                    {
                        MessageBox.Show("이미 존재하는 아이디 입니다.");
                        somthingWrong = true;
                        break;
                    }
                    else if (PWwrite != PWconfirm)
                    {
                        MessageBox.Show("비밀번호를 다시 확인하여 주십시오");
                        somthingWrong = true;
                        break;
                    }

                    else if (String.IsNullOrWhiteSpace(Addrtextbox.Text) || String.IsNullOrWhiteSpace(IDtextbox.Text) || String.IsNullOrWhiteSpace(Nametextbox.Text) || String.IsNullOrWhiteSpace(Phonetextbox.Text) || String.IsNullOrWhiteSpace(Birthtextbox.Text))
                    {
                        MessageBox.Show("기입란을 다시 확인하여 주십시오");
                        somthingWrong = true;
                        break;
                    }

                    else if (Age <= 0)
                    {
                        MessageBox.Show("생년월일을 다시 확인하여 주십시오");
                        somthingWrong = true;
                        break;
                    }
                    else if (checkFemale.Checked == checkMale.Checked)
                    {
                        MessageBox.Show("성별란을 다시 확인하여 주십시오");
                        somthingWrong = true;
                        break;
                    }
                    else
                    {
                        somthingWrong = false;
                    }

                }
                if (checkMale.Checked == true && checkFemale.Checked == false && somthingWrong == false)
                {
                    try
                    {
                        Gender = "남자";
                        string id = IDtextbox.Text;
                        string query = $"INSERT INTO user (ID,NAME,PHONE,AGE,GENDER,PASSWORD,ADDR) values('{ID}','{Name}', '{PhoneNum}',{Age},'{Gender}','{PWconfirm}','{Addr}')";
                        DBManager.getInstance().insert(query);
                        MessageBox.Show("회원가입 완료");

                        byte[] img = null;
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        img = ms.ToArray();
                        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!;Charset=utf8");
                        MySqlCommand command;
                        connection.Open();
                        string insertQuery = "UPDATE mydb.user SET photo=@img where ID ='" + id + "'";
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@img", MySqlDbType.MediumBlob);
                        command.Parameters["@img"].Value = img;
                        DBManager.getInstance().insert("insert into follow(uid,target_uid) values('" + ID + "','.')");

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("사진 삽입 성공");
                        }
                        else
                        {
                            Console.WriteLine("사진 삽입 실패");
                        }

                        connection.Close();

                        this.Hide();
                        Login L = new Login();
                        L.ShowDialog();
                        this.Close();
                    }
                    catch
                    {

                    }
                }

                else if (checkFemale.Checked == true && checkMale.Checked == false && somthingWrong == false)
                {
                    byte[] img = null;
                    Gender = "여자";
                    string query = $"INSERT INTO user (ID,NAME,PHONE,AGE,GENDER,PASSWORD,ADDR) values('{ID}','{Name}', '{PhoneNum}',{Age},'{Gender}','{PWconfirm}','{Addr}')";

                    DBManager.getInstance().insert(query);
                    MessageBox.Show("회원가입 완료");

                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        img = ms.ToArray();
                        MySqlConnection connection = new MySqlConnection("datasource=106.10.36.221;port=3306;username=root;password=DBdatabase1217!");
                        MySqlCommand command;
                        connection.Open();
                        string insertQuery = "update mydb.user set photo =@img where ID = '" + IDtextbox.Text + "'";
                        command = new MySqlCommand(insertQuery, connection);
                        command.Parameters.Add("@img", MySqlDbType.MediumBlob);
                        command.Parameters["@img"].Value = img;
                        DBManager.getInstance().insert("insert into follow(uid,target_uid) values('" + ID + "','.')");

                        if (command.ExecuteNonQuery() > 0)
                        {
                            Console.WriteLine("사진 삽입 성공");
                        }
                        else
                        {
                            Console.WriteLine("사진 삽입 실패");
                        }
                    }
                    catch
                    {

                    }

                    this.Hide();
                    Login L = new Login();
                    L.ShowDialog();
                    this.Close();

                }

                else if (checkFemale.Checked == true && checkMale.Checked == true)
                {
                    MessageBox.Show("성별을 하나만 선택하세요.");
                }

                else if (checkFemale.Checked == false && checkMale.Checked == false)
                {
                    MessageBox.Show("성별을 하나 선택하세요.");
                }


            }
            catch { }
        }

        private void AssignCancel_Click(object sender, EventArgs e)
        {
            try
            {
                Login L = new Login();
                this.Hide();
                L.ShowDialog();
                this.Close();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All files(*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    image_file = ofd.FileName.ToString();
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                    pictureBox1.Tag = ofd.FileName;
                }
            }
            catch { }
        }

        private void Phonetextbox_Click(object sender, EventArgs e)
        {
            try
            {
                Phonetextbox.Text = "";
            }
            catch { }
        }
    }
}

