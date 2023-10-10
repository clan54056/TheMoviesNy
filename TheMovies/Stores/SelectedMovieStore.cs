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
		private Movie _movie;

		public Movie SelectedMovie
		{
			get 
			{ 
				return _movie; 
			}
			set 
			{ 
				_movie = value;
				SelectedMovieChanged?.Invoke();
			}
		}

		public event Action SelectedMovieChanged;

	}
}
