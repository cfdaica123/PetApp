using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Petshop_App.Controller
{
    public partial class Sanpham : UserControl
    {
        public Sanpham()
        {
            InitializeComponent();
            showSP();
        }

        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        //hiển thị danh sách nhân viên
        private void showSP()
        {
            con.Open();
            string Query = "select * from SanPham";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pn_danhsachsanpham.DataSource = ds.Tables[0];
            con.Close();
        }

        //xóa trắng dữ liệu ở các text
        private void clear()
        {
            txt_tenSP.Text = "";
            txt_soluongSP.Text = "";
            txt_giaSP.Text = "";
            txt_danhmucSP.SelectedIndex = -1;
        }

        //xử lý sự kiện nút cập nhật
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tenSP.Text == "" || txt_danhmucSP.SelectedIndex == -1 || txt_soluongSP.Text == "" || txt_giaSP.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SanPham (tenSP, danhmucSP, soluongSP, giaSP) values (@ten, @danhmuc, @soluong, @gia)", con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenSP.Text);
                    cmd.Parameters.AddWithValue("@danhmuc", txt_danhmucSP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@soluong", txt_soluongSP.Text);
                    cmd.Parameters.AddWithValue("@gia", txt_giaSP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm sản phẩm  mới!!!");
                    con.Close();
                    showSP();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //nhấn vào danh sách nhân viên để hiển thị lên các textbox tương ứng

        int key = 0;
        private void pn_danhsachsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenSP.Text = pn_danhsachsanpham.SelectedRows[0].Cells[1].Value.ToString();
            txt_danhmucSP.Text = pn_danhsachsanpham.SelectedRows[0].Cells[2].Value.ToString();
            txt_soluongSP.Text = pn_danhsachsanpham.SelectedRows[0].Cells[3].Value.ToString();
            txt_giaSP.Text = pn_danhsachsanpham.SelectedRows[0].Cells[4].Value.ToString();
            if (txt_tenSP.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(pn_danhsachsanpham.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //xử lý sự kiện nút sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenSP.Text == "" || txt_danhmucSP.SelectedIndex == -1 || txt_soluongSP.Text == "" || txt_giaSP.Text == "")
            {
                MessageBox.Show("Hãy chọn một sản phẩm mà bạn muốn thay đổi thông tin...");
            }
            else
            {
                try
                {
                    con.Open();

                    //bắt sự kiện click vào bảng 
                    int currenIndex = pn_danhsachsanpham.CurrentRow.Index;
                    int mouse = Convert.ToInt32(pn_danhsachsanpham.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cmd = new SqlCommand("Update SanPham set tenSP = @ten , danhmucSP = @danhmuc, soluongSP = @soluong, giaSP = @gia where maSP = '" + mouse + "'", con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenSP.Text);
                    cmd.Parameters.AddWithValue("@danhmuc", txt_danhmucSP.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@soluong", txt_soluongSP.Text);
                    cmd.Parameters.AddWithValue("@gia", txt_giaSP.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin đã được cập nhật!!!");
                    con.Close();
                    showSP();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //xử lý sự kiện nút xóa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Hãy chọn một sản phẩm mà bạn muốn xóa...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from SanPham where maSP=@key", con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sản phẩm này đã được xóa!!!");
                    con.Close();
                    showSP();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
