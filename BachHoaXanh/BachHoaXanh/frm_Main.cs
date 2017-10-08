using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        // ham nay la hom add form ne
        // gio moi lan viet su kien cho click
        public void addform(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }
        private void barDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_DangNhap frm = new frm_DangNhap();
            addform(frm);
            //chu new fom roi goi ham la dc
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_PhanQuyen frm = new frm_PhanQuyen();
            addform(frm);
        }
    }
}
