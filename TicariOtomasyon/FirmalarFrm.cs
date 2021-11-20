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
    public partial class FirmalarFrm : Form
    {
       
        public FirmalarFrm()
        {
            InitializeComponent();
        }
        void FormClean()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSektor.Text = "";
            txtYetkili.Text = "";
            txtYetkiliGorev.Text = "";
            maskYetkiliTc.Text = "";
            maskTel1.Text = "";
            maskTel2.Text = "";
            maskTel3.Text = "";
            maskFax.Text = "";
            txtMail.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            rchAdres.Text = "";
            txtVergi.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
        }
        private void FirmalarFrm_Load(object sender, EventArgs e)
        {
            FormClean();
            //gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from l in context.Firma_TB
            //                           select l).ToList();
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
            //richOzel1.Enabled = false;
            //richOzel2.Enabled = false;
            //richOzel3.Enabled = false;
            //txtId.Enabled = false;
            //richOzel1.Text = context.Kodlar_TB.Single().FirmaKod1;
            //richOzel2.Text = context.Kodlar_TB.Single().FirmaKod2;
            //richOzel3.Text = context.Kodlar_TB.Single().FirmaKod3;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //int[] SelectedRowHandles = gridView1.GetSelectedRows();
            //string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            //int deger1 = Convert.ToInt32(B);
            //var liste = (from c in context.Firma_TB
            //             where c.ID == deger1
            //             select c).SingleOrDefault();
            //txtId.Text = liste.ID.ToString();
            //txtAd.Text = liste.Ad;
            //txtSektor.Text = liste.Sektor;
            //maskTel1.Text = liste.Telefon1;
            //maskTel2.Text = liste.Telefon2;
            //maskTel3.Text = liste.Telefon3;
            //txtVergi.Text = liste.VergiDaire;
            //maskYetkiliTc.Text = liste.YetkiliTC;
            //txtMail.Text = liste.Mail;
            //cbIl.Text = liste.Il;
            //cbIlce.Text = liste.Ilce;
            //rchAdres.Text = liste.Adres;
            //txtYetkili.Text = liste.YetkiliAdSoyad;
            //txtYetkiliGorev.Text = liste.YetkiliStatu;
            //maskFax.Text = liste.Fax;
            //txtKod1.Text = liste.OzelKod1;
            //txtKod2.Text = liste.OzelKod2;
            //txtKod3.Text = liste.OzelKod3;
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
            //Firma_TB yeniFirma = new Firma_TB();
            //if (!context.Firma_TB.Any(x => x.Ad == txtAd.Text))
            //{
            //    try
            //    {
            //        yeniFirma.Ad = txtAd.Text;
            //        yeniFirma.Sektor = txtSektor.Text;
            //        yeniFirma.Telefon1 = maskTel1.Text;
            //        yeniFirma.Telefon2 = maskTel2.Text;
            //        yeniFirma.Telefon3 = maskTel3.Text;
            //        yeniFirma.Fax = maskFax.Text;
            //        yeniFirma.Mail = txtMail.Text;
            //        yeniFirma.Il = cbIl.Text;
            //        yeniFirma.Ilce = cbIlce.Text;
            //        yeniFirma.Adres = rchAdres.Text;
            //        yeniFirma.VergiDaire = txtVergi.Text;
            //        yeniFirma.YetkiliAdSoyad = txtYetkili.Text;
            //        yeniFirma.YetkiliStatu = txtYetkiliGorev.Text;
            //        yeniFirma.YetkiliTC = maskYetkiliTc.Text;
            //        yeniFirma.OzelKod1 = txtKod1.Text;
            //        yeniFirma.OzelKod2 = txtKod2.Text;
            //        yeniFirma.OzelKod3 = txtKod3.Text;
            //        context.Firma_TB.Add(yeniFirma);
            //        context.SaveChanges();
            //        MessageBox.Show("Firma ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Firma_TB
            //                                   select ll).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Firma eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        var GuncellenecekFirma = context.Firma_TB.First(x => x.Ad == txtAd.Text);
            //        GuncellenecekFirma.Ad = txtAd.Text;
            //        GuncellenecekFirma.Sektor = txtSektor.Text;
            //        GuncellenecekFirma.Telefon1 = maskTel1.Text;
            //        GuncellenecekFirma.Telefon2 = maskTel2.Text;
            //        GuncellenecekFirma.Telefon3 = maskTel3.Text;
            //        GuncellenecekFirma.Fax = maskFax.Text;
            //        GuncellenecekFirma.Mail = txtMail.Text;
            //        GuncellenecekFirma.Il = cbIl.Text;
            //        GuncellenecekFirma.Ilce = cbIlce.Text;
            //        GuncellenecekFirma.Adres = rchAdres.Text;
            //        GuncellenecekFirma.VergiDaire = txtVergi.Text;
            //        GuncellenecekFirma.YetkiliAdSoyad = txtYetkili.Text;
            //        GuncellenecekFirma.YetkiliStatu = txtYetkiliGorev.Text;
            //        GuncellenecekFirma.YetkiliTC = maskYetkiliTc.Text;
            //        GuncellenecekFirma.OzelKod1 = txtKod1.Text;
            //        GuncellenecekFirma.OzelKod2 = txtKod2.Text;
            //        GuncellenecekFirma.OzelKod3 = txtKod3.Text;
            //        context.SaveChanges();
            //        MessageBox.Show("Firma güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Firma_TB
            //                                   select ll).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Firma güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    int id = Convert.ToInt32(txtId.Text);
            //    var silinecekFirma = context.Firma_TB.First(x => x.ID == id);
            //    context.Firma_TB.Remove(silinecekFirma);
            //    context.SaveChanges();
            //    MessageBox.Show("Firma silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    FormClean();
            //    gridControl1.DataSource = (from ll in context.Firma_TB
            //                               select ll).ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek firmayı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSektor.Text = "";
            txtYetkili.Text = "";
            txtYetkiliGorev.Text = "";
            maskYetkiliTc.Text = "";
            maskTel1.Text = "";
            maskTel2.Text = "";
            maskTel3.Text = "";
            maskFax.Text = "";
            txtMail.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            rchAdres.Text = "";
            txtVergi.Text = "";
            txtKod1.Text = "";
            txtKod2.Text = "";
            txtKod3.Text = "";
        }
    }
    
}
