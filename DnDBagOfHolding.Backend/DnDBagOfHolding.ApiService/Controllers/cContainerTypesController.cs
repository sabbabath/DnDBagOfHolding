using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/containerTypes")]
    [ApiController]
    public class cContainerTypesController : ControllerBase
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
