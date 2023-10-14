using Kanban.WPF.Entities;
using Kanban.WPF.ViewModels;
using Kanban.WPF.Views;

namespace Kanban.WPF.Services
{
    public class WindowService : IWindowService
    {
        private MainWindow _mainWindow;
        private BoardWindow _boardWindow;

        public void ShowMain()
        {
            _mainWindow = new MainWindow {DataContext = new MainViewModel()};
            _mainWindow.Show();
        }

        public void ShowBoard(Board board)
        {
            _boardWindow = new BoardWindow();
            _boardWindow.DataContext = new BoardViewModel {BoardWindow = _boardWindow, Board = board};
            _boardWindow.Show();
            _mainWindow.Close();
        }

        public void ShowMainCloseBoard()
        {
            ShowMain();
            _boardWindow.Close();
        }

    }
}