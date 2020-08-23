using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace experiment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TilesController : ControllerBase
    {
        private readonly ILogger<TilesController> _logger;

        public TilesController(ILogger<TilesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Tile> Get()
        {
            IList<Tile> tiles = new List<Tile>();
            for (int i = 0; i < 64; i++)
            {
                tiles.Add(new Tile() { Id = $"tile_{i.ToString()}" });
            }

            return tiles.ToArray();
        }
    }
}
