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
    public partial class MusteriFrm : Form
    {
        public MusteriFrm()
        {
            InitializeComponent();
        }

        void FormClean()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSoyad.Text = "";
            maskTc.Text = "";
            maskTel1.Text = "";
            maskTel2.Text = "";
            txtemail.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            rchAdres.Text = "";
            txtVergi.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //TicariServis.TicariServisSoapClient client = new TicariServis.TicariServisSoapClient();
            //MessageBox.Show(client.HelloWorld("Adınız", "soyadınız",5));
                  
            //Musteri_TB yeniMust = new Musteri_TB();
            //if (!context.Musteri_TB.Any(x => x.Tc == maskTc.Text))
            //{
            //    try
            //    {
            //        yeniMust.Ad = txtAd.Text;
            //        yeniMust.Soyad = txtSoyad.Text;
            //        yeniMust.Telefon = maskTel1.Text;
            //        yeniMust.Telefon2 = maskTel2.Text;
            //        yeniMust.Tc = maskTc.Text;
            //        yeniMust.Mail = txtemail.Text;
            //        yeniMust.Il = cbIl.Text;
            //        yeniMust.Ilce = cbIlce.Text;
            //        yeniMust.Adres = rchAdres.Text;
            //        yeniMust.VergiDairesi = txtVergi.Text;
            //        context.Musteri_TB.Add(yeniMust);
            //        context.SaveChanges();
            //        MessageBox.Show("Müşteri ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Musteri_TB
            //                                   select ll).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Müşteri eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    try
            //    {
            //        var GuncellenecekMusteri = context.Musteri_TB.First(x => x.Tc == maskTc.Text);
            //        GuncellenecekMusteri.Ad = txtAd.Text;
            //        GuncellenecekMusteri.Soyad = txtSoyad.Text;
            //        GuncellenecekMusteri.Telefon = maskTel1.Text;
            //        GuncellenecekMusteri.Telefon2 = maskTel2.Text;
            //        GuncellenecekMusteri.Mail = txtemail.Text;
            //        GuncellenecekMusteri.Il = cbIl.Text;
            //        GuncellenecekMusteri.Ilce = cbIlce.Text;
            //        GuncellenecekMusteri.Adres = rchAdres.Text;
            //        GuncellenecekMusteri.VergiDairesi = txtVergi.Text;
            //        context.SaveChanges();
            //        MessageBox.Show("Müşteri güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        FormClean();
            //        gridControl1.DataSource = (from ll in context.Musteri_TB
            //                                   select ll).ToList();
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("Müşteri güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }


            //}

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (txtId.Text != "")
            //{
            //    int id = Convert.ToInt32(txtId.Text);
            //    var silinecekMusteri = context.Musteri_TB.First(x => x.ID == id);
            //    context.Musteri_TB.Remove(silinecekMusteri);
            //    context.SaveChanges();
            //    MessageBox.Show("Müşteri silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    FormClean();
            //    gridControl1.DataSource = (from ll in context.Musteri_TB
            //                               select ll).ToList();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen silinecek müşteriyi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            //int[] SelectedRowHandles = gridView1.GetSelectedRows();
            //string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            //int deger1 = Convert.ToInt32(B);
            //var liste = (from c in context.Musteri_TB
            //             where c.ID == deger1
            //             select c).SingleOrDefault();
            //txtId.Text = liste.ID.ToString();
            //txtAd.Text = liste.Ad;
            //txtSoyad.Text = liste.Soyad;
            //maskTel1.Text = liste.Telefon;
            //maskTel2.Text = liste.Telefon2;
            //txtVergi.Text = liste.VergiDairesi;
            //maskTc.Text = liste.Tc;
            //txtemail.Text = liste.Mail;
            //cbIl.Text = liste.Il;
            //cbIlce.Text = liste.Ilce;
            //rchAdres.Text = liste.Adres;
        }

        private void MusteriFrm_Load(object sender, EventArgs e)
        {
            FormClean();
            txtId.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            //gridControl1.DataSource = (from ll in context.Musteri_TB
            //                           select ll).ToList();
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

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSoyad.Text = "";
            maskTc.Text = "";
            maskTel1.Text = "";
            maskTel2.Text = "";
            txtemail.Text = "";
            cbIl.EditValue = null;
            cbIlce.EditValue = null;
            rchAdres.Text = "";
            txtVergi.Text = "";
        }
    }
}
