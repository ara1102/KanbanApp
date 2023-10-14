using Kanban.WPF.Commands;
using System;
using System.Windows.Input;

namespace Kanban.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NewBoardCommand { get; }

        public HomeViewModel(Action goNewBoarView)
        {
            NewBoardCommand = new RelayCommand(o => goNewBoarView(), o => true);
        }
    }
}