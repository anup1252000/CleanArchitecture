using MediatR;

namespace CleanArchitecture.Application.FrequentDefect.Commands.DeleteFrequentDefect
{
    public class DeleteFrequentDefectCommand:IRequest
    {
        public int Id { get; set; }
    }
}
