using MediatR;
using TaskManager.Application.Abstractions.Persistence;

namespace TaskManager.Application.Features.Tasks.Commands.DeleteTask
{
    public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand, bool>
    {
        private readonly ITaskRepository _taskRepository;

        public DeleteTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> Handle(
            DeleteTaskCommand request,
            CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetByIdAsync(request.Id);

            if (task == null)
                return false;

            await _taskRepository.DeleteAsync(request.Id);

            return true;
        }
    }
}