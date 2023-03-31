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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //kết nối CSDL
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iBeos\Documents\PetshopDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string Query = "select userNV, passNV from NhanVien where userNV = '"+txtTaikhoan.Text+ "' and passNV = '" + txtMatkhau.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            var ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count !=0)
            {
                lblThongbao.Visible = false;
                MainForm menu = new MainForm();
                this.Hide();
                menu.Show();
            }
            else
            {
                lblThongbao.Visible = true;
                txtMatkhau.Clear();
            }
        }
    }
}
