using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
   
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {

        List<T> GetAll();

        T GetByCity(T entity);

        List<T> GetByCodeASC();

        List<T> GetByCodeDESC();


    }
}
