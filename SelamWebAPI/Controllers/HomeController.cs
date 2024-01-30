using Microsoft.AspNetCore.Mvc;
using SelamWebAPI.Models;

namespace SelamWebAPI.Controllers
{
    [ApiController]    // Api Controller built-in functions, def. err pages/binding etc.
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        /*public ResponseModel GetMessage()
        {
            return new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Selam ASP.NET Core Web API"
            };
        }*/

        public IActionResult GetMessage()
        {
            var result = new ResponseModel()
            {
                HttpStatus = 200,
                Message = "Selam ASP.NET Core Web API"
            };

            return Ok(result); // Bu satırdaki method API'ye ait std. methodlar: BadRequest/NotFound vs. dönebilirdi.
                               // Status kodlar bu methoda göre şekillenir
        }
    }
}
