using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Banka:IEntity
    {
        public int ID { get; set; }
        public string BankaAd { get; set; }
        public string Sube { get; set; }
        public string Iban { get; set; }
        public string HesapNo { get; set; }
        public string Yetkili { get; set; }
        public string Tarih { get; set; }
        public string HesapTuru { get; set; }
        public int FirmaID { get; set; }
        public int Il { get; set; }
        public int Ilce { get; set; }
        public string Telefon { get; set; }

        //public virtual Firma_TB Firma_TB { get; set; }
        //public virtual Ilceler_TB Ilceler_TB { get; set; }
        //public virtual Iller_TB Iller_TB { get; set; }
    }
}
