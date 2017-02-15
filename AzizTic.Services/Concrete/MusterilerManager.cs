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
    public class MusterilerManager : IMusterilerService
    {
        private IMusterilerDAL _musterilerDal;
        public MusterilerManager(IMusterilerDAL musterilerDal)
        {
            _musterilerDal = musterilerDal;
        }
             

        public List<Musteriler> GetAll()
        {
            return _musterilerDal.GetList();
        }

        public Musteriler GetById(int musteriId)
        {
            return _musterilerDal.Get(m => m.Id == musteriId);
        }
    }
}
