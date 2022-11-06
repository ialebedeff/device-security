using AutoMapper;
using DeviceSecurity.Shared.Data;
using DeviceSecurity.Shared.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceSecurity.DataAccess.Mapping
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile() {
            CreateMap<AccountData, Account>();
        }
    }
}
