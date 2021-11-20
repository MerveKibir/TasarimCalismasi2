using Business.Abstract;
using Business.Constants;
using Core.Ultities.Results;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        IPersonelDal _personelDal;
        public PersonelManager(IPersonelDal personelDal)
        {
            _personelDal = personelDal;
        }
        public IResult Add(Personel personel)
        {
            _personelDal.Add(personel);

            return new SuccessResult(Messages.PersonelEkle);
        }

        public IDataResult<List<Personel>> GetAll()
        {
            return new SuccessDataResult<List<Personel>>(_personelDal.GetAll(), Messages.PersonelEkle);
        }

        public IDataResult<Personel> GetById(int personelId)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(p => p.ID == personelId),Messages.PersonelGetir);
        }

        public IResult Update(Personel personel)
        {
            throw new NotImplementedException();
        }


        public IResult Kontrol(string personelKimlik)
        {
            var result = _personelDal.GetAll(p => p.Tc == personelKimlik).Any();
            if (result)
            {
                return new ErrorDataResult(Messages.PersonelKontrol);
            }
            return new SuccessResult();
        }

        public IDataResult<Personel> GetByKimlikNo(string personelKimlik)
        {
            return new SuccessDataResult<Personel>(_personelDal.Get(p => p.Tc == personelKimlik), Messages.PersonelGetir);
        }

        public IDataResult<List<PersonelDetayDto>> GetPersonelDetails()
        {
            return new SuccessDataResult<List<PersonelDetayDto>>(_personelDal.GetPersonelDetails());
        }
    }
}
