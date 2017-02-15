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
    public class KargoSirketleriManager : IKargoSirketleriService
    {
        private IKargoSirketleriDAL _kargoDal;
        public KargoSirketleriManager(IKargoSirketleriDAL kargoDal)
        {
            _kargoDal = kargoDal;
        }


        public void Add(KargoSirketleri kargoSirket)
        {
            _kargoDal.Add(kargoSirket);
        }

        public void Delete(int kargoSirketId)
        {
            _kargoDal.Delete(new KargoSirketleri { Id = kargoSirketId });
        }

        public List<KargoSirketleri> GetAll()
        {
            return _kargoDal.GetList();
        }

        public KargoSirketleri GetByKargoSirketId(int kargoSirketId)
        {
            return _kargoDal.Get(k => k.Id == kargoSirketId);
        }

        public void Update(KargoSirketleri kargoSirket)
        {
            _kargoDal.Update(kargoSirket);
        }
    }
}
