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
    public partial class F_RPhong : Form
    {
        public F_RPhong()
        {
            InitializeComponent();
        }

        private void F_RPhong_Load(object sender, EventArgs e)
        {
            HienThiKhu();
            Phong_DTOBindingSource.DataSource = Phong_BUS.LayDSPhong();
            this.reportViewer1.RefreshReport();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string makhu = cmbKhu.SelectedValue.ToString();
            Phong_DTOBindingSource.DataSource = Phong_BUS.LayDSPhongTheoKhu(makhu);
            this.reportViewer1.RefreshReport();
        }
        private void HienThiKhu()
        {
            List<Khu_DTO> lstKhu = Khu_BUS.LayKhu();
            cmbKhu.DataSource = lstKhu;
            cmbKhu.ValueMember = "SMaKhu";
            cmbKhu.DisplayMember = "STenKhu";
        }
    }
}
