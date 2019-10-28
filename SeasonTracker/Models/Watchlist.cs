using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SeasonTracker.Models
{
    public class Watchlist : INotifyPropertyChanged
    {
        private int _id;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged("Id"); }
        }

        private int _userId;

        [Indexed]   //Foreign key for User model
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; OnPropertyChanged("UserId"); }
        }

        private string _tvShowName;

        public string TvShowName
        {
            get { return _tvShowName; }
            set { _tvShowName = value; OnPropertyChanged("TvShowName"); }
        }

        private string _season;

        public string Season
        {
            get { return _season; }
            set { _season = value; OnPropertyChanged("Season"); }
        }

        private string _numberOfEpisodes;

        public string NumberOfEpisodes
        {
            get { return _numberOfEpisodes; }
            set { _numberOfEpisodes = value; OnPropertyChanged("NumberOfEpisodes"); }
        }

        private string _episodeViewList;

        public string EpisodeViewlist
        {
            get { return _episodeViewList; }
            set { _episodeViewList = value; OnPropertyChanged("EpisodeViewList"); }
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
