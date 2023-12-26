using Models.Model.Repository;
using Rick_Morty.Model.Character;


namespace Repository
{

    public interface IWebApiRepository
    {
        public CharacterResult GetAllCharacter();
        public Character GetSingleCharacter(int id);

    }

    public class WebApiRepository : IWebApiRepository
    {
        const string CharacterUrl = "https://rickandmortyapi.com/api/character";
        const string LocationUrl = "https://rickandmortyapi.com/api/location";
        const string EpisodesUrl = "https://rickandmortyapi.com/api/episode";

        public CharacterResult GetAllCharacter()
        {
            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<CharacterResult>(new GenerateResultParameters() { Url=CharacterUrl});


            //var next = result.info.Next;
            //next = result.info.Next.Replace("https://rickandmortyapi.com", "http://localhost:7012");
            //result.info.Next = next;
            return result;
        }
        public Character GetSingleCharacter(int id)
        {


            var url = CharacterUrl+"/"+id;

            WebApiHelper helper = new WebApiHelper();
            var result = helper.GenereteResult<Character>(new GenerateResultParameters {  Url=url});

            return result;

        }
    }
}