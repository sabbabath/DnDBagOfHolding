using DnDBagOfHolding.Business.Api.Interfaces;
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
    }
}
