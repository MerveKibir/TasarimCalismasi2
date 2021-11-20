using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concreate
{
    public class Not : IEntity 
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> NotTarih { get; set; }
        public Nullable<System.TimeSpan> NotSaat { get; set; }
        public string NotBaslik { get; set; }
        public string NotDetay { get; set; }
        public string NotOlusturan { get; set; }
    }
}
