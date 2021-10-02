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
using DTO;
using BUS;

namespace GUI
{
    public partial class F_ChuyenPhong : Form
    {
        public F_ChuyenPhong()
        {
            InitializeComponent();
        }
        

        private void F_ChuyenPhong_Load(object sender, EventArgs e)
        {
            HienThiKhuLenCombobox();
            if(F_Main.Quyen == 2)
            {
                btn1Chuyen2.Enabled = false;
                btn2Chuyen1.Enabled = false;
            }
           
        }
        private void HienThiKhuLenCombobox()
        {
            List<Khu_DTO> lstKhu1 = Khu_BUS.LayKhu();
            cmbKhu1.DataSource = lstKhu1;
            cmbKhu1.DisplayMember = "STenKhu";
            cmbKhu1.ValueMember = "SMaKhu";

            List<Khu_DTO> lstKhu2 = Khu_BUS.LayKhu();
            cmbKhu2.DataSource = lstKhu2;
            cmbKhu2.DisplayMember = "STenKhu";
            cmbKhu2.ValueMember = "SMaKhu";
        }
       

        private void cmbKhu1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhu1 = cmbKhu1.SelectedValue.ToString();
            List<Phong_DTO> lstPhong1 = Phong_BUS.LayDSPhongTheoKhu(makhu1);
            cmbPhong1.DataSource = lstPhong1;
            cmbPhong1.DisplayMember = "SMaPhong";
        }

        private void cmbKhu2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhu2 = cmbKhu2.SelectedValue.ToString();
            List<Phong_DTO> lstPhong2 = Phong_BUS.LayDSPhongTheoKhu(makhu2);
            cmbPhong2.DataSource = lstPhong2;
            cmbPhong2.DisplayMember = "SMaPhong";
        }

        private void HienThi1()
        {
            string maphong1 = cmbPhong1.Text;
            List<ThongTin_DTO> lstThongTin = ThongTin_BUS.LayThongTinTheoPhong(maphong1);
            dtgvThongTin1.DataSource = lstThongTin;
            if (dtgvThongTin1.DataSource != null)
            {
                dtgvThongTin1.Columns["SMaSo"].HeaderText = "Mã số";
                dtgvThongTin1.Columns["SHoTen"].HeaderText = "Họ Tên";
                dtgvThongTin1.Columns["INamSinh"].HeaderText = "Năm Sinh";
                dtgvThongTin1.Columns["SGioiTinh"].HeaderText = "Giới Tính";
                dtgvThongTin1.Columns["SCMND"].HeaderText = "CMND";
                dtgvThongTin1.Columns["SNguyenQuan"].HeaderText = "Nguyên Quán";
                dtgvThongTin1.Columns["SDienThoai"].HeaderText = "Điện Thoại";
                dtgvThongTin1.Columns["SMaKhu"].HeaderText = "Mã Khu";
                dtgvThongTin1.Columns["SMaPhong"].HeaderText = "Mã Phòng";

                dtgvThongTin1.Columns["SMaSo"].Width = 75;
                dtgvThongTin1.Columns["SHoTen"].Width = 215;
                dtgvThongTin1.Columns["INamSinh"].Width = 75;
                dtgvThongTin1.Columns["SGioiTinh"].Width = 75;
                dtgvThongTin1.Columns["SCMND"].Width = 75;
                dtgvThongTin1.Columns["SNguyenQuan"].Width = 75;
                dtgvThongTin1.Columns["SDienThoai"].Width = 100;
                dtgvThongTin1.Columns["SMaKhu"].Width = 75;
                dtgvThongTin1.Columns["SMaPhong"].Width = 75;
            }
        }
        private void HienThi2()
        {
            string maphong2 = cmbPhong2.Text;
            List<ThongTin_DTO> lstThongTin = ThongTin_BUS.LayThongTinTheoPhong(maphong2);
            dtgvThongTin2.DataSource = lstThongTin;

            if(dtgvThongTin2.DataSource != null)
            {
                dtgvThongTin2.Columns["SMaSo"].HeaderText = "Mã số";
                dtgvThongTin2.Columns["SHoTen"].HeaderText = "Họ Tên";
                dtgvThongTin2.Columns["INamSinh"].HeaderText = "Năm Sinh";
                dtgvThongTin2.Columns["SGioiTinh"].HeaderText = "Giới Tính";
                dtgvThongTin2.Columns["SCMND"].HeaderText = "CMND";
                dtgvThongTin2.Columns["SNguyenQuan"].HeaderText = "Nguyên Quán";
                dtgvThongTin2.Columns["SDienThoai"].HeaderText = "Điện Thoại";
                dtgvThongTin2.Columns["SMaKhu"].HeaderText = "Mã Khu";
                dtgvThongTin2.Columns["SMaPhong"].HeaderText = "Mã Phòng";

                dtgvThongTin2.Columns["SMaSo"].Width = 75;
                dtgvThongTin2.Columns["SHoTen"].Width = 215;
                dtgvThongTin2.Columns["INamSinh"].Width = 75;
                dtgvThongTin2.Columns["SGioiTinh"].Width = 75;
                dtgvThongTin2.Columns["SCMND"].Width = 75;
                dtgvThongTin2.Columns["SNguyenQuan"].Width = 75;
                dtgvThongTin2.Columns["SDienThoai"].Width = 100;
                dtgvThongTin2.Columns["SMaKhu"].Width = 75;
                dtgvThongTin2.Columns["SMaPhong"].Width = 75;
            }
        }

        private void cmbPhong1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi1();
        }

        private void cmbPhong2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThi2();
        }

        private void btn1Chuyen2_Click(object sender, EventArgs e)
        {
            if (dtgvThongTin1.SelectedRows.Count > 0)
            {
                string maSo = dtgvThongTin1.SelectedRows[0].Cells["SMaSo"].Value.ToString();
                string maPhongCanChuyen = cmbPhong2.Text;
                string maPhongCu = cmbPhong1.Text;
                string maKhuCanChuyen = cmbKhu2.SelectedValue.ToString();

                

                if (ThongTin_BUS.ChuyenPhong(maSo, maPhongCanChuyen,maKhuCanChuyen) == false || ThongTin_BUS.CongSoLuong(maPhongCanChuyen)==false || ThongTin_BUS.TruSoLuong(maPhongCu)==false)
                {
                    MessageBox.Show("Chuyển phòng thất bại!");
                    return;
                }
                LoadThongTin();
                MessageBox.Show("Chuyển phòng thành công!");
                
            }
            
        }
        private void LoadThongTin()
        {
            HienThi1();
            HienThi2();
        }

        private void btn2Chuyen1_Click(object sender, EventArgs e)
        {
            if (dtgvThongTin2.SelectedRows.Count > 0)
            {
                string maSo = dtgvThongTin2.SelectedRows[0].Cells["SMaSo"].Value.ToString();
                string maPhongCanChuyen = cmbPhong1.Text;
                string maPhongCu = cmbPhong2.Text;
                string maKhuCanChuyen = cmbKhu1.SelectedValue.ToString();



                if (ThongTin_BUS.ChuyenPhong(maSo, maPhongCanChuyen, maKhuCanChuyen) == false || ThongTin_BUS.CongSoLuong(maPhongCanChuyen) == false || ThongTin_BUS.TruSoLuong(maPhongCu) == false)
                {
                    MessageBox.Show("Chuyển phòng thất bại!");
                    return;
                }
                LoadThongTin();
                MessageBox.Show("Chuyển phòng thành công!");
        }
    }

    }
}
