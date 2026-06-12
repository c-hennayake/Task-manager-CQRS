using FluentValidation;

namespace TaskManager.Application.Features.Tasks.Commands.UpdateTask
{
    public class UpdateTaskCommandValidator
        : AbstractValidator<UpdateTaskCommand>
    {
        public UpdateTaskCommandValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.Description)
                .MaximumLength(500);
        }
    }
}