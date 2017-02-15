using AzizTic.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AzizTic.Entities.Concrete;
using AzizTic.DataAccess.Abstract;

namespace AzizTic.Services.Concrete
{
    public class TedarikciManager : ITedarikciService
    {
        private ITedarikcilerDAL _tedarikciDal;
        public TedarikciManager(ITedarikcilerDAL tedarikciDal)
        {
            _tedarikciDal = tedarikciDal;
        }


        public void Add(Tedarikciler tedarikci)
        {
            _tedarikciDal.Add(tedarikci);
        }

        public void Delete(int tedarikciId)
        {
            _tedarikciDal.Delete(new Tedarikciler { Id = tedarikciId });
        }

        public List<Tedarikciler> GetAll()
        {
            return _tedarikciDal.GetList();
        }

        public Tedarikciler GetByTedarikciId(int tedarikciId)
        {
            return _tedarikciDal.Get(t => t.Id == tedarikciId);
        }

        public void Update(Tedarikciler tedarikci)
        {
            _tedarikciDal.Update(tedarikci);
        }
    }
}
