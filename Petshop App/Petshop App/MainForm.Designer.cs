
namespace Petshop_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.elipse_Home = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipse_Application = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pn_Application = new System.Windows.Forms.Panel();
            this.trangchu1 = new Petshop_App.Controller.Trangchu();
            this.sanpham1 = new Petshop_App.Controller.Sanpham();
            this.nhanvien1 = new Petshop_App.Nhanvien();
            this.hoadon1 = new Petshop_App.Hoadon();
            this.khachhang1 = new Petshop_App.Khachhang();
            this.elipse_Nhanvien = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_hoadon = new Guna.UI2.WinForms.Guna2Button();
            this.btn_khachhang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.btn_pet = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Application.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_Home
            // 
            this.elipse_Home.BorderRadius = 30;
            this.elipse_Home.TargetControl = this;
            // 
            // elipse_Application
            // 
            this.elipse_Application.BorderRadius = 20;
            this.elipse_Application.TargetControl = this.pn_Application;
            // 
            // pn_Application
            // 
            this.pn_Application.BackColor = System.Drawing.Color.Teal;
            this.pn_Application.Controls.Add(this.trangchu1);
            this.pn_Application.Controls.Add(this.sanpham1);
            this.pn_Application.Controls.Add(this.nhanvien1);
            this.pn_Application.Controls.Add(this.hoadon1);
            this.pn_Application.Controls.Add(this.khachhang1);
            this.pn_Application.Location = new System.Drawing.Point(12, 12);
            this.pn_Application.Name = "pn_Application";
            this.pn_Application.Size = new System.Drawing.Size(832, 608);
            this.pn_Application.TabIndex = 1;
            this.pn_Application.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Application_Paint);
            // 
            // trangchu1
            // 
            this.trangchu1.BackColor = System.Drawing.Color.Gainsboro;
            this.trangchu1.Location = new System.Drawing.Point(0, 0);
            this.trangchu1.Name = "trangchu1";
            this.trangchu1.Size = new System.Drawing.Size(832, 608);
            this.trangchu1.TabIndex = 4;
            // 
            // sanpham1
            // 
            this.sanpham1.BackColor = System.Drawing.Color.Gainsboro;
            this.sanpham1.Location = new System.Drawing.Point(0, 0);
            this.sanpham1.Name = "sanpham1";
            this.sanpham1.Size = new System.Drawing.Size(832, 608);
            this.sanpham1.TabIndex = 3;
            // 
            // nhanvien1
            // 
            this.nhanvien1.BackColor = System.Drawing.Color.Gainsboro;
            this.nhanvien1.Location = new System.Drawing.Point(0, 0);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(832, 608);
            this.nhanvien1.TabIndex = 2;
            // 
            // hoadon1
            // 
            this.hoadon1.BackColor = System.Drawing.Color.Gainsboro;
            this.hoadon1.Location = new System.Drawing.Point(0, 0);
            this.hoadon1.Name = "hoadon1";
            this.hoadon1.Size = new System.Drawing.Size(832, 608);
            this.hoadon1.TabIndex = 1;
            // 
            // khachhang1
            // 
            this.khachhang1.BackColor = System.Drawing.Color.Gainsboro;
            this.khachhang1.Location = new System.Drawing.Point(0, 0);
            this.khachhang1.Name = "khachhang1";
            this.khachhang1.Size = new System.Drawing.Size(832, 608);
            this.khachhang1.TabIndex = 0;
            // 
            // elipse_Nhanvien
            // 
            this.elipse_Nhanvien.BorderRadius = 20;
            this.elipse_Nhanvien.TargetControl = this.pn_Application;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Petshop_App.Properties.Resources.exit;
            this.pictureBox2.Location = new System.Drawing.Point(913, 521);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // btn_hoadon
            // 
            this.btn_hoadon.BackColor = System.Drawing.Color.Transparent;
            this.btn_hoadon.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_hoadon.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_hoadon.CheckedState.Parent = this.btn_hoadon;
            this.btn_hoadon.CustomImages.Parent = this.btn_hoadon;
            this.btn_hoadon.FillColor = System.Drawing.Color.Transparent;
            this.btn_hoadon.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btn_hoadon.ForeColor = System.Drawing.Color.Black;
            this.btn_hoadon.HoverState.Parent = this.btn_hoadon;
            this.btn_hoadon.Image = global::Petshop_App.Properties.Resources.bill;
            this.btn_hoadon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_hoadon.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_hoadon.Location = new System.Drawing.Point(843, 313);
            this.btn_hoadon.Name = "btn_hoadon";
            this.btn_hoadon.ShadowDecoration.Parent = this.btn_hoadon;
            this.btn_hoadon.Size = new System.Drawing.Size(173, 45);
            this.btn_hoadon.TabIndex = 6;
            this.btn_hoadon.Text = "Hóa đơn";
            this.btn_hoadon.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_hoadon.Click += new System.EventHandler(this.btn_hoadon_Click);
            // 
            // btn_khachhang
            // 
            this.btn_khachhang.BackColor = System.Drawing.Color.Transparent;
            this.btn_khachhang.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_khachhang.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_khachhang.CheckedState.Parent = this.btn_khachhang;
            this.btn_khachhang.CustomImages.Parent = this.btn_khachhang;
            this.btn_khachhang.FillColor = System.Drawing.Color.Transparent;
            this.btn_khachhang.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btn_khachhang.ForeColor = System.Drawing.Color.Black;
            this.btn_khachhang.HoverState.Parent = this.btn_khachhang;
            this.btn_khachhang.Image = global::Petshop_App.Properties.Resources.rating;
            this.btn_khachhang.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_khachhang.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_khachhang.Location = new System.Drawing.Point(843, 262);
            this.btn_khachhang.Name = "btn_khachhang";
            this.btn_khachhang.ShadowDecoration.Parent = this.btn_khachhang;
            this.btn_khachhang.Size = new System.Drawing.Size(173, 45);
            this.btn_khachhang.TabIndex = 5;
            this.btn_khachhang.Text = "Khách hàng";
            this.btn_khachhang.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_khachhang.Click += new System.EventHandler(this.btn_khachhang_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.BackColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_nhanvien.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_nhanvien.CheckedState.Parent = this.btn_nhanvien;
            this.btn_nhanvien.CustomImages.Parent = this.btn_nhanvien;
            this.btn_nhanvien.FillColor = System.Drawing.Color.Transparent;
            this.btn_nhanvien.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btn_nhanvien.ForeColor = System.Drawing.Color.Black;
            this.btn_nhanvien.HoverState.Parent = this.btn_nhanvien;
            this.btn_nhanvien.Image = global::Petshop_App.Properties.Resources.workers;
            this.btn_nhanvien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_nhanvien.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_nhanvien.Location = new System.Drawing.Point(843, 208);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.ShadowDecoration.Parent = this.btn_nhanvien;
            this.btn_nhanvien.Size = new System.Drawing.Size(173, 45);
            this.btn_nhanvien.TabIndex = 4;
            this.btn_nhanvien.Text = "Nhân viên";
            this.btn_nhanvien.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // btn_pet
            // 
            this.btn_pet.BackColor = System.Drawing.Color.Transparent;
            this.btn_pet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_pet.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_pet.CheckedState.Parent = this.btn_pet;
            this.btn_pet.CustomImages.Parent = this.btn_pet;
            this.btn_pet.FillColor = System.Drawing.Color.Transparent;
            this.btn_pet.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic);
            this.btn_pet.ForeColor = System.Drawing.Color.Black;
            this.btn_pet.HoverState.Parent = this.btn_pet;
            this.btn_pet.Image = global::Petshop_App.Properties.Resources.pet;
            this.btn_pet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_pet.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_pet.Location = new System.Drawing.Point(843, 154);
            this.btn_pet.Name = "btn_pet";
            this.btn_pet.ShadowDecoration.Parent = this.btn_pet;
            this.btn_pet.Size = new System.Drawing.Size(173, 45);
            this.btn_pet.TabIndex = 3;
            this.btn_pet.Text = "Sản phẩm";
            this.btn_pet.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_pet.Click += new System.EventHandler(this.btn_pet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Petshop_App.Properties.Resources.cancel_25px;
            this.pictureBox1.Location = new System.Drawing.Point(991, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_home.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.btn_home.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.btn_home.CheckedState.Parent = this.btn_home;
            this.btn_home.CustomImages.Parent = this.btn_home;
            this.btn_home.FillColor = System.Drawing.Color.Transparent;
            this.btn_home.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.Black;
            this.btn_home.HoverState.Parent = this.btn_home;
            this.btn_home.Image = global::Petshop_App.Properties.Resources.home;
            this.btn_home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_home.Location = new System.Drawing.Point(843, 103);
            this.btn_home.Name = "btn_home";
            this.btn_home.ShadowDecoration.Parent = this.btn_home;
            this.btn_home.Size = new System.Drawing.Size(173, 45);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1028, 632);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_hoadon);
            this.Controls.Add(this.btn_khachhang);
            this.Controls.Add(this.btn_nhanvien);
            this.Controls.Add(this.btn_pet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.pn_Application);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pn_Application.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Elipse elipse_Application;
        private Guna.UI2.WinForms.Guna2Button btn_hoadon;
        private Guna.UI2.WinForms.Guna2Button btn_khachhang;
        private Guna.UI2.WinForms.Guna2Button btn_nhanvien;
        private Guna.UI2.WinForms.Guna2Button btn_pet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Elipse elipse_Nhanvien;
        private System.Windows.Forms.Panel pn_Application;
        private Khachhang khachhang1;
        private Nhanvien nhanvien1;
        private Hoadon hoadon1;
        private Controller.Trangchu trangchu1;
        private Controller.Sanpham sanpham1;
    }
}

