using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Abstractions.Persistence
{
    public interface IUnitOfWork
    {
        ITaskRepository Tasks { get; }

        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);
    }
}
