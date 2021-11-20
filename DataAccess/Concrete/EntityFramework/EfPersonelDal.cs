using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal : EfEntityRepositoryBase<Personel, TicariContext>, IPersonelDal
    {
        public List<PersonelDetayDto> GetPersonelDetails()
        {
                using (TicariContext context = new TicariContext())
                {
                    var result = from p in context.Personel_TB
                                 join c in context.Iller_TB
                                 on p.Il equals c.ID
                                 join d in context.Ilceler_TB
                                 on p.Ilce equals d.ID
                                 select new PersonelDetayDto
                                 {
                                     ID = p.ID,
                                     Ad = p.Ad,
                                     Soyad = p.Soyad,
                                     Tc = p.Tc,
                                     Adres = p.Adres,
                                     Gorev =p.Gorev,
                                     Mail= p.Mail,
                                     Telefon =p.Telefon,
                                     Sehir= c.Sehir,
                                     Ilce=d.Ilce
                                 };
                    return result.ToList();
                }
            
        }
    }
}
