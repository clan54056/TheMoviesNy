using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TheMovies.Stores;
using TheMovies.ViewModel;

namespace TheMovies
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedMovieStore _selectedMovieStore;

        public App()
        {
            _selectedMovieStore = new SelectedMovieStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new AddMovieViewModel(_selectedMovieStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
