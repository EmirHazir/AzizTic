using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IOdemelerService
    {
        List<Odemeler> GetAll();
        Odemeler GetByOdemeId(int odemelerId);
        List<Odemeler> GetByKullaniciTipId(int kullaniciTipId);
    }
}
