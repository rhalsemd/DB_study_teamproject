using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Random r = new Random();
            int winning_number = r.Next(1, 11);

            pictureBox1.Image = System.Drawing.Image.FromFile("Loginimage\\"+winning_number.ToString()+".jpg");
            Init();
        }

        public static string userID { get; private set; }

        private void Init()
        {
            try
            {
                pwd_textbox.PasswordChar = '*';
            }
            catch { }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String user = "";


                ConfigManager.GetInstance().userid = this.id_textbox.Text;
                ConfigManager.GetInstance().password = this.pwd_textbox.Text;


                Query query = new Query().select("id").From("user").Where("id='" + ConfigManager.GetInstance().userid + "' AND " + "password='" + ConfigManager.GetInstance().password + "'");
                DataTable dt = DBManager.getInstance().select(query.query);


                foreach (DataRow row in dt.Rows)
                {
                    user = row["id"].ToString();
                }

                if (user != "")
                {
                    ConfigManager.GetInstance().userid = user;
                    ConfigManager.GetInstance().aboutLogin = true;
                    String time_now = DateTime.Now.ToString();

                    this.Hide();

                    Home h = new Home();
                    Friend.userID = id_textbox.Text;
                    h.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("아이디가 존재하지 않거나 비밀번호 오류입니다.");
                }

            }
            catch { }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                Signup h = new Signup();

                h.ShowDialog();
                this.Close();
            }
            catch { }
        }
    }
}