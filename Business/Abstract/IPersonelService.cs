using Core.Ultities.Results;
using Core.Utilities.Results;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<List<Personel>> GetAll();
        IDataResult<Personel> GetById(int personelId);
        IDataResult<Personel> GetByKimlikNo(string personelKimlik);
        IDataResult<List<PersonelDetayDto>> GetPersonelDetails();
        IResult Add(Personel personel);
        IResult Update(Personel personel);
        IResult Kontrol(string personelKimlik);
    }
}
