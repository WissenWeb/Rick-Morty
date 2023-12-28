using Models.Model.Repository;
using Newtonsoft.Json;
using RestSharp;
using Rick_Morty.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WebApiHelper
    {

      

        public T GenereteResult<T>(GenerateResultParameters parameters)
        {
            RestSharp.RestClient cli = new RestSharp.RestClient(parameters.Url);
            RestRequest request = new RestRequest();
            request.Method = Method.Get;
            var result = cli.Execute(request);
            T t = JsonConvert.DeserializeObject<T>(result.Content);
            return t;


        }
    }
}
