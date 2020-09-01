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

        private void Generate()
        {
            var vals = new int[4];
            vals[0] = 0; vals[1] = 1; vals[2] = 2; vals[3] = 3;

            var variations = new int[256, 4];
            int current = 0;

            for (int i = 0; i < vals.Length; ++i) {
                for (int j = 0; j < vals.Length; ++j) {
                    for (int k = 0; k < vals.Length; ++k) {
                        for (int l = 0; l < vals.Length; ++l) {
                            variations[current, 0] = i;
                            variations[current, 1] = j;
                            variations[current, 2] = k;
                            variations[current, 3] = l;
                        }
                    }
                }
            }
        }

        public void Rotate<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
        }

        private int Match(int[,] list, int[] target, int start)
        {
            for (int i = start; i < list.Length; ++i) {
                if (list[i,0] == target[0] && list[i,1] == target[1] &&
                    list[i,2] == target[2] && list[i,3] == target[3]) {
                    return i;
                }
            }

            return -1;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            IList<string> greetings = new List<string>();

            var vals = new Color[4];

            for (int i = 0; i < vals.Length; ++i) {
                vals[i] = ColorPattern.PickRandom();
            }

            for (int i = 0; i < vals.Length; ++i) {
                for (int j = 0; j < vals.Length; ++j) {
                    for (int k = 0; k < vals.Length; ++k) {
                        for (int l = 0; l < vals.Length; ++l) {
                            greetings.Add(i.ToString() + j.ToString() + k.ToString() + l.ToString());
                        }
                    }
                }
            }

            return greetings.ToArray();
        }
    }
}
