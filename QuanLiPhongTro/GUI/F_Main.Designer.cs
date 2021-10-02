namespace GUI
{
    partial class F_Main
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.saoLưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khôiPhụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_qlKhu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_qlPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_qlCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.i_qlHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_ChuyenPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_nvQuaTrinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_thongke = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcKhu = new System.Windows.Forms.ToolStripMenuItem();
            this.chươngTrìnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status1,
            this.status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(876, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status1
            // 
            this.status1.Name = "status1";
            this.status1.Size = new System.Drawing.Size(118, 17);
            this.status1.Text = "toolStripStatusLabel1";
            // 
            // status2
            // 
            this.status2.Name = "status2";
            this.status2.Size = new System.Drawing.Size(118, 17);
            this.status2.Text = "toolStripStatusLabel2";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem,
            this.chươngTrìnhToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(876, 24);
            this.menuMain.TabIndex = 4;
            this.menuMain.Text = "menuStrip1";
            this.menuMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuMain_ItemClicked);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_htDangNhap,
            this.i_htDangXuat,
            this.i_htDoiMK,
            this.i_htDuLieu});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // i_htDangNhap
            // 
            this.i_htDangNhap.Name = "i_htDangNhap";
            this.i_htDangNhap.Size = new System.Drawing.Size(152, 22);
            this.i_htDangNhap.Text = "Đăng Nhập";
            this.i_htDangNhap.Click += new System.EventHandler(this.i_htDangNhap_Click);
            // 
            // i_htDangXuat
            // 
            this.i_htDangXuat.Name = "i_htDangXuat";
            this.i_htDangXuat.Size = new System.Drawing.Size(152, 22);
            this.i_htDangXuat.Text = "Đăng Xuất";
            this.i_htDangXuat.Click += new System.EventHandler(this.i_htDangXuat_Click);
            // 
            // i_htDoiMK
            // 
            this.i_htDoiMK.Name = "i_htDoiMK";
            this.i_htDoiMK.Size = new System.Drawing.Size(152, 22);
            this.i_htDoiMK.Text = "Đổi Mật Khẩu";
            this.i_htDoiMK.Click += new System.EventHandler(this.i_htDoiMK_Click);
            // 
            // i_htDuLieu
            // 
            this.i_htDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saoLưuToolStripMenuItem,
            this.khôiPhụcToolStripMenuItem});
            this.i_htDuLieu.Name = "i_htDuLieu";
            this.i_htDuLieu.Size = new System.Drawing.Size(152, 22);
            this.i_htDuLieu.Text = "Dữ liệu";
            // 
            // saoLưuToolStripMenuItem
            // 
            this.saoLưuToolStripMenuItem.Name = "saoLưuToolStripMenuItem";
            this.saoLưuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saoLưuToolStripMenuItem.Text = "Sao lưu";
            this.saoLưuToolStripMenuItem.Click += new System.EventHandler(this.saoLưuToolStripMenuItem_Click);
            // 
            // khôiPhụcToolStripMenuItem
            // 
            this.khôiPhụcToolStripMenuItem.Name = "khôiPhụcToolStripMenuItem";
            this.khôiPhụcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.khôiPhụcToolStripMenuItem.Text = "Khôi phục";
            this.khôiPhụcToolStripMenuItem.Click += new System.EventHandler(this.khôiPhụcToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_qlKhu,
            this.i_qlPhong,
            this.i_qlCaNhan,
            this.i_qlHoaDon});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // i_qlKhu
            // 
            this.i_qlKhu.Name = "i_qlKhu";
            this.i_qlKhu.Size = new System.Drawing.Size(152, 22);
            this.i_qlKhu.Text = "QL Khu";
            this.i_qlKhu.Click += new System.EventHandler(this.i_qlKhu_Click);
            // 
            // i_qlPhong
            // 
            this.i_qlPhong.Name = "i_qlPhong";
            this.i_qlPhong.Size = new System.Drawing.Size(152, 22);
            this.i_qlPhong.Text = "QL Phòng";
            this.i_qlPhong.Click += new System.EventHandler(this.i_qlPhong_Click);
            // 
            // i_qlCaNhan
            // 
            this.i_qlCaNhan.Name = "i_qlCaNhan";
            this.i_qlCaNhan.Size = new System.Drawing.Size(152, 22);
            this.i_qlCaNhan.Text = "QL Thông Tin";
            this.i_qlCaNhan.Click += new System.EventHandler(this.i_qlCaNhan_Click);
            // 
            // i_qlHoaDon
            // 
            this.i_qlHoaDon.Name = "i_qlHoaDon";
            this.i_qlHoaDon.Size = new System.Drawing.Size(152, 22);
            this.i_qlHoaDon.Text = "QL Hóa Đơn";
            this.i_qlHoaDon.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_ChuyenPhong,
            this.i_nvQuaTrinhLuong,
            this.i_thongke});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            this.nghiệpVụToolStripMenuItem.Click += new System.EventHandler(this.nghiệpVụToolStripMenuItem_Click);
            // 
            // i_ChuyenPhong
            // 
            this.i_ChuyenPhong.Name = "i_ChuyenPhong";
            this.i_ChuyenPhong.Size = new System.Drawing.Size(153, 22);
            this.i_ChuyenPhong.Text = "Chuyển Phòng";
            this.i_ChuyenPhong.Click += new System.EventHandler(this.i_ChuyenPhong_Click);
            // 
            // i_nvQuaTrinhLuong
            // 
            this.i_nvQuaTrinhLuong.Name = "i_nvQuaTrinhLuong";
            this.i_nvQuaTrinhLuong.Size = new System.Drawing.Size(153, 22);
            this.i_nvQuaTrinhLuong.Text = "Phòng Trống";
            this.i_nvQuaTrinhLuong.Click += new System.EventHandler(this.i_nvQuaTrinhLuong_Click);
            // 
            // i_thongke
            // 
            this.i_thongke.Name = "i_thongke";
            this.i_thongke.Size = new System.Drawing.Size(153, 22);
            this.i_thongke.Text = "Thống Kê";
            this.i_thongke.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_bcThongTin,
            this.i_bcPhong,
            this.i_bcKhu});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // i_bcThongTin
            // 
            this.i_bcThongTin.Name = "i_bcThongTin";
            this.i_bcThongTin.Size = new System.Drawing.Size(152, 22);
            this.i_bcThongTin.Text = "Thông Tin";
            this.i_bcThongTin.Click += new System.EventHandler(this.i_bcThongTin_Click);
            // 
            // i_bcPhong
            // 
            this.i_bcPhong.Name = "i_bcPhong";
            this.i_bcPhong.Size = new System.Drawing.Size(152, 22);
            this.i_bcPhong.Text = " Phòng";
            this.i_bcPhong.Click += new System.EventHandler(this.i_bcPhong_Click);
            // 
            // i_bcKhu
            // 
            this.i_bcKhu.Name = "i_bcKhu";
            this.i_bcKhu.Size = new System.Drawing.Size(152, 22);
            this.i_bcKhu.Text = " Khu";
            this.i_bcKhu.Click += new System.EventHandler(this.i_bcKhu_Click);
            // 
            // chươngTrìnhToolStripMenuItem
            // 
            this.chươngTrìnhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem,
            this.aboutMeToolStripMenuItem});
            this.chươngTrìnhToolStripMenuItem.Name = "chươngTrìnhToolStripMenuItem";
            this.chươngTrìnhToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.chươngTrìnhToolStripMenuItem.Text = "Chương trình";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            this.hướngDẫnSửDụngToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnSửDụngToolStripMenuItem_Click);
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutMeToolStripMenuItem.Text = "About me";
            this.aboutMeToolStripMenuItem.Click += new System.EventHandler(this.aboutMeToolStripMenuItem_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.hình;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 471);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "F_Main";
            this.Text = "F_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status1;
        private System.Windows.Forms.ToolStripStatusLabel status2;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_htDangNhap;
        private System.Windows.Forms.ToolStripMenuItem i_htDangXuat;
        private System.Windows.Forms.ToolStripMenuItem i_htDoiMK;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_qlKhu;
        private System.Windows.Forms.ToolStripMenuItem i_qlPhong;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_ChuyenPhong;
        private System.Windows.Forms.ToolStripMenuItem i_nvQuaTrinhLuong;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_bcThongTin;
        private System.Windows.Forms.ToolStripMenuItem i_bcPhong;
        private System.Windows.Forms.ToolStripMenuItem i_qlCaNhan;
        private System.Windows.Forms.ToolStripMenuItem i_bcKhu;
        private System.Windows.Forms.ToolStripMenuItem i_htDuLieu;
        private System.Windows.Forms.ToolStripMenuItem saoLưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khôiPhụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chươngTrìnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_qlHoaDon;
        private System.Windows.Forms.ToolStripMenuItem i_thongke;
    }
}