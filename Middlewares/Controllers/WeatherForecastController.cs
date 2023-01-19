using Microsoft.AspNetCore.Mvc;

namespace Middlewares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public String Get()
        {
            throw new Exception("Test hatasý");

            return "Ok";
        }
    }
}