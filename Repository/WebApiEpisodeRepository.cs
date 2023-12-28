using Models.Filter;
using Models.Model.Episode;
using Models.Model.Location;
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
        public EpisodeResult EpisodeFilter(EpisodeFilter filters);
        public List<Episode> GetMultipleEpisode(List<int> ids);


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
        public EpisodeResult EpisodeFilter(EpisodeFilter filters)
        {
            string url = EpisodeUrl + "/";
            if (!string.IsNullOrEmpty(filters.Name))
                url += "?name=" + filters.Name;
            if (!string.IsNullOrEmpty(filters.Episode))
                url += "?episode=" + filters.Episode;
            

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<EpisodeResult>(new GenerateResultParameters() { Url = url });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
        public List<Episode> GetMultipleEpisode(List<int> ids)
        {


            var url = EpisodeUrl + "/" + string.Join(",", ids);

            WebApiHelper helper = new WebApiHelper();

            var result = helper.GenereteResult<List<Episode>>(new GenerateResultParameters { Url = url });
            return result;

        }
    }
}
