using MediatR;

namespace CleanArchitecture.Application.FrequentDefect.Commands.CreateFrequentDefect
{
    public class CreateFrequentDefectCommand:IRequest<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
