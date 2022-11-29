using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace responsi
{
    internal class dept
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost, Port=5432, Username=postgres, Password=informatika, Database=postgres";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private int _id_dep;
        private string _nama_dep;


        public int id_dep
        {
            get { return _id_dep; }
        }
        public string nama_dep
        {
            get { return _nama_dep; }
            set { _nama_dep = value; }
        }
    }
}
