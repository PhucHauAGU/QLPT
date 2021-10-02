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
    public partial class F_HoaDon : Form
    {
        public F_HoaDon()
        {
            InitializeComponent();
           
        }
       
        
        private void HienThiPhong()
        {
            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhong();
            cmbMaPhong.DataSource = lstPhong;
            cmbMaPhong.ValueMember = "SMaPhong";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaHD.Text == "" ||cmbMaPhong.Text == "" || txtTienDien.Text == "" || txtTienNuoc.Text == "" || txtTienPhong.Text == "" || txtTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }

            // Kiểm tra mã nhân viên có bị trùng không
            if (HoaDon_BUS.TimTheoMa(txtMaHD.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            HoaDon_DTO tt = new HoaDon_DTO();
            tt.SMaHoaDon = txtMaHD.Text;
            tt.SMaPhong = cmbMaPhong.SelectedValue.ToString();
            tt.ITienDien = Int32.Parse(txtTienDien.Text);
            tt.ITienNuoc = Int32.Parse(txtTienNuoc.Text);
            tt.ITienPhong = Int32.Parse(txtTienPhong.Text);
            tt.IThanhTien = Int32.Parse(txtThanhTien.Text);
            tt.STrangThai = txtTrangThai.Text;
            

            if (HoaDon_BUS.ThemHoaDon(tt) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThi();
            MessageBox.Show("Đã thêm thành công.");  
        }

        private void F_HoaDon_Load(object sender, EventArgs e)
        {
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtTienPhong.Text = "0";
            HienThiPhong();
            HienThi();
            
        }
        private void HienThi()
        {

            List<HoaDon_DTO> lstThongTin = HoaDon_BUS.LayHoaDon();
            dgvHoaDon.DataSource = lstThongTin;
            if (dgvHoaDon.Rows.Count > 0)
            {
                dgvHoaDon.Columns["SMaHoaDon"].HeaderText = "Mã Hóa Đơn";
                dgvHoaDon.Columns["SMaPhong"].HeaderText = "Mã Phòng";
                dgvHoaDon.Columns["ITienDien"].HeaderText = "Tiền Điện";
                dgvHoaDon.Columns["ITienNuoc"].HeaderText = "Tiền Nước";
                dgvHoaDon.Columns["ITienPhong"].HeaderText = "Tiền Phòng";
                dgvHoaDon.Columns["IThanhTien"].HeaderText = "Thành Tiền";
                dgvHoaDon.Columns["STrangThai"].HeaderText = "Trạng Thái";
                

                dgvHoaDon.Columns["SMaHoaDon"].Width = 60;
                dgvHoaDon.Columns["SMaPhong"].Width = 60;
                dgvHoaDon.Columns["ITienDien"].Width = 75;
                dgvHoaDon.Columns["ITienNuoc"].Width = 75;
                dgvHoaDon.Columns["ITienPhong"].Width = 75;
                dgvHoaDon.Columns["IThanhTien"].Width = 75;
                dgvHoaDon.Columns["STrangThai"].Width = 110;
              
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || HoaDon_BUS.TimTheoMa(txtMaHD.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            HoaDon_DTO k = new HoaDon_DTO();
            k.SMaHoaDon = txtMaHD.Text;
            k.SMaPhong = cmbMaPhong.SelectedValue.ToString();
            k.ITienDien = Int32.Parse(txtTienDien.Text);
            k.ITienNuoc = Int32.Parse(txtTienNuoc.Text);
            k.ITienPhong = Int32.Parse(txtTienPhong.Text);
            k.IThanhTien = Int32.Parse(txtThanhTien.Text);
            k.STrangThai = txtTrangThai.Text;


            if (HoaDon_BUS.XoaHoaDon(k) == true)
            {
                HienThi();
                MessageBox.Show("Đã xóa Hóa Đơn.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "" || HoaDon_BUS.TimTheoMa(txtMaHD.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }

            HoaDon_DTO k = new HoaDon_DTO();
            k.SMaHoaDon = txtMaHD.Text;
            k.SMaPhong = cmbMaPhong.SelectedValue.ToString();
            k.ITienDien = Int32.Parse(txtTienDien.Text);
            k.ITienNuoc = Int32.Parse(txtTienNuoc.Text);
            k.ITienPhong = Int32.Parse(txtTienPhong.Text);
            k.IThanhTien = Int32.Parse(txtThanhTien.Text);
            k.STrangThai = txtTrangThai.Text;

            if (HoaDon_BUS.SuaHoaDon(k) == false)
            {
                MessageBox.Show("Không sửa được.");
                return;
            }

            HienThi();
            MessageBox.Show("Đã sửa thành công.");  
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = dgvHoaDon.SelectedRows[0].Cells["SMaHoaDon"].Value.ToString();
            cmbMaPhong.SelectedValue = dgvHoaDon.SelectedRows[0].Cells["SMaPhong"].Value;
            txtTienDien.Text = dgvHoaDon.SelectedRows[0].Cells["ITienDien"].Value.ToString();
            txtTienNuoc.Text = dgvHoaDon.SelectedRows[0].Cells["ITienNuoc"].Value.ToString();
            txtTienPhong.Text = dgvHoaDon.SelectedRows[0].Cells["ITienPhong"].Value.ToString();
            txtThanhTien.Text = dgvHoaDon.SelectedRows[0].Cells["IThanhTien"].Value.ToString();
            txtTrangThai.Text = dgvHoaDon.SelectedRows[0].Cells["STrangThai"].Value.ToString();

        }

        private void txtTienDien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienDien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienNuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienNuoc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTienPhong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tiendien = Convert.ToInt32(txtTienDien.Text);
            int tiennuoc = Convert.ToInt32(txtTienNuoc.Text);
            int tienphong = Convert.ToInt32(txtTienPhong.Text);

            int thanhtien = tiendien + tiennuoc + tienphong;
            txtThanhTien.Text = thanhtien.ToString();
        }

      
    }
}
