using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class InHoaDon : Form
    {
        public DataTable dtdv;
        public DataTable dtp;
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void FormInHoaDon_Load(object sender, EventArgs e)
        {
            /*
           crpInHoaDon rp = new crpInHoaDon();
           rp.SetDataSource(dtp);

           rp.Subreports["crpInHoaDonPhong.rpt"].SetDataSource(dtp);
           //rp.SetDataSource(dtdv);
           rp.Subreports["crpInDichVu.rpt"].SetDataSource(dtdv);
           crv.ReportSource = rp;
           */
        }
    }
}
