
namespace Petshop_App
{
    partial class Khachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.elipse_Khachhang = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_luu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_sua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pn_nhanvien = new System.Windows.Forms.Panel();
            this.txt_dateKH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gioitinhKH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_addKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pn_danhsachkhachhang = new Bunifu.UI.WinForms.BunifuDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_nhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_danhsachkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // elipse_Khachhang
            // 
            this.elipse_Khachhang.BorderRadius = 20;
            this.elipse_Khachhang.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Petshop_App.Properties.Resources.pet_house;
            this.pictureBox1.Location = new System.Drawing.Point(721, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_luu
            // 
            this.btn_luu.ActiveBorderThickness = 1;
            this.btn_luu.ActiveCornerRadius = 20;
            this.btn_luu.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_luu.ActiveForecolor = System.Drawing.Color.White;
            this.btn_luu.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_luu.BackColor = System.Drawing.Color.Silver;
            this.btn_luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_luu.BackgroundImage")));
            this.btn_luu.ButtonText = "Cập nhật";
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_luu.IdleBorderThickness = 1;
            this.btn_luu.IdleCornerRadius = 20;
            this.btn_luu.IdleFillColor = System.Drawing.Color.White;
            this.btn_luu.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_luu.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_luu.Location = new System.Drawing.Point(233, 167);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(104, 47);
            this.btn_luu.TabIndex = 17;
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ActiveBorderThickness = 1;
            this.btn_sua.ActiveCornerRadius = 20;
            this.btn_sua.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.ActiveForecolor = System.Drawing.Color.White;
            this.btn_sua.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.BackColor = System.Drawing.Color.Silver;
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.ButtonText = "Sửa";
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.IdleBorderThickness = 1;
            this.btn_sua.IdleCornerRadius = 20;
            this.btn_sua.IdleFillColor = System.Drawing.Color.White;
            this.btn_sua.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_sua.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_sua.Location = new System.Drawing.Point(347, 167);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(104, 47);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveBorderThickness = 1;
            this.btn_xoa.ActiveCornerRadius = 20;
            this.btn_xoa.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.ActiveForecolor = System.Drawing.Color.White;
            this.btn_xoa.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.BackColor = System.Drawing.Color.Silver;
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.ButtonText = "Xóa";
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.IdleBorderThickness = 1;
            this.btn_xoa.IdleCornerRadius = 20;
            this.btn_xoa.IdleFillColor = System.Drawing.Color.White;
            this.btn_xoa.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_xoa.Location = new System.Drawing.Point(461, 167);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(104, 47);
            this.btn_xoa.TabIndex = 19;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // pn_nhanvien
            // 
            this.pn_nhanvien.AutoScroll = true;
            this.pn_nhanvien.BackColor = System.Drawing.Color.Silver;
            this.pn_nhanvien.Controls.Add(this.txt_dateKH);
            this.pn_nhanvien.Controls.Add(this.label3);
            this.pn_nhanvien.Controls.Add(this.txt_gioitinhKH);
            this.pn_nhanvien.Controls.Add(this.label5);
            this.pn_nhanvien.Controls.Add(this.txt_sdtKH);
            this.pn_nhanvien.Controls.Add(this.label8);
            this.pn_nhanvien.Controls.Add(this.txt_addKH);
            this.pn_nhanvien.Controls.Add(this.label2);
            this.pn_nhanvien.Controls.Add(this.txt_tenKH);
            this.pn_nhanvien.Controls.Add(this.label6);
            this.pn_nhanvien.Controls.Add(this.btn_xoa);
            this.pn_nhanvien.Controls.Add(this.btn_sua);
            this.pn_nhanvien.Controls.Add(this.btn_luu);
            this.pn_nhanvien.Controls.Add(this.pictureBox1);
            this.pn_nhanvien.Controls.Add(this.label1);
            this.pn_nhanvien.Location = new System.Drawing.Point(15, 17);
            this.pn_nhanvien.Name = "pn_nhanvien";
            this.pn_nhanvien.Size = new System.Drawing.Size(800, 218);
            this.pn_nhanvien.TabIndex = 2;
            // 
            // txt_dateKH
            // 
            this.txt_dateKH.BorderRadius = 10;
            this.txt_dateKH.CheckedState.Parent = this.txt_dateKH;
            this.txt_dateKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dateKH.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_dateKH.HoverState.Parent = this.txt_dateKH;
            this.txt_dateKH.Location = new System.Drawing.Point(116, 129);
            this.txt_dateKH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txt_dateKH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_dateKH.Name = "txt_dateKH";
            this.txt_dateKH.ShadowDecoration.Parent = this.txt_dateKH;
            this.txt_dateKH.Size = new System.Drawing.Size(138, 36);
            this.txt_dateKH.TabIndex = 29;
            this.txt_dateKH.Value = new System.DateTime(2021, 9, 7, 3, 16, 18, 469);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(483, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giới tính";
            // 
            // txt_gioitinhKH
            // 
            this.txt_gioitinhKH.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioitinhKH.FormattingEnabled = true;
            this.txt_gioitinhKH.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txt_gioitinhKH.Location = new System.Drawing.Point(495, 129);
            this.txt_gioitinhKH.Name = "txt_gioitinhKH";
            this.txt_gioitinhKH.Size = new System.Drawing.Size(79, 28);
            this.txt_gioitinhKH.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(112, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày sinh";
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtKH.Location = new System.Drawing.Point(455, 71);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.Size = new System.Drawing.Size(160, 28);
            this.txt_sdtKH.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(451, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "Số điện thoại";
            // 
            // txt_addKH
            // 
            this.txt_addKH.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addKH.Location = new System.Drawing.Point(275, 71);
            this.txt_addKH.Multiline = true;
            this.txt_addKH.Name = "txt_addKH";
            this.txt_addKH.Size = new System.Drawing.Size(174, 86);
            this.txt_addKH.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(271, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Địa chỉ";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenKH.Location = new System.Drawing.Point(116, 71);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(143, 28);
            this.txt_tenKH.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(112, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Họ tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Olive;
            this.label7.Location = new System.Drawing.Point(219, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 36);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // pn_danhsachkhachhang
            // 
            this.pn_danhsachkhachhang.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.pn_danhsachkhachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.pn_danhsachkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pn_danhsachkhachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pn_danhsachkhachhang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.pn_danhsachkhachhang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pn_danhsachkhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.pn_danhsachkhachhang.ColumnHeadersHeight = 40;
            this.pn_danhsachkhachhang.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.pn_danhsachkhachhang.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pn_danhsachkhachhang.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.pn_danhsachkhachhang.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pn_danhsachkhachhang.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.pn_danhsachkhachhang.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.pn_danhsachkhachhang.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.pn_danhsachkhachhang.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.pn_danhsachkhachhang.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.pn_danhsachkhachhang.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.pn_danhsachkhachhang.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.pn_danhsachkhachhang.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.pn_danhsachkhachhang.CurrentTheme.Name = null;
            this.pn_danhsachkhachhang.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.pn_danhsachkhachhang.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.pn_danhsachkhachhang.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.pn_danhsachkhachhang.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pn_danhsachkhachhang.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pn_danhsachkhachhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.pn_danhsachkhachhang.EnableHeadersVisualStyles = false;
            this.pn_danhsachkhachhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.pn_danhsachkhachhang.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.pn_danhsachkhachhang.HeaderBgColor = System.Drawing.Color.Empty;
            this.pn_danhsachkhachhang.HeaderForeColor = System.Drawing.Color.White;
            this.pn_danhsachkhachhang.Location = new System.Drawing.Point(15, 276);
            this.pn_danhsachkhachhang.Name = "pn_danhsachkhachhang";
            this.pn_danhsachkhachhang.RowHeadersVisible = false;
            this.pn_danhsachkhachhang.RowTemplate.Height = 40;
            this.pn_danhsachkhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pn_danhsachkhachhang.Size = new System.Drawing.Size(800, 318);
            this.pn_danhsachkhachhang.TabIndex = 30;
            this.pn_danhsachkhachhang.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.pn_danhsachkhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pn_danhsachkhachhang_CellContentClick);
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pn_nhanvien);
            this.Controls.Add(this.pn_danhsachkhachhang);
            this.Name = "Khachhang";
            this.Size = new System.Drawing.Size(832, 608);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_nhanvien.ResumeLayout(false);
            this.pn_nhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pn_danhsachkhachhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipse_Khachhang;
        private System.Windows.Forms.Panel pn_nhanvien;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_xoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sua;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_luu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_gioitinhKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_addKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker txt_dateKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView pn_danhsachkhachhang;
    }
}
