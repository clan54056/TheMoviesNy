using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Stores;
using TheMovies.ViewModel;

namespace TheMovies.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModelNavigationStore _modelNavigationStore;

        public MovieViewModel MovieViewModel { get; }

        public MainViewModel(ModelNavigationStore modelNavigationStore, MovieViewModel movieViewModel)
        {
            _modelNavigationStore = modelNavigationStore;
            MovieViewModel = movieViewModel;
        }

        
    }
}
