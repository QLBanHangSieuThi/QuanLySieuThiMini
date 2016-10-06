using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLySieuThiMini
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KhachHang_NCC.frmKhachHangNCC frmKH = new KhachHang_NCC.frmKhachHangNCC();
            frmKH.MdiParent = this;
            frmKH.Show();
        }
    }
}
