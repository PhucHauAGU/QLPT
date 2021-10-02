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
    public partial class F_PhongTrong : Form
    {
        public F_PhongTrong()
        {
            InitializeComponent();
        }
        F_DangKyThongTin fTT;
         

        private void F_PhongTrong_Load(object sender, EventArgs e)
        {
            HienThi();
            txtSoPhongTrong.Text = dgvPhongTrong.Rows.Count.ToString();

           
        }
        private void HienThi()
        {
            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhongTrong();
            dgvPhongTrong.DataSource = lstPhong;
            if(dgvPhongTrong.Rows.Count > 0)
                {
                    dgvPhongTrong.Columns["SMaPhong"].HeaderText = "Mã Phòng";
                    dgvPhongTrong.Columns["SMaKhu"].HeaderText = "Mã Khu";
                    dgvPhongTrong.Columns["ISoLuong"].HeaderText = "Số Lượng";
                    dgvPhongTrong.Columns["ISoLuongToiDa"].HeaderText = "Số lượng tối đa";

                    dgvPhongTrong.Columns["SMaPhong"].Width = 160;
                    dgvPhongTrong.Columns["SMaKhu"].Width = 160;
                    dgvPhongTrong.Columns["ISoLuong"].Width = 100;
                    dgvPhongTrong.Columns["ISoLuongToiDa"].Width = 110;
                }
        }

        private void dgvPhongTrong_Click(object sender, EventArgs e)
        {
       
        }

    }
}
