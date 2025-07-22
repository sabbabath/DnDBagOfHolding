using DnDBagOfHolding.Business.Api.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class cItemsController : ControllerBase
    {
        private readonly iItemManager cItemManager;
        private readonly ILogger<cItemsController> cLogger;

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<cDtoItem>>> GetAll()
        {
            var items = await cItemManager.GetItems();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(long id)
        {
            var item = await cItemManager.GetItem(id);
            return Ok(item);
        }
    }
}
