using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzizTic.Common.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(MapperConfiguration configuration);
    }
}
