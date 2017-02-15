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
    public class YorumManager : IYorumService
    {
        private IYorumDAL _yorumDal;
        public YorumManager(IYorumDAL yorumDal)
        {
            _yorumDal = yorumDal;
        }

        public void Add(Yorumlar yorum)
        {
            _yorumDal.Add(yorum);
        }

        public void Delete(int yorumId)
        {
            _yorumDal.Delete(new Yorumlar { Id = yorumId });
        }

        public List<Yorumlar> GetAll()
        {
            return _yorumDal.GetList();
        }

        public Yorumlar GetById(int yorumId)
        {
            return _yorumDal.Get(x => x.Id == yorumId);
        }

        public List<Yorumlar> GetByKullanici(int kullaniciId)
        {
            return _yorumDal.GetList(x => x.KullaniciId == kullaniciId);
        }

        public void Update(Yorumlar yorum)
        {
            _yorumDal.Update(yorum);
        }
    }
}
