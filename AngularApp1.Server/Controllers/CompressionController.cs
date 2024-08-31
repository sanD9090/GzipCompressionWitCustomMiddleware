using System.Text.Json;
using AngularApp1.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularApp1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompressionController : ControllerBase
    {

        [HttpGet("CompressedResponse")]

        public IActionResult CompressedResponse()
        {

            string filePath = "C:\\Users\\Sandeep Pradhan\\source\\repos\\AngularApp1\\AngularApp1.Server\\Data\\responseData.json";
            string fileContent = System.IO.File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var persons = JsonSerializer.Deserialize<List<Person>>(fileContent, options);

            return Ok(persons);
        }

        [HttpGet("NonCompressedResponse")]

        public IActionResult NonCompressedResponse()
        {

            string filePath = "C:\\Users\\Sandeep Pradhan\\source\\repos\\AngularApp1\\AngularApp1.Server\\Data\\responseData.json";
            string fileContent = System.IO.File.ReadAllText(filePath);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var persons = JsonSerializer.Deserialize<List<Person>>(fileContent, options);

            return Ok(persons);
        }
    }
}
