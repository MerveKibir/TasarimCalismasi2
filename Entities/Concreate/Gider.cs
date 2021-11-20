using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concreate
{
    public class Gider : IEntity 
    {
        public int ID { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public Nullable<decimal> Elektrik { get; set; }
        public Nullable<decimal> Su { get; set; }
        public Nullable<decimal> DoğalGaz { get; set; }
        public Nullable<decimal> Internet { get; set; }
        public Nullable<decimal> Maaşlar { get; set; }
        public Nullable<decimal> Ekstra { get; set; }
        public string Detay { get; set; }
    }
}
