using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class cCharactersController : ControllerBase
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
