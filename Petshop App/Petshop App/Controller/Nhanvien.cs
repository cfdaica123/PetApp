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

namespace Petshop_App
{
    public partial class Nhanvien : UserControl
    {
        public Nhanvien()
        {
            InitializeComponent();
            showNV();
        }
        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        //hiển thị danh sách nhân viên
        private void showNV()
        {
            con.Open();
            string Query = "select * from NhanVien";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pn_danhsachnhanvien.DataSource = ds.Tables[0];
            con.Close();
        }

        //xóa trắng dữ liệu ở các text
        private void clear()
        {
            txt_addNV.Text = "";
            txt_dateNV.Text = "";
            txt_passNV.Text = "";
            txt_sdtNV.Text = "";
            txt_tenNV.Text = "";
            txt_userNV.Text = "";
        }

        //xử lý sự kiện nút cập nhật
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
             if(txt_tenNV.Text == "" || txt_addNV.Text == "" || txt_sdtNV.Text == "" || txt_userNV.Text == "" || txt_passNV.Text == "" || txt_dateNV.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into NhanVien (tenNV, addNV, dateNV, sdtNV, userNV, passNV) values (@ten, @add, @date, @sdt, @user, @pass)",con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenNV.Text);
                    cmd.Parameters.AddWithValue("@add", txt_addNV.Text);
                    cmd.Parameters.AddWithValue("@date", txt_dateNV.Value.Date);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdtNV.Text);
                    cmd.Parameters.AddWithValue("@user", txt_userNV.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_passNV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã thêm thông tin  mới!!!");
                    con.Close();
                    showNV();
                    clear();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        //nhấn vào danh sách nhân viên để hiển thị lên các textbox tương ứng

        int key = 0;        
        private void pn_danhsachnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[1].Value.ToString();
            txt_addNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[2].Value.ToString();
            txt_dateNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[3].Value.ToString();
            txt_sdtNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[4].Value.ToString();
            txt_userNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[5].Value.ToString();
            txt_passNV.Text = pn_danhsachnhanvien.SelectedRows[0].Cells[6].Value.ToString();
            if (txt_tenNV.Text == "")
            {
                key = 0;
            }else
            {
                key = Convert.ToInt32(pn_danhsachnhanvien.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        //xử lý sự kiện nút sửa
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text == "" || txt_addNV.Text == "" || txt_sdtNV.Text == "" || txt_userNV.Text == "" || txt_passNV.Text == "" || txt_dateNV.Text == "")
            {
                MessageBox.Show("Hãy chọn  một  nhân viên bạn muốn thay đổi thông tin...");
            }
            else
            {
                try
                {
                    con.Open();

                    //bắt sự kiện click vào bảng 
                    int currenIndex = pn_danhsachnhanvien.CurrentRow.Index;
                    int mouse = Convert.ToInt32(pn_danhsachnhanvien.SelectedRows[0].Cells[0].Value.ToString());

                    SqlCommand cmd = new SqlCommand("Update NhanVien set tenNV = @ten , addNV = @add, dateNV = @date, sdtNV = @sdt, userNV = @user, passNV = @pass where maNV = '"+mouse+"'", con);
                    cmd.Parameters.AddWithValue("@ten", txt_tenNV.Text);
                    cmd.Parameters.AddWithValue("@add", txt_addNV.Text);
                    cmd.Parameters.AddWithValue("@date", txt_dateNV.Value.Date);
                    cmd.Parameters.AddWithValue("@sdt", txt_sdtNV.Text);
                    cmd.Parameters.AddWithValue("@user", txt_userNV.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_passNV.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thông tin đã được cập nhật!!!");
                    con.Close();
                    showNV();
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
            if ( key == 0)
            {
                MessageBox.Show("Hãy chọn một nhân viên bạn muốn xóa...");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from NhanVien where maNV=@key", con);
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Nhân viên đã được xóa!!!");
                    con.Close();
                    showNV();
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
