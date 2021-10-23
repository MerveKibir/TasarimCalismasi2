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

        public void FormKontrol(Form AcilanForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (AcilanForm.Name == MdiChildren[i].Name)
                {
                    MdiChildren[i].Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilanForm.MdiParent = this;
                AcilanForm.WindowState = FormWindowState.Maximized;
                AcilanForm.Show();
            }
            else
            {
                AcilanForm.Refresh();
                AcilanForm.Activate();
            }
        }

        
        private void btnUrunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UrunlerFrm frm = new UrunlerFrm();
            FormKontrol(frm);
        }

        
        private void btnMusteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriFrm frm = new MusteriFrm();
            FormKontrol(frm);
        }

        private void btnFirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FirmalarFrm frm = new FirmalarFrm();
            FormKontrol(frm);
        }
    }
}
