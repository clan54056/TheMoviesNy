using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TheMovies.Stores;
using TheMovies.ViewModel;
using TheMovies.ViewModels;

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ModelNavigationStore _modelNavigationStore;
        private readonly SelectedMovieStore _selectedMovieStore;

        public App()
        {
            _modelNavigationStore = new ModelNavigationStore();
            _selectedMovieStore = new SelectedMovieStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MovieViewModel movieViewModel = new MovieViewModel(_selectedMovieStore, _modelNavigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_modelNavigationStore, movieViewModel)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
