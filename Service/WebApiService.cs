using Models.Model.Episode;
using Models.Model.Location;
using Repository;
using Rick_Morty.Model.Character;

namespace Service
{
    public class WebApiService : IWebApiService
    {
        public IWebApiCharacterRepository _webapiCharacterRepository;
        public IWebApiLocationRepository _webApiLocationRepository;
        public IWebApiEpisodeRepository _webapiEpisodeRepository;


        public WebApiService(IWebApiCharacterRepository webApiCharacterRepository, IWebApiLocationRepository webApiLocationRepository, IWebApiEpisodeRepository webapiEpisodeRepository)
        {

            _webapiCharacterRepository = webApiCharacterRepository;
            _webApiLocationRepository = webApiLocationRepository;
            _webapiEpisodeRepository = webapiEpisodeRepository;
        }
        public CharacterResult GetAllCharacter()
        {

            var character = _webapiCharacterRepository.GetAllCharacter();
            return character;

        }
        public Character GetSingleCharacter(int id)
        {

            var character = _webapiCharacterRepository.GetSingleCharacter(id);
            return character;
        }

        public LocationResult GetAllLocation()
        {

            var locationResult = _webApiLocationRepository.GetAllLocation();
            return locationResult;
        }
        public Location GetSingleLocation(int id)
        {

            var location = _webApiLocationRepository.GetSingleLocation(id);
            return location;

        }

        public EpisodeResult GetAllEpisode()
        {
            var episodeResult = _webapiEpisodeRepository.GetAllEpisode();
            return episodeResult;
        }
        public Episode GetSingleEpisode(int id)
        {
            var episode = _webapiEpisodeRepository.GetSingleEpisode(id);
            return episode;
        }

    }
    public interface IWebApiService
    {

        public CharacterResult GetAllCharacter();
        public Character GetSingleCharacter(int id);
        public Location GetSingleLocation(int id);
        public LocationResult GetAllLocation();
        public EpisodeResult GetAllEpisode();
        public Episode GetSingleEpisode(int id);


    }
}