using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    internal class karyawan
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost, Port=5432, Username=postgres, Password=informatika, Database=postgres";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;

        private int _id_karyawan;
        private string _nama;
        private int _id_dep;

        public int id_karyawan { 
            get { return _id_karyawan; }
        }
        public string nama
        {
            get { return _nama; }
            set { _nama = value; }
        }
        public int id_deo
        {
            get { return _id_dep; } 
        }

    }
}
