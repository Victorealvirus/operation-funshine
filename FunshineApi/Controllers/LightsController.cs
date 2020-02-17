using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FunshineLogic;

namespace FunshineApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LightsController : ControllerBase
    {
        private readonly ILogger<LightsController> _logger;

        public LightsController(ILogger<LightsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return new LifxControl().GetLights();
        }
        
        [HttpPost]
        [Route("Toggle")]
        public bool Toggle()
        {
            return new LifxControl().ToggleLights();
        }
    }
}
