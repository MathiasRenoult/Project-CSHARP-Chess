using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessUI
{
    public class DatabaseConfig
    {
        private string server;
        private string db;
        private string uid;
        private string password;

        public DatabaseConfig(string server, string db, string uid, string password)
        {
            this.server = server;
            this.db = db;
            this.uid= uid;
            this.password = password;
        }

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
        public string Db
        {
            get { return db; }
            set { db = value; }
        }
        public string Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
