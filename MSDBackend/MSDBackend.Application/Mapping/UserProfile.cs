using AutoMapper;
using MSDBackend.Application.Model;
using MSDBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDBackend.Application.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile() {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
