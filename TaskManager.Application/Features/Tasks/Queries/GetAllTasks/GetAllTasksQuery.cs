using MediatR;
using TaskManager.Application.Features.Tasks.DTOs;

namespace TaskManager.Application.Features.Tasks.Queries.GetAllTasks
{
    public class GetAllTasksQuery : IRequest<List<TaskDto>>
    {
        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public string? Search { get; set; }

        public bool? IsCompleted { get; set; }
    }
}