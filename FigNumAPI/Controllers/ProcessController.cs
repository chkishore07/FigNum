using FigNumAPI.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace FigNumAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private IProcess _process;

        public ProcessController(IProcess process)
        {
            _process = process;
        }

        /// <summary>
        /// GET method to trim non prime numbers and non numbers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        [HttpGet]
        public string TrimPrimeNumbers(string numbers)
        {
            return string.Join(",", _process.NonPrimeNumbers(numbers).OrderBy(x => Convert.ToInt32(x)));
        }
    }
}
