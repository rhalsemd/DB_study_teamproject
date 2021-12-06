using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpro
{
    class ConfigManager
    {
        public bool aboutLogin = false;
        public string userid = "";
        public string password = "";
        public string sent_time = "";
        public int user_group = -1;
        public Boolean isgroup = false;
        public Boolean issender = false;
        public int msg_id = -1;
        public int? poststore_id = -1;
        public int postid = -1;
        public string postuserid = "";
        public string friendid = "";
        public int cid = -1;
        public int gid = 1;
        public int gcid = -1;
        public int priority = -1;
        public int gpostid = -1;
        public int storeid = -1;

        private static ConfigManager instance_ = new ConfigManager();

        public static ConfigManager GetInstance() { return instance_; }

        private ConfigManager()
        { }
        public string GetUid()
        {
            return userid;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
