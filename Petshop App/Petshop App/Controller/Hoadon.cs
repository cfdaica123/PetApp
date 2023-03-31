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
    public partial class Hoadon : UserControl
    {
        public Hoadon()
        {
            InitializeComponent();
            layidSP();
            hienthisanpham();
        }

        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        //đổ id vào combobox
        private void layidSP()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select maKH from KhachHang", con);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("maKH",typeof(int));
            dt.Load(sdr);
            txt_maKH.ValueMember = "maKH";
            txt_maKH.DataSource = dt;
            con.Close();
        } 

        private void hienthisanpham()
        {
            con.Open();
            String query = "Select * from SanPham";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            SqlCommandBuilder buid = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            pn_sanpham.DataSource = ds.Tables[0];
            con.Close();
        }

        private void laytenSP()
        {
            /*con.Open();
            String Query = "Select * from SanPham where maSP= '" + txt_maKH.SelectedIndex.ToString + "',con";//thiếu where maSP= '"+ txt_maKH.SelectedIndex.ToString+ "'
            SqlCommand cmd = new SqlCommand(Query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_tenSP.Text = dr["tenSP"].ToString();
            }
            con.Close();*/
        }
        int key=0, soluong=0;
        private void capnhatgia()
        {
            try
            {
                int newsoluong = soluong - Convert.ToInt32(txt_soluongSP.Text);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update SanPham set soluongSP=@soluong where maSP=@ma",con);
                cmd.Parameters.AddWithValue("@soluong", newsoluong);
                cmd.Parameters.AddWithValue("@ma", key);

                cmd.ExecuteNonQuery();
                con.Close();
                laytenSP();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int n = 0, GrdTotal = 0;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void pn_sanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenSP.Text = pn_sanpham.SelectedRows[0].Cells[1].Value.ToString();

            soluong = Convert.ToInt32(pn_sanpham.SelectedRows[0].Cells[3].Value.ToString());
            txt_giaKH.Text = pn_sanpham.SelectedRows[0].Cells[4].Value.ToString();
            
            if (txt_tenSP.Text =="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(pn_sanpham.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void txt_soluongSP_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void reset()
        {
            txt_giaKH.Text = "";
            txt_soluongSP.Text = "";
            txt_tenSP.Text = "";
            key = 0;
            soluong = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_soluongSP.Text == "" || Convert.ToInt32(txt_soluongSP.Text) > soluong)
            {
                MessageBox.Show("Không đủ số lượng");
            }
            else if(txt_soluongSP.Text == "" || key == 0)
            {
                MessageBox.Show("Thiếu thông tin");
            }
            else
            {
                int all = Convert.ToInt32(txt_giaKH.Text) * Convert.ToInt32(txt_soluongSP.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(pn_hoadon);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = txt_tenSP.Text;
                newRow.Cells[2].Value = txt_soluongSP.Text;
                newRow.Cells[3].Value = txt_giaKH.Text;
                newRow.Cells[4].Value = all;
                GrdTotal = GrdTotal + all;
                pn_hoadon.Rows.Add(newRow);
                n++;
                txt_tien.Text = "Rs" + GrdTotal;
                capnhatgia();
                reset();
            }
        }
    }
}
