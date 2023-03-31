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
    public partial class Trangchu : UserControl
    {
        public Trangchu()
        {
            InitializeComponent();
            hiencho();
            hienmeo();
            hienthucan();
            hienvatdung();
        }
        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void hiencho()
        {
            string danhmuc = "Chó";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from SanPham where danhmucSP='" + danhmuc + "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_cho.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void hienmeo()
        {
            string danhmuc = "Mèo";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from SanPham where danhmucSP='" + danhmuc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_meo.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void hienthucan()
        {
            string danhmuc = "Thức ăn";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from SanPham where danhmucSP='" + danhmuc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_thucan.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void hienvatdung()
        {
            string danhmuc = "Vật dụng";
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) from SanPham where danhmucSP='" + danhmuc + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txt_vatdung.Text = dt.Rows[0][0].ToString();
            con.Close();
        }
    }
}
