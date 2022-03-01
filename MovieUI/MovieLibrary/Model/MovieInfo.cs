using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLibrary.Model
{
    [Serializable]
    public class MovieInfo
    {
        public IList<string> Directors { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Rating { get; set; }
        public IList<string> Genres { get; set; }
        public string ImageURL { get; set; }
        public string Plot { get; set; }
        public int RunningTime { get; set; }
        public int Rank { get; set; }
        public IList<string> Actors { get; set; }
    }
}
