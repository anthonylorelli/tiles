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

        private int[,] Generate()
        {
            int rowSize = 4;
            var variations = new int[256, rowSize];
            int current = 0;

            for (int i = 0; i < rowSize; ++i) {
                for (int j = 0; j < rowSize; ++j) {
                    for (int k = 0; k < rowSize; ++k) {
                        for (int l = 0; l < rowSize; ++l) {
                            variations[current, 0] = i;
                            variations[current, 1] = j;
                            variations[current, 2] = k;
                            variations[current, 3] = l;
                            ++current;
                        }
                    }
                }
            }

            return variations;
        }

        public void Rotate<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);
        }

        private bool Match(int[,] list, int index, int[] target)
        {
            return  (list[index,0] == target[0] && list[index,1] == target[1] &&
                    list[index,2] == target[2] && list[index,3] == target[3]);
        }

        private string Find(int[,] list, int[] target, int start)
        {
            string result = start.ToString() + " [" + target[0] + "," + target[1] + "," + 
                target[2] + "," + target[3] + "] ";
            for (int i = start + 1; i < list.GetLength(0); ++i) {
                for (int k = 0; k < 4; Rotate(target, 1), ++k) {
                    if (Match(list, i, target)) {
                        result += i + " ";
                    }
                }
            }

            return result;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            IList<string> greetings = new List<string>();

            // var vals = new Color[4];

            // for (int i = 0; i < vals.Length; ++i) {
            //     vals[i] = ColorPattern.PickRandom();
            // }

            var list = Generate();

            for (int i = 0; i < list.GetLength(0); ++i) {
                int[] target = new int[] {list[i,0], list[i,1], list[i,2], list[i,3]};
                greetings.Add(Find(list, target, i));
            }

            return greetings.ToArray();
        }
    }
}
