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
    public class KategoriManager : IKategoriService
    {
        private IKategorilerDAL _kategoriDal;
        public KategoriManager(IKategorilerDAL kategoriDal)
        {
            _kategoriDal = kategoriDal;
        }

        public void Add(Kategoriler kategori)
        {
            _kategoriDal.Add(kategori);
        }

        public void Delete(int kategoriId)
        {
            _kategoriDal.Delete(new Kategoriler { Id = kategoriId });
        }

        public List<Kategoriler> GetAll()
        {
            return _kategoriDal.GetList();
        }

        public Kategoriler GetByKategoryId(int kategoriId)
        {
            return _kategoriDal.Get(k => k.Id == kategoriId);
        }

        public void Update(Kategoriler kategoriler)
        {
            _kategoriDal.Update(kategoriler);
        }
    }
}
