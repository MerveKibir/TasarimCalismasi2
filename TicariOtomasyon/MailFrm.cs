using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TicariOtomasyon
{
    public partial class MailFrm : Form
    {

        public MailFrm()
        {
            InitializeComponent();
        }
        public MailFrm(int id)
        {
            InitializeComponent();
            //if (context.Firma_TB.Any(x => x.ID == id))
            //{
            //    string liste = context.Firma_TB.Single(x => x.ID == id).Mail;
            //    txtMail.Text = liste;
            //}

        }
        public MailFrm(int id, bool MusteriMi)
        {
            InitializeComponent();
            //if (context.Musteri_TB.Any(x => x.ID == id) && MusteriMi == true)
            //{
            //    string liste = context.Musteri_TB.Single(x => x.ID == id).Mail;
            //    txtMail.Text = liste;
            //}

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var kullanici = context.Admin_TB.Where(x => x.Id == 1).Single();
            //    MailMessage loginInfo = new MailMessage();
            //    loginInfo.To.Add(txtMail.Text);
            //    loginInfo.From = new MailAddress(kullanici.Admin);
            //    loginInfo.Subject = txtKonu.Text;
            //    loginInfo.Body = rchMesaj.Text;
            //    loginInfo.IsBodyHtml = true;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.Port = 587;
            //    smtp.EnableSsl = true;
            //    smtp.Credentials = new System.Net.NetworkCredential(kullanici.Admin, kullanici.Parola);
            //    smtp.Send(loginInfo);
            //    var result=MessageBox.Show("Mesajınız gönderilmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    if(result==DialogResult.OK)
            //    {
            //        this.Close();
            //    }
            //}
            //catch (Exception)
            //{

            //    var result = MessageBox.Show("Mesajınız gönderilemedi.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}




        }
    }
}
