using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IKategoriService
    {
        List<Kategoriler> GetAll();
        Kategoriler GetByKategoryId(int kategoriId);
        void Delete(int kategoriId);
        void Add(Kategoriler kategori);
        void Update(Kategoriler kategoriler);
    }
}
