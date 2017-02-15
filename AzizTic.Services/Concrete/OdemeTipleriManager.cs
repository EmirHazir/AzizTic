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
    public class OdemeTipleriManager : IOdemeTipleriService
    {
        private IOdemeTipleriDAL _odemeTipDal;
        public OdemeTipleriManager(IOdemeTipleriDAL odemeTipDal)
        {
            _odemeTipDal = odemeTipDal;
        }

        public List<OdemeTipleri> GetById(int odemeTipId)
        {
            return _odemeTipDal.GetList(x => x.Id == odemeTipId);
        }

        public List<OdemeTipleri> GetList()
        {
            return _odemeTipDal.GetList();
        }
    }
}
