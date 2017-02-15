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
    public class AltKategoriManager : IAltKategorilerService
    {
        public IAlt_KategorilerDAL _altKategoriDal;
        public AltKategoriManager(IAlt_KategorilerDAL altKategoriDal)
        {
            _altKategoriDal = altKategoriDal;
        }

        public void Add(Alt_Kategoriler altKategori)
        {
            _altKategoriDal.Add(altKategori);
        }

        public void Delete(int altKategoriId)
        {
            _altKategoriDal.Delete(new Alt_Kategoriler { Id = altKategoriId });
        }

        public List<Alt_Kategoriler> GetAll()
        {
            return _altKategoriDal.GetList();
        }

        public Alt_Kategoriler GetByAltKategoriId(int altKategoriId)
        {
            return _altKategoriDal.Get(a => a.Id == altKategoriId);
        }

        public void Update(Alt_Kategoriler altKategori)
        {
            _altKategoriDal.Update(altKategori);
        }
    }
}
