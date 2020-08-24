using System;
using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.FrequentDefect.Commands.DeleteFrequentDefect
{
    public class DeleteFrequentDefectCommandHandler : IRequestHandler<DeleteFrequentDefectCommand>
    {
        private readonly IApplicationDbContext applicationDbContext;

        public DeleteFrequentDefectCommandHandler(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [Obsolete("Delete Frequent defect null need to be handled")]
        public async Task<Unit> Handle(DeleteFrequentDefectCommand request, CancellationToken cancellationToken)
        {
            var frequentDefect = await applicationDbContext.FrequentDefects.FindAsync(request.Id);
            if(frequentDefect==null)
            {

            }

            applicationDbContext.FrequentDefects.Remove(frequentDefect);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
