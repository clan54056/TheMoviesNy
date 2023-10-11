using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TheMovies.ViewModels
{
    public class MovieDetailsFormViewModel : ViewModelBase
    {
		private string _title;

		public string Title
		{
			get 
			{ 
				return _title; 
			}
			set 
			{ 
				_title = value;
				OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(CanSubmit));
			}
		}

        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
                OnPropertyChanged(nameof(Length));
            }
        }

        private int _genre;
        public int Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                _genre = value;
                OnPropertyChanged(nameof(Genre));
            }
        }

        public bool CanSubmit => !string.IsNullOrEmpty(_title);
        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

    }
}
