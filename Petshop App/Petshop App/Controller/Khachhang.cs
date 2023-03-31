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

/*Nhân viên bị ngáo nhưng mà chức  năng giống mấy cái kia nên debug một cái làm ví dụ còn lại tương tự tại bị lỗi tửng tửng mà không biết nằm ở đâu :V*/
namespace Petshop_App
{
    public partial class Khachhang : UserControl
    {
        public Khachhang()
        {
            InitializeComponent();
            showKH();
        }

        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        //hiển thị danh sách khách hàng
        private void showKH()
        {
            con.Open();
            string Query = "select * from KhachHang";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pn_danhsachkhachhang.DataSource = ds.Tables[0];
            con.Close();
        }

        //xóa trắng dữ liệu ở các text
        private void clear()
        {
            txt_tenKH.Text = "";
            txt_addKH.Text = "";
            txt_dateKH.Text = "";
            txt_sdtKH.Text = "";
            txt_gioitinhKH.SelectedIndex = -1;
        }

        //xử lý sự kiện nút cập nhật
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (txt_tenKH.Text == "" || txt_addKH.Text == "" || txt_sdtKH.Text == "" || txt_gioitinhKH.SelectedIndex == -1 || txt_dateKH.Text == "" )
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into KhachHang (tenKH, addKH, dateKH, sdtKH, gioitinhKH) values (@ten, @add, @date, @sdt, @gioitinh)", con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenKH.Text);
                    cmd.Parameters.AddWithValue("@add", txt_addKH.Text);
                    cmd.Parameters.AddWithValue("@date", txt_dateKH.Value.Date);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdtKH.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", txt_gioitinhKH.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thông tin  mới!!!");
                    con.Close();
                    showKH();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //xử lý sự kiện nút sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenKH.Text == "" || txt_addKH.Text == "" || txt_sdtKH.Text == "" || txt_gioitinhKH.SelectedIndex == -1 || txt_dateKH.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin...");
            }
            else
            {
                try
                {
                    con.Open();

                    //bắt sự kiện click vào bảng 
                    int currenIndex = pn_danhsachkhachhang.CurrentRow.Index;
                    int mouse = Convert.ToInt32(pn_danhsachkhachhang.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cmd = new SqlCommand("Update KhachHang set tenKH = @ten , addKH = @add, dateKH = @date, sdtKH = @sdt, gioitinhKH = @gioitinh where maKH = '" + mouse + "'", con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenKH.Text);
                    cmd.Parameters.AddWithValue("@add", txt_addKH.Text);
                    cmd.Parameters.AddWithValue("@date", txt_dateKH.Value.Date);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdtKH.Text);
                    cmd.Parameters.AddWithValue("@gioitinh", txt_gioitinhKH.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin khách hàng đã được cập nhật!!!");
                    con.Close();
                    showKH();
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
                MessageBox.Show("Hãy chọn khách hàng mà bạn muốn kick...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from NhanVien where makh=@key", con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhân viên đã được xóa!!!");
                    con.Close();
                    showKH();
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

        private void pn_danhsachkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenKH.Text = pn_danhsachkhachhang.SelectedRows[0].Cells[1].Value.ToString();
            txt_addKH.Text = pn_danhsachkhachhang.SelectedRows[0].Cells[2].Value.ToString();
            txt_dateKH.Text = pn_danhsachkhachhang.SelectedRows[0].Cells[3].Value.ToString();
            txt_sdtKH.Text = pn_danhsachkhachhang.SelectedRows[0].Cells[4].Value.ToString();
            txt_gioitinhKH.Text = pn_danhsachkhachhang.SelectedRows[0].Cells[5].Value.ToString();
            if (txt_tenKH.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(pn_danhsachkhachhang.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
