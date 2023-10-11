using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;
using TheMovies.Stores;

namespace TheMovies.ViewModels
{
    public class MoviesListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<MoviesListItemViewModel> _moviesListItemViewModels;
        private readonly SelectedMovieStore _selectedMovieStore;

        public IEnumerable<MoviesListItemViewModel> MoviesListItemViewModels => _moviesListItemViewModels;

        private MoviesListItemViewModel _selectedMovieListItemViewModel;

        public MoviesListItemViewModel SelectedMovieListItemViewModel
        {
            get 
            { 
                return _selectedMovieListItemViewModel; 
            }
            set 
            { 
                _selectedMovieListItemViewModel = value; 
                OnPropertyChanged(nameof(SelectedMovieListItemViewModel));

                _selectedMovieStore.SelectedMovie = _selectedMovieListItemViewModel?.Movie;
            }
        }


        public MoviesListViewModel(SelectedMovieStore selectedMovieStore)
        {
            _selectedMovieStore = selectedMovieStore;
            _moviesListItemViewModels = new ObservableCollection<MoviesListItemViewModel>();
            
            _moviesListItemViewModels.Add(new MoviesListItemViewModel(new Movie("test 1", 120, "Vild Nok")));
            _moviesListItemViewModels.Add(new MoviesListItemViewModel(new Movie("test 2", 60, "OK")));
            _moviesListItemViewModels.Add(new MoviesListItemViewModel(new Movie("test 3", 140, "Gal Nok")));
            
        }
    }
}
