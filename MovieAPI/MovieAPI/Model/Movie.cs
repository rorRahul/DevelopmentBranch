using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MovieAPI.Model
{
    [Serializable]
    [DataContract]
    public class Movie
    {
        [DataMember(Name = "Year")]
        public int Year { get; set; }

        [DataMember(Name = "Title")]
        public string Title { get; set; }

        [DataMember(Name = "Info")]
        public MovieInfo Info { get; set; }
    }
}
