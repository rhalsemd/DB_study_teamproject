using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpro
{
    class DBManager
    {
        string strConn = "Server=106.10.36.221;Database=mydb;Uid=root;Pwd=DBdatabase1217!;Charset=utf8";
        private static DBManager instance_ = new DBManager();
        private DBManager()
        {
        }

        public static DBManager getInstance() { return instance_; }

       
        public DataTable select(string query)
        {
            Console.WriteLine(query);
            DataTable dt = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                rdr.Close();
            }
            return dt;
        }

        public DataTable follow(ListView ListView, string query)
        {
            Console.WriteLine(query);
            MySqlConnection conn = new MySqlConnection(strConn);
            ListView.View = View.Details;
            MySqlDataAdapter adapt = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            ListView.Items.Clear();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ID"].ToString());

                    listitem.SubItems.Add(dr["NAME"].ToString());
                    listitem.SubItems.Add(dr["AGE"].ToString());
                    listitem.SubItems.Add(dr["GENDER"].ToString());
                    listitem.SubItems.Add(dr["ADDR"].ToString());

                    ListView.Items.Add(listitem);
                }
            }
            return dt;
        }
        public void update(string query)
        {
            Console.WriteLine(query);
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {

                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
        }
        public void delete(string query)
        {
            Console.WriteLine(query);
            int rdr;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd =
                      new MySqlCommand(query, conn);
                rdr = cmd.ExecuteNonQuery();

            }
        }


        public DataTable follow1(ListView ListView, string query1)
        {

            Console.WriteLine(query1);
            MySqlConnection conn = new MySqlConnection(strConn);


            ListView.View = View.Details;
            MySqlDataAdapter adapt = new MySqlDataAdapter(query1, conn);


            DataTable dt = new DataTable();
            adapt.Fill(dt);
            ListView.Items.Clear();

            if (dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    DataRow dr = dt.Rows[i];
                    ListViewItem listitem = new ListViewItem(dr["ID"].ToString());

                    listitem.SubItems.Add(dr["NAME"].ToString());
                    listitem.SubItems.Add(dr["AGE"].ToString());
                    listitem.SubItems.Add(dr["GENDER"].ToString());
                    listitem.SubItems.Add(dr["ADDR"].ToString());

                    ListView.Items.Add(listitem);



                }
            }
            return dt;
        }

        public int insert(string query)
        {
            Console.WriteLine(query);
            int ret = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                ret = cmd.ExecuteNonQuery();
            }
            return ret;
        }
        public void updatePhoto(string query, byte[] img)
        {
            Console.WriteLine(query);
            int rdr = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                query = "INSERT INTO mydb.user(Id, photo) VALUES(@Id,@Img)";
                cmd.Parameters.Add("@Img", MySqlDbType.MediumBlob);
                cmd.Parameters["@Img"].Value = img;
                rdr = cmd.ExecuteNonQuery();
                if (rdr == 1)
                {
                }
            }
        }
        public DataTable selectPhoto(string query)
        {
            Console.WriteLine(query);
            DataTable dt = new DataTable();
            MySqlDataAdapter da;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                da = new MySqlDataAdapter(cmd);//
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
        }

        public int updateR(string query)
        {
            Console.WriteLine(query);
            int affectedRows = 0;
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                affectedRows = cmd.ExecuteNonQuery();
            }
            return affectedRows;
        }

    }
}
