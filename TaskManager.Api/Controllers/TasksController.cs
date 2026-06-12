using MediatR;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.Features.Tasks.Commands.CreateTask;
using TaskManager.Application.Features.Tasks.Commands.DeleteTask;
using TaskManager.Application.Features.Tasks.Commands.UpdateTask;
using TaskManager.Application.Features.Tasks.Queries.GetAllTasks;
using TaskManager.Application.Features.Tasks.Queries.GetTaskById;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create(
            CreateTaskCommand command)
        {
            var result =
                await _mediator.Send(command);

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllTasksQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetTaskByIdQuery(id));

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateTaskCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result)
                return NotFound();

            return Ok(new
            {
                Message = "Task updated successfully"
            });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteTaskCommand(id));

            if (!result)
                return NotFound(new
                {
                    Message = "Task not found"
                });

            return Ok(new
            {
                Message = "Task deleted successfully"
            });
        }
    }
}