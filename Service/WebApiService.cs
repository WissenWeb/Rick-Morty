using Models.Filter;
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

        #region Character
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
        public CharacterResult CharacterFilter(CharacterFilter filter)
        {

            var characterResult = _webapiCharacterRepository.CharacterFilter(filter);
            return characterResult;
        }

        public List<Character> GetMultipleCharacter(List<int> ids)
        {

            var characterResult = _webapiCharacterRepository.GetMultipleCharacter(ids);
            return characterResult;
        }
        #endregion

        #region Location
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

        public LocationResult LocationFilter(LocationFilter filter)
        {
            var locationResult = _webApiLocationRepository.LocationFilter(filter);
            return locationResult;
        }
        #endregion

        #region Episode
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

        public List<Location> GetMultipleLocation(List<int> ids)
        {

            var locationResult = _webApiLocationRepository.GetMultipleLocation(ids);
            return locationResult;

        }
        public EpisodeResult EpisodeFilter(EpisodeFilter filter)
        {

            var episodeResult = _webapiEpisodeRepository.EpisodeFilter(filter);
            return episodeResult;

        }
        public List<Episode> GetMultipleEpisode(List<int> ids)
        {


            var episodeResult = _webapiEpisodeRepository.GetMultipleEpisode(ids);
            return episodeResult;

        }
        #endregion
    }
    public interface IWebApiService
    {

        public CharacterResult GetAllCharacter();
        public Character GetSingleCharacter(int id);
        public Location GetSingleLocation(int id);
        public LocationResult GetAllLocation();
        public EpisodeResult GetAllEpisode();
        public Episode GetSingleEpisode(int id);
        public CharacterResult CharacterFilter(CharacterFilter filter);
        public LocationResult LocationFilter(LocationFilter filter);

        public EpisodeResult EpisodeFilter(EpisodeFilter filter);

        public List<Character> GetMultipleCharacter(List<int> ids);
        public List<Location> GetMultipleLocation(List<int> ids);
        public List<Episode> GetMultipleEpisode(List<int> ids);


    }
}