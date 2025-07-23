using DnDBagOfHolding.Business.Api.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class cItemsController(iItemManager itemManager, ILogger<cItemsController> cLogger) : ControllerBase
    {
        private readonly iItemManager mItemManager = itemManager;

        private readonly ILogger<cItemsController> cLogger = cLogger;

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<cDtoItem>>> GetAll()
        {
            var items = await mItemManager.GetItems();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<cDtoItem>> GetById(long id)
        {
            var item = await mItemManager.GetItem(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }
    }
}
