using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TuLieuHocTap
{
    public partial class Quanly : Form
    {

        public Quanly()
        {
            InitializeComponent();
        }
        public SqlConnection cn;
        string id = "";
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rd;
        DataTable tb;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public void ketnoi()
        {
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            cn = new SqlConnection(@"" + line + "");
            cn.Open();
        }
        protected void Load_Data()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from STUDENT", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;


            txtname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["name"].Value);
            txtid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["studentid"].Value);
            txtmakhoa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["makhoa"].Value);
            txtmalop.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["malop"].Value);
        }
       
        
        private void button1_Click(object sender, EventArgs e)
        {

            string sql_xoa = "delete STUDENT where studentid = '" + txtid.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql_xoa, cn);
            cn.Close();
            cn.Open();
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xóa thành công!");
                Load_Data();
            }
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            try
            {
                ketnoi();
                //MessageBox.Show("Thành công");
            }
            catch (Exception loi)
            {
                //MessageBox.Show("Thất bại");
            }
            // Load_Data();
            string s = " select * from student ";
            cmd = new SqlCommand(s, cn);
            rd = cmd.ExecuteReader();
            tb = new DataTable();
            tb.Load(rd);
           
          
            Load_Data();
        }
       

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;

            txtname.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["name"].Value);
            txtid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["studentid"].Value);
            txtmakhoa.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["makhoa"].Value);
            txtmalop .Text = Convert.ToString(dataGridView1.CurrentRow.Cells["malop"].Value);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql_up = "update student set name = N'" + txtname.Text + "', makhoa = N'" + txtmakhoa.Text + "', malop = N'" + txtmalop.Text + "' WHERE studentid = '" + txtid.Text + "' "; 
            SqlCommand cmd = new SqlCommand(sql_up, cn);
            cn.Close();
            cn.Open();
            MessageBox.Show(sql_up);
            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("up thành công!");
                Load_Data();
            }
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MAINGUI main = new MAINGUI();
            main.Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
