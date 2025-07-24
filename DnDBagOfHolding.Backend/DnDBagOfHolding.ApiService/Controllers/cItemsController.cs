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

        [HttpPost]
        public async Task<ActionResult<cDtoItem>> Create([FromBody] cDtoItem item)
        {
            var createdItem = await mItemManager.CreateItem(item);
            return Ok(createdItem);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<cDtoItem>> Update([FromBody] cDtoItem item)
        {
            var updatedItem = await mItemManager.UpdateItem(item);
            return Ok(updatedItem);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await mItemManager.DeleteItem(id);
            return NoContent();
        }
    }
}
