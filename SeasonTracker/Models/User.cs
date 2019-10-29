using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SeasonTracker.Models
{
    public class User : INotifyPropertyChanged
    {
        private int _id;

        //[PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set 
            { 
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _username;

        [MaxLength(50)]
        public string Username
        {
            get { return _username; }
            set 
            { 
                _username = value;
                OnPropertyChanged("Username");
            }
        }

        private string _email;

        [MaxLength(50)]
        public string Email
        {
            get { return _email; }
            set 
            { 
                _email = value;
                OnPropertyChanged("Email");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
