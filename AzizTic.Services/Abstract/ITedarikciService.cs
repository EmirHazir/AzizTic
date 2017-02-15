using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
   public interface ITedarikciService
    {
        List<Tedarikciler> GetAll();
        void Add(Tedarikciler tedarikci);
        void Delete(int tedarikciId);
        void Update(Tedarikciler tedarikci);
        Tedarikciler GetByTedarikciId(int tedarikciId);
    }
}
