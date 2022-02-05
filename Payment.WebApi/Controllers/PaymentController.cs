using Microsoft.AspNetCore.Mvc;

namespace Payment.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // GET: api/<PaymentController>
        [HttpGet]
        public string Get()
        {
            return "This Payment service";
        }
    }
}
