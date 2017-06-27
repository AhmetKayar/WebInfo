using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Core.Entites;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.DataAccess.Abstract
{
    public interface IUtileDal
    {
        Task<List<T>> GetList<T>() where T : class, IEntity, new();
    }
}
