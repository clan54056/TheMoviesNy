using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;
using TheMovies.Stores;
using TheMovies.ViewModel;

namespace TheMovies.ViewModels
{
    public class MoviesDetailsViewModel : ViewModelBase
    {
        private readonly SelectedMovieStore _selectedMovieStore;

        private Movie SelectedMovie => _selectedMovieStore.SelectedMovie;


        public bool HasSelectedMovie => SelectedMovie != null;
        public string Title => SelectedMovie?.Title ?? "Unknown";
        public int Length => SelectedMovie?.Length ?? 0;
        public string Genre => SelectedMovie?.Genre ?? "Unknown";

        public MoviesDetailsViewModel(SelectedMovieStore selectedMovieStore)
        {

            this._selectedMovieStore = selectedMovieStore;
        }

    }
}
