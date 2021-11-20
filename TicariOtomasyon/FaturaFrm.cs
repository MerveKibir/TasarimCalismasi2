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
    public partial class FaturaFrm : Form
    {
        //TicariContext context = new TicariContext();
        public FaturaFrm()
        {
            InitializeComponent();
        }

        void FormClean()
        {
            txtFBID.Text = "";
            TxtFaturaID.Text = "";
            txtTeslimAlan.Text = "";
            txtVergiDairesi.Text = "";
            mskSaat.Text = "";
            mskTarih.Text = "";
            txtSeriNo.Text = "";
            txtSıraNo.Text = "";
            txtTeslimEden.EditValue = null;
            txtAlici.EditValue = null;
            txtUrunAd.Text = "";
            txtTutar.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtModel.Text = "";
            txtMarka.Text = "";
            txtFDID.Text = "";
        }

        private void FaturaFrm_Load(object sender, EventArgs e)
        {
            //gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from l in context.FaturaBilgi_TB
            //                           select l).ToList();
            //txtTeslimEden.Properties.DataSource = (from p in context.Personel_TB
            //                                       select new
            //                                       {
            //                                           Id = p.ID,
            //                                           Personel = p.Ad + " " + p.Soyad
            //                                       }).ToList();
            //txtAlici.Properties.DataSource = (from t in context.Firma_TB
            //                                  select new
            //                                  {
            //                                      Id = t.ID,
            //                                      Firma = t.Ad,
            //                                      Yetkili = t.YetkiliAdSoyad
            //                                  }).ToList();
            //txtFBID.Enabled = false;
            //TxtFaturaID.Enabled = false;
            //txtFDID.Enabled = false;
            //label1.Hide();
            //txtMarka.Enabled = false;
            //txtModel.Enabled = false;
            //txtUrunAd.Enabled = false;
            //txtFiyat.Enabled = false;
            //txtTutar.Enabled = false;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //int[] SelectedRowHandles = gridView1.GetSelectedRows();
            //string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            //int deger1 = Convert.ToInt32(B);
            //var liste = (from c in context.FaturaBilgi_TB
            //             where c.ID == deger1
            //             select c).SingleOrDefault();
            //if (FaturaBilgileri.SelectedTabPage == xtraTabPage1)
            //{
            //    var result = MessageBox.Show("Detay sayfasına gitmek isterseniz onaylayınız! Onaylamadığınız takdirde güncelleme alanına yönlendirileceksiniz!", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //    if (result == DialogResult.Yes)
            //    {
            //        FaturaDetayFrm frm = new FaturaDetayFrm(deger1);
            //        frm.ShowDialog();
            //    }
            //    else
            //    {
            //        txtFBID.Text = liste.ID.ToString();
            //        txtSeriNo.Text = liste.Seri;
            //        txtSıraNo.Text = liste.SıraNo;
            //        mskTarih.Text = liste.Tarih;
            //        mskSaat.Text = liste.Saat;
            //        txtVergiDairesi.Text = liste.VergiDaire;
            //        txtTeslimAlan.Text = liste.TeslimAlan;
            //        txtTeslimEden.Text = liste.TeslimEden;
            //        txtAlici.Text = liste.Alici;
            //    }
            //}
            //else
            //{
            //    txtFBID.Text = liste.ID.ToString();
            //    txtSeriNo.Text = liste.Seri;
            //    txtSıraNo.Text = liste.SıraNo;
            //    mskTarih.Text = liste.Tarih;
            //    mskSaat.Text = liste.Saat;
            //    txtVergiDairesi.Text = liste.VergiDaire;
            //    txtTeslimAlan.Text = liste.TeslimAlan;
            //    txtTeslimEden.Text = liste.TeslimEden;
            //    txtAlici.Text = liste.Alici;
            //}
        }

        private void btnFatKaydet_Click(object sender, EventArgs e)
        {
            //FaturaBilgi_TB yeniFatura = new FaturaBilgi_TB();
            //if (!context.FaturaBilgi_TB.Any(x => x.Seri == txtSeriNo.Text && x.SıraNo == txtSıraNo.Text))
            //{
            //    try
            //    {
            //        yeniFatura.Alici = txtAlici.Text;
            //        yeniFatura.TeslimAlan = txtTeslimAlan.Text;
            //        yeniFatura.Saat = mskSaat.Text;
            //        yeniFatura.Seri = txtSeriNo.Text;
            //        yeniFatura.Tarih = mskTarih.Text;
            //        yeniFatura.SıraNo = txtSıraNo.Text;
            //        yeniFatura.TeslimEden = txtTeslimEden.Text;
            //        yeniFatura.VergiDaire = txtVergiDairesi.Text;
            //        context.FaturaBilgi_TB.Add(yeniFatura);
            //        context.SaveChanges();
            //        MessageBox.Show("Fatura ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.FaturaBilgi_TB
            //                                   select ll).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Fatura eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        var GuncellenecekFatura = context.FaturaBilgi_TB.First(x => x.Seri == txtSeriNo.Text && x.SıraNo == txtSıraNo.Text);
            //        GuncellenecekFatura.Alici = txtAlici.Text;
            //        GuncellenecekFatura.TeslimAlan = txtTeslimAlan.Text;
            //        GuncellenecekFatura.Saat = mskSaat.Text;
            //        GuncellenecekFatura.Seri = txtSeriNo.Text;
            //        GuncellenecekFatura.SıraNo = txtSıraNo.Text;
            //        GuncellenecekFatura.Tarih = mskTarih.Text;
            //        GuncellenecekFatura.TeslimEden = txtTeslimEden.Text;
            //        GuncellenecekFatura.VergiDaire = txtVergiDairesi.Text;
            //        context.SaveChanges();
            //        MessageBox.Show("Fatura güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.FaturaBilgi_TB
            //                                   select ll).ToList();
            //    }

            //    catch (Exception)
            //    {
            //        MessageBox.Show("Fatura güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (txtFBID.Text != "")
            //{
            //    int id = Convert.ToInt32(txtFBID.Text);
            //    var silinecekFatura = context.FaturaBilgi_TB.First(x => x.ID == id);
            //    context.FaturaBilgi_TB.Remove(silinecekFatura);
            //    context.SaveChanges();
            //    MessageBox.Show("Fatura silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    FormClean();
            //    gridControl1.DataSource = (from ll in context.FaturaBilgi_TB
            //                               select ll).ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek faturayı seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnFatTem_Click(object sender, EventArgs e)
        {
            txtFBID.Text = "";
            TxtFaturaID.Text = "";
            txtTeslimAlan.Text = "";
            txtVergiDairesi.Text = "";
            mskSaat.Text = "";
            mskTarih.Text = "";
            txtSeriNo.Text = "";
            txtSıraNo.Text = "";
            txtTeslimEden.EditValue = null;
            txtAlici.EditValue = null;
            txtUrunAd.Text = "";
            txtTutar.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtModel.Text = "";
            txtMarka.Text = "";
            txtFDID.Text = "";
        }

        private void txtFBID_EditValueChanged(object sender, EventArgs e)
        {
            TxtFaturaID.Text = txtFBID.Text;
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            //if (TxtFaturaID.Text != "")
            //{
            //    using (var form = new UrunSecFrm())
            //    {
            //        var sonuc = form.ShowDialog();
            //        if (sonuc == DialogResult.OK)
            //        {
            //            int deger1 = Convert.ToInt32(form.donecekDeger1);
            //            var listesi = context.Urun_TB.ToList();
            //            var Urunum = context.Urun_TB.Where(p => p.ID == deger1).SingleOrDefault();
            //            if (Urunum != null)
            //            {
            //                txtUrunAd.Text = Urunum.UrunAd;
            //                txtMarka.Text = Urunum.Marka;
            //                txtModel.Text = Urunum.Model;
            //                txtFiyat.Text = Urunum.SatisFiyat.ToString();
            //                label1.Text = Urunum.ID.ToString();
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Öncelikle ürün ekleyeceğiniz faturayı seçmelisiniz!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void txtMiktar_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMiktar.Text != "" && txtFiyat.Text!="")
            {
                decimal miktar = Convert.ToDecimal(txtMiktar.Text);
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                txtTutar.Text = (miktar * fiyat).ToString();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //if (TxtFaturaID.Text != "")
            //{
            //    int id = Convert.ToInt32(label1.Text);
            //    FaturaDetay_TB yeniFaturaDetay = new FaturaDetay_TB();
            //    var urun = context.Urun_TB.Where(x => x.ID == id).Single();
            //    int fatId = Convert.ToInt32(TxtFaturaID.Text);
            //    if (!context.FaturaDetay_TB.Any(x => x.UrunId == id && x.FaturaBilgiId==fatId))
            //    {
            //        try
            //        {
            //            yeniFaturaDetay.UrunAd = txtUrunAd.Text;
            //            yeniFaturaDetay.Miktar = Convert.ToInt32(txtMiktar.Text);
            //            yeniFaturaDetay.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            //            yeniFaturaDetay.Tutar = Convert.ToDecimal(txtTutar.Text);
            //            yeniFaturaDetay.FaturaBilgiId = Convert.ToInt32(TxtFaturaID.Text);
            //            yeniFaturaDetay.UrunId = id;
            //            context.FaturaDetay_TB.Add(yeniFaturaDetay);
            //            context.SaveChanges();
            //            MessageBox.Show("Ürün ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            FormClean2();
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Ürün eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //        }
            //    }

            //    else
            //    {
            //        var result = MessageBox.Show("Bu ürün zaten mevcut. Yine de eklemek istiyor musunuz?.", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //        if (result == DialogResult.Yes)
            //        {
            //            try
            //            {
            //                yeniFaturaDetay.UrunAd = txtUrunAd.Text;
            //                yeniFaturaDetay.Miktar = Convert.ToInt32(txtMiktar.Text);
            //                yeniFaturaDetay.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            //                yeniFaturaDetay.Tutar = Convert.ToDecimal(txtTutar.Text);
            //                yeniFaturaDetay.FaturaBilgiId = Convert.ToInt32(TxtFaturaID.Text);
            //                yeniFaturaDetay.UrunId = id;
            //                context.FaturaDetay_TB.Add(yeniFaturaDetay);
            //                context.SaveChanges();
            //                MessageBox.Show("Ürün ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                FormClean2();
            //            }
            //            catch (Exception)
            //            {

            //                MessageBox.Show("Ürün eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
        }
        void FormClean2()
        {
            txtUrunAd.Text = "";
            txtTutar.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtModel.Text = "";
            txtFDID.Text = "";
            txtMarka.Text = "";
        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtUrunAd.Text = "";
            txtTutar.Text = "";
            txtMiktar.Text = "";
            txtFiyat.Text = "";
            txtModel.Text = "";
            txtFDID.Text = "";
            txtMarka.Text = "";
        }
    }
}
