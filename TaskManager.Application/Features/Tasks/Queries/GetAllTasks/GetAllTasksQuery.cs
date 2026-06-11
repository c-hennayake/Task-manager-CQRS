using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Features.Tasks.DTOs;

namespace TaskManager.Application.Features.Tasks.Queries.GetAllTasks
{

    public record GetAllTasksQuery : IRequest<List<TaskDto>>;
}
