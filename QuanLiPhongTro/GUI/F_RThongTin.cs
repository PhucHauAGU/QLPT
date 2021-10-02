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
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;

namespace GUI
{
    public partial class F_RThongTin : Form
    {
        public F_RThongTin()
        {
            InitializeComponent();
        }

        private void F_RThongTin_Load(object sender, EventArgs e)
        {
            HienThiPhong();
            ThongTin_DTOBindingSource.DataSource = ThongTin_BUS.LayThongTin();
            this.reportViewer1.RefreshReport();
        }
        private void HienThiPhong()
        {
            List<Phong_DTO> lstPhong = Phong_BUS.LayDSPhong();
            cmbPhong.DataSource = lstPhong;
            cmbPhong.ValueMember = "SMaPhong";
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maphong = cmbPhong.SelectedValue.ToString();
            ThongTin_DTOBindingSource.DataSource = ThongTin_BUS.LayThongTinTheoPhong(maphong);
            this.reportViewer1.RefreshReport();
        }
        

    }
}
