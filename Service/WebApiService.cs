using Repository;
using Rick_Morty.Model.Character;

namespace Service
{
    public class WebApiService : IWebApiService
    {


        public IWebApiRepository _webapiRepository;


        public WebApiService(IWebApiRepository webApiRepository)
        {

            _webapiRepository = webApiRepository;

        }
        public CharacterResult GetAllCharacter()
        {

            var character = _webapiRepository.GetAllCharacter();
            return character;

        }
        public Character GetSingleCharacter(int id)
        {

            var character = _webapiRepository.GetSingleCharacter(id);
            return character;
        }

    }
    public interface IWebApiService
    {

        public CharacterResult GetAllCharacter();
        public Character GetSingleCharacter(int id);


    }
}