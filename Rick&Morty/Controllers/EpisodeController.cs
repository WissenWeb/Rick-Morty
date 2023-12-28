using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Filter;
using Service;

namespace Rick_Morty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        public IWebApiService _webapiService;
        public EpisodeController(IWebApiService webApiService)
        {
            _webapiService = webApiService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var character = _webapiService.GetAllEpisode();
            return Ok(character);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var character = _webapiService.GetSingleEpisode(id);

            return Ok(character);
        }
        [HttpPost]
        [Route("Filter")]
        public IActionResult Get(EpisodeFilter filter)
        {
            var episodeResult = _webapiService.EpisodeFilter(filter);

            return Ok(episodeResult);
        }

        [HttpPost]
        [Route("Multiple")]
        public IActionResult Get(List<int> ids)
        {
            var episodeResult = _webapiService.GetMultipleEpisode(ids);
            return Ok(episodeResult);
        }

    }
}
