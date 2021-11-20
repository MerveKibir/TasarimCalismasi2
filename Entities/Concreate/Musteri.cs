using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concreate
{
    public class Musteri : IEntity 
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Telefon2 { get; set; }
        public string Tc { get; set; }
        public string Mail { get; set; }
        public int Il { get; set; }
        public int Ilce { get; set; }
        public string Adres { get; set; }
        public string VergiDairesi { get; set; }
    }
}
