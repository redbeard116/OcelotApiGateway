using Microsoft.AspNetCore.Mvc;

namespace Product.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        [HttpGet]
        public string Get()
        {
            return "This Product service";
        }
    }
}
