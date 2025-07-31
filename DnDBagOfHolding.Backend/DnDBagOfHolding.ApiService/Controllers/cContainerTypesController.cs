using DnDBagOfHolding.Business.Interfaces;
using DnDBagOfHolding.Common.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DnDBagOfHolding.ApiService.Controllers
{
    [Route("api/containerTypes")]
    [ApiController]
    public class cContainerTypesController(iContainerTypeManager containerTypeManager, ILogger<cContainerTypesController> cLogger) : ControllerBase
    {
        private readonly iContainerTypeManager mContainerTypeManager = containerTypeManager;

        private readonly ILogger<cContainerTypesController> cLogger = cLogger;

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<rDtoContainerType>>> GetAll()
        {
            var containerTypes = await mContainerTypeManager.GetContainerTypes();
            return Ok(containerTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<rDtoContainerType>> GetById(long id)
        {
            var containerType = await mContainerTypeManager.GetContainerType(id);
            return Ok(containerType);
        }

        [HttpPost]
        public async Task<ActionResult<rDtoContainerType>> Create([FromBody] rDtoContainerType containerType)
        {
            var createdType = await mContainerTypeManager.CreateContainerType(containerType);
            return Ok(createdType);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<rDtoContainerType>> Update([FromBody] rDtoContainerType containerType)
        {
            var updatedType = await mContainerTypeManager.UpdateContainerType(containerType);
            return Ok(updatedType);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await mContainerTypeManager.DeleteContainerType(id);
            return NoContent();
        }
    }
}
