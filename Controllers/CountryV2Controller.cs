using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelListing.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    public class CountryV2Controller : Controller
    {
        [Route("api/[controller]")]
        [ApiController]
        public class CountryController : ControllerBase
        {
            private readonly DatabaseContext _databaseContext;

            public CountryController(DatabaseContext databaseContext)
            {
                _databaseContext = databaseContext;
            }

            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status500InternalServerError)]
            public IActionResult GetCountries()
            {
                return (Ok(_databaseContext.Countries));
            }
        }
    }
}