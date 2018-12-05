using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AOC.Domain.Models;
using AOC.Services;
using Microsoft.AspNetCore.Mvc;

namespace AOC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IAvailableDaysService availableDaysService;

        public HomeController(IAvailableDaysService availableDaysService)
        {
            this.availableDaysService = availableDaysService;
        }

        // GET api/home
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return null;
        }

        // GET api/home/available
        [HttpGet("available")]
        public ActionResult<int> Available()
        {
            return this.availableDaysService.GetAvailableYears();
        }
    }
}
