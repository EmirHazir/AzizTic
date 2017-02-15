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
    public class OdemelerManager : IOdemeleService
    {
        private IOdemelerDAL _odemelerDal;
        public OdemelerManager(IOdemelerDAL odemelerDal)
        {
            _odemelerDal = odemelerDal;
        }

        public List<Odemeler> GetAll()
        {
           return _odemelerDal.GetList();
        }

        public List<Odemeler> GetByKullaniciTipId(int kullaniciTipId)
        {
            return _odemelerDal.GetList(x => x.KullaniciTipId == kullaniciTipId);
        }

        Odemeler GetByOdemeId(int odemelerId)
        {
           return _odemelerDal.Get(x => x.Id == odemelerId);
        }
    }
}
