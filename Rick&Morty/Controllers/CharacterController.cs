using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Filter;
using Service;

namespace Rick_Morty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {

        public IWebApiService _webapiService;
        public CharacterController(IWebApiService webApiService)
        {

            _webapiService = webApiService;
        }
        [HttpGet]
        public IActionResult Get()
        {


            var character = _webapiService.GetAllCharacter();
            return Ok(character);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var character = _webapiService.GetSingleCharacter(id);

            return Ok(character);
        }

        [HttpPost]
        [Route("Filter")]
        public IActionResult Get(CharacterFilter filter)
        {
            var characterResult = _webapiService.CharacterFilter(filter);
         
            return Ok(characterResult);
        }
        [HttpPost]
        [Route("Multiple")]
        public IActionResult Get(List<int> ids)
        {
           var characterResult= _webapiService.GetMultipleCharacter(ids);
            return Ok(characterResult);
        }

        //Pageleri getiren endpointler yazalım
    }
}
