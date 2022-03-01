using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MovieAPI.Model
{
    [Serializable]
    [DataContract]
    public class MovieInfo
    {
        [DataMember(Name = "Directors")]
        public IList<string> Directors { get; set; }

        [DataMember(Name = "release_date")]
        [JsonConverter(typeof(DateFormatConverter), "yyyy-MM-dd'T'HH:mm:ss.FFFK")]
        public DateTime ReleaseDate { get; set; }

        [DataMember(Name = "Rating")]
        public double Rating { get; set; }

        [DataMember(Name = "Genres")]
        public IList<string> Genres { get; set; }

        [DataMember(Name = "image_url")]
        public string ImageURL { get; set; }

        [DataMember(Name = "Plot")]
        public string Plot { get; set; }

        [DataMember(Name = "running_time_secs")]
        public int RunningTime { get; set; }

        [DataMember(Name = "Rank")]
        public int Rank { get; set; }

        [DataMember(Name = "Actors")]
        public IList<string> Actors { get; set; }
    }
}
