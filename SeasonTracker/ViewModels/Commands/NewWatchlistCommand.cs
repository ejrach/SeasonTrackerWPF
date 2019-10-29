using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SeasonTracker.ViewModels.Commands
{
    public class NewWatchlistCommand : ICommand
    {
        public DashboardViewModel VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewWatchlistCommand(DashboardViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: create new watchlist
            //temp
            int userId = 1;
            VM.CreateWatchlist(userId);
        }
    }
}
