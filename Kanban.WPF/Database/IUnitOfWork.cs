using Kanban.WPF.Entities;
using System;

namespace Kanban.WPF.Database
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Board> Boards { get; }
    }
}