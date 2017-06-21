using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App.WebInfo.Business.Abstract
{
    public interface IServiceBase<T> where T : class, new()
    {
        Task Add(T entity);
        Task Update(T entity);
        Task<long> Count();
        Task<List<T>> GetList();
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null, string include=null);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null, Expression<Func<T, bool>> orderProperty = null, int pageNumber = 1, int pageSize = 10, bool isAscendingOrder = true, params Expression<Func<T, bool>>[] include);
        Task<T> Get(Expression<Func<T, bool>> filter = null);
    }
}
