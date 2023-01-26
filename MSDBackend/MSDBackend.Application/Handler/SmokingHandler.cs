using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MSDBackend.Application.Model;
using MSDBackend.Infrastructure;
using MSDBackend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSDBackend.Application.Handler
{
    public interface ISmokingHandler
    {
        List<SmokeOccasionDto> GetSmokeOccasions();
    }
    public class SmokingHandler
    {
        private readonly IMapper _mapper;
        private SmokingContext _context;
        public SmokingHandler(IMapper mapper, SmokingContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public List<SmokeOccasionDto> GetSmokeOccasions()
        {
            return _mapper.Map<List<SmokeOccasion>, List<SmokeOccasionDto>>(_context.smokeOccasions.Include(x => x.TypeOfSmoke).ToList());
        }
    }
}
