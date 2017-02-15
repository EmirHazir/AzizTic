using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IOdemeTipleriService
    {
        List<OdemeTipleri> GetList();
        List<OdemeTipleri> GetById(int odemeTipId);
        
    }
}
