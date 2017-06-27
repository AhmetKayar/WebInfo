using App.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.Core.Dal
{
    public interface IEntityRepository<T> where T : class, IEntity,new()
    {
        Task Add(T entity);
        Task Add(List<T> entity);
        Task Update(T entity);
        Task<long> Count(Expression<Func<T, bool>> filter = null);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null, string includes=null);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null, Expression<Func<T, bool>> orderProperty = null, int pageNumber=1,int pageSize=10,bool isAscendingOrder=true, params Expression<Func<T, bool>>[] include);
        Task<T> Get(Expression<Func<T, bool>> filter, string include = null);
    }
}
