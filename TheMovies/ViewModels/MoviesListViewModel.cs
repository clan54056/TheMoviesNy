using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Stores;

namespace TheMovies.ViewModels
{
    public class MoviesListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<MoviesListItemViewModel> _moviesListItemViewModels;

        public IEnumerable<MoviesListItemViewModel> MoviesListItemViewModels => _moviesListItemViewModels;

        public MoviesListViewModel(SelectedMovieStore _selectedMovieStore)
        {
            _moviesListItemViewModels = new ObservableCollection<MoviesListItemViewModel>();

            _moviesListItemViewModels.Add(new MoviesListItemViewModel("test 1"));
            _moviesListItemViewModels.Add(new MoviesListItemViewModel("test 2"));
            _moviesListItemViewModels.Add(new MoviesListItemViewModel("test 3"));
        }
    }
}
