﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace Rick_Morty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public IWebApiService _webapiService;
        public LocationController(IWebApiService webApiService)
        {

            _webapiService = webApiService;
        }
        [HttpGet]
        public IActionResult Get()
        {


            var character = _webapiService.GetAllLocation();
            return Ok(character);
        }
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            var character = _webapiService.GetSingleLocation(id);

            return Ok(character);
        }
    }
}