using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public class FrequentDefect: AuditableEntity
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
