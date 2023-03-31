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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = true;
            trangchu1.BringToFront();
        }

        private void btn_pet_Click(object sender, EventArgs e)
        {
            sanpham1.Visible = true;
            sanpham1.BringToFront();
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            khachhang1.Visible = true;
            khachhang1.BringToFront();
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            nhanvien1.Visible = true;
            nhanvien1.BringToFront();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            hoadon1.Visible = true;
            hoadon1.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_Application_Paint(object sender, PaintEventArgs e)
        {
            trangchu1.Visible = false;
            sanpham1.Visible = false;
            khachhang1.Visible = false;
            nhanvien1.Visible = false;
            hoadon1.Visible = false;
        }
        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        


        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
