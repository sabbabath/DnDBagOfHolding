using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/containers")]
    [ApiController]
    public class cContainersController : ControllerBase
    {

        [HttpGet()]
        public async Task<HttpResponse> GetAll()
        {
            return null;
        }

        [HttpGet("{id}")]
        public async Task<HttpResponse> GetById(long id)
        {
            return null;
        }
    }
}
