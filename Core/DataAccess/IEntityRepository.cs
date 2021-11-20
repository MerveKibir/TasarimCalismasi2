using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //T parametresi; sınıf olmalı, IEntity ile implamente olmuş olmalı, yeni bir sınıf olmalı.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Filtre olmaması durumunda tamamını getir.
        T Get(Expression<Func<T, bool>> filter);//Filtre olması durumunda filtreye uygun veriyi getir.
        void Add(T entity);//Ekleme.
        void Update(T entity);//Güncelleme.
        void Delete(T entity);//Silme.
    }
}
