using Models.Model.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model.Episode
{

    public class EpisodeResult : BaseMain
    {
        public List<Episode> results { get; set; }
    }
    public class Episode:BaseMovie
    {
        [JsonProperty("AirDate")]
        public string AirDate { get; set; }

        [JsonProperty("Episode")]
        public string EpisodeNumber { get; set; }

        List<string> Characters { get; set; }


       

    }
}
