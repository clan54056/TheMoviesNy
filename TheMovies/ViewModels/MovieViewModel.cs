using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Stores;
using TheMovies.ViewModels;

namespace TheMovies.ViewModel
{
    public class MovieViewModel : ViewModelBase
    {
        public MoviesListViewModel MoviesListViewModel { get; }
        public MoviesDetailsViewModel MoviesDetailsViewModel { get; }

        public ICommand AddMovieCommand { get; }

        public MovieViewModel(SelectedMovieStore _selectedMovieStore)
        {
            MoviesListViewModel = new MoviesListViewModel(_selectedMovieStore);
            MoviesDetailsViewModel = new MoviesDetailsViewModel(_selectedMovieStore);
        }
    }
}
