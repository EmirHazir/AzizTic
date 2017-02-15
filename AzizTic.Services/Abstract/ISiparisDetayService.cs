using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface ISiparisDetayService
    {
        Siparis_Detay GetByUrunId(int urunId);
        Siparis_Detay GetBySiparisId(int siparisId);
        List<Siparis_Detay> GetAll();
        void Delete(int siparisId);
        void Update(Siparis_Detay siparisDetay);
  

    }
}
