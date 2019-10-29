using Microsoft.EntityFrameworkCore;
using SeasonTracker.Models;
using SeasonTracker.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SeasonTracker.ViewModels
{
    //What we want to do in this ViewModel:
    //  1. List the watchlists
    //  2. Commands like create new watchlists
    public class DashboardViewModel
    {
        private readonly ApplicationDbContext _db;

        public ObservableCollection<Watchlist> Watchlists { get; set; }

        private Watchlist _selectedWatchlist;

        public Watchlist SelectedWatchlist
        {
            get { return _selectedWatchlist; }
            set 
            { 
                _selectedWatchlist = value; 
                //Todo: get the watchlists for all tv shows
            }
        }

        public MyListCommand MyListCommand { get; set; }
        public NewWatchlistCommand NewWatchlistCommand { get; set; }

        //Constructor
        public DashboardViewModel()
        {
            NewWatchlistCommand = new NewWatchlistCommand(this);
            MyListCommand = new MyListCommand(this);

            _db = new ApplicationDbContext();
        }

        public void CreateWatchlist(int userId)
        {
            Watchlist newWatchlist = new Watchlist()
            {
                //TODO: User id goes here
                UserId = userId,
                TvShowName = "Big Bang Theory",
                Season = "1",
                NumberOfEpisodes = "20",
                EpisodeViewlist = new string('N', 20)
            };

            //TODO: LEFT OFF HERE. Code is not getting here.
            if (_db != null)
            {
                _db.Watchlists.Add(newWatchlist);
                _db.SaveChanges();
            }
            //DatabaseHelper.Insert(newWatchlist);
        }
    }
}
