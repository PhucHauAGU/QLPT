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
    public partial class F_DangKyThongTin : Form
    {
        public F_DangKyThongTin()
        {
            InitializeComponent();
            
        }
      

        private void F_DangKyThongTin_Load(object sender, EventArgs e)
        {
            HienThiKhuLenCombobox();
            HienThiPhongLenComboBox(); 
            HienThi();
            if(F_Main.Quyen == 2)
            {
                btnSua.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
          
        }
       private void HienThi() {

            List<ThongTin_DTO> lstThongTin = ThongTin_BUS.LayThongTin();
            dgvThongTin.DataSource = lstThongTin;
            if(dgvThongTin.Rows.Count > 0)
            {
                dgvThongTin.Columns["SMaSo"].HeaderText = "Mã số";
                dgvThongTin.Columns["SHoTen"].HeaderText = "Họ Tên";
                dgvThongTin.Columns["INamSinh"].HeaderText = "Năm Sinh";
                dgvThongTin.Columns["SGioiTinh"].HeaderText = "Giới Tính";
                dgvThongTin.Columns["SCMND"].HeaderText = "CMND";
                dgvThongTin.Columns["SNguyenQuan"].HeaderText = "Nguyên Quán";
                dgvThongTin.Columns["SDienThoai"].HeaderText = "Điện Thoại";
                dgvThongTin.Columns["SMaKhu"].HeaderText = "Mã Khu";
                dgvThongTin.Columns["SMaPhong"].HeaderText = "Mã Phòng";

                dgvThongTin.Columns["SMaSo"].Width = 75;
                dgvThongTin.Columns["SHoTen"].Width = 215;
                dgvThongTin.Columns["INamSinh"].Width = 75;
                dgvThongTin.Columns["SGioiTinh"].Width = 75;
                dgvThongTin.Columns["SCMND"].Width = 75;
                dgvThongTin.Columns["SNguyenQuan"].Width = 75;
                dgvThongTin.Columns["SDienThoai"].Width = 100;
                dgvThongTin.Columns["SMaKhu"].Width = 75;
                dgvThongTin.Columns["SMaPhong"].Width = 75;
            }
       }
       private void HienThiKhuLenCombobox()
       {
           List<Khu_DTO> lstKhu = Khu_BUS.LayKhu();
           cmbKhu.DataSource = lstKhu;
           cmbKhu.DisplayMember = "STenKhu";
           cmbKhu.ValueMember = "SMaKhu";
       }
        private void HienThiPhongLenComboBox()
        {
            string makhu = cmbKhu.SelectedValue.ToString();
            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhongTheoKhu(makhu);
            cmbPhong.DataSource = lstPhong;
            cmbPhong.ValueMember = "SMaPhong";
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiPhongLenComboBox();
           
        }

        private void dgvThongTin_Click(object sender, EventArgs e)
        {

            txtMaSo.Text = dgvThongTin.SelectedRows[0].Cells["SMaSo"].Value.ToString();
            txtHoTen.Text = dgvThongTin.SelectedRows[0].Cells["SHoTen"].Value.ToString();
            txtNamSinh.Text = dgvThongTin.SelectedRows[0].Cells["INamSinh"].Value.ToString();
            if(dgvThongTin.SelectedRows[0].Cells["SGioiTinh"].Value.ToString() == "NAM")
            {
                rdbNam.Checked = true;
            }
            else {
                rdbNu.Checked = true;
            }
            txtCMND.Text = dgvThongTin.SelectedRows[0].Cells["SCMND"].Value.ToString();
            txtNguyenQuan.Text = dgvThongTin.SelectedRows[0].Cells["SNguyenQuan"].Value.ToString();
            txtSdt.Text = dgvThongTin.SelectedRows[0].Cells["SDienThoai"].Value.ToString();
            cmbKhu.SelectedValue = dgvThongTin.SelectedRows[0].Cells["SMaKhu"].Value;
            cmbPhong.SelectedValue = dgvThongTin.SelectedRows[0].Cells["SMaPhong"].Value;
         
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaSo.Clear();
            txtHoTen.Clear();
            txtNamSinh.Clear();
            txtNguyenQuan.Clear();
            txtCMND.Clear();
            rdbNam.Checked = true;
            txtSdt.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaSo.Text == "" || txtHoTen.Text == "" || txtNamSinh.Text == "" || txtNguyenQuan.Text == "" || txtCMND.Text == "" || txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã số có bị trùng không
            if (ThongTin_BUS.TimTheoMa(txtMaSo.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            ThongTin_DTO tt = new ThongTin_DTO();
            tt.SMaSo = txtMaSo.Text;
            tt.SHoTen = txtHoTen.Text;
            tt.INamSinh = Int32.Parse(txtNamSinh.Text);
            if (rdbNam.Checked == true)
            {
                tt.SGioiTinh = "NAM";
            }
            else
            {
                tt.SGioiTinh = "NỮ";
            }
            tt.SCMND = txtCMND.Text;
            tt.SNguyenQuan = txtNguyenQuan.Text;
            tt.SDienThoai = txtSdt.Text;
            tt.SMaKhu = cmbKhu.SelectedValue.ToString();
            tt.SMaPhong = cmbPhong.SelectedValue.ToString();

            if (ThongTin_BUS.ThemThongTin(tt) == false|| ThongTin_BUS.CongSoLuong(tt.SMaPhong) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThi();
            MessageBox.Show("Đã thêm thành công.");
            //Khóa nút thêm nếu số lượng đạt tối đa
            string maphong = cmbPhong.SelectedValue.ToString();
            Phong_DTO p = new Phong_DTO();
            p = Phong_BUS.TimPhongTheoMa(maphong);
            if (p.ISoLuong == p.ISoLuongToiDa)
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text == "" || ThongTin_BUS.TimTheoMa(txtMaSo.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }

            ThongTin_DTO tt = new ThongTin_DTO();
            tt.SMaSo = txtMaSo.Text;
            tt.SHoTen = txtHoTen.Text;
            tt.INamSinh = Int32.Parse(txtNamSinh.Text);
            if (rdbNam.Checked == true)
            {
                tt.SGioiTinh = "NAM";
            }
            else
            {
                tt.SGioiTinh = "NỮ";
            }
            tt.SCMND = txtCMND.Text;
            tt.SNguyenQuan = txtNguyenQuan.Text;
            tt.SDienThoai = txtSdt.Text;
            tt.SMaKhu = cmbKhu.SelectedValue.ToString();
            tt.SMaPhong = cmbPhong.SelectedValue.ToString();

            if (ThongTin_BUS.XoaThongTin(tt) == false || ThongTin_BUS.TruSoLuong(tt.SMaPhong) == false)
            {
                MessageBox.Show("Không xóa được.");
                return;
            }

            HienThi();
            MessageBox.Show("Đã xóa thành công.");  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text == "" || ThongTin_BUS.TimTheoMa(txtMaSo.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }

            ThongTin_DTO tt = new ThongTin_DTO();
            tt.SMaSo = txtMaSo.Text;
            tt.SHoTen = txtHoTen.Text;
            tt.INamSinh = Int32.Parse(txtNamSinh.Text);
            if (rdbNam.Checked == true)
            {
                tt.SGioiTinh = "NAM";
            }
            else
            {
                tt.SGioiTinh = "NỮ";
            }
            tt.SCMND = txtCMND.Text;
            tt.SNguyenQuan = txtNguyenQuan.Text;
            tt.SDienThoai = txtSdt.Text;
            tt.SMaKhu = cmbKhu.SelectedValue.ToString();
            tt.SMaPhong = cmbPhong.SelectedValue.ToString();

            if (ThongTin_BUS.SuaThongTin(tt) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }

            HienThi();
            MessageBox.Show("Đã sửa thành công.");  
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maso = txtMaSoTim.Text;
            List<ThongTin_DTO> lstThongTin = ThongTin_BUS.TimTheoHoTen(maso);
            if (lstThongTin == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgvThongTin.DataSource = lstThongTin;
        }

        private void cmbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maphong = cmbPhong.SelectedValue.ToString();
            Phong_DTO p = new Phong_DTO();
            p = Phong_BUS.TimPhongTheoMa(maphong);
            if (p.ISoLuong == p.ISoLuongToiDa)
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
    }
}
