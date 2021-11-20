using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class FaturaDetay:IEntity
    {
        public int ID { get; set; }
        public string UrunAd { get; set; }
        public Nullable<int> Miktar { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public int FaturaBilgiId { get; set; }
        public int UrunId { get; set; }
    }
}
