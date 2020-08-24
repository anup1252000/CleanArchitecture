using System;
using CleanArchitecture.Application.Common.Mappings;

namespace CleanArchitecture.Application.FrequentDefect.Queries.GetFrequentDefect
{
    public class FrequentDefectDto:IMapFrom<Domain.Entities.FrequentDefect>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime LastModified { get; set; }
    }
}
