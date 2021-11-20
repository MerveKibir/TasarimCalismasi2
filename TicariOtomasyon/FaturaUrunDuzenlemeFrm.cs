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
    public partial class FaturaUrunDuzenlemeFrm : Form
    {
        //TicariContext context = new TicariContext();
        public FaturaUrunDuzenlemeFrm()
        {
            InitializeComponent();
        }
        public FaturaUrunDuzenlemeFrm(int id)
        {
            InitializeComponent();
            //if (context.FaturaDetay_TB.Any(x => x.ID == id))
            //{
            //    var liste = (from ll in context.FaturaDetay_TB
            //                 where ll.ID == id
            //                 select ll).SingleOrDefault();
            //    var urunum = (from ur in context.Urun_TB
            //                  where ur.ID == liste.UrunId
            //                  select ur).SingleOrDefault();
            //    txtFDID.Text = liste.ID.ToString();
            //    txtFiyat.Text = liste.Fiyat.ToString();
            //    txtMarka.Text = urunum.Marka;
            //    txtMiktar.Text = liste.Miktar.ToString();
            //    txtModel.Text = urunum.Model;
            //    txtTutar.Text = liste.Tutar.ToString();
            //    txtUrunAd.Text = liste.UrunAd;
            //    TxtFaturaID.Text = liste.FaturaBilgiId.ToString();
            //    label1.Text = liste.UrunId.ToString();
            //}
        }
        private void FaturaUrunDuzenlemeFrm_Load(object sender, EventArgs e)
        {
            TxtFaturaID.Enabled = false;
            txtFDID.Enabled = false;
            txtMarka.Enabled = false;
            txtModel.Enabled = false;
            txtUrunAd.Enabled = false;
            txtFiyat.Enabled = false;
            txtTutar.Enabled = false;
            label1.Hide();
        }

        private void btnUrunSec_Click(object sender, EventArgs e)
        {
            //using (var form = new UrunSecFrm())
            //{
            //    var sonuc = form.ShowDialog();
            //    if (sonuc == DialogResult.OK)
            //    {
            //        int deger1 = Convert.ToInt32(form.donecekDeger1);
            //        var listesi = context.Urun_TB.ToList();
            //        var Urunum = context.Urun_TB.Where(p => p.ID == deger1).SingleOrDefault();
            //        if (Urunum != null)
            //        {
            //            txtUrunAd.Text = Urunum.UrunAd;
            //            txtMarka.Text = Urunum.Marka;
            //            txtModel.Text = Urunum.Model;
            //            txtFiyat.Text = Urunum.SatisFiyat.ToString();
            //            label1.Text = Urunum.ID.ToString();
            //        }
            //    }
            //}
            //if (txtMiktar.Text != "" && txtFiyat.Text != "")
            //{
            //    decimal miktar = Convert.ToDecimal(txtMiktar.Text);
            //    decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
            //    txtTutar.Text = (miktar * fiyat).ToString();
            //}
        }

        private void txtMiktar_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMiktar.Text != "" && txtFiyat.Text != "")
            {
                decimal miktar = Convert.ToDecimal(txtMiktar.Text);
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);
                txtTutar.Text = (miktar * fiyat).ToString();
            }
        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    int id = Convert.ToInt32(txtFDID.Text);
                
            //    var silinecek = (from s in context.FaturaDetay_TB
            //                     where s.ID == id
            //                     select s).Single();
            //    context.FaturaDetay_TB.Remove(silinecek);
            //    context.SaveChanges();
            //    MessageBox.Show("Faturadan ürün silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
                

            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Faturadan ürün silme işlemi başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
                
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    int id = Convert.ToInt32(txtFDID.Text);
            //    var guncellenecek = context.FaturaDetay_TB.First(x => x.ID == id);
            //    guncellenecek.Fiyat = Convert.ToDecimal(txtFiyat.Text);
            //    guncellenecek.Miktar = Convert.ToInt32(txtMiktar.Text);
            //    guncellenecek.Tutar = Convert.ToDecimal(txtTutar.Text);
            //    guncellenecek.UrunAd = txtUrunAd.Text;
            //    guncellenecek.UrunId = Convert.ToInt32(label1.Text);
            //    context.SaveChanges();
            //    MessageBox.Show("Fatura ürünü güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Fatura içi ürün güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
        private void FaturaUrunDuzenlemeFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //int dgr = Convert.ToInt32(TxtFaturaID.Text);//silindikten sonra alttaki formun yenileneceği değer.
            //FaturaDetayFrm frm = (FaturaDetayFrm)Application.OpenForms["FaturaDetayFrm"];
            //frm.gridControl1.DataSource = (from l in context.FaturaDetay_TB
            //                               where l.FaturaBilgiId == dgr
            //                               select l).ToList();
        }
    }
}
