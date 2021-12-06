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
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            try
            {
                SetGroupMemberListView();
                ResetGroupMemberListViewItems();
                SetGroupMemberListViewItemsFromDatabase();
                SetGradeComboBox();
            }
            catch { }
        }
        private void SetGroupMemberListView()
        {
            try
            {
                groupMemberListView.Columns.Add("아이디", 100);
                groupMemberListView.Columns.Add("이름", 100);
                groupMemberListView.Columns.Add("나이", 100);
                groupMemberListView.Columns.Add("성별", 100);
                groupMemberListView.Columns.Add("등급", 100);
                groupMemberListView.View = View.Details;
                groupMemberListView.FullRowSelect = true;
                groupMemberListView.GridLines = true;
            }
            catch { }
        }
        private void ResetGroupMemberListViewItems()
        {
            try
            {
                groupMemberListView.Items.Clear();
            }
            catch { }
        }
        private void SetGroupMemberListViewItemsFromDatabase()
        {
            try
            {
                Query query = new Query().Select("u.id, u.name, u.addr, u.age, u.gender, u.photo, j.admin")
                                            .From("user u, groupjoin j")
                                            .Where("u.id = j.uid AND gid =" + ConfigManager.GetInstance().gid + " AND u.id IN (SELECT uid FROM groupjoin WHERE gid =" + ConfigManager.GetInstance().gid + ")")
                                            .OrderBy("admin, name");
                DataTable dt = DBManager.getInstance().select(query.query);
                foreach (DataRow row in dt.Rows)
                {
                    string uid = string.Format("{0}", row["id"]);
                    string name = string.Format("{0}", row["name"]);
                    string addr = string.Format("{0}", row["addr"]);
                    string age = string.Format("{0}", row["age"]);
                    string gender = string.Format("{0}", row["gender"]);
                    //string photo = string.Format("{0}", row["photo"]);
                    string grade = string.Format("{0}", row["admin"]);

                    if (grade != "2")
                    {
                        string[] arr = new string[5];
                        arr[0] = uid;
                        arr[1] = name;
                        arr[2] = age;
                        arr[3] = gender;

                        if (grade == "1")
                        {
                            arr[4] = "매니저";
                        }
                        else if (grade == "0")
                        {
                            arr[4] = "일반 그룹원";
                        }

                        ListViewItem lvt = new ListViewItem(arr);
                        groupMemberListView.Items.Add(lvt);
                    }
                    else { }
                }
            }
            catch { }
        }
        private void SetGradeComboBox()
        {
            try
            {
                gradeComboBox.Items.Add("매니저");
                gradeComboBox.Items.Add("일반 그룹원");
            }
            catch { }
        }
        private void groupMemberListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListView.SelectedListViewItemCollection itemColl = groupMemberListView.SelectedItems;
                foreach (ListViewItem item in itemColl)
                {
                    idLabel.Text = item.SubItems[0].Text;
                    nameLabel.Text = item.SubItems[1].Text;
                    gradeComboBox.Text = item.SubItems[4].Text;
                }
            }
            catch { }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string uid = idLabel.Text;
                string grade = gradeComboBox.Text;
                string gradeColumn = "";

                if (uid == "없음")
                {
                    MessageBox.Show("선택된 유저가 없습니다.");
                    return;
                }
                if (grade == "그룹장")
                {
                    gradeColumn = "2";
                }
                else if (grade == "매니저")
                {
                    gradeColumn = "1";
                }
                else if (grade == "일반 그룹원")
                {
                    gradeColumn = "0";
                }

                Query query = new Query().Update("groupjoin").Set("admin = " + gradeColumn).Where("uid = '" + uid + "' AND gid ='" + ConfigManager.GetInstance().gid + "'");
                int affectedRows = DBManager.getInstance().updateR(query.query);
                if (affectedRows > 0)
                {
                    MessageBox.Show(uid + " 유저의 등급이 " + grade + "으로 변경되었습니다.");
                }
                else
                {
                    MessageBox.Show("등급 조정 실패");
                }

                //리스트뷰 리셋하고 다시 로드
                ResetGroupMemberListViewItems();
                SetGroupMemberListViewItemsFromDatabase();
            }
            catch { }
            }
        private void GroupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Home homeForm = new Home();
                homeForm.Show();
            }
            catch { }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //리스트뷰 리셋하고 검색 결과 로드
                ResetGroupMemberListViewItems();

                string keyword = searchTextBox.Text;

                Query query = new Query().Select("u.id, u.name, u.addr, u.age, u.gender, u.photo, j.admin")
                                            .From("user u, groupjoin j")
                                            .Where("u.id = j.uid AND gid =" + ConfigManager.GetInstance().gid + " AND u.id IN (SELECT uid FROM groupjoin WHERE gid = " + ConfigManager.GetInstance().gid + " AND name LIKE '%" + keyword + "%')")
                                            .OrderBy("admin, name");
                DataTable dt = DBManager.getInstance().select(query.query);
                foreach (DataRow row in dt.Rows)
                {
                    string uid = string.Format("{0}", row["id"]);
                    string name = string.Format("{0}", row["name"]);
                    string addr = string.Format("{0}", row["addr"]);
                    string age = string.Format("{0}", row["age"]);
                    string gender = string.Format("{0}", row["gender"]);
                    //string photo = string.Format("{0}", row["photo"]);
                    string grade = string.Format("{0}", row["admin"]);

                    if (grade != "2")
                    {
                        string[] arr = new string[5];
                        arr[0] = uid;
                        arr[1] = name;
                        arr[2] = age;
                        arr[3] = gender;
                        if (grade == "2")
                        {
                            arr[4] = "그룹장";
                        }
                        else if (grade == "1")
                        {
                            arr[4] = "매니저";
                        }
                        else if (grade == "0")
                        {
                            arr[4] = "일반 그룹원";
                        }

                        ListViewItem lvt = new ListViewItem(arr);
                        groupMemberListView.Items.Add(lvt);
                    }
                    else { }
                }
            }
            catch { }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Gboard gboard = new Gboard();
                gboard.ShowDialog();
                this.Close();
            }
            catch { }
        }
    }
}
