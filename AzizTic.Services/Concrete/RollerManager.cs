using AzizTic.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzizTic.Entities.Concrete;
using AzizTic.DataAccess.Abstract;

namespace AzizTic.Services.Concrete
{
    public class RollerManager : IRollerService
    {
        private IRollerDAL _rolDal;

        public RollerManager(IRollerDAL rolDal)
        {
            _rolDal = rolDal;
        }


        public void Add(Roller rol)
        {
            _rolDal.Add(rol);
        }

        public void Delete(int rolId)
        {
            _rolDal.Delete(new Roller { Id = rolId });
        }

        public List<Roller> GetAll()
        {
            return _rolDal.GetList();
        }

        public Roller GetById(int rolId)
        {
            return _rolDal.Get(x=>x.Id == rolId);
        }

        public void Update(Roller rol)
        {
             _rolDal.Update(rol);
        }
    }
}
