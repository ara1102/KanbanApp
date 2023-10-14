using System;
using Kanban.WPF.Entities;
using Kanban.WPF.ViewModels;
using Syncfusion.UI.Xaml.Kanban;

namespace Kanban.WPF.Views
{
    public partial class BoardWindow
    {
        public BoardWindow()
        {
            InitializeComponent();
        }

        private void SfKanban_OnCardTapped(object sender, KanbanTappedEventArgs e)
        {
            var viewModel = (BoardViewModel) DataContext;
            viewModel.SelectedTask = (Task) e.SelectedCard.Content;
            viewModel.TaskViewWidth = 250;
            ClearTaskTagEntry();
        }


        public void ClearTaskTagEntry()
        {
            TaskTagTextBox.Text = "";
        }

        private void BoardWindow_OnClosed(object sender, EventArgs e)
        {
            var viewModel = (BoardViewModel) DataContext;
            viewModel.SaveBoard(null);
        }

    }
}