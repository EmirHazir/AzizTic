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
    public class EfAlt_KategorilerDAL : EfRepositoryBase<Alt_Kategoriler,Model>, IAlt_KategorilerDAL
    {
    }
}
