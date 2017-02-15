using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Services.Abstract
{
    public interface IRollerService
    {
        List<Roller> GetAll();
        Roller GetById(int rolId);
        void Add(Roller rol);
        void Delete(int rolId);
        void Update(Roller rol);
    }
}
