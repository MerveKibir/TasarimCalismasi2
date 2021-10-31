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
    public partial class GiderFrm : Form
    {
        TicariContext context = new TicariContext();
        public GiderFrm()
        {
            InitializeComponent();
        }
        void FormClean()
        {
            cbAy.Text = "";
            txtId.Text = "";
            txtDogalgaz.Text = "";
            txtElektrik.Text = "";
            txtYil.Text = "";
            txtInternet.Text = "";
            txtMaas.Text = "";
            txtSu.Text = "";
            rchDetay.Text = "";
            txtExtra.Text = "";
        }
        private void GiderFrm_Load(object sender, EventArgs e)
        {
            FormClean();
            txtId.Enabled = false;
            gridView1.OptionsBehavior.Editable = false;
            gridControl1.DataSource = (from ll in context.Gider_TB
                                       select ll).ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Gider_TB yeniGider = new Gider_TB();
            if (txtId.Text=="")
            {
                try
                {
                    yeniGider.Ay = cbAy.Text;
                    yeniGider.Yil = txtYil.Text;
                    if (txtElektrik.Text != "")
                    {
                        yeniGider.Elektrik = Convert.ToDecimal(txtElektrik.Text);
                    }
                    else
                    {
                        yeniGider.Elektrik = Convert.ToDecimal(0);
                    }
                    if (txtDogalgaz.Text != "")
                    {
                        yeniGider.DoğalGaz = Convert.ToDecimal(txtDogalgaz.Text);
                    }
                    else
                    {
                        yeniGider.DoğalGaz = Convert.ToDecimal(0);
                    }
                    if (txtInternet.Text != "")
                    {
                        yeniGider.Internet = Convert.ToDecimal(txtInternet.Text);
                    }
                    else
                    {
                        yeniGider.Internet = Convert.ToDecimal(0);
                    }
                    if (txtSu.Text != "")
                    {
                        yeniGider.Su = Convert.ToDecimal(txtSu.Text);
                    }
                    else
                    {
                        yeniGider.Su = Convert.ToDecimal(0);
                    }
                    if (txtMaas.Text != "")
                    {
                        yeniGider.Maaşlar = Convert.ToDecimal(txtMaas.Text);
                    }
                    else
                    {
                        yeniGider.Maaşlar = Convert.ToDecimal(0);
                    }
                    if (txtExtra.Text != "")
                    {
                        yeniGider.Ekstra = Convert.ToDecimal(txtExtra.Text);
                    }
                    else
                    {
                        yeniGider.Ekstra = Convert.ToDecimal(0);
                    }
                    yeniGider.Detay = rchDetay.Text;
                    context.Gider_TB.Add(yeniGider);
                    context.SaveChanges();
                    MessageBox.Show("Gider ekleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormClean();
                    gridControl1.DataSource = (from ll in context.Gider_TB
                                               select ll).ToList();
                }
                catch (Exception)
                {

                    MessageBox.Show("Gider eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                
                var result = MessageBox.Show("Güncelleme işlemini gerçekleştirmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes )
                {
                    try
                    {
                            int id = Convert.ToInt32(txtId.Text);
                            var GuncellenecekGider = context.Gider_TB.First(x => x.ID == id);
                            GuncellenecekGider.Ay = cbAy.Text;
                            GuncellenecekGider.Yil = txtYil.Text;
                            GuncellenecekGider.Elektrik = Convert.ToDecimal(txtElektrik.Text);
                            GuncellenecekGider.Detay = rchDetay.Text;
                            GuncellenecekGider.DoğalGaz = Convert.ToDecimal(txtDogalgaz.Text);
                            GuncellenecekGider.Internet = Convert.ToDecimal(txtInternet.Text);
                            GuncellenecekGider.Su = Convert.ToDecimal(txtSu.Text);
                            GuncellenecekGider.Maaşlar = Convert.ToDecimal(txtMaas.Text);
                            GuncellenecekGider.Ekstra = Convert.ToDecimal(txtExtra.Text);
                            context.SaveChanges();
                            MessageBox.Show("Gider güncelleme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormClean();
                            gridControl1.DataSource = (from ll in context.Gider_TB
                                                       select ll).ToList();
                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Gider güncellenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                var silinecekGider = context.Gider_TB.First(x => x.ID == id);
                context.Gider_TB.Remove(silinecekGider);
                context.SaveChanges();
                MessageBox.Show("Gider silme işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormClean();
                gridControl1.DataSource = (from ll in context.Gider_TB
                                           select ll).ToList();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek gideri seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            cbAy.Text = "";
            txtId.Text = "";
            txtDogalgaz.Text = "";
            txtElektrik.Text = "";
            txtYil.Text = "";
            txtInternet.Text = "";
            txtMaas.Text = "";
            txtSu.Text = "";
            rchDetay.Text = "";
            txtExtra.Text = "";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            int[] SelectedRowHandles = gridView1.GetSelectedRows();
            string B = gridView1.GetRowCellValue(SelectedRowHandles[0], gridView1.Columns["ID"]).ToString();
            int deger1 = Convert.ToInt32(B);
            var liste = (from c in context.Gider_TB
                         where c.ID == deger1
                         select c).SingleOrDefault();
            txtDogalgaz.Text = liste.DoğalGaz.ToString();
            txtElektrik.Text = liste.Elektrik.ToString();
            txtExtra.Text = liste.Ekstra.ToString();
            txtInternet.Text = liste.Internet.ToString();
            txtMaas.Text = liste.Maaşlar.ToString();
            txtSu.Text = liste.Su.ToString();
            txtYil.Text = liste.Yil.ToString();
            cbAy.Text = liste.Ay.ToString();
            rchDetay.Text = liste.Detay.ToString();
            txtId.Text = liste.ID.ToString();
        }
    }
}
