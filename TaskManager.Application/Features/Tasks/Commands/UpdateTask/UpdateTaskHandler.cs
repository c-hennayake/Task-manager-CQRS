using MediatR;
using TaskManager.Application.Abstractions.Persistence;

namespace TaskManager.Application.Features.Tasks.Commands.UpdateTask
{
    public class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand, bool>
    {
        private readonly ITaskRepository _taskRepository;

        public UpdateTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> Handle(
            UpdateTaskCommand request,
            CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetByIdAsync(request.Id);

            if (task == null)
                return false;

            task.Title = request.Title;
            task.Description = request.Description;
            task.IsCompleted = request.IsCompleted;

            await _taskRepository.UpdateAsync(task);

            return true;
        }
    }
}