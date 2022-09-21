using Microsoft.AspNetCore.Mvc;

namespace DemoDatosRest.Controllers
{
    [ApiController]
    [Route("api/")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
         };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "passengers")]
        public IEnumerable<WeatherForecast> Gets()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        [Route("passengers")]
        public IEnumerable<Passengers> Get1()
        {
            Passengers[] result = new Passengers[5];
            result[0] = new Passengers("3fa85f64-5717-4562-b3fc-2c963f66afa6", "Juan", "Perez", "456");
            result[1] = new Passengers("3fa85f64-5717-4562-b3fc-2c963f66afa7", "Perer", "Mendoza", "2000");
            result[2] = new Passengers("3fa85f64-5717-4562-b3fc-2c963f66afa8", "Mendo", "Vilca", "123");
            result[3] = new Passengers("3fa85f64-5717-4562-b3fc-2c963f66afa9", "Marcos", "Vilca", "231");
            result[4] = new Passengers("3fa85f64-5717-4562-b3fc-2c963f66afa0", "Lucas", "Vilca", "321");


            return result;
        }
        [HttpGet]
        [Route("flights")]
        public IEnumerable<Flights> Get2()
        {
            Flights[] result = new Flights[3];
            result[0] = new Flights("3fa85f64-5717-4562-b3fc-2c963f66afb6", "LPZ", "CBBA" );
            result[1] = new Flights("3fa85f64-5717-4562-b3fc-2c963f66afb7", "SCZ", "LPZ");
            result[2] = new Flights("3fa85f64-5717-4562-b3fc-2c963f66afb8", "SCZ", "CBBA");


            return result;
        }
        [HttpGet]
        [Route("invoices")]
        public IEnumerable<Invoices> Get3()
        {
            Invoices[] result = new Invoices[5];
            result[0] = new Invoices("3fa85f64-5717-4562-b3fc-2c963f66afa8 ", "12345645", "3fa85f64-5717-4562-b3fc-2c963f66afa6", "R", "2022-08-12", "200.0", "3fa85f64-5717-4562-b3fc-2c963f66afb6");
            result[1] = new Invoices("3fa85f64-5717-4562-b3fc-2c963f66afa8 ", "12345645", "3fa85f64-5717-4562-b3fc-2c963f66afa7", "R", "2022-08-12", "200.0", "3fa85f64-5717-4562-b3fc-2c963f66afb7");
            result[2] = new Invoices("3fa85f64-5717-4562-b3fc-2c963f66afa8 ", "12345645", "3fa85f64-5717-4562-b3fc-2c963f66afa8", "R", "2022-08-12", "200.0", "3fa85f64-5717-4562-b3fc-2c963f66afb8");
            result[3] = new Invoices("3fa85f64-5717-4562-b3fc-2c963f66afa8 ", "12345645", "3fa85f64-5717-4562-b3fc-2c963f66afa9", "R", "2022-08-12", "200.0", "3fa85f64-5717-4562-b3fc-2c963f66afb6");
            result[4] = new Invoices("3fa85f64-5717-4562-b3fc-2c963f66afa8 ", "12345645", "3fa85f64-5717-4562-b3fc-2c963f66afa0", "R", "2022-08-12", "200.0", "3fa85f64-5717-4562-b3fc-2c963f66afb6");



            return result;
        }

    }
}