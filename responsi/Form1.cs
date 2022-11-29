using Npgsql;
using System.Data;

namespace responsi
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost, Port=5432, Username=postgres, Password=informatika, Database=postgres";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            karyawan emp = new karyawan();
            emp.nama = tbNama.Text;

            dept departemen = new dept();
            departemen.nama_dep = cb_dep.Text;

            conn = new NpgsqlConnection(connstring);
            try
            {
                conn.Open();
                dgv_hr.DataSource = null;
                sql = "select * from tb_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }



            try
            {
                conn.Open();
                dgv_hr.DataSource = null;
                sql = "select * from tb_select2()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cb_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<dept> list = new List<dept>();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}