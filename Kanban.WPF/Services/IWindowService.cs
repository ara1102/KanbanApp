using Kanban.WPF.Entities;

namespace Kanban.WPF.Services
{
    public interface IWindowService
    {
        void ShowMain();
        void ShowBoard(Board board);
        void ShowMainCloseBoard();
    }
}