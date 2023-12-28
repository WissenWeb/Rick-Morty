using Models.Filter;
using Models.Model.Repository;
using Rick_Morty.Model.Character;
using System.IO.MemoryMappedFiles;

namespace Repository
{

    public interface IWebApiCharacterRepository
    {
        public CharacterResult GetAllCharacter();
        public Character GetSingleCharacter(int id);
        public CharacterResult CharacterFilter(CharacterFilter filters);
        public List<Character> GetMultipleCharacter(List<int> ids);

    }

    public class WebApiCharacterRepository : IWebApiCharacterRepository
    {
        const string CharacterUrl = "https://rickandmortyapi.com/api/character";


        public CharacterResult GetAllCharacter()
        {
            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<CharacterResult>(new GenerateResultParameters() { Url = CharacterUrl });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
        public Character GetSingleCharacter(int id)
        {


            var url = CharacterUrl + "/" + id;

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<Character>(new GenerateResultParameters { Url = url });

            return result;

        }
        public List<Character> GetMultipleCharacter(List<int> ids)
        {

            var url = CharacterUrl + "/" + string.Join(",", ids);

            WebApiHelper helper = new WebApiHelper();

            var result = helper.GenereteResult<List<Character>>(new GenerateResultParameters { Url = url });
            return result;

        }
        public CharacterResult CharacterFilter(CharacterFilter filters)
        {
            string url = CharacterUrl + "/";
            if (!string.IsNullOrEmpty(filters.Name))
                url += "?name=" + filters.Name;
            if (!string.IsNullOrEmpty(filters.Gender))
                url += "?gender=" + filters.Gender;
            if (!string.IsNullOrEmpty(filters.Status))
                url += "?status=" + filters.Status;
            if (!string.IsNullOrEmpty(filters.Type))
                url += "?type=" + filters.Type;
            if (!string.IsNullOrEmpty(filters.Species))
                url += "?species=" + filters.Species;

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<CharacterResult>(new GenerateResultParameters() { Url = url });


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }


    }
}