using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class TicariContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MERVE;Database=TicariDB;User Id=mervek;Password=MevsiM95;");
        }
        public virtual DbSet<Admins> Admin_TB { get; set; }
        public virtual DbSet<Banka> Banka_TB { get; set; }
        public virtual DbSet<FaturaBilgi> FaturaBilgi_TB { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetay_TB { get; set; }
        public virtual DbSet<Firma> Firma_TB { get; set; }
        public virtual DbSet<Gider> Giderl_TB { get; set; }
        public virtual DbSet<Ilceler> Ilceler_TB { get; set; }
        public virtual DbSet<Iller> Iller_TB { get; set; }
        public virtual DbSet<Musteri> Musteri_TB { get; set; }
        public virtual DbSet<Not> Not_TB { get; set; }
        public virtual DbSet<Personel> Personel_TB{ get; set; }
        public virtual DbSet<Stok> Stok_TB { get; set; }
        public virtual DbSet<Urun> Urun_TB { get; set; }
    }
}
