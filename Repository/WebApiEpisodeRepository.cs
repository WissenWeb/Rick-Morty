using Models.Model.Episode;
using Models.Model.Repository;
using Rick_Morty.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IWebApiEpisodeRepository
    {
        public EpisodeResult GetAllEpisode();
        public Episode GetSingleEpisode(int id);


    }
    public class WebApiEpisodeRepository : IWebApiEpisodeRepository
    {
        const string EpisodeUrl = "https://rickandmortyapi.com/api/episode";


        public EpisodeResult GetAllEpisode()
        {
            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<EpisodeResult>(new GenerateResultParameters() { Url = EpisodeUrl });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
        public Episode GetSingleEpisode(int id)
        {


            var url = EpisodeUrl + "/" + id;

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<Episode>(new GenerateResultParameters { Url = url });

            return result;

        }
    }
}
