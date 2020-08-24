using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.FrequentDefect.Queries.GetFrequentDefect
{
    public class GetFrequentDefectQueryHandler:IRequestHandler<GetFrequentDefectQuery, List<FrequentDefectDto>>
    {
        private readonly IMapper mapper;
        private readonly IApplicationDbContext applicationDbContext;

        public GetFrequentDefectQueryHandler(IApplicationDbContext applicationDbContext,IMapper mapper)
        {
            this.mapper = mapper;
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<List<FrequentDefectDto>> Handle(GetFrequentDefectQuery request, CancellationToken cancellationToken)
        {
            return await applicationDbContext.FrequentDefects.ProjectTo<FrequentDefectDto>(mapper.ConfigurationProvider)
                .OrderBy(x => x.LastModified).ToListAsync();
        }
    }
}
