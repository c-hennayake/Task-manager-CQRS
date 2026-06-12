using MediatR;
using TaskManager.Application.Abstractions.Persistence;
using TaskManager.Application.Features.Tasks.DTOs;

namespace TaskManager.Application.Features.Tasks.Queries.GetAllTasks
{
    public class GetAllTasksHandler
        : IRequestHandler<GetAllTasksQuery, List<TaskDto>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetAllTasksHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskDto>> Handle(
            GetAllTasksQuery request,
            CancellationToken cancellationToken)
        {
            var tasks = await _taskRepository.GetPagedTasksAsync(
                request.PageNumber,
                request.PageSize,
                request.Search,
                request.IsCompleted);

            return tasks.Select(x => new TaskDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                IsCompleted = x.IsCompleted
            }).ToList();
        }
    }
}