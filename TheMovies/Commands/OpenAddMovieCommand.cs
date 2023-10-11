using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Stores;
using TheMovies.ViewModels;

namespace TheMovies.Commands
{
    public class OpenAddMovieCommand : CommandBase
    {

        private readonly ModelNavigationStore _modelNavigationStore;

        public OpenAddMovieCommand(ModelNavigationStore modelNavigationStore)
        {
            _modelNavigationStore = modelNavigationStore;
        }

        public override void Execute(object parameter)
        {
            AddMovieViewModel addMovieViewModel = new AddMovieViewModel();

            _modelNavigationStore.CurrentViewModel = addMovieViewModel;
        }
    }
}
