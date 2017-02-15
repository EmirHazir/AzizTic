using AzizTic.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzizTic.Entities.Concrete;

namespace AzizTic.Services.Concrete
{
    public class SepetManager : ISepetService
    {
        public void AddToSepet(Sepet sepet, Urunler urun)
        {
            SepetIcerik sepetIcerik = sepet.SepetIcerikleri.FirstOrDefault(s => s.Urunler.Id == urun.Id);
            if (sepetIcerik!=null)
            {
                sepetIcerik.SepettekiUrunAdet++;
                return;
            }
            else
            {
                sepet.SepetIcerikleri.Add(new SepetIcerik
                {
                    Urunler = urun,
                    SepettekiUrunAdet=1
                });
            }
        }

        public List<SepetIcerik> List(Sepet sepet)
        {
            return sepet.SepetIcerikleri;
        }

        public void RemoveFromSepet(Sepet sepet, int urunId)
        {
            sepet.SepetIcerikleri.Remove(sepet.SepetIcerikleri.FirstOrDefault(s => s.Urunler.Id == urunId));
        }
    }
}
