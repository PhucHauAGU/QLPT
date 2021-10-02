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
    public partial class F_QuanLyPhong : Form
    {
        public F_QuanLyPhong()
        {
            InitializeComponent();
        }
       

        private void F_QuanLyPhong_Load(object sender, EventArgs e)
        {
            
            HienThiKhuLenCombobox();
            HienThiPhong();
            if (F_Main.Quyen == 2)
            {
                
                btnThemPhong.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void HienThiKhuLenCombobox()
        {
            List<Khu_DTO> lstKhu = Khu_BUS.LayKhu();
            cmbKhu.DataSource = lstKhu;
            cmbKhu.DisplayMember = "STenKhu";
            cmbKhu.ValueMember = "SMaKhu";
        }

        private void HienThiPhong()
        {

            string makhu = cmbKhu.SelectedValue.ToString();

            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhongTheoKhu(makhu);
            dtgvPhong.DataSource = lstPhong;
            txtMaKhu.Text = cmbKhu.SelectedValue.ToString();
            if(dtgvPhong.Rows.Count > 0)
            {
                dtgvPhong.Columns["SMaPhong"].HeaderText = "Mã Phòng";
                dtgvPhong.Columns["SMaKhu"].HeaderText = "Mã Khu";
                dtgvPhong.Columns["ISoLuong"].HeaderText = "Số Lượng";
                dtgvPhong.Columns["ISoLuongToiDa"].HeaderText = "Số lượng tối đa";
          
                dtgvPhong.Columns["SMaPhong"].Width = 160;
                dtgvPhong.Columns["SMaKhu"].Width = 160;
                dtgvPhong.Columns["ISoLuong"].Width = 100;
                dtgvPhong.Columns["ISoLuongToiDa"].Width = 100;
            }
           

        }
        public void loadThongTin(string maphong)
        {

            dgvThongTin.DataSource = ThongTin_BUS.LayThongTinTheoPhong(maphong);

        }

       

        private void dtgvPhong_Click(object sender, EventArgs e)
        {
            string maphong = dtgvPhong.SelectedRows[0].Cells["SMaPhong"].Value.ToString();
            txtMaPhong.Text = dtgvPhong.SelectedRows[0].Cells["SMaPhong"].Value.ToString();
            txtMaKhu.Text = dtgvPhong.SelectedRows[0].Cells["SMaKhu"].Value.ToString();
            txtSoLuong.Text = dtgvPhong.SelectedRows[0].Cells["ISoLuong"].Value.ToString();
            txtSoLuongMax.Text = dtgvPhong.SelectedRows[0].Cells["ISoLuongToiDa"].Value.ToString();
            loadThongTin(maphong);

         
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaPhong.Text == "" || txtSoLuongMax.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
            // Kiểm tra mã nhân viên có bị trùng không
            if (Phong_BUS.TimPhongTheoMa(txtMaPhong.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            Phong_DTO p = new Phong_DTO();
            p.SMaPhong = txtMaPhong.Text;
            p.SMaKhu = txtMaKhu.Text;
            p.ISoLuong = 0;
            p.ISoLuongToiDa = Int32.Parse(txtSoLuongMax.Text);
          

            if (Phong_BUS.ThemPhong(p) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiPhong();
            MessageBox.Show("Đã thêm Phòng.");         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "" || Phong_BUS.TimPhongTheoMa(txtMaPhong.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            Phong_DTO p = new Phong_DTO();
            p.SMaPhong = txtMaPhong.Text;
            p.SMaKhu = txtMaKhu.Text;
            p.ISoLuong = Int32.Parse(txtSoLuong.Text);
            p.ISoLuongToiDa = Int32.Parse(txtSoLuongMax.Text);

            if (Phong_BUS.XoaPhong(p) == true)
            {
                HienThiPhong();
                MessageBox.Show("Đã xóa nhân viên.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void cmbKhu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string makhu = cmbKhu.SelectedValue.ToString();

            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhongTheoKhu(makhu);
            dtgvPhong.DataSource = lstPhong;
            txtMaKhu.Text = cmbKhu.SelectedValue.ToString();

            //Khu_DTO k = new Khu_DTO();
            //k = Khu_BUS.TimKhuTheoMa(makhu).;
            //int soluong = Int32.Parse(k.ISoPhong.ToString());
            //if (Int32.Parse(dtgvPhong.Rows.Count.ToString()) == soluong)
            //{
            //    btnThemPhong.Enabled = false;
            //}
            //else
            //{
            //    btnThemPhong.Enabled = true;
            //}
           
            
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            txtMaKhu.Clear();
            txtMaPhong.Clear();
            txtSoLuong.Clear();
            txtSoLuongMax.Clear();
        }

        private void txtSoLuongMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        
        
    }
}
