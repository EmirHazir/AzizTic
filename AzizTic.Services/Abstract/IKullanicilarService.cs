using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IKullanicilarService
    {
        List<Kullanicilar> GetAll();
        Kullanicilar GetByKullaniciId(int kullaniciId);
        void Add(Kullanicilar kullanici);
        void Delete(int kullaniciId);
        void Update(Kullanicilar kullanici);
    }
}
