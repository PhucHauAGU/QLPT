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
    public partial class F_QuanLyKhu : Form
    {
        public F_QuanLyKhu()
        {
            InitializeComponent();
        }

        private void F_QuanLyKhu_Load(object sender, EventArgs e)
        {
            HienThiKhu();
            if (F_Main.Quyen == 2)
            {
                
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        private void HienThiKhu()
            {
                List<Khu_DTO> lstKhu = Khu_BUS.LayKhu();
                dtgvKhu.DataSource = lstKhu;
                if(dtgvKhu.Rows.Count > 0)
                {
                    dtgvKhu.Columns["SMaKhu"].HeaderText = "Mã Khu";
                    dtgvKhu.Columns["STenKhu"].HeaderText = "Tên Khu";
                    dtgvKhu.Columns["ISoPhong"].HeaderText = "Số Phòng";
                }
            }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống 
            if (txtMaKhu.Text == "" || txtTenKhu.Text == "" || txtSoLuongPhong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            
           
            // Kiểm tra mã nhân viên có bị trùng không
            if (Khu_BUS.TimKhuTheoMa(txtMaKhu.Text) != null)
            {
                MessageBox.Show("Mã khu đã tồn tại!");
                return;
            }

            Khu_DTO k = new Khu_DTO();
            k.SMaKhu = txtMaKhu.Text;
            k.STenKhu = txtTenKhu.Text;
            k.ISoPhong = Int32.Parse(txtSoLuongPhong.Text);

            if (Khu_BUS.ThemKhu(k) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiKhu();
            MessageBox.Show("Đã thêm khu.");  
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhu.Text == "" || Khu_BUS.TimKhuTheoMa(txtMaKhu.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            Khu_DTO k = new Khu_DTO();
            k.SMaKhu = txtMaKhu.Text;
            k.STenKhu = txtTenKhu.Text;
            k.ISoPhong = Int32.Parse(txtSoLuongPhong.Text);
          

            if (Khu_BUS.XoaKhu(k) == true)
            {
                HienThiKhu();
                MessageBox.Show("Đã xóa Khu.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void dtgvKhu_Click(object sender, EventArgs e)
        {
            txtMaKhu.Text = dtgvKhu.SelectedRows[0].Cells["SMaKhu"].Value.ToString();
            txtTenKhu.Text = dtgvKhu.SelectedRows[0].Cells["STenKhu"].Value.ToString();
            txtSoLuongPhong.Text = dtgvKhu.SelectedRows[0].Cells["ISoPhong"].Value.ToString();
        }

        private void btnXoaChu_Click(object sender, EventArgs e)
        {
            txtMaKhu.Clear();
            txtSoLuongPhong.Clear();
            txtTenKhu.Clear();
        }

        private void txtSoLuongPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
