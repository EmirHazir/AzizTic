using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IKullaniciTipleriService
    {
        List<KullaniciTipleri> GetAll();
        KullaniciTipleri GetByKullaniciTipId(int kullaniciTipId);

    }
}
