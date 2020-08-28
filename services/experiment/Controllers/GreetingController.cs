using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace experiment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly ILogger<TilesController> _logger;

        public GreetingController(ILogger<TilesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            IList<string> greetings = new List<string>();

            var vals = new Color[4];

            for (int i = 0; i < vals.Length; ++i) {
                vals[i] = ColorPattern.PickRandom();
            }

            foreach (var val in vals) {
                greetings.Add(val.ToString());
            }

            return greetings.ToArray();
        }
    }
}
