using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IYorumService
    {
        List<Yorumlar> GetAll();
        List<Yorumlar> GetByKullanici(int kullaniciId);

        void Add(Yorumlar yorum);
        void Update(Yorumlar yorum);
        void Delete(int yorumId);

        Yorumlar GetById(int yorumId);

    }
}
