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
    public class KullaniciTipleriManager : IKullaniciTipleriService
    {
        private IKullaniciTipleriDAL _kullaniciTipleriDal;
        public KullaniciTipleriManager(IKullaniciTipleriDAL kullaniciTipleri)
        {
            _kullaniciTipleriDal = kullaniciTipleri;
        }

        public List<KullaniciTipleri> GetAll()
        {
            return _kullaniciTipleriDal.GetList();
        }

        public KullaniciTipleri GetByKullaniciTipId(int kullaniciTipId)
        {
            return _kullaniciTipleriDal.Get(k => k.Id == kullaniciTipId);
        }
    }
}
