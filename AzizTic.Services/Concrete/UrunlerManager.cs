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
    public class UrunlerManager : IUrunlerService
    {
        private IUrunDAL _urunDal;

        public UrunlerManager(IUrunDAL urunDal)
        {
            _urunDal = urunDal;
        }

        public void Add(Urunler urun)
        {
            _urunDal.Add(urun);
        }

        public void Delete(int urunId)
        {
            _urunDal.Delete(new Urunler { Id = urunId });
        }

        public List<Urunler> GetAll()
        {
            return _urunDal.GetList();
        }

        public List<Urunler> GetByCategory(int kategoriId)
        {
            return _urunDal.GetList(u => u.KategoriId == kategoriId);
        }

        public Urunler GetByUrunId(int urunId)
        {
            return _urunDal.Get(u => u.Id == urunId);
        }

        public void Update(Urunler urun)
        {
            _urunDal.Update(urun);
        }
    }
}
