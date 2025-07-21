using DnDBagOfHolding.Business.Api.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ServiceDefaults.Api
{
    [Route("api/items")]
    [ApiController]
    public class cItemsController : ControllerBase
    {
        private readonly iItemManager cItemManager;
        private readonly ILogger<cItemsController> cLogger;

        [HttpGet()]
        public async Task<HttpResponse> GetAll()
        {
            var items = await cItemManager.GetItems();

            return null;
        }

        [HttpGet("{id}")]
        public async Task<HttpResponse> GetById(long id)
        {
            return null;
        }
    }
}
