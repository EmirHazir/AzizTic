using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface ISiparisService
    {
        List<Siparisler> GetAll();
        Siparisler GetByMusteri(int musteriId);
        Siparisler GetByKargoSirketId(int kargoSirketId);
        void Add(Siparisler siparis);
        void Delete(int siparisId);
        void Update(Siparisler siparis);
        Siparisler GetBySiparisId(int siparisId);
    }
}
