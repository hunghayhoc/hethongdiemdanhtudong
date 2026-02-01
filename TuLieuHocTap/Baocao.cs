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
using Excel = Microsoft.Office.Interop.Excel;


namespace TuLieuHocTap
{
    public partial class Baocao : Form
    {
        public SqlConnection cn;
        SqlConnection con;
        public Baocao()
        {
            InitializeComponent();
        }
        private void LoadCobkhoa()
        {
            DataTable dt = new DataTable();
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            cn = new SqlConnection(@"" + line + "");
            //cn = new SqlConnection("Server=DESKTOP-MHU5E4L;Initial Catalog=FRSYSTEM_DATABASE;Integrated Security=True");
            cn.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Khoa", cn);

                da.Fill(dt);
                comboBox1.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                // throw new Exception("Error " + ex.ToString());
            }

            try
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Tenkhoa";
                comboBox1.ValueMember = "Makhoa";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void LoadCoblop()
        {
            DataTable dt = new DataTable();
            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            cn = new SqlConnection(@"" + line + "");
            //cn = new SqlConnection("Server=DESKTOP-MHU5E4L;Initial Catalog=FRSYSTEM_DATABASE;Integrated Security=True");
            cn.Open();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Lop Where Makhoa = '" + comboBox1.SelectedValue + "'", cn);

                da.Fill(dt);
                comboBox2.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                // throw new Exception("Error " + ex.ToString());
            }

            try
            {
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Tenlop";
                comboBox2.ValueMember = "Malop";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n", ex.ToString());
            }
        }
        private void LoadCobmonhoc()
        {
            comboBox3.Items.Add("Toán CC A1");
            comboBox3.Items.Add("Toán CC A2");
            comboBox3.Items.Add("Toán CC A3");
            comboBox3.Items.Add("Vật Lý Đại Cương A1");
            comboBox3.Items.Add("Vật Lý Đại Cương A2");
            comboBox3.Items.Add("Hóa Học Đại Cương");
            comboBox3.Items.Add("Xác Suất Thống Kê");
            comboBox3.Items.Add("Toán Kinh Tế");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "BaoCaoDiemDanh-Ngay" + theDate;

                try
                {
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Xuất báo cáo thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Lỗi : " + ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message.ToString());
            }
        }

        private void Baocao_Load(object sender, EventArgs e)
        {
            LoadCobmonhoc();
            LoadCobkhoa();
            LoadCoblop();
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            groupBox1.Enabled = false;
            checkBox2.Enabled = false;

            var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
            StreamReader sr = new StreamReader(txtpath);
            String line = sr.ReadToEnd();
            con = new SqlConnection(@"" + line + "");
            SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM attendance", con); //this will get all marked attendance from the database
            DataTable sd = new DataTable();

            checkup.Fill(sd);
            dataGridView1.DataSource = sd;

            DataTable sd1 = new DataTable();
            sd1 = sd.DefaultView.ToTable(true, "name", "studentid", "dateandtime", "Makhoa", "Malop");

            dataGridView1.DataSource = sd1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                checkBox2.Enabled = false;
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCoblop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string theDate = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            if (checkBox3.Checked == false)
            {
                //MessageBox.Show(theDate);
                var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                StreamReader sr = new StreamReader(txtpath);
                String line = sr.ReadToEnd();
                con = new SqlConnection(@"" + line + "");
                SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM attendance WHERE dateandtime = '" + theDate + "' ORDER BY name ", con);
                DataTable sd = new DataTable();

                checkup.Fill(sd);
                dataGridView1.DataSource = sd;

                DataTable sd1 = new DataTable();
                sd1 = sd.DefaultView.ToTable(true, "name", "studentid", "dateandtime", "Makhoa", "Malop");

                dataGridView1.DataSource = sd1;
            }
            else if (checkBox3.Checked == true)
            {
                if (checkBox1.Checked == true)
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    con = new SqlConnection(@"" + line + "");
                    SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM attendance WHERE dateandtime = '" + theDate + "' AND Makhoa = '" + comboBox1.SelectedValue + "' ORDER BY Makhoa", con);
                    DataTable sd = new DataTable();

                    checkup.Fill(sd);
                    dataGridView1.DataSource = sd;

                    DataTable sd1 = new DataTable();
                    sd1 = sd.DefaultView.ToTable(true, "name", "studentid", "dateandtime", "Makhoa", "Malop");

                    dataGridView1.DataSource = sd1;
                }
                else if (checkBox2.Checked == true)
                {
                    var txtpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ConnectionString.txt");
                    StreamReader sr = new StreamReader(txtpath);
                    String line = sr.ReadToEnd();
                    con = new SqlConnection(@"" + line + "");
                    SqlDataAdapter checkup = new SqlDataAdapter("SELECT * FROM attendance WHERE dateandtime = '" + theDate + "' AND Malop= '" + comboBox2.SelectedValue + "' ORDER BY MaLop", con);
                    DataTable sd = new DataTable();

                    checkup.Fill(sd);
                    dataGridView1.DataSource = sd;

                    DataTable sd1 = new DataTable();
                    sd1 = sd.DefaultView.ToTable(true, "name", "studentid", "dateandtime", "Makhoa", "Malop");

                    dataGridView1.DataSource = sd1;
                }
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
