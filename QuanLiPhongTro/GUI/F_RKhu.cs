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

namespace GUI
{
    public partial class F_RKhu : Form
    {
        public F_RKhu()
        {
            InitializeComponent();
        }

        private void F_RKhu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLPTDataSet.KHU' table. You can move, or remove it, as needed.
           this.KHUTableAdapter.Fill(this.QLPTDataSet.KHU);
            this.reportViewer1.RefreshReport();
        }
    }
}
