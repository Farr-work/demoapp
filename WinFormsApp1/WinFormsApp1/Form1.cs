using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Connect DB
        static String cnString = @"Data Source=.;Initial Catalog=QuanLyHang;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection conn = new SqlConnection(cnString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select *  from QuanLyHang", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dtgvHang.DataSource = dt;
                }

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbMaH.Equals(""))
            {
                MessageBox.Show("Khong duoc de trong", "ERROR", MessageBoxButtons.OKCancel);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into QuanLyHang values(@MaHang,@TenHang,@NgayNhap,@SoLuong,@GiaBan,@TrangThai)", conn);

                cmd.Parameters.AddWithValue("@MaHang", txbMaH.Text);
                cmd.Parameters.AddWithValue("@TenHang", txbTenH.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtNgayNhap.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txbSoLuong.Text));
                cmd.Parameters.AddWithValue("@GiaBan", float.Parse(txbGia.Text));

                if (rdbHangMoi.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrangThai", false);
                }
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void XoaTextBox()
        {
            txbMaH.Clear();
            txbTenH.Clear();
            txbMaH.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Update QuanLyHang set MaHang=@MaHang,TenHang=@TenHang,NgayNhap=@NgayNhap," +
                    "SoLuong=@SoLuong,GiaBan=@GiaBan,TrangThai=@TrangThai)", conn);

                cmd.Parameters.AddWithValue("@MaHang", txbMaH.Text);
                cmd.Parameters.AddWithValue("@TenHang", txbTenH.Text);
                cmd.Parameters.AddWithValue("@NgayNhap", dtNgayNhap.Value.ToString("yyyy/MM/dd"));
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txbSoLuong.Text));
                cmd.Parameters.AddWithValue("@GiaBan", float.Parse(txbGia.Text));

                if (rdbHangMoi.Checked)
                {
                    cmd.Parameters.AddWithValue("@TrangThai", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@TrangThai", false);
                }
                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Form1_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void dtgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvHang.CurrentRow.Index;
            txbMaH.Text = dtgvHang.Rows[i].Cells[0].Value.ToString();
            txbTenH.Text = dtgvHang.Rows[i].Cells[1].Value.ToString();
            dtNgayNhap.Text = dtgvHang.Rows[i].Cells[2].Value.ToString();
            txbSoLuong.Text = dtgvHang.Rows[i].Cells[3].Value.ToString();
            txbGia.Text = dtgvHang.Rows[i].Cells[4].Value.ToString();
            if (dtgvHang.Rows[i].Cells[5].Value.Equals(true))
            {
                rdbHangMoi.Checked = true;
            }
            else
            {
                rdbHangMoi.Checked = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from QuanLyHang where MaHang='" + txbMaH.Text + "'", conn);

                cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                Form1_Load(sender, e);
                XoaTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from QuanLyHang Where MaHang=@MaHang", conn);

                cmd.Parameters.AddWithValue("@MaHang", txbMaH.Text);
                //cmd.Parameters.AddWithValue("@TenHang", txbTenH.Text);
                //cmd.Parameters.AddWithValue("@NgayNhap", dtNgayNhap.Value.ToString("yyyy/MM/dd"));
                //cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txbSoLuong.Text));
                //cmd.Parameters.AddWithValue("@GiaBan", float.Parse(txbGia.Text));

                //if (rdbHangMoi.Checked)
                //{
                //    cmd.Parameters.AddWithValue("@TrangThai", true);
                //}
                //else
                //{
                //    cmd.Parameters.AddWithValue("@TrangThai", false);
                //}
                cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dtgvHang.DataSource = dt;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                //Form1_Load(sender, e);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OKCancel);
            }
        }
    }
}
