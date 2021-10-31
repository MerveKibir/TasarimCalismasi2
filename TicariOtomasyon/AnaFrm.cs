using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
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
        RibbonControl ribbonn = new RibbonControl();
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

        private void btnPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelFrm frm = new PersonelFrm();
            FormKontrol(frm);
        }

        private void btnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RehberFrm frm = new RehberFrm();
            FormKontrol(frm);
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void ribbonControl1_Paint(object sender, PaintEventArgs e)
        {
            RibbonControl ribbon = sender as RibbonControl;
            RibbonPageHeaderViewInfo viewInfo = ribbon.ViewInfo.Header;
            Rectangle rect = new Rectangle(0 ,0, viewInfo.Bounds.Width, viewInfo.Bounds.Height);
            using (SolidBrush brush = new SolidBrush(Color.Teal))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void btnGiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GiderFrm frm = new GiderFrm();
            FormKontrol(frm);
        }
    }
}
