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

    public interface IWebApiLocationRepository
    {

        public LocationResult GetAllLocation();
        public Location GetSingleLocation(int id);
        public LocationResult LocationFilter(LocationFilter filters);

    }
    public class WebApiLocationRepository:IWebApiLocationRepository
    {
 
        const string LocationUrl = "https://rickandmortyapi.com/api/location";

        public LocationResult GetAllLocation()
        {
            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<LocationResult>(new GenerateResultParameters() { Url = LocationUrl });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
        public Location GetSingleLocation(int id)
        {


            var url = LocationUrl + "/" + id;

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<Location>(new GenerateResultParameters { Url = url });

            return result;

        }
        public LocationResult LocationFilter(LocationFilter filters)
        {
            string url = LocationUrl + "/";
            if (!string.IsNullOrEmpty(filters.Name))
                url += "?name=" + filters.Name;
            if (!string.IsNullOrEmpty(filters.Type))
                url += "?type=" + filters.Type;

            if (!string.IsNullOrEmpty(filters.Dimension))
                url += "?dimension=" + filters.Dimension;


            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<LocationResult>(new GenerateResultParameters() { Url = url });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
    }
}
