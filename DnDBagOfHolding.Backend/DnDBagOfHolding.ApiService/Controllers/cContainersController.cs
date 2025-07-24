using DnDBagOfHolding.Business.Api.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/containers")]
    [ApiController]
    public class cContainersController(iContainerManager containerManager, ILogger<cContainersController> cLogger) : ControllerBase
    {
        private readonly iContainerManager mContainerManager = containerManager;

        private readonly ILogger<cContainersController> cLogger = cLogger;

        [HttpGet()]
        public async Task<ActionResult> GetAll()
        {
            var containers = await mContainerManager.GetContainers();
            return Ok(containers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(long id)
        {
            var container = await mContainerManager.GetContainer(id);
            if (container == null)
            {
                return NotFound();
            }
            return Ok(container);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] cDtoContainer container)
        {
            var createdContainer = await mContainerManager.CreateContainer(container);
            return Ok(createdContainer);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody] cDtoContainer container)
        {
            var updatedContainer = await mContainerManager.UpdateContainer(container);
            return Ok(updatedContainer);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await mContainerManager.DeleteContainer(id);
            return NoContent();
        }
    }
}
