using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDBagOfHolding.ServiceDefaults.Api
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
