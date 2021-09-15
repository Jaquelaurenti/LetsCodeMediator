using FluentValidation;
using MediatorSimples.Application.Commands;

namespace MediatorSimples.Application.Validators
{
    public class InsereRebeldeCommandValidator: AbstractValidator<InsereRebeldeCommand>
    {
        public InsereRebeldeCommandValidator()
        {
            RuleFor(command => command.Rebelde).NotNull();
        }
    }
}