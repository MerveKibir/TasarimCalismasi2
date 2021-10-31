using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicariOtomasyon.Entity;

namespace TicariOtomasyon
{
    public partial class RehberFrm : Form
    {
        TicariContext context = new TicariContext();
        public RehberFrm()
        {
            InitializeComponent();
        }
        public static string mail { get; set; }
        private void RehberFrm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = (from ll in context.Musteri_TB
                                       select new
                                       {
                                           ID=ll.ID,
                                           AD=ll.Ad,
                                           SOYAD=ll.Soyad,
                                           TELEFON=ll.Telefon,
                                           TELEFON2=ll.Telefon2,
                                           MAİL=ll.Mail
                                       }).ToList();
            gridView2.OptionsBehavior.Editable = false;
            gridControl2.DataSource = (from ll in context.Firma_TB
                                       select new
                                       {
                                           ID = ll.ID,
                                           AD = ll.Ad,
                                           YETKILI= ll.YetkiliAdSoyad,
                                           TELEFON = ll.Telefon1,
                                           TELEFON2 = ll.Telefon2,
                                           TELEFON3 = ll.Telefon3,
                                           MAİL = ll.Mail,
                                           FAX=ll.Fax
                                       }).ToList();
        }
        bool MusteriMi;
        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            
            int[] SelectedRowHandles = gridView2.GetSelectedRows();
            string B = gridView2.GetRowCellValue(SelectedRowHandles[0], gridView2.Columns["ID"]).ToString();
            int id = Convert.ToInt32(B);
            MailFrm frm = new MailFrm(id);
            frm.ShowDialog(); 
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            MusteriMi = true;
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            int id = Convert.ToInt32( B);

            MailFrm frm = new MailFrm(id, MusteriMi);
            frm.ShowDialog();
        }
    }
}
