using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Model
{
    [Serializable]
    public class Movie
    {
        public int Year { get; set; }
        public string Title { get; set; }
        public MovieInfo Info { get; set; }
    }
}
