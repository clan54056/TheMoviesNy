using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Stores;
using TheMovies.ViewModel;

namespace TheMovies.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ModelNavigationStore _modelNavigationStore;

        public ViewModelBase CurrentModelViewModel => _modelNavigationStore.CurrentViewModel;
        public bool IsModelOpen => _modelNavigationStore.IsOpen;

        public MovieViewModel MovieViewModel { get; }

        public MainViewModel(ModelNavigationStore modelNavigationStore, MovieViewModel movieViewModel)
        {
            _modelNavigationStore = modelNavigationStore;
            MovieViewModel = movieViewModel;

            _modelNavigationStore.CurrentViewModelChanged += ModelNavigationStore_CurrentViewModelChanged;
        }


        protected override void Dispose()
        {
            _modelNavigationStore.CurrentViewModelChanged -= ModelNavigationStore_CurrentViewModelChanged;
            base.Dispose();
        }

        private void ModelNavigationStore_CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModelViewModel));
            OnPropertyChanged(nameof(IsModelOpen));
        }



    }
}
