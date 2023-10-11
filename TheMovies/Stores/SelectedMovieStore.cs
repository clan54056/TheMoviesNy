using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TheMovies.Models;

namespace TheMovies.Stores
{
    public class SelectedMovieStore
    {
		private Movie _selectedMovie;

		public Movie SelectedMovie
		{
			get 
			{ 
				return _selectedMovie; 
			}
			set 
			{ 
				_selectedMovie = value;
				SelectedMovieChanged?.Invoke();
			}
		}

		public event Action SelectedMovieChanged;

	}
}
