using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using TicariOtomasyon.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class UrunlerFrm : Form
    {
        TicariContext context = new TicariContext();
        public UrunlerFrm()
        {
            InitializeComponent();
        }

        private void UrunlerFrm_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = (from ll in context.Urun_TB
                                       select ll).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun_TB yeniUrun = new Urun_TB();
            if (!context.Urun_TB.Any(x =>x.UrunAd==txtAd.Text &&x.Marka == txtMarka.Text && x.Model == txtModel.Text && x.Yıl==txtYil.Text))
            {
                try
                {
                    yeniUrun.Marka = txtMarka.Text;
                    yeniUrun.Model = txtModel.Text;
                    yeniUrun.SatisFiyat = Convert.ToDecimal(txtSatis.Text);
                    yeniUrun.UrunAd = txtAd.Text;
                    yeniUrun.Yıl = txtYil.Text;
                    yeniUrun.Adet = Convert.ToInt32(numAdet.Value);
                    yeniUrun.AlisFiyat = Convert.ToDecimal(txtAlis.Text);
                    yeniUrun.Detay = rchDetay.Text;
                    context.Urun_TB.Add(yeniUrun);
                    context.SaveChanges();
                    MessageBox.Show("Ürün ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = (from ll in context.Urun_TB
                                               select ll).ToList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ürün eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    var GuncellenecekUrun = context.Urun_TB.First(x => x.Marka == txtMarka.Text && x.Model == txtModel.Text);
                    GuncellenecekUrun.Marka = txtMarka.Text;
                    GuncellenecekUrun.Model = txtModel.Text;
                    GuncellenecekUrun.SatisFiyat = Convert.ToDecimal(txtSatis.Text);
                    GuncellenecekUrun.UrunAd = txtAd.Text;
                    GuncellenecekUrun.Yıl = txtYil.Text;
                    GuncellenecekUrun.Adet = Convert.ToInt32(numAdet.Value);
                    GuncellenecekUrun.AlisFiyat = Convert.ToDecimal(txtAlis.Text);
                    GuncellenecekUrun.Detay = rchDetay.Text;
                    context.SaveChanges();
                    MessageBox.Show("Ürün güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = (from ll in context.Urun_TB
                                               select ll).ToList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Ürün güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtId.Text!="")
            {
                int id = Convert.ToInt32(txtId.Text);
                var silinecekUrun = context.Urun_TB.First(x => x.ID == id);
                context.Urun_TB.Remove(silinecekUrun);
                context.SaveChanges();
                MessageBox.Show("Ürün silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = (from ll in context.Urun_TB
                                           select ll).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek ürün seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            int deger1 = Convert.ToInt32(B);
            var liste = (from c in context.Urun_TB
                         where c.ID == deger1
                         select c ).SingleOrDefault();
            txtId.Text = liste.ID.ToString();
            txtAd.Text = liste.UrunAd;
            txtMarka.Text = liste.Marka;
            txtModel.Text = liste.Model;
            txtYil.Text = liste.Yıl;
            numAdet.Value = Convert.ToDecimal(liste.Adet);
            txtAlis.Text =liste.AlisFiyat.ToString();
            txtSatis.Text = liste.SatisFiyat.ToString();
            rchDetay.Text = liste.Detay;
        }
    }
}
