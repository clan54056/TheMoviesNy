﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.ViewModels;

namespace TheMovies.Stores
{
    public class ModelNavigationStore
    {
		private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
		{
			get 
			{ 
				return _currentViewModel; 
			}
			set 
			{
                _currentViewModel = value;
				CurrentViewModelChanged?.Invoke();
			}
		}

        public bool IsOpen => CurrentViewModel != null;

        public event Action CurrentViewModelChanged;




    }
}
