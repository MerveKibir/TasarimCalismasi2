using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class MainFrm : Form
    {
        
        public MainFrm()
        {
            InitializeComponent();
        }
        UrunlerFrm frm;
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm==null)
            {
                frm = new UrunlerFrm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        MusteriFrm mstfrm;
        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mstfrm == null)
            {
                mstfrm = new MusteriFrm();
                mstfrm.MdiParent = this;
                mstfrm.Show();
            }
        }
    }
}
