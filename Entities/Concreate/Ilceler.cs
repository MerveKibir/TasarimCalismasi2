using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Ilceler:IEntity
    {
        public int ID { get; set; }
        public string Ilce { get; set; }
        public int Sehir { get; set; }
    }
}
