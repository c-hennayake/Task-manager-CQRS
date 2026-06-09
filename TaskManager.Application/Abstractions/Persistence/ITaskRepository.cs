using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Abstractions.Persistence
{
    public interface ITaskRepository
    {
        Task<TaskItem?> GetByIdAsync(int id);

        Task<List<TaskItem>> GetAllAsync();

        Task AddAsync(TaskItem task);

        void Update(TaskItem task);

        void Delete(TaskItem task);
    }
}
