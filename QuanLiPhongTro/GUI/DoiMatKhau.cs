using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTen.Text = F_Main.TaiKhoan.STen;
            txtTen.Enabled = false;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            if (TaiKhoan_BUS.LayTaiKhoan(txtTen.Text, txtMatKhau.Text) == null)
            {
                MessageBox.Show("Tên hoặc mật khẩu không đúng.");
                return;
            }
            TaiKhoan_DTO tk = new TaiKhoan_DTO();
            tk.STen = txtTen.Text;
            tk.SMatKhau = txtMatKhau.Text;
            // ghi nhận mật khẩu mới
            if (TaiKhoan_BUS.DoiMatKhau(tk, txtMatKhauMoi.Text) == false)
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            MessageBox.Show("Đã thay đổi mật khẩu.");
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }
    }
}
