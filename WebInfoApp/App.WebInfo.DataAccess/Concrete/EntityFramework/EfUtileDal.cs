using System;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core.Entites;

namespace App.WebInfo.DataAccess.Concrete.EntityFramework
{
    public class EfUtileDal:IUtileDal

    {
        public async Task<List<T>> GetList<T>() where T : class, IEntity, new()
        {
            using (var context = new WebInfoContext())
            {
                return await context.Set<T>().ToListAsync();
            }
        }
    }
}
