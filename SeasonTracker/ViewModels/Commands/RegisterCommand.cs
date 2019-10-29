using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SeasonTracker.ViewModels.Commands
{
    public class RegisterCommand : ICommand
    {
        //The viewmodel this command will be active on
        public LoginViewModel VM { get; set; }

        public event EventHandler CanExecuteChanged;

        public RegisterCommand(LoginViewModel vm)
        {
            VM = VM;
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
