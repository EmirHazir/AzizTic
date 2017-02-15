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
    public class SiparisDetayManager : ISiparisDetayService
    {
        private ISiparis_DetayDAL _siparisDetayDal;
        public SiparisDetayManager(ISiparis_DetayDAL siparisDetayDal)
        {
            _siparisDetayDal = siparisDetayDal;
        }

        public void Delete(int siparisId)
        {
            _siparisDetayDal.Delete(new Siparis_Detay { SiparisId = siparisId });
        }

        public List<Siparis_Detay> GetAll()
        {
            return _siparisDetayDal.GetList();
        }

        public Siparis_Detay GetBySiparisId(int siparisId)
        {
            return _siparisDetayDal.Get(s => s.SiparisId == siparisId);
        }

        public Siparis_Detay GetByUrunId(int urunId)
        {
            return _siparisDetayDal.Get(s => s.UrunId == urunId);
        }

        public void Update(Siparis_Detay siparisDetay)
        {
            _siparisDetayDal.Update(siparisDetay);
        }
    }
}
