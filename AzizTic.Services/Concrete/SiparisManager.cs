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
    public class SiparisManager : ISiparisService
    {
        private ISiparislerDAL _siparisDal;
        public SiparisManager(ISiparislerDAL siparisDal)
        {
            _siparisDal = siparisDal;
        }


        public void Add(Siparisler siparis)
        {
            _siparisDal.Add(siparis);
        }

        public void Delete(int siparisId)
        {
            _siparisDal.Delete(new Siparisler { Id = siparisId });
        }

        public List<Siparisler> GetAll()
        {
            return _siparisDal.GetList();
        }

        public Siparisler GetByKargoSirketId(int kargoSirketId)
        {
            return _siparisDal.Get(k => k.KargoSirketId == kargoSirketId);
        }

        public Siparisler GetByMusteri(int musteriId)
        {
            return _siparisDal.Get(m => m.MusteriId == musteriId);
        }

        public Siparisler GetBySiparisId(int siparisId)
        {
            return _siparisDal.Get(x => x.Id == siparisId);
        }

        public void Update(Siparisler siparis)
        {
            _siparisDal.Update(siparis);
        }
    }
}
