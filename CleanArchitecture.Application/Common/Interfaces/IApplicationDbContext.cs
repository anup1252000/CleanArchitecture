using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.FrequentDefect> FrequentDefects { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
