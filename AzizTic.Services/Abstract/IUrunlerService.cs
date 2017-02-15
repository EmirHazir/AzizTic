using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IUrunlerService
    {
        List<Urunler> GetAll();
        List<Urunler> GetByCategory(int kategoriId);
        void Add(Urunler urun);
        void Delete(int urunId);
        void Update(Urunler urun);
        Urunler GetByUrunId(int urunId);
    }
}
