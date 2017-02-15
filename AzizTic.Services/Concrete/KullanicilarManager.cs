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
    public class KullanicilarManager : IKullanicilarService
    {
        private IKullanicilarDAL _kullanicilarDal;
        public KullanicilarManager(IKullanicilarDAL kullanicilarDal)
        {
            _kullanicilarDal = kullanicilarDal;
        }

        public void Add(Kullanicilar kullanici)
        {
            _kullanicilarDal.Add(kullanici);
        }

        public void Delete(int kullaniciId)
        {
            _kullanicilarDal.Delete(new Kullanicilar { Id = kullaniciId });
        }

        public List<Kullanicilar> GetAll()
        {
            return _kullanicilarDal.GetList();
        }

        public Kullanicilar GetByKullaniciId(int kullaniciId)
        {
            return _kullanicilarDal.Get(k => k.Id == kullaniciId);
        }

        public void Update(Kullanicilar kullanici)
        {
            _kullanicilarDal.Update(kullanici);
        }
    }
}
