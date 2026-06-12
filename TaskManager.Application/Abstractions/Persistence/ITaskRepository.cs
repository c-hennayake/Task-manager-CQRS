using TaskManager.Domain.Entities;

namespace TaskManager.Application.Abstractions.Persistence
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllAsync();


        Task<List<TaskItem>> GetPagedTasksAsync(
    int pageNumber,
    int pageSize,
    string? search,
    bool? isCompleted);


        Task<TaskItem?> GetByIdAsync(int id);

        Task AddAsync(TaskItem task);

        Task UpdateAsync(TaskItem task);

        Task DeleteAsync(int id);
    }
}