using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SeasonTracker.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginViewModel VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public LoginCommand(LoginViewModel vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: register functionality
        }
    }
}
