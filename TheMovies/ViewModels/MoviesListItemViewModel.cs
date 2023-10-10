using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TheMovies.ViewModel;

namespace TheMovies.ViewModels
{
    public class MoviesListItemViewModel : ViewModelBase
    {
        public string Title { get; set; }
        public int Length{ get; set; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }

        public MoviesListItemViewModel(string title) 
        {
            Title = title;
        }
    }
}
