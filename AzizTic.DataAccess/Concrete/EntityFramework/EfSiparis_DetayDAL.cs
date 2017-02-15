using AzizTic.Core.Repository.EntityFramework;
using AzizTic.DataAccess.Abstract;
using AzizTic.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.DataAccess.Concrete.EntityFramework
{
    public class EfSiparis_DetayDAL : EfRepositoryBase<Siparis_Detay,Model>, ISiparis_DetayDAL
    {
    }
}
