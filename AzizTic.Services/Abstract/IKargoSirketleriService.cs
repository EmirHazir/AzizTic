using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IKargoSirketleriService
    {
        List<KargoSirketleri> GetAll();
        KargoSirketleri GetByKargoSirketId(int kargoSirketId);
        void Add(KargoSirketleri kargoSirket);
        void Update(KargoSirketleri kargoSirket);
        void Delete(int kargoSirketId);
    }
}
