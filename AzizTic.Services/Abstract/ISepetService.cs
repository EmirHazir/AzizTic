using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface ISepetService
    {
        void AddToSepet(Sepet sepet, Urunler urun);
        void RemoveFromSepet(Sepet sepet, int urunId);
        List<SepetIcerik> List(Sepet sepet);
    }
}
