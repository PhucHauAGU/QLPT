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
    public partial class F_ThongKe : Form
    {
        public F_ThongKe()
        {
            InitializeComponent();
        }

        private void F_ThongKe_Load(object sender, EventArgs e)
        {
            var data = BUS.HoaDon_BUS.LayHoaDon();
            HoaDon_DTOBindingSource.DataSource = data;
            int Tong = 0;
            data.ForEach(it => { Tong += it.IThanhTien; });
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("Tong","Tổng tiền: "+Tong.ToString())
            };
            reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();
        }
    }
}
