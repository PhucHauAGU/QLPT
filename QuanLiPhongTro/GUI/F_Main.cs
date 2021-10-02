using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }
        public static TaiKhoan_DTO TaiKhoan;
        bool bDangNhap;
        public static int Quyen;
        F_QuanLyKhu fKhu;
        F_QuanLyPhong fPhong;
        F_DangKyThongTin fTT;
        F_ChuyenPhong fCP;
        F_DangNhap fDN;
        F_RThongTin FRTT;
        F_RKhu FRK;
        F_ChuyenPhong FCP;
        F_RPhong FRP;
        DoiMatKhau DMK;
        F_PhongTrong FPT;
        F_HoaDon FHD;
        F_ThongKe FTK;

        private void HienThiMenu()
        {
            i_htDangNhap.Enabled = !bDangNhap;
            i_htDangXuat.Enabled = bDangNhap;
            i_htDoiMK.Enabled = bDangNhap;
            i_qlKhu.Enabled = bDangNhap;
            i_qlPhong.Enabled = bDangNhap;
            i_ChuyenPhong.Enabled = bDangNhap;
            i_nvQuaTrinhLuong.Enabled = bDangNhap;
            i_qlCaNhan.Enabled = bDangNhap;
            i_qlHoaDon.Enabled = bDangNhap;
            i_thongke.Enabled = bDangNhap;
            i_htDuLieu.Enabled = bDangNhap;
        }


        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            HienThiMenu();
            status1.Text = "Chưa Đăng Nhập";
            status2.Text = "";
        }

        private void i_htDangNhap_Click(object sender, EventArgs e)
        {

            fDN = new F_DangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string sTen = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;
                TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.LayTaiKhoan(sTen, sMatKhau);
                if (TaiKhoan != null)
                {
                    bDangNhap = true;
                    status1.Text = "Tên Tài Khoản: " + TaiKhoan.STen;
                    status2.Text = "Thời Gian Đăng Nhập: " + DateTime.Now;
                    if(TaiKhoan.IQuyen == 2 )
                    {
                        
                        Quyen = 2;
                        
                    }
                    else
                    {
                        Quyen = 1;
                    }
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                bDangNhap = false;
            }
           

            HienThiMenu();
            if (Quyen == 2)
            {
                i_htDuLieu.Enabled = false;
                i_thongke.Enabled = false;
                i_qlHoaDon.Enabled = false;
            }
        }

        private void i_qlKhu_Click(object sender, EventArgs e)
        {
            if (fKhu == null || fKhu.IsDisposed)
            {
                fKhu = new F_QuanLyKhu();
                fKhu.MdiParent = this;
                fKhu.Show();
            }
        }

        private void i_qlPhong_Click(object sender, EventArgs e)
        {
            if (fPhong == null || fPhong.IsDisposed)
            {
                fPhong = new F_QuanLyPhong();
                fPhong.MdiParent = this;
                fPhong.Show();
            }
        }

        private void i_qlCaNhan_Click(object sender, EventArgs e)
        {
            if (fTT == null || fTT.IsDisposed)
            {
                fTT = new F_DangKyThongTin();
                fTT.MdiParent = this;
                fTT.Show();
            }
        }

        private void menuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void i_htDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất và thiết lập lại menu
            bDangNhap = false;
            HienThiMenu();
            status1.Text = "Chưa đăng nhập";
            status2.Text = "";
        }

        private void i_bcThongTin_Click(object sender, EventArgs e)
        {
            if (FRTT == null || FRTT.IsDisposed)
            {
                FRTT = new F_RThongTin();
                FRTT.MdiParent = this;
                FRTT.Show();
            }
        }

        private void i_bcKhu_Click(object sender, EventArgs e)
        {
            if (FRK == null || FRK.IsDisposed)
            {
                FRK = new F_RKhu();
                FRK.MdiParent = this;
                FRK.Show();
            }
        }

        private void i_ChuyenPhong_Click(object sender, EventArgs e)
        {
            if (FCP == null || FCP.IsDisposed)
            {
                FCP = new F_ChuyenPhong();
                FCP.MdiParent = this;
                FCP.Show();
            }
        }

        private void i_bcPhong_Click(object sender, EventArgs e)
        {
            if (FRP == null || FRP.IsDisposed)
            {
                FRP = new F_RPhong();
                FRP.MdiParent = this;
                FRP.Show();
            }
        }

        private void i_htDoiMK_Click(object sender, EventArgs e)
        {
            if (DMK == null || DMK.IsDisposed)
            {
                DMK = new DoiMatKhau();
                DMK.MdiParent = this;
                DMK.Show();
            }
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                  if (CSDL_BUS.SaoLuu() == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào F:/SaoLuu");
                else
                   MessageBox.Show("Thao tác không thành công");
        }

        private void khôiPhụcToolStripMenuItem_Click(object sender, EventArgs e)
        {



            if (CSDL_BUS.PhucHoiDuLieu() == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            
        }

        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ABOUT.chm");
        }

        private void i_nvQuaTrinhLuong_Click(object sender, EventArgs e)
        {
            if (FPT == null || FPT.IsDisposed)
            {
                FPT = new F_PhongTrong();
                FPT.MdiParent = this;
                FPT.Show();
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "HDSD.chm");
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FHD == null || FHD.IsDisposed)
            {
                FHD = new F_HoaDon();
                FHD.MdiParent = this;
                FHD.Show();
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FTK == null || FTK.IsDisposed)
            {
                FTK = new F_ThongKe();
                FTK.MdiParent = this;
                FTK.Show();
            }
        }

     

      
    }
}
