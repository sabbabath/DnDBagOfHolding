using DnDBagOfHolding.Business.Api.Interfaces;
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
        public async Task<ActionResult<IEnumerable<cDtoContainerType>>> GetAll()
        {
            var containerTypes = await mContainerTypeManager.GetContainerTypes();
            return Ok(containerTypes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<cDtoContainerType>> GetById(long id)
        {
            var containerType = await mContainerTypeManager.GetContainerType(id);
            return Ok(containerType);
        }
    }
}
