using Microsoft.AspNetCore.Mvc;
using NumberToWordsAPI.Services;

namespace NumberToWordsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberToWordsController : ControllerBase
    {
        private readonly NumberToWordsService _service;

        public NumberToWordsController(NumberToWordsService service)
        {
            _service = service;
        }

        [HttpGet("Convert")]
        public IActionResult Convert([FromQuery] decimal number)
        {
            var result = _service.ConvertToWords(number);

            return Ok(result);
        }
    }
}