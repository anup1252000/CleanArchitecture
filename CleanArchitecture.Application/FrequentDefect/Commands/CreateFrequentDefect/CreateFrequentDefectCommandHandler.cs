using System.Threading;
using System.Threading.Tasks;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.FrequentDefect.Commands.CreateFrequentDefect
{
    public class CreateFrequentDefectCommandHandler:IRequestHandler<CreateFrequentDefectCommand,int>
    {
        private readonly IApplicationDbContext applicationDbContext;

        public CreateFrequentDefectCommandHandler(IApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<int> Handle(CreateFrequentDefectCommand request, CancellationToken cancellationToken)
        {
            var frequentDefect = new Domain.Entities.FrequentDefect
            {
                Title = request.Title,
                Content = request.Content
            };
            await applicationDbContext.FrequentDefects.AddAsync(frequentDefect);
            await applicationDbContext.SaveChangesAsync(cancellationToken);
            return frequentDefect.Id;
        }
    }
}
