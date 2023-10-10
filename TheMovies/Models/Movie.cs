using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Movie
    {
        public string Title { get; }
        public int Length { get; }
        public string Genre { get; }        
        
        public Movie(string title, int length, string genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
