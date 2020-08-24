using System;
using System.Collections.Generic;
using MediatR;

namespace CleanArchitecture.Application.FrequentDefect.Queries.GetFrequentDefect
{
    public class GetFrequentDefectQuery:IRequest<List<FrequentDefectDto>>
    {
        public GetFrequentDefectQuery()
        {
        }
    }
}
