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
    public partial class UserInfoUpdate : Form
    {
        public UserInfoUpdate()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            try
            {
               // SetUserInterfaceAttribute();

                //++++++++++++++++++++++++++++++++++++++++++++++++++++++ start ++++++++++++++++++++++++++++++++++++++++++++++++++++++
                SetValuesIntoPictureBox();
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++ end ++++++++++++++++++++++++++++++++++++++++++++++++++++++

                SetValuesIntoTextBox();
            }

            catch { }
        }
        private void SetUserInterfaceAttribute()
        {
            try
            {
                List<Control> allControls = GetAllControls(this);
                allControls.ForEach(k => k.Font = new Font("배달의민족 도현", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 129));
                List<Control> allTextBoxControls = GetAllControls(this);
                allTextBoxControls.ForEach(k => k.Font = new Font("배달의민족 도현", 13.5F, FontStyle.Bold, GraphicsUnit.Point, 129));


                //++++++++++++++++++++++++++++++++++++++++++++++++++++++ start ++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                //
                editImageButton.Width = 172;
                editImageButton.Height = 25;
                editImageButton.FlatStyle = FlatStyle.Flat;
                editImageButton.FlatAppearance.BorderSize = 0;
                editImageButton.BackColor = Color.SteelBlue;
                editImageButton.ForeColor = Color.White;
                editImageButton.FlatAppearance.MouseDownBackColor = Color.Yellow;
                editImageButton.FlatAppearance.MouseOverBackColor = Color.Salmon;
                //++++++++++++++++++++++++++++++++++++++++++++++++++++++ end ++++++++++++++++++++++++++++++++++++++++++++++++++++++
                //
                idTextBox.Dock = DockStyle.Fill;
                idTextBox.BackColor = Color.LightSeaGreen;
                idTextBox.BorderStyle = BorderStyle.None;
                //
                nameTextBox.Dock = DockStyle.Fill;
                nameTextBox.BackColor = Color.LightSeaGreen;
                nameTextBox.BorderStyle = BorderStyle.None;
                //
                addrTextBox.Dock = DockStyle.Fill;
                addrTextBox.BackColor = Color.LightSeaGreen;
                addrTextBox.BorderStyle = BorderStyle.None;
                //
                phoneMaskedTextBox.Dock = DockStyle.Fill;
                phoneMaskedTextBox.BackColor = Color.LightSeaGreen;
                phoneMaskedTextBox.BorderStyle = BorderStyle.None;
                //
                ageTextBox.Dock = DockStyle.Fill;
                ageTextBox.BackColor = Color.LightSeaGreen;
                ageTextBox.BorderStyle = BorderStyle.None;
                //
                maleRadioButton.Dock = DockStyle.Fill;
                maleRadioButton.Font = new Font("배달의민족 도현", 11.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
                //
                femaleRadioButton.Dock = DockStyle.Fill;
                femaleRadioButton.Font = new Font("배달의민족 도현", 11.8F, FontStyle.Bold, GraphicsUnit.Point, 129);
                //
                pwMaskedTextBox1.Dock = DockStyle.Fill;
                pwMaskedTextBox1.BackColor = Color.LightSeaGreen;
                pwMaskedTextBox1.BorderStyle = BorderStyle.None;
                //
                pwMaskedTextBox2.Dock = DockStyle.Fill;
                pwMaskedTextBox2.BackColor = Color.LightSeaGreen;
                pwMaskedTextBox2.BorderStyle = BorderStyle.None;
                //
                editButton.Dock = DockStyle.Fill;
                editButton.FlatStyle = FlatStyle.Flat;
                editButton.FlatAppearance.BorderSize = 0;
                editButton.BackColor = Color.SteelBlue;
                editButton.ForeColor = Color.White;
                editButton.FlatAppearance.MouseDownBackColor = Color.Yellow;
                editButton.FlatAppearance.MouseOverBackColor = Color.Salmon;
                //
                cancelButton.Dock = DockStyle.Fill;
                cancelButton.FlatStyle = FlatStyle.Flat;
                cancelButton.FlatAppearance.BorderSize = 0;
                cancelButton.BackColor = Color.SteelBlue;
                cancelButton.ForeColor = Color.White;
                cancelButton.FlatAppearance.MouseDownBackColor = Color.Yellow;
                cancelButton.FlatAppearance.MouseOverBackColor = Color.Salmon;

                //
                idTextBox.Enabled = false;
                nameTextBox.Enabled = false;
                editButton.Enabled = false;
            }
            catch { }
        }
        private List<Control> GetAllTextBoxControls(Control container, List<Control> list)
        {
                foreach (Control c in container.Controls.OfType<TextBox>())
                {
                    if (c.Controls.Count > 0)
                        list = GetAllControls(c, list);
                    else
                        list.Add(c);
                }
                return list;   
        }
        private List<Control> GetAllControls(Control container, List<Control> list)
        {

                foreach (Control c in container.Controls)
                {
                    if (c.Controls.Count > 0)
                        list = GetAllControls(c, list);
                    else
                        list.Add(c);
                }
                return list;

        }
        private List<Control> GetAllControls(Control container)
        {
            return GetAllControls(container, new List<Control>());
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++ start ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // resource에 default_user 추가하기
        private void SetValuesIntoPictureBox()
        {
            pictureBox1.Image = Properties.Resources.default_user;
            //pictureBox1.Load("default");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            string uid = ConfigManager.GetInstance().GetUid();
            Query query = new Query().Select("photo").From("user").Where("id = '" + uid + "'");
            DataTable dt = DBManager.getInstance().select(query.query);
            if (!(dt.Rows[0][0].Equals(DBNull.Value)))
            {
                byte[] img = (byte[])dt.Rows[0][0];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
        private void editImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog
            {
                Filter = "이미지 선택 (* .jpg; * .png; * .jpeg) | * .jpg; * .png; * .jpeg"
            };
            if (opn.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opn.FileName);
            }
        }
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++ end ++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void SetValuesIntoTextBox()
        {
            string uid = ConfigManager.GetInstance().GetUid();
            Query query = new Query().Select("*").From("user").Where("id = '" + uid + "'");
            DataTable dt = DBManager.getInstance().select(query.query);

            foreach (DataRow row in dt.Rows)
            {
                //아이디 이름 주소 전화번호 나이 성별 비밀번호
                string id = string.Format("{0}", row["id"]);
                string name = string.Format("{0}", row["name"]);
                string addr = string.Format("{0}", row["addr"]);
                string phone = string.Format("{0}", row["phone"]);
                string age = string.Format("{0}", row["age"]);
                string gender = string.Format("{0}", row["gender"]);

                idTextBox.Text = id;
                nameTextBox.Text = name;
                addrTextBox.Text = addr;
                phoneMaskedTextBox.Text = phone;
                ageTextBox.Text = age;
                if (gender == "남자")
                {
                    maleRadioButton.Checked = true;
                }
                else
                {
                    femaleRadioButton.Checked = true;
                }
            }
        }
        private void CheckPassword()
        {
            string PWwrite = pwMaskedTextBox1.Text;
            string PWconfirm = pwMaskedTextBox2.Text;
            //if (PWwrite != "" && PWconfirm != "")
            //{
            if (PWwrite != PWconfirm)
            {
                MessageBox.Show( "비밀번호가 일치하지 않습니다.");
                editButton.Enabled = false;
            }
            else if (PWwrite != "" && PWconfirm != "")
            {
                MessageBox.Show("비밀번호가 일치합니다.");
                editButton.Enabled = true;
            }
            //}
            if (PWwrite == "" || PWconfirm == "")
            {
            }
        }
        private void pwMaskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }
        private void pwMaskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            CheckPassword();
        }
        private void pwMaskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckPassword();
        }
        private void CloseAndShowTheHomeForm()
        {
            Close();
            Home homeForm = new Home();
            homeForm.Show();
        }

        public static Form GetForm(string formName)//이름으로 열려있는 폼 리턴
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == formName)
                    return frm;
            }
            MessageBox.Show("열려있는 " + formName + "폼이 없습니다.");
            return null;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            bool somthingWrong = false;
            string ID = idTextBox.Text;
            string Name = nameTextBox.Text;
            //int PhoneNum = Convert.ToInt32(phoneMaskedTextBox.Text);
            string PhoneNum = phoneMaskedTextBox.Text;
            string Addr = addrTextBox.Text;
            int Age = Convert.ToInt32(ageTextBox.Text);
            string Gender = null;
            string PWwrite = pwMaskedTextBox1.Text;
            string PWconfirm = pwMaskedTextBox2.Text;
            string queryId = "SELECT * FROM user";
            DataTable dt = DBManager.getInstance().select(queryId);
            StringBuilder sb = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                string str = string.Format($"{row["ID"]}");
                sb.Append(str + " ");
                if (String.IsNullOrWhiteSpace(addrTextBox.Text) || String.IsNullOrWhiteSpace(idTextBox.Text) || String.IsNullOrWhiteSpace(nameTextBox.Text) || String.IsNullOrWhiteSpace(phoneMaskedTextBox.Text) || String.IsNullOrWhiteSpace(ageTextBox.Text) || String.IsNullOrWhiteSpace(PWwrite) || String.IsNullOrWhiteSpace(PWconfirm)) 
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
                else if (femaleRadioButton.Checked == maleRadioButton.Checked)
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

            if (somthingWrong == false)
            {
                if (maleRadioButton.Checked == true && femaleRadioButton.Checked == false)
                {
                    Gender = "남자";
                }
                else if (femaleRadioButton.Checked == true && maleRadioButton.Checked == false)
                {
                    Gender = "여자";
                }
                Query query = new Query().Update("user").Set("name = '" + Name + "', phone = '" + PhoneNum + "', age = " + Age + ", gender = '" + Gender + "', password = '" + PWconfirm + "', addr = '" + Addr + "'").Where("id = '" + ID + "'");
                DBManager.getInstance().update(query.query);
                SaveImage();
                MessageBox.Show("회원수정 완료");
                Home home = new Home();
                Hide();
                home.ShowDialog();
                Close();
            }
        }
        private void SaveImage()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] img = ms.ToArray();

            string ID = ConfigManager.GetInstance().GetUid();
            Query query = new Query().Update("user").Set("photo = @img").Where("id = '" + ID + "'");
            DBManager.getInstance().updatePhoto(query.query, img);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            Hide();
            home.ShowDialog();
            Close();
        }

    }
}