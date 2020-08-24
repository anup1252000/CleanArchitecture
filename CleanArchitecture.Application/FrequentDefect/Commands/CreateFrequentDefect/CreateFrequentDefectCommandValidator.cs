using System;
using FluentValidation;

namespace CleanArchitecture.Application.FrequentDefect.Commands.CreateFrequentDefect
{
    public class CreateFrequentDefectCommandValidator:AbstractValidator<CreateFrequentDefectCommand>
    {
        public CreateFrequentDefectCommandValidator()
        {
            RuleFor(expression => expression.Title).NotEmpty();
            RuleFor(expression => expression.Content).NotEmpty();
        }
    }
}
