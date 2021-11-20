using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concreate
{
    public class Iller : IEntity 
    {
        public int ID { get; set; }
        public string Sehir { get; set; }
    }
}
