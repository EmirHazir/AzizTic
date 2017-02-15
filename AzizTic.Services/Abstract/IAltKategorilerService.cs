using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IAltKategorilerService 
    {
        List<Alt_Kategoriler> GetAll();
        Alt_Kategoriler GetByAltKategoriId(int altKategoriId);
        void Add(Alt_Kategoriler altKategori);
        void Delete(int altKategoriId);
        void Update(Alt_Kategoriler altKategori);
    }
}
