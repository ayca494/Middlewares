using Microsoft.AspNetCore.Mvc;
using Middlewares.Models;

namespace Middlewares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public String Get()
        {
            //throw new Exception("Test hatas�");

            return "Ok";
        }

        [HttpGet("Student")]
        public Student GetStudent()
        {
            return new Student()
            {
                ID = 1,
                FullName = "Ay�a"
            };
        }

        [HttpPost("Student")]
        public String CreateStudent([FromBody]Student student)
        {
            return "��renci olu�turuldu.";
        }
    }
}