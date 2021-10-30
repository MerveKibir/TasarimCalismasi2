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
    public partial class PersonelFrm : Form
    {
        TicariContext context = new TicariContext();
        public PersonelFrm()
        {
            InitializeComponent();
        }

        private void PersonelFrm_Load(object sender, EventArgs e)
        {
            FormClean();
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = (from l in context.Personel_TB
                                       select l).ToList();
            cbIl.Properties.DataSource = (from p in context.Iller_TB
                                          select new
                                          {
                                              Plaka = p.ID,
                                              Il = p.Sehir
                                          }).ToList();
            cbIlce.Properties.DataSource = (from t in context.Ilceler_TB
                                            select new
                                            {
                                                Id = t.ID,
                                                Sehir = t.Sehir,
                                                Ilce = t.Ilce
                                            }).ToList();
            txtId.Enabled = false;
        }
        void FormClean()
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSoyad.Text = "";
            maskTc.Text = "";
            maskTel1.Text = "";
            txtemail.Text = "";
            cbIl.Text = "";
            cbIlce.Text = "";
            rchAdres.Text = "";
            txtGorev.Text = "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel_TB yeniPersonel = new Personel_TB();
            if (!context.Personel_TB.Any(x => x.Tc == maskTc.Text))
            {
                try
                {
                    yeniPersonel.Ad = txtAd.Text;
                    yeniPersonel.Soyad = txtSoyad.Text;
                    yeniPersonel.Telefon = maskTel1.Text;
                    yeniPersonel.Tc = maskTc.Text;
                    yeniPersonel.Mail = txtemail.Text;
                    yeniPersonel.Il = cbIl.Text;
                    yeniPersonel.Ilce = cbIlce.Text;
                    yeniPersonel.Adres = rchAdres.Text;
                    yeniPersonel.Gorev = txtGorev.Text;
                    context.Personel_TB.Add(yeniPersonel);
                    context.SaveChanges();
                    MessageBox.Show("Personel ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormClean();
                    gridControl1.DataSource = (from ll in context.Personel_TB
                                               select ll).ToList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Personel eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var GuncellenecekPersonel = context.Personel_TB.First(x => x.Tc == maskTc.Text);
                    GuncellenecekPersonel.Ad = txtAd.Text;
                    GuncellenecekPersonel.Soyad = txtSoyad.Text;
                    GuncellenecekPersonel.Telefon = maskTel1.Text;
                    GuncellenecekPersonel.Mail = txtemail.Text;
                    GuncellenecekPersonel.Il = cbIl.Text;
                    GuncellenecekPersonel.Ilce = cbIlce.Text;
                    GuncellenecekPersonel.Adres = rchAdres.Text;
                    GuncellenecekPersonel.Gorev = txtGorev.Text;
                    context.SaveChanges();
                    MessageBox.Show("Personel güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormClean();
                    gridControl1.DataSource = (from ll in context.Personel_TB
                                               select ll).ToList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Personel güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                var silinecekPersonel = context.Personel_TB.First(x => x.ID == id);
                context.Personel_TB.Remove(silinecekPersonel);
                context.SaveChanges();
                MessageBox.Show("Personel silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClean();
                gridControl1.DataSource = (from ll in context.Personel_TB
                                           select ll).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek personeli seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtId.Text = "";
            txtSoyad.Text = "";
            maskTc.Text = "";
            maskTel1.Text = "";
            txtemail.Text = "";
            cbIl.Text = "";
            cbIlce.Text = "";
            rchAdres.Text = "";
            txtGorev.Text = "";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            int deger1 = Convert.ToInt32(B);
            var liste = (from c in context.Personel_TB
                         where c.ID == deger1
                         select c).SingleOrDefault();
            txtId.Text = liste.ID.ToString();
            txtAd.Text = liste.Ad;
            txtSoyad.Text = liste.Soyad;
            maskTel1.Text = liste.Telefon;
            txtGorev.Text = liste.Gorev;
            maskTc.Text = liste.Tc;
            txtemail.Text = liste.Mail;
            cbIl.Text = liste.Il;
            cbIlce.Text = liste.Ilce;
            rchAdres.Text = liste.Adres;
        }

        private void cbIl_EditValueChanged(object sender, EventArgs e)
        {
            var dgr = Convert.ToInt32(cbIl.EditValue);
            cbIlce.Properties.DataSource = (from t in context.Ilceler_TB
                                            where t.Sehir == dgr
                                            select new
                                            {
                                                Id = t.ID,
                                                Sehir = t.Sehir,
                                                Ilce = t.Ilce
                                            }).ToList();
        }
    }
}
