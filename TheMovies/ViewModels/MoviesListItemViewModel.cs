using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.Models;
using TheMovies.ViewModel;

namespace TheMovies.ViewModels
{
    public class MoviesListItemViewModel : ViewModelBase
    {

        public Movie Movie { get; }

        public string Title => Movie.Title;

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }


        public MoviesListItemViewModel(Movie movie)
        {
            Movie = movie;
        }
    }
}
