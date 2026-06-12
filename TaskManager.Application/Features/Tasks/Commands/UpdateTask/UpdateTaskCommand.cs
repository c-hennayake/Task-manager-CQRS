using MediatR;

namespace TaskManager.Application.Features.Tasks.Commands.UpdateTask
{
    public class UpdateTaskCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}