﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate
{
    public class Firma :IEntity
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string YetkiliStatu { get; set; }
        public string YetkiliAdSoyad { get; set; }
        public string YetkiliTC { get; set; }
        public string Sektor { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public int Il { get; set; }
        public int Ilce { get; set; }
        public string VergiDaire { get; set; }
        public string Adres { get; set; }
        public string OzelKod1 { get; set; }
        public string OzelKod2 { get; set; }
        public string OzelKod3 { get; set; }
    }
}
