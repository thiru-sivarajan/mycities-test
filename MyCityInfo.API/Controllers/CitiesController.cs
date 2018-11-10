using Microsoft.AspNetCore.Mvc;
using MyCityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCityInfo.API.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
    }
}
