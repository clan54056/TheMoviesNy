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

            _selectedMovieStore = selectedMovieStore;

            _selectedMovieStore.SelectedMovieChanged += _selectedMovieStore_SelectedMovieChanged;
        }

        protected override void Dispose()
        {
            _selectedMovieStore.SelectedMovieChanged -= _selectedMovieStore_SelectedMovieChanged;
            base.Dispose();
        }

        private void _selectedMovieStore_SelectedMovieChanged()
        {
            OnPropertyChanged(nameof(HasSelectedMovie));
            OnPropertyChanged(nameof(Title));
            OnPropertyChanged(nameof(Length));
            OnPropertyChanged(nameof(Genre));
        }
    }
}
