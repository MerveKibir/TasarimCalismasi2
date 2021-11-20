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
    public partial class BankaFrm : Form
    {
        
        public BankaFrm()
        {
            InitializeComponent();
        }
        void FormClean()
        {
            txtBankaAd.Text = "";
            txtId.Text = "";
            txtSube.Text = "";
            maskIban.Text = "";
            maskTel.Text = "";
            maskIban.Text = "";
            mskHesap.Text = "";
            mskTarih.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            LueFirma.EditValue = null;
            txtYetkili.Text = "";
        }
        private void BankaFrm_Load(object sender, EventArgs e)
        {
            //FormClean();
            //txtId.Enabled = false;
            //gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from ll in context.Banka_TB
            //                           join kk in context.Firma_TB
            //                           on ll.FirmaID equals kk.ID
            //                           select new
            //                           {
            //                               ID = ll.ID,
            //                               Il = ll.Il,
            //                               Ilce = ll.Ilce,
            //                               BankaAdi = ll.BankaAd,
            //                               Sube = ll.Sube,
            //                               Iban = ll.Iban,
            //                               HesapNo = ll.HesapNo,
            //                               Yetkili = ll.Yetkili,
            //                               Telefon = ll.Telefon,
            //                               Tarih = ll.Tarih,
            //                               HesapTuru = ll.HesapTuru,
            //                               Firma = kk.Ad
            //                           }).ToList();
            //cbIl.Properties.DataSource = (from p in context.Iller_TB
            //                              select new
            //                              {
            //                                  Plaka = p.ID,
            //                                  Il = p.Sehir
            //                              }).ToList();
            //cbIlce.Properties.DataSource = (from t in context.Ilceler_TB
            //                                select new
            //                                {
            //                                    Id = t.ID,
            //                                    Sehir = t.Sehir,
            //                                    Ilce = t.Ilce
            //                                }).ToList();
            //LueFirma.Properties.DataSource = (from t in context.Firma_TB
            //                                select new
            //                                {
            //                                    Id = t.ID,
            //                                    Firma = t.Ad
            //                                }).ToList();
        }

        private void cbIl_EditValueChanged(object sender, EventArgs e)
        {
            //var dgr = Convert.ToInt32(cbIl.EditValue);
            //cbIlce.Properties.DataSource = (from t in context.Ilceler_TB
            //                                where t.Sehir == dgr
            //                                select new
            //                                {
            //                                    Id = t.ID,
            //                                    Sehir = t.Sehir,
            //                                    Ilce = t.Ilce
            //                                }).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Banka_TB yeniBanka = new Banka_TB();
            //var dgr = Convert.ToInt32(LueFirma.EditValue);
            //if (!context.Banka_TB.Any(x => x.FirmaID == dgr && x.BankaAd==txtBankaAd.Text && x.Sube==txtSube.Text))
            //{
            //    try
            //    {
            //        yeniBanka.BankaAd = txtBankaAd.Text;
            //        yeniBanka.Sube = txtSube.Text;
            //        yeniBanka.Telefon = maskTel.Text;
            //        yeniBanka.Iban = maskIban.Text;
            //        yeniBanka.HesapNo = mskHesap.Text;
            //        yeniBanka.HesapTuru = cbHesapTuru.Text;
            //        yeniBanka.Il = cbIl.Text;
            //        yeniBanka.Ilce = cbIlce.Text;
            //        yeniBanka.Yetkili = txtYetkili.Text;
            //        yeniBanka.Tarih = mskTarih.Text;
            //        yeniBanka.FirmaID = Convert.ToInt32(LueFirma.EditValue);
            //        context.Banka_TB.Add(yeniBanka);
            //        context.SaveChanges();
            //        MessageBox.Show("Banka bilgisi ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Banka_TB
            //                                   join kk in context.Firma_TB
            //                                   on ll.FirmaID equals kk.ID
            //                                   select new
            //                                   {
            //                                       ID=ll.ID,
            //                                       Il=ll.Il,
            //                                       Ilce=ll.Ilce,
            //                                       BankaAdi=ll.BankaAd,
            //                                       Sube=ll.Sube,
            //                                       Iban=ll.Iban,
            //                                       HesapNo= ll.HesapNo,
            //                                       Yetkili=ll.Yetkili,
            //                                       Telefon=ll.Telefon,
            //                                       Tarih=ll.Tarih,
            //                                       HesapTuru= ll.HesapTuru,
            //                                       Firma=kk.Ad
            //                                   }).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Banka bilgisi eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        var GuncellenecekBanka = context.Banka_TB.First(x => x.FirmaID == dgr && x.BankaAd == txtBankaAd.Text && x.Sube == txtSube.Text);
            //        GuncellenecekBanka.BankaAd = txtBankaAd.Text;
            //        GuncellenecekBanka.Sube = txtSube.Text;
            //        GuncellenecekBanka.Telefon = maskTel.Text;
            //        GuncellenecekBanka.Yetkili = txtYetkili.Text;
            //        GuncellenecekBanka.HesapNo = mskHesap.Text;
            //        GuncellenecekBanka.Il = cbIl.Text;
            //        GuncellenecekBanka.Ilce = cbIlce.Text;
            //        GuncellenecekBanka.HesapTuru = cbHesapTuru.Text;
            //        GuncellenecekBanka.Iban = maskIban.Text;
            //        GuncellenecekBanka.Tarih = mskTarih.Text;
            //        GuncellenecekBanka.FirmaID = Convert.ToInt32(LueFirma.EditValue);
            //        context.SaveChanges();
            //        MessageBox.Show("Banka bilgisi güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Banka_TB
            //                                   join kk in context.Firma_TB
            //                                   on ll.FirmaID equals kk.ID
            //                                   select new
            //                                   {
            //                                       ID = ll.ID,
            //                                       Il = ll.Il,
            //                                       Ilce = ll.Ilce,
            //                                       BankaAdi = ll.BankaAd,
            //                                       Sube = ll.Sube,
            //                                       Iban = ll.Iban,
            //                                       HesapNo = ll.HesapNo,
            //                                       Yetkili = ll.Yetkili,
            //                                       Telefon = ll.Telefon,
            //                                       Tarih = ll.Tarih,
            //                                       HesapTuru = ll.HesapTuru,
            //                                       Firma = kk.Ad
            //                                   }).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Banka bilgisi güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    int id = Convert.ToInt32(txtId.Text);
            //    var silinecekBanka = context.Banka_TB.First(x => x.ID == id);
            //    context.Banka_TB.Remove(silinecekBanka);
            //    context.SaveChanges();
            //    MessageBox.Show("Banka bilgisi silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    FormClean();
            //    gridControl1.DataSource = (from ll in context.Banka_TB
            //                               join kk in context.Firma_TB
            //                               on ll.FirmaID equals kk.ID
            //                               select new
            //                               {
            //                                   ID = ll.ID,
            //                                   Il = ll.Il,
            //                                   Ilce = ll.Ilce,
            //                                   BankaAdi = ll.BankaAd,
            //                                   Sube = ll.Sube,
            //                                   Iban = ll.Iban,
            //                                   HesapNo = ll.HesapNo,
            //                                   Yetkili = ll.Yetkili,
            //                                   Telefon = ll.Telefon,
            //                                   Tarih = ll.Tarih,
            //                                   HesapTuru = ll.HesapTuru,
            //                                   Firma = kk.Ad
            //                               }).ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek banka bilgisi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtBankaAd.Text = "";
            txtId.Text = "";
            txtSube.Text = "";
            maskIban.Text = "";
            maskTel.Text = "";
            maskIban.Text = "";
            mskHesap.Text = "";
            mskTarih.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            LueFirma.EditValue = null;
            txtYetkili.Text = "";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //int[] SelectedRowHandles = gridView1.GetSelectedRows();
            //string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            //int deger1 = Convert.ToInt32(B);
            //var liste = (from c in context.Banka_TB
            //             where c.ID == deger1
            //             select c).SingleOrDefault();
            //var dgr = (from ll in context.Banka_TB
            //           join kk in context.Firma_TB
            //           on ll.FirmaID equals kk.ID
            //           where ll.ID==deger1
            //           select kk.Ad).SingleOrDefault();
            //txtId.Text = liste.ID.ToString();
            //txtBankaAd.Text = liste.BankaAd;
            //txtSube.Text = liste.Sube;
            //maskTel.Text = liste.Telefon;
            //mskHesap.Text = liste.HesapNo;
            //maskIban.Text = liste.Iban;
            //mskTarih.Text = liste.Tarih;
            //LueFirma.Text = dgr;
            //cbIl.Text = liste.Il;
            //cbIlce.Text = liste.Ilce;
            //cbHesapTuru.Text = liste.HesapTuru;
            //txtYetkili.Text = liste.Yetkili;
        }
    }
}
