using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concreate
{
    public class Urun : IEntity 
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yıl { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> AlisFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public string Detay { get; set; }
    }
}
