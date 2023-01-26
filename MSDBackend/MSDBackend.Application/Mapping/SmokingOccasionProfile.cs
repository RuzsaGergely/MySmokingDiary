using MSDBackend.Application.Model;
using MSDBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MSDBackend.Application.Mapping
{
    public class SmokingOccasionProfile : Profile
    {
        public SmokingOccasionProfile() {
            CreateMap<SmokeOccasion, SmokeOccasionDto>();
            CreateMap<SmokeOccasionDto, SmokeOccasion>();
        }
    }
}
