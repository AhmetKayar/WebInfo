using App.WebInfo.Business.Abstract;
using App.WebInfo.DataAccess.Abstract;
using App.WebInfo.Entities.Concrete;

namespace App.WebInfo.Business.Concrete
{
    public class PersonalManager : ManagerBase<IPersonalDal, Personal>, IPersonalService
    {
        public PersonalManager(IPersonalDal manager) : base(manager)
        {
        }
    }
}
