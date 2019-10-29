using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SeasonTracker.ViewModels.Commands
{
    public class MyListCommand : ICommand
    {
        public DashboardViewModel VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public MyListCommand(DashboardViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: view watchlists 
        }
    }
}
