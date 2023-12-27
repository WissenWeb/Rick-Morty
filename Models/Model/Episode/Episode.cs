using Models.Model.Base;
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
        public string Air_Date { get; set; }

        public string EpisodeNumber { get; set; }

        List<string> Characters { get; set; }


       

    }
}
